// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	StripLinesCollection class is used to expose stripes
//              or lines on the plotting area and is exposed through
//              StripLines property of each Axis.
//              Each StripLine class presents one or series of
//              repeated axis horizontal or vertical strips within
//              the plotting are.
//              When multiple strip lines are defined for an axis,
//              there is a possibility of overlap. The z-order of
//              StripLine objects is determined by their order of
//              occurrence in the StripLinesCollection object. The
//              z-order follows this convention, the first occurrence
//              is drawn first, the second occurrence is drawn second,
//              and so on.
//              Highlighting weekends on date axis is a good example
//              of using strip lines with interval.
//


using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting.Utilities;
using System.Windows.Forms.Design.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// The StripLinesCollection class is a strongly typed collection of
/// StripLine classes.
/// </summary>
[
SRDescription("DescriptionAttributeStripLinesCollection_StripLinesCollection"),

]
public class StripLinesCollection : ChartElementCollection<StripLine>
{

	#region Constructor
	/// <summary>
	/// Legend item collection object constructor
	/// </summary>
	/// <param name="axis">Axis object reference.</param>
	internal StripLinesCollection(Axis axis)
		: base(axis)
	{
	}
	#endregion


}

/// <summary>
/// The StripLine class contains properties which define visual appearance
/// of the stripe or line, its position according to the axis.  It
/// may optionally contain the repeat interval. Text may associate
/// with a strip or a line.  It also contains methods of drawing and hit
/// testing.
/// </summary>
[
	SRDescription("DescriptionAttributeStripLine_StripLine"),
	DefaultProperty("IntervalOffset"),
]
public class StripLine : ChartElement
{

	#region Fields

	// Private data members, which store properties values
	internal DateTimeIntervalType _intervalOffsetType = DateTimeIntervalType.Auto;
	internal bool _interlaced = false;

	// Strip/Line title properties
	private FontCache _fontCache = new();
	private Font _font = null;

	// Chart image map properties

	// Default text orientation

	#endregion

	#region Properties
	/// <summary>
	/// Gets axes to which this object attached to.
	/// </summary>
	/// <returns>Axis object reference.</returns>
	internal Axis Axis
	{
		get
		{
			if (Parent != null)
			{
				return Parent.Parent as Axis;
			}
			else
			{
				return null;
			}
		}
	}
	#endregion

	#region Constructors

	/// <summary>
	/// Strip line object constructor.
	/// </summary>
	public StripLine()
			: base()
	{
		_font = _fontCache.DefaultFont;
	}

	#endregion

	#region Painting methods

	/// <summary>
	/// Checks if chart title is drawn vertically.
	/// Note: From the drawing perspective stacked text orientation is not vertical.
	/// </summary>
	/// <returns>True if text is vertical.</returns>
	private bool IsTextVertical
	{
		get
		{
			TextOrientation currentTextOrientation = GetTextOrientation();
			return currentTextOrientation == TextOrientation.Rotated90 || currentTextOrientation == TextOrientation.Rotated270;
		}
	}

	/// <summary>
	/// Returns stripline text orientation. If set to Auto automatically determines the
	/// orientation based on the orientation of the stripline.
	/// </summary>
	/// <returns>Current text orientation.</returns>
	private TextOrientation GetTextOrientation()
	{
		if (TextOrientation == TextOrientation.Auto && Axis != null)
		{
			if (Axis.AxisPosition == AxisPosition.Bottom || Axis.AxisPosition == AxisPosition.Top)
			{
				return TextOrientation.Rotated270;
			}

			return TextOrientation.Horizontal;
		}

		return TextOrientation;
	}

	/// <summary>
	/// Draw strip(s) or line(s).
	/// </summary>
	/// <param name="graph">Reference to the Chart Graphics object.</param>
	/// <param name="common">Common objects.</param>
	/// <param name="drawLinesOnly">Indicates if Lines or Stripes should be drawn.</param>
	internal void Paint(
		ChartGraphics graph,
		CommonElements common,
		bool drawLinesOnly)
	{
		// Strip lines are not supported in circular chart area
		if (Axis.ChartArea.chartAreaIsCurcular)
		{
			return;
		}

		// Get plot area position
		RectangleF plotAreaPosition = Axis.ChartArea.PlotAreaPosition.ToRectangleF();

		// Detect if strip/line is horizontal or vertical
		bool horizontal = true;
		if (Axis.AxisPosition == AxisPosition.Bottom || Axis.AxisPosition == AxisPosition.Top)
		{
			horizontal = false;
		}

		// Get first series attached to this axis
		Series axisSeries = null;
		if (Axis.axisType == AxisName.X || Axis.axisType == AxisName.X2)
		{
			List<string> seriesArray = Axis.ChartArea.GetXAxesSeries((Axis.axisType == AxisName.X) ? AxisType.Primary : AxisType.Secondary, Axis.SubAxisName);
			if (seriesArray.Count > 0)
			{
				axisSeries = Axis.Common.DataManager.Series[seriesArray[0]];
				if (axisSeries != null && !axisSeries.IsXValueIndexed)
				{
					axisSeries = null;
				}
			}
		}

		// Get starting position from axis
		// NOTE: Starting position was changed from "this.Axis.minimum" to
		// fix the minimum scaleView location to fix issue #5962 -- AG
		double currentPosition = Axis.ViewMinimum;

		// Adjust start position depending on the interval type
		if (!Axis.ChartArea.chartAreaIsCurcular ||
			Axis.axisType == AxisName.Y ||
			Axis.axisType == AxisName.Y2)
		{
			double intervalToUse = Interval;

			// NOTE: fix for issue #5962
			// Always use original grid interval for isInterlaced strip lines.
			if (_interlaced)
			{
				// Automaticly generated isInterlaced strips have interval twice as big as major grids
				intervalToUse /= 2.0;
			}

			currentPosition = ChartHelper.AlignIntervalStart(currentPosition, intervalToUse, IntervalType, axisSeries);
		}

		// Too many tick marks
		if (Interval != 0)
		{
			if ((Axis.ViewMaximum - Axis.ViewMinimum) / ChartHelper.GetIntervalSize(currentPosition, Interval, IntervalType, axisSeries, 0, DateTimeIntervalType.Number, false) > ChartHelper.MaxNumOfGridlines)
			{
				return;
			}
		}

		DateTimeIntervalType offsetType = (IntervalOffsetType == DateTimeIntervalType.Auto) ? IntervalType : IntervalOffsetType;
		if (Interval == 0)
		{
			currentPosition = IntervalOffset;
		}
		/******************************************************************
		 * Removed by AG. Causing issues with interalced strip lines.
		 /******************************************************************
		else if(axisSeries != null && axisSeries.IsXValueIndexed)
		{
			// Align first position for indexed series
			currentPosition += this.Axis.AlignIndexedIntervalStart(
				currentPosition,
				this.Interval,
				this.IntervalType,
				axisSeries,
				this.IntervalOffset,
				offsetType,
				false);
		}
		*/
		else
		{
			if (IntervalOffset > 0)
			{
				currentPosition += ChartHelper.GetIntervalSize(currentPosition, IntervalOffset,
				offsetType, axisSeries, 0, DateTimeIntervalType.Number, false);
			}
			else if (IntervalOffset < 0)
			{
				currentPosition -= ChartHelper.GetIntervalSize(currentPosition, -IntervalOffset,
				offsetType, axisSeries, 0, DateTimeIntervalType.Number, false);
			}
		}

		// Draw several lines or strips if Interval property is set
		int counter = 0;
		do
		{
			// Check if we do not exceed max number of elements
			if (counter++ > ChartHelper.MaxNumOfGridlines)
			{
				break;
			}

			// Draw strip
			if (StripWidth > 0 && !drawLinesOnly)
			{
				double stripRightPosition = currentPosition + ChartHelper.GetIntervalSize(currentPosition, StripWidth, StripWidthType, axisSeries, IntervalOffset, offsetType, false);
				if (stripRightPosition > Axis.ViewMinimum && currentPosition < Axis.ViewMaximum)
				{
					// Calculate strip rectangle
					RectangleF rect = RectangleF.Empty;
					double pos1 = (float)Axis.GetLinearPosition(currentPosition);
					double pos2 = (float)Axis.GetLinearPosition(stripRightPosition);
					if (horizontal)
					{
						rect.X = plotAreaPosition.X;
						rect.Width = plotAreaPosition.Width;
						rect.Y = (float)Math.Min(pos1, pos2);
						rect.Height = (float)Math.Max(pos1, pos2) - rect.Y;

						// Check rectangle boundaries
						rect.Intersect(plotAreaPosition);
					}
					else
					{
						rect.Y = plotAreaPosition.Y;
						rect.Height = plotAreaPosition.Height;
						rect.X = (float)Math.Min(pos1, pos2);
						rect.Width = (float)Math.Max(pos1, pos2) - rect.X;

						// Check rectangle boundaries
						rect.Intersect(plotAreaPosition);
					}

					if (rect.Width > 0 && rect.Height > 0)
					{

						// Start Svg Selection mode
						graph.StartHotRegion("", ToolTip);
						if (!Axis.ChartArea.Area3DStyle.Enable3D)
						{
							// Draw strip
							graph.FillRectangleRel(rect,
								BackColor, BackHatchStyle, BackImage,
								BackImageWrapMode, BackImageTransparentColor, BackImageAlignment,
								BackGradientStyle, BackSecondaryColor, BorderColor,
								BorderWidth, BorderDashStyle, Color.Empty,
								0, PenAlignment.Inset);
						}
						else
						{
							Draw3DStrip(graph, rect, horizontal);
						}

						// End Svg Selection mode
						graph.EndHotRegion();

						// Draw strip line title
						PaintTitle(graph, rect);

						if (common.ProcessModeRegions)
						{
							if (!Axis.ChartArea.Area3DStyle.Enable3D)
							{
								common.HotRegionsList.AddHotRegion(rect, ToolTip, string.Empty, string.Empty, string.Empty, this, ChartElementType.StripLines, null);
							}
						}
					}

				}
			}
			// Draw line
			else if (StripWidth == 0 && drawLinesOnly)
			{
				if (currentPosition > Axis.ViewMinimum && currentPosition < Axis.ViewMaximum)
				{
					// Calculate line position
					PointF point1 = PointF.Empty;
					PointF point2 = PointF.Empty;
					if (horizontal)
					{
						point1.X = plotAreaPosition.X;
						point1.Y = (float)Axis.GetLinearPosition(currentPosition);
						point2.X = plotAreaPosition.Right;
						point2.Y = point1.Y;
					}
					else
					{
						point1.X = (float)Axis.GetLinearPosition(currentPosition);
						point1.Y = plotAreaPosition.Y;
						point2.X = point1.X;
						point2.Y = plotAreaPosition.Bottom;
					}

					// Start Svg Selection mode
					graph.StartHotRegion("", ToolTip);

					// Draw Line
					if (!Axis.ChartArea.Area3DStyle.Enable3D)
					{
						graph.DrawLineRel(BorderColor, BorderWidth, BorderDashStyle, point1, point2);
					}
					else
					{
						graph.Draw3DGridLine(Axis.ChartArea, BorderColor, BorderWidth, BorderDashStyle, point1, point2, horizontal, Axis.Common, this);
					}

					// End Svg Selection mode
					graph.EndHotRegion();

					// Draw strip line title
					PaintTitle(graph, point1, point2);

					if (common.ProcessModeRegions)
					{
						SizeF relBorderWidth = new(BorderWidth + 1, BorderWidth + 1);
						relBorderWidth = graph.GetRelativeSize(relBorderWidth);
						RectangleF lineRect = RectangleF.Empty;
						if (horizontal)
						{
							lineRect.X = point1.X;
							lineRect.Y = point1.Y - relBorderWidth.Height / 2f;
							lineRect.Width = point2.X - point1.X;
							lineRect.Height = relBorderWidth.Height;
						}
						else
						{
							lineRect.X = point1.X - relBorderWidth.Width / 2f;
							lineRect.Y = point1.Y;
							lineRect.Width = relBorderWidth.Width;
							lineRect.Height = point2.Y - point1.Y;
						}

						common.HotRegionsList.AddHotRegion(lineRect, ToolTip, null, null, null, this, ChartElementType.StripLines, null);
					}
				}
			}

			// Go to the next line/strip
			if (Interval > 0)
			{
				currentPosition += ChartHelper.GetIntervalSize(currentPosition, Interval, IntervalType, axisSeries, IntervalOffset, offsetType, false);
			}

		} while (Interval > 0 && currentPosition <= Axis.ViewMaximum);
	}

	/// <summary>
	/// Draws strip line in 3d.
	/// </summary>
	/// <param name="graph">Chart graphics.</param>
	/// <param name="rect">Strip rectangle.</param>
	/// <param name="horizontal">Indicates that strip is horizontal</param>
	private void Draw3DStrip(ChartGraphics graph, RectangleF rect, bool horizontal)
	{
		ChartArea area = Axis.ChartArea;
		DrawingOperationTypes operationType = DrawingOperationTypes.DrawElement;

		if (Axis.Common.ProcessModeRegions)
		{
			operationType |= DrawingOperationTypes.CalcElementPath;
		}

		// Draw strip on the back/front wall
		GraphicsPath path = graph.Fill3DRectangle(
			rect,
				area.IsMainSceneWallOnFront() ? area.areaSceneDepth : 0f,
				0,
				area.matrix3D,
				area.Area3DStyle.LightStyle,
			BackColor,
				BorderColor,
			BorderWidth,
				BorderDashStyle,
			operationType);

		if (Axis.Common.ProcessModeRegions)
		{
			Axis.Common.HotRegionsList.AddHotRegion(graph, path, false, ToolTip, null, null, null, this, ChartElementType.StripLines);
		}

		if (horizontal)
		{
			// Draw strip on the side wall (left or right)
			if (!area.IsSideSceneWallOnLeft())
			{
				rect.X = rect.Right;
			}

			rect.Width = 0f;

			path = graph.Fill3DRectangle(
				rect,
					0f,
					area.areaSceneDepth,
					area.matrix3D,
					area.Area3DStyle.LightStyle,
				BackColor,
					BorderColor,
				BorderWidth,
					BorderDashStyle,
				operationType);

		}
		else if (area.IsBottomSceneWallVisible())
		{
			// Draw strip on the bottom wall (if visible)
			rect.Y = rect.Bottom;
			rect.Height = 0f;

			path = graph.Fill3DRectangle(
				rect,
					0f,
					area.areaSceneDepth,
					area.matrix3D,
					area.Area3DStyle.LightStyle,
				BackColor,
					BorderColor,
				BorderWidth,
					BorderDashStyle,
				operationType);
		}

		if (Axis.Common.ProcessModeRegions)
		{
			Axis.Common.HotRegionsList.AddHotRegion(graph, path, false, ToolTip, null, null, null, this, ChartElementType.StripLines);
		}

		path?.Dispose();
	}

	/// <summary>
	/// Draw strip/line title text
	/// </summary>
	/// <param name="graph">Chart graphics object.</param>
	/// <param name="point1">First line point.</param>
	/// <param name="point2">Second line point.</param>
	private void PaintTitle(ChartGraphics graph, PointF point1, PointF point2)
	{
		if (Text.Length > 0)
		{
			// Define a rectangle to draw the title
			RectangleF rect = RectangleF.Empty;
			rect.X = point1.X;
			rect.Y = point1.Y;
			rect.Height = point2.Y - rect.Y;
			rect.Width = point2.X - rect.X;

			// Paint title using a rect
			PaintTitle(graph, rect);
		}
	}

	/// <summary>
	/// Draw strip/line title text
	/// </summary>
	/// <param name="graph">Chart graphics object.</param>
	/// <param name="rect">Rectangle to draw in.</param>
	private void PaintTitle(ChartGraphics graph, RectangleF rect)
	{
		if (Text.Length > 0)
		{
			// Get title text
			string titleText = Text;

			// Prepare string format
			using StringFormat format = new();
			format.Alignment = TextAlignment;

			if (graph.IsRightToLeft)
			{
				if (format.Alignment == StringAlignment.Far)
				{
					format.Alignment = StringAlignment.Near;
				}
				else if (format.Alignment == StringAlignment.Near)
				{
					format.Alignment = StringAlignment.Far;
				}
			}

			format.LineAlignment = TextLineAlignment;

			// Adjust default title angle for horizontal lines
			int angle = 0;
			switch (TextOrientation)
			{
				case (TextOrientation.Rotated90):
					angle = 90;
					break;
				case (TextOrientation.Rotated270):
					angle = 270;
					break;
				case (TextOrientation.Auto):
					if (Axis.AxisPosition == AxisPosition.Bottom || Axis.AxisPosition == AxisPosition.Top)
					{
						angle = 270;
					}

					break;
			}

			// Set vertical text for horizontal lines
			if (angle == 90)
			{
				format.FormatFlags = StringFormatFlags.DirectionVertical;
				angle = 0;
			}
			else if (angle == 270)
			{
				format.FormatFlags = StringFormatFlags.DirectionVertical;
				angle = 180;
			}

			// Measure string size
			SizeF size = graph.MeasureStringRel(titleText.Replace("\\n", "\n"), Font, new SizeF(100, 100), format, GetTextOrientation());

			// Adjust text size
			float zPositon = 0f;
			if (Axis.ChartArea.Area3DStyle.Enable3D)
			{
				// Get projection coordinates
				Point3D[] textSizeProjection = new Point3D[3];
				zPositon = Axis.ChartArea.IsMainSceneWallOnFront() ? Axis.ChartArea.areaSceneDepth : 0f;
				textSizeProjection[0] = new Point3D(0f, 0f, zPositon);
				textSizeProjection[1] = new Point3D(size.Width, 0f, zPositon);
				textSizeProjection[2] = new Point3D(0f, size.Height, zPositon);

				// Transform coordinates of text size
				Axis.ChartArea.matrix3D.TransformPoints(textSizeProjection);

				// Adjust text size
				int index = Axis.ChartArea.IsMainSceneWallOnFront() ? 0 : 1;
				size.Width *= size.Width / (textSizeProjection[index].X - textSizeProjection[(index == 0) ? 1 : 0].X);
				size.Height *= size.Height / (textSizeProjection[2].Y - textSizeProjection[0].Y);
			}


			// Get relative size of the border width
			SizeF sizeBorder = graph.GetRelativeSize(new SizeF(BorderWidth, BorderWidth));

			// Find the center of rotation
			PointF rotationCenter = PointF.Empty;
			if (format.Alignment == StringAlignment.Near)
			{ // Near
				rotationCenter.X = rect.X + size.Width / 2 + sizeBorder.Width;
			}
			else if (format.Alignment == StringAlignment.Far)
			{ // Far
				rotationCenter.X = rect.Right - size.Width / 2 - sizeBorder.Width;
			}
			else
			{ // Center
				rotationCenter.X = (rect.Left + rect.Right) / 2;
			}

			if (format.LineAlignment == StringAlignment.Near)
			{ // Near
				rotationCenter.Y = rect.Top + size.Height / 2 + sizeBorder.Height;
			}
			else if (format.LineAlignment == StringAlignment.Far)
			{ // Far
				rotationCenter.Y = rect.Bottom - size.Height / 2 - sizeBorder.Height;
			}
			else
			{ // Center
				rotationCenter.Y = (rect.Bottom + rect.Top) / 2;
			}

			// Reset string alignment to center point
			format.Alignment = StringAlignment.Center;
			format.LineAlignment = StringAlignment.Center;

			if (Axis.ChartArea.Area3DStyle.Enable3D)
			{
				// Get projection coordinates
				Point3D[] rotationCenterProjection = new Point3D[2];
				rotationCenterProjection[0] = new Point3D(rotationCenter.X, rotationCenter.Y, zPositon);
				if (format.FormatFlags == StringFormatFlags.DirectionVertical)
				{
					rotationCenterProjection[1] = new Point3D(rotationCenter.X, rotationCenter.Y - 20f, zPositon);
				}
				else
				{
					rotationCenterProjection[1] = new Point3D(rotationCenter.X - 20f, rotationCenter.Y, zPositon);
				}

				// Transform coordinates of text rotation point
				Axis.ChartArea.matrix3D.TransformPoints(rotationCenterProjection);

				// Adjust rotation point
				rotationCenter = rotationCenterProjection[0].PointF;

				// Adjust angle of the text
				if (angle == 0 || angle == 180 || angle == 90 || angle == 270)
				{
					if (format.FormatFlags == StringFormatFlags.DirectionVertical)
					{
						angle += 90;
					}

					// Convert coordinates to absolute
					rotationCenterProjection[0].PointF = graph.GetAbsolutePoint(rotationCenterProjection[0].PointF);
					rotationCenterProjection[1].PointF = graph.GetAbsolutePoint(rotationCenterProjection[1].PointF);

					// Calcuate axis angle
					float angleXAxis = (float)Math.Atan(
						(rotationCenterProjection[1].Y - rotationCenterProjection[0].Y) /
						(rotationCenterProjection[1].X - rotationCenterProjection[0].X));
					angleXAxis = (float)Math.Round(angleXAxis * 180f / (float)Math.PI);
					angle += (int)angleXAxis;
				}
			}

			// Draw string
			using Brush brush = new SolidBrush(ForeColor);
			graph.DrawStringRel(
				titleText.Replace("\\n", "\n"),
				Font,
				brush,
				rotationCenter,
				format,
				angle,
				GetTextOrientation());
		}
	}

	#endregion

	#region	Strip line properties

	/// <summary>
	/// Gets or sets the text orientation.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(TextOrientation.Auto),
	SRDescription("DescriptionAttribute_TextOrientation"),
	NotifyParentProperty(true)
	]
	public TextOrientation TextOrientation
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = TextOrientation.Auto;

	/// <summary>
	/// Gets or sets the strip or line starting position offset.
	/// </summary>
	[
	SRCategory("CategoryAttributeData"),
	Bindable(true),
	DefaultValue(0.0),
	SRDescription("DescriptionAttributeStripLine_IntervalOffset"),
	TypeConverter(typeof(AxisLabelDateValueConverter))
	]
	public double IntervalOffset
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = 0;

	/// <summary>
	/// Gets or sets the unit of measurement of the strip or line offset.
	/// </summary>
	[
	SRCategory("CategoryAttributeData"),
	Bindable(true),
	DefaultValue(DateTimeIntervalType.Auto),
	SRDescription("DescriptionAttributeStripLine_IntervalOffsetType"),
	RefreshProperties(RefreshProperties.All)
	]
	public DateTimeIntervalType IntervalOffsetType
	{
		get
		{
			return _intervalOffsetType;
		}
		set
		{
			_intervalOffsetType = (value != DateTimeIntervalType.NotSet) ? value : DateTimeIntervalType.Auto;
			Invalidate();
		}
	}

	/// <summary>
	/// Gets or sets the strip or line step size.
	/// </summary>
	[
	SRCategory("CategoryAttributeData"),
	Bindable(true),
	DefaultValue(0.0),
	RefreshProperties(RefreshProperties.All),
	SRDescription("DescriptionAttributeStripLine_Interval")
	]
	public double Interval
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = 0;

	/// <summary>
	/// Gets or sets the unit of measurement of the strip or line step.
	/// </summary>
	[
	SRCategory("CategoryAttributeData"),
	Bindable(true),
	DefaultValue(DateTimeIntervalType.Auto),
	SRDescription("DescriptionAttributeStripLine_IntervalType"),
	RefreshProperties(RefreshProperties.All)
	]
	public DateTimeIntervalType IntervalType
	{
		get;
		set
		{
			field = (value != DateTimeIntervalType.NotSet) ? value : DateTimeIntervalType.Auto;
			Invalidate();
		}
	} = DateTimeIntervalType.Auto;

	/// <summary>
	/// Gets or sets the strip width.
	/// </summary>
	[
	SRCategory("CategoryAttributeData"),
	Bindable(true),
	DefaultValue(0.0),
	SRDescription("DescriptionAttributeStripLine_StripWidth")
	]
	public double StripWidth
	{
		get;
		set
		{
			if (value < 0)
			{
				throw (new ArgumentException(SR.ExceptionStripLineWidthIsNegative, nameof(value)));
			}

			field = value;
			Invalidate();
		}
	} = 0;

	/// <summary>
	/// Gets or sets the unit of measurement of the strip width.
	/// </summary>
	[
	SRCategory("CategoryAttributeData"),
	Bindable(true),
	DefaultValue(DateTimeIntervalType.Auto),
	SRDescription("DescriptionAttributeStripLine_StripWidthType"),
	RefreshProperties(RefreshProperties.All)
	]
	public DateTimeIntervalType StripWidthType
	{
		get;
		set
		{
			field = (value != DateTimeIntervalType.NotSet) ? value : DateTimeIntervalType.Auto;
			Invalidate();
		}
	} = DateTimeIntervalType.Auto;

	/// <summary>
	/// Gets or sets the background color.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeBackColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BackColor
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the border color.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
		DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeBorderColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BorderColor
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the border style.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(ChartDashStyle.Solid),
		SRDescription("DescriptionAttributeBorderDashStyle")
	]
	public ChartDashStyle BorderDashStyle
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = ChartDashStyle.Solid;

	/// <summary>
	/// Gets or sets the border width.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(1),
		SRDescription("DescriptionAttributeBorderWidth")
	]
	public int BorderWidth
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = 1;

	/// <summary>
	/// Gets or sets the background image.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(""),
		SRDescription("DescriptionAttributeBackImage"),
		Editor(typeof(ImageValueEditor), typeof(UITypeEditor)),
		NotifyParentProperty(true)
	]
	public string BackImage
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = "";

	/// <summary>
	/// Gets or sets the background image drawing mode.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(ChartImageWrapMode.Tile),
	NotifyParentProperty(true),
		SRDescription("DescriptionAttributeImageWrapMode")
	]
	public ChartImageWrapMode BackImageWrapMode
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = ChartImageWrapMode.Tile;

	/// <summary>
	/// Gets or sets a color which will be replaced with a transparent color while drawing the background image.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
	NotifyParentProperty(true),
		SRDescription("DescriptionAttributeImageTransparentColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BackImageTransparentColor
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the background image alignment used by unscale drawing mode.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(ChartImageAlignmentStyle.TopLeft),
	NotifyParentProperty(true),
		SRDescription("DescriptionAttributeBackImageAlign")
	]
	public ChartImageAlignmentStyle BackImageAlignment
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = ChartImageAlignmentStyle.TopLeft;

	/// <summary>
	/// Gets or sets the background gradient style.
	/// <seealso cref="BackSecondaryColor"/>
	/// <seealso cref="BackColor"/>
	/// <seealso cref="BackHatchStyle"/>
	/// </summary>
	/// <value>
	/// A <see cref="GradientStyle"/> value used for the background.
	/// </value>
	/// <remarks>
	/// Two colors are used to draw the gradient, <see cref="BackColor"/> and <see cref="BackSecondaryColor"/>.
	/// </remarks>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(GradientStyle.None),
		SRDescription("DescriptionAttributeBackGradientStyle"),
		Editor(typeof(GradientEditor), typeof(UITypeEditor))
		]
	public GradientStyle BackGradientStyle
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = GradientStyle.None;

	/// <summary>
	/// Gets or sets the secondary background color.
	/// <seealso cref="BackColor"/>
	/// <seealso cref="BackHatchStyle"/>
	/// <seealso cref="BackGradientStyle"/>
	/// </summary>
	/// <value>
	/// A <see cref="Color"/> value used for the secondary color of a background with
	/// hatching or gradient fill.
	/// </value>
	/// <remarks>
	/// This color is used with <see cref="BackColor"/> when <see cref="BackHatchStyle"/> or
	/// <see cref="BackGradientStyle"/> are used.
	/// </remarks>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeBackSecondaryColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BackSecondaryColor
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the background hatch style.
	/// <seealso cref="BackSecondaryColor"/>
	/// <seealso cref="BackColor"/>
	/// <seealso cref="BackGradientStyle"/>
	/// </summary>
	/// <value>
	/// A <see cref="ChartHatchStyle"/> value used for the background.
	/// </value>
	/// <remarks>
	/// Two colors are used to draw the hatching, <see cref="BackColor"/> and <see cref="BackSecondaryColor"/>.
	/// </remarks>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(ChartHatchStyle.None),
		SRDescription("DescriptionAttributeBackHatchStyle"),
		Editor(typeof(HatchStyleEditor), typeof(UITypeEditor))
		]
	public ChartHatchStyle BackHatchStyle
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = ChartHatchStyle.None;

	/// <summary>
	/// Gets or sets the name of the strip line.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(false),
	Browsable(false),
	DefaultValue("StripLine"),
	SRDescription("DescriptionAttributeStripLine_Name"),
	DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
	SerializationVisibility(SerializationVisibility.Hidden)
	]
	public string Name
	{
		get
		{
			return "StripLine";
		}
	}

	/// <summary>
	/// Gets or sets the title text of the strip line.
	/// </summary>
	[
	SRCategory("CategoryAttributeTitle"),
	Bindable(true),
	DefaultValue(""),
	SRDescription("DescriptionAttributeStripLine_Title"),
	NotifyParentProperty(true)
	]
	public string Text
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = "";

	/// <summary>
	/// Gets or sets the fore color of the strip line.
	/// </summary>
	[
	SRCategory("CategoryAttributeTitle"),
	Bindable(true),
	DefaultValue(typeof(Color), "Black"),
	SRDescription("DescriptionAttributeStripLine_TitleColor"),
	NotifyParentProperty(true),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color ForeColor
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = Color.Black;

	/// <summary>
	/// Gets or sets the text alignment of the strip line.
	/// </summary>
	[
	SRCategory("CategoryAttributeTitle"),
	Bindable(true),
	DefaultValue(typeof(StringAlignment), "Far"),
	SRDescription("DescriptionAttributeStripLine_TitleAlignment"),
	NotifyParentProperty(true)
	]
	public StringAlignment TextAlignment
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = StringAlignment.Far;

	/// <summary>
	/// Gets or sets the text line alignment of the strip line.
	/// </summary>
	[
	SRCategory("CategoryAttributeTitle"),
	Bindable(true),
	DefaultValue(typeof(StringAlignment), "Near"),
	SRDescription("DescriptionAttributeStripLine_TitleLineAlignment"),
	NotifyParentProperty(true)
	]
	public StringAlignment TextLineAlignment
	{
		get;
		set
		{
			field = value;
			Invalidate();
		}
	} = StringAlignment.Near;

	/// <summary>
	/// Gets or sets the title font.
	/// </summary>
	[
	SRCategory("CategoryAttributeTitle"),
	Bindable(true),
	DefaultValue(typeof(Font), "Microsoft Sans Serif, 8pt"),
		SRDescription("DescriptionAttributeTitleFont"),
	NotifyParentProperty(true)
	]
	public Font Font
	{
		get
		{
			return _font;
		}
		set
		{
			_font = value;
			Invalidate();
		}
	}


	/// <summary>
	/// Gets or sets the tooltip.
	/// </summary>
	[
	SRCategory("CategoryAttributeMapArea"),

		Bindable(true),
		SRDescription("DescriptionAttributeToolTip"),
	DefaultValue("")
	]
	public string ToolTip
	{
		set
		{
			Invalidate();
			field = value;
		}
		get;
	} = "";

	#endregion


	#region Invalidation methods

	/// <summary>
	/// Invalidate chart area
	/// </summary>
	private new void Invalidate() => Axis?.Invalidate();

	#endregion

	#region IDisposable Members

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_fontCache?.Dispose();
			_fontCache = null;
		}

		base.Dispose(disposing);
	}


	#endregion
}
