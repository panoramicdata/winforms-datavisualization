// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;
using Xunit;

namespace System.Windows.Forms.DataVisualization.Core.Tests;

/// <summary>
/// Tests for the ChartRenderer and related rendering classes.
/// </summary>
public class ChartRendererTests
{
    private readonly ChartRenderer _renderer = new();
    private readonly ChartLayoutEngine _layoutEngine = new();

    [Fact]
    public void Render_WithSimpleChart_DoesNotThrow()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act & Assert
        var exception = Record.Exception(() => _renderer.Render(engine, chart, layout));
        Assert.Null(exception);
    }

    [Fact]
    public void Render_WithTitle_DrawsTitle()
    {
        // Arrange
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            Title = "My Chart"
        };
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act
        _renderer.Render(engine, chart, layout);

        // Assert
        Assert.Contains(engine.DrawnStrings, s => s.Contains("My Chart"));
    }

    [Fact]
    public void Render_WithLineChart_DrawsLines()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act
        _renderer.Render(engine, chart, layout);

        // Assert
        Assert.True(engine.LinesDrawn > 0, "Should have drawn at least one line");
    }

    [Fact]
    public void Render_WithBarChart_DrawsRectangles()
    {
        // Arrange
        var chart = CreateSimpleBarChart();
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act
        _renderer.Render(engine, chart, layout);

        // Assert
        Assert.True(engine.RectanglesFilled > 0, "Should have drawn at least one filled rectangle");
    }

    [Fact]
    public void Render_WithPieChart_DrawsPieSlices()
    {
        // Arrange
        var chart = CreateSimplePieChart();
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act
        _renderer.Render(engine, chart, layout);

        // Assert
        Assert.True(engine.PiesFilled > 0, "Should have drawn at least one pie slice");
    }

    [Fact]
    public void Render_WithLegend_DrawsLegend()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        chart.ShowLegend = true;
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act
        _renderer.Render(engine, chart, layout);

        // Assert
        // Legend draws series name
        Assert.Contains(engine.DrawnStrings, s => s.Contains("Series1"));
    }

    [Fact]
    public void Render_WithGridLines_DrawsGrid()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act
        _renderer.Render(engine, chart, layout);

        // Assert
        // Should draw grid lines (dotted lines)
        Assert.True(engine.LinesDrawn > 0);
    }

    [Fact]
    public void Render_WithNullEngine_ThrowsArgumentNullException()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        var layout = _layoutEngine.CalculateLayout(chart);

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _renderer.Render(null!, chart, layout));
    }

    [Fact]
    public void Render_WithNullChart_ThrowsArgumentNullException()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        var layout = _layoutEngine.CalculateLayout(chart);
        var engine = new MockRenderingEngine();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _renderer.Render(engine, null!, layout));
    }

    [Fact]
    public void Render_WithNullLayout_ThrowsArgumentNullException()
    {
        // Arrange
        var chart = CreateSimpleLineChart();
        var engine = new MockRenderingEngine();

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => _renderer.Render(engine, chart, null!));
    }

    private static TestChartModel CreateSimpleLineChart()
    {
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            Title = "Line Chart"
        };

        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1")
        {
            ChartType = "Line",
            ChartArea = "Default",
            Color = ChartColor.Blue
        };
        series.PointsList.Add(new TestDataPointModel(1, 10));
        series.PointsList.Add(new TestDataPointModel(2, 25));
        series.PointsList.Add(new TestDataPointModel(3, 15));
        series.PointsList.Add(new TestDataPointModel(4, 30));
        chart.SeriesList.Add(series);

        return chart;
    }

    private static TestChartModel CreateSimpleBarChart()
    {
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            Title = "Bar Chart"
        };

        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1")
        {
            ChartType = "Column",
            ChartArea = "Default",
            Color = ChartColor.Blue
        };
        series.PointsList.Add(new TestDataPointModel(1, 10));
        series.PointsList.Add(new TestDataPointModel(2, 25));
        series.PointsList.Add(new TestDataPointModel(3, 15));
        chart.SeriesList.Add(series);

        return chart;
    }

    private static TestChartModel CreateSimplePieChart()
    {
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            Title = "Pie Chart"
        };

        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1")
        {
            ChartType = "Pie",
            ChartArea = "Default"
        };
        series.PointsList.Add(new TestDataPointModel(0, 30) { Color = ChartColor.Red });
        series.PointsList.Add(new TestDataPointModel(0, 40) { Color = ChartColor.Blue });
        series.PointsList.Add(new TestDataPointModel(0, 30) { Color = ChartColor.Green });
        chart.SeriesList.Add(series);

        return chart;
    }
}

/// <summary>
/// Tests for SeriesRendererFactory.
/// </summary>
public class SeriesRendererFactoryTests
{
    private readonly SeriesRendererFactory _factory = new();

    [Theory]
    [InlineData("Line")]
    [InlineData("FastLine")]
    [InlineData("Spline")]
    [InlineData("StepLine")]
    public void GetRenderer_ForLineCharts_ReturnsLineRenderer(string chartType)
    {
        var renderer = _factory.GetRenderer(chartType);
        Assert.IsType<LineSeriesRenderer>(renderer);
    }

    [Theory]
    [InlineData("Bar")]
    [InlineData("Column")]
    [InlineData("StackedBar")]
    [InlineData("StackedColumn")]
    public void GetRenderer_ForBarCharts_ReturnsBarRenderer(string chartType)
    {
        var renderer = _factory.GetRenderer(chartType);
        Assert.IsType<BarSeriesRenderer>(renderer);
    }

    [Theory]
    [InlineData("Area")]
    [InlineData("SplineArea")]
    [InlineData("StackedArea")]
    public void GetRenderer_ForAreaCharts_ReturnsAreaRenderer(string chartType)
    {
        var renderer = _factory.GetRenderer(chartType);
        Assert.IsType<AreaSeriesRenderer>(renderer);
    }

    [Theory]
    [InlineData("Pie")]
    [InlineData("Doughnut")]
    public void GetRenderer_ForPieCharts_ReturnsPieRenderer(string chartType)
    {
        var renderer = _factory.GetRenderer(chartType);
        Assert.IsType<PieSeriesRenderer>(renderer);
    }

    [Theory]
    [InlineData("Point")]
    [InlineData("FastPoint")]
    [InlineData("Bubble")]
    public void GetRenderer_ForPointCharts_ReturnsPointRenderer(string chartType)
    {
        var renderer = _factory.GetRenderer(chartType);
        Assert.IsType<PointSeriesRenderer>(renderer);
    }

    [Fact]
    public void GetRenderer_ForUnknownChart_ReturnsDefaultRenderer()
    {
        var renderer = _factory.GetRenderer("UnknownChartType");
        Assert.NotNull(renderer);
        Assert.IsType<LineSeriesRenderer>(renderer);
    }

    [Fact]
    public void GetRenderer_WithNullChartType_ReturnsDefaultRenderer()
    {
        var renderer = _factory.GetRenderer(null!);
        Assert.NotNull(renderer);
    }

    [Fact]
    public void GetRenderer_WithEmptyChartType_ReturnsDefaultRenderer()
    {
        var renderer = _factory.GetRenderer("");
        Assert.NotNull(renderer);
    }

    [Fact]
    public void GetRenderer_IsCaseInsensitive()
    {
        var renderer1 = _factory.GetRenderer("line");
        var renderer2 = _factory.GetRenderer("LINE");
        var renderer3 = _factory.GetRenderer("Line");

        Assert.Equal(renderer1.GetType(), renderer2.GetType());
        Assert.Equal(renderer2.GetType(), renderer3.GetType());
    }
}

#region Mock Rendering Engine

/// <summary>
/// Mock rendering engine for testing that tracks what was drawn.
/// </summary>
internal class MockRenderingEngine : IRenderingEngine
{
    public List<string> DrawnStrings { get; } = [];
    public int LinesDrawn { get; private set; }
    public int RectanglesFilled { get; private set; }
    public int RectanglesDrawn { get; private set; }
    public int EllipsesFilled { get; private set; }
    public int PiesFilled { get; private set; }
    public int PolygonsFilled { get; private set; }

    public float Width => 400;
    public float Height => 300;
    public float DpiX => 96;
    public float DpiY => 96;

    public ChartMatrix Transform { get; set; } = ChartMatrix.Identity;
    public ChartSmoothingMode SmoothingMode { get; set; }
    public ChartTextRenderingHint TextRenderingHint { get; set; }
    public bool IsClipEmpty => false;

    public void DrawLine(ChartPen pen, ChartPointF pt1, ChartPointF pt2) => LinesDrawn++;
    public void DrawLine(ChartPen pen, float x1, float y1, float x2, float y2) => LinesDrawn++;
    public void DrawLines(ChartPen pen, ChartPointF[] points) => LinesDrawn += Math.Max(0, points.Length - 1);
    public void DrawRectangle(ChartPen pen, float x, float y, float width, float height) => RectanglesDrawn++;
    public void DrawRectangle(ChartPen pen, ChartRectangleF rect) => RectanglesDrawn++;
    public void DrawEllipse(ChartPen pen, float x, float y, float width, float height) { }
    public void DrawEllipse(ChartPen pen, ChartRectangleF rect) { }
    public void DrawPolygon(ChartPen pen, ChartPointF[] points) { }
    public void DrawPath(ChartPen pen, ChartPath path) { }
    public void DrawPie(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void DrawArc(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) { }
    public void DrawCurve(ChartPen pen, ChartPointF[] points, int offset, int numberOfSegments, float tension) => LinesDrawn++;

    public void DrawString(string s, ChartFont font, ChartBrush brush, ChartRectangleF layoutRectangle, ChartStringFormat? format)
        => DrawnStrings.Add(s);
    public void DrawString(string s, ChartFont font, ChartBrush brush, ChartPointF point, ChartStringFormat? format)
        => DrawnStrings.Add(s);

    public void FillRectangle(ChartBrush brush, float x, float y, float width, float height) => RectanglesFilled++;
    public void FillRectangle(ChartBrush brush, ChartRectangleF rect) => RectanglesFilled++;
    public void FillEllipse(ChartBrush brush, ChartRectangleF rect) => EllipsesFilled++;
    public void FillEllipse(ChartBrush brush, float x, float y, float width, float height) => EllipsesFilled++;
    public void FillPolygon(ChartBrush brush, ChartPointF[] points) => PolygonsFilled++;
    public void FillPath(ChartBrush brush, ChartPath path) { }
    public void FillPie(ChartBrush brush, float x, float y, float width, float height, float startAngle, float sweepAngle)
        => PiesFilled++;

    public ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea, ChartStringFormat? stringFormat)
        => new(text.Length * 7, 14);
    public ChartSizeF MeasureString(string text, ChartFont font)
        => new(text.Length * 7, 14);

    public object Save() => new object();
    public void Restore(object state) { }
    public void ResetClip() { }
    public void SetClip(ChartRectangleF rect) { }
    public void SetClip(ChartPath path, ChartCombineMode combineMode) { }
    public void TranslateTransform(float dx, float dy) { }
    public void RotateTransform(float angle) { }
    public void ScaleTransform(float sx, float sy) { }
    public void BeginSelection(string hRef, string title) { }
    public void EndSelection() { }

    public void Dispose() { }
}

#endregion
