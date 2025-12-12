// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps an SvgChartSeries to implement the platform-agnostic ISeriesModel interface.
/// </summary>
public class SvgSeriesAdapter : ISeriesModel
{
    private readonly SvgChartSeries _series;
    private readonly List<IDataPointModel> _points;

    /// <summary>
    /// Creates a new SvgSeriesAdapter wrapping the specified SvgChartSeries.
    /// </summary>
    /// <param name="series">The SvgChartSeries to adapt.</param>
    public SvgSeriesAdapter(SvgChartSeries series)
    {
        _series = series ?? throw new ArgumentNullException(nameof(series));
        
        // Create adapters for data points
        _points = [];
        for (int i = 0; i < _series.Points.Count; i++)
        {
            _points.Add(new SvgDataPointAdapter(_series.Points[i], _series, i));
        }
    }

    /// <summary>
    /// Gets the underlying SvgChartSeries.
    /// </summary>
    public SvgChartSeries Series => _series;

    /// <inheritdoc/>
    public string Name => _series.Name;

    /// <inheritdoc/>
    public string ChartType => ConvertChartType(_series.ChartType);

    /// <inheritdoc/>
    public string ChartArea => string.Empty; // SvgChart uses default area

    /// <inheritdoc/>
    public ChartColor Color => _series.Color;

    /// <inheritdoc/>
    public ChartColor BorderColor => _series.Color;

    /// <inheritdoc/>
    public float BorderWidth => _series.LineWidth;

    /// <inheritdoc/>
    public ChartDashStyle BorderDashStyle => ChartDashStyle.Solid;

    /// <inheritdoc/>
    public IReadOnlyList<IDataPointModel> Points => _points;

    /// <inheritdoc/>
    public bool ShowMarkers => _series.ShowMarkers;

    /// <inheritdoc/>
    public ChartMarkerStyle MarkerStyle => ConvertMarkerStyle(_series.MarkerStyle);

    /// <inheritdoc/>
    public float MarkerSize => _series.MarkerSize;

    /// <inheritdoc/>
    public ChartColor MarkerColor => _series.Color;

    /// <inheritdoc/>
    public ChartColor MarkerBorderColor => ChartColor.Empty;

    /// <inheritdoc/>
    public float MarkerBorderWidth => 0;

    /// <inheritdoc/>
    public bool IsValueShownAsLabel => _series.IsValueShownAsLabel;

    /// <inheritdoc/>
    public string LabelFormat => string.Empty;

    /// <inheritdoc/>
    public ChartFont LabelFont => new ChartFont("Arial", 10);

    /// <inheritdoc/>
    public ChartColor LabelForeColor => ChartColor.Black;

    /// <inheritdoc/>
    public bool IsVisible => true;

    /// <inheritdoc/>
    public bool IsXValueIndexed => false;

    /// <inheritdoc/>
    public ChartAxisType XAxisType => ChartAxisType.Primary;

    /// <inheritdoc/>
    public ChartAxisType YAxisType => ChartAxisType.Primary;

    /// <summary>
    /// Converts SvgChartType to the string chart type name used by Core.
    /// </summary>
    private static string ConvertChartType(SvgChartType chartType)
    {
        return chartType switch
        {
            SvgChartType.Line => "Line",
            SvgChartType.Spline => "Spline",
            SvgChartType.StepLine => "StepLine",
            SvgChartType.Area => "Area",
            SvgChartType.SplineArea => "SplineArea",
            SvgChartType.Bar => "Bar",
            SvgChartType.Column => "Column",
            SvgChartType.Point => "Point",
            SvgChartType.Pie => "Pie",
            SvgChartType.Radar => "Radar",
            SvgChartType.Polar => "Polar",
            _ => "Line"
        };
    }

    /// <summary>
    /// Converts SvgMarkerStyle to ChartMarkerStyle.
    /// </summary>
    private static ChartMarkerStyle ConvertMarkerStyle(SvgMarkerStyle style)
    {
        return style switch
        {
            SvgMarkerStyle.None => ChartMarkerStyle.None,
            SvgMarkerStyle.Square => ChartMarkerStyle.Square,
            SvgMarkerStyle.Circle => ChartMarkerStyle.Circle,
            SvgMarkerStyle.Diamond => ChartMarkerStyle.Diamond,
            SvgMarkerStyle.Triangle => ChartMarkerStyle.Triangle,
            SvgMarkerStyle.Cross => ChartMarkerStyle.Cross,
            SvgMarkerStyle.Star4 => ChartMarkerStyle.Star4,
            SvgMarkerStyle.Star5 => ChartMarkerStyle.Star5,
            SvgMarkerStyle.Star6 => ChartMarkerStyle.Star6,
            SvgMarkerStyle.Star10 => ChartMarkerStyle.Star10,
            _ => ChartMarkerStyle.None
        };
    }
}
