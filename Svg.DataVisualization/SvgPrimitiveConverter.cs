// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Converts chart primitives to SVG attribute strings.
/// </summary>
public static class SvgPrimitiveConverter
{
    private static readonly CultureInfo InvariantCulture = CultureInfo.InvariantCulture;

    #region Color Conversion

    /// <summary>
    /// Converts a ChartColor to an SVG color string.
    /// </summary>
    /// <param name="color">The chart color to convert.</param>
    /// <returns>An SVG color string (hex or rgba format).</returns>
    public static string ToSvgColor(ChartColor color)
    {
        if (color.IsEmpty)
            return "none";

        if (color.A == 255)
            return $"#{color.R:X2}{color.G:X2}{color.B:X2}";

        // Use rgba for semi-transparent colors
        return $"rgba({color.R},{color.G},{color.B},{(color.A / 255.0).ToString("F2", InvariantCulture)})";
    }

    /// <summary>
    /// Converts a ChartColor to an SVG opacity value (0-1).
    /// </summary>
    /// <param name="color">The chart color.</param>
    /// <returns>Opacity value between 0 and 1.</returns>
    public static string ToSvgOpacity(ChartColor color)
    {
        return (color.A / 255.0).ToString("F2", InvariantCulture);
    }

    #endregion

    #region Pen/Stroke Conversion

    /// <summary>
    /// Converts a ChartPen to SVG stroke attributes.
    /// </summary>
    /// <param name="pen">The chart pen to convert.</param>
    /// <returns>SVG stroke attribute string.</returns>
    public static string ToSvgStrokeAttributes(ChartPen pen)
    {
        var sb = new StringBuilder();

        sb.Append($"stroke=\"{ToSvgColor(pen.Color)}\" ");
        sb.Append($"stroke-width=\"{pen.Width.ToString(InvariantCulture)}\" ");

        if (pen.Color.A < 255)
        {
            sb.Append($"stroke-opacity=\"{ToSvgOpacity(pen.Color)}\" ");
        }

        // Dash style
        var dashArray = ToSvgDashArray(pen.DashStyle, pen.Width);
        if (!string.IsNullOrEmpty(dashArray))
        {
            sb.Append($"stroke-dasharray=\"{dashArray}\" ");
        }

        // Line cap
        var lineCap = ToSvgLineCap(pen.StartCap);
        if (lineCap != "butt")
        {
            sb.Append($"stroke-linecap=\"{lineCap}\" ");
        }

        // Line join
        var lineJoin = ToSvgLineJoin(pen.LineJoin);
        if (lineJoin != "miter")
        {
            sb.Append($"stroke-linejoin=\"{lineJoin}\" ");
        }

        return sb.ToString().TrimEnd();
    }

    /// <summary>
    /// Converts a ChartDashStyle to an SVG stroke-dasharray value.
    /// </summary>
    public static string ToSvgDashArray(ChartDashStyle dashStyle, float width)
    {
        return dashStyle switch
        {
            ChartDashStyle.Solid => string.Empty,
            ChartDashStyle.Dash => $"{(3 * width).ToString(InvariantCulture)},{width.ToString(InvariantCulture)}",
            ChartDashStyle.Dot => $"{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)}",
            ChartDashStyle.DashDot => $"{(3 * width).ToString(InvariantCulture)},{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)}",
            ChartDashStyle.DashDotDot => $"{(3 * width).ToString(InvariantCulture)},{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)},{width.ToString(InvariantCulture)}",
            _ => string.Empty
        };
    }

    /// <summary>
    /// Converts a ChartLineCap to an SVG stroke-linecap value.
    /// </summary>
    public static string ToSvgLineCap(ChartLineCap cap)
    {
        return cap switch
        {
            ChartLineCap.Flat => "butt",
            ChartLineCap.Square => "square",
            ChartLineCap.Round or ChartLineCap.RoundAnchor => "round",
            _ => "butt"
        };
    }

    /// <summary>
    /// Converts a ChartLineJoin to an SVG stroke-linejoin value.
    /// </summary>
    public static string ToSvgLineJoin(ChartLineJoin join)
    {
        return join switch
        {
            ChartLineJoin.Miter or ChartLineJoin.MiterClipped => "miter",
            ChartLineJoin.Bevel => "bevel",
            ChartLineJoin.Round => "round",
            _ => "miter"
        };
    }

    #endregion

    #region Brush/Fill Conversion

    /// <summary>
    /// Converts a ChartBrush to SVG fill attributes.
    /// </summary>
    /// <param name="brush">The chart brush to convert.</param>
    /// <param name="definitionId">Optional definition ID for gradients/patterns.</param>
    /// <returns>SVG fill attribute string.</returns>
    public static string ToSvgFillAttributes(ChartBrush brush, string? definitionId = null)
    {
        return brush switch
        {
            ChartSolidBrush solidBrush => ToSvgSolidFill(solidBrush),
            ChartLinearGradientBrush gradientBrush when definitionId != null => $"fill=\"url(#{definitionId})\"",
            ChartHatchBrush hatchBrush when definitionId != null => $"fill=\"url(#{definitionId})\"",
            _ => "fill=\"none\""
        };
    }

    /// <summary>
    /// Converts a ChartSolidBrush to SVG fill attributes.
    /// </summary>
    private static string ToSvgSolidFill(ChartSolidBrush brush)
    {
        var sb = new StringBuilder();
        sb.Append($"fill=\"{ToSvgColor(brush.Color)}\"");

        if (brush.Color.A < 255)
        {
            sb.Append($" fill-opacity=\"{ToSvgOpacity(brush.Color)}\"");
        }

        return sb.ToString();
    }

    /// <summary>
    /// Generates an SVG linearGradient definition element.
    /// </summary>
    /// <param name="brush">The gradient brush.</param>
    /// <param name="id">The unique ID for this gradient.</param>
    /// <returns>SVG linearGradient element string.</returns>
    public static string ToSvgGradientDefinition(ChartLinearGradientBrush brush, string id)
    {
        var (x1, y1, x2, y2) = brush.GradientMode switch
        {
            ChartLinearGradientMode.Horizontal => ("0%", "0%", "100%", "0%"),
            ChartLinearGradientMode.Vertical => ("0%", "0%", "0%", "100%"),
            ChartLinearGradientMode.ForwardDiagonal => ("0%", "0%", "100%", "100%"),
            ChartLinearGradientMode.BackwardDiagonal => ("100%", "0%", "0%", "100%"),
            _ => ("0%", "0%", "100%", "0%")
        };

        return $"""
            <linearGradient id="{id}" x1="{x1}" y1="{y1}" x2="{x2}" y2="{y2}">
                <stop offset="0%" stop-color="{ToSvgColor(brush.Color1)}" />
                <stop offset="100%" stop-color="{ToSvgColor(brush.Color2)}" />
            </linearGradient>
            """;
    }

    /// <summary>
    /// Generates an SVG pattern definition for a hatch brush.
    /// </summary>
    /// <param name="brush">The hatch brush.</param>
    /// <param name="id">The unique ID for this pattern.</param>
    /// <returns>SVG pattern element string.</returns>
    public static string ToSvgHatchDefinition(ChartHatchBrush brush, string id)
    {
        var patternSize = 8;
        var foreColor = ToSvgColor(brush.ForegroundColor);
        var backColor = ToSvgColor(brush.BackgroundColor);

        // Generate pattern based on hatch style
        var patternContent = brush.HatchStyle switch
        {
            ChartHatchStyle.Horizontal => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="0" y1="{patternSize / 2}" x2="{patternSize}" y2="{patternSize / 2}" stroke="{foreColor}" stroke-width="1"/>
                """,
            ChartHatchStyle.Vertical => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="{patternSize / 2}" y1="0" x2="{patternSize / 2}" y2="{patternSize}" stroke="{foreColor}" stroke-width="1"/>
                """,
            ChartHatchStyle.ForwardDiagonal => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="0" y1="0" x2="{patternSize}" y2="{patternSize}" stroke="{foreColor}" stroke-width="1"/>
                """,
            ChartHatchStyle.BackwardDiagonal => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="{patternSize}" y1="0" x2="0" y2="{patternSize}" stroke="{foreColor}" stroke-width="1"/>
                """,
            ChartHatchStyle.Cross => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="0" y1="{patternSize / 2}" x2="{patternSize}" y2="{patternSize / 2}" stroke="{foreColor}" stroke-width="1"/>
                <line x1="{patternSize / 2}" y1="0" x2="{patternSize / 2}" y2="{patternSize}" stroke="{foreColor}" stroke-width="1"/>
                """,
            ChartHatchStyle.DiagonalCross => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="0" y1="0" x2="{patternSize}" y2="{patternSize}" stroke="{foreColor}" stroke-width="1"/>
                <line x1="{patternSize}" y1="0" x2="0" y2="{patternSize}" stroke="{foreColor}" stroke-width="1"/>
                """,
            _ => $"""
                <rect width="{patternSize}" height="{patternSize}" fill="{backColor}"/>
                <line x1="0" y1="{patternSize / 2}" x2="{patternSize}" y2="{patternSize / 2}" stroke="{foreColor}" stroke-width="1"/>
                """
        };

        return $"""
            <pattern id="{id}" patternUnits="userSpaceOnUse" width="{patternSize}" height="{patternSize}">
                {patternContent}
            </pattern>
            """;
    }

    #endregion

    #region Font Conversion

    /// <summary>
    /// Converts a ChartFont to SVG text style attributes.
    /// </summary>
    /// <param name="font">The chart font to convert.</param>
    /// <returns>SVG font style attribute string.</returns>
    public static string ToSvgFontAttributes(ChartFont font)
    {
        var sb = new StringBuilder();

        sb.Append($"font-family=\"{font.FontFamily ?? "sans-serif"}\" ");
        sb.Append($"font-size=\"{font.Size.ToString(InvariantCulture)}\" ");

        if (font.Bold)
            sb.Append("font-weight=\"bold\" ");

        if (font.Italic)
            sb.Append("font-style=\"italic\" ");

        if (font.Underline || font.Strikeout)
        {
            var decorations = new List<string>();
            if (font.Underline) decorations.Add("underline");
            if (font.Strikeout) decorations.Add("line-through");
            sb.Append($"text-decoration=\"{string.Join(" ", decorations)}\" ");
        }

        return sb.ToString().TrimEnd();
    }

    #endregion

    #region Path Conversion

    /// <summary>
    /// Converts a ChartPath to an SVG path data string (d attribute).
    /// </summary>
    /// <param name="path">The chart path to convert.</param>
    /// <returns>SVG path data string.</returns>
    public static string ToSvgPathData(ChartPath path)
    {
        var sb = new StringBuilder();
        var points = path.PathPoints;
        var types = path.PathTypes;

        if (points.Length == 0)
            return string.Empty;

        int i = 0;
        ChartPointF? lastPoint = null;

        while (i < points.Length)
        {
            var pointType = types[i];
            var baseType = (ChartPathPointType)((byte)pointType & 0x07);
            bool closeSubpath = ((byte)pointType & (byte)ChartPathPointType.CloseSubpath) != 0;

            switch (baseType)
            {
                case ChartPathPointType.Start:
                    sb.Append($"M {FormatPoint(points[i])} ");
                    lastPoint = points[i];
                    i++;
                    break;

                case ChartPathPointType.Line:
                    sb.Append($"L {FormatPoint(points[i])} ");
                    lastPoint = points[i];
                    i++;
                    break;

                case ChartPathPointType.Bezier:
                    if (i + 2 < points.Length)
                    {
                        sb.Append($"C {FormatPoint(points[i])} {FormatPoint(points[i + 1])} {FormatPoint(points[i + 2])} ");
                        lastPoint = points[i + 2];
                        i += 3;
                    }
                    else
                    {
                        i++;
                    }
                    break;

                default:
                    i++;
                    break;
            }

            if (closeSubpath)
            {
                sb.Append("Z ");
            }
        }

        return sb.ToString().TrimEnd();
    }

    /// <summary>
    /// Formats a point for SVG path data.
    /// </summary>
    private static string FormatPoint(ChartPointF point)
    {
        return $"{point.X.ToString(InvariantCulture)},{point.Y.ToString(InvariantCulture)}";
    }

    #endregion

    #region Transform Conversion

    /// <summary>
    /// Converts a ChartMatrix to an SVG transform attribute value.
    /// </summary>
    /// <param name="matrix">The chart matrix to convert.</param>
    /// <returns>SVG transform attribute value.</returns>
    public static string ToSvgTransform(ChartMatrix matrix)
    {
        if (matrix.IsIdentity)
            return string.Empty;

        var e = matrix.Elements;
        return $"matrix({e[0].ToString(InvariantCulture)},{e[1].ToString(InvariantCulture)},{e[2].ToString(InvariantCulture)},{e[3].ToString(InvariantCulture)},{e[4].ToString(InvariantCulture)},{e[5].ToString(InvariantCulture)})";
    }

    #endregion

    #region StringFormat Conversion

    /// <summary>
    /// Converts a ChartStringFormat to SVG text-anchor and alignment attributes.
    /// </summary>
    /// <param name="format">The string format to convert.</param>
    /// <returns>SVG text alignment attributes.</returns>
    public static string ToSvgTextAlignment(ChartStringFormat format)
    {
        var sb = new StringBuilder();

        // Horizontal alignment
        var textAnchor = format.Alignment switch
        {
            ChartStringAlignment.Near => "start",
            ChartStringAlignment.Center => "middle",
            ChartStringAlignment.Far => "end",
            _ => "start"
        };
        sb.Append($"text-anchor=\"{textAnchor}\" ");

        // Vertical alignment (dominant-baseline)
        var dominantBaseline = format.LineAlignment switch
        {
            ChartStringAlignment.Near => "hanging",
            ChartStringAlignment.Center => "central",
            ChartStringAlignment.Far => "alphabetic",
            _ => "alphabetic"
        };
        sb.Append($"dominant-baseline=\"{dominantBaseline}\"");

        return sb.ToString();
    }

    #endregion

    #region Geometry Helpers

    /// <summary>
    /// Formats coordinates for SVG elements.
    /// </summary>
    public static string FormatCoordinate(float value)
    {
        return value.ToString(InvariantCulture);
    }

    /// <summary>
    /// Formats a rectangle for SVG rect element attributes.
    /// </summary>
    public static string ToSvgRectAttributes(ChartRectangleF rect)
    {
        return $"x=\"{FormatCoordinate(rect.X)}\" y=\"{FormatCoordinate(rect.Y)}\" width=\"{FormatCoordinate(rect.Width)}\" height=\"{FormatCoordinate(rect.Height)}\"";
    }

    /// <summary>
    /// Formats an ellipse for SVG ellipse element attributes.
    /// </summary>
    public static string ToSvgEllipseAttributes(ChartRectangleF rect)
    {
        var cx = rect.X + rect.Width / 2;
        var cy = rect.Y + rect.Height / 2;
        var rx = rect.Width / 2;
        var ry = rect.Height / 2;

        return $"cx=\"{FormatCoordinate(cx)}\" cy=\"{FormatCoordinate(cy)}\" rx=\"{FormatCoordinate(rx)}\" ry=\"{FormatCoordinate(ry)}\"";
    }

    /// <summary>
    /// Creates an SVG arc path for pie/arc segments.
    /// </summary>
    /// <param name="rect">Bounding rectangle of the ellipse.</param>
    /// <param name="startAngle">Start angle in degrees.</param>
    /// <param name="sweepAngle">Sweep angle in degrees.</param>
    /// <param name="includeCenterPoint">If true, creates a pie slice; if false, creates an arc.</param>
    /// <returns>SVG path data for the arc.</returns>
    public static string ToSvgArcPath(ChartRectangleF rect, float startAngle, float sweepAngle, bool includeCenterPoint)
    {
        var cx = rect.X + rect.Width / 2;
        var cy = rect.Y + rect.Height / 2;
        var rx = rect.Width / 2;
        var ry = rect.Height / 2;

        // Convert angles from degrees to radians
        var startRad = startAngle * Math.PI / 180.0;
        var endRad = (startAngle + sweepAngle) * Math.PI / 180.0;

        // Calculate start and end points
        var x1 = cx + rx * Math.Cos(startRad);
        var y1 = cy + ry * Math.Sin(startRad);
        var x2 = cx + rx * Math.Cos(endRad);
        var y2 = cy + ry * Math.Sin(endRad);

        // Determine arc flags
        var largeArcFlag = Math.Abs(sweepAngle) > 180 ? 1 : 0;
        var sweepFlag = sweepAngle > 0 ? 1 : 0;

        var sb = new StringBuilder();

        if (includeCenterPoint)
        {
            // Pie slice: start from center
            sb.Append($"M {FormatCoordinate((float)cx)},{FormatCoordinate((float)cy)} ");
            sb.Append($"L {FormatCoordinate((float)x1)},{FormatCoordinate((float)y1)} ");
        }
        else
        {
            // Arc only: start from first point
            sb.Append($"M {FormatCoordinate((float)x1)},{FormatCoordinate((float)y1)} ");
        }

        // Draw the arc
        sb.Append($"A {FormatCoordinate(rx)},{FormatCoordinate(ry)} 0 {largeArcFlag},{sweepFlag} {FormatCoordinate((float)x2)},{FormatCoordinate((float)y2)} ");

        if (includeCenterPoint)
        {
            sb.Append("Z");
        }

        return sb.ToString();
    }

    #endregion
}
