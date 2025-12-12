// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders area and spline area chart types.
/// </summary>
public class AreaSeriesRenderer : ISeriesRenderer
{
    /// <inheritdoc />
    public IEnumerable<string> SupportedChartTypes => new[]
    {
        "Area", "SplineArea", "StackedArea", "StackedArea100",
        "Range", "SplineRange"
    };

    /// <inheritdoc />
    public void Render(IRenderingEngine engine, SeriesLayout seriesLayout, ChartAreaLayout areaLayout)
    {
        var points = seriesLayout.PointLayouts
            .Where(p => !p.IsEmpty)
            .ToList();

        if (points.Count < 2)
            return;

        var chartType = seriesLayout.ChartType.ToUpperInvariant();
        var color = seriesLayout.Color.IsEmpty ? ChartColor.Blue : seriesLayout.Color;

        // Fill the area
        RenderAreaFill(engine, points, areaLayout, color, chartType.Contains("SPLINE"));

        // Draw the line on top
        RenderAreaLine(engine, points, seriesLayout, chartType.Contains("SPLINE"));
    }

    /// <summary>
    /// Renders the filled area.
    /// </summary>
    private static void RenderAreaFill(
        IRenderingEngine engine,
        List<DataPointLayout> points,
        ChartAreaLayout areaLayout,
        ChartColor color,
        bool isSpline)
    {
        var plotArea = areaLayout.PlotAreaBounds;
        var yAxis = areaLayout.AxisYLayout;

        if (yAxis == null)
            return;

        // Get the baseline (Y = 0 or minimum)
        float baselineY = yAxis.ValueToPixel(Math.Max(0, yAxis.Minimum), plotArea.Y, plotArea.Height);

        // Create polygon points: data points + baseline points
        var polygonPoints = new List<ChartPointF>();

        // Add starting baseline point
        polygonPoints.Add(new ChartPointF(points[0].Position.X, baselineY));

        // Add data points
        foreach (var point in points)
        {
            polygonPoints.Add(point.Position);
        }

        // Add ending baseline point
        polygonPoints.Add(new ChartPointF(points[^1].Position.X, baselineY));

        // Use semi-transparent fill
        var fillColor = ChartColor.FromArgb(128, color.R, color.G, color.B);
        using var brush = new ChartSolidBrush(fillColor);

        engine.FillPolygon(brush, polygonPoints.ToArray());
    }

    /// <summary>
    /// Renders the area outline.
    /// </summary>
    private static void RenderAreaLine(
        IRenderingEngine engine,
        List<DataPointLayout> points,
        SeriesLayout seriesLayout,
        bool isSpline)
    {
        var color = seriesLayout.Color.IsEmpty ? ChartColor.Blue : seriesLayout.Color;
        using var pen = new ChartPen(color, seriesLayout.LineWidth)
        {
            DashStyle = seriesLayout.DashStyle
        };

        var chartPoints = points.Select(p => p.Position).ToArray();

        if (isSpline && chartPoints.Length >= 2)
        {
            engine.DrawCurve(pen, chartPoints, 0, chartPoints.Length - 1, 0.5f);
        }
        else
        {
            engine.DrawLines(pen, chartPoints);
        }
    }
}
