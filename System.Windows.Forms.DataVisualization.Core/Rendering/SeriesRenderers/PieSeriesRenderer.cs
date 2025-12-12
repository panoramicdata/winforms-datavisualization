// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders pie and doughnut chart types.
/// </summary>
public class PieSeriesRenderer : ISeriesRenderer
{
    /// <summary>
    /// Default color palette for pie slices.
    /// </summary>
    private static readonly ChartColor[] DefaultPalette =
    [
        ChartColor.FromArgb(65, 140, 240),   // Blue
        ChartColor.FromArgb(252, 180, 65),   // Orange
        ChartColor.FromArgb(224, 64, 10),    // Red
        ChartColor.FromArgb(5, 100, 146),    // Dark Blue
        ChartColor.FromArgb(191, 191, 191),  // Gray
        ChartColor.FromArgb(26, 59, 105),    // Navy
        ChartColor.FromArgb(255, 227, 130),  // Yellow
        ChartColor.FromArgb(18, 156, 221),   // Light Blue
        ChartColor.FromArgb(202, 107, 75),   // Brown
        ChartColor.FromArgb(0, 92, 219)      // Azure
    ];

    /// <inheritdoc />
    public IEnumerable<string> SupportedChartTypes => new[]
    {
        "Pie", "Doughnut"
    };

    /// <inheritdoc />
    public void Render(IRenderingEngine engine, SeriesLayout seriesLayout, ChartAreaLayout areaLayout)
    {
        var points = seriesLayout.PointLayouts
            .Where(p => !p.IsEmpty && p.YValue > 0)
            .ToList();

        if (points.Count == 0)
            return;

        var chartType = seriesLayout.ChartType.ToUpperInvariant();
        bool isDoughnut = chartType.Contains("DOUGHNUT");

        // Calculate total for percentages
        double total = points.Sum(p => Math.Abs(p.YValue));
        if (total == 0)
            return;

        // Calculate pie bounds (centered in plot area)
        var plotArea = areaLayout.PlotAreaBounds;
        float pieSize = Math.Min(plotArea.Width, plotArea.Height) * 0.8f;
        float pieX = plotArea.X + (plotArea.Width - pieSize) / 2;
        float pieY = plotArea.Y + (plotArea.Height - pieSize) / 2;

        float startAngle = -90f; // Start from top

        for (int i = 0; i < points.Count; i++)
        {
            var point = points[i];
            float sweepAngle = (float)(point.YValue / total * 360);

            // Get color from point, series, or default palette
            var color = point.Color.IsEmpty
                ? (seriesLayout.Color.IsEmpty ? DefaultPalette[i % DefaultPalette.Length] : seriesLayout.Color)
                : point.Color;

            RenderSlice(engine, pieX, pieY, pieSize, pieSize, startAngle, sweepAngle, color, isDoughnut);

            // Draw slice border
            using var borderPen = new ChartPen(ChartColor.White, 2f);
            engine.DrawPie(borderPen, pieX, pieY, pieSize, pieSize, startAngle, sweepAngle);

            startAngle += sweepAngle;
        }

        // Render labels
        RenderLabels(engine, points, total, plotArea, pieX, pieY, pieSize);
    }

    /// <summary>
    /// Renders a single pie slice.
    /// </summary>
    private static void RenderSlice(
        IRenderingEngine engine,
        float x, float y, float width, float height,
        float startAngle, float sweepAngle,
        ChartColor color,
        bool isDoughnut)
    {
        using var brush = new ChartSolidBrush(color);
        engine.FillPie(brush, x, y, width, height, startAngle, sweepAngle);

        if (isDoughnut)
        {
            // Cut out the center
            float innerSize = width * 0.4f;
            float innerX = x + (width - innerSize) / 2;
            float innerY = y + (height - innerSize) / 2;

            // Draw white center to create doughnut effect
            using var centerBrush = new ChartSolidBrush(ChartColor.White);
            engine.FillEllipse(centerBrush, innerX, innerY, innerSize, innerSize);
        }
    }

    /// <summary>
    /// Renders labels for pie slices.
    /// </summary>
    private static void RenderLabels(
        IRenderingEngine engine,
        List<DataPointLayout> points,
        double total,
        ChartRectangleF plotArea,
        float pieX, float pieY, float pieSize)
    {
        float centerX = pieX + pieSize / 2;
        float centerY = pieY + pieSize / 2;
        float labelRadius = pieSize / 2 + 20; // Position labels outside the pie

        float startAngle = -90f;
        var font = new ChartFont("Arial", 9f);
        using var brush = new ChartSolidBrush(ChartColor.Black);

        foreach (var point in points)
        {
            float sweepAngle = (float)(point.YValue / total * 360);
            float midAngle = startAngle + sweepAngle / 2;

            // Convert to radians
            double radians = midAngle * Math.PI / 180;

            // Calculate label position
            float labelX = centerX + (float)(Math.Cos(radians) * labelRadius);
            float labelY = centerY + (float)(Math.Sin(radians) * labelRadius);

            // Get label text
            string labelText = !string.IsNullOrEmpty(point.Label)
                ? point.Label
                : $"{point.YValue / total:P0}";

            var format = new ChartStringFormat
            {
                Alignment = labelX > centerX ? ChartStringAlignment.Near : ChartStringAlignment.Far,
                LineAlignment = ChartStringAlignment.Center
            };

            engine.DrawString(labelText, font, brush, new ChartPointF(labelX, labelY), format);

            startAngle += sweepAngle;
        }
    }
}
