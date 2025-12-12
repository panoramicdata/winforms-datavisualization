// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps an SvgDataPoint to implement the platform-agnostic IDataPointModel interface.
/// </summary>
public class SvgDataPointAdapter : IDataPointModel
{
    private readonly SvgDataPoint _dataPoint;
    private readonly SvgChartSeries _series;
    private readonly int _index;
    private readonly double[] _yValues;

    /// <summary>
    /// Creates a new SvgDataPointAdapter wrapping the specified SvgDataPoint.
    /// </summary>
    /// <param name="dataPoint">The SvgDataPoint to adapt.</param>
    /// <param name="series">The parent series.</param>
    /// <param name="index">The index of the point in the series.</param>
    public SvgDataPointAdapter(SvgDataPoint dataPoint, SvgChartSeries series, int index)
    {
        _dataPoint = dataPoint;
        _series = series ?? throw new ArgumentNullException(nameof(series));
        _index = index;
        _yValues = [dataPoint.Y];
    }

    /// <inheritdoc/>
    public double XValue => _dataPoint.X;

    /// <inheritdoc/>
    public double[] YValues => _yValues;

    /// <inheritdoc/>
    public double YValue => _dataPoint.Y;

    /// <inheritdoc/>
    public string AxisLabel => _dataPoint.Label;

    /// <inheritdoc/>
    public string Label => _dataPoint.Label;

    /// <inheritdoc/>
    public int LabelAngle => 0;

    /// <inheritdoc/>
    public ChartColor Color => _series.Color;

    /// <inheritdoc/>
    public ChartColor BorderColor => ChartColor.Empty;

    /// <inheritdoc/>
    public float BorderWidth => 1;

    /// <inheritdoc/>
    public ChartMarkerStyle MarkerStyle => ConvertMarkerStyle(_series.MarkerStyle);

    /// <inheritdoc/>
    public float MarkerSize => _series.MarkerSize;

    /// <inheritdoc/>
    public ChartColor MarkerColor => _series.Color;

    /// <inheritdoc/>
    public bool IsEmpty => false;

    /// <inheritdoc/>
    public bool IsValueShownAsLabel => _series.IsValueShownAsLabel;

    /// <inheritdoc/>
    public string ToolTip => string.Empty;

    /// <inheritdoc/>
    public string LabelToolTip => string.Empty;

    /// <inheritdoc/>
    public ChartColor LabelForeColor => ChartColor.Black;

    /// <inheritdoc/>
    public ChartColor LabelBackColor => ChartColor.Empty;

    /// <inheritdoc/>
    public ChartColor LabelBorderColor => ChartColor.Empty;

    /// <inheritdoc/>
    public float LabelBorderWidth => 0;

    /// <inheritdoc/>
    public ChartDashStyle LabelBorderDashStyle => ChartDashStyle.Solid;

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
