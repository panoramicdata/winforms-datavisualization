// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Adapter that wraps ChartGraphics to implement ILayoutGraphics.
/// This allows the Core layout engine to work with WinForms GDI+ graphics
/// while maintaining pixel-perfect compatibility with the original layout calculations.
/// </summary>
internal sealed class ChartGraphicsLayoutAdapter : ILayoutGraphics
{
    private readonly ChartGraphics _chartGraphics;

    /// <summary>
    /// Initializes a new instance of the ChartGraphicsLayoutAdapter class.
    /// </summary>
    /// <param name="chartGraphics">The ChartGraphics instance to wrap.</param>
    public ChartGraphicsLayoutAdapter(ChartGraphics chartGraphics)
    {
        _chartGraphics = chartGraphics ?? throw new ArgumentNullException(nameof(chartGraphics));
    }

    /// <summary>
    /// Gets the underlying ChartGraphics instance.
    /// </summary>
    public ChartGraphics ChartGraphics => _chartGraphics;

    #region Properties

    /// <inheritdoc/>
    public float Width => _chartGraphics.Common?.Width ?? 0;

    /// <inheritdoc/>
    public float Height => _chartGraphics.Common?.Height ?? 0;

    /// <inheritdoc/>
    public float DpiX => _chartGraphics.Graphics?.DpiX ?? 96f;

    /// <inheritdoc/>
    public float DpiY => _chartGraphics.Graphics?.DpiY ?? 96f;

    #endregion

    #region Coordinate Conversion

    /// <inheritdoc/>
    public ChartRectangleF GetAbsoluteRectangle(ChartRectangleF rectangle)
    {
        var gdiRect = new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        var absRect = _chartGraphics.GetAbsoluteRectangle(gdiRect);
        return new ChartRectangleF(absRect.X, absRect.Y, absRect.Width, absRect.Height);
    }

    /// <inheritdoc/>
    public ChartRectangleF GetRelativeRectangle(ChartRectangleF rectangle)
    {
        var gdiRect = new RectangleF(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        var relRect = _chartGraphics.GetRelativeRectangle(gdiRect);
        return new ChartRectangleF(relRect.X, relRect.Y, relRect.Width, relRect.Height);
    }

    /// <inheritdoc/>
    public ChartPointF GetAbsolutePoint(ChartPointF point)
    {
        var gdiPoint = new PointF(point.X, point.Y);
        var absPoint = _chartGraphics.GetAbsolutePoint(gdiPoint);
        return new ChartPointF(absPoint.X, absPoint.Y);
    }

    /// <inheritdoc/>
    public ChartPointF GetRelativePoint(ChartPointF point)
    {
        var gdiPoint = new PointF(point.X, point.Y);
        var relPoint = _chartGraphics.GetRelativePoint(gdiPoint);
        return new ChartPointF(relPoint.X, relPoint.Y);
    }

    /// <inheritdoc/>
    public ChartSizeF GetAbsoluteSize(ChartSizeF size)
    {
        var gdiSize = new SizeF(size.Width, size.Height);
        var absSize = _chartGraphics.GetAbsoluteSize(gdiSize);
        return new ChartSizeF(absSize.Width, absSize.Height);
    }

    /// <inheritdoc/>
    public ChartSizeF GetRelativeSize(ChartSizeF size)
    {
        var gdiSize = new SizeF(size.Width, size.Height);
        var relSize = _chartGraphics.GetRelativeSize(gdiSize);
        return new ChartSizeF(relSize.Width, relSize.Height);
    }

    #endregion

    #region Text Measurement

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font)
    {
        if (string.IsNullOrEmpty(text) || _chartGraphics.Graphics == null)
            return new ChartSizeF(0, 0);

        // Convert ChartFont to GDI+ Font
        using var gdiFont = CreateGdiFont(font);
        var size = _chartGraphics.MeasureStringAbs(text, gdiFont);
        return new ChartSizeF(size.Width, size.Height);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea)
    {
        if (string.IsNullOrEmpty(text) || _chartGraphics.Graphics == null)
            return new ChartSizeF(0, 0);

        // Convert ChartFont to GDI+ Font
        using var gdiFont = CreateGdiFont(font);
        var gdiLayoutArea = new SizeF(layoutArea.Width, layoutArea.Height);
        var size = _chartGraphics.MeasureStringAbs(text, gdiFont, gdiLayoutArea, StringFormat.GenericDefault);
        return new ChartSizeF(size.Width, size.Height);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureStringRel(string text, ChartFont font)
    {
        if (string.IsNullOrEmpty(text) || _chartGraphics.Graphics == null)
            return new ChartSizeF(0, 0);

        // Convert ChartFont to GDI+ Font
        using var gdiFont = CreateGdiFont(font);
        var size = _chartGraphics.MeasureStringRel(text, gdiFont);
        return new ChartSizeF(size.Width, size.Height);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureStringRel(string text, ChartFont font, ChartSizeF layoutArea)
    {
        if (string.IsNullOrEmpty(text) || _chartGraphics.Graphics == null)
            return new ChartSizeF(0, 0);

        // Convert ChartFont to GDI+ Font
        using var gdiFont = CreateGdiFont(font);
        var gdiLayoutArea = new SizeF(layoutArea.Width, layoutArea.Height);
        var size = _chartGraphics.MeasureStringRel(text, gdiFont, gdiLayoutArea, StringFormat.GenericDefault);
        return new ChartSizeF(size.Width, size.Height);
    }

    #endregion

    #region Helper Methods

    /// <summary>
    /// Creates a GDI+ Font from a ChartFont.
    /// </summary>
    private static Font CreateGdiFont(ChartFont chartFont)
    {
        var fontStyle = FontStyle.Regular;
        if (chartFont.Bold) fontStyle |= FontStyle.Bold;
        if (chartFont.Italic) fontStyle |= FontStyle.Italic;
        if (chartFont.Underline) fontStyle |= FontStyle.Underline;
        if (chartFont.Strikeout) fontStyle |= FontStyle.Strikeout;

        return new Font(chartFont.FontFamily, chartFont.Size, fontStyle, GraphicsUnit.Point);
    }

    #endregion
}
