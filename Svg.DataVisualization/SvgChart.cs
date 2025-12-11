// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// A lightweight SVG chart generator that creates charts without WinForms dependencies.
/// This class provides a simplified API for creating basic charts with SVG output.
/// </summary>
public class SvgChart : IDisposable
{
    private readonly List<SvgChartSeries> _series;
    private readonly List<SvgChartArea> _chartAreas;
    private bool _disposed;

    /// <summary>
    /// Gets or sets the width of the chart in pixels.
    /// </summary>
    public float Width { get; set; } = 600;

    /// <summary>
    /// Gets or sets the height of the chart in pixels.
    /// </summary>
    public float Height { get; set; } = 400;

    /// <summary>
    /// Gets or sets the background color of the chart.
    /// </summary>
    public ChartColor BackColor { get; set; } = ChartColor.White;

    /// <summary>
    /// Gets or sets the chart title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the title font.
    /// </summary>
    public ChartFont TitleFont { get; set; } = new ChartFont("Arial", 14, ChartFontStyle.Bold);

    /// <summary>
    /// Gets or sets the title color.
    /// </summary>
    public ChartColor TitleColor { get; set; } = ChartColor.Black;

    /// <summary>
    /// Gets the collection of data series.
    /// </summary>
    public IList<SvgChartSeries> Series => _series;

    /// <summary>
    /// Gets the collection of chart areas.
    /// </summary>
    public IList<SvgChartArea> ChartAreas => _chartAreas;

    /// <summary>
    /// Gets or sets whether to show the legend.
    /// </summary>
    public bool ShowLegend { get; set; } = true;

    /// <summary>
    /// Gets or sets the legend position.
    /// </summary>
    public SvgLegendPosition LegendPosition { get; set; } = SvgLegendPosition.Right;

    /// <summary>
    /// Creates a new SvgChart instance.
    /// </summary>
    public SvgChart()
    {
        _series = [];
        _chartAreas = [new SvgChartArea("Default")];
    }

    /// <summary>
    /// Renders the chart to SVG format.
    /// </summary>
    /// <returns>The SVG content as a string.</returns>
    public string RenderToSvg()
    {
        using var engine = new SvgRenderingEngine(Width, Height);
        Render(engine);
        return engine.GetSvgContent();
    }

    /// <summary>
    /// Saves the chart to an SVG file.
    /// </summary>
    /// <param name="path">The file path to save to.</param>
    public void SaveToFile(string path)
    {
        var svg = RenderToSvg();
        File.WriteAllText(path, svg);
    }

    /// <summary>
    /// Gets the chart as a stream.
    /// </summary>
    /// <returns>A stream containing the SVG content.</returns>
    public Stream RenderToStream()
    {
        using var engine = new SvgRenderingEngine(Width, Height);
        Render(engine);
        return engine.ToStream();
    }

    /// <summary>
    /// Renders the chart using the specified rendering engine.
    /// </summary>
    /// <param name="engine">The rendering engine to use.</param>
    private void Render(IRenderingEngine engine)
    {
        // Calculate layout
        var titleHeight = string.IsNullOrEmpty(Title) ? 0f : 30f;
        var legendWidth = ShowLegend && LegendPosition == SvgLegendPosition.Right ? 120f : 0f;
        var legendHeight = ShowLegend && LegendPosition == SvgLegendPosition.Bottom ? 40f : 0f;
        var padding = 20f;

        var chartArea = new ChartRectangleF(
            padding,
            padding + titleHeight,
            Width - (2 * padding) - legendWidth,
            Height - (2 * padding) - titleHeight - legendHeight
        );

        // Draw background
        using var backBrush = new ChartSolidBrush(BackColor);
        engine.FillRectangle(backBrush, 0, 0, Width, Height);

        // Draw title
        if (!string.IsNullOrEmpty(Title))
        {
            using var titleBrush = new ChartSolidBrush(TitleColor);
            var titleFormat = new ChartStringFormat
            {
                Alignment = ChartStringAlignment.Center,
                LineAlignment = ChartStringAlignment.Center
            };
            engine.DrawString(Title, TitleFont, titleBrush, new ChartPointF(Width / 2, padding + titleHeight / 2), titleFormat);
        }

        // Draw chart area background
        var defaultArea = _chartAreas.FirstOrDefault() ?? new SvgChartArea("Default");
        using var areaBrush = new ChartSolidBrush(defaultArea.BackColor);
        engine.FillRectangle(areaBrush, chartArea);

        // Draw axes
        DrawAxes(engine, chartArea, defaultArea);

        // Calculate data bounds
        var (minX, maxX, minY, maxY) = CalculateDataBounds();

        // Draw series
        foreach (var series in _series)
        {
            DrawSeries(engine, chartArea, series, minX, maxX, minY, maxY);
        }

        // Draw legend
        if (ShowLegend && _series.Count > 0)
        {
            DrawLegend(engine, chartArea);
        }
    }

    private void DrawAxes(IRenderingEngine engine, ChartRectangleF chartArea, SvgChartArea area)
    {
        using var axisPen = new ChartPen(area.AxisColor, 1);
        using var gridPen = new ChartPen(area.GridColor, 1) { DashStyle = ChartDashStyle.Dot };

        // Draw X axis
        engine.DrawLine(axisPen, chartArea.Left, chartArea.Bottom, chartArea.Right, chartArea.Bottom);

        // Draw Y axis
        engine.DrawLine(axisPen, chartArea.Left, chartArea.Top, chartArea.Left, chartArea.Bottom);

        // Draw grid lines
        if (area.ShowGrid)
        {
            const int gridLines = 5;

            // Horizontal grid lines
            for (int i = 1; i <= gridLines; i++)
            {
                var y = chartArea.Top + (chartArea.Height * i / (gridLines + 1));
                engine.DrawLine(gridPen, chartArea.Left, y, chartArea.Right, y);
            }

            // Vertical grid lines
            for (int i = 1; i <= gridLines; i++)
            {
                var x = chartArea.Left + (chartArea.Width * i / (gridLines + 1));
                engine.DrawLine(gridPen, x, chartArea.Top, x, chartArea.Bottom);
            }
        }
    }

    private void DrawSeries(IRenderingEngine engine, ChartRectangleF chartArea, SvgChartSeries series, double minX, double maxX, double minY, double maxY)
    {
        if (series.Points.Count == 0)
            return;

        var rangeX = maxX - minX;
        var rangeY = maxY - minY;

        // Prevent division by zero
        if (rangeX == 0) rangeX = 1;
        if (rangeY == 0) rangeY = 1;

        // Convert data points to pixel coordinates
        var pixelPoints = series.Points.Select((p, i) =>
        {
            var x = chartArea.Left + (float)((p.X - minX) / rangeX * chartArea.Width);
            var y = chartArea.Bottom - (float)((p.Y - minY) / rangeY * chartArea.Height);
            return new ChartPointF(x, y);
        }).ToArray();

        using var pen = new ChartPen(series.Color, series.LineWidth);
        using var brush = new ChartSolidBrush(series.Color);

        switch (series.ChartType)
        {
            case SvgChartType.Line:
                DrawLineSeries(engine, pixelPoints, pen);
                if (series.ShowMarkers)
                    DrawMarkers(engine, pixelPoints, brush, series.MarkerSize);
                break;

            case SvgChartType.Area:
                DrawAreaSeries(engine, pixelPoints, chartArea, brush, pen);
                break;

            case SvgChartType.Bar:
                DrawBarSeries(engine, chartArea, series, minX, maxX, minY, maxY, brush, pen);
                break;

            case SvgChartType.Column:
                DrawColumnSeries(engine, chartArea, series, minX, maxX, minY, maxY, brush, pen);
                break;

            case SvgChartType.Scatter:
                DrawMarkers(engine, pixelPoints, brush, series.MarkerSize);
                break;

            case SvgChartType.Pie:
                DrawPieSeries(engine, chartArea, series);
                break;
        }
    }

    private static void DrawLineSeries(IRenderingEngine engine, ChartPointF[] points, ChartPen pen)
    {
        if (points.Length >= 2)
        {
            engine.DrawLines(pen, points);
        }
    }

    private static void DrawAreaSeries(IRenderingEngine engine, ChartPointF[] points, ChartRectangleF chartArea, ChartBrush brush, ChartPen pen)
    {
        if (points.Length < 2)
            return;

        // Create polygon points (include bottom corners)
        var polygonPoints = new ChartPointF[points.Length + 2];
        polygonPoints[0] = new ChartPointF(points[0].X, chartArea.Bottom);
        Array.Copy(points, 0, polygonPoints, 1, points.Length);
        polygonPoints[^1] = new ChartPointF(points[^1].X, chartArea.Bottom);

        engine.FillPolygon(brush, polygonPoints);
        engine.DrawLines(pen, points);
    }

    private static void DrawColumnSeries(IRenderingEngine engine, ChartRectangleF chartArea, SvgChartSeries series,
        double minX, double maxX, double minY, double maxY, ChartBrush brush, ChartPen pen)
    {
        var rangeY = maxY - minY;
        if (rangeY == 0) rangeY = 1;

        var barWidth = chartArea.Width / (series.Points.Count + 1) * 0.8f;
        var spacing = chartArea.Width / (series.Points.Count + 1);

        for (int i = 0; i < series.Points.Count; i++)
        {
            var point = series.Points[i];
            var x = chartArea.Left + spacing * (i + 0.5f);
            var barHeight = (float)((point.Y - minY) / rangeY * chartArea.Height);
            var y = chartArea.Bottom - barHeight;

            engine.FillRectangle(brush, x - barWidth / 2, y, barWidth, barHeight);
            engine.DrawRectangle(pen, x - barWidth / 2, y, barWidth, barHeight);
        }
    }

    private static void DrawBarSeries(IRenderingEngine engine, ChartRectangleF chartArea, SvgChartSeries series,
        double minX, double maxX, double minY, double maxY, ChartBrush brush, ChartPen pen)
    {
        var rangeX = maxX - minX;
        if (rangeX == 0) rangeX = 1;

        var barHeight = chartArea.Height / (series.Points.Count + 1) * 0.8f;
        var spacing = chartArea.Height / (series.Points.Count + 1);

        for (int i = 0; i < series.Points.Count; i++)
        {
            var point = series.Points[i];
            var y = chartArea.Top + spacing * (i + 0.5f);
            var barWidth = (float)((point.Y - minY) / (maxY - minY) * chartArea.Width);

            engine.FillRectangle(brush, chartArea.Left, y - barHeight / 2, barWidth, barHeight);
            engine.DrawRectangle(pen, chartArea.Left, y - barHeight / 2, barWidth, barHeight);
        }
    }

    private void DrawPieSeries(IRenderingEngine engine, ChartRectangleF chartArea, SvgChartSeries series)
    {
        if (series.Points.Count == 0)
            return;

        var total = series.Points.Sum(p => Math.Abs(p.Y));
        if (total == 0)
            return;

        var centerX = chartArea.Left + chartArea.Width / 2;
        var centerY = chartArea.Top + chartArea.Height / 2;
        var radius = Math.Min(chartArea.Width, chartArea.Height) / 2 * 0.8f;

        var rect = new ChartRectangleF(centerX - radius, centerY - radius, radius * 2, radius * 2);
        var startAngle = -90f; // Start from top

        var colors = GetDefaultColors();
        using var borderPen = new ChartPen(ChartColor.White, 1);

        for (int i = 0; i < series.Points.Count; i++)
        {
            var point = series.Points[i];
            var sweepAngle = (float)(Math.Abs(point.Y) / total * 360);

            var color = i < colors.Length ? colors[i] : series.Color;
            using var brush = new ChartSolidBrush(color);

            engine.FillPie(brush, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle);
            engine.DrawPie(borderPen, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle);

            startAngle += sweepAngle;
        }
    }

    private static void DrawMarkers(IRenderingEngine engine, ChartPointF[] points, ChartBrush brush, float markerSize)
    {
        var halfSize = markerSize / 2;
        foreach (var point in points)
        {
            engine.FillEllipse(brush, point.X - halfSize, point.Y - halfSize, markerSize, markerSize);
        }
    }

    private void DrawLegend(IRenderingEngine engine, ChartRectangleF chartArea)
    {
        var legendFont = new ChartFont("Arial", 10);
        var padding = 5f;
        var itemHeight = 20f;
        var symbolWidth = 20f;

        float legendX, legendY;

        if (LegendPosition == SvgLegendPosition.Right)
        {
            legendX = chartArea.Right + 10;
            legendY = chartArea.Top;
        }
        else
        {
            legendX = chartArea.Left;
            legendY = chartArea.Bottom + 10;
        }

        using var textBrush = new ChartSolidBrush(ChartColor.Black);

        for (int i = 0; i < _series.Count; i++)
        {
            var series = _series[i];
            var y = legendY + (i * itemHeight) + padding;

            // Draw color symbol
            using var symbolBrush = new ChartSolidBrush(series.Color);
            engine.FillRectangle(symbolBrush, legendX, y + 2, symbolWidth - 4, itemHeight - 8);

            // Draw series name
            engine.DrawString(series.Name, legendFont, textBrush, new ChartPointF(legendX + symbolWidth + padding, y + itemHeight / 2), null);
        }
    }

    private (double minX, double maxX, double minY, double maxY) CalculateDataBounds()
    {
        double minX = double.MaxValue, maxX = double.MinValue;
        double minY = 0, maxY = double.MinValue; // Start Y at 0 for most chart types

        foreach (var series in _series)
        {
            foreach (var point in series.Points)
            {
                minX = Math.Min(minX, point.X);
                maxX = Math.Max(maxX, point.X);
                minY = Math.Min(minY, point.Y);
                maxY = Math.Max(maxY, point.Y);
            }
        }

        // Handle empty or single-value cases
        if (minX == double.MaxValue) minX = 0;
        if (maxX == double.MinValue) maxX = 1;
        if (maxY == double.MinValue) maxY = 1;

        // Add some padding
        var rangeY = maxY - minY;
        maxY += rangeY * 0.1;

        return (minX, maxX, minY, maxY);
    }

    private static ChartColor[] GetDefaultColors()
    {
        return
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
            ChartColor.FromArgb(0, 92, 219),     // Royal Blue
        ];
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        if (!_disposed)
        {
            _series.Clear();
            _chartAreas.Clear();
            _disposed = true;
        }
    }
}

/// <summary>
/// Represents a data series in an SvgChart.
/// </summary>
public class SvgChartSeries
{
    /// <summary>
    /// Gets or sets the name of the series.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the chart type for this series.
    /// </summary>
    public SvgChartType ChartType { get; set; } = SvgChartType.Line;

    /// <summary>
    /// Gets or sets the color of the series.
    /// </summary>
    public ChartColor Color { get; set; } = ChartColor.FromArgb(65, 140, 240);

    /// <summary>
    /// Gets or sets the line width for line-based charts.
    /// </summary>
    public float LineWidth { get; set; } = 2f;

    /// <summary>
    /// Gets or sets whether to show markers on data points.
    /// </summary>
    public bool ShowMarkers { get; set; } = false;

    /// <summary>
    /// Gets or sets the marker size.
    /// </summary>
    public float MarkerSize { get; set; } = 6f;

    /// <summary>
    /// Gets the collection of data points.
    /// </summary>
    public List<SvgDataPoint> Points { get; } = [];

    /// <summary>
    /// Creates a new SvgChartSeries with the specified name.
    /// </summary>
    public SvgChartSeries(string name = "")
    {
        Name = name;
    }
}

/// <summary>
/// Represents a data point in an SvgChartSeries.
/// </summary>
public struct SvgDataPoint
{
    /// <summary>
    /// Gets or sets the X value.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y value.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the label for this point.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Creates a new data point.
    /// </summary>
    public SvgDataPoint(double x, double y, string label = "")
    {
        X = x;
        Y = y;
        Label = label;
    }
}

/// <summary>
/// Represents a chart area in an SvgChart.
/// </summary>
public class SvgChartArea
{
    /// <summary>
    /// Gets or sets the name of the chart area.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// </summary>
    public ChartColor BackColor { get; set; } = ChartColor.FromArgb(245, 245, 245);

    /// <summary>
    /// Gets or sets the axis color.
    /// </summary>
    public ChartColor AxisColor { get; set; } = ChartColor.Black;

    /// <summary>
    /// Gets or sets the grid color.
    /// </summary>
    public ChartColor GridColor { get; set; } = ChartColor.LightGray;

    /// <summary>
    /// Gets or sets whether to show grid lines.
    /// </summary>
    public bool ShowGrid { get; set; } = true;

    /// <summary>
    /// Creates a new chart area with the specified name.
    /// </summary>
    public SvgChartArea(string name)
    {
        Name = name;
    }
}

/// <summary>
/// Chart types supported by SvgChart.
/// </summary>
public enum SvgChartType
{
    /// <summary>Line chart.</summary>
    Line,

    /// <summary>Area chart.</summary>
    Area,

    /// <summary>Horizontal bar chart.</summary>
    Bar,

    /// <summary>Vertical column chart.</summary>
    Column,

    /// <summary>Scatter plot.</summary>
    Scatter,

    /// <summary>Pie chart.</summary>
    Pie
}

/// <summary>
/// Legend positions for SvgChart.
/// </summary>
public enum SvgLegendPosition
{
    /// <summary>Legend on the right side.</summary>
    Right,

    /// <summary>Legend at the bottom.</summary>
    Bottom
}
