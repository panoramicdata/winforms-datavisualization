// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Adapters;
using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// A lightweight SVG chart generator that creates charts without WinForms dependencies.
/// This class provides a simplified API for creating basic charts with SVG output.
/// </summary>
public class SvgChart : IDisposable
{
    private readonly List<SvgChartSeries> _series;
    private readonly List<SvgChartArea> _chartAreas;
    private readonly ChartLayoutEngine _layoutEngine;
    private readonly ChartRenderer _renderer;
    private bool _disposed;

    /// <summary>
    /// Gets or sets the width of the chart in pixels.
    /// </summary>
    public float Width { get; set; } = 600;

    /// <summary>
    /// Gets or sets the height of the chart in pixels.
    /// </summary>
    public float Height { get; set; } = 400;

    /// <summary>
    /// Gets or sets the background color of the chart.
    /// Default matches WinForms cream/tan gradient base color.
    /// </summary>
    public ChartColor BackColor { get; set; } = ChartColor.FromArgb(243, 223, 193);

    /// <summary>
    /// Gets or sets the secondary background color for gradients.
    /// </summary>
    public ChartColor BackSecondaryColor { get; set; } = ChartColor.White;

    /// <summary>
    /// Gets or sets the background gradient style.
    /// </summary>
    public ChartGradientStyle BackGradientStyle { get; set; } = ChartGradientStyle.TopBottom;

    /// <summary>
    /// Gets or sets the chart title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the title font.
    /// </summary>
    public ChartFont TitleFont { get; set; } = new ChartFont("Arial", 14, ChartFontStyle.Bold);

    /// <summary>
    /// Gets or sets the title color.
    /// </summary>
    public ChartColor TitleColor { get; set; } = ChartColor.Black;

    /// <summary>
    /// Gets the collection of data series.
    /// </summary>
    public IList<SvgChartSeries> Series => _series;

    /// <summary>
    /// Gets the collection of chart areas.
    /// </summary>
    public IList<SvgChartArea> ChartAreas => _chartAreas;

    /// <summary>
    /// Gets or sets whether to show the legend.
    /// </summary>
    public bool ShowLegend { get; set; } = true;

    /// <summary>
    /// Gets or sets the legend position.
    /// </summary>
    public SvgLegendPosition LegendPosition { get; set; } = SvgLegendPosition.Right;

    /// <summary>
    /// Creates a new SvgChart instance.
    /// </summary>
    public SvgChart()
        : this(SvgTextMeasurer.Instance)
    {
    }

    /// <summary>
    /// Creates a new SvgChart instance with a custom text measurer.
    /// </summary>
    /// <param name="textMeasurer">The text measurer to use for layout calculations.</param>
    public SvgChart(ITextMeasurer textMeasurer)
    {
        _series = [];
        _chartAreas = [new SvgChartArea("Default")];
        _layoutEngine = new ChartLayoutEngine(textMeasurer ?? SvgTextMeasurer.Instance);
        _renderer = new ChartRenderer();
    }

    /// <summary>
    /// Renders the chart to SVG format.
    /// </summary>
    /// <returns>The SVG content as a string.</returns>
    public string RenderToSvg()
    {
        using var engine = new SvgRenderingEngine(Width, Height);
        Render(engine);
        return engine.GetSvgContent();
    }

    /// <summary>
    /// Saves the chart to an SVG file.
    /// </summary>
    /// <param name="path">The file path to save to.</param>
    public void SaveToFile(string path)
    {
        var svg = RenderToSvg();
        File.WriteAllText(path, svg);
    }

    /// <summary>
    /// Gets the chart as a stream.
    /// </summary>
    /// <returns>A stream containing the SVG content.</returns>
    public Stream RenderToStream()
    {
        using var engine = new SvgRenderingEngine(Width, Height);
        Render(engine);
        return engine.ToStream();
    }

    /// <summary>
    /// Renders the chart using the specified rendering engine.
    /// Uses the Core ChartLayoutEngine and ChartRenderer for consistent output.
    /// </summary>
    /// <param name="engine">The rendering engine to use.</param>
    private void Render(IRenderingEngine engine)
    {
        // Create adapter to wrap this SvgChart as IChartModel
        var adapter = new SvgChartAdapter(this);
        
        // Calculate layout using the Core layout engine
        var layout = _layoutEngine.CalculateLayout(adapter);
        
        // Render using the Core renderer
        _renderer.Render(engine, adapter, layout);
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        if (!_disposed)
        {
            _series.Clear();
            _chartAreas.Clear();
            _disposed = true;
        }
    }
}

/// <summary>
/// Represents a data series in an SvgChart.
/// </summary>
public class SvgChartSeries
{
    /// <summary>
    /// Gets or sets the name of the series.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the chart type for this series.
    /// </summary>
    public SvgChartType ChartType { get; set; } = SvgChartType.Line;

    /// <summary>
    /// Gets or sets the color of the series.
    /// </summary>
    public ChartColor Color { get; set; } = ChartColor.FromArgb(65, 140, 240);

    /// <summary>
    /// Gets or sets the line width for line-based charts.
    /// </summary>
    public float LineWidth { get; set; } = 2f;

    /// <summary>
    /// Gets or sets whether to show markers on data points.
    /// </summary>
    public bool ShowMarkers { get; set; } = false;

    /// <summary>
    /// Gets or sets the marker size.
    /// </summary>
    public float MarkerSize { get; set; } = 6f;

    /// <summary>
    /// Gets or sets the marker style.
    /// </summary>
    public SvgMarkerStyle MarkerStyle { get; set; } = SvgMarkerStyle.Circle;

    /// <summary>
    /// Gets or sets whether values are shown as labels on data points.
    /// </summary>
    public bool IsValueShownAsLabel { get; set; } = false;

    /// <summary>
    /// Gets or sets the label style (position relative to data point).
    /// </summary>
    public string LabelStyle { get; set; } = "Auto";

    /// <summary>
    /// Gets the collection of data points.
    /// </summary>
    public List<SvgDataPoint> Points { get; } = [];

    /// <summary>
    /// Creates a new SvgChartSeries with the specified name.
    /// </summary>
    public SvgChartSeries(string name = "")
    {
        Name = name;
    }
}

/// <summary>
/// Represents a data point in an SvgChartSeries.
/// </summary>
public struct SvgDataPoint
{
    /// <summary>
    /// Gets or sets the X value.
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// Gets or sets the Y value.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Gets or sets the label for this point.
    /// </summary>
    public string Label { get; set; }

    /// <summary>
    /// Creates a new data point.
    /// </summary>
    public SvgDataPoint(double x, double y, string label = "")
    {
        X = x;
        Y = y;
        Label = label;
    }
}

/// <summary>
/// Represents a chart area in an SvgChart.
/// </summary>
public class SvgChartArea
{
    /// <summary>
    /// Gets or sets the name of the chart area.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the background color.
    /// Default matches WinForms OldLace color.
    /// </summary>
    public ChartColor BackColor { get; set; } = ChartColor.FromArgb(253, 245, 230); // OldLace

    /// <summary>
    /// Gets or sets the secondary background color for gradients.
    /// </summary>
    public ChartColor BackSecondaryColor { get; set; } = ChartColor.White;

    /// <summary>
    /// Gets or sets the background gradient style.
    /// </summary>
    public ChartGradientStyle BackGradientStyle { get; set; } = ChartGradientStyle.TopBottom;

    /// <summary>
    /// Gets or sets the axis color.
    /// Default matches WinForms semi-transparent axis.
    /// </summary>
    public ChartColor AxisColor { get; set; } = ChartColor.FromArgb(64, 64, 64, 64);

    /// <summary>
    /// Gets or sets the grid color.
    /// Default matches WinForms semi-transparent grid.
    /// </summary>
    public ChartColor GridColor { get; set; } = ChartColor.FromArgb(64, 64, 64, 64);

    /// <summary>
    /// Gets or sets whether to show grid lines.
    /// </summary>
    public bool ShowGrid { get; set; } = true;

    /// <summary>
    /// Gets the X axis configuration.
    /// </summary>
    public SvgAxis AxisX { get; } = new SvgAxis();

    /// <summary>
    /// Gets the Y axis configuration.
    /// </summary>
    public SvgAxis AxisY { get; } = new SvgAxis();

    /// <summary>
    /// Creates a new chart area with the specified name.
    /// </summary>
    public SvgChartArea(string name)
    {
        Name = name;
    }
}

/// <summary>
/// Represents axis configuration for an SvgChart.
/// </summary>
public class SvgAxis
{
    /// <summary>
    /// Gets or sets whether the axis margin is visible.
    /// When true, adds spacing at the edges of the axis.
    /// </summary>
    public bool IsMarginVisible { get; set; } = false;

    /// <summary>
    /// Gets or sets whether to show the major grid lines.
    /// </summary>
    public bool ShowMajorGrid { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to show tick marks.
    /// </summary>
    public bool ShowTickMarks { get; set; } = true;

    /// <summary>
    /// Gets or sets whether to show labels.
    /// </summary>
    public bool ShowLabels { get; set; } = true;
}

/// <summary>
/// Represents a circular chart area for Radar and Polar charts.
/// </summary>
public class SvgCircularChartArea : SvgChartArea
{
    /// <summary>
    /// Gets or sets the number of sectors (spokes) in the circular chart.
    /// For Radar charts, this is typically the number of data points.
    /// For Polar charts, this defaults to 12 (30-degree increments).
    /// </summary>
    public int SectorCount { get; set; } = 12;

    /// <summary>
    /// Gets or sets whether to use polygon (true) or circle (false) for grid lines.
    /// </summary>
    public bool UsePolygons { get; set; } = false;

    /// <summary>
    /// Gets or sets the labels style for circular axes.
    /// </summary>
    public SvgCircularLabelsStyle LabelsStyle { get; set; } = SvgCircularLabelsStyle.Horizontal;

    /// <summary>
    /// Gets or sets the area drawing style (circle or polygon).
    /// </summary>
    public SvgCircularAreaStyle AreaStyle { get; set; } = SvgCircularAreaStyle.Circle;

    /// <summary>
    /// Gets the list of axis labels (one per sector).
    /// </summary>
    public List<string> AxisLabels { get; } = [];

    /// <summary>
    /// Creates a new circular chart area with the specified name.
    /// </summary>
    public SvgCircularChartArea(string name) : base(name)
    {
    }

    /// <summary>
    /// Creates a circular chart area with auto-configured sectors based on data.
    /// </summary>
    /// <param name="name">The area name.</param>
    /// <param name="labels">The labels for each sector.</param>
    public SvgCircularChartArea(string name, IEnumerable<string> labels) : base(name)
    {
        AxisLabels.AddRange(labels);
        SectorCount = AxisLabels.Count;
    }
}

/// <summary>
/// Labels style for circular chart axes.
/// </summary>
public enum SvgCircularLabelsStyle
{
    /// <summary>Labels are horizontal.</summary>
    Horizontal,

    /// <summary>Labels radiate outward from center.</summary>
    Radial,

    /// <summary>Labels follow the circular path.</summary>
    Circular
}

/// <summary>
/// Area drawing style for circular charts.
/// </summary>
public enum SvgCircularAreaStyle
{
    /// <summary>Draw as circle.</summary>
    Circle,

    /// <summary>Draw as polygon matching sector count.</summary>
    Polygon
}

/// <summary>
/// Chart types supported by SvgChart.
/// These mirror the WinForms SeriesChartType enum for easy migration.
/// </summary>
public enum SvgChartType
{
    /// <summary>Line chart.</summary>
    Line,

    /// <summary>Spline (curved line) chart.</summary>
    Spline,

    /// <summary>Step line chart.</summary>
    StepLine,

    /// <summary>Area chart.</summary>
    Area,

    /// <summary>Spline area chart.</summary>
    SplineArea,

    /// <summary>Horizontal bar chart.</summary>
    Bar,

    /// <summary>Vertical column chart.</summary>
    Column,

    /// <summary>Point/Scatter chart (matches WinForms SeriesChartType.Point).</summary>
    Point,

    /// <summary>Scatter chart (alias for Point chart).</summary>
    Scatter = Point,

    /// <summary>Pie chart.</summary>
    Pie,

    /// <summary>Radar chart (circular with data at sector angles).</summary>
    Radar,

    /// <summary>Polar chart (circular with X values as angles).</summary>
    Polar
}

/// <summary>
/// Legend positions for SvgChart.
/// </summary>
public enum SvgLegendPosition
{
    /// <summary>Legend on the right side.</summary>
    Right,

    /// <summary>Legend at the bottom.</summary>
    Bottom
}

/// <summary>
/// Marker styles for data points, matching WinForms MarkerStyle enum.
/// </summary>
public enum SvgMarkerStyle
{
    /// <summary>No marker.</summary>
    None,

    /// <summary>Square marker.</summary>
    Square,

    /// <summary>Circle marker.</summary>
    Circle,

    /// <summary>Diamond marker.</summary>
    Diamond,

    /// <summary>Triangle marker.</summary>
    Triangle,

    /// <summary>Cross marker.</summary>
    Cross,

    /// <summary>4-pointed star marker.</summary>
    Star4,

    /// <summary>5-pointed star marker.</summary>
    Star5,

    /// <summary>6-pointed star marker.</summary>
    Star6,

    /// <summary>10-pointed star marker.</summary>
    Star10
}
