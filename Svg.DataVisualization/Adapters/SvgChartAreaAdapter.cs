// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps an SvgChartArea to implement the platform-agnostic IChartAreaModel interface.
/// </summary>
public class SvgChartAreaAdapter : IChartAreaModel
{
    private readonly SvgChartArea _chartArea;
    private readonly SvgAxisAdapter _axisX;
    private readonly SvgAxisAdapter _axisY;

    /// <summary>
    /// Creates a new SvgChartAreaAdapter wrapping the specified SvgChartArea.
    /// </summary>
    /// <param name="chartArea">The SvgChartArea to adapt.</param>
    /// <param name="chart">The parent SvgChart for calculating data bounds.</param>
    public SvgChartAreaAdapter(SvgChartArea chartArea, SvgChart chart)
    {
        _chartArea = chartArea ?? throw new ArgumentNullException(nameof(chartArea));
        
        // Calculate data bounds from all series
        var (minX, maxX, minY, maxY) = CalculateDataBounds(chart);
        
        // Create axis adapters with calculated bounds
        _axisX = new SvgAxisAdapter(false, minX, maxX, chartArea);
        _axisY = new SvgAxisAdapter(true, minY, maxY, chartArea);
    }

    /// <summary>
    /// Gets the underlying SvgChartArea.
    /// </summary>
    public SvgChartArea ChartArea => _chartArea;

    /// <inheritdoc/>
    public string Name => _chartArea.Name;

    /// <inheritdoc/>
    public ChartColor BackColor => _chartArea.BackColor;

    /// <inheritdoc/>
    public ChartColor BackSecondaryColor => _chartArea.BackSecondaryColor;

    /// <inheritdoc/>
    public ChartGradientStyle BackGradientStyle => _chartArea.BackGradientStyle;

    /// <inheritdoc/>
    public bool ShowGrid => _chartArea.ShowGrid;

    /// <inheritdoc/>
    public ChartColor GridColor => _chartArea.GridColor;

    /// <inheritdoc/>
    public IAxisModel AxisX => _axisX;

    /// <inheritdoc/>
    public IAxisModel AxisY => _axisY;

    /// <inheritdoc/>
    public IAxisModel? AxisX2 => null; // SvgChart doesn't support secondary axes yet

    /// <inheritdoc/>
    public IAxisModel? AxisY2 => null;

    /// <summary>
    /// Calculates data bounds from the chart's series.
    /// </summary>
    private static (double minX, double maxX, double minY, double maxY) CalculateDataBounds(SvgChart chart)
    {
        double minX = double.MaxValue, maxX = double.MinValue;
        double minY = 0, maxY = double.MinValue; // Start Y at 0 for most chart types

        foreach (var series in chart.Series)
        {
            for (int i = 0; i < series.Points.Count; i++)
            {
                var point = series.Points[i];
                minX = Math.Min(minX, point.X);
                maxX = Math.Max(maxX, point.X);
                minY = Math.Min(minY, point.Y);
                maxY = Math.Max(maxY, point.Y);
            }
        }

        // Handle empty or single-value cases
        if (minX == double.MaxValue) minX = 0;
        if (maxX == double.MinValue) maxX = 10;
        if (maxY == double.MinValue) maxY = 10;

        // Ensure we have some range
        if (minX == maxX)
        {
            minX -= 1;
            maxX += 1;
        }
        if (minY == maxY)
        {
            minY -= 1;
            maxY += 1;
        }

        // Add some padding to max Y
        var rangeY = maxY - minY;
        maxY += rangeY * 0.1;

        return (minX, maxX, minY, maxY);
    }
}
