// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Represents the type of values used in a chart.
/// </summary>
public enum ChartValueType
{
    /// <summary>
    /// Automatically determined value type.
    /// </summary>
    Auto,

    /// <summary>
    /// Double-precision floating point value.
    /// </summary>
    Double,

    /// <summary>
    /// Single-precision floating point value.
    /// </summary>
    Single,

    /// <summary>
    /// 32-bit signed integer value.
    /// </summary>
    Int32,

    /// <summary>
    /// 64-bit signed integer value.
    /// </summary>
    Int64,

    /// <summary>
    /// 32-bit unsigned integer value.
    /// </summary>
    UInt32,

    /// <summary>
    /// 64-bit unsigned integer value.
    /// </summary>
    UInt64,

    /// <summary>
    /// String value.
    /// </summary>
    String,

    /// <summary>
    /// DateTime value.
    /// </summary>
    DateTime,

    /// <summary>
    /// Date value (without time component).
    /// </summary>
    Date,

    /// <summary>
    /// Time value (without date component).
    /// </summary>
    Time,

    /// <summary>
    /// DateTimeOffset value.
    /// </summary>
    DateTimeOffset
}

/// <summary>
/// Specifies the marker style for data points.
/// </summary>
public enum CoreMarkerStyle
{
    /// <summary>
    /// No marker is displayed.
    /// </summary>
    None,

    /// <summary>
    /// A square marker is displayed.
    /// </summary>
    Square,

    /// <summary>
    /// A circular marker is displayed.
    /// </summary>
    Circle,

    /// <summary>
    /// A diamond-shaped marker is displayed.
    /// </summary>
    Diamond,

    /// <summary>
    /// A triangular marker is displayed.
    /// </summary>
    Triangle,

    /// <summary>
    /// A cross-shaped marker is displayed.
    /// </summary>
    Cross,

    /// <summary>
    /// A 4-point star marker is displayed.
    /// </summary>
    Star4,

    /// <summary>
    /// A 5-point star marker is displayed.
    /// </summary>
    Star5,

    /// <summary>
    /// A 6-point star marker is displayed.
    /// </summary>
    Star6,

    /// <summary>
    /// A 10-point star marker is displayed.
    /// </summary>
    Star10
}

/// <summary>
/// Platform-agnostic interface representing a data point in a chart series.
/// </summary>
public interface IDataPoint
{
    /// <summary>
    /// Gets or sets the X value of the data point.
    /// </summary>
    double XValue { get; set; }

    /// <summary>
    /// Gets or sets the Y values of the data point.
    /// </summary>
    double[] YValues { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this data point represents an empty point.
    /// </summary>
    bool IsEmpty { get; set; }

    /// <summary>
    /// Gets or sets the text of the data point label.
    /// </summary>
    string Label { get; set; }

    /// <summary>
    /// Gets or sets the X axis label text for the data point.
    /// </summary>
    string AxisLabel { get; set; }

    /// <summary>
    /// Gets or sets the tooltip text for the data point.
    /// </summary>
    string ToolTip { get; set; }

    /// <summary>
    /// Gets or sets the legend text for the data point.
    /// </summary>
    string LegendText { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this point is visible in the legend.
    /// </summary>
    bool IsVisibleInLegend { get; set; }

    /// <summary>
    /// Gets or sets the color of the data point.
    /// </summary>
    ChartColor Color { get; set; }

    /// <summary>
    /// Gets or sets the border color of the data point.
    /// </summary>
    ChartColor BorderColor { get; set; }

    /// <summary>
    /// Gets or sets the border width of the data point.
    /// </summary>
    int BorderWidth { get; set; }

    /// <summary>
    /// Gets or sets the marker style of the data point.
    /// </summary>
    CoreMarkerStyle MarkerStyle { get; set; }

    /// <summary>
    /// Gets or sets the marker size of the data point.
    /// </summary>
    int MarkerSize { get; set; }

    /// <summary>
    /// Gets or sets the marker color of the data point.
    /// </summary>
    ChartColor MarkerColor { get; set; }

    /// <summary>
    /// Gets or sets the marker border color of the data point.
    /// </summary>
    ChartColor MarkerBorderColor { get; set; }

    /// <summary>
    /// Gets or sets the marker border width of the data point.
    /// </summary>
    int MarkerBorderWidth { get; set; }

    /// <summary>
    /// Gets a value by its name (X, Y, Y1, Y2, etc.).
    /// </summary>
    /// <param name="valueName">The name of the value to get.</param>
    /// <returns>The value.</returns>
    double GetValueByName(string valueName);

    /// <summary>
    /// Sets the X and Y values of the data point.
    /// </summary>
    /// <param name="xValue">The X value.</param>
    /// <param name="yValue">The Y values.</param>
    void SetValueXY(object xValue, params object[] yValue);

    /// <summary>
    /// Sets the Y values of the data point.
    /// </summary>
    /// <param name="yValue">The Y values.</param>
    void SetValueY(params object[] yValue);

    /// <summary>
    /// Checks if a custom property is set.
    /// </summary>
    /// <param name="name">The name of the custom property.</param>
    /// <returns>True if the property is set.</returns>
    bool IsCustomPropertySet(string name);

    /// <summary>
    /// Gets a custom property value.
    /// </summary>
    /// <param name="name">The name of the custom property.</param>
    /// <returns>The property value.</returns>
    string GetCustomProperty(string name);

    /// <summary>
    /// Sets a custom property value.
    /// </summary>
    /// <param name="name">The name of the custom property.</param>
    /// <param name="value">The property value.</param>
    void SetCustomProperty(string name, string value);

    /// <summary>
    /// Deletes a custom property.
    /// </summary>
    /// <param name="name">The name of the custom property to delete.</param>
    void DeleteCustomProperty(string name);
}

/// <summary>
/// Platform-agnostic interface representing a data series in a chart.
/// </summary>
public interface IDataSeries
{
    /// <summary>
    /// Gets or sets the name of the series.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets the collection of data points in the series.
    /// </summary>
    IList<IDataPoint> Points { get; }

    /// <summary>
    /// Gets or sets the chart type name for this series.
    /// </summary>
    string ChartTypeName { get; set; }

    /// <summary>
    /// Gets or sets the name of the chart area this series belongs to.
    /// </summary>
    string ChartArea { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the series is enabled.
    /// </summary>
    bool Enabled { get; set; }

    /// <summary>
    /// Gets or sets the X value type for this series.
    /// </summary>
    ChartValueType XValueType { get; set; }

    /// <summary>
    /// Gets or sets the Y value type for this series.
    /// </summary>
    ChartValueType YValueType { get; set; }

    /// <summary>
    /// Gets or sets the number of Y values per data point.
    /// </summary>
    int YValuesPerPoint { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether X values are indexed.
    /// </summary>
    bool IsXValueIndexed { get; set; }

    /// <summary>
    /// Gets or sets the color of the series.
    /// </summary>
    ChartColor Color { get; set; }

    /// <summary>
    /// Gets or sets the border color of the series.
    /// </summary>
    ChartColor BorderColor { get; set; }

    /// <summary>
    /// Gets or sets the border width of the series.
    /// </summary>
    int BorderWidth { get; set; }

    /// <summary>
    /// Gets or sets the legend name for this series.
    /// </summary>
    string Legend { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the series is visible in the legend.
    /// </summary>
    bool IsVisibleInLegend { get; set; }

    /// <summary>
    /// Gets or sets the legend text for this series.
    /// </summary>
    string LegendText { get; set; }

    /// <summary>
    /// Gets the total Y value for the series.
    /// </summary>
    /// <returns>The total Y value.</returns>
    double GetTotalYValue();

    /// <summary>
    /// Gets the total Y value for the specified Y value index.
    /// </summary>
    /// <param name="yValueIndex">The Y value index.</param>
    /// <returns>The total Y value.</returns>
    double GetTotalYValue(int yValueIndex);
}

/// <summary>
/// Platform-agnostic interface representing a chart area.
/// </summary>
public interface IChartArea
{
    /// <summary>
    /// Gets or sets the name of the chart area.
    /// </summary>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the chart area is visible.
    /// </summary>
    bool Visible { get; set; }

    /// <summary>
    /// Gets or sets the background color of the chart area.
    /// </summary>
    ChartColor BackColor { get; set; }

    /// <summary>
    /// Gets or sets the border color of the chart area.
    /// </summary>
    ChartColor BorderColor { get; set; }

    /// <summary>
    /// Gets or sets the border width of the chart area.
    /// </summary>
    int BorderWidth { get; set; }
}
