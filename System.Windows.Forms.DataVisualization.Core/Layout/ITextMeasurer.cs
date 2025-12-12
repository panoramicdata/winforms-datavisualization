// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Interface for measuring text dimensions in a platform-agnostic way.
/// Implementations can use GDI+, SVG estimation, or any other text rendering system.
/// </summary>
public interface ITextMeasurer
{
    /// <summary>
    /// Measures the size of a text string when rendered with the specified font.
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="font">The font to use for measurement.</param>
    /// <returns>The size of the text in pixels.</returns>
    ChartSizeF MeasureString(string text, ChartFont font);

    /// <summary>
    /// Measures the size of a text string when rendered with the specified font,
    /// constrained to a maximum width (for text wrapping).
    /// </summary>
    /// <param name="text">The text to measure.</param>
    /// <param name="font">The font to use for measurement.</param>
    /// <param name="maxWidth">The maximum width available for the text.</param>
    /// <returns>The size of the text in pixels.</returns>
    ChartSizeF MeasureString(string text, ChartFont font, float maxWidth);
}

/// <summary>
/// A default text measurer that uses simple character-based estimation.
/// This is suitable for platforms where actual text measurement is not available
/// or when approximate measurements are acceptable.
/// </summary>
public class DefaultTextMeasurer : ITextMeasurer
{
    /// <summary>
    /// Default approximate character width in pixels.
    /// </summary>
    private const float ApproxCharWidth = 7f;

    /// <summary>
    /// Approximate ratio of character width to font size.
    /// </summary>
    private const float CharWidthRatio = 0.6f;

    /// <summary>
    /// Approximate ratio of character height to font size.
    /// </summary>
    private const float CharHeightRatio = 1.2f;

    /// <summary>
    /// The singleton instance of the default text measurer.
    /// </summary>
    public static DefaultTextMeasurer Instance { get; } = new();

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font)
    {
        if (string.IsNullOrEmpty(text))
            return new ChartSizeF(0, 0);

        float fontSize = font.Size;
        float charWidth = fontSize * CharWidthRatio;
        float charHeight = fontSize * CharHeightRatio;

        // Count lines for multi-line text
        var lines = text.Split('\n');
        float maxLineWidth = 0;

        foreach (var line in lines)
        {
            float lineWidth = line.Length * charWidth;
            maxLineWidth = Math.Max(maxLineWidth, lineWidth);
        }

        return new ChartSizeF(maxLineWidth, lines.Length * charHeight);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font, float maxWidth)
    {
        if (string.IsNullOrEmpty(text))
            return new ChartSizeF(0, 0);

        var size = MeasureString(text, font);

        // Simple word wrapping estimation
        if (size.Width > maxWidth && maxWidth > 0)
        {
            int lines = (int)Math.Ceiling(size.Width / maxWidth);
            float charHeight = font.Size * CharHeightRatio;
            return new ChartSizeF(maxWidth, lines * charHeight);
        }

        return size;
    }
}
