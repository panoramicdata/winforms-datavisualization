// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	A cursor is a horizontal or vertical line that 
//              defines a position along an axis. A range selection 
//              is a range along an axis that is defined by a beginning 
//              and end position, and is displayed using a semi-transparent 
//              color.
//              Both cursors and range selections are implemented by the 
//              Cursor class, which is exposed as the CursorX and CursorY 
//              properties of the ChartArea object. The CursorX object is 
//              for the X axis of a chart area, and the CursorY object is 
//              for the Y axis. The AxisType property of these objects 
//              determines if the associated axis is primary or secondary.
//              Cursors and range selections can be set via end-user 
//              interaction and programmatically.
//


using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// The Cursor class is responsible for chart axes cursor and selection 
/// functionality. It contains properties which define visual appearance, 
/// position and behavior settings. It also contains methods for 
/// drawing cursor and selection in the plotting area.
/// </summary>
[
DefaultProperty("Enabled"),
SRDescription("DescriptionAttributeCursor_Cursor"),
]
public class Cursor : IDisposable
{
	#region Cursor constructors and initialization

	/// <summary>
	/// Public constructor
	/// </summary>
	public Cursor()
	{
	}

	/// <summary>
	/// Initialize cursor class.
	/// </summary>
	/// <param name="chartArea">Chart area the cursor belongs to.</param>
	/// <param name="attachedToXAxis">Indicates which axes should be used X or Y.</param>
	internal void Initialize(ChartArea chartArea, AxisName attachedToXAxis)
	{
		// Set chart are reference
		_chartArea = chartArea;

		// Attach cursor to specified axis
		_attachedToXAxis = attachedToXAxis;
	}

	#endregion

	#region Cursor fields

	// Reference to the chart area object the cursor belongs to
	private ChartArea _chartArea = null;

	// Defines which axis the cursor attached to X or Y
	private AxisName _attachedToXAxis = AxisName.X;

	// Enables/Disables chart area cursor.

	// Enables/Disables chart area selection.

	// Indicates that cursor will automatically scroll the area scaleView if necessary.

	// Cursor line color

	// Cursor line width

	// Cursor line style

	// Chart area selection color

	// AxisName of the axes (primary/secondary) the cursor is attached to

	// Cursor position

	// Range selection start position.
	private double _selectionStart = double.NaN;

	// Range selection end position.
	private double _selectionEnd = double.NaN;

	// Cursor movement interval current & original values

	// Cursor movement interval type

	// Cursor movement interval offset current & original values

	// Cursor movement interval offset type

	// Reference to the axis obhect
	private Axis _axis = null;

	// User selection start point
	private PointF _userSelectionStart = PointF.Empty;

	// Indicates that selection must be drawn
	private bool _drawSelection = true;

	// Indicates that events must be fired when position/selection is changed
	private bool _fireUserChangingEvent = false;

	// Indicates that XXXChanged events must be fired when position/selection is changed
	private bool _fireUserChangedEvent = false;

	// Scroll size and direction when AutoScroll is set
	private MouseEventArgs _mouseMoveArguments = null;

	// Timer used to scroll the data while selecting
	private Timer _scrollTimer = new();

	// Indicates that axis data scaleView was scrolled as a result of the mouse move event
	private bool _viewScrolledOnMouseMove = false;

	#endregion

	#region Cursor "Behavior" public properties.

	/// <summary>
	/// Gets or sets the position of a cursor.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(double.NaN),
	SRDescription("DescriptionAttributeCursor_Position"),
	ParenthesizePropertyName(true),
		TypeConverter(typeof(DoubleDateNanValueConverter)),
	]
	public double Position { get; set
		{
			if (field != value)
			{
				field = value;

				// Align cursor in connected areas
				if (_chartArea != null && _chartArea.Common != null && _chartArea.Common.ChartPicture != null)
				{
					if (!_chartArea.alignmentInProcess)
					{
						AreaAlignmentOrientations orientation = (_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
							AreaAlignmentOrientations.Vertical : AreaAlignmentOrientations.Horizontal;
						_chartArea.Common.ChartPicture.AlignChartAreasCursor(_chartArea, orientation, false);
					}
				}

				if (_chartArea != null && !_chartArea.alignmentInProcess)
				{
					Invalidate(false);
				}

			}
		} } = double.NaN;

	/// <summary>
	/// Gets or sets the starting position of a cursor's selected range. 
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(double.NaN),
	SRDescription("DescriptionAttributeCursor_SelectionStart"),
		TypeConverter(typeof(DoubleDateNanValueConverter)),
	]
	public double SelectionStart
	{
		get
		{
			return _selectionStart;
		}
		set
		{
			if (_selectionStart != value)
			{
				_selectionStart = value;

				// Align cursor in connected areas
				if (_chartArea != null && _chartArea.Common != null && _chartArea.Common.ChartPicture != null)
				{
					if (!_chartArea.alignmentInProcess)
					{
						AreaAlignmentOrientations orientation = (_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
							AreaAlignmentOrientations.Vertical : AreaAlignmentOrientations.Horizontal;
						_chartArea.Common.ChartPicture.AlignChartAreasCursor(_chartArea, orientation, false);
					}
				}

				if (_chartArea != null && !_chartArea.alignmentInProcess)
				{
					Invalidate(false);
				}

			}
		}
	}

	/// <summary>
	/// Gets or sets the ending position of a range selection.  
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(double.NaN),
	SRDescription("DescriptionAttributeCursor_SelectionEnd"),
		TypeConverter(typeof(DoubleDateNanValueConverter)),
	]
	public double SelectionEnd
	{
		get
		{
			return _selectionEnd;
		}
		set
		{
			if (_selectionEnd != value)
			{
				_selectionEnd = value;

				// Align cursor in connected areas
				if (_chartArea != null && _chartArea.Common != null && _chartArea.Common.ChartPicture != null)
				{
					if (!_chartArea.alignmentInProcess)
					{
						AreaAlignmentOrientations orientation = (_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
							AreaAlignmentOrientations.Vertical : AreaAlignmentOrientations.Horizontal;
						_chartArea.Common.ChartPicture.AlignChartAreasCursor(_chartArea, orientation, false);
					}
				}

				if (_chartArea != null && !_chartArea.alignmentInProcess)
				{
					Invalidate(false);
				}
			}
		}
	}

	/// <summary>
	/// Gets or sets a property that enables or disables the cursor interface.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(false),
	SRDescription("DescriptionAttributeCursor_UserEnabled"),
	]
	public bool IsUserEnabled { get; set; } = false;

	/// <summary>
	/// Gets or sets a property that enables or disables the range selection interface.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(false),
		SRDescription("DescriptionAttributeCursor_UserSelection"),
	]
	public bool IsUserSelectionEnabled { get; set; } = false;

	/// <summary>
	/// Determines if scrolling will occur if a range selection operation 
	/// extends beyond a boundary of the chart area.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(true),
	SRDescription("DescriptionAttributeCursor_AutoScroll"),
	]
	public bool AutoScroll { get; set; } = true;

	/// <summary>
	///  Gets or sets the type of axis that the cursor is attached to.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	SRDescription("DescriptionAttributeCursor_AxisType"),
		DefaultValue(AxisType.Primary)
	]
	public AxisType AxisType { get; set
		{
			field = value;

			// Reset reference to the axis object
			_axis = null;

			Invalidate(true);
		} } = AxisType.Primary;

	/// <summary>
	/// Gets or sets the cursor movement interval.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(1.0),
	SRDescription("DescriptionAttributeCursor_Interval"),
	]
	public double Interval { get; set; } = 1;

	/// <summary>
	/// Gets or sets the unit of measurement of the Interval property.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(DateTimeIntervalType.Auto),
		SRDescription("DescriptionAttributeCursor_IntervalType")
	]
	public DateTimeIntervalType IntervalType { get; set
		{
			field = (value != DateTimeIntervalType.NotSet) ? value : DateTimeIntervalType.Auto;
		} } = DateTimeIntervalType.Auto;


	/// <summary>
	/// Gets or sets the interval offset, which determines 
	/// where to draw the cursor and range selection.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(0.0),
		SRDescription("DescriptionAttributeCursor_IntervalOffset"),
	]
	public double IntervalOffset { get; set
		{
			// Validation
			if (value < 0.0)
			{
				throw (new ArgumentException(SR.ExceptionCursorIntervalOffsetIsNegative, nameof(value)));
			}

			field = value;
		} } = 0;

	/// <summary>
	/// Gets or sets the unit of measurement of the IntervalOffset property.
	/// </summary>
	[
	SRCategory("CategoryAttributeBehavior"),
	Bindable(true),
	DefaultValue(DateTimeIntervalType.Auto),
		SRDescription("DescriptionAttributeCursor_IntervalOffsetType"),
	]
	public DateTimeIntervalType IntervalOffsetType { get; set
		{
			field = (value != DateTimeIntervalType.NotSet) ? value : DateTimeIntervalType.Auto;
		} } = DateTimeIntervalType.Auto;
	#endregion

	#region Cursor "Appearance" public properties

	/// <summary>
	/// Gets or sets the color the cursor line.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), "Red"),
		SRDescription("DescriptionAttributeLineColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor)),
		]
	public Color LineColor { get; set
		{
			field = value;
			Invalidate(false);
		} } = Color.Red;

	/// <summary>
	/// Gets or sets the style of the cursor line.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(ChartDashStyle.Solid),
		SRDescription("DescriptionAttributeLineDashStyle"),
	]
	public ChartDashStyle LineDashStyle { get; set
		{
			field = value;
			Invalidate(false);
		} } = ChartDashStyle.Solid;

	/// <summary>
	/// Gets or sets the width of the cursor line.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(1),
		SRDescription("DescriptionAttributeLineWidth"),
	]
	public int LineWidth { get; set
		{
			if (value < 0)
			{
				throw (new ArgumentOutOfRangeException(nameof(value), SR.ExceptionCursorLineWidthIsNegative));
			}

			field = value;
			Invalidate(true);
		} } = 1;

	/// <summary>
	/// Gets or sets a semi-transparent color that highlights a range of data.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), "LightGray"),
	SRDescription("DescriptionAttributeCursor_SelectionColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color SelectionColor { get; set
		{
			field = value;
			Invalidate(false);
		} } = Color.LightGray;

	#endregion

	#region Cursor painting methods

	/// <summary>
	/// Draws chart area cursor and selection.
	/// </summary>
	/// <param name="graph">Reference to the ChartGraphics object.</param>
	internal void Paint(ChartGraphics graph)
	{
		//***************************************************
		//** Prepare for drawing
		//***************************************************

		// Do not proceed with painting if cursor is not attached to the axis
		if (GetAxis() == null ||
			_chartArea == null ||
			_chartArea.Common == null ||
			_chartArea.Common.ChartPicture == null ||
			_chartArea.Common.ChartPicture._isPrinting)
		{
			return;
		}

		// Get plot area position
		RectangleF plotAreaPosition = _chartArea.PlotAreaPosition.ToRectangleF();

		// Detect if cursor is horizontal or vertical
		bool horizontal = true;
		if (GetAxis().AxisPosition == AxisPosition.Bottom || GetAxis().AxisPosition == AxisPosition.Top)
		{
			horizontal = false;
		}

		//***************************************************
		//** Draw selection
		//***************************************************

		// Check if selection need to be drawn
		if (_drawSelection &&
			!double.IsNaN(SelectionStart) &&
			!double.IsNaN(SelectionEnd) &&
			SelectionColor != Color.Empty)
		{
			// Calculate selection rectangle
			RectangleF rectSelection = GetSelectionRect(plotAreaPosition);
			rectSelection.Intersect(plotAreaPosition);

			// Get opposite axis selection rectangle
			RectangleF rectOppositeSelection = GetOppositeSelectionRect(plotAreaPosition);

			// Draw selection if rectangle is not empty
			if (!rectSelection.IsEmpty && rectSelection.Width > 0 && rectSelection.Height > 0)
			{
				// Limit selection rectangle to the area of the opposite selection
				if (!rectOppositeSelection.IsEmpty && rectOppositeSelection.Width > 0 && rectOppositeSelection.Height > 0)
				{
					rectSelection.Intersect(rectOppositeSelection);

					// We do not need to draw selection in the opposite axis 
					Cursor oppositeCursor =
						(_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
						_chartArea.CursorY : _chartArea.CursorX;
					oppositeCursor._drawSelection = false;
				}

				// Make sure selection is inside plotting area
				rectSelection.Intersect(plotAreaPosition);

				// If selection rectangle is not empty
				if (rectSelection.Width > 0 && rectSelection.Height > 0)
				{
					// Add transparency to solid colors
					Color rangeSelectionColor = SelectionColor;
					if (rangeSelectionColor.A == 255)
					{
						rangeSelectionColor = Color.FromArgb(120, rangeSelectionColor);
					}

					// Draw selection
					graph.FillRectangleRel(rectSelection,
						rangeSelectionColor,
						ChartHatchStyle.None,
						"",
						ChartImageWrapMode.Tile,
						Color.Empty,
						ChartImageAlignmentStyle.Center,
						GradientStyle.None,
						Color.Empty,
						Color.Empty,
						0,
						ChartDashStyle.NotSet,
						Color.Empty,
						0,
						PenAlignment.Inset);
				}
			}
		}

		//***************************************************
		//** Draw cursor
		//***************************************************

		// Check if cursor need to be drawn
		if (!double.IsNaN(Position) &&
			LineColor != Color.Empty &&
			LineWidth > 0 &&
			LineDashStyle != ChartDashStyle.NotSet)
		{
			// Calculate line position
			bool insideArea = false;
			PointF point1 = PointF.Empty;
			PointF point2 = PointF.Empty;
			if (horizontal)
			{
				// Set cursor coordinates
				point1.X = plotAreaPosition.X;
				point1.Y = (float)GetAxis().GetLinearPosition(Position);
				point2.X = plotAreaPosition.Right;
				point2.Y = point1.Y;

				// Check if cursor is inside plotting rect
				if (point1.Y >= plotAreaPosition.Y && point1.Y <= plotAreaPosition.Bottom)
				{
					insideArea = true;
				}
			}
			else
			{
				// Set cursor coordinates
				point1.X = (float)GetAxis().GetLinearPosition(Position);
				point1.Y = plotAreaPosition.Y;
				point2.X = point1.X;
				point2.Y = plotAreaPosition.Bottom;

				// Check if cursor is inside plotting rect
				if (point1.X >= plotAreaPosition.X && point1.X <= plotAreaPosition.Right)
				{
					insideArea = true;
				}
			}

			// Draw cursor if it's inside the chart area plotting rectangle
			if (insideArea)
			{
				graph.DrawLineRel(LineColor, LineWidth, LineDashStyle, point1, point2);
			}
		}
		// Reset draw selection flag
		_drawSelection = true;
	}

	#endregion

	#region Cursor position setting methods

	/// <summary>
	/// This method sets the position of a cursor within a chart area at a given axis value.
	/// </summary>
	/// <param name="newPosition">The new position of the cursor.  Measured as a value along the relevant axis.</param>
	public void SetCursorPosition(double newPosition)
	{
		// Check if we are setting different value
		if (Position != newPosition)
		{
			double newRoundedPosition = RoundPosition(newPosition);
			// Send PositionChanging event
			if (_fireUserChangingEvent && GetChartObject() != null)
			{
				CursorEventArgs arguments = new(_chartArea, GetAxis(), newRoundedPosition);
				GetChartObject().OnCursorPositionChanging(arguments);

				// Check if position values were changed in the event
				newRoundedPosition = arguments.NewPosition;
			}

			// Change position
			Position = newRoundedPosition;

			// Send PositionChanged event
			if (_fireUserChangedEvent && GetChartObject() != null)
			{
				CursorEventArgs arguments = new(_chartArea, GetAxis(), Position);
				GetChartObject().OnCursorPositionChanged(arguments);
			}
		}
	}


	/// <summary>
	/// This method displays a cursor at the specified position.  Measured in pixels.
	/// </summary>
	/// <param name="point">A PointF structure that specifies where the cursor will be drawn.</param>
	/// <param name="roundToBoundary">If true, the cursor will be drawn along the nearest chart area boundary 
	/// when the specified position does not fall within a ChartArea object.</param>
	public void SetCursorPixelPosition(PointF point, bool roundToBoundary)
	{
		if (_chartArea != null && _chartArea.Common != null && GetAxis() != null)
		{
			PointF relativeCoord = GetPositionInPlotArea(point, roundToBoundary);
			if (!relativeCoord.IsEmpty)
			{
				// Get new cursor position
				double newCursorPosition = PositionToCursorPosition(relativeCoord);

				// Set new cursor & selection position
				SetCursorPosition(newCursorPosition);
			}
		}
	}

	/// <summary>
	/// This method sets the position of a selected range within a chart area at given axis values. 
	/// </summary>
	/// <param name="newStart">The new starting position of the range selection.  Measured as a value along the relevant axis..</param>
	/// <param name="newEnd">The new ending position of the range selection.  Measured as a value along the relevant axis.</param>
	public void SetSelectionPosition(double newStart, double newEnd)
	{
		// Check if we are setting different value
		if (SelectionStart != newStart || SelectionEnd != newEnd)
		{
			// Send PositionChanging event
			double newRoundedSelectionStart = RoundPosition(newStart);
			double newRoundedSelectionEnd = RoundPosition(newEnd);

			// Send SelectionRangeChanging event
			if (_fireUserChangingEvent && GetChartObject() != null)
			{
				CursorEventArgs arguments = new(_chartArea, GetAxis(), newRoundedSelectionStart, newRoundedSelectionEnd);
				GetChartObject().OnSelectionRangeChanging(arguments);

				// Check if position values were changed in the event
				newRoundedSelectionStart = arguments.NewSelectionStart;
				newRoundedSelectionEnd = arguments.NewSelectionEnd;
			}

			// Change selection position
			_selectionStart = newRoundedSelectionStart;
			_selectionEnd = newRoundedSelectionEnd;

			// Align cursor in connected areas
			if (_chartArea != null && _chartArea.Common != null && _chartArea.Common.ChartPicture != null)
			{
				if (!_chartArea.alignmentInProcess)
				{
					AreaAlignmentOrientations orientation = (_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
						AreaAlignmentOrientations.Vertical : AreaAlignmentOrientations.Horizontal;
					_chartArea.Common.ChartPicture.AlignChartAreasCursor(_chartArea, orientation, true);
				}
			}

			if (_chartArea != null && !_chartArea.alignmentInProcess)
			{
				Invalidate(false);
			}

			// Send SelectionRangeChanged event
			if (_fireUserChangedEvent && GetChartObject() != null)
			{
				CursorEventArgs arguments = new(_chartArea, GetAxis(), SelectionStart, SelectionEnd);
				GetChartObject().OnSelectionRangeChanged(arguments);
			}
		}
	}


	/// <summary>
	/// This method sets the starting and ending positions of a range selection.
	/// </summary>
	/// <param name="startPoint">A PointF structure that specifies where the range selection begins.</param>
	/// <param name="endPoint">A PointF structure that specifies where the range selection ends</param>
	/// <param name="roundToBoundary">If true, the starting and ending points will be rounded to the nearest chart area boundary 
	/// when the specified positions do not fall within a ChartArea object.</param>
	public void SetSelectionPixelPosition(PointF startPoint, PointF endPoint, bool roundToBoundary)
	{
		if (_chartArea != null && _chartArea.Common != null && GetAxis() != null)
		{
			// Calculating the start position
			double newStart = SelectionStart;
			if (!startPoint.IsEmpty)
			{
				PointF relativeCoord = GetPositionInPlotArea(startPoint, roundToBoundary);
				if (!relativeCoord.IsEmpty)
				{
					// Get new selection start position
					newStart = PositionToCursorPosition(relativeCoord);
				}
			}

			// Setting the end position
			double newEnd = newStart;
			if (!endPoint.IsEmpty)
			{
				PointF relativeCoord = GetPositionInPlotArea(endPoint, roundToBoundary);
				if (!relativeCoord.IsEmpty)
				{
					// Get new selection position
					newEnd = PositionToCursorPosition(relativeCoord);
				}
			}

			// Set new selection start & end position
			SetSelectionPosition(newStart, newEnd);
		}
	}

	#endregion

	#region Position rounding methods

	/// <summary>
	/// Rounds new position of the cursor or range selection
	/// </summary>
	/// <param name="cursorPosition"></param>
	/// <returns></returns>
	internal double RoundPosition(double cursorPosition)
	{
		double roundedPosition = cursorPosition;

		if (!double.IsNaN(roundedPosition))
		{
			// Check if position rounding is required
			if (GetAxis() != null &&
				Interval != 0 &&
					!double.IsNaN(Interval))
			{
				// Get first series attached to this axis
				Series axisSeries = null;
				if (_axis.axisType == AxisName.X || _axis.axisType == AxisName.X2)
				{
					List<string> seriesArray = _axis.ChartArea.GetXAxesSeries((_axis.axisType == AxisName.X) ? AxisType.Primary : AxisType.Secondary, _axis.SubAxisName);
					if (seriesArray.Count > 0)
					{
						string seriesName = seriesArray[0] as string;
						axisSeries = _axis.Common.DataManager.Series[seriesName];
						if (axisSeries != null && !axisSeries.IsXValueIndexed)
						{
							axisSeries = null;
						}
					}
				}

				// If interval type is not set - use number
				DateTimeIntervalType intervalType =
					(IntervalType == DateTimeIntervalType.Auto) ?
					DateTimeIntervalType.Number : IntervalType;

				// If interval offset type is not set - use interval type
				DateTimeIntervalType offsetType =
					(IntervalOffsetType == DateTimeIntervalType.Auto) ?
				intervalType : IntervalOffsetType;

				// Round numbers
				if (intervalType == DateTimeIntervalType.Number)
				{
					double newRoundedPosition = Math.Round(roundedPosition / Interval) * Interval;

					// Add offset number
					if (IntervalOffset != 0 &&
						!double.IsNaN(IntervalOffset) &&
						offsetType != DateTimeIntervalType.Auto)
					{
						if (IntervalOffset > 0)
						{
							newRoundedPosition += ChartHelper.GetIntervalSize(newRoundedPosition, IntervalOffset, offsetType);
						}
						else
						{
							newRoundedPosition -= ChartHelper.GetIntervalSize(newRoundedPosition, IntervalOffset, offsetType);
						}
					}

					// Find rounded position after/before the current
					double nextPosition = newRoundedPosition;
					if (newRoundedPosition <= cursorPosition)
					{
						nextPosition += ChartHelper.GetIntervalSize(newRoundedPosition, Interval, intervalType, axisSeries, 0, DateTimeIntervalType.Number, true);
					}
					else
					{
						nextPosition -= ChartHelper.GetIntervalSize(newRoundedPosition, Interval, intervalType, axisSeries, 0, DateTimeIntervalType.Number, true);
					}

					// Choose closest rounded position
					if (Math.Abs(nextPosition - cursorPosition) > Math.Abs(cursorPosition - newRoundedPosition))
					{
						roundedPosition = newRoundedPosition;
					}
					else
					{
						roundedPosition = nextPosition;
					}

				}

				// Round date/time
				else
				{
					// Find one rounded position prior and one after current position
					// Adjust start position depending on the interval and type
					double prevPosition = ChartHelper.AlignIntervalStart(cursorPosition, Interval, intervalType, axisSeries);

					// Adjust start position depending on the interval offset and offset type
					if (IntervalOffset != 0 && axisSeries == null)
					{
						if (IntervalOffset > 0)
						{
							prevPosition += ChartHelper.GetIntervalSize(
							prevPosition,
							IntervalOffset,
							offsetType,
							axisSeries,
							0,
							DateTimeIntervalType.Number,
							true);
						}
						else
						{
							prevPosition += ChartHelper.GetIntervalSize(
							prevPosition,
							-IntervalOffset,
							offsetType,
							axisSeries,
							0,
							DateTimeIntervalType.Number,
							true);
						}
					}

					// Find rounded position after/before the current
					double nextPosition = prevPosition;
					if (prevPosition <= cursorPosition)
					{
						nextPosition += ChartHelper.GetIntervalSize(prevPosition, Interval, intervalType, axisSeries, 0, DateTimeIntervalType.Number, true);
					}
					else
					{
						nextPosition -= ChartHelper.GetIntervalSize(prevPosition, Interval, intervalType, axisSeries, 0, DateTimeIntervalType.Number, true);
					}

					// Choose closest rounded position
					if (Math.Abs(nextPosition - cursorPosition) > Math.Abs(cursorPosition - prevPosition))
					{
						roundedPosition = prevPosition;
					}
					else
					{
						roundedPosition = nextPosition;
					}
				}
			}
		}

		return roundedPosition;
	}
	#endregion

	#region Mouse events handling for the Cursor

	/// <summary>
	/// Mouse down event handler.
	/// </summary>
	internal void Cursor_MouseDown(object sender, MouseEventArgs e)
	{
		// Set flag to fire position changing events
		_fireUserChangingEvent = true;
		_fireUserChangedEvent = false;

		// Check if left mouse button was clicked in chart area
		if (e.Button == MouseButtons.Left && !GetPositionInPlotArea(new PointF(e.X, e.Y), false).IsEmpty)
		{
			// Change cursor position and selection start position when mouse down
			if (IsUserEnabled)
			{
				SetCursorPixelPosition(new PointF(e.X, e.Y), false);
			}

			if (IsUserSelectionEnabled)
			{
				_userSelectionStart = new PointF(e.X, e.Y);
				SetSelectionPixelPosition(_userSelectionStart, PointF.Empty, false);
			}
		}

		// Clear flag to fire position changing events
		_fireUserChangingEvent = false;
		_fireUserChangedEvent = false;
	}

	/// <summary>
	/// Mouse up event handler.
	/// </summary>
	internal void Cursor_MouseUp(object sender, MouseEventArgs e)
	{
		// If in range selection mode
		if (!_userSelectionStart.IsEmpty)
		{
			// Stop timer
			_scrollTimer.Stop();
			_mouseMoveArguments = null;

			// Check if axis data scaleView zooming UI is enabled
			if (_axis != null &&
				_axis.ScaleView.Zoomable &&
				!double.IsNaN(SelectionStart) &&
				!double.IsNaN(SelectionEnd) &&
				SelectionStart != SelectionEnd)
			{
				// Zoom data scaleView
				double start = Math.Min(SelectionStart, SelectionEnd);
				double size = (double)Math.Max(SelectionStart, SelectionEnd) - start;
				bool zoomed = _axis.ScaleView.Zoom(start, size, DateTimeIntervalType.Number, true, true);

				// Clear image buffer
				if (_chartArea.areaBufferBitmap != null && zoomed)
				{
					_chartArea.areaBufferBitmap.Dispose();
					_chartArea.areaBufferBitmap = null;
				}

				// Clear range selection
				SelectionStart = double.NaN;
				SelectionEnd = double.NaN;

				// NOTE: Fixes issue #6823
				// Clear cursor position after the zoom in operation
				Position = double.NaN;

				// Align cursor in connected areas
				if (_chartArea != null && _chartArea.Common != null && _chartArea.Common.ChartPicture != null)
				{
					if (!_chartArea.alignmentInProcess)
					{
						AreaAlignmentOrientations orientation = (_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
							AreaAlignmentOrientations.Vertical : AreaAlignmentOrientations.Horizontal;
						_chartArea.Common.ChartPicture.AlignChartAreasZoomed(_chartArea, orientation, zoomed);
					}
				}
			}

			// Fire XXXChanged events
			if (GetChartObject() != null)
			{
				CursorEventArgs arguments = new(_chartArea, GetAxis(), SelectionStart, SelectionEnd);
				GetChartObject().OnSelectionRangeChanged(arguments);

				arguments = new CursorEventArgs(_chartArea, GetAxis(), Position);
				GetChartObject().OnCursorPositionChanged(arguments);
			}

			// Stop range selection mode
			_userSelectionStart = PointF.Empty;
		}
	}

	/// <summary>
	/// Mouse move event handler.
	/// </summary>
	internal void Cursor_MouseMove(MouseEventArgs e, ref bool handled)
	{
		// Process range selection
		if (_userSelectionStart != PointF.Empty)
		{
			// Mouse move event should not be handled by any other chart elements
			handled = true;

			// Set flag to fire position changing events
			_fireUserChangingEvent = true;
			_fireUserChangedEvent = false;

			// Check if mouse position is outside of the chart area and if not - try scrolling
			if (AutoScroll)
			{
				if (_chartArea != null && _chartArea.Common != null && GetAxis() != null)
				{
					// Check if axis data scaleView is enabled
					if (!double.IsNaN(_axis.ScaleView.Position) && !double.IsNaN(_axis.ScaleView.Size))
					{
						ScrollType scrollType = ScrollType.SmallIncrement;
						bool insideChartArea = true;
						double offsetFromBoundary = 0.0;

						// Translate mouse pixel coordinates into the relative chart area coordinates
						float mouseX = e.X * 100F / ((float)(_chartArea.Common.Width - 1));
						float mouseY = e.Y * 100F / ((float)(_chartArea.Common.Height - 1));

						// Check if coordinate is inside chart plotting area
						if (_axis.AxisPosition == AxisPosition.Bottom || _axis.AxisPosition == AxisPosition.Top)
						{
							if (mouseX < _chartArea.PlotAreaPosition.X)
							{
								scrollType = ScrollType.SmallDecrement;
								insideChartArea = false;
								offsetFromBoundary = _chartArea.PlotAreaPosition.X - mouseX;
							}
							else if (mouseX > _chartArea.PlotAreaPosition.Right)
							{
								scrollType = ScrollType.SmallIncrement;
								insideChartArea = false;
								offsetFromBoundary = mouseX - _chartArea.PlotAreaPosition.Right;
							}
						}
						else
						{
							if (mouseY < _chartArea.PlotAreaPosition.Y)
							{
								scrollType = ScrollType.SmallIncrement;
								insideChartArea = false;
								offsetFromBoundary = _chartArea.PlotAreaPosition.Y - mouseY;
							}
							else if (mouseY > _chartArea.PlotAreaPosition.Bottom)
							{
								scrollType = ScrollType.SmallDecrement;
								insideChartArea = false;
								offsetFromBoundary = mouseY - _chartArea.PlotAreaPosition.Bottom;
							}
						}

						// Try scrolling scaleView position
						if (!insideChartArea)
						{
							// Set flag that data scaleView was scrolled
							_viewScrolledOnMouseMove = true;

							// Get minimum scroll interval
							double scrollInterval = ChartHelper.GetIntervalSize(
							_axis.ScaleView.Position,
							_axis.ScaleView.GetScrollingLineSize(),
							_axis.ScaleView.GetScrollingLineSizeType());
							offsetFromBoundary *= 2;
							if (offsetFromBoundary > scrollInterval)
							{
								scrollInterval = ((int)(offsetFromBoundary / scrollInterval)) * scrollInterval;
							}

							// Scroll axis data scaleView
							double newDataViewPosition = _axis.ScaleView.Position;
							if (scrollType == ScrollType.SmallIncrement)
							{
								newDataViewPosition += scrollInterval;
							}
							else
							{
								newDataViewPosition -= scrollInterval;
							}

							// Scroll axis data scaleView
							_axis.ScaleView.Scroll(newDataViewPosition);

							// Save last mouse move arguments
							_mouseMoveArguments = new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, e.Delta);

							// Start selection scrolling timer
							if (!_scrollTimer.Enabled)
							{
								// Start timer
								_scrollTimer.Tick += new EventHandler(SelectionScrollingTimerEventProcessor);
								_scrollTimer.Interval = 200;
								_scrollTimer.Start();
							}
						}
						else
						{
							// Stop timer
							_scrollTimer.Stop();
							_mouseMoveArguments = null;
						}
					}
				}
			}

			// Change cursor position and selection end position when mouse moving
			if (IsUserEnabled)
			{
				SetCursorPixelPosition(new PointF(e.X, e.Y), true);
			}

			if (IsUserSelectionEnabled)
			{
				// Set selection
				SetSelectionPixelPosition(PointF.Empty, new PointF(e.X, e.Y), true);
			}

			// Clear flag to fire position changing events
			_fireUserChangingEvent = false;
			_fireUserChangedEvent = false;

			// Clear flag that data scaleView was scrolled
			_viewScrolledOnMouseMove = false;

		}
	}

	/// <summary>
	/// This is the method to run when the timer is raised.
	/// Used to scroll axis data scaleView while mouse is outside of the chart area.
	/// </summary>
	/// <param name="myObject"></param>
	/// <param name="myEventArgs"></param>
	private void SelectionScrollingTimerEventProcessor(object myObject, EventArgs myEventArgs)
	{
		// Simulate mouse move events
		if (_mouseMoveArguments != null)
		{
			bool handled = false;
			Cursor_MouseMove(_mouseMoveArguments, ref handled);
		}
	}

	#endregion

	#region Cursor helper methods

	/// <summary>
	/// Helper function which returns a reference to the chart object
	/// </summary>
	/// <returns>Chart object reference.</returns>
	private Chart GetChartObject()
	{
		if (_chartArea != null)
		{
			return _chartArea.Chart;
		}

		return null;
	}

	/// <summary>
	/// Get rectangle of the axis range selection.
	/// </summary>
	/// <returns>Selection rectangle.</returns>
	/// <param name="plotAreaPosition">Plot area rectangle.</param>
	/// <returns></returns>
	private RectangleF GetSelectionRect(RectangleF plotAreaPosition)
	{
		RectangleF rect = RectangleF.Empty;

		if (_axis != null &&
			SelectionStart != SelectionEnd)
		{
			double start = (float)_axis.GetLinearPosition(SelectionStart);
			double end = (float)_axis.GetLinearPosition(SelectionEnd);

			// Detect if cursor is horizontal or vertical
			bool horizontal = true;
			if (GetAxis().AxisPosition == AxisPosition.Bottom || GetAxis().AxisPosition == AxisPosition.Top)
			{
				horizontal = false;
			}

			if (horizontal)
			{
				rect.X = plotAreaPosition.X;
				rect.Width = plotAreaPosition.Width;
				rect.Y = (float)Math.Min(start, end);
				rect.Height = (float)Math.Max(start, end) - rect.Y;
			}
			else
			{
				rect.Y = plotAreaPosition.Y;
				rect.Height = plotAreaPosition.Height;
				rect.X = (float)Math.Min(start, end);
				rect.Width = (float)Math.Max(start, end) - rect.X;
			}
		}

		return rect;
	}

	/// <summary>
	/// Get rectangle of the opposite axis selection
	/// </summary>
	/// <param name="plotAreaPosition">Plot area rectangle.</param>
	/// <returns>Opposite selection rectangle.</returns>
	private RectangleF GetOppositeSelectionRect(RectangleF plotAreaPosition)
	{
		if (_chartArea != null)
		{
			// Get opposite cursor 
			Cursor oppositeCursor =
				(_attachedToXAxis == AxisName.X || _attachedToXAxis == AxisName.X2) ?
				_chartArea.CursorY : _chartArea.CursorX;
			return oppositeCursor.GetSelectionRect(plotAreaPosition);
		}

		return RectangleF.Empty;
	}

	/// <summary>
	/// Converts X or Y position value to the cursor axis value
	/// </summary>
	/// <param name="position">Position in relative coordinates.</param>
	/// <returns>Cursor position as axis value.</returns>
	private double PositionToCursorPosition(PointF position)
	{
		// Detect if cursor is horizontal or vertical
		bool horizontal = true;
		if (GetAxis().AxisPosition == AxisPosition.Bottom || GetAxis().AxisPosition == AxisPosition.Top)
		{
			horizontal = false;
		}

		// Convert relative coordinates into axis values
		double newCursorPosition;
		if (horizontal)
		{
			newCursorPosition = GetAxis().PositionToValue(position.Y);
		}
		else
		{
			newCursorPosition = GetAxis().PositionToValue(position.X);
		}

		// Round new position using Step & StepType properties
		newCursorPosition = RoundPosition(newCursorPosition);

		return newCursorPosition;
	}


	/// <summary>
	/// Checks if specified point is located inside the plotting area.
	/// Converts pixel coordinates to relative.
	/// </summary>
	/// <param name="point">Point coordinates to test.</param>
	/// <param name="roundToBoundary">Indicates that coordinates must be rounded to area boundary.</param>
	/// <returns>PointF.IsEmpty or relative coordinates in plotting area.</returns>
	private PointF GetPositionInPlotArea(PointF point, bool roundToBoundary)
	{
		PointF result = PointF.Empty;

		if (_chartArea != null && _chartArea.Common != null && GetAxis() != null)
		{
			// Translate mouse pixel coordinates into the relative chart area coordinates
			result.X = point.X * 100F / ((float)(_chartArea.Common.Width - 1));
			result.Y = point.Y * 100F / ((float)(_chartArea.Common.Height - 1));

			// Round coordinate if it' outside chart plotting area
			RectangleF plotAreaPosition = _chartArea.PlotAreaPosition.ToRectangleF();
			if (roundToBoundary)
			{
				if (result.X < plotAreaPosition.X)
				{
					result.X = plotAreaPosition.X;
				}

				if (result.X > plotAreaPosition.Right)
				{
					result.X = plotAreaPosition.Right;
				}

				if (result.Y < plotAreaPosition.Y)
				{
					result.Y = plotAreaPosition.Y;
				}

				if (result.Y > plotAreaPosition.Bottom)
				{
					result.Y = plotAreaPosition.Bottom;
				}
			}
			else
			{
				// Check if coordinate is inside chart plotting area
				if (result.X < plotAreaPosition.X ||
					result.X > plotAreaPosition.Right ||
					result.Y < plotAreaPosition.Y ||
					result.Y > plotAreaPosition.Bottom)
				{
					result = PointF.Empty;
				}
			}
		}

		return result;
	}

	/// <summary>
	/// Invalidate chart are with the cursor.
	/// </summary>
	/// <param name="invalidateArea">Chart area must be invalidated.</param>
	private void Invalidate(bool invalidateArea)
	{
		if (GetChartObject() != null && _chartArea != null && !GetChartObject().disableInvalidates)
		{
			// If data scaleView was scrolled - just invalidate the chart area
			if (_viewScrolledOnMouseMove || invalidateArea || GetChartObject().dirtyFlag)
			{
				_chartArea.Invalidate();
			}

			// If only cursor/selection position was changed - use optimized drawing algorithm
			else
			{
				// Set flag to redraw cursor/selection only
				GetChartObject().paintTopLevelElementOnly = true;

				// Invalidate and update the chart
				_chartArea.Invalidate();
				GetChartObject().Update();

				// Clear flag to redraw cursor/selection only
				GetChartObject().paintTopLevelElementOnly = false;
			}
		}
	}

	/// <summary>
	/// Gets axis objects the cursor is attached to.
	/// </summary>
	/// <returns>Axis object.</returns>
	internal Axis GetAxis()
	{
		if (_axis == null && _chartArea != null)
		{
			if (_attachedToXAxis == AxisName.X)
			{
				_axis = (AxisType == AxisType.Primary) ? _chartArea.AxisX : _chartArea.AxisX2;
			}
			else
			{
				_axis = (AxisType == AxisType.Primary) ? _chartArea.AxisY : _chartArea.AxisY2;
			}
		}

		return _axis;
	}

	#endregion

	#region IDisposable Members

	/// <summary>
	/// Releases unmanaged and - optionally - managed resources
	/// </summary>
	/// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			// Dispose managed resources
			_scrollTimer?.Dispose();
			_scrollTimer = null;
		}
	}

	/// <summary>
	/// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
	/// </summary>
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	#endregion
}

/// <summary>
/// The CursorEventArgs class stores the event arguments for cursor and selection events.
/// </summary>
public class CursorEventArgs : EventArgs
{
	#region Private fields

	// Private fields for properties values storage

	#endregion

	#region Constructors

	/// <summary>
	/// CursorEventArgs constructor.
	/// </summary>
	/// <param name="chartArea">ChartArea of the cursor.</param>
	/// <param name="axis">Axis of the cursor.</param>
	/// <param name="newPosition">New cursor position.</param>
	public CursorEventArgs(ChartArea chartArea, Axis axis, double newPosition)
	{
		ChartArea = chartArea;
		Axis = axis;
		NewPosition = newPosition;
		NewSelectionStart = double.NaN;
		NewSelectionEnd = double.NaN;
	}

	/// <summary>
	/// CursorEventArgs constructor.
	/// </summary>
	/// <param name="chartArea">ChartArea of the cursor.</param>
	/// <param name="axis">Axis of the cursor.</param>
	/// <param name="newSelectionStart">New range selection starting position.</param>
	/// <param name="newSelectionEnd">New range selection ending position.</param>
	public CursorEventArgs(ChartArea chartArea, Axis axis, double newSelectionStart, double newSelectionEnd)
	{
		ChartArea = chartArea;
		Axis = axis;
		NewPosition = double.NaN;
		NewSelectionStart = newSelectionStart;
		NewSelectionEnd = newSelectionEnd;
	}

	#endregion

	#region Properties

	/// <summary>
	/// ChartArea of the event.
	/// </summary>
	[
	SRDescription("DescriptionAttributeChartArea"),
	]
	public ChartArea ChartArea { get; } = null;

	/// <summary>
	/// Axis of the event.
	/// </summary>
	[
	SRDescription("DescriptionAttributeAxis"),
	]
	public Axis Axis { get; } = null;

	/// <summary>
	/// New cursor position.
	/// </summary>
	[
	SRDescription("DescriptionAttributeCursorEventArgs_NewPosition"),
	]
	public double NewPosition { get; set; } = double.NaN;

	/// <summary>
	/// New range selection starting position.
	/// </summary>
	[
	SRDescription("DescriptionAttributeCursorEventArgs_NewSelectionStart"),
	]
	public double NewSelectionStart { get; set; } = double.NaN;

	/// <summary>
	/// New range selection ending position.
	/// </summary>
	[
	SRDescription("DescriptionAttributeCursorEventArgs_NewSelectionEnd"),
	]
	public double NewSelectionEnd { get; set; } = double.NaN;

	#endregion
}
