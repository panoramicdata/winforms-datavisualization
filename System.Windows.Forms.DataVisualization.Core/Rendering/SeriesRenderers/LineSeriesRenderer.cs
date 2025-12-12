// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders line, spline, and step line chart types.
/// </summary>
public class LineSeriesRenderer : ISeriesRenderer
{
    /// <inheritdoc />
    public IEnumerable<string> SupportedChartTypes => new[]
    {
        "Line", "FastLine", "Spline", "StepLine"
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
        var color = seriesLayout.Color.IsEmpty ? ChartColor.Blue : seriesLayout.Color;

        using var pen = new ChartPen(color, seriesLayout.LineWidth)
        {
            DashStyle = seriesLayout.DashStyle
        };

        if (chartType.Contains("STEPLINE"))
        {
            RenderStepLine(engine, pen, points);
        }
        else if (chartType.Contains("SPLINE"))
        {
            RenderSpline(engine, pen, points);
        }
        else
        {
            RenderLine(engine, pen, points);
        }

        // Render markers if enabled
        var series = seriesLayout.Series;
        if (series?.ShowMarkers == true && series.MarkerStyle != ChartMarkerStyle.None)
        {
            RenderMarkers(engine, seriesLayout, points);
        }
    }

    /// <summary>
    /// Renders a standard line chart.
    /// </summary>
    private static void RenderLine(IRenderingEngine engine, ChartPen pen, List<DataPointLayout> points)
    {
        if (points.Count < 2)
        {
            if (points.Count == 1)
            {
                // Draw a single point as a small circle
                RenderSinglePoint(engine, pen, points[0]);
            }
            return;
        }

        var chartPoints = points.Select(p => p.Position).ToArray();
        engine.DrawLines(pen, chartPoints);
    }

    /// <summary>
    /// Renders a step line chart.
    /// </summary>
    private static void RenderStepLine(IRenderingEngine engine, ChartPen pen, List<DataPointLayout> points)
    {
        if (points.Count < 2)
        {
            if (points.Count == 1)
            {
                RenderSinglePoint(engine, pen, points[0]);
            }
            return;
        }

        // Step line: horizontal line first, then vertical
        for (int i = 0; i < points.Count - 1; i++)
        {
            var current = points[i].Position;
            var next = points[i + 1].Position;

            // Horizontal segment
            engine.DrawLine(pen, current.X, current.Y, next.X, current.Y);
            // Vertical segment
            engine.DrawLine(pen, next.X, current.Y, next.X, next.Y);
        }
    }

    /// <summary>
    /// Renders a spline (curved) line chart.
    /// </summary>
    private static void RenderSpline(IRenderingEngine engine, ChartPen pen, List<DataPointLayout> points)
    {
        if (points.Count < 2)
        {
            if (points.Count == 1)
            {
                RenderSinglePoint(engine, pen, points[0]);
            }
            return;
        }

        var chartPoints = points.Select(p => p.Position).ToArray();

        if (chartPoints.Length >= 2)
        {
            // Use cardinal spline with default tension
            engine.DrawCurve(pen, chartPoints, 0, chartPoints.Length - 1, 0.5f);
        }
    }

    /// <summary>
    /// Renders a single point as a small marker.
    /// </summary>
    private static void RenderSinglePoint(IRenderingEngine engine, ChartPen pen, DataPointLayout point)
    {
        float size = 4f;
        using var brush = new ChartSolidBrush(pen.Color);
        engine.FillEllipse(brush, point.Position.X - size / 2, point.Position.Y - size / 2, size, size);
    }

    /// <summary>
    /// Renders markers at each data point.
    /// </summary>
    private static void RenderMarkers(IRenderingEngine engine, SeriesLayout seriesLayout, List<DataPointLayout> points)
    {
        var series = seriesLayout.Series;
        if (series == null)
            return;

        foreach (var point in points)
        {
            var style = point.MarkerStyle != ChartMarkerStyle.None
                ? point.MarkerStyle
                : series.MarkerStyle;

            if (style == ChartMarkerStyle.None)
                continue;

            var size = point.MarkerSize.Width > 0 ? point.MarkerSize.Width : series.MarkerSize;
            var color = series.MarkerColor.IsEmpty ? seriesLayout.Color : series.MarkerColor;
            var borderColor = series.MarkerBorderColor.IsEmpty ? color : series.MarkerBorderColor;
            var borderWidth = series.MarkerBorderWidth;

            RenderMarker(engine, style, point.Position, size, color, borderColor, borderWidth);
        }
    }

    /// <summary>
    /// Renders a single marker.
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
                engine.DrawLine(pen, position.X - halfSize, position.Y, position.X + halfSize, position.Y);
                engine.DrawLine(pen, position.X, position.Y - halfSize, position.X, position.Y + halfSize);
                break;

            case ChartMarkerStyle.Star4:
            case ChartMarkerStyle.Star5:
            case ChartMarkerStyle.Star6:
            case ChartMarkerStyle.Star10:
                // Simplified: render as a cross/star shape
                engine.DrawLine(pen, position.X - halfSize, position.Y, position.X + halfSize, position.Y);
                engine.DrawLine(pen, position.X, position.Y - halfSize, position.X, position.Y + halfSize);
                float diagSize = halfSize * 0.7f;
                engine.DrawLine(pen, position.X - diagSize, position.Y - diagSize, position.X + diagSize, position.Y + diagSize);
                engine.DrawLine(pen, position.X - diagSize, position.Y + diagSize, position.X + diagSize, position.Y - diagSize);
                break;

            default:
                // Default to circle
                engine.FillEllipse(brush, position.X - halfSize, position.Y - halfSize, size, size);
                break;
        }
    }
}
