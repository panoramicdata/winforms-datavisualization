// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Utilities;

/// <summary>
/// GDI+ implementation of ITextMeasurer for WinForms charts.
/// Uses System.Drawing.Graphics to measure text accurately.
/// </summary>
public sealed class GdiTextMeasurer : ITextMeasurer, IDisposable
{
    private readonly Graphics _graphics;
    private readonly bool _ownsGraphics;
    private bool _disposed;

    /// <summary>
    /// Thread-local singleton instance for convenience.
    /// Uses a bitmap-based Graphics object for measurement.
    /// </summary>
    public static GdiTextMeasurer Default { get; } = new GdiTextMeasurer();

    /// <summary>
    /// Creates a new GdiTextMeasurer with an internal Graphics object for measurement.
    /// </summary>
    public GdiTextMeasurer()
    {
        // Create a small bitmap to get a Graphics object for measurement
        var bitmap = new Bitmap(1, 1);
        _graphics = Graphics.FromImage(bitmap);
        _ownsGraphics = true;
    }

    /// <summary>
    /// Creates a new GdiTextMeasurer using an existing Graphics object.
    /// </summary>
    /// <param name="graphics">The Graphics object to use for measurement.</param>
    public GdiTextMeasurer(Graphics graphics)
    {
        _graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));
        _ownsGraphics = false;
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(GdiTextMeasurer));

        if (string.IsNullOrEmpty(text))
            return new ChartSizeF(0, 0);

        using var gdiFont = ConvertFont(font);
        var size = _graphics.MeasureString(text, gdiFont);
        return new ChartSizeF(size.Width, size.Height);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font, float maxWidth)
    {
        if (_disposed)
            throw new ObjectDisposedException(nameof(GdiTextMeasurer));

        if (string.IsNullOrEmpty(text))
            return new ChartSizeF(0, 0);

        using var gdiFont = ConvertFont(font);
        var size = _graphics.MeasureString(text, gdiFont, (int)maxWidth);
        return new ChartSizeF(size.Width, size.Height);
    }

    /// <summary>
    /// Converts a ChartFont to a GDI+ Font.
    /// </summary>
    private static Font ConvertFont(ChartFont chartFont)
    {
        var fontStyle = FontStyle.Regular;
        
        if ((chartFont.Style & ChartFontStyle.Bold) != 0)
            fontStyle |= FontStyle.Bold;
        if ((chartFont.Style & ChartFontStyle.Italic) != 0)
            fontStyle |= FontStyle.Italic;
        if ((chartFont.Style & ChartFontStyle.Underline) != 0)
            fontStyle |= FontStyle.Underline;
        if ((chartFont.Style & ChartFontStyle.Strikeout) != 0)
            fontStyle |= FontStyle.Strikeout;

        return new Font(chartFont.FontFamily, chartFont.Size, fontStyle);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        if (!_disposed)
        {
            if (_ownsGraphics)
            {
                _graphics?.Dispose();
            }
            _disposed = true;
        }
    }
}
