// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	AxisScrollBar class represent axis scroolbar. There
//              is a big difference how this UI  functionality
//              implemented for Windows Forms and ASP.NET. For
//              Windows Forms a custom drawn scrollbar control is
//              drawn in the chart which reacts to the mouse input and
//              changes current axis data scaleView.
//


using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting.Utilities;
using System.Windows.Forms.Design.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting;

#region Scroll bar enumerations

/// <summary>
/// An enumeration of scrollbar button types.
/// </summary>
public enum ScrollBarButtonType
{
	/// <summary>
	/// Thumb tracker button.
	/// </summary>
	ThumbTracker,

	/// <summary>
	/// Scroll by substracting small distance.
	/// </summary>
	SmallDecrement,

	/// <summary>
	/// Scroll by adding small distance.
	/// </summary>
	SmallIncrement,

	/// <summary>
	/// Scroll by substracting large distance.
	/// </summary>
	LargeDecrement,

	/// <summary>
	/// Scroll by adding large distance.
	/// </summary>
	LargeIncrement,

	/// <summary>
	/// Zoom reset button.
	/// </summary>
	ZoomReset
}

/// <summary>
/// An enumeration of scrollbar button style flags.
/// </summary>
[Flags]
public enum ScrollBarButtonStyles
{
	/// <summary>
	/// No buttons are shown.
	/// </summary>
	None = 0,

	/// <summary>
	/// Small increment or decrement buttons are shown.
	/// </summary>
	SmallScroll = 1,

	/// <summary>
	/// Reset zoom buttons are shown.
	/// </summary>
	ResetZoom = 2,

	/// <summary>
	/// All buttons are shown.
	/// </summary>
	All = SmallScroll | ResetZoom
}

#endregion

/// <summary>
/// AxisScrollBar class represents the axis scrollbar. It is exposed as the
/// ScrollBar property of the Axis class. It contains scrollbar appearance
/// properties and drawing methods.
/// </summary>
public class AxisScrollBar : IDisposable
{
	#region Scroll bar fields

	// Reference to the axis data scaleView class
	internal Axis _axis = null;

	// Indicates that scollbra will be drawn

	// Axis data scaleView scroll bar style

	// Axis data scaleView scroll bar size

	// Index of the pressed butoon in the scroll bar
	private int _pressedButtonType = int.MaxValue;

	// Axis data scaleView scroll bar buttons color

	// Axis data scaleView scroll bar back color

	// Axis data scaleView scroll bar lines color

	// Current scroll bar drawing colors
	private Color _buttonCurrentColor = Color.Empty;
	private Color _backCurrentColor = Color.Empty;
	private Color _lineCurrentColor = Color.Empty;

	// Last mouse click mouse and scaleView position
	private PointF _lastClickMousePosition = PointF.Empty;
	private double _lastClickViewPosition = double.NaN;

	// Timer used to scroll the data while selecting
	private Timer _scrollTimer = new();

	// Scroll size and direction when AutoScroll is set
	private MouseEventArgs _mouseArguments = null;

	// Position of the scrollbar (true - edge of PlotArea, false - edge of chart area)

	#endregion

	#region Scroll bar constructors and initialization

	/// <summary>
	/// AxisScrollBar constructor.
	/// </summary>
	public AxisScrollBar()
	{
	}

	/// <summary>
	/// Axis scroll bar constructor.
	/// </summary>
	/// <param name="axis">Reference to the axis class.</param>
	internal AxisScrollBar(Axis axis)
	{
		// Save reference to the axis data scaleView
		this._axis = axis;
	}

	/// <summary>
	/// Initialize axis scroll bar class.
	/// </summary>
	internal void Initialize()
	{
	}

	#endregion

	#region Scroll bar properties

	/// <summary>
	/// Gets or sets a flag which indicates whether scroll bar is positioned inside or outside of chart area.
	/// </summary>
	[
		SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(true),
	SRDescription("DescriptionAttributeAxisScrollBar_PositionInside")
	]
	public bool IsPositionedInside
	{
		get; set
		{
			if (field != value)
			{
				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = true;


	/// <summary>
	/// Gets or sets a flag which indicates whether the scroll bar is enabled.
	/// </summary>
	[
	SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(true),
	SRDescription("DescriptionAttributeAxisScrollBar_Enabled")
	]
	public bool Enabled
	{
		get; set
		{
			if (field != value)
			{
				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = true;

	/// <summary>
	/// Gets the ChartArea that contains this scrollbar.
	/// </summary>
	[
	Browsable(false),
	Bindable(false),
	DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
	SerializationVisibility(SerializationVisibility.Hidden)
	]
	public ChartArea ChartArea
	{
		get
		{
			return _axis.ChartArea;
		}
	}

	/// <summary>
	/// Gets the Axis that contains this scrollbar.
	/// </summary>
	[
	Browsable(false),
	Bindable(false),
	DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),
	SerializationVisibility(SerializationVisibility.Hidden)
	]
	public Axis Axis
	{
		get
		{
			return _axis;
		}
	}

	/// <summary>
	/// Gets or sets the style of the scrollbar button.
	/// </summary>
	[
	SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(ScrollBarButtonStyles.All),
	SRDescription("DescriptionAttributeAxisScrollBar_Buttons"),
		Editor(typeof(FlagsEnumUITypeEditor), typeof(UITypeEditor))
		]
	public ScrollBarButtonStyles ButtonStyle
	{
		get; set
		{
			if (field != value)
			{
				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = ScrollBarButtonStyles.All;

	/// <summary>
	/// Gets or sets the size of the scrollbar.
	/// </summary>
	[
	SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(14.0),
	SRDescription("DescriptionAttributeAxisScrollBar_Size"),
	]
	public double Size
	{
		get; set
		{
			if (field != value)
			{
				// Check values range
				if (value < 5.0 || value > 20.0)
				{
					throw (new ArgumentOutOfRangeException(nameof(value), SR.ExceptionScrollBarSizeInvalid));
				}

				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = 14.0;

	/// <summary>
	/// Gets or sets the button color of the scrollbar.
	/// </summary>
	[
	SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
	SRDescription("DescriptionAttributeAxisScrollBar_ButtonColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color ButtonColor
	{
		get; set
		{
			if (field != value)
			{
				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the line color of the scrollbar.
	/// </summary>
	[
	SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeLineColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color LineColor
	{
		get; set
		{
			if (field != value)
			{
				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the background color of the scrollbar.
	/// </summary>
	[
	SRCategory("CategoryAttributeAxisView"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeBackColor"),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BackColor
	{
		get; set
		{
			if (field != value)
			{
				field = value;
				_axis?.ChartArea.Invalidate();
			}
		}
	} = Color.Empty;

	#endregion

	#region Scroll bar public methods

	/// <summary>
	/// This method returns true if the scrollbar is visible.
	/// </summary>
	[Browsable(false)]
	[SerializationVisibility(SerializationVisibility.Hidden)]
	public bool IsVisible
	{
		get
		{
			// Check scroll bar enabled flag
			if (!Enabled)
			{
				return false;
			}

			// Do not show scroll bars while printing
			if (_axis == null ||
				_axis.ChartArea == null ||
				_axis.ChartArea.Common == null ||
				_axis.ChartArea.Common.ChartPicture == null ||
				_axis.ChartArea.Common.ChartPicture._isPrinting)
			{
				return false;
			}

#if SUBAXES
		// Scrollbar is not supported on the sub axis
		if(this.axis.IsSubAxis)
		{
			return false;
		}
#endif // SUBAXES

			// Check if data scaleView size in percentage is less than 100%
			return (GetDataViewPercentage() < 100.0);
		}
	}

	#endregion

	#region Scroll bar painting methods

	/// <summary>
	/// Draws axis scroll bar.
	/// </summary>
	/// <param name="graph">Reference to the Chart Graphics object.</param>
	internal void Paint(ChartGraphics graph)
	{
		// Scroll bar border width
		int borderWidth = 1;

		// Scroll bar should not be visible
		if (!IsVisible)
		{
			return;
		}

#if SUBAXES
		// Scrollbar not supported on sub axis
		if( this.axis != null &&  this.axis.IsSubAxis)
		{
			return;
		}
#endif //SUBAXES

		// Set current scroll bar colors
		_buttonCurrentColor = ButtonColor;
		_backCurrentColor = BackColor;
		_lineCurrentColor = LineColor;

		// Make sure the current colors are not empty
		if (_buttonCurrentColor == Color.Empty)
		{
			_buttonCurrentColor = _axis.ChartArea.BackColor;
			if (_buttonCurrentColor == Color.Empty)
			{
				_buttonCurrentColor = Color.DarkGray;
			}
		}

		if (_backCurrentColor == Color.Empty)
		{
			_backCurrentColor = _axis.ChartArea.BackColor;
			if (_backCurrentColor == Color.Empty)
			{
				_backCurrentColor = Color.LightGray;
			}
		}

		if (_lineCurrentColor == Color.Empty)
		{
			_lineCurrentColor = _axis.LineColor;
			if (_lineCurrentColor == Color.Empty)
			{
				_lineCurrentColor = Color.Black;
			}
		}

		// Get scroll bar rectangle
		RectangleF scrollBarRect = GetScrollBarRect();

		// Fill scroll bar background
		graph.FillRectangleRel(
			scrollBarRect,
			_backCurrentColor,
			ChartHatchStyle.None,
			"",
			ChartImageWrapMode.Tile,
			Color.Empty,
			ChartImageAlignmentStyle.Center,
			GradientStyle.None,
			Color.Empty,
			_lineCurrentColor,
			borderWidth,
			ChartDashStyle.Solid,
			Color.Empty,
			0,
			PenAlignment.Outset);

		// Fill rectangle between to neighbour scroll bars
		PaintScrollBarConnectionRect(graph, scrollBarRect, borderWidth);

		// Get scroll bar client rectangle
		SizeF borderRelativeSize = new(borderWidth, borderWidth);
		borderRelativeSize = graph.GetRelativeSize(borderRelativeSize);
		RectangleF scrollBarClientRect = new(scrollBarRect.Location, scrollBarRect.Size);
		scrollBarClientRect.Inflate(-borderRelativeSize.Width, -borderRelativeSize.Height);

		// Draw all button types
		foreach (ScrollBarButtonType buttonType in Enum.GetValues<ScrollBarButtonType>())
		{
			// Get button rectangle
			RectangleF buttonRect = GetScrollBarButtonRect(scrollBarClientRect, (ScrollBarButtonType)buttonType);

			// Paint button
			if (!buttonRect.IsEmpty)
			{
				PaintScrollBar3DButton(
					graph,
					buttonRect,
					((ScrollBarButtonType)_pressedButtonType) == (ScrollBarButtonType)buttonType,
					(ScrollBarButtonType)buttonType);
			}
		}

		if (ChartArea.Common.ProcessModeRegions)
		{
			SetHotRegionElement(ChartArea.Common);
		}
	}

	/// <summary>
	/// Fills a connection rectangle between two scoll bars.
	/// </summary>
	/// <param name="graph">Chart graphics.</param>
	/// <param name="scrollBarRect">Scroll bar position.</param>
	/// <param name="borderWidth">Border width.</param>
	private void PaintScrollBarConnectionRect(
		ChartGraphics graph,
		RectangleF scrollBarRect,
		int borderWidth)
	{
		// Do not draw anything if scroll bar is vertical
		if (_axis.AxisPosition == AxisPosition.Left ||
			_axis.AxisPosition == AxisPosition.Right)
		{
			return;
		}

		// Check if scoll bar is shown on the left/right sides of
		// the plotting area and get their sizes in relative coordinates
		float leftSize = 0f;
		float rightSize = 0f;

		foreach (Axis a in _axis.ChartArea.Axes)
		{
			if (a.AxisPosition == AxisPosition.Left && a.ScrollBar.IsVisible && a.ScrollBar.IsPositionedInside == _axis.ScrollBar.IsPositionedInside)
			{
				leftSize = (float)a.ScrollBar.GetScrollBarRelativeSize();
			}

			if (a.AxisPosition == AxisPosition.Right && a.ScrollBar.IsVisible && a.ScrollBar.IsPositionedInside == _axis.ScrollBar.IsPositionedInside)
			{
				rightSize = (float)a.ScrollBar.GetScrollBarRelativeSize();
			}
		}

		// Prepare generic rectangle coordinates
		RectangleF connectorRect = new(scrollBarRect.Location, scrollBarRect.Size);

		// Prepare coordinates and fill area to the left
		if (leftSize > 0f)
		{
			connectorRect.X = scrollBarRect.X - leftSize;
			connectorRect.Width = leftSize;

			// Fill background
			graph.FillRectangleRel(
				connectorRect,
				_backCurrentColor,
				ChartHatchStyle.None,
				"",
				ChartImageWrapMode.Tile,
				Color.Empty,
				ChartImageAlignmentStyle.Center,
				GradientStyle.None,
				Color.Empty,
				_lineCurrentColor,
				borderWidth,
				ChartDashStyle.Solid,
				Color.Empty,
				0,
				PenAlignment.Outset);
		}

		// Prepare coordinates and fill area to the right
		if (rightSize > 0f)
		{
			connectorRect.X = scrollBarRect.Right;
			connectorRect.Width = rightSize;

			// Fill background
			graph.FillRectangleRel(
				connectorRect,
				_backCurrentColor,
				ChartHatchStyle.None,
				"",
				ChartImageWrapMode.Tile,
				Color.Empty,
				ChartImageAlignmentStyle.Center,
				GradientStyle.None,
				Color.Empty,
				_lineCurrentColor,
				borderWidth,
				ChartDashStyle.Solid,
				Color.Empty,
				0,
				PenAlignment.Outset);
		}

	}

	/// <summary>
	/// Draws 3D button in the scroll bar
	/// </summary>
	/// <param name="graph">Chart graphics.</param>
	/// <param name="buttonRect">Button position.</param>
	/// <param name="pressedState">Indicates that button is pressed.</param>
	/// <param name="buttonType">Button type to draw.</param>
	internal void PaintScrollBar3DButton(
		ChartGraphics graph,
		RectangleF buttonRect,
		bool pressedState,
		ScrollBarButtonType buttonType)
	{
		// Page Up/Down buttons do not require drawing
		if (buttonType == ScrollBarButtonType.LargeIncrement || buttonType == ScrollBarButtonType.LargeDecrement)
		{
			return;
		}

		// Get 3 levels of colors for button drawing
		Color darkerColor = ChartGraphics.GetGradientColor(_buttonCurrentColor, Color.Black, 0.5);
		Color darkestColor = ChartGraphics.GetGradientColor(_buttonCurrentColor, Color.Black, 0.8);
		Color lighterColor = ChartGraphics.GetGradientColor(_buttonCurrentColor, Color.White, 0.5);

		// Fill button rectangle background
		graph.FillRectangleRel(
			buttonRect,
			_buttonCurrentColor,
			ChartHatchStyle.None,
			"",
			ChartImageWrapMode.Tile,
			Color.Empty,
			ChartImageAlignmentStyle.Center,
			GradientStyle.None,
			Color.Empty,
			darkerColor,
			(pressedState) ? 1 : 0,
			ChartDashStyle.Solid,
			Color.Empty,
			0,
			PenAlignment.Outset);

		// Check if 2 or 1 pixel border will be drawn (if size too small)
		bool singlePixelBorder = Size <= 12;

		// Draw 3D effect around the button when not pressed
		if (!pressedState)
		{
			// Get relative size of 1 pixel
			SizeF pixelRelativeSize = new(1, 1);
			pixelRelativeSize = graph.GetRelativeSize(pixelRelativeSize);

			// Draw top/left border with button color
			graph.DrawLineRel(
				(singlePixelBorder) ? lighterColor : _buttonCurrentColor, 1, ChartDashStyle.Solid,
				new PointF(buttonRect.X, buttonRect.Bottom),
				new PointF(buttonRect.X, buttonRect.Top));
			graph.DrawLineRel(
				(singlePixelBorder) ? lighterColor : _buttonCurrentColor, 1, ChartDashStyle.Solid,
				new PointF(buttonRect.Left, buttonRect.Y),
				new PointF(buttonRect.Right, buttonRect.Y));

			// Draw right/bottom border with the darkest color
			graph.DrawLineRel(
				(singlePixelBorder) ? darkerColor : darkestColor, 1, ChartDashStyle.Solid,
				new PointF(buttonRect.Right, buttonRect.Bottom),
				new PointF(buttonRect.Right, buttonRect.Top));
			graph.DrawLineRel(
				(singlePixelBorder) ? darkerColor : darkestColor, 1, ChartDashStyle.Solid,
				new PointF(buttonRect.Left, buttonRect.Bottom),
				new PointF(buttonRect.Right, buttonRect.Bottom));

			if (!singlePixelBorder)
			{
				// Draw right/bottom border (offset 1) with the dark color
				graph.DrawLineRel(
					darkerColor, 1, ChartDashStyle.Solid,
					new PointF(buttonRect.Right - pixelRelativeSize.Width, buttonRect.Bottom - pixelRelativeSize.Height),
					new PointF(buttonRect.Right - pixelRelativeSize.Width, buttonRect.Top + pixelRelativeSize.Height));
				graph.DrawLineRel(
					darkerColor, 1, ChartDashStyle.Solid,
					new PointF(buttonRect.Left + pixelRelativeSize.Width, buttonRect.Bottom - pixelRelativeSize.Height),
					new PointF(buttonRect.Right - pixelRelativeSize.Width, buttonRect.Bottom - pixelRelativeSize.Height));

				// Draw top/left border (offset 1) with lighter color
				graph.DrawLineRel(
					lighterColor, 1, ChartDashStyle.Solid,
					new PointF(buttonRect.X + pixelRelativeSize.Width, buttonRect.Bottom - pixelRelativeSize.Height),
					new PointF(buttonRect.X + pixelRelativeSize.Width, buttonRect.Top + pixelRelativeSize.Height));
				graph.DrawLineRel(
					lighterColor, 1, ChartDashStyle.Solid,
					new PointF(buttonRect.Left + pixelRelativeSize.Width, buttonRect.Y + pixelRelativeSize.Height),
					new PointF(buttonRect.Right - pixelRelativeSize.Width, buttonRect.Y + pixelRelativeSize.Height));
			}
		}

		// Check axis orientation
		bool verticalAxis = (_axis.AxisPosition == AxisPosition.Left ||
			_axis.AxisPosition == AxisPosition.Right);

		// Set graphics transformation for button pressed mode
		float pressedShifting = (singlePixelBorder) ? 0.5f : 1f;
		if (pressedState)
		{
			graph.TranslateTransform(pressedShifting, pressedShifting);
		}

		// Draw button image
		RectangleF buttonAbsRect = graph.GetAbsoluteRectangle(buttonRect);
		float imageOffset = (singlePixelBorder) ? 2 : 3;
		switch (buttonType)
		{
			case (ScrollBarButtonType.SmallDecrement):
				{
					// Calculate triangal points position
					PointF[] points = new PointF[3];
					if (verticalAxis)
					{
						points[0].X = buttonAbsRect.X + imageOffset;
						points[0].Y = buttonAbsRect.Y + (imageOffset + 1f);
						points[1].X = buttonAbsRect.X + buttonAbsRect.Width / 2f;
						points[1].Y = buttonAbsRect.Bottom - imageOffset;
						points[2].X = buttonAbsRect.Right - imageOffset;
						points[2].Y = buttonAbsRect.Y + (imageOffset + 1f);
					}
					else
					{
						points[0].X = buttonAbsRect.X + imageOffset;
						points[0].Y = buttonAbsRect.Y + buttonAbsRect.Height / 2f;
						points[1].X = buttonAbsRect.Right - (imageOffset + 1f);
						points[1].Y = buttonAbsRect.Y + imageOffset;
						points[2].X = buttonAbsRect.Right - (imageOffset + 1f);
						points[2].Y = buttonAbsRect.Bottom - imageOffset;
					}

					using Brush brush = new SolidBrush(_lineCurrentColor);
					graph.FillPolygon(brush, points);

					break;
				}
			case (ScrollBarButtonType.SmallIncrement):
				{
					// Calculate triangal points position
					PointF[] points = new PointF[3];
					if (verticalAxis)
					{
						points[0].X = buttonAbsRect.X + imageOffset;
						points[0].Y = buttonAbsRect.Bottom - (imageOffset + 1f);
						points[1].X = buttonAbsRect.X + buttonAbsRect.Width / 2f;
						points[1].Y = buttonAbsRect.Y + imageOffset;
						points[2].X = buttonAbsRect.Right - imageOffset;
						points[2].Y = buttonAbsRect.Bottom - (imageOffset + 1f);
					}
					else
					{
						points[0].X = buttonAbsRect.Right - imageOffset;
						points[0].Y = buttonAbsRect.Y + buttonAbsRect.Height / 2f;
						points[1].X = buttonAbsRect.X + (imageOffset + 1f);
						points[1].Y = buttonAbsRect.Y + imageOffset;
						points[2].X = buttonAbsRect.X + (imageOffset + 1f);
						points[2].Y = buttonAbsRect.Bottom - imageOffset;
					}

					using Brush brush = new SolidBrush(_lineCurrentColor);
					graph.FillPolygon(brush, points);

					break;
				}
			case (ScrollBarButtonType.ZoomReset):
				{
					// Draw circule with a minus sign
					using Pen pen = new(_lineCurrentColor, 1);
					graph.DrawEllipse(pen, buttonAbsRect.X + imageOffset - 0.5f, buttonAbsRect.Y + imageOffset - 0.5f, buttonAbsRect.Width - 2f * imageOffset, buttonAbsRect.Height - 2f * imageOffset);
					graph.DrawLine(pen, buttonAbsRect.X + imageOffset + 1.5f, buttonAbsRect.Y + buttonAbsRect.Height / 2f - 0.5f, buttonAbsRect.Right - imageOffset - 2.5f, buttonAbsRect.Y + buttonAbsRect.Height / 2f - 0.5f);

					break;
				}
		}

		// Reset graphics transformation for button pressed mode
		if (pressedState)
		{
			graph.TranslateTransform(-pressedShifting, -pressedShifting);
		}
	}

	#endregion

	#region Mouse events handling for the Scroll Bar

	/// <summary>
	/// Mouse down event handler.
	/// </summary>
	internal void ScrollBar_MouseDown(object sender, MouseEventArgs e)
	{
		// Process left mouse button
		if (e.Button == MouseButtons.Left && IsVisible)
		{
			// Remember position where mouse was clicked
			_lastClickMousePosition = new PointF(e.X, e.Y);
			_lastClickViewPosition = _axis.ScaleView.Position;

			// Check if button was pressed inside the scroll bar
			if (GetElementByPixelPosition(e.X, e.Y, out ScrollBarButtonType buttonType))
			{
				ButtonClicked(buttonType, e.X, e.Y);
			}
		}
	}

	/// <summary>
	/// Mouse up event handler.
	/// </summary>
	internal void ScrollBar_MouseUp(object sender, MouseEventArgs e)
	{
		// If scroll bar button was pressed
		if (_pressedButtonType != int.MaxValue)
		{
			// Check if button was unpressed inside the reset zoom button
			if (GetElementByPixelPosition(e.X, e.Y, out ScrollBarButtonType buttonType))
			{
				if (buttonType == ScrollBarButtonType.ZoomReset)
				{
					ButtonClicked(buttonType, e.X, e.Y);
				}
			}

			// Stop scrolling timer
			_scrollTimer.Stop();
			_mouseArguments = null;

			// Clear pressed button state
			_pressedButtonType = int.MaxValue;

			// Invalidate chart
			_axis.Invalidate();
		}
	}

	/// <summary>
	/// Mouse move event handler.
	/// </summary>
	internal void ScrollBar_MouseMove(MouseEventArgs e, ref bool handled)
	{
		// If scroll bar button was pressed
		if (_pressedButtonType != int.MaxValue)
		{
			// Mouse move event should not be handled by any other chart elements
			handled = true;

			// Check if tracking buton was pressed
			if ((ScrollBarButtonType)_pressedButtonType == ScrollBarButtonType.ThumbTracker)
			{
				// Proceed if last clicked position is known
				if (!_lastClickMousePosition.IsEmpty)
				{
					ButtonClicked(ScrollBarButtonType.ThumbTracker, e.X, e.Y);
				}
			}

			// Non tracking scroll bar button
			else
			{
				// Check if mouse cursor is still in the pressed button's rectangle
				bool inPressedButton = false;
				if (GetElementByPixelPosition(e.X, e.Y, out ScrollBarButtonType buttonType))
				{
					if (buttonType == (ScrollBarButtonType)_pressedButtonType)
					{
						inPressedButton = true;
					}
				}

				// Clear pressed button state
				if (!inPressedButton)
				{
					// Stop scrolling timer
					_scrollTimer.Stop();
					_mouseArguments = null;

					// Clear pressed button state
					_pressedButtonType = int.MaxValue;

					// Invalidate chart
					_axis.Invalidate();
				}
			}
		}
	}

	/// <summary>
	/// Scroll bar button was clicked by the user.
	/// </summary>
	/// <param name="buttonType">Button type.</param>
	/// <param name="x">X click position in pixels.</param>
	/// <param name="y">Y click position in pixels.</param>
	private void ButtonClicked(ScrollBarButtonType buttonType, int x, int y)
	{
		// Call zoom reset on the second pass when button is released
		if (buttonType != ScrollBarButtonType.ZoomReset ||
			(ScrollBarButtonType)_pressedButtonType == buttonType)
		{

			//**************************************************
			//** Fire scroll bar button clicked event
			//**************************************************
			ScrollBarEventArgs eventArg = new(_axis, x, y, buttonType);
			_axis.ScaleView.GetChartObject().OnAxisScrollBarClicked(eventArg);

			// Check if event was handled by user
			if (eventArg.IsHandled)
			{
				// Save type of the button pressed
				_pressedButtonType = (int)buttonType;

				return;
			}

			//**************************************************
			//** Scroll data scaleView
			//**************************************************
			switch (buttonType)
			{
				case (ScrollBarButtonType.SmallIncrement):
					_axis.ScaleView.Scroll(ScrollType.SmallIncrement, true);
					break;
				case (ScrollBarButtonType.SmallDecrement):
					_axis.ScaleView.Scroll(ScrollType.SmallDecrement, true);
					break;
				case (ScrollBarButtonType.LargeIncrement):
					_axis.ScaleView.Scroll(ScrollType.LargeIncrement, true);
					break;
				case (ScrollBarButtonType.LargeDecrement):
					_axis.ScaleView.Scroll(ScrollType.LargeDecrement, true);
					break;
				case (ScrollBarButtonType.ZoomReset):
					_axis.ScaleView.ZoomReset(1, true);
					break;
				case (ScrollBarButtonType.ThumbTracker):
					{
						if (!_lastClickMousePosition.IsEmpty &&
							!double.IsNaN(_lastClickViewPosition) &&
							(_lastClickMousePosition.X != x || _lastClickMousePosition.Y != y))
						{
							// Get scroll bar client rectangle
							RectangleF scrollBarRect = GetScrollBarRect();
							SizeF borderRelativeSize = new(1, 1);
							borderRelativeSize = GetRelativeSize(borderRelativeSize);
							RectangleF scrollBarClientRect = new(scrollBarRect.Location, scrollBarRect.Size);
							scrollBarClientRect.Inflate(-borderRelativeSize.Width, -borderRelativeSize.Height);

							// Check axis orientation
							bool verticalAxis = (_axis.AxisPosition == AxisPosition.Left ||
								_axis.AxisPosition == AxisPosition.Right);

							// Get button relative size
							SizeF buttonSize = new(scrollBarClientRect.Width, scrollBarClientRect.Height);
							buttonSize = GetAbsoluteSize(buttonSize);
							if (verticalAxis)
							{
								buttonSize.Height = buttonSize.Width;
							}
							else
							{
								buttonSize.Width = buttonSize.Height;
							}

							buttonSize = GetRelativeSize(buttonSize);

							// Calculate the distance in percentages the mouse was moved
							// from it's original (clicked) position.
							float distance = 0f;
							double trackingAreaSize = 0f;
							if (verticalAxis)
							{
								// Calculate max tracking size
								trackingAreaSize = scrollBarClientRect.Height - GetButtonsNumberAll() * buttonSize.Height;
								distance = _lastClickMousePosition.Y - y;

								// Convert to relative coordinates
								distance = distance * 100F / ((float)(_axis.Common.Height - 1));
							}
							else
							{
								trackingAreaSize = scrollBarClientRect.Width - GetButtonsNumberAll() * buttonSize.Width;
								distance = x - _lastClickMousePosition.X;

								// Convert to relative coordinates
								distance = distance * 100F / ((float)(_axis.Common.Width - 1));
							}

							// Convert to percentages from total tracking area
							distance = (float)(distance / (trackingAreaSize / 100f));

							// Get axis scale size without margins
							double axisScaleSize = Math.Abs(
								(_axis.maximum - _axis.marginView) -
								(_axis.minimum + _axis.marginView));

							// Calculate the same percentage using axis scale
							distance = (float)(distance * (axisScaleSize / 100f));

							// Round the distance to the minimum scroll line size
							if (!double.IsNaN(_axis.ScaleView.SmallScrollMinSize) && _axis.ScaleView.SmallScrollMinSize != 0.0)
							{
								double minSize = ChartHelper.GetIntervalSize(0, _axis.ScaleView.SmallScrollMinSize, _axis.ScaleView.SmallScrollMinSizeType);

								double rounder = (Math.Round(distance / minSize));
								distance = (float)(rounder * minSize);
							}

							// Scroll scaleView into the new position
							_axis.ScaleView.Scroll(_lastClickViewPosition + ((_axis.IsReversed) ? -1 : 1) * distance, true);
						}

						break;
					}
			}

			//************************************************************
			//** Initialize timer for repeating scroll (if mouse is hold)
			//************************************************************

			// Reset mouse arguments
			_mouseArguments = null;

			if (buttonType != ScrollBarButtonType.ThumbTracker && buttonType != ScrollBarButtonType.ZoomReset)
			{
				// Remember last mouse position
				_mouseArguments = new MouseEventArgs(MouseButtons.Left, 1, x, y, 0);

				// Enable timer
				if (!_scrollTimer.Enabled)
				{
					_scrollTimer.Tick += new EventHandler(ScrollingTimerEventProcessor);
					_scrollTimer.Interval = 400;
					_scrollTimer.Start();
				}
			}
		}

		//************************************************************
		//** Invalidate chart
		//************************************************************

		// Save type of the button pressed
		_pressedButtonType = (int)buttonType;

		// Invalidate
		_axis.Invalidate();
	}

	/// <summary>
	/// This is the method to run when the timer is raised.
	/// Used to repetedly scroll data scaleView while mouse button is pressed.
	/// </summary>
	/// <param name="myObject">Object.</param>
	/// <param name="myEventArgs">Event arguments.</param>
	private void ScrollingTimerEventProcessor(object myObject, EventArgs myEventArgs)
	{
		// Simulate mouse move events
		if (_mouseArguments != null)
		{
			_scrollTimer.Interval = 200;
			ScrollBar_MouseDown(null, _mouseArguments);
		}
	}

	/// <summary>
	/// This method fills hot region collection with scroll bar elements.
	/// Possible elements are all scroll bar buttons and scroll bar background
	/// which performs PgUp/PgDn action.
	/// </summary>
	/// <param name="common">Common Elements</param>
	private void SetHotRegionElement(CommonElements common)
	{
		// Check if mouse button was clicked in the scroll bar
		RectangleF scrollBarRect = GetScrollBarRect();

		// Get scroll bar client rectangle
		SizeF borderRelativeSize = new(1, 1);
		borderRelativeSize = GetRelativeSize(borderRelativeSize);
		RectangleF scrollBarClientRect = new(scrollBarRect.Location, scrollBarRect.Size);
		scrollBarClientRect.Inflate(-borderRelativeSize.Width, -borderRelativeSize.Height);

		ChartElementType buttonType = ChartElementType.Nothing;

		// Fill collection with scroll buttons rectangles.
		foreach (object type in Enum.GetValues<ScrollBarButtonType>())
		{

			// Convert Scroll Bar Button type enum to Chart Element AxisName enum.
			switch ((ScrollBarButtonType)type)
			{
				case ScrollBarButtonType.SmallIncrement:
					buttonType = ChartElementType.ScrollBarSmallIncrement;
					break;
				case ScrollBarButtonType.LargeIncrement:
					buttonType = ChartElementType.ScrollBarLargeIncrement;
					break;
				case ScrollBarButtonType.LargeDecrement:
					buttonType = ChartElementType.ScrollBarLargeDecrement;
					break;
				case ScrollBarButtonType.ThumbTracker:
					buttonType = ChartElementType.ScrollBarThumbTracker;
					break;
				case ScrollBarButtonType.SmallDecrement:
					buttonType = ChartElementType.ScrollBarSmallDecrement;
					break;
				case ScrollBarButtonType.ZoomReset:
					buttonType = ChartElementType.ScrollBarZoomReset;
					break;
			}

			// Get button rectangle
			RectangleF buttonRect = GetScrollBarButtonRect(scrollBarClientRect, (ScrollBarButtonType)type);

			common.HotRegionsList.AddHotRegion(buttonRect, this, buttonType, true);

		}
	}

	/// <summary>
	/// Detects the scroll bar elements by pixel position.
	/// Possible elements are all scroll bar buttons and scroll bar background
	/// which performs PgUp/PgDn action.
	/// </summary>
	/// <param name="x">X coordinate in pixels.</param>
	/// <param name="y">Y coordinate in pixels.</param>
	/// <param name="buttonType">Return button type.</param>
	/// <returns>True if position is in the scroll bar.</returns>
	private bool GetElementByPixelPosition(float x, float y, out ScrollBarButtonType buttonType)
	{
		// Set initial values
		buttonType = ScrollBarButtonType.ThumbTracker;

		// Convert mouse click coordinates to relative
		PointF position = new(x, y)
		{
			X = x * 100F / ((float)(_axis.Common.Width - 1)),
			Y = y * 100F / ((float)(_axis.Common.Height - 1))
		};

		// Check if mouse button was clicked in the scroll bar
		RectangleF scrollBarRect = GetScrollBarRect();
		if (scrollBarRect.Contains(position))
		{
			// Get scroll bar client rectangle
			SizeF borderRelativeSize = new(1, 1);
			borderRelativeSize = GetRelativeSize(borderRelativeSize);
			RectangleF scrollBarClientRect = new(scrollBarRect.Location, scrollBarRect.Size);
			scrollBarClientRect.Inflate(-borderRelativeSize.Width, -borderRelativeSize.Height);

			//******************************************************************
			//** Check if scroll bar button was clicked
			//******************************************************************
			foreach (object type in Enum.GetValues<ScrollBarButtonType>())
			{
				// Get button rectangle
				RectangleF buttonRect = GetScrollBarButtonRect(scrollBarClientRect, (ScrollBarButtonType)type);

				// Check if position is inside the button
				if (buttonRect.Contains(position))
				{
					buttonType = (ScrollBarButtonType)type;
					return true;
				}
			}
		}

		// Pixel position is outside scroll bar area
		return false;
	}

	#endregion

	#region Scroll bar helper methods

	/// <summary>
	/// Returns scroll bar button rectangle position in relative coordinates.
	/// </summary>
	/// <param name="scrollBarClientRect">Scroll bar client rectangle.</param>
	/// <param name="buttonType">Scroll bar button type.</param>
	/// <returns>Scroll bar position.</returns>
	internal RectangleF GetScrollBarButtonRect(RectangleF scrollBarClientRect, ScrollBarButtonType buttonType)
	{
		// Initialize button rectangle
		RectangleF buttonRect = new(scrollBarClientRect.Location, scrollBarClientRect.Size);

		// Check axis orientation
		bool verticalAxis = (_axis.AxisPosition == AxisPosition.Left ||
			_axis.AxisPosition == AxisPosition.Right);

		// Get relative size of 1 pixel
		SizeF pixelRelativeSize = new(1, 1);
		pixelRelativeSize = GetRelativeSize(pixelRelativeSize);

		// Get button relative size
		SizeF buttonSize = new(scrollBarClientRect.Width, scrollBarClientRect.Height);
		buttonSize = GetAbsoluteSize(buttonSize);
		if (verticalAxis)
		{
			buttonSize.Height = buttonSize.Width;
		}
		else
		{
			buttonSize.Width = buttonSize.Height;
		}

		buttonSize = GetRelativeSize(buttonSize);

		// Set common position sizes
		buttonRect.Width = buttonSize.Width;
		buttonRect.Height = buttonSize.Height;
		if (verticalAxis)
		{
			buttonRect.X = scrollBarClientRect.X;
		}
		else
		{
			buttonRect.Y = scrollBarClientRect.Y;
		}

		// Calculate scroll bar buttons position
		switch (buttonType)
		{
			case (ScrollBarButtonType.LargeDecrement):
			case (ScrollBarButtonType.LargeIncrement):
			case (ScrollBarButtonType.ThumbTracker):
				{
					// Get tracker button position and size first
					if (verticalAxis)
					{
						// Calculate tracker size
						double trackingAreaSize = scrollBarClientRect.Height - GetButtonsNumberAll() * buttonSize.Height;
						buttonRect.Height = (float)(GetDataViewPercentage() * (trackingAreaSize / 100f));

						// Check if tracker size is too small
						if (buttonRect.Height < pixelRelativeSize.Height * 6f)
						{
							buttonRect.Height = pixelRelativeSize.Height * 6f;
						}

						// Calculate tracker position
						if (!_axis.IsReversed)
						{
							buttonRect.Y = scrollBarClientRect.Bottom - GetButtonsNumberBottom() * buttonSize.Height - buttonRect.Height;
							buttonRect.Y -= (float)(GetDataViewPositionPercentage() * (trackingAreaSize / 100f));
							if (buttonRect.Y < scrollBarClientRect.Y + GetButtonsNumberTop() * buttonSize.Height + ((GetButtonsNumberTop() == 0) ? 0 : pixelRelativeSize.Height))
							{
								buttonRect.Y = scrollBarClientRect.Y + GetButtonsNumberTop() * buttonSize.Height + ((GetButtonsNumberTop() == 0) ? 0 : pixelRelativeSize.Height);
							}
						}
						else
						{
							buttonRect.Y = scrollBarClientRect.Top + GetButtonsNumberTop() * buttonSize.Height;
							buttonRect.Y += (float)(GetDataViewPositionPercentage() * (trackingAreaSize / 100f));
							if ((buttonRect.Y + buttonRect.Height) > scrollBarClientRect.Bottom - GetButtonsNumberBottom() * buttonSize.Height - ((GetButtonsNumberBottom() == 0) ? 0 : pixelRelativeSize.Height))
							{
								buttonRect.Y = (scrollBarClientRect.Bottom - GetButtonsNumberBottom() * buttonSize.Height) - buttonRect.Height - ((GetButtonsNumberBottom() == 0) ? 0 : pixelRelativeSize.Height);
							}
						}
					}
					else
					{
						// Calculate tracker size
						double trackingAreaSize = scrollBarClientRect.Width - GetButtonsNumberAll() * buttonSize.Width;
						buttonRect.Width = (float)(GetDataViewPercentage() * (trackingAreaSize / 100f));

						// Check if tracker size is too small
						if (buttonRect.Width < pixelRelativeSize.Width * 6f)
						{
							buttonRect.Width = pixelRelativeSize.Width * 6f;
						}

						// Calculate tracker position
						if (!_axis.IsReversed)
						{
							buttonRect.X = scrollBarClientRect.X + GetButtonsNumberTop() * buttonSize.Width;
							buttonRect.X += (float)(GetDataViewPositionPercentage() * (trackingAreaSize / 100f));
							if ((buttonRect.X + buttonRect.Width) > scrollBarClientRect.Right - GetButtonsNumberBottom() * buttonSize.Width - ((GetButtonsNumberBottom() == 0) ? 0 : pixelRelativeSize.Width))
							{
								buttonRect.X = (scrollBarClientRect.Right - buttonRect.Width) - GetButtonsNumberBottom() * buttonSize.Width - ((GetButtonsNumberBottom() == 0) ? 0 : pixelRelativeSize.Width);
							}
						}
						else
						{
							buttonRect.X = scrollBarClientRect.Right - GetButtonsNumberBottom() * buttonSize.Width - ((GetButtonsNumberBottom() == 0) ? 0 : pixelRelativeSize.Width) - buttonRect.Width;
							buttonRect.X -= (float)(GetDataViewPositionPercentage() * (trackingAreaSize / 100f));
							if (buttonRect.X < scrollBarClientRect.X + GetButtonsNumberTop() * buttonSize.Width)
							{
								buttonRect.X = scrollBarClientRect.X + GetButtonsNumberTop() * buttonSize.Width;
							}
						}

					}

					// Get page up region rectangle depending on the tracker position
					if (buttonType == ScrollBarButtonType.LargeDecrement)
					{
						if (verticalAxis)
						{
							buttonRect.Y = buttonRect.Bottom + pixelRelativeSize.Height;
							buttonRect.Height = (scrollBarClientRect.Bottom - GetButtonsNumberBottom() * buttonSize.Height - pixelRelativeSize.Height) - buttonRect.Y;
						}
						else
						{
							float x = scrollBarClientRect.X +
								GetButtonsNumberTop() * buttonSize.Width +
								pixelRelativeSize.Width;

							buttonRect.Width = buttonRect.X - x;
							buttonRect.X = x;
						}
					}

					// Get page down region rectangle depending on the tracker position
					else if (buttonType == ScrollBarButtonType.LargeIncrement)
					{
						if (verticalAxis)
						{
							float y = scrollBarClientRect.Y +
								GetButtonsNumberTop() * buttonSize.Height +
								pixelRelativeSize.Height;

							buttonRect.Height = buttonRect.Y - y;
							buttonRect.Y = y;
						}
						else
						{
							buttonRect.X = buttonRect.Right + pixelRelativeSize.Width;
							buttonRect.Width = (scrollBarClientRect.Right - GetButtonsNumberBottom() * buttonSize.Width - pixelRelativeSize.Height) - buttonRect.X;
						}
					}

					break;
				}

			case (ScrollBarButtonType.SmallDecrement):
				if (ButtonStyle == ScrollBarButtonStyles.All ||
					ButtonStyle == ScrollBarButtonStyles.SmallScroll)
				{
					if (verticalAxis)
					{
						buttonRect.Y = scrollBarClientRect.Bottom - buttonRect.Height;
					}
					else
					{
						buttonRect.X = scrollBarClientRect.X + (GetButtonsNumberTop() - 1f) * buttonSize.Width;
						buttonRect.X += (GetButtonsNumberTop() == 1) ? 0 : pixelRelativeSize.Width;
					}
				}
				else
				{
					buttonRect = RectangleF.Empty;
				}

				break;

			case (ScrollBarButtonType.SmallIncrement):
				if (ButtonStyle == ScrollBarButtonStyles.All ||
					ButtonStyle == ScrollBarButtonStyles.SmallScroll)
				{
					if (verticalAxis)
					{
						buttonRect.Y = scrollBarClientRect.Y + (GetButtonsNumberTop() - 1f) * buttonSize.Height;
						buttonRect.Y += (GetButtonsNumberTop() == 1) ? 0 : pixelRelativeSize.Height;
					}
					else
					{
						buttonRect.X = scrollBarClientRect.Right - buttonRect.Width;
					}
				}
				else
				{
					buttonRect = RectangleF.Empty;
				}

				break;

			case (ScrollBarButtonType.ZoomReset):
				if (ButtonStyle == ScrollBarButtonStyles.All ||
					ButtonStyle == ScrollBarButtonStyles.ResetZoom)
				{
					if (verticalAxis)
					{
						buttonRect.Y = scrollBarClientRect.Y;
					}
					else
					{
						buttonRect.X = scrollBarClientRect.X;
					}
				}
				else
				{
					buttonRect = RectangleF.Empty;
				}

				break;
		}

		return buttonRect;
	}

	/// <summary>
	/// Returns scroll bar rectangle position in relative coordinates.
	/// </summary>
	/// <returns>Scroll bar position.</returns>
	internal RectangleF GetScrollBarRect()
	{
		// Get scroll bar relative size
		float scrollBarSize = (float)GetScrollBarRelativeSize();

		// Get relative size of the axis line (Note: Code removed for now. -- AG)
		//SizeF axisLineSize = new SizeF(axis.LineWidth, axis.LineWidth);
		//axisLineSize.Width =  axisLineSize.Width * 100F / ((float)(this.axis.Common.Width - 1));
		//axisLineSize.Height = axisLineSize.Height * 100F / ((float)(this.axis.Common.Height - 1));

		// Check if scroll bar is positioned next to PlotArea or ChartArea
		RectangleF areaPosition = _axis.PlotAreaPosition.ToRectangleF();
		if (!IsPositionedInside)
		{
			areaPosition = _axis.ChartArea.Position.ToRectangleF();

			// Reduce rectangle size by scroll bar size
			foreach (Axis a in ChartArea.Axes)
			{
				if (a.ScrollBar.IsVisible && !a.ScrollBar.IsPositionedInside)
				{
					float size = (float)a.ScrollBar.GetScrollBarRelativeSize();
					switch (a.AxisPosition)
					{
						case AxisPosition.Left:
							areaPosition.X += size;
							areaPosition.Width -= size;
							break;
						case AxisPosition.Right:
							areaPosition.Width -= size;
							break;
						case AxisPosition.Bottom:
							areaPosition.Height -= size;
							break;
						case AxisPosition.Top:
							areaPosition.Y += size;
							areaPosition.Height -= size;
							break;
					}
				}
			}
		}

		// Get bar position depending on the axis type
		RectangleF barPosition = RectangleF.Empty;
		if (_axis.PlotAreaPosition != null)
		{
			switch (_axis.AxisPosition)
			{
				case AxisPosition.Left:
					barPosition.Y = areaPosition.Y;
					barPosition.Height = areaPosition.Height;
					barPosition.X =
						((IsPositionedInside) ? (float)(_axis.GetAxisPosition(true)) : areaPosition.X) - scrollBarSize;// - axisLineSize.Width / 2f;
					barPosition.Width = scrollBarSize;
					break;
				case AxisPosition.Right:
					barPosition.Y = areaPosition.Y;
					barPosition.Height = areaPosition.Height;
					barPosition.X =
						(IsPositionedInside) ? (float)_axis.GetAxisPosition(true) : areaPosition.Right;// + axisLineSize.Width / 2f;
					barPosition.Width = scrollBarSize;
					break;
				case AxisPosition.Bottom:
					barPosition.X = areaPosition.X;
					barPosition.Width = areaPosition.Width;
					barPosition.Y =
						(IsPositionedInside) ? (float)_axis.GetAxisPosition(true) : areaPosition.Bottom;// + axisLineSize.Height / 2f;
					barPosition.Height = scrollBarSize;
					break;
				case AxisPosition.Top:
					barPosition.X = areaPosition.X;
					barPosition.Width = areaPosition.Width;
					barPosition.Y =
						((IsPositionedInside) ? (float)_axis.GetAxisPosition(true) : areaPosition.Y) - scrollBarSize;// - axisLineSize.Height / 2f;
					barPosition.Height = scrollBarSize;
					break;
			}
		}

		return barPosition;
	}

	/// <summary>
	/// Internal helper method which returns the relative scroll bar size.
	/// </summary>
	/// <returns>Relative scroll bar size.</returns>
	internal double GetScrollBarRelativeSize()
	{
		// Scroll bar is not shown in 3D
		if (_axis.ChartArea.Area3DStyle.Enable3D || _axis.ChartArea.chartAreaIsCurcular)
		{
			return 0.0;
		}

#if SUBAXES
		// Scrollbar not supported on sub axis
		if( this.axis != null &&  this.axis.IsSubAxis)
		{
			return 0.0;
		}
#endif //SUBAXES


		// Get scroll bar relative size depending on the axis location
		if (_axis.AxisPosition == AxisPosition.Left || _axis.AxisPosition == AxisPosition.Right)
		{
			return Size * 100F / ((float)(_axis.Common.Width - 1));
		}
		else
		{
			return Size * 100F / ((float)(_axis.Common.Height - 1));
		}
	}

	/// <summary>
	/// Returns the percentage size (0-100%) of the data scaleView comparing to
	/// the axis scale minimum and maximum values.
	/// </summary>
	/// <returns>Size of the data scaleView in percentage.</returns>
	private double GetDataViewPercentage()
	{
		double viewPercentage = 100.0;

		// Check if axis data scaleView properties are set
		if (_axis != null &&
			!double.IsNaN(_axis.ScaleView.Position) &&
			!double.IsNaN(_axis.ScaleView.Size))
		{
			// Get data scaleView size
			double dataViewSize = ChartHelper.GetIntervalSize(
			_axis.ScaleView.Position,
			_axis.ScaleView.Size,
			_axis.ScaleView.SizeType);

			// Get axis scale size without margins
			double minimum = _axis.minimum + _axis.marginView;
			double maximum = _axis.maximum - _axis.marginView;
			if (_axis.ScaleView.Position < minimum)
			{
				minimum = _axis.ScaleView.Position;
			}

			if ((_axis.ScaleView.Position + dataViewSize) > maximum)
			{
				maximum = _axis.ScaleView.Position + dataViewSize;
			}

			double axisScaleSize = Math.Abs(minimum - maximum);

			// Check if data scaleView is smaller than axis scale and if it is find the pecentage
			if (dataViewSize < axisScaleSize)
			{
				viewPercentage = dataViewSize / (axisScaleSize / 100.0);
			}
		}

		return viewPercentage;
	}

	/// <summary>
	/// Returns the the data scaleView position in percentage (0-100%) using
	/// the axis scale minimum and maximum values.
	/// </summary>
	/// <returns>Data scaleView position in percentage.</returns>
	private double GetDataViewPositionPercentage()
	{
		double viewPosition = 0.0;

		// Check if axis data scaleView properties are set
		if (_axis != null &&
			!double.IsNaN(_axis.ScaleView.Position) &&
			!double.IsNaN(_axis.ScaleView.Size))
		{
			// Get data scaleView size
			double dataViewSize = ChartHelper.GetIntervalSize(
			_axis.ScaleView.Position,
			_axis.ScaleView.Size,
			_axis.ScaleView.SizeType);

			// Get axis scale size without margins
			double minimum = _axis.minimum + _axis.marginView;
			double maximum = _axis.maximum - _axis.marginView;
			if (_axis.ScaleView.Position < minimum)
			{
				minimum = _axis.ScaleView.Position;
			}

			if ((_axis.ScaleView.Position + dataViewSize) > maximum)
			{
				maximum = _axis.ScaleView.Position + dataViewSize;
			}

			double axisScaleSize = Math.Abs(minimum - maximum);

			// Calculate data scaleView position in percentage
			viewPosition = (_axis.ScaleView.Position - (minimum)) / (axisScaleSize / 100.0);
		}

		return viewPosition;
	}

	/// <summary>
	/// Get total number of buttons in the scroll bar (except tracker).
	/// </summary>
	/// <returns>Number of buttons.</returns>
	private int GetButtonsNumberAll()
	{
		int buttonNumber = 0;
		if ((ButtonStyle & ScrollBarButtonStyles.ResetZoom) == ScrollBarButtonStyles.ResetZoom)
		{
			buttonNumber += 1;
		}

		if ((ButtonStyle & ScrollBarButtonStyles.SmallScroll) == ScrollBarButtonStyles.SmallScroll)
		{
			buttonNumber += 2;
		}

		return buttonNumber;
	}

	/// <summary>
	/// Get number of buttons in the top (left) part of the scroll bar.
	/// </summary>
	/// <returns>Number of buttons.</returns>
	private int GetButtonsNumberTop()
	{
		int buttonNumber = 0;
		if ((ButtonStyle & ScrollBarButtonStyles.ResetZoom) == ScrollBarButtonStyles.ResetZoom)
		{
			buttonNumber += 1;
		}

		if ((ButtonStyle & ScrollBarButtonStyles.SmallScroll) == ScrollBarButtonStyles.SmallScroll)
		{
			buttonNumber += 1;
		}

		return buttonNumber;
	}

	/// <summary>
	/// Get number of buttons in the bottom (right) part of the scroll bar.
	/// </summary>
	/// <returns>Number of buttons.</returns>
	private int GetButtonsNumberBottom()
	{
		int buttonNumber = 0;
		if ((ButtonStyle & ScrollBarButtonStyles.SmallScroll) == ScrollBarButtonStyles.SmallScroll)
		{
			buttonNumber += 1;
		}

		return buttonNumber;
	}

	#endregion

	#region Coordinate convertion methods

	/// <summary>
	/// Converts Relative size to Absolute size
	/// </summary>
	/// <param name="relative">Relative size in %</param>
	/// <returns>Absolute size</returns>
	internal SizeF GetAbsoluteSize(SizeF relative)
	{
		SizeF absolute = SizeF.Empty;

		// Convert relative coordinates to absolute coordinates
		absolute.Width = relative.Width * (_axis.Common.Width - 1) / 100F;
		absolute.Height = relative.Height * (_axis.Common.Height - 1) / 100F;

		// Return Absolute coordinates
		return absolute;
	}

	/// <summary>
	/// Converts Absolute size to Relative size
	/// </summary>
	/// <param name="size">Absolute size</param>
	/// <returns>Relative size</returns>
	internal SizeF GetRelativeSize(SizeF size)
	{
		SizeF relative = SizeF.Empty;

		// Convert absolute coordinates to relative coordinates
		relative.Width = size.Width * 100F / ((float)(_axis.Common.Width - 1));
		relative.Height = size.Height * 100F / ((float)(_axis.Common.Height - 1));

		// Return relative coordinates
		return relative;
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
/// The arguments for a scrollbar event.
/// </summary>
/// <remarks>
/// ScrollBarEventArgs constructor.
/// </remarks>
/// <param name="axis">Axis containing the scrollbar.</param>
/// <param name="x">X position of mouse cursor.</param>
/// <param name="y">Y position of mouse cursor.</param>
/// <param name="buttonType">Button type of the button clicked.</param>
[method: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly",
		Justification = "X and Y are cartesian coordinates and well understood")]
/// <summary>
/// The arguments for a scrollbar event.
/// </summary>
public class ScrollBarEventArgs(Axis axis, int x, int y, ScrollBarButtonType buttonType) : EventArgs
{
	#region Properties

	/// <summary>
	/// Axis containing the scrollbar of the event.
	/// </summary>
	[
	SRDescription("DescriptionAttributeAxis"),
	]
	public Axis Axis { get; } = axis;

	/// <summary>
	/// ChartArea containing the scrollbar of the event.
	/// </summary>
	[
	SRDescription("DescriptionAttributeChartArea"),
	]
	public ChartArea ChartArea
	{
		get
		{
			return Axis.ChartArea;
		}
	}

	/// <summary>
	/// Button type of the scrollbar button clicked.
	/// </summary>
	[
	SRDescription("DescriptionAttributeScrollBarEventArgs_ButtonType"),
	]
	public ScrollBarButtonType ButtonType { get; } = buttonType;

	/// <summary>
	/// Indicates if the event is handled by the user and no further processing is required.
	/// </summary>
	[
	SRDescription("DescriptionAttributeScrollBarEventArgs_Handled"),
	]
	public bool IsHandled { get; set; } = false;

	/// <summary>
	/// X position of mouse cursor.
	/// </summary>
	[
	SRDescription("DescriptionAttributeScrollBarEventArgs_MousePositionX"),
	]
	public int MousePositionX { get; } = x;

	/// <summary>
	/// Y position of mouse cursor.
	/// </summary>
	[
	SRDescription("DescriptionAttributeScrollBarEventArgs_MousePositionY"),
	]
	public int MousePositionY { get; } = y;

	#endregion
}
