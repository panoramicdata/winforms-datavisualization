// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Platform-agnostic interface representing a data series.
/// </summary>
public interface ISeriesModel
{
    /// <summary>
    /// Gets the name of the series.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets the chart type name (e.g., "Line", "Bar", "Pie").
    /// </summary>
    string ChartType { get; }

    /// <summary>
    /// Gets the name of the chart area this series belongs to.
    /// </summary>
    string ChartArea { get; }

    /// <summary>
    /// Gets the series color.
    /// </summary>
    ChartColor Color { get; }

    /// <summary>
    /// Gets the border/line color.
    /// </summary>
    ChartColor BorderColor { get; }

    /// <summary>
    /// Gets the border/line width.
    /// </summary>
    float BorderWidth { get; }

    /// <summary>
    /// Gets the border/line dash style.
    /// </summary>
    ChartDashStyle BorderDashStyle { get; }

    /// <summary>
    /// Gets the collection of data points.
    /// </summary>
    IReadOnlyList<IDataPointModel> Points { get; }

    /// <summary>
    /// Gets whether markers are shown on data points.
    /// </summary>
    bool ShowMarkers { get; }

    /// <summary>
    /// Gets the marker style.
    /// </summary>
    ChartMarkerStyle MarkerStyle { get; }

    /// <summary>
    /// Gets the marker size.
    /// </summary>
    float MarkerSize { get; }

    /// <summary>
    /// Gets the marker color. If empty, series color is used.
    /// </summary>
    ChartColor MarkerColor { get; }

    /// <summary>
    /// Gets the marker border color.
    /// </summary>
    ChartColor MarkerBorderColor { get; }

    /// <summary>
    /// Gets the marker border width.
    /// </summary>
    float MarkerBorderWidth { get; }

    /// <summary>
    /// Gets whether values are shown as labels on data points.
    /// </summary>
    bool IsValueShownAsLabel { get; }

    /// <summary>
    /// Gets the label format string.
    /// </summary>
    string LabelFormat { get; }

    /// <summary>
    /// Gets the label font.
    /// </summary>
    ChartFont LabelFont { get; }

    /// <summary>
    /// Gets the label color.
    /// </summary>
    ChartColor LabelForeColor { get; }

    /// <summary>
    /// Gets whether this series is visible.
    /// </summary>
    bool IsVisible { get; }

    /// <summary>
    /// Gets whether the series uses indexed X values.
    /// When true, X values are treated as point indices (1, 2, 3...).
    /// </summary>
    bool IsXValueIndexed { get; }

    /// <summary>
    /// Gets the X axis type (Primary or Secondary).
    /// </summary>
    ChartAxisType XAxisType { get; }

    /// <summary>
    /// Gets the Y axis type (Primary or Secondary).
    /// </summary>
    ChartAxisType YAxisType { get; }
}

/// <summary>
/// Platform-agnostic interface representing a data point.
/// </summary>
public interface IDataPointModel
{
    /// <summary>
    /// Gets the X value of the data point.
    /// </summary>
    double XValue { get; }

    /// <summary>
    /// Gets the Y values of the data point.
    /// Most chart types use only YValues[0], but some (like Stock charts) use multiple.
    /// </summary>
    double[] YValues { get; }

    /// <summary>
    /// Gets the primary Y value (shortcut for YValues[0]).
    /// </summary>
    double YValue { get; }

    /// <summary>
    /// Gets the axis label for this point.
    /// </summary>
    string AxisLabel { get; }

    /// <summary>
    /// Gets the data point label.
    /// </summary>
    string Label { get; }

    /// <summary>
    /// Gets the label angle in degrees.
    /// </summary>
    int LabelAngle { get; }

    /// <summary>
    /// Gets the data point color. If empty, series color is used.
    /// </summary>
    ChartColor Color { get; }

    /// <summary>
    /// Gets the border color.
    /// </summary>
    ChartColor BorderColor { get; }

    /// <summary>
    /// Gets the border width.
    /// </summary>
    float BorderWidth { get; }

    /// <summary>
    /// Gets the marker style for this point. If None, series marker is used.
    /// </summary>
    ChartMarkerStyle MarkerStyle { get; }

    /// <summary>
    /// Gets the marker size for this point.
    /// </summary>
    float MarkerSize { get; }

    /// <summary>
    /// Gets the marker color for this point.
    /// </summary>
    ChartColor MarkerColor { get; }

    /// <summary>
    /// Gets whether this is an empty point (no value).
    /// </summary>
    bool IsEmpty { get; }

    /// <summary>
    /// Gets whether the value is shown as a label for this point.
    /// </summary>
    bool IsValueShownAsLabel { get; }

    /// <summary>
    /// Gets the tooltip text for this point.
    /// </summary>
    string ToolTip { get; }

    /// <summary>
    /// Gets the label tooltip text.
    /// </summary>
    string LabelToolTip { get; }

    /// <summary>
    /// Gets the label foreground color.
    /// </summary>
    ChartColor LabelForeColor { get; }

    /// <summary>
    /// Gets the label background color.
    /// </summary>
    ChartColor LabelBackColor { get; }

    /// <summary>
    /// Gets the label border color.
    /// </summary>
    ChartColor LabelBorderColor { get; }

    /// <summary>
    /// Gets the label border width.
    /// </summary>
    float LabelBorderWidth { get; }

    /// <summary>
    /// Gets the label border dash style.
    /// </summary>
    ChartDashStyle LabelBorderDashStyle { get; }
}

/// <summary>
/// Marker styles for data points, matching WinForms MarkerStyle enum.
/// </summary>
public enum ChartMarkerStyle
{
    /// <summary>No marker.</summary>
    None = 0,

    /// <summary>Square marker.</summary>
    Square = 1,

    /// <summary>Circle marker.</summary>
    Circle = 2,

    /// <summary>Diamond marker.</summary>
    Diamond = 3,

    /// <summary>Triangle marker.</summary>
    Triangle = 4,

    /// <summary>Cross marker.</summary>
    Cross = 5,

    /// <summary>4-pointed star marker.</summary>
    Star4 = 6,

    /// <summary>5-pointed star marker.</summary>
    Star5 = 7,

    /// <summary>6-pointed star marker.</summary>
    Star6 = 8,

    /// <summary>10-pointed star marker.</summary>
    Star10 = 9
}

/// <summary>
/// Axis type (Primary or Secondary).
/// </summary>
public enum ChartAxisType
{
    /// <summary>Primary axis (bottom X, left Y).</summary>
    Primary = 0,

    /// <summary>Secondary axis (top X, right Y).</summary>
    Secondary = 1
}
