// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps an SvgChart to implement the platform-agnostic IChartModel interface.
/// This allows the Core layout engine and renderer to work with SvgChart.
/// </summary>
public class SvgChartAdapter : IChartModel
{
    private readonly SvgChart _chart;
    private readonly List<IChartAreaModel> _chartAreas;
    private readonly List<ISeriesModel> _series;

    /// <summary>
    /// Creates a new SvgChartAdapter wrapping the specified SvgChart.
    /// </summary>
    /// <param name="chart">The SvgChart to adapt.</param>
    public SvgChartAdapter(SvgChart chart)
    {
        _chart = chart ?? throw new ArgumentNullException(nameof(chart));
        
        // Create adapters for chart areas
        _chartAreas = [];
        foreach (var area in _chart.ChartAreas)
        {
            _chartAreas.Add(CreateChartAreaAdapter(area, _chart));
        }

        // Create adapters for series
        _series = [];
        foreach (var series in _chart.Series)
        {
            _series.Add(new SvgSeriesAdapter(series));
        }
    }

    /// <summary>
    /// Creates the appropriate adapter for a chart area based on its type.
    /// </summary>
    private static IChartAreaModel CreateChartAreaAdapter(SvgChartArea area, SvgChart chart)
    {
        // Check if any series uses radar or polar chart type
        bool hasCircularSeries = chart.Series.Any(s => 
            s.ChartType == SvgChartType.Radar || s.ChartType == SvgChartType.Polar);

        // Use circular adapter if area is circular or series require it
        if (area is SvgCircularChartArea circularArea)
        {
            return new SvgCircularChartAreaAdapter(circularArea, chart);
        }
        else if (hasCircularSeries)
        {
            // Auto-create circular area from regular area when series need it
            var autoCircular = new SvgCircularChartArea(area.Name)
            {
                BackColor = area.BackColor,
                BackSecondaryColor = area.BackSecondaryColor,
                BackGradientStyle = area.BackGradientStyle,
                AxisColor = area.AxisColor,
                GridColor = area.GridColor,
                ShowGrid = area.ShowGrid
            };

            // Set sector count based on max points in circular series
            int maxPoints = chart.Series
                .Where(s => s.ChartType == SvgChartType.Radar || s.ChartType == SvgChartType.Polar)
                .Select(s => s.Points.Count)
                .DefaultIfEmpty(12)
                .Max();

            autoCircular.SectorCount = maxPoints;

            // Get labels from first radar series
            var radarSeries = chart.Series.FirstOrDefault(s => s.ChartType == SvgChartType.Radar);
            if (radarSeries != null)
            {
                foreach (var point in radarSeries.Points)
                {
                    autoCircular.AxisLabels.Add(point.Label);
                }
            }

            return new SvgCircularChartAreaAdapter(autoCircular, chart);
        }

        return new SvgChartAreaAdapter(area, chart);
    }

    /// <summary>
    /// Gets the underlying SvgChart.
    /// </summary>
    public SvgChart Chart => _chart;

    /// <inheritdoc/>
    public float Width => _chart.Width;

    /// <inheritdoc/>
    public float Height => _chart.Height;

    /// <inheritdoc/>
    public ChartColor BackColor => _chart.BackColor;

    /// <inheritdoc/>
    public ChartColor BackSecondaryColor => _chart.BackSecondaryColor;

    /// <inheritdoc/>
    public ChartGradientStyle BackGradientStyle => _chart.BackGradientStyle;

    /// <inheritdoc/>
    public string Title => _chart.Title;

    /// <inheritdoc/>
    public ChartFont TitleFont => _chart.TitleFont;

    /// <inheritdoc/>
    public ChartColor TitleColor => _chart.TitleColor;

    /// <inheritdoc/>
    public IReadOnlyList<IChartAreaModel> ChartAreas => _chartAreas;

    /// <inheritdoc/>
    public IReadOnlyList<ISeriesModel> Series => _series;

    /// <inheritdoc/>
    public bool ShowLegend => _chart.ShowLegend;

    /// <inheritdoc/>
    public ChartLegendPosition LegendPosition => _chart.LegendPosition switch
    {
        SvgLegendPosition.Right => ChartLegendPosition.Right,
        SvgLegendPosition.Bottom => ChartLegendPosition.Bottom,
        _ => ChartLegendPosition.Right
    };

    /// <summary>
    /// Refreshes the adapter to pick up changes in the underlying SvgChart.
    /// </summary>
    public void Refresh()
    {
        // Rebuild chart areas list
        _chartAreas.Clear();
        foreach (var area in _chart.ChartAreas)
        {
            _chartAreas.Add(CreateChartAreaAdapter(area, _chart));
        }

        // Rebuild series list
        _series.Clear();
        foreach (var series in _chart.Series)
        {
            _series.Add(new SvgSeriesAdapter(series));
        }
    }
}
