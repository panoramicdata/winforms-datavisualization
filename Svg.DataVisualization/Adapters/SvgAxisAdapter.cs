// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that provides axis settings for SvgChart.
/// SvgChart doesn't have explicit axis objects, so this provides sensible defaults.
/// </summary>
public class SvgAxisAdapter : IAxisModel
{
    private readonly bool _isVertical;
    private readonly double _minimum;
    private readonly double _maximum;
    private readonly SvgChartArea? _chartArea;
    private readonly SvgAxis _axis;
    private readonly List<string> _customLabels = [];

    /// <summary>
    /// Creates a new SvgAxisAdapter with the specified settings.
    /// </summary>
    /// <param name="isVertical">Whether this is a vertical (Y) axis.</param>
    /// <param name="minimum">The minimum data value.</param>
    /// <param name="maximum">The maximum data value.</param>
    /// <param name="chartArea">The parent chart area.</param>
    public SvgAxisAdapter(bool isVertical, double minimum, double maximum, SvgChartArea chartArea)
    {
        _isVertical = isVertical;
        _minimum = minimum;
        _maximum = maximum;
        _chartArea = chartArea ?? throw new ArgumentNullException(nameof(chartArea));
        _axis = isVertical ? chartArea.AxisY : chartArea.AxisX;
    }

    /// <summary>
    /// Creates a new SvgAxisAdapter from an SvgAxis with default min/max.
    /// Used for circular charts where axis range is determined by data.
    /// </summary>
    /// <param name="axis">The SvgAxis to adapt.</param>
    public SvgAxisAdapter(SvgAxis axis)
    {
        _axis = axis ?? throw new ArgumentNullException(nameof(axis));
        _isVertical = false;
        _minimum = 0;
        _maximum = 100;
        _chartArea = null;
    }

    /// <inheritdoc/>
    public bool Enabled => true;

    /// <inheritdoc/>
    public string Title => string.Empty;

    /// <inheritdoc/>
    public double Minimum => _minimum;

    /// <inheritdoc/>
    public double Maximum => _maximum;

    /// <inheritdoc/>
    public double Interval => CalculateNiceInterval(_maximum - _minimum, 5);

    /// <inheritdoc/>
    public ChartColor LineColor => _chartArea?.AxisColor ?? ChartColor.FromArgb(64, 64, 64, 64);

    /// <inheritdoc/>
    public float LineWidth => 1f;

    /// <inheritdoc/>
    public bool ShowMajorGrid => _chartArea?.ShowGrid ?? true && _axis.ShowMajorGrid;

    /// <inheritdoc/>
    public bool ShowTickMarks => _axis.ShowTickMarks;

    /// <inheritdoc/>
    public bool ShowLabels => _axis.ShowLabels;

    /// <inheritdoc/>
    public ChartFont LabelFont => new ChartFont("Arial", 10);

    /// <inheritdoc/>
    public ChartFont? TitleFont => null;

    /// <inheritdoc/>
    public ChartColor LabelColor => ChartColor.Black;

    /// <inheritdoc/>
    public IReadOnlyList<string> CustomLabels => _customLabels;

    /// <inheritdoc/>
    public bool IsReversed => false;

    /// <inheritdoc/>
    public bool IsLogarithmic => false;

    /// <inheritdoc/>
    public double LogarithmBase => 10;

    /// <inheritdoc/>
    public bool IsMarginVisible => _axis.IsMarginVisible;

    /// <summary>
    /// Calculates a "nice" interval for axis labels.
    /// </summary>
    private static double CalculateNiceInterval(double range, int targetSteps)
    {
        if (range <= 0)
            return 1.0;

        double roughInterval = range / targetSteps;
        double magnitude = Math.Pow(10, Math.Floor(Math.Log10(roughInterval)));
        double residual = roughInterval / magnitude;

        double niceInterval;
        if (residual <= 1.5)
            niceInterval = magnitude;
        else if (residual <= 3)
            niceInterval = 2 * magnitude;
        else if (residual <= 7)
            niceInterval = 5 * magnitude;
        else
            niceInterval = 10 * magnitude;

        return niceInterval;
    }
}
