// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Windows.Forms.DataVisualization.Charting.Layout;

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Renders Polar chart series.
/// Polar charts are similar to radar charts but use X values as angles.
/// </summary>
public class PolarSeriesRenderer : ISeriesRenderer
{
    /// <inheritdoc/>
    public IEnumerable<string> SupportedChartTypes => new[] { "Polar" };

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
        PolarDrawingStyle drawingStyle = GetDrawingStyle(seriesLayout);

        // Draw based on style
        switch (drawingStyle)
        {
            case PolarDrawingStyle.Line:
                DrawLine(engine, seriesLayout, circularLayout);
                break;

            case PolarDrawingStyle.Marker:
                // Only markers, no lines
                break;
        }

        // Draw markers (always drawn on top)
        DrawMarkers(engine, seriesLayout, circularLayout);
    }

    /// <summary>
    /// Gets the polar drawing style from series properties.
    /// </summary>
    private static PolarDrawingStyle GetDrawingStyle(SeriesLayout seriesLayout)
    {
        // Default to Line style for polar charts
        return PolarDrawingStyle.Line;
    }

    /// <summary>
    /// Draws the line connecting polar points.
    /// Points are ordered by their X value (angle) and connected.
    /// Unlike radar charts, polar charts don't necessarily close the figure.
    /// </summary>
    private void DrawLine(
        IRenderingEngine engine,
        SeriesLayout seriesLayout,
        CircularChartAreaLayout? circularLayout)
    {
        var points = GetValidPointsOrderedByAngle(seriesLayout);
        if (points.Count < 2) return;

        var color = seriesLayout.Color.IsEmpty ? ChartColor.Blue : seriesLayout.Color;
        using var pen = new ChartPen(color, seriesLayout.LineWidth)
        {
            DashStyle = seriesLayout.DashStyle
        };

        // Draw lines between consecutive points (don't close the figure)
        for (int i = 0; i < points.Count - 1; i++)
        {
            engine.DrawLine(
                pen,
                points[i].Position,
                points[i + 1].Position);
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
                using (var crossPen = new ChartPen(color, 2))
                {
                    engine.DrawLine(crossPen,
                        new ChartPointF(position.X - halfSize, position.Y),
                        new ChartPointF(position.X + halfSize, position.Y));
                    engine.DrawLine(crossPen,
                        new ChartPointF(position.X, position.Y - halfSize),
                        new ChartPointF(position.X, position.Y + halfSize));
                }
                break;

            default:
                // Draw as circle for unknown styles
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
    /// Gets the list of valid (non-empty) points ordered by their angle (X value).
    /// </summary>
    private static List<DataPointLayout> GetValidPointsOrderedByAngle(SeriesLayout seriesLayout)
    {
        // For polar charts, X value represents the angle, so order by X value
        return seriesLayout.PointLayouts
            .Where(p => !p.IsEmpty)
            .OrderBy(p => p.XValue)
            .ToList();
    }
}
