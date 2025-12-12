// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Specifies the unit of measure for the given data.
/// </summary>
public enum ChartGraphicsUnit
{
    /// <summary>
    /// Specifies the world coordinate system unit as the unit of measure.
    /// </summary>
    World = 0,

    /// <summary>
    /// Specifies the unit of measure of the display device (typically pixels for video displays).
    /// </summary>
    Display = 1,

    /// <summary>
    /// Specifies a device pixel as the unit of measure.
    /// </summary>
    Pixel = 2,

    /// <summary>
    /// Specifies a printer's point (1/72 inch) as the unit of measure.
    /// </summary>
    Point = 3,

    /// <summary>
    /// Specifies the inch as the unit of measure.
    /// </summary>
    Inch = 4,

    /// <summary>
    /// Specifies the document unit (1/300 inch) as the unit of measure.
    /// </summary>
    Document = 5,

    /// <summary>
    /// Specifies the millimeter as the unit of measure.
    /// </summary>
    Millimeter = 6
}

/// <summary>
/// Specifies the quality of rendering.
/// </summary>
public enum ChartSmoothingMode
{
    /// <summary>
    /// Specifies an invalid mode.
    /// </summary>
    Invalid = -1,

    /// <summary>
    /// Specifies the default mode.
    /// </summary>
    Default = 0,

    /// <summary>
    /// Specifies high speed, low quality rendering.
    /// </summary>
    HighSpeed = 1,

    /// <summary>
    /// Specifies high quality, low speed rendering.
    /// </summary>
    HighQuality = 2,

    /// <summary>
    /// Specifies no antialiasing.
    /// </summary>
    None = 3,

    /// <summary>
    /// Specifies antialiased rendering.
    /// </summary>
    AntiAlias = 4
}

/// <summary>
/// Specifies the quality of text rendering.
/// </summary>
public enum ChartTextRenderingHint
{
    /// <summary>
    /// Each character is drawn using its glyph bitmap, with the system default rendering hint.
    /// </summary>
    SystemDefault = 0,

    /// <summary>
    /// Each character is drawn using its glyph bitmap. Hinting is used.
    /// </summary>
    SingleBitPerPixelGridFit = 1,

    /// <summary>
    /// Each character is drawn using its glyph bitmap. Hinting is not used.
    /// </summary>
    SingleBitPerPixel = 2,

    /// <summary>
    /// Each character is drawn using its antialiased glyph bitmap with hinting.
    /// </summary>
    AntiAliasGridFit = 3,

    /// <summary>
    /// Each character is drawn using its antialiased glyph bitmap without hinting.
    /// </summary>
    AntiAlias = 4,

    /// <summary>
    /// Each character is drawn using its ClearType glyph bitmap with hinting.
    /// </summary>
    ClearTypeGridFit = 5
}

/// <summary>
/// Specifies how the source colors are combined with the background colors.
/// </summary>
public enum ChartCombineMode
{
    /// <summary>
    /// One clipping region is replaced by another.
    /// </summary>
    Replace = 0,

    /// <summary>
    /// Two clipping regions are combined by taking their intersection.
    /// </summary>
    Intersect = 1,

    /// <summary>
    /// Two clipping regions are combined by taking the union of both.
    /// </summary>
    Union = 2,

    /// <summary>
    /// Two clipping regions are combined by taking only the areas enclosed by one or the other region, but not both.
    /// </summary>
    Xor = 3,

    /// <summary>
    /// Specifies that the existing region is replaced by the result of the new region being removed from the existing region.
    /// </summary>
    Exclude = 4,

    /// <summary>
    /// Specifies that the existing region is replaced by the result of the existing region being removed from the new region.
    /// </summary>
    Complement = 5
}

/// <summary>
/// Specifies the type of fill.
/// </summary>
public enum ChartBrushType
{
    /// <summary>
    /// A solid brush.
    /// </summary>
    Solid,

    /// <summary>
    /// A linear gradient brush.
    /// </summary>
    LinearGradient,

    /// <summary>
    /// A hatch brush.
    /// </summary>
    Hatch,

    /// <summary>
    /// A texture brush.
    /// </summary>
    Texture
}

/// <summary>
/// Specifies the style of dashed lines drawn with a pen.
/// </summary>
public enum RenderDashStyle
{
    /// <summary>
    /// Specifies a solid line.
    /// </summary>
    Solid = 0,

    /// <summary>
    /// Specifies a line consisting of dashes.
    /// </summary>
    Dash = 1,

    /// <summary>
    /// Specifies a line consisting of dots.
    /// </summary>
    Dot = 2,

    /// <summary>
    /// Specifies a line consisting of a repeating pattern of dash-dot.
    /// </summary>
    DashDot = 3,

    /// <summary>
    /// Specifies a line consisting of a repeating pattern of dash-dot-dot.
    /// </summary>
    DashDotDot = 4,

    /// <summary>
    /// Specifies a user-defined custom dash style.
    /// </summary>
    Custom = 5
}

/// <summary>
/// Specifies the style of dashed lines drawn with a ChartPen.
/// </summary>
public enum ChartDashStyle
{
    /// <summary>
    /// Specifies a solid line.
    /// </summary>
    Solid = 0,

    /// <summary>
    /// Specifies a line consisting of dashes.
    /// </summary>
    Dash = 1,

    /// <summary>
    /// Specifies a line consisting of dots.
    /// </summary>
    Dot = 2,

    /// <summary>
    /// Specifies a line consisting of a repeating pattern of dash-dot.
    /// </summary>
    DashDot = 3,

    /// <summary>
    /// Specifies a line consisting of a repeating pattern of dash-dot-dot.
    /// </summary>
    DashDotDot = 4,

    /// <summary>
    /// Specifies a user-defined custom dash style.
    /// </summary>
    Custom = 5
}

/// <summary>
/// Specifies the available cap styles with which a Pen object can end a line.
/// </summary>
public enum ChartLineCap
{
    /// <summary>
    /// Specifies a flat line cap.
    /// </summary>
    Flat = 0,

    /// <summary>
    /// Specifies a square line cap.
    /// </summary>
    Square = 1,

    /// <summary>
    /// Specifies a round line cap.
    /// </summary>
    Round = 2,

    /// <summary>
    /// Specifies a triangular line cap.
    /// </summary>
    Triangle = 3,

    /// <summary>
    /// Specifies no anchor.
    /// </summary>
    NoAnchor = 16,

    /// <summary>
    /// Specifies a square anchor line cap.
    /// </summary>
    SquareAnchor = 17,

    /// <summary>
    /// Specifies a round anchor cap.
    /// </summary>
    RoundAnchor = 18,

    /// <summary>
    /// Specifies a diamond anchor cap.
    /// </summary>
    DiamondAnchor = 19,

    /// <summary>
    /// Specifies an arrow-shaped anchor cap.
    /// </summary>
    ArrowAnchor = 20,

    /// <summary>
    /// Specifies a custom line cap.
    /// </summary>
    Custom = 255
}

/// <summary>
/// Specifies how to join consecutive line or curve segments.
/// </summary>
public enum ChartLineJoin
{
    /// <summary>
    /// Specifies a mitered join.
    /// </summary>
    Miter = 0,

    /// <summary>
    /// Specifies a beveled join.
    /// </summary>
    Bevel = 1,

    /// <summary>
    /// Specifies a circular join.
    /// </summary>
    Round = 2,

    /// <summary>
    /// Specifies a mitered join. This produces a sharp corner or a clipped corner.
    /// </summary>
    MiterClipped = 3
}

/// <summary>
/// Specifies the different patterns available for hatch brushes.
/// </summary>
public enum RenderHatchStyle
{
    None = -1,
    Horizontal = 0,
    Vertical = 1,
    ForwardDiagonal = 2,
    BackwardDiagonal = 3,
    Cross = 4,
    DiagonalCross = 5,
    Percent05 = 6,
    Percent10 = 7,
    Percent20 = 8,
    Percent25 = 9,
    Percent30 = 10,
    Percent40 = 11,
    Percent50 = 12,
    Percent60 = 13,
    Percent70 = 14,
    Percent75 = 15,
    Percent80 = 16,
    Percent90 = 17,
    LightDownwardDiagonal = 18,
    LightUpwardDiagonal = 19,
    DarkDownwardDiagonal = 20,
    DarkUpwardDiagonal = 21,
    WideDownwardDiagonal = 22,
    WideUpwardDiagonal = 23,
    LightVertical = 24,
    LightHorizontal = 25,
    NarrowVertical = 26,
    NarrowHorizontal = 27,
    DarkVertical = 28,
    DarkHorizontal = 29,
    DashedDownwardDiagonal = 30,
    DashedUpwardDiagonal = 31,
    DashedHorizontal = 32,
    DashedVertical = 33,
    SmallConfetti = 34,
    LargeConfetti = 35,
    ZigZag = 36,
    Wave = 37,
    DiagonalBrick = 38,
    HorizontalBrick = 39,
    Weave = 40,
    Plaid = 41,
    Divot = 42,
    DottedGrid = 43,
    DottedDiamond = 44,
    Shingle = 45,
    Trellis = 46,
    Sphere = 47,
    SmallGrid = 48,
    SmallCheckerBoard = 49,
    LargeCheckerBoard = 50,
    OutlinedDiamond = 51,
    SolidDiamond = 52
}

/// <summary>
/// Specifies the different patterns available for ChartHatchBrush.
/// </summary>
public enum ChartHatchStyle
{
    None = -1,
    Horizontal = 0,
    Vertical = 1,
    ForwardDiagonal = 2,
    BackwardDiagonal = 3,
    Cross = 4,
    DiagonalCross = 5,
    Percent05 = 6,
    Percent10 = 7,
    Percent20 = 8,
    Percent25 = 9,
    Percent30 = 10,
    Percent40 = 11,
    Percent50 = 12,
    Percent60 = 13,
    Percent70 = 14,
    Percent75 = 15,
    Percent80 = 16,
    Percent90 = 17,
    LightDownwardDiagonal = 18,
    LightUpwardDiagonal = 19,
    DarkDownwardDiagonal = 20,
    DarkUpwardDiagonal = 21,
    WideDownwardDiagonal = 22,
    WideUpwardDiagonal = 23,
    LightVertical = 24,
    LightHorizontal = 25,
    NarrowVertical = 26,
    NarrowHorizontal = 27,
    DarkVertical = 28,
    DarkHorizontal = 29,
    DashedDownwardDiagonal = 30,
    DashedUpwardDiagonal = 31,
    DashedHorizontal = 32,
    DashedVertical = 33,
    SmallConfetti = 34,
    LargeConfetti = 35,
    ZigZag = 36,
    Wave = 37,
    DiagonalBrick = 38,
    HorizontalBrick = 39,
    Weave = 40,
    Plaid = 41,
    Divot = 42,
    DottedGrid = 43,
    DottedDiamond = 44,
    Shingle = 45,
    Trellis = 46,
    Sphere = 47,
    SmallGrid = 48,
    SmallCheckerBoard = 49,
    LargeCheckerBoard = 50,
    OutlinedDiamond = 51,
    SolidDiamond = 52
}

/// <summary>
/// Specifies the direction of a linear gradient.
/// </summary>
public enum ChartLinearGradientMode
{
    /// <summary>
    /// Specifies a gradient from left to right.
    /// </summary>
    Horizontal = 0,

    /// <summary>
    /// Specifies a gradient from top to bottom.
    /// </summary>
    Vertical = 1,

    /// <summary>
    /// Specifies a gradient from upper left to lower right.
    /// </summary>
    ForwardDiagonal = 2,

    /// <summary>
    /// Specifies a gradient from upper right to lower left.
    /// </summary>
    BackwardDiagonal = 3
}

/// <summary>
/// Specifies text layout information.
/// </summary>
public enum ChartStringAlignment
{
    /// <summary>
    /// Specifies the text be aligned near the layout.
    /// </summary>
    Near = 0,

    /// <summary>
    /// Specifies that text is aligned in the center of the layout rectangle.
    /// </summary>
    Center = 1,

    /// <summary>
    /// Specifies that text is aligned far from the origin position of the layout rectangle.
    /// </summary>
    Far = 2
}

/// <summary>
/// Specifies how to trim characters from a string that does not completely fit into a layout shape.
/// </summary>
public enum ChartStringTrimming
{
    /// <summary>
    /// Specifies no trimming.
    /// </summary>
    None = 0,

    /// <summary>
    /// Specifies that the text is trimmed to the nearest character.
    /// </summary>
    Character = 1,

    /// <summary>
    /// Specifies that text is trimmed to the nearest word.
    /// </summary>
    Word = 2,

    /// <summary>
    /// Specifies that the text is trimmed to the nearest character, and an ellipsis is inserted at the end.
    /// </summary>
    EllipsisCharacter = 3,

    /// <summary>
    /// Specifies that text is trimmed to the nearest word, and an ellipsis is inserted at the end.
    /// </summary>
    EllipsisWord = 4,

    /// <summary>
    /// The center is removed from trimmed lines and replaced by an ellipsis.
    /// </summary>
    EllipsisPath = 5
}

/// <summary>
/// Specifies display and layout information for text strings.
/// </summary>
[Flags]
public enum ChartStringFormatFlags
{
    /// <summary>
    /// Text is displayed from right to left.
    /// </summary>
    DirectionRightToLeft = 1,

    /// <summary>
    /// Text is vertically aligned.
    /// </summary>
    DirectionVertical = 2,

    /// <summary>
    /// Parts of characters are allowed to overhang the string's layout rectangle.
    /// </summary>
    FitBlackBox = 4,

    /// <summary>
    /// Control characters such as the left-to-right mark are shown in the output.
    /// </summary>
    DisplayFormatControl = 32,

    /// <summary>
    /// Fallback to alternate fonts for characters not supported in the requested font.
    /// </summary>
    NoFontFallback = 1024,

    /// <summary>
    /// Includes the trailing space at the end of each line.
    /// </summary>
    MeasureTrailingSpaces = 2048,

    /// <summary>
    /// Text wrapping between lines when formatting within a rectangle is disabled.
    /// </summary>
    NoWrap = 4096,

    /// <summary>
    /// Only entire lines are laid out in the formatting rectangle.
    /// </summary>
    LineLimit = 8192,

    /// <summary>
    /// Overhanging parts of glyphs are allowed to show outside the layout rectangle.
    /// </summary>
    NoClip = 16384
}

/// <summary>
/// Specifies how a path segment should be filled.
/// </summary>
public enum ChartFillMode
{
    /// <summary>
    /// Specifies the alternate fill mode.
    /// </summary>
    Alternate = 0,

    /// <summary>
    /// Specifies the winding fill mode.
    /// </summary>
    Winding = 1
}

/// <summary>
/// Specifies the gradient style for chart backgrounds.
/// </summary>
public enum ChartGradientStyle
{
    /// <summary>
    /// No gradient is used.
    /// </summary>
    None,

    /// <summary>
    /// Gradient is applied from left to right.
    /// </summary>
    LeftRight,

    /// <summary>
    /// Gradient is applied from top to bottom.
    /// </summary>
    TopBottom,

    /// <summary>
    /// Gradient is applied from the center outwards.
    /// </summary>
    Center,

    /// <summary>
    /// Gradient is applied diagonally from left to right.
    /// </summary>
    DiagonalLeft,

    /// <summary>
    /// Gradient is applied diagonally from right to left.
    /// </summary>
    DiagonalRight,

    /// <summary>
    /// Gradient is applied horizontally from the center outwards.
    /// </summary>
    HorizontalCenter,

    /// <summary>
    /// Gradient is applied vertically from the center outwards.
    /// </summary>
    VerticalCenter
}
