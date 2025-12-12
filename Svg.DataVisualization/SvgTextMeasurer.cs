// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// SVG implementation of ITextMeasurer.
/// Uses estimation based on font metrics since SVG rendering doesn't have access
/// to a graphics context for measuring. This provides reasonable approximations
/// that match typical browser rendering.
/// </summary>
public class SvgTextMeasurer : ITextMeasurer
{
    /// <summary>
    /// Average character width ratio for proportional fonts.
    /// This is calibrated for common fonts like Arial, Helvetica.
    /// </summary>
    private const float ProportionalWidthRatio = 0.55f;

    /// <summary>
    /// Average character width ratio for monospace fonts.
    /// </summary>
    private const float MonospaceWidthRatio = 0.6f;

    /// <summary>
    /// Line height multiplier for typical fonts.
    /// </summary>
    private const float LineHeightRatio = 1.2f;

    /// <summary>
    /// Width multiplier for bold text.
    /// </summary>
    private const float BoldWidthMultiplier = 1.05f;

    /// <summary>
    /// The singleton instance.
    /// </summary>
    public static SvgTextMeasurer Instance { get; } = new();

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font)
    {
        if (string.IsNullOrEmpty(text))
            return new ChartSizeF(0, 0);

        // Determine width ratio based on font family
        float widthRatio = IsMonospaceFont(font.FontFamily) 
            ? MonospaceWidthRatio 
            : ProportionalWidthRatio;

        // Adjust for bold
        if ((font.Style & ChartFontStyle.Bold) != 0)
        {
            widthRatio *= BoldWidthMultiplier;
        }

        // Calculate character dimensions
        float charWidth = font.Size * widthRatio;
        float charHeight = font.Size * LineHeightRatio;

        // Handle multi-line text
        var lines = text.Split('\n');
        float maxLineWidth = 0;

        foreach (var line in lines)
        {
            // Estimate line width considering variable-width characters
            float lineWidth = EstimateLineWidth(line, font.Size, widthRatio);
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

        // Estimate wrapped size
        if (size.Width > maxWidth && maxWidth > 0)
        {
            float charHeight = font.Size * LineHeightRatio;
            int lines = (int)Math.Ceiling(size.Width / maxWidth);
            return new ChartSizeF(maxWidth, lines * charHeight);
        }

        return size;
    }

    /// <summary>
    /// Estimates the width of a line of text considering character widths.
    /// </summary>
    private static float EstimateLineWidth(string line, float fontSize, float baseWidthRatio)
    {
        if (string.IsNullOrEmpty(line))
            return 0;

        float totalWidth = 0;
        
        foreach (char c in line)
        {
            // Adjust width based on character type
            float charWidthRatio = c switch
            {
                // Narrow characters
                'i' or 'l' or '!' or '|' or '.' or ',' or ':' or ';' or '\'' => baseWidthRatio * 0.4f,
                'I' or 'j' or 'f' or 't' => baseWidthRatio * 0.6f,
                
                // Wide characters
                'm' or 'w' or 'M' or 'W' => baseWidthRatio * 1.4f,
                '@' or '%' => baseWidthRatio * 1.5f,
                
                // Spaces
                ' ' => baseWidthRatio * 0.5f,
                
                // Capital letters (slightly wider)
                >= 'A' and <= 'Z' => baseWidthRatio * 1.1f,
                
                // Numbers
                >= '0' and <= '9' => baseWidthRatio * 1.0f,
                
                // Default
                _ => baseWidthRatio
            };

            totalWidth += fontSize * charWidthRatio;
        }

        return totalWidth;
    }

    /// <summary>
    /// Checks if a font family is monospace.
    /// </summary>
    private static bool IsMonospaceFont(string fontFamily)
    {
        var lower = fontFamily.ToLowerInvariant();
        return lower.Contains("mono") || 
               lower.Contains("courier") || 
               lower.Contains("consolas") ||
               lower.Contains("menlo") ||
               lower.Contains("lucida console");
    }
}
