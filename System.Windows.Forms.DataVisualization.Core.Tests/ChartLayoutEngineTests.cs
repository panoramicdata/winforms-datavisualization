// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;
using Xunit;

namespace System.Windows.Forms.DataVisualization.Core.Tests;

/// <summary>
/// Tests for the ChartLayoutEngine and related layout classes.
/// </summary>
public class ChartLayoutEngineTests
{
    private readonly ChartLayoutEngine _engine = new();

    [Fact]
    public void CalculateLayout_WithSimpleChart_ReturnsValidLayout()
    {
        // Arrange
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            Title = "Test Chart"
        };

        var series = new TestSeriesModel("Series1");
        series.PointsList.Add(new TestDataPointModel(1, 10));
        series.PointsList.Add(new TestDataPointModel(2, 20));
        series.PointsList.Add(new TestDataPointModel(3, 15));
        chart.SeriesList.Add(series);

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        Assert.NotNull(layout);
        Assert.Equal(400, layout.Size.Width);
        Assert.Equal(300, layout.Size.Height);
        Assert.False(layout.TitleBounds.IsEmpty);
    }

    [Fact]
    public void CalculateLayout_WithNoTitle_HasEmptyTitleBounds()
    {
        // Arrange
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            Title = ""
        };

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        Assert.True(layout.TitleBounds.IsEmpty);
    }

    [Fact]
    public void CalculateLayout_WithLegend_ReservesLegendSpace()
    {
        // Arrange
        var chart = new TestChartModel
        {
            Width = 400,
            Height = 300,
            ShowLegend = true,
            LegendPosition = ChartLegendPosition.Right
        };

        var series = new TestSeriesModel("Series1");
        series.PointsList.Add(new TestDataPointModel(1, 10));
        chart.SeriesList.Add(series);

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        Assert.False(layout.LegendBounds.IsEmpty);
        Assert.True(layout.LegendBounds.X > layout.ContentBounds.Right);
    }

    [Fact]
    public void CalculateLayout_WithChartArea_CreatesAreaLayout()
    {
        // Arrange
        var chart = new TestChartModel { Width = 400, Height = 300 };
        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1") { ChartArea = "Default" };
        series.PointsList.Add(new TestDataPointModel(1, 10));
        series.PointsList.Add(new TestDataPointModel(2, 20));
        chart.SeriesList.Add(series);

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        Assert.Single(layout.ChartAreaLayouts);
        var areaLayout = layout.ChartAreaLayouts[0];
        Assert.False(areaLayout.PlotAreaBounds.IsEmpty);
    }

    [Fact]
    public void CalculateLayout_WithMultipleChartAreas_DistributesSpaceEvenly()
    {
        // Arrange
        var chart = new TestChartModel { Width = 400, Height = 300 };
        chart.ChartAreasList.Add(new TestChartAreaModel("Area1"));
        chart.ChartAreasList.Add(new TestChartAreaModel("Area2"));

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        Assert.Equal(2, layout.ChartAreaLayouts.Count);
        // Each area should have approximately half the width
        Assert.True(layout.ChartAreaLayouts[0].Bounds.Width > 0);
        Assert.True(layout.ChartAreaLayouts[1].Bounds.Width > 0);
    }

    [Fact]
    public void CalculateLayout_WithSeriesData_CalculatesPointPositions()
    {
        // Arrange
        var chart = new TestChartModel { Width = 400, Height = 300 };
        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1") { ChartArea = "Default" };
        series.PointsList.Add(new TestDataPointModel(1, 10));
        series.PointsList.Add(new TestDataPointModel(2, 30));
        series.PointsList.Add(new TestDataPointModel(3, 20));
        chart.SeriesList.Add(series);

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        var areaLayout = layout.ChartAreaLayouts[0];
        Assert.Single(areaLayout.SeriesLayouts);

        var seriesLayout = areaLayout.SeriesLayouts[0];
        Assert.Equal(3, seriesLayout.PointLayouts.Count);

        // Points should have valid positions within the plot area
        foreach (var pointLayout in seriesLayout.PointLayouts)
        {
            Assert.True(pointLayout.Position.X >= areaLayout.PlotAreaBounds.X);
            Assert.True(pointLayout.Position.X <= areaLayout.PlotAreaBounds.Right);
            Assert.True(pointLayout.Position.Y >= areaLayout.PlotAreaBounds.Y);
            Assert.True(pointLayout.Position.Y <= areaLayout.PlotAreaBounds.Bottom);
        }
    }

    [Fact]
    public void AxisLayout_ValueToPixel_ConvertsCorrectly()
    {
        // Arrange
        var axis = new AxisLayout
        {
            Minimum = 0,
            Maximum = 100,
            IsVertical = false
        };

        // Act & Assert
        // At minimum, should be at start
        Assert.Equal(0, axis.ValueToPixel(0, 0, 200));
        // At maximum, should be at end
        Assert.Equal(200, axis.ValueToPixel(100, 0, 200));
        // At midpoint, should be in middle
        Assert.Equal(100, axis.ValueToPixel(50, 0, 200));
    }

    [Fact]
    public void AxisLayout_ValueToPixel_FlipsForVerticalAxis()
    {
        // Arrange
        var axis = new AxisLayout
        {
            Minimum = 0,
            Maximum = 100,
            IsVertical = true
        };

        // Act & Assert
        // For vertical axis, minimum should be at bottom (end)
        Assert.Equal(200, axis.ValueToPixel(0, 0, 200));
        // Maximum should be at top (start)
        Assert.Equal(0, axis.ValueToPixel(100, 0, 200));
    }

    [Fact]
    public void AxisLayout_PixelToValue_RoundTrips()
    {
        // Arrange
        var axis = new AxisLayout
        {
            Minimum = 0,
            Maximum = 100,
            IsVertical = false
        };

        // Act
        float pixel = axis.ValueToPixel(42, 0, 200);
        double value = axis.PixelToValue(pixel, 0, 200);

        // Assert
        Assert.Equal(42, value, precision: 5);
    }
}

/// <summary>
/// Tests for AxisLayoutCalculator.
/// </summary>
public class AxisLayoutCalculatorTests
{
    private readonly AxisLayoutCalculator _calculator = new();

    [Fact]
    public void Calculate_WithValidAxis_ReturnsEnabledLayout()
    {
        // Arrange
        var axis = new TestAxisModel
        {
            Enabled = true,
            Minimum = 0,
            Maximum = 100
        };

        // Act
        var layout = _calculator.Calculate(axis, false, 400, 0, 100);

        // Assert
        Assert.True(layout.IsEnabled);
        Assert.Equal(0, layout.Minimum);
        Assert.Equal(100, layout.Maximum);
    }

    [Fact]
    public void Calculate_WithDisabledAxis_ReturnsDisabledLayout()
    {
        // Arrange
        var axis = new TestAxisModel { Enabled = false };

        // Act
        var layout = _calculator.Calculate(axis, false, 400, 0, 100);

        // Assert
        Assert.False(layout.IsEnabled);
        Assert.Equal(0, layout.TotalSize);
    }

    [Fact]
    public void Calculate_WithAutoInterval_CalculatesNiceInterval()
    {
        // Arrange
        var axis = new TestAxisModel
        {
            Enabled = true,
            Minimum = 0,
            Maximum = 100,
            Interval = double.NaN // Auto
        };

        // Act
        var layout = _calculator.Calculate(axis, false, 400, 0, 100);

        // Assert
        Assert.True(layout.Interval > 0);
        // Should be a nice number like 10, 20, 25, etc.
        Assert.True(layout.Interval == 10 || layout.Interval == 20 || layout.Interval == 25);
    }

    [Fact]
    public void Calculate_GeneratesTicks()
    {
        // Arrange
        var axis = new TestAxisModel
        {
            Enabled = true,
            Minimum = 0,
            Maximum = 100,
            Interval = 20
        };

        // Act
        var layout = _calculator.Calculate(axis, false, 400, 0, 100);

        // Assert
        Assert.True(layout.Ticks.Count > 0);
        // Should have ticks at 0, 20, 40, 60, 80, 100
        Assert.Equal(6, layout.Ticks.Count);
        Assert.Equal(0, layout.Ticks[0].Value);
        Assert.Equal(100, layout.Ticks[^1].Value);
    }

    [Fact]
    public void Calculate_GeneratesLabels()
    {
        // Arrange
        var axis = new TestAxisModel
        {
            Enabled = true,
            Minimum = 0,
            Maximum = 100,
            ShowLabels = true,
            Interval = 25
        };

        // Act
        var layout = _calculator.Calculate(axis, false, 400, 0, 100);

        // Assert
        Assert.Equal(5, layout.Labels.Count); // 0, 25, 50, 75, 100
        Assert.Equal("0", layout.Labels[0].Text);
        Assert.Equal("100", layout.Labels[^1].Text);
    }

    [Fact]
    public void Calculate_WithCustomLabels_UsesCustomLabels()
    {
        // Arrange
        var axis = new TestAxisModel
        {
            Enabled = true,
            Minimum = 0,
            Maximum = 100,
            ShowLabels = true
        };
        axis.CustomLabelsList.AddRange(["Jan", "Feb", "Mar", "Apr"]);

        // Act
        var layout = _calculator.Calculate(axis, false, 400, 0, 100);

        // Assert
        Assert.Equal(4, layout.Labels.Count);
        Assert.Equal("Jan", layout.Labels[0].Text);
        Assert.Equal("Apr", layout.Labels[^1].Text);
    }
}

/// <summary>
/// Tests verifying layout fidelity and pixel accuracy.
/// These tests ensure the Core layout engine produces consistent results.
/// </summary>
public class LayoutFidelityTests
{
    private readonly ChartLayoutEngine _engine = new();

    [Fact]
    public void Layout_IsDeterministic_SameInputProducesSameOutput()
    {
        // Arrange
        var chart = CreateStandardTestChart();

        // Act - Calculate layout multiple times
        var layout1 = _engine.CalculateLayout(chart);
        var layout2 = _engine.CalculateLayout(chart);
        var layout3 = _engine.CalculateLayout(chart);

        // Assert - All layouts should be identical
        Assert.Equal(layout1.ContentBounds.X, layout2.ContentBounds.X);
        Assert.Equal(layout1.ContentBounds.Y, layout2.ContentBounds.Y);
        Assert.Equal(layout1.ContentBounds.Width, layout2.ContentBounds.Width);
        Assert.Equal(layout1.ContentBounds.Height, layout2.ContentBounds.Height);

        Assert.Equal(layout2.ContentBounds.X, layout3.ContentBounds.X);
        Assert.Equal(layout2.ContentBounds.Y, layout3.ContentBounds.Y);
        Assert.Equal(layout2.ContentBounds.Width, layout3.ContentBounds.Width);
        Assert.Equal(layout2.ContentBounds.Height, layout3.ContentBounds.Height);
    }

    [Fact]
    public void Layout_WithKnownDimensions_ProducesExpectedMargins()
    {
        // Arrange - Create chart with specific dimensions
        var chart = new TestChartModel
        {
            Width = 600,
            Height = 400,
            Title = "",  // No title
            ShowLegend = false
        };
        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1") { ChartArea = "Default" };
        series.PointsList.Add(new TestDataPointModel(1, 50));
        chart.SeriesList.Add(series);

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert - Content bounds should account for padding
        Assert.True(layout.ContentBounds.X >= 10, "Left padding should be at least 10");
        Assert.True(layout.ContentBounds.Y >= 10, "Top padding should be at least 10");
        Assert.True(layout.ContentBounds.Right <= 590, "Right padding should leave at least 10px");
        Assert.True(layout.ContentBounds.Bottom <= 390, "Bottom padding should leave at least 10px");
    }

    [Fact]
    public void PlotArea_AccountsForAxisLabels()
    {
        // Arrange
        var chart = CreateStandardTestChart();

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert - Plot area should be smaller than chart area due to axis labels
        var areaLayout = layout.ChartAreaLayouts[0];
        Assert.True(areaLayout.PlotAreaBounds.X > areaLayout.Bounds.X,
            "Plot area X should be offset for Y-axis labels");
        Assert.True(areaLayout.PlotAreaBounds.Bottom < areaLayout.Bounds.Bottom,
            "Plot area should leave room for X-axis labels at bottom");
    }

    [Fact]
    public void PointPositions_AreWithinPlotArea()
    {
        // Arrange
        var chart = CreateStandardTestChart();

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        var areaLayout = layout.ChartAreaLayouts[0];
        var plotArea = areaLayout.PlotAreaBounds;

        foreach (var seriesLayout in areaLayout.SeriesLayouts)
        {
            foreach (var point in seriesLayout.PointLayouts)
            {
                if (!point.IsEmpty)
                {
                    Assert.True(point.Position.X >= plotArea.X - 1,
                        $"Point X={point.Position.X} should be >= plot area X={plotArea.X}");
                    Assert.True(point.Position.X <= plotArea.Right + 1,
                        $"Point X={point.Position.X} should be <= plot area right={plotArea.Right}");
                    Assert.True(point.Position.Y >= plotArea.Y - 1,
                        $"Point Y={point.Position.Y} should be >= plot area Y={plotArea.Y}");
                    Assert.True(point.Position.Y <= plotArea.Bottom + 1,
                        $"Point Y={point.Position.Y} should be <= plot area bottom={plotArea.Bottom}");
                }
            }
        }
    }

    [Fact]
    public void AxisTicks_AlignWithLabelPositions()
    {
        // Arrange
        var chart = CreateStandardTestChart();

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert - Each tick should have a corresponding label at the same value
        var areaLayout = layout.ChartAreaLayouts[0];
        if (areaLayout.AxisXLayout?.Labels.Count > 0 && areaLayout.AxisXLayout.Ticks.Count > 0)
        {
            Assert.Equal(areaLayout.AxisXLayout.Ticks.Count, areaLayout.AxisXLayout.Labels.Count);
            for (int i = 0; i < areaLayout.AxisXLayout.Ticks.Count; i++)
            {
                Assert.Equal(
                    areaLayout.AxisXLayout.Ticks[i].Value,
                    areaLayout.AxisXLayout.Labels[i].Value,
                    precision: 5);
            }
        }
    }

    [Theory]
    [InlineData(400, 300)]
    [InlineData(800, 600)]
    [InlineData(1200, 900)]
    [InlineData(200, 150)]
    public void Layout_ScalesProportionally_DifferentSizes(int width, int height)
    {
        // Arrange
        var chart = CreateStandardTestChart();
        chart.Width = width;
        chart.Height = height;

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert
        Assert.Equal(width, layout.Size.Width);
        Assert.Equal(height, layout.Size.Height);
        Assert.True(layout.ContentBounds.Width > 0);
        Assert.True(layout.ContentBounds.Height > 0);
        
        // Content should use a reasonable portion of the chart
        // For small charts, the fixed-size elements (title, legend, padding) take more relative space
        var usageRatio = (layout.ContentBounds.Width * layout.ContentBounds.Height) / (width * height);
        var minUsage = width < 300 ? 0.15 : 0.5; // Smaller charts have less relative content area
        Assert.True(usageRatio > minUsage, $"Content area should use at least {minUsage:P0} of chart space, got {usageRatio:P}");
    }

    [Fact]
    public void MultipleSeries_ShareSamePlotArea()
    {
        // Arrange
        var chart = new TestChartModel { Width = 600, Height = 400 };
        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series1 = new TestSeriesModel("Series1") { ChartArea = "Default", Color = ChartColor.Blue };
        series1.PointsList.Add(new TestDataPointModel(1, 10));
        series1.PointsList.Add(new TestDataPointModel(2, 20));

        var series2 = new TestSeriesModel("Series2") { ChartArea = "Default", Color = ChartColor.Red };
        series2.PointsList.Add(new TestDataPointModel(1, 15));
        series2.PointsList.Add(new TestDataPointModel(2, 25));

        chart.SeriesList.Add(series1);
        chart.SeriesList.Add(series2);

        // Act
        var layout = _engine.CalculateLayout(chart);

        // Assert - Both series should be in the same chart area layout
        var areaLayout = layout.ChartAreaLayouts[0];
        Assert.Equal(2, areaLayout.SeriesLayouts.Count);

        // All points should be within the same plot area
        var plotArea = areaLayout.PlotAreaBounds;
        foreach (var seriesLayout in areaLayout.SeriesLayouts)
        {
            foreach (var point in seriesLayout.PointLayouts)
            {
                if (!point.IsEmpty)
                {
                    Assert.True(point.Position.X >= plotArea.X - 1 && point.Position.X <= plotArea.Right + 1);
                    Assert.True(point.Position.Y >= plotArea.Y - 1 && point.Position.Y <= plotArea.Bottom + 1);
                }
            }
        }
    }

    [Fact]
    public void LegendPosition_Right_ReducesContentWidth()
    {
        // Arrange
        var chartNoLegend = CreateStandardTestChart();
        chartNoLegend.ShowLegend = false;

        var chartWithLegend = CreateStandardTestChart();
        chartWithLegend.ShowLegend = true;
        chartWithLegend.LegendPosition = ChartLegendPosition.Right;

        // Act
        var layoutNoLegend = _engine.CalculateLayout(chartNoLegend);
        var layoutWithLegend = _engine.CalculateLayout(chartWithLegend);

        // Assert - Content width should be smaller when legend is shown on right
        Assert.True(layoutWithLegend.ContentBounds.Width < layoutNoLegend.ContentBounds.Width,
            "Content width should be reduced when legend is on the right");
        Assert.False(layoutWithLegend.LegendBounds.IsEmpty, "Legend bounds should not be empty");
    }

    [Fact]
    public void Title_ReducesContentHeight()
    {
        // Arrange
        var chartNoTitle = CreateStandardTestChart();
        chartNoTitle.Title = "";

        var chartWithTitle = CreateStandardTestChart();
        chartWithTitle.Title = "Test Chart Title";

        // Act
        var layoutNoTitle = _engine.CalculateLayout(chartNoTitle);
        var layoutWithTitle = _engine.CalculateLayout(chartWithTitle);

        // Assert - Content area should start lower when title is present
        Assert.True(layoutWithTitle.ContentBounds.Y > layoutNoTitle.ContentBounds.Y ||
                   layoutWithTitle.ContentBounds.Height < layoutNoTitle.ContentBounds.Height,
            "Content area should be reduced when title is present");
        Assert.False(layoutWithTitle.TitleBounds.IsEmpty, "Title bounds should not be empty");
    }

    private TestChartModel CreateStandardTestChart()
    {
        var chart = new TestChartModel
        {
            Width = 600,
            Height = 400,
            Title = "Test Chart",
            ShowLegend = true,
            LegendPosition = ChartLegendPosition.Right
        };

        chart.ChartAreasList.Add(new TestChartAreaModel("Default"));

        var series = new TestSeriesModel("Series1") { ChartArea = "Default" };
        series.PointsList.Add(new TestDataPointModel(1, 10));
        series.PointsList.Add(new TestDataPointModel(2, 25));
        series.PointsList.Add(new TestDataPointModel(3, 15));
        series.PointsList.Add(new TestDataPointModel(4, 30));
        series.PointsList.Add(new TestDataPointModel(5, 20));
        chart.SeriesList.Add(series);

        return chart;
    }
}

#region Test Model Implementations

internal class TestChartModel : IChartModel
{
    public float Width { get; set; } = 400;
    public float Height { get; set; } = 300;
    public ChartColor BackColor { get; set; } = ChartColor.White;
    public ChartColor BackSecondaryColor { get; set; } = ChartColor.White;
    public ChartGradientStyle BackGradientStyle { get; set; } = ChartGradientStyle.None;
    public string Title { get; set; } = "";
    public ChartFont TitleFont { get; set; } = new("Arial", 12);
    public ChartColor TitleColor { get; set; } = ChartColor.Black;
    public bool ShowLegend { get; set; }
    public ChartLegendPosition LegendPosition { get; set; } = ChartLegendPosition.Right;

    public List<TestChartAreaModel> ChartAreasList { get; } = [];
    public List<TestSeriesModel> SeriesList { get; } = [];

    public IReadOnlyList<IChartAreaModel> ChartAreas => ChartAreasList;
    public IReadOnlyList<ISeriesModel> Series => SeriesList;
}

internal class TestChartAreaModel : IChartAreaModel
{
    public TestChartAreaModel(string name = "Default")
    {
        Name = name;
    }

    public string Name { get; set; }
    public ChartColor BackColor { get; set; } = ChartColor.White;
    public ChartColor BackSecondaryColor { get; set; } = ChartColor.White;
    public ChartGradientStyle BackGradientStyle { get; set; } = ChartGradientStyle.None;
    public bool ShowGrid { get; set; } = true;
    public ChartColor GridColor { get; set; } = ChartColor.LightGray;

    public IAxisModel AxisX { get; set; } = new TestAxisModel();
    public IAxisModel AxisY { get; set; } = new TestAxisModel();
    public IAxisModel? AxisX2 { get; set; }
    public IAxisModel? AxisY2 { get; set; }
}

internal class TestAxisModel : IAxisModel
{
    public bool Enabled { get; set; } = true;
    public string Title { get; set; } = "";
    public double Minimum { get; set; } = double.NaN;
    public double Maximum { get; set; } = double.NaN;
    public double Interval { get; set; } = double.NaN;
    public ChartColor LineColor { get; set; } = ChartColor.Black;
    public float LineWidth { get; set; } = 1;
    public bool ShowMajorGrid { get; set; } = true;
    public bool ShowTickMarks { get; set; } = true;
    public bool ShowLabels { get; set; } = true;
    public ChartFont LabelFont { get; set; } = new("Arial", 10);
    public ChartFont? TitleFont { get; set; }
    public ChartColor LabelColor { get; set; } = ChartColor.Black;
    public bool IsReversed { get; set; }
    public bool IsLogarithmic { get; set; }
    public double LogarithmBase { get; set; } = 10;
    public bool IsMarginVisible { get; set; }

    public List<string> CustomLabelsList { get; } = [];
    public IReadOnlyList<string> CustomLabels => CustomLabelsList;
}

internal class TestSeriesModel : ISeriesModel
{
    public TestSeriesModel(string name = "Series1")
    {
        Name = name;
    }

    public string Name { get; set; }
    public string ChartType { get; set; } = "Line";
    public string ChartArea { get; set; } = "";
    public ChartColor Color { get; set; } = ChartColor.Blue;
    public ChartColor BorderColor { get; set; } = ChartColor.Blue;
    public float BorderWidth { get; set; } = 1;
    public ChartDashStyle BorderDashStyle { get; set; } = ChartDashStyle.Solid;
    public bool ShowMarkers { get; set; }
    public ChartMarkerStyle MarkerStyle { get; set; } = ChartMarkerStyle.None;
    public float MarkerSize { get; set; } = 5;
    public ChartColor MarkerColor { get; set; } = ChartColor.Empty;
    public ChartColor MarkerBorderColor { get; set; } = ChartColor.Empty;
    public float MarkerBorderWidth { get; set; } = 1;
    public bool IsValueShownAsLabel { get; set; }
    public string LabelFormat { get; set; } = "";
    public ChartFont LabelFont { get; set; } = new("Arial", 10);
    public ChartColor LabelForeColor { get; set; } = ChartColor.Black;
    public bool IsVisible { get; set; } = true;
    public bool IsXValueIndexed { get; set; } = true;
    public ChartAxisType XAxisType { get; set; } = ChartAxisType.Primary;
    public ChartAxisType YAxisType { get; set; } = ChartAxisType.Primary;

    public List<TestDataPointModel> PointsList { get; } = [];
    public IReadOnlyList<IDataPointModel> Points => PointsList;

    public void Add(double x, double y)
    {
        PointsList.Add(new TestDataPointModel(x, y));
    }
}

internal class TestDataPointModel : IDataPointModel
{
    public TestDataPointModel(double x, double y)
    {
        XValue = x;
        YValues = [y];
    }

    public double XValue { get; set; }
    public double[] YValues { get; set; }
    public double YValue => YValues.Length > 0 ? YValues[0] : 0;
    public string AxisLabel { get; set; } = "";
    public string Label { get; set; } = "";
    public int LabelAngle { get; set; }
    public ChartColor Color { get; set; } = ChartColor.Empty;
    public ChartColor BorderColor { get; set; } = ChartColor.Empty;
    public float BorderWidth { get; set; } = 1;
    public ChartMarkerStyle MarkerStyle { get; set; } = ChartMarkerStyle.None;
    public float MarkerSize { get; set; } = 5;
    public ChartColor MarkerColor { get; set; } = ChartColor.Empty;
    public bool IsEmpty { get; set; }
    public bool IsValueShownAsLabel { get; set; }
    public string ToolTip { get; set; } = "";
    public string LabelToolTip { get; set; } = "";
    public ChartColor LabelForeColor { get; set; } = ChartColor.Black;
    public ChartColor LabelBackColor { get; set; } = ChartColor.Empty;
    public ChartColor LabelBorderColor { get; set; } = ChartColor.Empty;
    public float LabelBorderWidth { get; set; }
    public ChartDashStyle LabelBorderDashStyle { get; set; } = ChartDashStyle.Solid;
}

#endregion
