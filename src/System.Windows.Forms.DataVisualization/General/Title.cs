// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.


//
//  Purpose:	Titles can be added to the chart by simply including 
//              those titles into the Titles collection, which is 
//              found in the root Chart object. The Title object 
//              incorporates several properties that can be used to 
//              position, dock, and control the appearance of any 
//              Title. Title positioning can be explicitly set, or 
//              you can specify that your title be docked. The 
//              charting control gives you full control over all of 
//              the appearance properties of your Titles, so you have 
//              the ability to set specific properties for such things 
//              as fonts, or colors, and even text effects. 
//              :
// NOTE: In early versions of the Chart control only 1 title was 
// exposed through the Title, TitleFont and TitleFontColor properties 
// in the root chart object. Due to the customer requests, support for 
// unlimited number of titles was added through the TitleCollection 
// exposed as a Titles property of the root chart object. Old 
// properties were deprecated and marked as non-browsable. 
//


using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting.Utilities;
using System.Windows.Forms.Design.DataVisualization.Charting;

namespace System.Windows.Forms.DataVisualization.Charting;

#region Title enumerations

/// <summary>
/// An enumeration of chart element docking styles.
/// </summary>
public enum Docking
{
	/// <summary>
	/// Docked to the top.
	/// </summary>
	Top,

	/// <summary>
	/// Docked to the right.
	/// </summary>
	Right,

	/// <summary>
	/// Docked to the bottom.
	/// </summary>
	Bottom,

	/// <summary>
	/// Docked to the left.
	/// </summary>
	Left,
};

/// <summary>
/// Text drawing styles.
/// </summary>
public enum TextStyle
{
	/// <summary>
	/// Default text drawing style.
	/// </summary>
	Default,

	/// <summary>
	/// Shadow text.
	/// </summary>
	Shadow,

	/// <summary>
	/// Emboss text.
	/// </summary>
	Emboss,

	/// <summary>
	/// Embed text.
	/// </summary>
	Embed,

	/// <summary>
	/// Frame text.
	/// </summary>
	Frame
}


/// <summary>
/// An enumeration of chart text orientation.
/// </summary>
public enum TextOrientation
{
	/// <summary>
	/// Orientation is automatically determined based on the type of the 
	/// chart element it is used in.
	/// </summary>
	Auto,

	/// <summary>
	/// Horizontal text.
	/// </summary>
	Horizontal,

	/// <summary>
	/// Text rotated 90 degrees and oriented from top to bottom.
	/// </summary>
	Rotated90,

	/// <summary>
	/// Text rotated 270 degrees and oriented from bottom to top.
	/// </summary>
	Rotated270,

	/// <summary>
	/// Text characters are not rotated and position one below the other.
	/// </summary>
	Stacked
}

#endregion

/// <summary>
/// The Title class provides properties which define content, visual 
/// appearance and position of the single chart title. It also 
/// contains methods responsible for calculating title position, 
/// drawing and hit testing.
/// </summary>
[
SRDescription("DescriptionAttributeTitle5"),
]
public class Title : ChartNamedElement, IDisposable
{
	#region Fields

	// Spacing between title text and the border in pixels
	internal int titleBorderSpacing = 4;


	//***********************************************************
	//** Private data members, which store properties values
	//***********************************************************

	// Title text
	private string _text = string.Empty;

	// Title drawing style

	// Title position
	private ElementPosition _position = null;

	// Background properties
	private bool _visible = true;

	// Border properties

	// Font properties
	private FontCache _fontCache = new();
	private Font _font;
	private Color _foreColor = Color.Black;

	// Docking and Alignment properties
	private Docking _docking = Docking.Top;

	// Interactive properties


	// Default text orientation

	#endregion

	#region Constructors and Initialization

	/// <summary>
	/// Title constructor.
	/// </summary>
	public Title()
	{
		Initialize(string.Empty, Docking.Top, null, Color.Black);
	}

	/// <summary>
	/// Public constructor.
	/// </summary>
	/// <param name="text">Title text.</param>
	public Title(string text)
	{
		Initialize(text, Docking.Top, null, Color.Black);
	}

	/// <summary>
	/// Title constructor.
	/// </summary>
	/// <param name="text">Title text.</param>
	/// <param name="docking">Title docking.</param>
	public Title(string text, Docking docking)
	{
		Initialize(text, docking, null, Color.Black);
	}

	/// <summary>
	/// Title constructor.
	/// </summary>
	/// <param name="text">Title text.</param>
	/// <param name="docking">Title docking.</param>
	/// <param name="font">Title font.</param>
	/// <param name="color">Title color.</param>
	public Title(string text, Docking docking, Font font, Color color)
	{
		Initialize(text, docking, font, color);
	}

	/// <summary>
	/// Initialize title object.
	/// </summary>
	/// <param name="text">Title text.</param>
	/// <param name="docking">Title docking.</param>
	/// <param name="font">Title font.</param>
	/// <param name="color">Title color.</param>
	private void Initialize(string text, Docking docking, Font font, Color color)
	{
		// Initialize fields
		_position = new ElementPosition(this);
		_font = _fontCache.DefaultFont;
		_text = text;
		_docking = docking;
		_foreColor = color;
		if (font != null)
		{
			_font = font;
		}
	}

	#endregion

	#region	Properties

	/// <summary>
	/// Gets or sets the unique name of a ChartArea object.
	/// </summary>
	[
	SRCategory("CategoryAttributeMisc"),
	Bindable(true),
	SRDescription("DescriptionAttributeTitle_Name"),
	NotifyParentProperty(true),
	]
	public override string Name
	{
		get
		{
			return base.Name;
		}
		set
		{
			base.Name = value;
		}
	}

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
			Invalidate(true);
		}
	} = TextOrientation.Auto;

	/// <summary>
	/// Gets or sets a flag that specifies whether the title is visible.
	/// </summary>
	/// <value>
	/// <b>True</b> if the title is visible; <b>false</b> otherwise.
	/// </value>
	[
	SRCategory("CategoryAttributeAppearance"),
	DefaultValue(true),
	SRDescription("DescriptionAttributeTitle_Visible"),
	ParenthesizePropertyName(true),
	]
	virtual public bool Visible
	{
		get
		{
			return _visible;
		}
		set
		{
			_visible = value;
			Invalidate(false);
		}
	}

	/// <summary>
	/// Gets or sets the chart area name which the title is docked to inside or outside.
	/// </summary>
	[
	SRCategory("CategoryAttributeDocking"),
	Bindable(true),
		DefaultValue(Constants.NotSetValue),
	SRDescription("DescriptionAttributeTitle_DockToChartArea"),
		TypeConverter(typeof(LegendAreaNameConverter)),
	NotifyParentProperty(true)
	]
	public string DockedToChartArea
	{
		get;
		set
		{
			if (value != field)
			{
				if (value.Length == 0)
				{
					field = Constants.NotSetValue;
				}
				else
				{
					if (Chart != null && Chart.ChartAreas != null)
					{
						Chart.ChartAreas.VerifyNameReference(value);
					}

					field = value;
				}

				Invalidate(false);
			}
		}
	} = Constants.NotSetValue;

	/// <summary>
	/// Gets or sets a property which indicates whether the title is docked inside chart area. 
	/// DockedToChartArea property must be set first.
	/// </summary>
	[
		SRCategory("CategoryAttributeDocking"),
	Bindable(true),
	DefaultValue(true),
	SRDescription("DescriptionAttributeTitle_DockInsideChartArea"),
	NotifyParentProperty(true)
	]
	public bool IsDockedInsideChartArea
	{
		get;
		set
		{
			if (value != field)
			{
				field = value;
				Invalidate(false);
			}
		}
	} = true;

	/// <summary>
	/// Gets or sets the positive or negative offset of the docked title position.
	/// </summary>
	[
	SRCategory("CategoryAttributeDocking"),
	Bindable(true),
	DefaultValue(0),
	SRDescription("DescriptionAttributeTitle_DockOffset"),
	NotifyParentProperty(true)
	]
	public int DockingOffset
	{
		get;
		set
		{
			if (value != field)
			{
				if (value < -100 || value > 100)
				{
					throw (new ArgumentOutOfRangeException(nameof(value), SR.ExceptionValueMustBeInRange(nameof(DockingOffset), (-100).ToString(CultureInfo.CurrentCulture), (100).ToString(CultureInfo.CurrentCulture))));
				}

				field = value;
				Invalidate(false);
			}
		}
	} = 0;

	/// <summary>
	/// Gets or sets the position of the title.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	SRDescription("DescriptionAttributeTitle_Position"),
	DesignerSerializationVisibility(DesignerSerializationVisibility.Content),
	NotifyParentProperty(true),
		TypeConverter(typeof(ElementPositionConverter)),
	SerializationVisibility(SerializationVisibility.Element)
	]
	public ElementPosition Position
	{
		get
		{
			// Serialize only position values if Auto set to false
			if (Chart != null && Chart.serializationStatus == SerializationStatus.Saving)
			{
				if (_position.Auto)
				{
					return new ElementPosition();
				}
				else
				{
					ElementPosition newPosition = new()
					{
						Auto = false
					};
					newPosition.SetPositionNoAuto(_position.X, _position.Y, _position.Width, _position.Height);
					return newPosition;
				}
			}

			return _position;
		}
		set
		{
			_position = value;
			_position.Parent = this;
			Invalidate(false);
		}
	}

	/// <summary>
	/// Determoines if this position should be serialized.
	/// </summary>
	/// <returns></returns>
	internal bool ShouldSerializePosition()
	{
		return !Position.Auto;
	}


	/// <summary>
	/// Gets or sets the text of the title.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(""),
	SRDescription("DescriptionAttributeTitle_Text"),
	NotifyParentProperty(true),
	ParenthesizePropertyName(true)
	]
	public string Text
	{
		get
		{
			return _text;
		}
		set
		{
			_text = (value == null) ? string.Empty : value;
			Invalidate(false);
		}
	}


	/// <summary>
	/// Title drawing style.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(TextStyle.Default),
	SRDescription("DescriptionAttributeTextStyle"),
	NotifyParentProperty(true)
	]
	public TextStyle TextStyle
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
		}
	} = TextStyle.Default;

	/// <summary>
	/// Gets or sets the background color of the title.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeBackColor"),
	NotifyParentProperty(true),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BackColor
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the border color of the title.
	/// </summary>
	[
		SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), ""),
		SRDescription("DescriptionAttributeBorderColor"),
	NotifyParentProperty(true),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color BorderColor
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
		}
	} = Color.Empty;

	/// <summary>
	/// Gets or sets the border style of the title.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(ChartDashStyle.Solid),
		SRDescription("DescriptionAttributeBorderDashStyle"),
	NotifyParentProperty(true),
	]
	public ChartDashStyle BorderDashStyle
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
		}
	} = ChartDashStyle.Solid;

	/// <summary>
	/// Gets or sets the border width of the title.
	/// </summary>
	[
		SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(1),
		SRDescription("DescriptionAttributeBorderWidth"),
	NotifyParentProperty(true),
	]
	public int BorderWidth
	{
		get;
		set
		{
			if (value < 0)
			{
				throw (new ArgumentOutOfRangeException(nameof(value), SR.ExceptionTitleBorderWidthIsNegative));
			}

			field = value;
			Invalidate(false);
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
		NotifyParentProperty(true),
	]
	public string BackImage
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
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
		SRDescription("DescriptionAttributeImageWrapMode"),
	]
	public ChartImageWrapMode BackImageWrapMode
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
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
			Invalidate(true);
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
		SRDescription("DescriptionAttributeBackImageAlign"),
	]
	public ChartImageAlignmentStyle BackImageAlignment
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
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
	NotifyParentProperty(true),
		SRDescription("DescriptionAttributeBackGradientStyle"),
		Editor(typeof(GradientEditor), typeof(UITypeEditor))
		]
	public GradientStyle BackGradientStyle
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
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
	NotifyParentProperty(true),
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
			Invalidate(true);
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
	NotifyParentProperty(true),
		SRDescription("DescriptionAttributeBackHatchStyle"),
		Editor(typeof(HatchStyleEditor), typeof(UITypeEditor))
		]
	public ChartHatchStyle BackHatchStyle
	{
		get;
		set
		{
			field = value;
			Invalidate(true);
		}
	} = ChartHatchStyle.None;

	/// <summary>
	/// Gets or sets the title font.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Font), "Microsoft Sans Serif, 8pt"),
	SRDescription("DescriptionAttributeTitle_Font"),
	NotifyParentProperty(true),
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
			Invalidate(false);
		}
	}

	/// <summary>
	/// Gets or sets the title fore color.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), "Black"),
	SRDescription("DescriptionAttributeTitle_Color"),
	NotifyParentProperty(true),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color ForeColor
	{
		get
		{
			return _foreColor;
		}
		set
		{
			_foreColor = value;
			Invalidate(true);
		}
	}

	/// <summary>
	/// Gets or sets title alignment.
	/// </summary>
	[
	SRCategory("CategoryAttributeDocking"),
	Bindable(true),
	DefaultValue(ContentAlignment.MiddleCenter),
	SRDescription("DescriptionAttributeTitle_Alignment"),
	NotifyParentProperty(true)
	]
	public ContentAlignment Alignment
	{
		get;
		set
		{
			field = value;
			Invalidate(false);
		}
	} = ContentAlignment.MiddleCenter;

	/// <summary>
	/// Gets or sets the title docking style.
	/// </summary>
	[
		SRCategory("CategoryAttributeDocking"),
	Bindable(true),
	DefaultValue(Docking.Top),
	SRDescription("DescriptionAttributeTitle_Docking"),
	NotifyParentProperty(true)
	]
	public Docking Docking
	{
		get
		{
			return _docking;
		}
		set
		{
			_docking = value;
			Invalidate(false);
		}
	}

	/// <summary>
	/// Gets or sets the title shadow offset.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(0),
		SRDescription("DescriptionAttributeShadowOffset"),
	NotifyParentProperty(true)
	]
	public int ShadowOffset
	{
		get;
		set
		{
			field = value;
			Invalidate(false);
		}
	} = 0;

	/// <summary>
	/// Gets or sets the title shadow color.
	/// </summary>
	[
	SRCategory("CategoryAttributeAppearance"),
	Bindable(true),
	DefaultValue(typeof(Color), "128, 0, 0, 0"),
		SRDescription("DescriptionAttributeShadowColor"),
	NotifyParentProperty(true),
		TypeConverter(typeof(ColorConverter)),
		Editor(typeof(ChartColorEditor), typeof(UITypeEditor))
		]
	public Color ShadowColor
	{
		get;
		set
		{
			field = value;
			Invalidate(false);
		}
	} = Color.FromArgb(128, 0, 0, 0);

	/// <summary>
	/// Gets or sets the tooltip.
	/// </summary>
	[
	SRCategory("CategoryAttributeToolTip"),
	Bindable(true),
		SRDescription("DescriptionAttributeToolTip"),
	DefaultValue("")
	]
	public string ToolTip { set; get; } = string.Empty;

	/// <summary>
	/// True if title background or border is visible
	/// </summary>
	internal bool BackGroundIsVisible
	{
		get
		{
			if (!BackColor.IsEmpty ||
				BackImage.Length > 0 ||
				(!BorderColor.IsEmpty && BorderDashStyle != ChartDashStyle.NotSet))
			{
				return true;
			}

			return false;
		}
	}

	#endregion

	#region Helper Methods

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
	/// Returns title text orientation. If set to Auto automatically determines the
	/// orientation based on title docking.
	/// </summary>
	/// <returns>Current text orientation.</returns>
	private TextOrientation GetTextOrientation()
	{
		if (TextOrientation == TextOrientation.Auto)
		{
			// When chart title is docked to the left or right we automatically 
			// set vertical text with different rotation angles.
			if (Position.Auto)
			{
				if (Docking == Docking.Left)
				{
					return TextOrientation.Rotated270;
				}
				else if (Docking == Docking.Right)
				{
					return TextOrientation.Rotated90;
				}
			}

			return TextOrientation.Horizontal;
		}

		return TextOrientation;
	}

	/// <summary>
	/// Helper method that checks if title is visible.
	/// </summary>
	/// <returns>True if title is visible.</returns>
	internal bool IsVisible()
	{
		if (Visible)
		{

			// Check if title is docked to the chart area
			if (DockedToChartArea.Length > 0 &&
				Chart != null)
			{
				if (Chart.ChartAreas.IndexOf(DockedToChartArea) >= 0)
				{
					// Do not show title when it is docked to invisible chart area
					ChartArea area = Chart.ChartAreas[DockedToChartArea];
					if (!area.Visible)
					{
						return false;
					}
				}
			}


			return true;
		}

		return false;
	}

	/// <summary>
	/// Invalidate chart title when one of the properties is changed.
	/// </summary>
	/// <param name="invalidateTitleOnly">Indicates that only title area should be invalidated.</param>
	[SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters", Justification = "This parameter is used when compiling for the WinForms version of Chart")]
	internal void Invalidate(bool invalidateTitleOnly)
	{
		if (Chart != null)
		{
			// Set dirty flag
			Chart.dirtyFlag = true;

			// Invalidate chart
			if (invalidateTitleOnly)
			{
				// Calculate the position of the title
				Rectangle invalRect = Chart.ClientRectangle;
				if (Position.Width != 0 && Position.Height != 0)
				{
					// Convert relative coordinates to absolute coordinates
					invalRect.X = (int)(Position.X * (Common.ChartPicture.Width - 1) / 100F);
					invalRect.Y = (int)(Position.Y * (Common.ChartPicture.Height - 1) / 100F);
					invalRect.Width = (int)(Position.Width * (Common.ChartPicture.Width - 1) / 100F);
					invalRect.Height = (int)(Position.Height * (Common.ChartPicture.Height - 1) / 100F);

					// Inflate rectangle size using border size and shadow size
					invalRect.Inflate(BorderWidth + ShadowOffset + 1, BorderWidth + ShadowOffset + 1);
				}

				// Invalidate title rectangle only
				Chart.Invalidate(invalRect);
			}
			else
			{
				Invalidate();
			}
		}
	}

	#endregion

	#region Painting and Selection Methods

	/// <summary>
	/// Paints title using chart graphics object.
	/// </summary>
	/// <param name="chartGraph">The graph provides drawing object to the display device. A Graphics object is associated with a specific device context.</param>
	[SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode")]
	internal void Paint(ChartGraphics chartGraph)
	{
		// check if title is visible
		if (!IsVisible())
		{
			return;
		}

		// Title text
		string titleText = Text;

		//***************************************************************
		//** Calculate title relative position
		//***************************************************************
		RectangleF titlePosition = Position.ToRectangleF();

		// Auto set the title position if width or height is not set for custom position
		if (!Position.Auto && Common != null && Common.ChartPicture != null)
		{
			if (titlePosition.Width == 0 || titlePosition.Height == 0)
			{
				// Calculate text layout area
				SizeF layoutArea = new(
						(titlePosition.Width == 0) ? Common.ChartPicture.Width : titlePosition.Width,
						(titlePosition.Height == 0) ? Common.ChartPicture.Height : titlePosition.Height);
				if (IsTextVertical)
				{
					float tempValue = layoutArea.Width;
					layoutArea.Width = layoutArea.Height;
					layoutArea.Height = tempValue;
				}

				// Measure text size
				layoutArea = chartGraph.GetAbsoluteSize(layoutArea);
				SizeF titleSize = chartGraph.MeasureString(
					"W" + titleText.Replace("\\n", "\n"),
					Font,
					layoutArea,
					StringFormat.GenericDefault,
						GetTextOrientation());

				// Increase text size by 4 pixels
				if (BackGroundIsVisible)
				{
					titleSize.Width += titleBorderSpacing;
					titleSize.Height += titleBorderSpacing;
				}

				// Switch width and height for vertical text
				if (IsTextVertical)
				{
					float tempValue = titleSize.Width;
					titleSize.Width = titleSize.Height;
					titleSize.Height = tempValue;
				}

				// Convert text size to relative coordinates
				titleSize = chartGraph.GetRelativeSize(titleSize);

				// Update custom position
				if (titlePosition.Width == 0)
				{
					titlePosition.Width = titleSize.Width;
					if (Alignment == ContentAlignment.BottomRight ||
						Alignment == ContentAlignment.MiddleRight ||
						Alignment == ContentAlignment.TopRight)
					{
						titlePosition.X = titlePosition.X - titlePosition.Width;
					}
					else if (Alignment == ContentAlignment.BottomCenter ||
						Alignment == ContentAlignment.MiddleCenter ||
						Alignment == ContentAlignment.TopCenter)
					{
						titlePosition.X = titlePosition.X - titlePosition.Width / 2f;
					}
				}

				if (titlePosition.Height == 0)
				{
					titlePosition.Height = titleSize.Height;
					if (Alignment == ContentAlignment.BottomRight ||
						Alignment == ContentAlignment.BottomCenter ||
						Alignment == ContentAlignment.BottomLeft)
					{
						titlePosition.Y = titlePosition.Y - titlePosition.Height;
					}
					else if (Alignment == ContentAlignment.MiddleCenter ||
						Alignment == ContentAlignment.MiddleLeft ||
						Alignment == ContentAlignment.MiddleRight)
					{
						titlePosition.Y = titlePosition.Y - titlePosition.Height / 2f;
					}
				}

			}
		}

		//***************************************************************
		//** Convert title position to absolute coordinates
		//***************************************************************
		RectangleF absPosition = new(titlePosition.Location, titlePosition.Size);
		absPosition = chartGraph.GetAbsoluteRectangle(absPosition);

		//***************************************************************
		//** Draw title background, border and shadow
		//***************************************************************
		if (BackGroundIsVisible && Common.ProcessModePaint)
		{
			chartGraph.FillRectangleRel(titlePosition,
				BackColor,
				BackHatchStyle,
				BackImage,
				BackImageWrapMode,
				BackImageTransparentColor,
				BackImageAlignment,
				BackGradientStyle,
				BackSecondaryColor,
				BorderColor,
				BorderWidth,
				BorderDashStyle,
				ShadowColor,
				ShadowOffset,
				PenAlignment.Inset);
		}
		else
		{
			// Adjust text position to be only around the text itself
			SizeF titleArea = chartGraph.GetAbsoluteSize(titlePosition.Size);
			SizeF titleSize = chartGraph.MeasureString(
					"W" + titleText.Replace("\\n", "\n"),
				Font,
				titleArea,
					StringFormat.GenericDefault,
					GetTextOrientation());

			// Convert text size to relative coordinates
			titleSize = chartGraph.GetRelativeSize(titleSize);

			// Adjust position depending on alignment
			RectangleF exactTitleRect = new(
				titlePosition.X,
				titlePosition.Y,
				titleSize.Width,
				titleSize.Height);
			if (Alignment == ContentAlignment.BottomCenter ||
				Alignment == ContentAlignment.BottomLeft ||
				Alignment == ContentAlignment.BottomRight)
			{
				exactTitleRect.Y = titlePosition.Bottom - exactTitleRect.Height;
			}
			else if (Alignment == ContentAlignment.MiddleCenter ||
				Alignment == ContentAlignment.MiddleLeft ||
				Alignment == ContentAlignment.MiddleRight)
			{
				exactTitleRect.Y = titlePosition.Y +
					titlePosition.Height / 2f -
					exactTitleRect.Height / 2f;
			}

			if (Alignment == ContentAlignment.BottomRight ||
				Alignment == ContentAlignment.MiddleRight ||
				Alignment == ContentAlignment.TopRight)
			{
				exactTitleRect.X = titlePosition.Right - exactTitleRect.Width;
			}
			else if (Alignment == ContentAlignment.BottomCenter ||
				Alignment == ContentAlignment.MiddleCenter ||
				Alignment == ContentAlignment.TopCenter)
			{
				exactTitleRect.X = titlePosition.X +
					titlePosition.Width / 2f -
					exactTitleRect.Width / 2f;
			}

			// NOTE: This approach for text selection can not be used with
			// Flash animations because of the bug in Flash viewer. When the 
			// button shape is placed in the last frame the Alpha value of the
			// color is ignored.

			// NOTE: Feature tested again with Flash Player 7 and it seems to be 
			// working fine. Code below is commented to enable selection in flash
			// through transparent rectangle.
			// Fixes issue #4172.

			bool drawRect = true;

			// Draw transparent rectangle in the text position
			if (drawRect)
			{
				chartGraph.FillRectangleRel(
					exactTitleRect,
					Color.FromArgb(0, Color.White),
					ChartHatchStyle.None,
					string.Empty,
					ChartImageWrapMode.Tile,
					BackImageTransparentColor,
					BackImageAlignment,
					GradientStyle.None,
					BackSecondaryColor,
					Color.Transparent,
					0,
					BorderDashStyle,
					Color.Transparent,
					0,
					PenAlignment.Inset);
			}

			// End Selection mode
			chartGraph.EndHotRegion();
		}

		if (Common.ProcessModePaint)
		{
			Common.Chart.CallOnPrePaint(new ChartPaintEventArgs(this, chartGraph, Common, Position));
		}

		//***************************************************************
		//** Add spacing between text and border
		//***************************************************************
		if (BackGroundIsVisible)
		{
			absPosition.Width -= titleBorderSpacing;
			absPosition.Height -= titleBorderSpacing;
			absPosition.X += titleBorderSpacing / 2f;
			absPosition.Y += titleBorderSpacing / 2f;
		}

		//***************************************************************
		//** Create string format
		//***************************************************************
		using StringFormat format = new();
		format.Alignment = StringAlignment.Center;
		format.LineAlignment = StringAlignment.Center;

		if (Alignment == ContentAlignment.BottomCenter ||
			Alignment == ContentAlignment.BottomLeft ||
			Alignment == ContentAlignment.BottomRight)
		{
			format.LineAlignment = StringAlignment.Far;
		}
		else if (Alignment == ContentAlignment.TopCenter ||
			Alignment == ContentAlignment.TopLeft ||
			Alignment == ContentAlignment.TopRight)
		{
			format.LineAlignment = StringAlignment.Near;
		}

		if (Alignment == ContentAlignment.BottomLeft ||
			Alignment == ContentAlignment.MiddleLeft ||
			Alignment == ContentAlignment.TopLeft)
		{
			format.Alignment = StringAlignment.Near;
		}
		else if (Alignment == ContentAlignment.BottomRight ||
			Alignment == ContentAlignment.MiddleRight ||
			Alignment == ContentAlignment.TopRight)
		{
			format.Alignment = StringAlignment.Far;
		}

		//***************************************************************
		//** Draw text shadow for the default style when background is not drawn anf ShadowOffset is not null
		//***************************************************************
		Color textShadowColor = ChartGraphics.GetGradientColor(ForeColor, Color.Black, 0.8);
		int textShadowOffset = 1;
		TextStyle textStyle = TextStyle;
		if ((textStyle == TextStyle.Default || textStyle == TextStyle.Shadow) &&
			!BackGroundIsVisible &&
			ShadowOffset != 0)
		{
			// Draw shadowed text
			textStyle = TextStyle.Shadow;
			textShadowColor = ShadowColor;
			textShadowOffset = ShadowOffset;
		}

		if (textStyle == TextStyle.Shadow)
		{
			textShadowColor = (textShadowColor.A != 255) ? textShadowColor : Color.FromArgb(textShadowColor.A / 2, textShadowColor);
		}

		//***************************************************************
		//** Replace new line characters
		//***************************************************************
		titleText = titleText.Replace("\\n", "\n");

		//***************************************************************
		//** Define text angle depending on the docking
		//***************************************************************
		Matrix oldTransform = null;
		if (IsTextVertical)
		{
			if (GetTextOrientation() == TextOrientation.Rotated270)
			{
				// IMPORTANT !
				// Right to Left flag has to be used because of bug with .net with multi line vertical text. As soon as .net bug is fixed this flag HAS TO be removed. Bug number 1870.
				format.FormatFlags |= StringFormatFlags.DirectionVertical | StringFormatFlags.DirectionRightToLeft;

				// Save old graphics transformation
				oldTransform = chartGraph.Transform.Clone();

				// Rotate tile 180 degrees at center
				PointF center = PointF.Empty;

				center.X = absPosition.X + absPosition.Width / 2F;
				center.Y = absPosition.Y + absPosition.Height / 2F;

				// Create and set new transformation matrix
				Matrix newMatrix = chartGraph.Transform.Clone();
				newMatrix.RotateAt(180, center);
				chartGraph.Transform = newMatrix;
			}
			else if (GetTextOrientation() == TextOrientation.Rotated90)
			{
				// IMPORTANT !
				// Right to Left flag has to be used because of bug with .net with multi line vertical text. As soon as .net bug is fixed this flag HAS TO be removed. Bug number 1870.
				format.FormatFlags |= StringFormatFlags.DirectionVertical | StringFormatFlags.DirectionRightToLeft;
			}
		}

		try
		{
			chartGraph.IsTextClipped = !Position.Auto;
			DrawStringWithStyle(chartGraph, titleText, textStyle, Font, absPosition, ForeColor, textShadowColor, textShadowOffset, format, GetTextOrientation());
		}
		finally
		{
			chartGraph.IsTextClipped = false;
		}
		// Call Paint event
		if (Common.ProcessModePaint)
		{
			Common.Chart.CallOnPostPaint(new ChartPaintEventArgs(this, chartGraph, Common, Position));
		}

		//***************************************************************
		//** Restore old transformation
		//***************************************************************
		if (oldTransform != null)
		{
			chartGraph.Transform = oldTransform;
		}

		if (Common.ProcessModeRegions)
		{
			Common.HotRegionsList.AddHotRegion(titlePosition, ToolTip, null, null, null, this, ChartElementType.Title, null);
		}
	}

	/// <summary>
	/// Draws the string with style.
	/// </summary>
	/// <param name="chartGraph">The chart graph.</param>
	/// <param name="titleText">The title text.</param>
	/// <param name="textStyle">The text style.</param>
	/// <param name="font">The font.</param>
	/// <param name="absPosition">The abs position.</param>
	/// <param name="foreColor">Color of the fore.</param>
	/// <param name="shadowColor">Color of the shadow.</param>
	/// <param name="shadowOffset">The shadow offset.</param>
	/// <param name="format">The format.</param>
	/// <param name="orientation">The orientation.</param>
	internal static void DrawStringWithStyle(
		ChartGraphics chartGraph,
		string titleText,
		TextStyle textStyle,
		Font font,
		RectangleF absPosition,
		Color foreColor,
		Color shadowColor,
		int shadowOffset,
		StringFormat format,
		TextOrientation orientation
		)
	{
		//***************************************************************
		//** Draw title text
		//***************************************************************
		if (titleText.Length > 0)
		{
			if (textStyle == TextStyle.Default)
			{
				using SolidBrush brush = new(foreColor);
				chartGraph.DrawString(titleText, font, brush, absPosition, format, orientation);
			}
			else if (textStyle == TextStyle.Frame)
			{
				using GraphicsPath graphicsPath = new();
				graphicsPath.AddString(
					titleText,
					font.FontFamily,
					(int)font.Style,
					font.Size * 1.3f,
					absPosition,
					format);
				graphicsPath.CloseAllFigures();


				using Pen pen = new(foreColor, 1);
				chartGraph.DrawPath(pen, graphicsPath);
			}
			else if (textStyle == TextStyle.Embed)
			{
				// Draw shadow
				RectangleF shadowPosition = new(absPosition.Location, absPosition.Size);
				shadowPosition.X -= 1;
				shadowPosition.Y -= 1;
				using (SolidBrush brush = new(shadowColor))
				{
					chartGraph.DrawString(titleText, font, brush, shadowPosition, format, orientation);
				}
				// Draw highlighting
				shadowPosition.X += 2;
				shadowPosition.Y += 2;
				Color texthighlightColor = ChartGraphics.GetGradientColor(Color.White, foreColor, 0.3);
				using (SolidBrush brush = new(texthighlightColor))
				{
					chartGraph.DrawString(titleText, font, brush, shadowPosition, format, orientation);
				}

				using (SolidBrush brush = new(foreColor))
				{
					// Draw text
					chartGraph.DrawString(titleText, font, brush, absPosition, format, orientation);
				}
			}
			else if (textStyle == TextStyle.Emboss)
			{
				// Draw shadow
				RectangleF shadowPosition = new(absPosition.Location, absPosition.Size);
				shadowPosition.X += 1;
				shadowPosition.Y += 1;
				using (SolidBrush brush = new(shadowColor))
				{
					chartGraph.DrawString(titleText, font, brush, shadowPosition, format, orientation);
				}
				// Draw highlighting
				shadowPosition.X -= 2;
				shadowPosition.Y -= 2;
				Color texthighlightColor = ChartGraphics.GetGradientColor(Color.White, foreColor, 0.3);
				using (SolidBrush brush = new(texthighlightColor))
				{
					chartGraph.DrawString(titleText, font, brush, shadowPosition, format, orientation);
				}
				// Draw text
				using (SolidBrush brush = new(foreColor))
				{
					chartGraph.DrawString(titleText, font, brush, absPosition, format, orientation);
				}

			}
			else if (textStyle == TextStyle.Shadow)
			{
				// Draw shadow
				RectangleF shadowPosition = new(absPosition.Location, absPosition.Size);
				shadowPosition.X += shadowOffset;
				shadowPosition.Y += shadowOffset;
				using (SolidBrush brush = new(shadowColor))
				{
					chartGraph.DrawString(titleText, font, brush, shadowPosition, format, orientation);
				}
				// Draw text
				using (SolidBrush brush = new(foreColor))
				{
					chartGraph.DrawString(titleText, font, brush, absPosition, format, orientation);
				}

			}
		}
	}

	#endregion

	#region Position Calculation Methods

	/// <summary>
	/// Recalculates title position.
	/// </summary>
	/// <param name="chartGraph">Chart graphics used.</param>
	/// <param name="chartAreasRectangle">Area where the title should be docked.</param>
	/// <param name="frameTitlePosition">Position of the title in the frame.</param>
	/// <param name="elementSpacing">Spacing size in percentage of the area.</param>
	internal void CalcTitlePosition(
		ChartGraphics chartGraph,
		ref RectangleF chartAreasRectangle,
		ref RectangleF frameTitlePosition,
		float elementSpacing)
	{
		// Special case for the first title docked to the top when the title frame is used
		if (!frameTitlePosition.IsEmpty &&
			Position.Auto &&
			Docking == Docking.Top &&
				DockedToChartArea == Constants.NotSetValue)
		{
			Position.SetPositionNoAuto(
				frameTitlePosition.X + elementSpacing,
				frameTitlePosition.Y,
				frameTitlePosition.Width - 2f * elementSpacing,
				frameTitlePosition.Height);
			frameTitlePosition = RectangleF.Empty;
			return;
		}

		// Get title size
		RectangleF titlePosition = new();
		SizeF layoutArea = new(chartAreasRectangle.Width, chartAreasRectangle.Height);

		// Switch width and height for vertical text
		if (IsTextVertical)
		{
			float tempValue = layoutArea.Width;
			layoutArea.Width = layoutArea.Height;
			layoutArea.Height = tempValue;
		}

		// Meausure text size
		layoutArea.Width -= 2f * elementSpacing;
		layoutArea.Height -= 2f * elementSpacing;
		layoutArea = chartGraph.GetAbsoluteSize(layoutArea);
		SizeF titleSize = chartGraph.MeasureString(
				"W" + Text.Replace("\\n", "\n"),
			Font,
			layoutArea,
			StringFormat.GenericDefault,
				GetTextOrientation());

		// Increase text size by 4 pixels
		if (BackGroundIsVisible)
		{
			titleSize.Width += titleBorderSpacing;
			titleSize.Height += titleBorderSpacing;
		}

		// Switch width and height for vertical text
		if (IsTextVertical)
		{
			float tempValue = titleSize.Width;
			titleSize.Width = titleSize.Height;
			titleSize.Height = tempValue;
		}

		// Convert text size to relative coordinates
		titleSize = chartGraph.GetRelativeSize(titleSize);
		titlePosition.Height = titleSize.Height;
		titlePosition.Width = titleSize.Width;
		if (float.IsNaN(titleSize.Height) || float.IsNaN(titleSize.Width))
		{
			return;
		}

		// Calculate title position
		if (Docking == Docking.Top)
		{
			titlePosition.Y = chartAreasRectangle.Y + elementSpacing;
			titlePosition.X = chartAreasRectangle.X + elementSpacing;
			titlePosition.Width = chartAreasRectangle.Right - titlePosition.X - elementSpacing;
			if (titlePosition.Width < 0)
			{
				titlePosition.Width = 0;
			}

			// Adjust position of the chart area(s)
			chartAreasRectangle.Height -= titlePosition.Height + elementSpacing;
			chartAreasRectangle.Y = titlePosition.Bottom;
		}
		else if (Docking == Docking.Bottom)
		{
			titlePosition.Y = chartAreasRectangle.Bottom - titleSize.Height - elementSpacing;
			titlePosition.X = chartAreasRectangle.X + elementSpacing;
			titlePosition.Width = chartAreasRectangle.Right - titlePosition.X - elementSpacing;
			if (titlePosition.Width < 0)
			{
				titlePosition.Width = 0;
			}

			// Adjust position of the chart area(s)
			chartAreasRectangle.Height -= titlePosition.Height + elementSpacing;
		}

		if (Docking == Docking.Left)
		{
			titlePosition.X = chartAreasRectangle.X + elementSpacing;
			titlePosition.Y = chartAreasRectangle.Y + elementSpacing;
			titlePosition.Height = chartAreasRectangle.Bottom - titlePosition.Y - elementSpacing;
			if (titlePosition.Height < 0)
			{
				titlePosition.Height = 0;
			}

			// Adjust position of the chart area(s)
			chartAreasRectangle.Width -= titlePosition.Width + elementSpacing;
			chartAreasRectangle.X = titlePosition.Right;
		}

		if (Docking == Docking.Right)
		{
			titlePosition.X = chartAreasRectangle.Right - titleSize.Width - elementSpacing;
			titlePosition.Y = chartAreasRectangle.Y + elementSpacing;
			titlePosition.Height = chartAreasRectangle.Bottom - titlePosition.Y - elementSpacing;
			if (titlePosition.Height < 0)
			{
				titlePosition.Height = 0;
			}

			// Adjust position of the chart area(s)
			chartAreasRectangle.Width -= titlePosition.Width + elementSpacing;
		}


		// Offset calculated docking position
		if (DockingOffset != 0)
		{
			if (Docking == Docking.Top || Docking == Docking.Bottom)
			{
				titlePosition.Y += DockingOffset;
			}
			else
			{
				titlePosition.X += DockingOffset;
			}
		}

		Position.SetPositionNoAuto(titlePosition.X, titlePosition.Y, titlePosition.Width, titlePosition.Height);
	}

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

			_position?.Dispose();
			_position = null;
		}
	}


	#endregion
}

/// <summary>
/// The TitleCollection class is a strongly typed collection of Title classes.
/// Indexer of this collection can take the title index (integer) or unique 
/// title name (string) as a parameter.
/// </summary>
[
	SRDescription("DescriptionAttributeTitles"),
]
public class TitleCollection : ChartNamedElementCollection<Title>
{

	#region Constructors

	/// <summary>
	/// TitleCollection constructor.
	/// </summary>
	/// <param name="parent">Parent chart element.</param>
	internal TitleCollection(IChartElement parent)
		: base(parent)
	{
	}

	#endregion

	#region Methods

	/// <summary>
	/// Creates a new Title with the specified name and adds it to the collection.
	/// </summary>
	/// <param name="name">The new chart area name.</param>
	/// <returns>New title</returns>
	public Title Add(string name)
	{
		Title title = new(name);
		Add(title);
		return title;
	}


	/// <summary>
	/// Recalculates title position in the collection for titles docked outside of chart area.
	/// </summary>
	/// <param name="chartPicture">Chart picture object.</param>
	/// <param name="chartGraph">Chart graphics used.</param>
	/// <param name="area">Area the title is docked to.</param>
	/// <param name="chartAreasRectangle">Area where the title should be positioned.</param>
	/// <param name="elementSpacing">Spacing size in percentage of the area.</param>
	internal static void CalcOutsideTitlePosition(
		ChartPicture chartPicture,
		ChartGraphics chartGraph,
		ChartArea area,
		ref RectangleF chartAreasRectangle,
		float elementSpacing)
	{
		if (chartPicture != null)
		{
			// Get elemets spacing
			float areaSpacing = Math.Min((chartAreasRectangle.Height / 100F) * elementSpacing, (chartAreasRectangle.Width / 100F) * elementSpacing);

			// Loop through all titles
			foreach (Title title in chartPicture.Titles)
			{
				// Check if title visible
				if (!title.IsVisible())
				{
					continue;
				}

				// Check if all chart area names are valid
				if (title.DockedToChartArea != Constants.NotSetValue && chartPicture.ChartAreas.IndexOf(title.DockedToChartArea) < 0)
				{
					throw (new ArgumentException(SR.ExceptionChartTitleDockedChartAreaIsMissing((string)title.DockedToChartArea)));
				}

				// Process only titles docked to specified area
				if (title.IsDockedInsideChartArea == false &&
					title.DockedToChartArea == area.Name &&
					title.Position.Auto)
				{
					// Calculate title position
					RectangleF frameRect = RectangleF.Empty;
					RectangleF prevChartAreasRectangle = chartAreasRectangle;
					title.CalcTitlePosition(chartGraph,
						ref chartAreasRectangle,
						ref frameRect,
						areaSpacing);

					// Adjust title position
					RectangleF titlePosition = title.Position.ToRectangleF();
					if (title.Docking == Docking.Top)
					{
						titlePosition.Y -= areaSpacing;
						if (!area.Position.Auto)
						{
							titlePosition.Y -= titlePosition.Height;
							prevChartAreasRectangle.Y -= titlePosition.Height + areaSpacing;
							prevChartAreasRectangle.Height += titlePosition.Height + areaSpacing;
						}
					}
					else if (title.Docking == Docking.Bottom)
					{
						titlePosition.Y += areaSpacing;
						if (!area.Position.Auto)
						{
							titlePosition.Y = prevChartAreasRectangle.Bottom + areaSpacing;
							prevChartAreasRectangle.Height += titlePosition.Height + areaSpacing;
						}
					}

					if (title.Docking == Docking.Left)
					{
						titlePosition.X -= areaSpacing;
						if (!area.Position.Auto)
						{
							titlePosition.X -= titlePosition.Width;
							prevChartAreasRectangle.X -= titlePosition.Width + areaSpacing;
							prevChartAreasRectangle.Width += titlePosition.Width + areaSpacing;
						}
					}

					if (title.Docking == Docking.Right)
					{
						titlePosition.X += areaSpacing;
						if (!area.Position.Auto)
						{
							titlePosition.X = prevChartAreasRectangle.Right + areaSpacing;
							prevChartAreasRectangle.Width += titlePosition.Width + areaSpacing;
						}
					}

					// Set title position without changing the 'Auto' flag
					title.Position.SetPositionNoAuto(titlePosition.X, titlePosition.Y, titlePosition.Width, titlePosition.Height);

					// If custom position is used in the chart area reset the curent adjusted position
					if (!area.Position.Auto)
					{
						chartAreasRectangle = prevChartAreasRectangle;
					}

				}
			}

		}
	}

	/// <summary>
	/// Recalculates all titles position inside chart area in the collection.
	/// </summary>
	/// <param name="chartPicture">Chart picture object.</param>
	/// <param name="chartGraph">Chart graphics used.</param>
	/// <param name="elementSpacing">Spacing size in percentage of the area.</param>
	internal static void CalcInsideTitlePosition(
		ChartPicture chartPicture,
		ChartGraphics chartGraph,
		float elementSpacing)
	{
		if (chartPicture != null)
		{
			// Check if all chart area names are valid
			foreach (Title title in chartPicture.Titles)
			{
				// Check if title visible
				if (!title.IsVisible())
				{
					continue;
				}

				if (title.DockedToChartArea != Constants.NotSetValue)
				{
					try
					{
						ChartArea area = chartPicture.ChartAreas[title.DockedToChartArea];
					}
					catch
					{
						throw (new ArgumentException(SR.ExceptionChartTitleDockedChartAreaIsMissing((string)title.DockedToChartArea)));
					}
				}
			}

			// Loop through all chart areas
			foreach (ChartArea area in chartPicture.ChartAreas)
			{

				// Check if chart area is visible
				if (area.Visible)

				{
					// Get area position
					RectangleF titlePlottingRectangle = area.PlotAreaPosition.ToRectangleF();

					// Get elemets spacing
					float areaSpacing = Math.Min((titlePlottingRectangle.Height / 100F) * elementSpacing, (titlePlottingRectangle.Width / 100F) * elementSpacing);

					// Loop through all titles
					foreach (Title title in chartPicture.Titles)
					{
						if (title.IsDockedInsideChartArea == true &&
							title.DockedToChartArea == area.Name &&
							title.Position.Auto)
						{
							// Calculate title position
							RectangleF frameRect = RectangleF.Empty;
							title.CalcTitlePosition(chartGraph,
								ref titlePlottingRectangle,
								ref frameRect,
								areaSpacing);
						}
					}
				}
			}
		}
	}

	#endregion

	#region Event handlers
	internal void ChartAreaNameReferenceChanged(object sender, NameReferenceChangedEventArgs e)
	{
		//If all the chart areas are removed and then the first one is added we don't want to dock the titles
		if (e.OldElement == null)
		{
			return;
		}

		foreach (Title title in this)
		{
			if (title.DockedToChartArea == e.OldName)
			{
				title.DockedToChartArea = e.NewName;
			}
		}
	}
	#endregion


}
