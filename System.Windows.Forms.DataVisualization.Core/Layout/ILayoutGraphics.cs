// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Interface for graphics operations needed during chart layout calculations.
/// This abstraction allows the layout engine to work with different rendering targets
/// (GDI+, SVG, etc.) while using the same layout logic.
/// </summary>
/// <remarks>
/// This interface is designed to be implemented by adapters that wrap platform-specific
/// graphics objects. The WinForms implementation wraps ChartGraphics, while SVG/Blazor
/// implementations provide their own coordinate conversion and text measurement.
/// 
/// All coordinate conversion methods use the same relative coordinate system as
/// WinForms (0-100 for both X and Y axes, representing percentages of the chart area).
/// </remarks>
public interface ILayoutGraphics
{
    #region Properties

    /// <summary>
    /// Gets the width of the chart picture in pixels.
    /// </summary>
    float Width { get; }

    /// <summary>
    /// Gets the height of the chart picture in pixels.
    /// </summary>
    float Height { get; }

    /// <summary>
    /// Gets the horizontal resolution (DPI) of the graphics surface.
    /// </summary>
    float DpiX { get; }

    /// <summary>
    /// Gets the vertical resolution (DPI) of the graphics surface.
    /// </summary>
    float DpiY { get; }

    #endregion

    #region Coordinate Conversion

    /// <summary>
    /// Converts a rectangle from relative coordinates (0-100) to absolute pixel coordinates.
    /// </summary>
    /// <param name="rectangle">Rectangle in relative coordinates.</param>
    /// <returns>Rectangle in absolute pixel coordinates.</returns>
    ChartRectangleF GetAbsoluteRectangle(ChartRectangleF rectangle);

    /// <summary>
    /// Converts a rectangle from absolute pixel coordinates to relative coordinates (0-100).
    /// </summary>
    /// <param name="rectangle">Rectangle in absolute pixel coordinates.</param>
    /// <returns>Rectangle in relative coordinates.</returns>
    ChartRectangleF GetRelativeRectangle(ChartRectangleF rectangle);

    /// <summary>
    /// Converts a point from relative coordinates (0-100) to absolute pixel coordinates.
    /// </summary>
    /// <param name="point">Point in relative coordinates.</param>
    /// <returns>Point in absolute pixel coordinates.</returns>
    ChartPointF GetAbsolutePoint(ChartPointF point);

    /// <summary>
    /// Converts a point from absolute pixel coordinates to relative coordinates (0-100).
    /// </summary>
    /// <param name="point">Point in absolute pixel coordinates.</param>
    /// <returns>Point in relative coordinates.</returns>
    ChartPointF GetRelativePoint(ChartPointF point);

    /// <summary>
    /// Converts a size from relative coordinates (0-100) to absolute pixel size.
    /// </summary>
    /// <param name="size">Size in relative coordinates.</param>
    /// <returns>Size in absolute pixels.</returns>
    ChartSizeF GetAbsoluteSize(ChartSizeF size);

    /// <summary>
    /// Converts a size from absolute pixel size to relative coordinates (0-100).
    /// </summary>
    /// <param name="size">Size in absolute pixels.</param>
    /// <returns>Size in relative coordinates.</returns>
    ChartSizeF GetRelativeSize(ChartSizeF size);

    #endregion

    #region Text Measurement

    /// <summary>
    /// Measures the specified text string when drawn with the specified font.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="font">The font to use for measurement.</param>
    /// <returns>The size of the text in absolute pixels.</returns>
    ChartSizeF MeasureString(string text, ChartFont font);

    /// <summary>
    /// Measures the specified text string when drawn with the specified font,
    /// constrained to a layout area.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="font">The font to use for measurement.</param>
    /// <param name="layoutArea">The maximum layout area for the text.</param>
    /// <returns>The size of the text in absolute pixels.</returns>
    ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea);

    /// <summary>
    /// Measures the specified text string in relative coordinates.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="font">The font to use for measurement.</param>
    /// <returns>The size of the text in relative coordinates.</returns>
    ChartSizeF MeasureStringRel(string text, ChartFont font);

    /// <summary>
    /// Measures the specified text string in relative coordinates,
    /// constrained to a layout area.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="font">The font to use for measurement.</param>
    /// <param name="layoutArea">The maximum layout area for the text in relative coordinates.</param>
    /// <returns>The size of the text in relative coordinates.</returns>
    ChartSizeF MeasureStringRel(string text, ChartFont font, ChartSizeF layoutArea);

    #endregion
}

/// <summary>
/// Default implementation of ILayoutGraphics that uses simple calculations.
/// This is suitable for platforms where exact GDI+ compatibility is not required.
/// </summary>
public class DefaultLayoutGraphics : ILayoutGraphics
{
    private readonly float _width;
    private readonly float _height;
    private readonly float _dpiX;
    private readonly float _dpiY;
    private readonly ITextMeasurer _textMeasurer;

    /// <summary>
    /// Initializes a new instance of the DefaultLayoutGraphics class.
    /// </summary>
    /// <param name="width">Width in pixels.</param>
    /// <param name="height">Height in pixels.</param>
    /// <param name="dpiX">Horizontal DPI (default 96).</param>
    /// <param name="dpiY">Vertical DPI (default 96).</param>
    /// <param name="textMeasurer">Optional text measurer (uses DefaultTextMeasurer if null).</param>
    public DefaultLayoutGraphics(
        float width,
        float height,
        float dpiX = 96f,
        float dpiY = 96f,
        ITextMeasurer? textMeasurer = null)
    {
        _width = width;
        _height = height;
        _dpiX = dpiX;
        _dpiY = dpiY;
        _textMeasurer = textMeasurer ?? DefaultTextMeasurer.Instance;
    }

    /// <inheritdoc/>
    public float Width => _width;

    /// <inheritdoc/>
    public float Height => _height;

    /// <inheritdoc/>
    public float DpiX => _dpiX;

    /// <inheritdoc/>
    public float DpiY => _dpiY;

    /// <inheritdoc/>
    public ChartRectangleF GetAbsoluteRectangle(ChartRectangleF rectangle)
    {
        // Convert relative coordinates (0-100) to absolute pixel coordinates
        // Note: WinForms uses (Width - 1) and (Height - 1) for the conversion factor
        float effectiveWidth = _width - 1;
        float effectiveHeight = _height - 1;

        return new ChartRectangleF(
            rectangle.X * effectiveWidth / 100f,
            rectangle.Y * effectiveHeight / 100f,
            rectangle.Width * effectiveWidth / 100f,
            rectangle.Height * effectiveHeight / 100f);
    }

    /// <inheritdoc/>
    public ChartRectangleF GetRelativeRectangle(ChartRectangleF rectangle)
    {
        // Convert absolute pixel coordinates to relative coordinates (0-100)
        float effectiveWidth = _width - 1;
        float effectiveHeight = _height - 1;

        return new ChartRectangleF(
            rectangle.X * 100f / effectiveWidth,
            rectangle.Y * 100f / effectiveHeight,
            rectangle.Width * 100f / effectiveWidth,
            rectangle.Height * 100f / effectiveHeight);
    }

    /// <inheritdoc/>
    public ChartPointF GetAbsolutePoint(ChartPointF point)
    {
        float effectiveWidth = _width - 1;
        float effectiveHeight = _height - 1;

        return new ChartPointF(
            point.X * effectiveWidth / 100f,
            point.Y * effectiveHeight / 100f);
    }

    /// <inheritdoc/>
    public ChartPointF GetRelativePoint(ChartPointF point)
    {
        float effectiveWidth = _width - 1;
        float effectiveHeight = _height - 1;

        return new ChartPointF(
            point.X * 100f / effectiveWidth,
            point.Y * 100f / effectiveHeight);
    }

    /// <inheritdoc/>
    public ChartSizeF GetAbsoluteSize(ChartSizeF size)
    {
        float effectiveWidth = _width - 1;
        float effectiveHeight = _height - 1;

        return new ChartSizeF(
            size.Width * effectiveWidth / 100f,
            size.Height * effectiveHeight / 100f);
    }

    /// <inheritdoc/>
    public ChartSizeF GetRelativeSize(ChartSizeF size)
    {
        float effectiveWidth = _width - 1;
        float effectiveHeight = _height - 1;

        return new ChartSizeF(
            size.Width * 100f / effectiveWidth,
            size.Height * 100f / effectiveHeight);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font)
    {
        return _textMeasurer.MeasureString(text, font);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea)
    {
        return _textMeasurer.MeasureString(text, font, layoutArea.Width);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureStringRel(string text, ChartFont font)
    {
        var absSize = MeasureString(text, font);
        return GetRelativeSize(absSize);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureStringRel(string text, ChartFont font, ChartSizeF layoutArea)
    {
        var absLayoutArea = GetAbsoluteSize(layoutArea);
        var absSize = MeasureString(text, font, absLayoutArea);
        return GetRelativeSize(absSize);
    }
}
