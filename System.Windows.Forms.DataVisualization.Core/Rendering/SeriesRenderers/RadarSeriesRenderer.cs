// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Windows.Forms.DataVisualization.Charting.Layout;

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Renders Radar chart series.
/// </summary>
public class RadarSeriesRenderer : ISeriesRenderer
{
    /// <inheritdoc/>
    public IEnumerable<string> SupportedChartTypes => ["Radar"];

    /// <inheritdoc/>
    public void Render(
        IRenderingEngine engine,
        SeriesLayout seriesLayout,
        ChartAreaLayout areaLayout)
    {
        if (seriesLayout.PointLayouts.Count == 0)
            return;

        // Check if this is a circular layout
        var circularLayout = areaLayout as CircularChartAreaLayout;

        // Get drawing style from series
        RadarDrawingStyle drawingStyle = GetDrawingStyle(seriesLayout);

        // Draw based on style
        switch (drawingStyle)
        {
            case RadarDrawingStyle.Area:
                DrawArea(engine, seriesLayout, circularLayout);
                DrawLine(engine, seriesLayout, circularLayout, true);
                break;

            case RadarDrawingStyle.Line:
                DrawLine(engine, seriesLayout, circularLayout, true);
                break;

            case RadarDrawingStyle.Marker:
                // Markers are drawn after the area/line
                break;
        }

        // Draw markers (always drawn on top)
        DrawMarkers(engine, seriesLayout, circularLayout);
    }

    /// <summary>
    /// Gets the radar drawing style from series properties.
    /// </summary>
    private static RadarDrawingStyle GetDrawingStyle(SeriesLayout seriesLayout)
    {
        // Default to Area style
        return RadarDrawingStyle.Area;
    }

    /// <summary>
    /// Draws the filled area for radar chart.
    /// </summary>
    private void DrawArea(
        IRenderingEngine engine,
        SeriesLayout seriesLayout,
        CircularChartAreaLayout? circularLayout)
    {
        var points = GetValidPoints(seriesLayout);
        if (points.Count < 3) return;

        var color = seriesLayout.Color.IsEmpty ? ChartColor.Blue : seriesLayout.Color;

        // Create polygon path
        var pathPoints = points.Select(p => p.Position).ToList();

        // Add center point to close the shape properly if we have circular layout
        if (circularLayout != null)
        {
            // For each segment, we draw a filled triangle from center
            for (int i = 0; i < points.Count; i++)
            {
                int nextIndex = (i + 1) % points.Count;
                
                var p1 = circularLayout.Center;
                var p2 = points[i].Position;
                var p3 = points[nextIndex].Position;

                // Create semi-transparent fill color
                var fillColor = ChartColor.FromArgb(180, color.R, color.G, color.B);
                using var brush = new ChartSolidBrush(fillColor);

                engine.FillPolygon(brush, [p1, p2, p3]);
            }
        }
        else
        {
            // Fallback: just fill the polygon
            var fillColor = ChartColor.FromArgb(180, color.R, color.G, color.B);
            using var brush = new ChartSolidBrush(fillColor);
            engine.FillPolygon(brush, [.. pathPoints]);
        }
    }

    /// <summary>
    /// Draws the line connecting radar points.
    /// </summary>
    private void DrawLine(
        IRenderingEngine engine,
        SeriesLayout seriesLayout,
        CircularChartAreaLayout? circularLayout,
        bool closeFigure)
    {
        var points = GetValidPoints(seriesLayout);
        if (points.Count < 2) return;

        var color = seriesLayout.Color.IsEmpty ? ChartColor.Blue : seriesLayout.Color;
        using var pen = new ChartPen(color, seriesLayout.LineWidth)
        {
            DashStyle = seriesLayout.DashStyle
        };

        // Draw lines between consecutive points
        for (int i = 0; i < points.Count; i++)
        {
            int nextIndex = (i + 1) % points.Count;
            
            // Skip closing line if not required
            if (!closeFigure && nextIndex == 0) break;

            engine.DrawLine(
                pen,
                points[i].Position,
                points[nextIndex].Position);
        }
    }

    /// <summary>
    /// Draws markers at each data point.
    /// </summary>
    private void DrawMarkers(
        IRenderingEngine engine,
        SeriesLayout seriesLayout,
        CircularChartAreaLayout? circularLayout)
    {
        foreach (var point in seriesLayout.PointLayouts)
        {
            if (point.IsEmpty) continue;
            if (point.MarkerStyle == ChartMarkerStyle.None) continue;

            var markerColor = point.Color.IsEmpty ? seriesLayout.Color : point.Color;
            if (markerColor.IsEmpty) markerColor = ChartColor.Blue;
            var markerSize = point.MarkerSize.Width > 0 ? point.MarkerSize.Width : 8f;

            DrawMarker(engine, point.Position, point.MarkerStyle, markerSize, markerColor);
        }
    }

    /// <summary>
    /// Draws a single marker.
    /// </summary>
    private void DrawMarker(
        IRenderingEngine engine,
        ChartPointF position,
        ChartMarkerStyle style,
        float size,
        ChartColor color)
    {
        float halfSize = size / 2f;
        using var brush = new ChartSolidBrush(color);
        var borderColor = ChartColor.FromArgb(color.A, 
            (byte)Math.Max(0, color.R - 50), 
            (byte)Math.Max(0, color.G - 50), 
            (byte)Math.Max(0, color.B - 50));
        using var borderPen = new ChartPen(borderColor, 1);

        switch (style)
        {
            case ChartMarkerStyle.Circle:
                engine.FillEllipse(
                    brush,
                    new ChartRectangleF(
                        position.X - halfSize,
                        position.Y - halfSize,
                        size,
                        size));
                engine.DrawEllipse(
                    borderPen,
                    new ChartRectangleF(
                        position.X - halfSize,
                        position.Y - halfSize,
                        size,
                        size));
                break;

            case ChartMarkerStyle.Square:
                engine.FillRectangle(
                    brush,
                    new ChartRectangleF(
                        position.X - halfSize,
                        position.Y - halfSize,
                        size,
                        size));
                engine.DrawRectangle(
                    borderPen,
                    new ChartRectangleF(
                        position.X - halfSize,
                        position.Y - halfSize,
                        size,
                        size));
                break;

            case ChartMarkerStyle.Diamond:
                var diamondPoints = new ChartPointF[]
                {
                    new(position.X, position.Y - halfSize),
                    new(position.X + halfSize, position.Y),
                    new(position.X, position.Y + halfSize),
                    new(position.X - halfSize, position.Y)
                };
                engine.FillPolygon(brush, diamondPoints);
                engine.DrawPolygon(borderPen, diamondPoints);
                break;

            case ChartMarkerStyle.Triangle:
                var trianglePoints = new ChartPointF[]
                {
                    new(position.X, position.Y - halfSize),
                    new(position.X + halfSize, position.Y + halfSize),
                    new(position.X - halfSize, position.Y + halfSize)
                };
                engine.FillPolygon(brush, trianglePoints);
                engine.DrawPolygon(borderPen, trianglePoints);
                break;

            case ChartMarkerStyle.Cross:
                var crossPen = new ChartPen(color, 2);
                engine.DrawLine(crossPen, 
                    new ChartPointF(position.X - halfSize, position.Y),
                    new ChartPointF(position.X + halfSize, position.Y));
                engine.DrawLine(crossPen,
                    new ChartPointF(position.X, position.Y - halfSize),
                    new ChartPointF(position.X, position.Y + halfSize));
                break;

            case ChartMarkerStyle.Star4:
            case ChartMarkerStyle.Star5:
            case ChartMarkerStyle.Star6:
            case ChartMarkerStyle.Star10:
                // Draw as circle for now
                engine.FillEllipse(
                    brush,
                    new ChartRectangleF(
                        position.X - halfSize,
                        position.Y - halfSize,
                        size,
                        size));
                break;
        }
    }

    /// <summary>
    /// Gets the list of valid (non-empty) points in order.
    /// </summary>
    private static List<DataPointLayout> GetValidPoints(SeriesLayout seriesLayout)
    {
        return seriesLayout.PointLayouts
            .Where(p => !p.IsEmpty)
            .OrderBy(p => p.Index)
            .ToList();
    }
}
