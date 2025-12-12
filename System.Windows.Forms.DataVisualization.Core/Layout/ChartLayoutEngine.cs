// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// The main layout engine that calculates positions for all chart elements.
/// This is the single source of truth for chart layout, ensuring identical
/// output across all rendering engines (GDI+, SVG, etc.).
/// </summary>
public class ChartLayoutEngine
{
    private readonly AxisLayoutCalculator _axisCalculator;
    private readonly CircularLayoutEngine _circularLayoutEngine;
    private readonly ITextMeasurer _textMeasurer;

    /// <summary>
    /// Default padding around the chart in pixels.
    /// </summary>
    private const float DefaultPadding = 10f;

    /// <summary>
    /// Default title height in pixels.
    /// </summary>
    private const float DefaultTitleHeight = 24f;

    /// <summary>
    /// Default legend width when on the side.
    /// </summary>
    private const float DefaultLegendWidth = 100f;

    /// <summary>
    /// Default legend height when at bottom.
    /// </summary>
    private const float DefaultLegendHeight = 40f;

    /// <summary>
    /// Default font for titles.
    /// </summary>
    private static readonly ChartFont DefaultTitleFont = new("Arial", 14, ChartFontStyle.Bold);

    /// <summary>
    /// Default font for legend text.
    /// </summary>
    private static readonly ChartFont DefaultLegendFont = new("Arial", 10, ChartFontStyle.Regular);

    /// <summary>
    /// Creates a new ChartLayoutEngine with the default text measurer.
    /// </summary>
    public ChartLayoutEngine()
        : this(DefaultTextMeasurer.Instance)
    {
    }

    /// <summary>
    /// Creates a new ChartLayoutEngine with the specified text measurer.
    /// </summary>
    /// <param name="textMeasurer">The text measurer to use for layout calculations.</param>
    public ChartLayoutEngine(ITextMeasurer textMeasurer)
    {
        _textMeasurer = textMeasurer ?? DefaultTextMeasurer.Instance;
        _axisCalculator = new AxisLayoutCalculator(_textMeasurer);
        _circularLayoutEngine = new CircularLayoutEngine(_textMeasurer);
    }

    /// <summary>
    /// Calculates the complete layout for a chart.
    /// </summary>
    /// <param name="chart">The chart model.</param>
    /// <returns>The calculated layout.</returns>
    public ChartLayout CalculateLayout(IChartModel chart)
    {
        var layout = new ChartLayout(chart.Width, chart.Height);

        // Start with content bounds as the full chart area minus padding
        layout.ContentBounds = new ChartRectangleF(
            DefaultPadding,
            DefaultPadding,
            chart.Width - DefaultPadding * 2,
            chart.Height - DefaultPadding * 2);

        // Calculate title position
        if (!string.IsNullOrEmpty(chart.Title))
        {
            layout.TitleBounds = CalculateTitleBounds(chart, layout);
            // Adjust content bounds
            layout.ContentBounds = new ChartRectangleF(
                layout.ContentBounds.X,
                layout.ContentBounds.Y + layout.TitleBounds.Height + DefaultPadding,
                layout.ContentBounds.Width,
                layout.ContentBounds.Height - layout.TitleBounds.Height - DefaultPadding);
        }

        // Calculate legend position
        if (chart.ShowLegend && chart.Series.Count > 0)
        {
            layout.LegendBounds = CalculateLegendBounds(chart, layout);
            // Adjust content bounds based on legend position
            AdjustContentBoundsForLegend(chart, layout);
        }

        // Calculate chart area layouts
        CalculateChartAreaLayouts(chart, layout);

        return layout;
    }

    /// <summary>
    /// Calculates the title bounds.
    /// </summary>
    private ChartRectangleF CalculateTitleBounds(IChartModel chart, ChartLayout layout)
    {
        // Measure title text
        var titleFont = chart.TitleFont ?? DefaultTitleFont;
        var titleSize = _textMeasurer.MeasureString(chart.Title, titleFont);

        float titleHeight = Math.Max(titleSize.Height, DefaultTitleHeight);
        float titleWidth = Math.Min(titleSize.Width, layout.ContentBounds.Width);

        float titleX = layout.ContentBounds.X + (layout.ContentBounds.Width - titleWidth) / 2;

        return new ChartRectangleF(
            titleX,
            layout.ContentBounds.Y,
            titleWidth,
            titleHeight);
    }

    /// <summary>
    /// Calculates the legend bounds based on position.
    /// </summary>
    private ChartRectangleF CalculateLegendBounds(IChartModel chart, ChartLayout layout)
    {
        // Estimate legend size based on number of series
        int seriesCount = chart.Series.Count;
        float itemHeight = 20f;
        float itemWidth = 80f;

        // Measure actual series name widths
        foreach (var series in chart.Series)
        {
            var textSize = _textMeasurer.MeasureString(series.Name, DefaultLegendFont);
            float width = textSize.Width + 30f; // text + color box + padding
            itemWidth = Math.Max(itemWidth, width);
        }

        switch (chart.LegendPosition)
        {
            case ChartLegendPosition.Right:
                float rightWidth = Math.Min(itemWidth + 20f, DefaultLegendWidth);
                return new ChartRectangleF(
                    layout.ContentBounds.Right - rightWidth,
                    layout.ContentBounds.Y,
                    rightWidth,
                    Math.Min(seriesCount * itemHeight + 20f, layout.ContentBounds.Height));

            case ChartLegendPosition.Left:
                float leftWidth = Math.Min(itemWidth + 20f, DefaultLegendWidth);
                return new ChartRectangleF(
                    layout.ContentBounds.X,
                    layout.ContentBounds.Y,
                    leftWidth,
                    Math.Min(seriesCount * itemHeight + 20f, layout.ContentBounds.Height));

            case ChartLegendPosition.Bottom:
                return new ChartRectangleF(
                    layout.ContentBounds.X,
                    layout.ContentBounds.Bottom - DefaultLegendHeight,
                    layout.ContentBounds.Width,
                    DefaultLegendHeight);

            case ChartLegendPosition.Top:
                return new ChartRectangleF(
                    layout.ContentBounds.X,
                    layout.ContentBounds.Y,
                    layout.ContentBounds.Width,
                    DefaultLegendHeight);

            default:
                return ChartRectangleF.Empty;
        }
    }

    /// <summary>
    /// Adjusts the content bounds to account for legend position.
    /// </summary>
    private void AdjustContentBoundsForLegend(IChartModel chart, ChartLayout layout)
    {
        float legendSpace = DefaultPadding;

        switch (chart.LegendPosition)
        {
            case ChartLegendPosition.Right:
                layout.ContentBounds = new ChartRectangleF(
                    layout.ContentBounds.X,
                    layout.ContentBounds.Y,
                    layout.ContentBounds.Width - layout.LegendBounds.Width - legendSpace,
                    layout.ContentBounds.Height);
                break;

            case ChartLegendPosition.Left:
                layout.ContentBounds = new ChartRectangleF(
                    layout.ContentBounds.X + layout.LegendBounds.Width + legendSpace,
                    layout.ContentBounds.Y,
                    layout.ContentBounds.Width - layout.LegendBounds.Width - legendSpace,
                    layout.ContentBounds.Height);
                break;

            case ChartLegendPosition.Bottom:
                layout.ContentBounds = new ChartRectangleF(
                    layout.ContentBounds.X,
                    layout.ContentBounds.Y,
                    layout.ContentBounds.Width,
                    layout.ContentBounds.Height - layout.LegendBounds.Height - legendSpace);
                break;

            case ChartLegendPosition.Top:
                layout.ContentBounds = new ChartRectangleF(
                    layout.ContentBounds.X,
                    layout.ContentBounds.Y + layout.LegendBounds.Height + legendSpace,
                    layout.ContentBounds.Width,
                    layout.ContentBounds.Height - layout.LegendBounds.Height - legendSpace);
                break;
        }
    }

    /// <summary>
    /// Calculates layouts for all chart areas.
    /// </summary>
    private void CalculateChartAreaLayouts(IChartModel chart, ChartLayout layout)
    {
        var chartAreas = chart.ChartAreas;

        if (chartAreas.Count == 0)
        {
            // Create a default chart area layout using the full content bounds
            var defaultAreaLayout = new ChartAreaLayout
            {
                Bounds = layout.ContentBounds,
                PlotAreaBounds = layout.ContentBounds
            };

            // Calculate series for default area
            CalculateSeriesLayouts(chart, defaultAreaLayout, chart.Series, layout);

            layout.ChartAreaLayouts.Add(defaultAreaLayout);
            return;
        }

        // Calculate how to distribute chart areas
        int areaCount = chartAreas.Count;
        int columns = (int)Math.Ceiling(Math.Sqrt(areaCount));
        int rows = (int)Math.Ceiling((double)areaCount / columns);

        float areaWidth = layout.ContentBounds.Width / columns;
        float areaHeight = layout.ContentBounds.Height / rows;

        int areaIndex = 0;
        for (int row = 0; row < rows && areaIndex < areaCount; row++)
        {
            for (int col = 0; col < columns && areaIndex < areaCount; col++)
            {
                var area = chartAreas[areaIndex];
                
                // Check if this is a circular chart area
                ChartAreaLayout areaLayout;
                if (area is ICircularChartAreaModel circularArea)
                {
                    // Get series for this area
                    var areaSeries = chart.Series
                        .Where(s => s.ChartArea == area.Name || string.IsNullOrEmpty(s.ChartArea))
                        .ToList();

                    var bounds = new ChartRectangleF(
                        layout.ContentBounds.X + col * areaWidth,
                        layout.ContentBounds.Y + row * areaHeight,
                        areaWidth,
                        areaHeight);

                    areaLayout = _circularLayoutEngine.CalculateLayout(circularArea, areaSeries, bounds);
                }
                else
                {
                    // Use standard rectangular layout
                    areaLayout = CalculateChartAreaLayout(
                        area,
                        chart,
                        layout,
                        layout.ContentBounds.X + col * areaWidth,
                        layout.ContentBounds.Y + row * areaHeight,
                        areaWidth,
                        areaHeight);
                }

                layout.ChartAreaLayouts.Add(areaLayout);
                areaIndex++;
            }
        }
    }

    /// <summary>
    /// Calculates the layout for a single chart area.
    /// </summary>
    private ChartAreaLayout CalculateChartAreaLayout(
        IChartAreaModel area,
        IChartModel chart,
        ChartLayout parentLayout,
        float x, float y, float width, float height)
    {
        var areaLayout = new ChartAreaLayout
        {
            Area = area,
            Bounds = new ChartRectangleF(x, y, width, height),
            BackColor = area.BackColor,
            BackSecondaryColor = area.BackSecondaryColor,
            BackGradientStyle = area.BackGradientStyle,
            ShowGrid = area.ShowGrid,
            GridColor = area.GridColor
        };

        // Get series that belong to this chart area
        var areaSeries = chart.Series
            .Where(s => s.ChartArea == area.Name || string.IsNullOrEmpty(s.ChartArea))
            .ToList();

        // Calculate data bounds from series
        var (dataMinX, dataMaxX, dataMinY, dataMaxY) = CalculateDataBounds(areaSeries);

        // Calculate axis layouts
        areaLayout.AxisXLayout = _axisCalculator.Calculate(
            area.AxisX, false, width, dataMinX, dataMaxX);

        areaLayout.AxisYLayout = _axisCalculator.Calculate(
            area.AxisY, true, height, dataMinY, dataMaxY);

        if (area.AxisX2 != null)
        {
            areaLayout.AxisX2Layout = _axisCalculator.Calculate(
                area.AxisX2, false, width, dataMinX, dataMaxX);
        }

        if (area.AxisY2 != null)
        {
            areaLayout.AxisY2Layout = _axisCalculator.Calculate(
                area.AxisY2, true, height, dataMinY, dataMaxY);
        }

        // Calculate plot area (inner area where data is drawn)
        areaLayout.PlotAreaBounds = CalculatePlotArea(areaLayout);

        // Update axis positions now that we know the plot area
        if (areaLayout.AxisXLayout != null)
            _axisCalculator.UpdatePositions(areaLayout.AxisXLayout, areaLayout.PlotAreaBounds);
        if (areaLayout.AxisYLayout != null)
            _axisCalculator.UpdatePositions(areaLayout.AxisYLayout, areaLayout.PlotAreaBounds);
        if (areaLayout.AxisX2Layout != null)
            _axisCalculator.UpdatePositions(areaLayout.AxisX2Layout, areaLayout.PlotAreaBounds);
        if (areaLayout.AxisY2Layout != null)
            _axisCalculator.UpdatePositions(areaLayout.AxisY2Layout, areaLayout.PlotAreaBounds);

        // Calculate series layouts
        CalculateSeriesLayouts(chart, areaLayout, areaSeries, parentLayout);

        return areaLayout;
    }

    /// <summary>
    /// Calculates the data bounds from all series.
    /// </summary>
    private (double minX, double maxX, double minY, double maxY) CalculateDataBounds(
        IEnumerable<ISeriesModel> seriesList)
    {
        double minX = double.MaxValue;
        double maxX = double.MinValue;
        double minY = double.MaxValue;
        double maxY = double.MinValue;

        bool hasData = false;

        foreach (var series in seriesList)
        {
            if (!series.IsVisible)
                continue;

            int pointIndex = 0;
            foreach (var point in series.Points)
            {
                if (point.IsEmpty)
                {
                    pointIndex++;
                    continue;
                }

                hasData = true;

                // Use index if X is not specified or series is indexed
                double xValue = series.IsXValueIndexed || point.XValue == 0
                    ? pointIndex + 1
                    : point.XValue;

                minX = Math.Min(minX, xValue);
                maxX = Math.Max(maxX, xValue);
                minY = Math.Min(minY, point.YValue);
                maxY = Math.Max(maxY, point.YValue);

                pointIndex++;
            }
        }

        if (!hasData)
        {
            return (0, 10, 0, 10);
        }

        // Ensure we have some range
        if (minX == maxX)
        {
            minX -= 1;
            maxX += 1;
        }
        if (minY == maxY)
        {
            minY -= 1;
            maxY += 1;
        }

        return (minX, maxX, minY, maxY);
    }

    /// <summary>
    /// Calculates the plot area bounds after accounting for axes.
    /// </summary>
    private ChartRectangleF CalculatePlotArea(ChartAreaLayout areaLayout)
    {
        float left = areaLayout.Bounds.X;
        float top = areaLayout.Bounds.Y;
        float right = areaLayout.Bounds.Right;
        float bottom = areaLayout.Bounds.Bottom;

        // Account for Y axis on left
        if (areaLayout.AxisYLayout?.IsEnabled == true)
        {
            left += areaLayout.AxisYLayout.TotalSize;
        }

        // Account for X axis on bottom
        if (areaLayout.AxisXLayout?.IsEnabled == true)
        {
            bottom -= areaLayout.AxisXLayout.TotalSize;
        }

        // Account for secondary Y axis on right
        if (areaLayout.AxisY2Layout?.IsEnabled == true)
        {
            right -= areaLayout.AxisY2Layout.TotalSize;
        }

        // Account for secondary X axis on top
        if (areaLayout.AxisX2Layout?.IsEnabled == true)
        {
            top += areaLayout.AxisX2Layout.TotalSize;
        }

        // Add small padding
        const float plotPadding = 5f;
        left += plotPadding;
        top += plotPadding;
        right -= plotPadding;
        bottom -= plotPadding;

        return new ChartRectangleF(
            left,
            top,
            Math.Max(1, right - left),
            Math.Max(1, bottom - top));
    }

    /// <summary>
    /// Calculates layouts for series data points.
    /// </summary>
    private void CalculateSeriesLayouts(
        IChartModel chart,
        ChartAreaLayout areaLayout,
        IEnumerable<ISeriesModel> seriesList,
        ChartLayout parentLayout)
    {
        var plotArea = areaLayout.PlotAreaBounds;
        var xAxis = areaLayout.AxisXLayout;
        var yAxis = areaLayout.AxisYLayout;

        foreach (var series in seriesList)
        {
            if (!series.IsVisible)
                continue;

            var seriesLayout = new SeriesLayout
            {
                Series = series,
                ChartType = series.ChartType,
                Color = series.Color,
                LineWidth = series.BorderWidth,
                DashStyle = series.BorderDashStyle
            };

            int pointIndex = 0;
            foreach (var point in series.Points)
            {
                var pointLayout = new DataPointLayout
                {
                    Point = point,
                    Index = pointIndex,
                    IsEmpty = point.IsEmpty,
                    Label = point.Label,
                    Color = point.Color.IsEmpty ? series.Color : point.Color
                };

                if (!point.IsEmpty)
                {
                    // Use index if X is not specified or series is indexed
                    double xValue = series.IsXValueIndexed || point.XValue == 0
                        ? pointIndex + 1
                        : point.XValue;

                    pointLayout.XValue = xValue;
                    pointLayout.YValue = point.YValue;

                    // Calculate pixel position
                    if (xAxis != null && yAxis != null)
                    {
                        float pixelX = xAxis.ValueToPixel(xValue, plotArea.X, plotArea.Width);
                        float pixelY = yAxis.ValueToPixel(point.YValue, plotArea.Y, plotArea.Height);
                        pointLayout.Position = new ChartPointF(pixelX, pixelY);
                    }

                    // Calculate marker info
                    var markerStyle = point.MarkerStyle != ChartMarkerStyle.None
                        ? point.MarkerStyle
                        : series.MarkerStyle;
                    var markerSize = point.MarkerSize > 0 ? point.MarkerSize : series.MarkerSize;

                    pointLayout.MarkerStyle = markerStyle;
                    pointLayout.MarkerSize = new ChartSizeF(markerSize, markerSize);

                    // Calculate bar bounds for bar/column charts
                    if (IsBarChart(series.ChartType))
                    {
                        pointLayout.BarBounds = CalculateBarBounds(
                            xValue, point.YValue, xAxis, yAxis, plotArea, series.Points.Count);
                    }
                }

                seriesLayout.PointLayouts.Add(pointLayout);
                pointIndex++;
            }

            areaLayout.SeriesLayouts.Add(seriesLayout);
        }
    }

    /// <summary>
    /// Checks if a chart type is a bar/column chart.
    /// </summary>
    private static bool IsBarChart(string chartType)
    {
        return chartType.Contains("Bar", StringComparison.OrdinalIgnoreCase) ||
               chartType.Contains("Column", StringComparison.OrdinalIgnoreCase);
    }

    /// <summary>
    /// Calculates the bar/column bounds for a data point.
    /// </summary>
    private static ChartRectangleF CalculateBarBounds(
        double xValue,
        double yValue,
        AxisLayout? xAxis,
        AxisLayout? yAxis,
        ChartRectangleF plotArea,
        int pointCount)
    {
        if (xAxis == null || yAxis == null)
            return ChartRectangleF.Empty;

        float barWidth = plotArea.Width / Math.Max(1, pointCount) * 0.8f;
        float halfWidth = barWidth / 2;

        float centerX = xAxis.ValueToPixel(xValue, plotArea.X, plotArea.Width);
        float topY = yAxis.ValueToPixel(yValue, plotArea.Y, plotArea.Height);
        float bottomY = yAxis.ValueToPixel(0, plotArea.Y, plotArea.Height);

        // Handle negative values
        if (topY > bottomY)
        {
            (topY, bottomY) = (bottomY, topY);
        }

        return new ChartRectangleF(
            centerX - halfWidth,
            topY,
            barWidth,
            bottomY - topY);
    }
}
