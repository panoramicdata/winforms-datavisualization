// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.DataVisualization.Charting.Rendering;
using Xunit;

namespace Svg.DataVisualization.Tests;

public class SvgPrimitiveConverterTests
{
    [Fact]
    public void ToSvgColor_WithOpaqueColor_ReturnsHexFormat()
    {
        var color = ChartColor.FromArgb(255, 128, 64);
        var result = SvgPrimitiveConverter.ToSvgColor(color);
        Assert.Equal("#FF8040", result);
    }

    [Fact]
    public void ToSvgColor_WithTransparentColor_ReturnsRgbaFormat()
    {
        var color = ChartColor.FromArgb(128, 255, 128, 64);
        var result = SvgPrimitiveConverter.ToSvgColor(color);
        Assert.StartsWith("rgba(255,128,64,", result);
    }

    [Fact]
    public void ToSvgColor_WithEmptyColor_ReturnsNone()
    {
        var color = ChartColor.Empty;
        var result = SvgPrimitiveConverter.ToSvgColor(color);
        Assert.Equal("none", result);
    }

    [Fact]
    public void ToSvgDashArray_WithSolid_ReturnsEmpty()
    {
        var result = SvgPrimitiveConverter.ToSvgDashArray(ChartDashStyle.Solid, 1);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToSvgDashArray_WithDash_ReturnsDashPattern()
    {
        var result = SvgPrimitiveConverter.ToSvgDashArray(ChartDashStyle.Dash, 2);
        Assert.Contains(",", result);
        Assert.NotEmpty(result);
    }

    [Fact]
    public void ToSvgLineCap_WithRound_ReturnsRound()
    {
        var result = SvgPrimitiveConverter.ToSvgLineCap(ChartLineCap.Round);
        Assert.Equal("round", result);
    }

    [Fact]
    public void ToSvgLineCap_WithFlat_ReturnsButt()
    {
        var result = SvgPrimitiveConverter.ToSvgLineCap(ChartLineCap.Flat);
        Assert.Equal("butt", result);
    }

    [Fact]
    public void ToSvgLineJoin_WithRound_ReturnsRound()
    {
        var result = SvgPrimitiveConverter.ToSvgLineJoin(ChartLineJoin.Round);
        Assert.Equal("round", result);
    }

    [Fact]
    public void ToSvgFontAttributes_ContainsFontFamily()
    {
        var font = new ChartFont("Arial", 12);
        var result = SvgPrimitiveConverter.ToSvgFontAttributes(font);
        Assert.Contains("font-family=\"Arial\"", result);
    }

    [Fact]
    public void ToSvgFontAttributes_ContainsFontSize()
    {
        var font = new ChartFont("Arial", 14);
        var result = SvgPrimitiveConverter.ToSvgFontAttributes(font);
        Assert.Contains("font-size=\"14\"", result);
    }

    [Fact]
    public void ToSvgFontAttributes_WithBold_ContainsBold()
    {
        var font = new ChartFont("Arial", 12, ChartFontStyle.Bold);
        var result = SvgPrimitiveConverter.ToSvgFontAttributes(font);
        Assert.Contains("font-weight=\"bold\"", result);
    }

    [Fact]
    public void ToSvgFontAttributes_WithItalic_ContainsItalic()
    {
        var font = new ChartFont("Arial", 12, ChartFontStyle.Italic);
        var result = SvgPrimitiveConverter.ToSvgFontAttributes(font);
        Assert.Contains("font-style=\"italic\"", result);
    }

    [Fact]
    public void ToSvgRectAttributes_ReturnsCorrectFormat()
    {
        var rect = new ChartRectangleF(10, 20, 100, 50);
        var result = SvgPrimitiveConverter.ToSvgRectAttributes(rect);
        Assert.Contains("x=\"10\"", result);
        Assert.Contains("y=\"20\"", result);
        Assert.Contains("width=\"100\"", result);
        Assert.Contains("height=\"50\"", result);
    }

    [Fact]
    public void ToSvgEllipseAttributes_CalculatesCorrectCenter()
    {
        var rect = new ChartRectangleF(0, 0, 100, 50);
        var result = SvgPrimitiveConverter.ToSvgEllipseAttributes(rect);
        Assert.Contains("cx=\"50\"", result);
        Assert.Contains("cy=\"25\"", result);
    }

    [Fact]
    public void ToSvgTransform_WithIdentity_ReturnsEmpty()
    {
        var matrix = ChartMatrix.Identity;
        var result = SvgPrimitiveConverter.ToSvgTransform(matrix);
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void ToSvgTextAlignment_WithCenter_ReturnsCenterAnchor()
    {
        var format = new ChartStringFormat { Alignment = ChartStringAlignment.Center };
        var result = SvgPrimitiveConverter.ToSvgTextAlignment(format);
        Assert.Contains("text-anchor=\"middle\"", result);
    }

    [Fact]
    public void ToSvgGradientDefinition_ContainsGradientId()
    {
        var brush = new ChartLinearGradientBrush(
            new ChartRectangleF(0, 0, 100, 100),
            ChartColor.Red,
            ChartColor.Blue,
            ChartLinearGradientMode.Horizontal);

        var result = SvgPrimitiveConverter.ToSvgGradientDefinition(brush, "myGradient");
        Assert.Contains("id=\"myGradient\"", result);
        Assert.Contains("<stop", result);
    }
}

public class SvgRenderingEngineTests
{
    [Fact]
    public void Constructor_SetsDimensions()
    {
        using var engine = new SvgRenderingEngine(800, 600);
        Assert.Equal(800, engine.Width);
        Assert.Equal(600, engine.Height);
    }

    [Fact]
    public void GetSvgContent_ReturnsSvgDocument()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        var svg = engine.GetSvgContent();

        Assert.StartsWith("<svg", svg);
        Assert.Contains("</svg>", svg);
        Assert.Contains("xmlns=\"http://www.w3.org/2000/svg\"", svg);
    }

    [Fact]
    public void GetSvgContent_ContainsViewBox()
    {
        using var engine = new SvgRenderingEngine(400, 300);
        var svg = engine.GetSvgContent();

        Assert.Contains("viewBox=\"0 0 400 300\"", svg);
    }

    [Fact]
    public void DrawLine_AddsLineElement()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var pen = new ChartPen(ChartColor.Black, 1);

        engine.DrawLine(pen, 10, 20, 80, 90);
        var svg = engine.GetSvgContent();

        Assert.Contains("<line", svg);
        Assert.Contains("x1=\"10\"", svg);
        Assert.Contains("y1=\"20\"", svg);
        Assert.Contains("x2=\"80\"", svg);
        Assert.Contains("y2=\"90\"", svg);
    }

    [Fact]
    public void DrawRectangle_AddsRectElement()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var pen = new ChartPen(ChartColor.Red, 2);

        engine.DrawRectangle(pen, 10, 10, 50, 30);
        var svg = engine.GetSvgContent();

        Assert.Contains("<rect", svg);
        Assert.Contains("fill=\"none\"", svg);
    }

    [Fact]
    public void FillRectangle_AddsFilledRectElement()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var brush = new ChartSolidBrush(ChartColor.Blue);

        engine.FillRectangle(brush, 10, 10, 50, 30);
        var svg = engine.GetSvgContent();

        Assert.Contains("<rect", svg);
        Assert.Contains("stroke=\"none\"", svg);
    }

    [Fact]
    public void DrawEllipse_AddsEllipseElement()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var pen = new ChartPen(ChartColor.Green, 1);

        engine.DrawEllipse(pen, 20, 20, 60, 40);
        var svg = engine.GetSvgContent();

        Assert.Contains("<ellipse", svg);
    }

    [Fact]
    public void DrawString_AddsTextElement()
    {
        using var engine = new SvgRenderingEngine(200, 100);
        var font = new ChartFont("Arial", 12);
        using var brush = new ChartSolidBrush(ChartColor.Black);

        engine.DrawString("Hello World", font, brush, new ChartPointF(10, 50), null);
        var svg = engine.GetSvgContent();

        Assert.Contains("<text", svg);
        Assert.Contains("Hello World", svg);
    }

    [Fact]
    public void DrawString_EscapesXmlCharacters()
    {
        using var engine = new SvgRenderingEngine(200, 100);
        var font = new ChartFont("Arial", 12);
        using var brush = new ChartSolidBrush(ChartColor.Black);

        engine.DrawString("<test>&\"'", font, brush, new ChartPointF(10, 50), null);
        var svg = engine.GetSvgContent();

        Assert.Contains("&lt;test&gt;&amp;", svg);
    }

    [Fact]
    public void FillPolygon_AddsPolygonElement()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var brush = new ChartSolidBrush(ChartColor.Yellow);

        var points = new ChartPointF[]
        {
            new(50, 10),
            new(90, 90),
            new(10, 90)
        };

        engine.FillPolygon(brush, points);
        var svg = engine.GetSvgContent();

        Assert.Contains("<polygon", svg);
    }

    [Fact]
    public void DrawPie_AddsPathElement()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var pen = new ChartPen(ChartColor.Black, 1);

        engine.DrawPie(pen, 10, 10, 80, 80, 0, 90);
        var svg = engine.GetSvgContent();

        Assert.Contains("<path", svg);
        Assert.Contains("A ", svg); // Arc command
    }

    [Fact]
    public void FillRectangle_WithGradient_AddsDefinition()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var brush = new ChartLinearGradientBrush(
            new ChartRectangleF(0, 0, 100, 100),
            ChartColor.Red,
            ChartColor.Blue,
            ChartLinearGradientMode.Horizontal);

        engine.FillRectangle(brush, 10, 10, 80, 80);
        var svg = engine.GetSvgContent();

        Assert.Contains("<defs>", svg);
        Assert.Contains("<linearGradient", svg);
        Assert.Contains("url(#gradient_", svg);
    }

    [Fact]
    public void Save_And_Restore_ManagesState()
    {
        using var engine = new SvgRenderingEngine(100, 100);

        var state = engine.Save();
        engine.TranslateTransform(50, 50);
        engine.Restore(state);

        // After restore, transform should be back to identity
        Assert.True(engine.Transform.IsIdentity);
    }

    [Fact]
    public void ToStream_ReturnsReadableStream()
    {
        using var engine = new SvgRenderingEngine(100, 100);
        using var stream = engine.ToStream();

        Assert.True(stream.CanRead);
        Assert.True(stream.Length > 0);
    }
}

public class SvgChartTests
{
    [Fact]
    public void Constructor_InitializesDefaults()
    {
        using var chart = new SvgChart();

        Assert.Equal(600, chart.Width);
        Assert.Equal(400, chart.Height);
        Assert.NotNull(chart.Series);
        Assert.NotNull(chart.ChartAreas);
    }

    [Fact]
    public void RenderToSvg_ReturnsValidSvg()
    {
        using var chart = new SvgChart
        {
            Title = "Test Chart",
            Width = 400,
            Height = 300
        };

        var svg = chart.RenderToSvg();

        Assert.Contains("<svg", svg);
        Assert.Contains("</svg>", svg);
    }

    [Fact]
    public void RenderToSvg_WithData_ContainsChartElements()
    {
        using var chart = new SvgChart();
        var series = new SvgChartSeries("Test")
        {
            ChartType = SvgChartType.Line
        };
        series.Points.Add(new SvgDataPoint(0, 10));
        series.Points.Add(new SvgDataPoint(1, 20));
        series.Points.Add(new SvgDataPoint(2, 15));

        chart.Series.Add(series);
        var svg = chart.RenderToSvg();

        // Should contain polyline for line chart
        Assert.Contains("<polyline", svg);
    }

    [Fact]
    public void RenderToSvg_WithTitle_ContainsTitle()
    {
        using var chart = new SvgChart { Title = "My Chart Title" };
        var svg = chart.RenderToSvg();

        Assert.Contains("My Chart Title", svg);
    }

    [Fact]
    public void RenderToSvg_WithColumnChart_ContainsRects()
    {
        using var chart = new SvgChart();
        var series = new SvgChartSeries("Columns")
        {
            ChartType = SvgChartType.Column
        };
        series.Points.Add(new SvgDataPoint(0, 10));
        series.Points.Add(new SvgDataPoint(1, 20));

        chart.Series.Add(series);
        var svg = chart.RenderToSvg();

        // Column charts use rect elements
        Assert.Contains("<rect", svg);
    }

    [Fact]
    public void RenderToSvg_WithPieChart_ContainsPaths()
    {
        using var chart = new SvgChart();
        var series = new SvgChartSeries("Pie")
        {
            ChartType = SvgChartType.Pie
        };
        series.Points.Add(new SvgDataPoint(0, 30));
        series.Points.Add(new SvgDataPoint(1, 50));
        series.Points.Add(new SvgDataPoint(2, 20));

        chart.Series.Add(series);
        var svg = chart.RenderToSvg();

        // Pie charts use path elements for slices
        Assert.Contains("<path", svg);
    }

    [Fact]
    public void RenderToSvg_WithLegend_ContainsLegendItems()
    {
        using var chart = new SvgChart { ShowLegend = true };
        var series = new SvgChartSeries("Test Series");
        series.Points.Add(new SvgDataPoint(0, 10));
        chart.Series.Add(series);

        var svg = chart.RenderToSvg();

        Assert.Contains("Test Series", svg);
    }

    [Fact]
    public void RenderToSvg_WithScatterChart_ContainsEllipses()
    {
        using var chart = new SvgChart();
        var series = new SvgChartSeries("Scatter")
        {
            ChartType = SvgChartType.Scatter
        };
        series.Points.Add(new SvgDataPoint(0, 10));
        series.Points.Add(new SvgDataPoint(1, 20));

        chart.Series.Add(series);
        var svg = chart.RenderToSvg();

        // Scatter plots use ellipse elements for markers
        Assert.Contains("<ellipse", svg);
    }

    [Fact]
    public void RenderToStream_ReturnsValidStream()
    {
        using var chart = new SvgChart();
        using var stream = chart.RenderToStream();

        Assert.True(stream.CanRead);
        Assert.True(stream.Length > 0);
    }

    [Fact]
    public void MultipleSeries_RenderCorrectly()
    {
        using var chart = new SvgChart();

        var series1 = new SvgChartSeries("Series 1") { ChartType = SvgChartType.Line };
        series1.Points.Add(new SvgDataPoint(0, 10));
        series1.Points.Add(new SvgDataPoint(1, 20));

        var series2 = new SvgChartSeries("Series 2") { ChartType = SvgChartType.Line };
        series2.Points.Add(new SvgDataPoint(0, 15));
        series2.Points.Add(new SvgDataPoint(1, 25));

        chart.Series.Add(series1);
        chart.Series.Add(series2);

        var svg = chart.RenderToSvg();

        // Should contain multiple polylines
        var polylineCount = svg.Split("<polyline").Length - 1;
        Assert.Equal(2, polylineCount);
    }
}
