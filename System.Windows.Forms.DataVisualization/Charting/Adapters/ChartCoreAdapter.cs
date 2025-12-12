// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps a WinForms Chart to implement the platform-agnostic IChartModel interface.
/// This allows the Core layout engine and renderer to work with WinForms charts.
/// </summary>
public class ChartCoreAdapter : IChartModel
{
    private readonly Chart _chart;
    private readonly List<IChartAreaModel> _chartAreas;
    private readonly List<ISeriesModel> _series;

    /// <summary>
    /// Creates a new ChartCoreAdapter wrapping the specified Chart.
    /// </summary>
    /// <param name="chart">The WinForms Chart to adapt.</param>
    public ChartCoreAdapter(Chart chart)
    {
        _chart = chart ?? throw new ArgumentNullException(nameof(chart));
        
        // Create adapters for chart areas
        _chartAreas = [];
        foreach (ChartArea area in _chart.ChartAreas)
        {
            _chartAreas.Add(new ChartAreaCoreAdapter(area));
        }

        // Create adapters for series
        _series = [];
        foreach (Series series in _chart.Series)
        {
            _series.Add(new SeriesCoreAdapter(series));
        }
    }

    /// <summary>
    /// Gets the underlying WinForms Chart.
    /// </summary>
    public Chart Chart => _chart;

    /// <inheritdoc/>
    public float Width => _chart.Width;

    /// <inheritdoc/>
    public float Height => _chart.Height;

    /// <inheritdoc/>
    public ChartColor BackColor => ChartColor.FromArgb(
        _chart.BackColor.A,
        _chart.BackColor.R,
        _chart.BackColor.G,
        _chart.BackColor.B);

    /// <inheritdoc/>
    public ChartColor BackSecondaryColor => ChartColor.FromArgb(
        _chart.BackSecondaryColor.A,
        _chart.BackSecondaryColor.R,
        _chart.BackSecondaryColor.G,
        _chart.BackSecondaryColor.B);

    /// <inheritdoc/>
    public ChartGradientStyle BackGradientStyle => ConvertGradientStyle(_chart.BackGradientStyle);

    /// <inheritdoc/>
    public string Title
    {
        get
        {
            // Return the first title if available
            if (_chart.Titles.Count > 0)
            {
                return _chart.Titles[0].Text ?? string.Empty;
            }
            return string.Empty;
        }
    }

    /// <inheritdoc/>
    public ChartFont TitleFont
    {
        get
        {
            if (_chart.Titles.Count > 0 && _chart.Titles[0].Font != null)
            {
                var font = _chart.Titles[0].Font;
                return new ChartFont(
                    font.FontFamily.Name,
                    font.Size,
                    ConvertFontStyle(font.Style));
            }
            return new ChartFont("Arial", 14, ChartFontStyle.Bold);
        }
    }

    /// <inheritdoc/>
    public ChartColor TitleColor
    {
        get
        {
            if (_chart.Titles.Count > 0)
            {
                var color = _chart.Titles[0].ForeColor;
                return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
            }
            return ChartColor.Black;
        }
    }

    /// <inheritdoc/>
    public IReadOnlyList<IChartAreaModel> ChartAreas => _chartAreas;

    /// <inheritdoc/>
    public IReadOnlyList<ISeriesModel> Series => _series;

    /// <inheritdoc/>
    public bool ShowLegend
    {
        get
        {
            // Check if any legend is enabled
            foreach (Legend legend in _chart.Legends)
            {
                if (legend.Enabled)
                {
                    return true;
                }
            }
            return false;
        }
    }

    /// <inheritdoc/>
    public ChartLegendPosition LegendPosition
    {
        get
        {
            if (_chart.Legends.Count > 0)
            {
                var legend = _chart.Legends[0];
                return legend.Docking switch
                {
                    Docking.Left => ChartLegendPosition.Left,
                    Docking.Top => ChartLegendPosition.Top,
                    Docking.Bottom => ChartLegendPosition.Bottom,
                    _ => ChartLegendPosition.Right
                };
            }
            return ChartLegendPosition.Right;
        }
    }

    /// <summary>
    /// Refreshes the adapter to pick up changes in the underlying Chart.
    /// </summary>
    public void Refresh()
    {
        // Rebuild chart areas list
        _chartAreas.Clear();
        foreach (ChartArea area in _chart.ChartAreas)
        {
            _chartAreas.Add(new ChartAreaCoreAdapter(area));
        }

        // Rebuild series list
        _series.Clear();
        foreach (Series series in _chart.Series)
        {
            _series.Add(new SeriesCoreAdapter(series));
        }
    }

    private static ChartFontStyle ConvertFontStyle(Drawing.FontStyle style)
    {
        ChartFontStyle result = ChartFontStyle.Regular;
        if ((style & Drawing.FontStyle.Bold) != 0)
            result |= ChartFontStyle.Bold;
        if ((style & Drawing.FontStyle.Italic) != 0)
            result |= ChartFontStyle.Italic;
        if ((style & Drawing.FontStyle.Underline) != 0)
            result |= ChartFontStyle.Underline;
        if ((style & Drawing.FontStyle.Strikeout) != 0)
            result |= ChartFontStyle.Strikeout;
        return result;
    }

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
