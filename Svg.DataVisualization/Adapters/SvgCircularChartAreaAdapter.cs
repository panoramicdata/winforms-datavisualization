// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps an SvgCircularChartArea to implement ICircularChartAreaModel.
/// </summary>
public class SvgCircularChartAreaAdapter : ICircularChartAreaModel
{
    private readonly SvgCircularChartArea _area;
    private readonly SvgChart _chart;
    private readonly List<ICircularAxisModel> _circularAxes;
    private readonly SvgAxisAdapter _axisXAdapter;
    private readonly SvgAxisAdapter _axisYAdapter;

    /// <summary>
    /// Creates a new adapter for a circular chart area.
    /// </summary>
    public SvgCircularChartAreaAdapter(SvgCircularChartArea area, SvgChart chart)
    {
        _area = area ?? throw new ArgumentNullException(nameof(area));
        _chart = chart ?? throw new ArgumentNullException(nameof(chart));
        
        _axisXAdapter = new SvgAxisAdapter(area.AxisX);
        _axisYAdapter = new SvgAxisAdapter(area.AxisY);

        // Create circular axis models from labels
        _circularAxes = [];
        float sectorAngle = _area.SectorCount > 0 ? 360f / _area.SectorCount : 360f;
        
        for (int i = 0; i < _area.SectorCount; i++)
        {
            string label = i < _area.AxisLabels.Count ? _area.AxisLabels[i] : string.Empty;
            _circularAxes.Add(new SvgCircularAxisAdapter(i * sectorAngle, label));
        }
    }

    #region IChartAreaModel Implementation

    /// <inheritdoc/>
    public string Name => _area.Name;

    /// <inheritdoc/>
    public ChartColor BackColor => _area.BackColor;

    /// <inheritdoc/>
    public ChartColor BackSecondaryColor => _area.BackSecondaryColor;

    /// <inheritdoc/>
    public ChartGradientStyle BackGradientStyle => _area.BackGradientStyle;

    /// <inheritdoc/>
    public bool ShowGrid => _area.ShowGrid;

    /// <inheritdoc/>
    public ChartColor GridColor => _area.GridColor;

    /// <inheritdoc/>
    public IAxisModel AxisX => _axisXAdapter;

    /// <inheritdoc/>
    public IAxisModel AxisY => _axisYAdapter;

    /// <inheritdoc/>
    public IAxisModel? AxisX2 => null;

    /// <inheritdoc/>
    public IAxisModel? AxisY2 => null;

    #endregion

    #region ICircularChartAreaModel Implementation

    /// <inheritdoc/>
    public int SectorCount => _area.SectorCount;

    /// <inheritdoc/>
    public ChartPointF Center => new(50, 50); // Relative coordinates (center of area)

    /// <inheritdoc/>
    public CircularAxisLabelsStyle LabelsStyle => _area.LabelsStyle switch
    {
        SvgCircularLabelsStyle.Radial => CircularAxisLabelsStyle.Radial,
        SvgCircularLabelsStyle.Circular => CircularAxisLabelsStyle.Circular,
        _ => CircularAxisLabelsStyle.Horizontal
    };

    /// <inheritdoc/>
    public CircularAreaDrawingStyle AreaDrawingStyle => _area.AreaStyle switch
    {
        SvgCircularAreaStyle.Polygon => CircularAreaDrawingStyle.Polygon,
        _ => CircularAreaDrawingStyle.Circle
    };

    /// <inheritdoc/>
    public bool UsePolygons => _area.UsePolygons || _area.AreaStyle == SvgCircularAreaStyle.Polygon;

    /// <inheritdoc/>
    public IReadOnlyList<ICircularAxisModel> CircularAxes => _circularAxes;

    /// <inheritdoc/>
    public ICircularChartType? CircularChartType => null; // Not needed for basic layout

    #endregion
}

/// <summary>
/// Simple adapter for circular axis model.
/// </summary>
internal class SvgCircularAxisAdapter : ICircularAxisModel
{
    /// <summary>
    /// Creates a new circular axis adapter.
    /// </summary>
    public SvgCircularAxisAdapter(float angle, string title)
    {
        Angle = angle;
        Title = title;
    }

    /// <inheritdoc/>
    public float Angle { get; }

    /// <inheritdoc/>
    public string Title { get; }

    /// <inheritdoc/>
    public ChartColor TitleColor => ChartColor.Black;
}
