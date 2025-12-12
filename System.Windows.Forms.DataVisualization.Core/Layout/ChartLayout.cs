// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Contains the complete calculated layout for a chart, including positions
/// for all elements (title, legend, chart areas, axes, data points).
/// This is the output of <see cref="ChartLayoutEngine.CalculateLayout"/>.
/// </summary>
public class ChartLayout
{
    /// <summary>
    /// Gets the total size of the chart.
    /// </summary>
    public ChartSizeF Size { get; }

    /// <summary>
    /// Gets or sets the bounds of the chart title.
    /// </summary>
    public ChartRectangleF TitleBounds { get; set; }

    /// <summary>
    /// Gets or sets the bounds of the legend.
    /// </summary>
    public ChartRectangleF LegendBounds { get; set; }

    /// <summary>
    /// Gets the collection of chart area layouts.
    /// </summary>
    public List<ChartAreaLayout> ChartAreaLayouts { get; } = [];

    /// <summary>
    /// Gets or sets the available area for chart content after title and legend.
    /// </summary>
    public ChartRectangleF ContentBounds { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChartLayout"/> class.
    /// </summary>
    /// <param name="size">The total size of the chart.</param>
    public ChartLayout(ChartSizeF size)
    {
        Size = size;
        ContentBounds = new ChartRectangleF(0, 0, size.Width, size.Height);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChartLayout"/> class.
    /// </summary>
    /// <param name="width">The width of the chart.</param>
    /// <param name="height">The height of the chart.</param>
    public ChartLayout(float width, float height)
        : this(new ChartSizeF(width, height))
    {
    }
}

/// <summary>
/// Contains the calculated layout for a single chart area.
/// </summary>
public class ChartAreaLayout
{
    /// <summary>
    /// Gets or sets the chart area model this layout was calculated from.
    /// </summary>
    public IChartAreaModel? Area { get; set; }

    /// <summary>
    /// Gets or sets the outer bounds of the chart area (including axes).
    /// </summary>
    public ChartRectangleF Bounds { get; set; }

    /// <summary>
    /// Gets or sets the plot area bounds (the area where data is drawn).
    /// </summary>
    public ChartRectangleF PlotAreaBounds { get; set; }

    /// <summary>
    /// Gets or sets the X axis layout.
    /// </summary>
    public AxisLayout? AxisXLayout { get; set; }

    /// <summary>
    /// Gets or sets the Y axis layout.
    /// </summary>
    public AxisLayout? AxisYLayout { get; set; }

    /// <summary>
    /// Gets or sets the secondary X axis layout (top).
    /// </summary>
    public AxisLayout? AxisX2Layout { get; set; }

    /// <summary>
    /// Gets or sets the secondary Y axis layout (right).
    /// </summary>
    public AxisLayout? AxisY2Layout { get; set; }

    /// <summary>
    /// Gets the collection of series layouts for this chart area.
    /// </summary>
    public List<SeriesLayout> SeriesLayouts { get; } = [];

    /// <summary>
    /// Gets or sets the background color of the chart area.
    /// </summary>
    public ChartColor BackColor { get; set; } = ChartColor.White;

    /// <summary>
    /// Gets or sets the secondary background color for gradients.
    /// </summary>
    public ChartColor BackSecondaryColor { get; set; } = ChartColor.White;

    /// <summary>
    /// Gets or sets the background gradient style.
    /// </summary>
    public ChartGradientStyle BackGradientStyle { get; set; } = ChartGradientStyle.None;

    /// <summary>
    /// Gets or sets whether to show grid lines.
    /// </summary>
    public bool ShowGrid { get; set; } = true;

    /// <summary>
    /// Gets or sets the grid line color.
    /// </summary>
    public ChartColor GridColor { get; set; } = ChartColor.LightGray;
}

/// <summary>
/// Contains the calculated layout for an axis.
/// </summary>
public class AxisLayout
{
    /// <summary>
    /// Gets or sets the axis model this layout was calculated from.
    /// </summary>
    public IAxisModel? Axis { get; set; }

    /// <summary>
    /// Gets or sets whether this axis is enabled/visible.
    /// </summary>
    public bool IsEnabled { get; set; } = true;

    /// <summary>
    /// Gets or sets whether this is a vertical axis (Y axis) or horizontal (X axis).
    /// </summary>
    public bool IsVertical { get; set; }

    /// <summary>
    /// Gets or sets the position of the axis line.
    /// </summary>
    public ChartRectangleF AxisLineBounds { get; set; }

    /// <summary>
    /// Gets or sets the area reserved for axis labels.
    /// </summary>
    public ChartRectangleF LabelBounds { get; set; }

    /// <summary>
    /// Gets or sets the area reserved for the axis title.
    /// </summary>
    public ChartRectangleF TitleBounds { get; set; }

    /// <summary>
    /// Gets or sets the total space consumed by this axis (line + labels + title).
    /// </summary>
    public float TotalSize { get; set; }

    /// <summary>
    /// Gets or sets the minimum data value on this axis.
    /// </summary>
    public double Minimum { get; set; }

    /// <summary>
    /// Gets or sets the maximum data value on this axis.
    /// </summary>
    public double Maximum { get; set; }

    /// <summary>
    /// Gets or sets the interval between tick marks/labels.
    /// </summary>
    public double Interval { get; set; }

    /// <summary>
    /// Gets the calculated tick mark positions (in data coordinates).
    /// </summary>
    public List<AxisTickLayout> Ticks { get; } = [];

    /// <summary>
    /// Gets the calculated label positions.
    /// </summary>
    public List<AxisLabelLayout> Labels { get; } = [];

    /// <summary>
    /// Converts a data value to a pixel position within the plot area.
    /// </summary>
    /// <param name="value">The data value.</param>
    /// <param name="plotStart">The start of the plot area in pixels.</param>
    /// <param name="plotSize">The size of the plot area in pixels.</param>
    /// <returns>The pixel position.</returns>
    public float ValueToPixel(double value, float plotStart, float plotSize)
    {
        if (Maximum == Minimum)
            return plotStart;

        double normalized = (value - Minimum) / (Maximum - Minimum);

        // For vertical axes, flip the direction (0 at bottom, max at top)
        if (IsVertical)
            normalized = 1.0 - normalized;

        return plotStart + (float)(normalized * plotSize);
    }

    /// <summary>
    /// Converts a pixel position to a data value.
    /// </summary>
    /// <param name="pixel">The pixel position.</param>
    /// <param name="plotStart">The start of the plot area in pixels.</param>
    /// <param name="plotSize">The size of the plot area in pixels.</param>
    /// <returns>The data value.</returns>
    public double PixelToValue(float pixel, float plotStart, float plotSize)
    {
        if (plotSize == 0)
            return Minimum;

        double normalized = (pixel - plotStart) / plotSize;

        // For vertical axes, flip the direction
        if (IsVertical)
            normalized = 1.0 - normalized;

        return Minimum + normalized * (Maximum - Minimum);
    }
}

/// <summary>
/// Contains the calculated position for an axis tick mark.
/// </summary>
public class AxisTickLayout
{
    /// <summary>
    /// Gets or sets the data value at this tick.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Gets or sets the pixel position of this tick.
    /// </summary>
    public float PixelPosition { get; set; }

    /// <summary>
    /// Gets or sets whether this is a major tick (longer line).
    /// </summary>
    public bool IsMajor { get; set; } = true;
}

/// <summary>
/// Contains the calculated position and text for an axis label.
/// </summary>
public class AxisLabelLayout
{
    /// <summary>
    /// Gets or sets the data value this label represents.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Gets or sets the label text.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the pixel position of this label.
    /// </summary>
    public ChartPointF Position { get; set; }

    /// <summary>
    /// Gets or sets the bounds of the label text.
    /// </summary>
    public ChartRectangleF Bounds { get; set; }
}

/// <summary>
/// Contains the calculated layout for a data series.
/// </summary>
public class SeriesLayout
{
    /// <summary>
    /// Gets or sets the series model this layout was calculated from.
    /// </summary>
    public ISeriesModel? Series { get; set; }

    /// <summary>
    /// Gets or sets the chart type for this series.
    /// </summary>
    public string ChartType { get; set; } = string.Empty;

    /// <summary>
    /// Gets the collection of data point layouts.
    /// </summary>
    public List<DataPointLayout> PointLayouts { get; } = [];

    /// <summary>
    /// Gets or sets the series color.
    /// </summary>
    public ChartColor Color { get; set; }

    /// <summary>
    /// Gets or sets the line/border width.
    /// </summary>
    public float LineWidth { get; set; } = 1f;

    /// <summary>
    /// Gets or sets the line/border dash style.
    /// </summary>
    public ChartDashStyle DashStyle { get; set; } = ChartDashStyle.Solid;
}

/// <summary>
/// Contains the calculated layout for a single data point.
/// </summary>
public class DataPointLayout
{
    /// <summary>
    /// Gets or sets the data point model this layout was calculated from.
    /// </summary>
    public IDataPointModel? Point { get; set; }

    /// <summary>
    /// Gets or sets the index of this point in the series.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Gets or sets the X data value.
    /// </summary>
    public double XValue { get; set; }

    /// <summary>
    /// Gets or sets the Y data value (primary).
    /// </summary>
    public double YValue { get; set; }

    /// <summary>
    /// Gets or sets the calculated pixel position.
    /// </summary>
    public ChartPointF Position { get; set; }

    /// <summary>
    /// Gets or sets the marker size (if markers are shown).
    /// </summary>
    public ChartSizeF MarkerSize { get; set; }

    /// <summary>
    /// Gets or sets the marker style.
    /// </summary>
    public ChartMarkerStyle MarkerStyle { get; set; } = ChartMarkerStyle.None;

    /// <summary>
    /// Gets or sets the color for this point (may override series color).
    /// </summary>
    public ChartColor Color { get; set; }

    /// <summary>
    /// Gets or sets the label text for this point.
    /// </summary>
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the label position.
    /// </summary>
    public ChartPointF LabelPosition { get; set; }

    /// <summary>
    /// Gets or sets whether this point is empty/missing.
    /// </summary>
    public bool IsEmpty { get; set; }

    /// <summary>
    /// Gets or sets additional bounds for bar/column charts (the rectangle of the bar).
    /// </summary>
    public ChartRectangleF BarBounds { get; set; }
}

/// <summary>
/// Contains the calculated layout for a legend.
/// </summary>
public class LegendLayout
{
    /// <summary>
    /// Gets or sets the bounds of the legend.
    /// </summary>
    public ChartRectangleF Bounds { get; set; }

    /// <summary>
    /// Gets or sets the position of the legend.
    /// </summary>
    public ChartLegendPosition Position { get; set; } = ChartLegendPosition.Right;

    /// <summary>
    /// Gets the collection of legend item layouts.
    /// </summary>
    public List<LegendItemLayout> Items { get; } = [];
}

/// <summary>
/// Contains the calculated layout for a legend item.
/// </summary>
public class LegendItemLayout
{
    /// <summary>
    /// Gets or sets the series this legend item represents.
    /// </summary>
    public ISeriesModel? Series { get; set; }

    /// <summary>
    /// Gets or sets the text of the legend item.
    /// </summary>
    public string Text { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the color of the legend item symbol.
    /// </summary>
    public ChartColor Color { get; set; }

    /// <summary>
    /// Gets or sets the bounds of the entire legend item.
    /// </summary>
    public ChartRectangleF Bounds { get; set; }

    /// <summary>
    /// Gets or sets the bounds of the symbol (color box/line).
    /// </summary>
    public ChartRectangleF SymbolBounds { get; set; }

    /// <summary>
    /// Gets or sets the position of the text.
    /// </summary>
    public ChartPointF TextPosition { get; set; }
}
