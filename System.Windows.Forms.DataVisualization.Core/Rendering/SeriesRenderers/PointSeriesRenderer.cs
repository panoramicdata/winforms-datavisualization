// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders point, scatter, and bubble chart types.
/// </summary>
public class PointSeriesRenderer : ISeriesRenderer
{
    /// <inheritdoc />
    public IEnumerable<string> SupportedChartTypes => new[]
    {
        "Point", "FastPoint", "Bubble", "Scatter"
    };

    /// <inheritdoc />
    public void Render(IRenderingEngine engine, SeriesLayout seriesLayout, ChartAreaLayout areaLayout)
    {
        var points = seriesLayout.PointLayouts
            .Where(p => !p.IsEmpty)
            .ToList();

        if (points.Count == 0)
            return;

        var chartType = seriesLayout.ChartType.ToUpperInvariant();
        bool isBubble = chartType.Contains("BUBBLE");

        foreach (var point in points)
        {
            RenderPoint(engine, point, seriesLayout, isBubble);
        }
    }

    /// <summary>
    /// Renders a single data point.
    /// </summary>
    private static void RenderPoint(
        IRenderingEngine engine,
        DataPointLayout point,
        SeriesLayout seriesLayout,
        bool isBubble)
    {
        var series = seriesLayout.Series;
        var position = point.Position;

        // Determine marker style
        var style = point.MarkerStyle != ChartMarkerStyle.None
            ? point.MarkerStyle
            : series?.MarkerStyle ?? ChartMarkerStyle.Circle;

        // Determine size
        float size;
        if (isBubble)
        {
            // For bubble charts, size could be based on additional Y values
            size = point.MarkerSize.Width > 0 ? point.MarkerSize.Width : 20f;
        }
        else
        {
            size = point.MarkerSize.Width > 0
                ? point.MarkerSize.Width
                : series?.MarkerSize ?? 8f;
        }

        // Determine colors
        var fillColor = point.Color.IsEmpty
            ? (series?.MarkerColor.IsEmpty == true ? seriesLayout.Color : series?.MarkerColor ?? seriesLayout.Color)
            : point.Color;

        if (fillColor.IsEmpty)
            fillColor = ChartColor.Blue;

        var borderColor = series?.MarkerBorderColor ?? ChartColor.Empty;
        if (borderColor.IsEmpty)
            borderColor = DarkenColor(fillColor, 0.2f);

        var borderWidth = series?.MarkerBorderWidth ?? 1f;

        RenderMarker(engine, style, position, size, fillColor, borderColor, borderWidth);
    }

    /// <summary>
    /// Renders a marker at the specified position.
    /// </summary>
    private static void RenderMarker(
        IRenderingEngine engine,
        ChartMarkerStyle style,
        ChartPointF position,
        float size,
        ChartColor fillColor,
        ChartColor borderColor,
        float borderWidth)
    {
        float halfSize = size / 2;

        using var brush = new ChartSolidBrush(fillColor);
        using var pen = new ChartPen(borderColor, borderWidth);

        switch (style)
        {
            case ChartMarkerStyle.Circle:
                engine.FillEllipse(brush, position.X - halfSize, position.Y - halfSize, size, size);
                if (borderWidth > 0)
                    engine.DrawEllipse(pen, position.X - halfSize, position.Y - halfSize, size, size);
                break;

            case ChartMarkerStyle.Square:
                engine.FillRectangle(brush, position.X - halfSize, position.Y - halfSize, size, size);
                if (borderWidth > 0)
                    engine.DrawRectangle(pen, position.X - halfSize, position.Y - halfSize, size, size);
                break;

            case ChartMarkerStyle.Diamond:
                var diamondPoints = new[]
                {
                    new ChartPointF(position.X, position.Y - halfSize),
                    new ChartPointF(position.X + halfSize, position.Y),
                    new ChartPointF(position.X, position.Y + halfSize),
                    new ChartPointF(position.X - halfSize, position.Y)
                };
                engine.FillPolygon(brush, diamondPoints);
                if (borderWidth > 0)
                    engine.DrawPolygon(pen, diamondPoints);
                break;

            case ChartMarkerStyle.Triangle:
                var trianglePoints = new[]
                {
                    new ChartPointF(position.X, position.Y - halfSize),
                    new ChartPointF(position.X + halfSize, position.Y + halfSize),
                    new ChartPointF(position.X - halfSize, position.Y + halfSize)
                };
                engine.FillPolygon(brush, trianglePoints);
                if (borderWidth > 0)
                    engine.DrawPolygon(pen, trianglePoints);
                break;

            case ChartMarkerStyle.Cross:
                float crossWidth = Math.Max(2, borderWidth);
                using (var crossPen = new ChartPen(fillColor, crossWidth))
                {
                    engine.DrawLine(crossPen, position.X - halfSize, position.Y, position.X + halfSize, position.Y);
                    engine.DrawLine(crossPen, position.X, position.Y - halfSize, position.X, position.Y + halfSize);
                }
                break;

            case ChartMarkerStyle.Star4:
                RenderStar(engine, brush, pen, position, halfSize, 4, borderWidth > 0);
                break;

            case ChartMarkerStyle.Star5:
                RenderStar(engine, brush, pen, position, halfSize, 5, borderWidth > 0);
                break;

            case ChartMarkerStyle.Star6:
                RenderStar(engine, brush, pen, position, halfSize, 6, borderWidth > 0);
                break;

            case ChartMarkerStyle.Star10:
                RenderStar(engine, brush, pen, position, halfSize, 10, borderWidth > 0);
                break;

            default:
                // Default to circle
                engine.FillEllipse(brush, position.X - halfSize, position.Y - halfSize, size, size);
                break;
        }
    }

    /// <summary>
    /// Renders a star-shaped marker.
    /// </summary>
    private static void RenderStar(
        IRenderingEngine engine,
        ChartSolidBrush brush,
        ChartPen pen,
        ChartPointF center,
        float outerRadius,
        int points,
        bool drawBorder)
    {
        float innerRadius = outerRadius * 0.5f;
        int totalPoints = points * 2;
        var starPoints = new ChartPointF[totalPoints];

        for (int i = 0; i < totalPoints; i++)
        {
            float angle = (float)(i * Math.PI / points - Math.PI / 2);
            float radius = i % 2 == 0 ? outerRadius : innerRadius;

            starPoints[i] = new ChartPointF(
                center.X + (float)(Math.Cos(angle) * radius),
                center.Y + (float)(Math.Sin(angle) * radius));
        }

        engine.FillPolygon(brush, starPoints);
        if (drawBorder)
            engine.DrawPolygon(pen, starPoints);
    }

    /// <summary>
    /// Darkens a color by a factor.
    /// </summary>
    private static ChartColor DarkenColor(ChartColor color, float factor)
    {
        int r = (int)(color.R * (1 - factor));
        int g = (int)(color.G * (1 - factor));
        int b = (int)(color.B * (1 - factor));
        return ChartColor.FromArgb(color.A, (byte)r, (byte)g, (byte)b);
    }
}
