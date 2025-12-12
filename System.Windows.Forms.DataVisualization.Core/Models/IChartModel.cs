// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Platform-agnostic interface representing a chart.
/// This interface allows the Core layout engine to work with any chart implementation.
/// </summary>
public interface IChartModel
{
    /// <summary>
    /// Gets the width of the chart in pixels.
    /// </summary>
    float Width { get; }

    /// <summary>
    /// Gets the height of the chart in pixels.
    /// </summary>
    float Height { get; }

    /// <summary>
    /// Gets the background color of the chart.
    /// </summary>
    ChartColor BackColor { get; }

    /// <summary>
    /// Gets the secondary background color for gradients.
    /// </summary>
    ChartColor BackSecondaryColor { get; }

    /// <summary>
    /// Gets the background gradient style.
    /// </summary>
    ChartGradientStyle BackGradientStyle { get; }

    /// <summary>
    /// Gets the main title of the chart.
    /// </summary>
    string Title { get; }

    /// <summary>
    /// Gets the title font.
    /// </summary>
    ChartFont TitleFont { get; }

    /// <summary>
    /// Gets the title color.
    /// </summary>
    ChartColor TitleColor { get; }

    /// <summary>
    /// Gets the collection of chart areas.
    /// </summary>
    IReadOnlyList<IChartAreaModel> ChartAreas { get; }

    /// <summary>
    /// Gets the collection of data series.
    /// </summary>
    IReadOnlyList<ISeriesModel> Series { get; }

    /// <summary>
    /// Gets whether the legend should be shown.
    /// </summary>
    bool ShowLegend { get; }

    /// <summary>
    /// Gets the legend position.
    /// </summary>
    ChartLegendPosition LegendPosition { get; }
}

/// <summary>
/// Platform-agnostic interface representing a chart area.
/// </summary>
public interface IChartAreaModel
{
    /// <summary>
    /// Gets the name of the chart area.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the background color of the chart area.
    /// </summary>
    ChartColor BackColor { get; }

    /// <summary>
    /// Gets the secondary background color for gradients.
    /// </summary>
    ChartColor BackSecondaryColor { get; }

    /// <summary>
    /// Gets the background gradient style.
    /// </summary>
    ChartGradientStyle BackGradientStyle { get; }

    /// <summary>
    /// Gets whether to show grid lines.
    /// </summary>
    bool ShowGrid { get; }

    /// <summary>
    /// Gets the grid line color.
    /// </summary>
    ChartColor GridColor { get; }

    /// <summary>
    /// Gets the primary X axis.
    /// </summary>
    IAxisModel AxisX { get; }

    /// <summary>
    /// Gets the primary Y axis.
    /// </summary>
    IAxisModel AxisY { get; }

    /// <summary>
    /// Gets the secondary X axis (top).
    /// </summary>
    IAxisModel? AxisX2 { get; }

    /// <summary>
    /// Gets the secondary Y axis (right).
    /// </summary>
    IAxisModel? AxisY2 { get; }
}

/// <summary>
/// Platform-agnostic interface representing an axis.
/// </summary>
public interface IAxisModel
{
    /// <summary>
    /// Gets whether the axis is enabled/visible.
    /// </summary>
    bool Enabled { get; }

    /// <summary>
    /// Gets the axis title.
    /// </summary>
    string Title { get; }

    /// <summary>
    /// Gets the minimum value of the axis.
    /// </summary>
    double Minimum { get; }

    /// <summary>
    /// Gets the maximum value of the axis.
    /// </summary>
    double Maximum { get; }

    /// <summary>
    /// Gets the interval between axis labels/ticks.
    /// </summary>
    double Interval { get; }

    /// <summary>
    /// Gets the axis line color.
    /// </summary>
    ChartColor LineColor { get; }

    /// <summary>
    /// Gets the axis line width.
    /// </summary>
    float LineWidth { get; }

    /// <summary>
    /// Gets whether to show major grid lines.
    /// </summary>
    bool ShowMajorGrid { get; }

    /// <summary>
    /// Gets whether to show tick marks.
    /// </summary>
    bool ShowTickMarks { get; }

    /// <summary>
    /// Gets whether to show labels.
    /// </summary>
    bool ShowLabels { get; }

    /// <summary>
    /// Gets the label font.
    /// </summary>
    ChartFont LabelFont { get; }

    /// <summary>
    /// Gets the axis label font. Alias for LabelFont for compatibility.
    /// </summary>
    ChartFont Font => LabelFont;

    /// <summary>
    /// Gets the title font.
    /// </summary>
    ChartFont? TitleFont { get; }

    /// <summary>
    /// Gets the label color.
    /// </summary>
    ChartColor LabelColor { get; }

    /// <summary>
    /// Gets custom labels for the axis. If empty, labels are auto-generated.
    /// </summary>
    IReadOnlyList<string> CustomLabels { get; }

    /// <summary>
    /// Gets whether the axis values should be reversed.
    /// </summary>
    bool IsReversed { get; }

    /// <summary>
    /// Gets whether to use logarithmic scale.
    /// </summary>
    bool IsLogarithmic { get; }

    /// <summary>
    /// Gets the logarithmic base (default 10).
    /// </summary>
    double LogarithmBase { get; }

    /// <summary>
    /// Gets whether to show margin at the edges of the axis.
    /// </summary>
    bool IsMarginVisible { get; }
}

/// <summary>
/// Legend position options.
/// </summary>
public enum ChartLegendPosition
{
    /// <summary>Legend on the right side.</summary>
    Right,

    /// <summary>Legend at the bottom.</summary>
    Bottom,

    /// <summary>Legend on the left side.</summary>
    Left,

    /// <summary>Legend at the top.</summary>
    Top
}

/// <summary>
/// Platform-agnostic interface representing a circular chart area (Radar, Polar).
/// Extends IChartAreaModel with circular-specific properties.
/// </summary>
public interface ICircularChartAreaModel : IChartAreaModel
{
    /// <summary>
    /// Gets the number of sectors (spokes) in the circular chart area.
    /// For Radar charts, this equals the number of data points.
    /// For Polar charts, this is typically based on the X axis interval.
    /// </summary>
    int SectorCount { get; }

    /// <summary>
    /// Gets the center point of the circular area in relative coordinates (0-100).
    /// </summary>
    ChartPointF Center { get; }

    /// <summary>
    /// Gets the style for drawing labels around the circular area.
    /// </summary>
    CircularAxisLabelsStyle LabelsStyle { get; }

    /// <summary>
    /// Gets the style for drawing the circular area background.
    /// </summary>
    CircularAreaDrawingStyle AreaDrawingStyle { get; }

    /// <summary>
    /// Gets whether to use polygon (true) or circle (false) for the area.
    /// </summary>
    bool UsePolygons { get; }

    /// <summary>
    /// Gets the list of circular axis definitions (one per sector).
    /// </summary>
    IReadOnlyList<ICircularAxisModel> CircularAxes { get; }

    /// <summary>
    /// Gets the chart type interface for this circular area.
    /// </summary>
    ICircularChartType? CircularChartType { get; }
}

/// <summary>
/// Represents a single axis in a circular chart area (a spoke).
/// </summary>
public interface ICircularAxisModel
{
    /// <summary>
    /// Gets the angle position of this axis in degrees (0-360).
    /// </summary>
    float Angle { get; }

    /// <summary>
    /// Gets the title/label for this axis.
    /// </summary>
    string Title { get; }

    /// <summary>
    /// Gets the color for the title text.
    /// </summary>
    ChartColor TitleColor { get; }
}
