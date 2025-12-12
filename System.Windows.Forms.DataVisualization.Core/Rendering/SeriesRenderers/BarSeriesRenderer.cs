// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders bar and column chart types.
/// </summary>
public class BarSeriesRenderer : ISeriesRenderer
{
    /// <inheritdoc />
    public IEnumerable<string> SupportedChartTypes => new[]
    {
        "Bar", "Column", "StackedBar", "StackedColumn",
        "StackedBar100", "StackedColumn100",
        "RangeBar", "RangeColumn"
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
        bool isHorizontal = chartType.Contains("BAR") && !chartType.Contains("COLUMN");

        foreach (var point in points)
        {
            RenderBar(engine, point, seriesLayout, areaLayout, isHorizontal);
        }
    }

    /// <summary>
    /// Renders a single bar/column.
    /// </summary>
    private static void RenderBar(
        IRenderingEngine engine,
        DataPointLayout point,
        SeriesLayout seriesLayout,
        ChartAreaLayout areaLayout,
        bool isHorizontal)
    {
        var bounds = point.BarBounds;
        if (bounds.IsEmpty || bounds.Width <= 0 || bounds.Height <= 0)
        {
            // Calculate bounds if not already set
            bounds = CalculateBarBounds(point, areaLayout, seriesLayout, isHorizontal);
        }

        if (bounds.IsEmpty || bounds.Width <= 0 || bounds.Height <= 0)
            return;

        var color = point.Color.IsEmpty ? seriesLayout.Color : point.Color;
        if (color.IsEmpty)
            color = ChartColor.Blue;

        using var brush = new ChartSolidBrush(color);
        engine.FillRectangle(brush, bounds);

        // Draw border
        var borderColor = point.Point?.BorderColor ?? seriesLayout.Series?.BorderColor ?? ChartColor.Empty;
        var borderWidth = point.Point?.BorderWidth ?? seriesLayout.Series?.BorderWidth ?? 1f;

        if (!borderColor.IsEmpty && borderWidth > 0)
        {
            using var pen = new ChartPen(borderColor, borderWidth);
            engine.DrawRectangle(pen, bounds);
        }
        else
        {
            // Draw a subtle border
            using var pen = new ChartPen(DarkenColor(color, 0.2f), 1f);
            engine.DrawRectangle(pen, bounds);
        }
    }

    /// <summary>
    /// Calculates the bar bounds if not pre-calculated.
    /// </summary>
    private static ChartRectangleF CalculateBarBounds(
        DataPointLayout point,
        ChartAreaLayout areaLayout,
        SeriesLayout seriesLayout,
        bool isHorizontal)
    {
        var plotArea = areaLayout.PlotAreaBounds;
        var xAxis = areaLayout.AxisXLayout;
        var yAxis = areaLayout.AxisYLayout;

        if (xAxis == null || yAxis == null)
            return ChartRectangleF.Empty;

        int pointCount = seriesLayout.PointLayouts.Count(p => !p.IsEmpty);
        if (pointCount == 0)
            return ChartRectangleF.Empty;

        if (isHorizontal)
        {
            // Horizontal bar: X is the value, Y is the category
            float barHeight = plotArea.Height / pointCount * 0.7f;
            float halfHeight = barHeight / 2;

            float centerY = yAxis.ValueToPixel(point.Index + 1, plotArea.Y, plotArea.Height);
            float startX = xAxis.ValueToPixel(0, plotArea.X, plotArea.Width);
            float endX = xAxis.ValueToPixel(point.YValue, plotArea.X, plotArea.Width);

            float left = Math.Min(startX, endX);
            float width = Math.Abs(endX - startX);

            return new ChartRectangleF(left, centerY - halfHeight, width, barHeight);
        }
        else
        {
            // Vertical column: Y is the value, X is the category
            float barWidth = plotArea.Width / pointCount * 0.7f;
            float halfWidth = barWidth / 2;

            float centerX = point.Position.X;
            float bottomY = yAxis.ValueToPixel(0, plotArea.Y, plotArea.Height);
            float topY = point.Position.Y;

            // Handle negative values
            float y = Math.Min(topY, bottomY);
            float height = Math.Abs(bottomY - topY);

            return new ChartRectangleF(centerX - halfWidth, y, barWidth, height);
        }
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
