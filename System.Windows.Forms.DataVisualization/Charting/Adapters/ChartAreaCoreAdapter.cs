// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps a WinForms ChartArea to implement the platform-agnostic IChartAreaModel interface.
/// </summary>
public class ChartAreaCoreAdapter : IChartAreaModel
{
    private readonly ChartArea _chartArea;
    private readonly AxisCoreAdapter _axisX;
    private readonly AxisCoreAdapter _axisY;
    private readonly AxisCoreAdapter _axisX2;
    private readonly AxisCoreAdapter _axisY2;

    /// <summary>
    /// Creates a new ChartAreaCoreAdapter wrapping the specified ChartArea.
    /// </summary>
    /// <param name="chartArea">The WinForms ChartArea to adapt.</param>
    public ChartAreaCoreAdapter(ChartArea chartArea)
    {
        _chartArea = chartArea ?? throw new ArgumentNullException(nameof(chartArea));
        _axisX = new AxisCoreAdapter(chartArea.AxisX);
        _axisY = new AxisCoreAdapter(chartArea.AxisY);
        _axisX2 = new AxisCoreAdapter(chartArea.AxisX2);
        _axisY2 = new AxisCoreAdapter(chartArea.AxisY2);
    }

    /// <summary>
    /// Gets the underlying WinForms ChartArea.
    /// </summary>
    public ChartArea ChartArea => _chartArea;

    /// <inheritdoc/>
    public string Name => _chartArea.Name ?? string.Empty;

    /// <inheritdoc/>
    public ChartColor BackColor
    {
        get
        {
            var color = _chartArea.BackColor;
            if (color.IsEmpty)
            {
                return ChartColor.FromArgb(245, 245, 245); // Default light gray
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartColor BackSecondaryColor
    {
        get
        {
            var color = _chartArea.BackSecondaryColor;
            if (color.IsEmpty)
            {
                return ChartColor.White;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartGradientStyle BackGradientStyle => ConvertGradientStyle(_chartArea.BackGradientStyle);

    /// <inheritdoc/>
    public bool ShowGrid
    {
        get
        {
            // Return true if either X or Y axis has major grid enabled
            return _chartArea.AxisX.MajorGrid.Enabled || _chartArea.AxisY.MajorGrid.Enabled;
        }
    }

    /// <inheritdoc/>
    public ChartColor GridColor
    {
        get
        {
            // Use Y axis major grid color as the primary grid color
            var color = _chartArea.AxisY.MajorGrid.LineColor;
            if (color.IsEmpty)
            {
                return ChartColor.LightGray;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public IAxisModel AxisX => _axisX;

    /// <inheritdoc/>
    public IAxisModel AxisY => _axisY;

    /// <inheritdoc/>
    public IAxisModel? AxisX2 => _axisX2.Enabled ? _axisX2 : null;

    /// <inheritdoc/>
    public IAxisModel? AxisY2 => _axisY2.Enabled ? _axisY2 : null;

    private static ChartGradientStyle ConvertGradientStyle(GradientStyle style)
    {
        return style switch
        {
            GradientStyle.None => ChartGradientStyle.None,
            GradientStyle.LeftRight => ChartGradientStyle.LeftRight,
            GradientStyle.TopBottom => ChartGradientStyle.TopBottom,
            GradientStyle.Center => ChartGradientStyle.Center,
            GradientStyle.DiagonalLeft => ChartGradientStyle.DiagonalLeft,
            GradientStyle.DiagonalRight => ChartGradientStyle.DiagonalRight,
            GradientStyle.HorizontalCenter => ChartGradientStyle.HorizontalCenter,
            GradientStyle.VerticalCenter => ChartGradientStyle.VerticalCenter,
            _ => ChartGradientStyle.None
        };
    }
}
