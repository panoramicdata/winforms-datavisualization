// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Calculates layout for circular chart areas (Radar, Polar).
/// </summary>
public class CircularLayoutEngine
{
    private readonly ITextMeasurer _textMeasurer;

    /// <summary>
    /// Default font for axis labels.
    /// </summary>
    private static readonly ChartFont DefaultLabelFont = new("Arial", 10, ChartFontStyle.Regular);

    /// <summary>
    /// Creates a new CircularLayoutEngine with default text measurer.
    /// </summary>
    public CircularLayoutEngine()
        : this(DefaultTextMeasurer.Instance)
    {
    }

    /// <summary>
    /// Creates a new CircularLayoutEngine with specified text measurer.
    /// </summary>
    /// <param name="textMeasurer">The text measurer to use.</param>
    public CircularLayoutEngine(ITextMeasurer textMeasurer)
    {
        _textMeasurer = textMeasurer ?? DefaultTextMeasurer.Instance;
    }

    /// <summary>
    /// Calculates the layout for a circular chart area.
    /// </summary>
    /// <param name="area">The circular chart area model.</param>
    /// <param name="series">The series to display in this area.</param>
    /// <param name="bounds">The available bounds for the chart area.</param>
    /// <returns>The calculated circular layout.</returns>
    public CircularChartAreaLayout CalculateLayout(
        ICircularChartAreaModel area,
        IReadOnlyList<ISeriesModel> series,
        ChartRectangleF bounds)
    {
        var layout = new CircularChartAreaLayout
        {
            Area = area,
            Bounds = bounds,
            SectorCount = area.SectorCount,
            UsePolygons = area.UsePolygons,
            LabelsStyle = area.LabelsStyle,
            BackColor = area.BackColor,
            BackSecondaryColor = area.BackSecondaryColor,
            BackGradientStyle = area.BackGradientStyle,
            ShowGrid = area.ShowGrid,
            GridColor = area.GridColor
        };

        // Calculate sector angle
        layout.SectorAngle = layout.SectorCount > 0 ? 360f / layout.SectorCount : 360f;

        // Calculate Y axis range from data
        CalculateYAxisRange(series, area, layout);

        // Calculate center and radius
        CalculateCenterAndRadius(area, layout, bounds);

        // Calculate circular axes (spokes)
        CalculateCircularAxes(area, layout);

        // Calculate grid lines
        CalculateGridLines(area, layout);

        // Calculate series layouts
        CalculateSeriesLayouts(series, layout);

        // Set plot area to inscribed rectangle (for compatibility)
        float inset = layout.Radius * 0.05f;
        layout.PlotAreaBounds = new ChartRectangleF(
            layout.Center.X - layout.Radius + inset,
            layout.Center.Y - layout.Radius + inset,
            (layout.Radius - inset) * 2,
            (layout.Radius - inset) * 2);

        return layout;
    }

    /// <summary>
    /// Calculates the Y axis range from series data.
    /// </summary>
    private void CalculateYAxisRange(
        IReadOnlyList<ISeriesModel> series,
        ICircularChartAreaModel area,
        CircularChartAreaLayout layout)
    {
        double minY = double.MaxValue;
        double maxY = double.MinValue;
        bool hasData = false;

        foreach (var s in series)
        {
            if (!s.IsVisible) continue;

            foreach (var point in s.Points)
            {
                if (point.IsEmpty) continue;
                hasData = true;

                minY = Math.Min(minY, point.YValue);
                maxY = Math.Max(maxY, point.YValue);
            }
        }

        if (!hasData)
        {
            minY = 0;
            maxY = 100;
        }

        // Check if axis has explicit settings
        if (area.AxisY != null)
        {
            if (area.AxisY.Minimum != 0 || area.AxisY.Maximum != 0)
            {
                if (area.AxisY.Minimum < minY) minY = area.AxisY.Minimum;
                if (area.AxisY.Maximum > maxY) maxY = area.AxisY.Maximum;
            }
        }

        // Ensure positive minimum for circular charts (usually start from 0)
        if (minY > 0) minY = 0;

        // Add margin
        double range = maxY - minY;
        if (range <= 0) range = 1;
        maxY += range * 0.1;

        layout.YAxisMinimum = minY;
        layout.YAxisMaximum = maxY;
    }

    /// <summary>
    /// Calculates the center point and radius of the circular area.
    /// </summary>
    private void CalculateCenterAndRadius(
        ICircularChartAreaModel area,
        CircularChartAreaLayout layout,
        ChartRectangleF bounds)
    {
        // Estimate label size for margin
        float labelMargin = EstimateLabelMargin(area, layout);

        // Available space after margins
        float availableWidth = bounds.Width - labelMargin * 2;
        float availableHeight = bounds.Height - labelMargin * 2;

        // Make it square (use smaller dimension)
        float size = Math.Min(availableWidth, availableHeight);
        size = Math.Max(size, 10); // Minimum size

        layout.Radius = size / 2;

        // Center in the available bounds
        layout.Center = new ChartPointF(
            bounds.X + bounds.Width / 2,
            bounds.Y + bounds.Height / 2);
    }

    /// <summary>
    /// Estimates the margin needed for labels.
    /// </summary>
    private float EstimateLabelMargin(ICircularChartAreaModel area, CircularChartAreaLayout layout)
    {
        float maxLabelSize = 20f; // Minimum margin

        foreach (var axis in area.CircularAxes)
        {
            if (!string.IsNullOrEmpty(axis.Title))
            {
                var labelSize = _textMeasurer.MeasureString(axis.Title, DefaultLabelFont);
                maxLabelSize = Math.Max(maxLabelSize, Math.Max(labelSize.Width, labelSize.Height));
            }
        }

        return maxLabelSize + 10f; // Add padding
    }

    /// <summary>
    /// Calculates the positions of circular axes (spokes).
    /// </summary>
    private void CalculateCircularAxes(
        ICircularChartAreaModel area,
        CircularChartAreaLayout layout)
    {
        for (int i = 0; i < layout.SectorCount; i++)
        {
            float angle = layout.SectorAngle * i;

            var axisLayout = new CircularAxisLayout
            {
                Index = i,
                Angle = angle,
                StartPosition = layout.Center
            };

            // Calculate end position (at the edge)
            axisLayout.EndPosition = layout.ValueToPosition(layout.YAxisMaximum, angle);

            // Get label from circular axis definition
            if (i < area.CircularAxes.Count)
            {
                var axisModel = area.CircularAxes[i];
                axisLayout.Label = axisModel.Title;
                axisLayout.LabelColor = axisModel.TitleColor.IsEmpty ? ChartColor.Black : axisModel.TitleColor;
            }

            // Calculate label position (outside the chart)
            CalculateLabelPosition(axisLayout, layout);

            layout.CircularAxes.Add(axisLayout);
        }
    }

    /// <summary>
    /// Calculates the label position for a circular axis.
    /// </summary>
    private void CalculateLabelPosition(CircularAxisLayout axis, CircularChartAreaLayout layout)
    {
        // Position label slightly outside the chart edge
        float labelDistance = layout.Radius + 10f;
        double angleRadians = (axis.Angle - 90) * Math.PI / 180.0;

        float x = layout.Center.X + labelDistance * (float)Math.Cos(angleRadians);
        float y = layout.Center.Y + labelDistance * (float)Math.Sin(angleRadians);

        axis.LabelPosition = new ChartPointF(x, y);

        // Calculate label angle based on style
        switch (layout.LabelsStyle)
        {
            case CircularAxisLabelsStyle.Radial:
                // Labels point outward
                axis.LabelAngle = axis.Angle;
                if (axis.Angle > 90 && axis.Angle <= 270)
                {
                    // Flip text on bottom half so it's readable
                    axis.LabelAngle += 180;
                }
                break;

            case CircularAxisLabelsStyle.Circular:
                // Labels follow the circle
                axis.LabelAngle = axis.Angle + 90;
                if (axis.Angle > 0 && axis.Angle < 180)
                {
                    axis.LabelAngle += 180;
                }
                break;

            case CircularAxisLabelsStyle.Horizontal:
            case CircularAxisLabelsStyle.Auto:
            default:
                // Labels are horizontal
                axis.LabelAngle = 0;
                break;
        }

        // Calculate label bounds
        if (!string.IsNullOrEmpty(axis.Label))
        {
            var labelSize = _textMeasurer.MeasureString(axis.Label, DefaultLabelFont);
            axis.LabelBounds = new ChartRectangleF(
                axis.LabelPosition.X - labelSize.Width / 2,
                axis.LabelPosition.Y - labelSize.Height / 2,
                labelSize.Width,
                labelSize.Height);
        }
    }

    /// <summary>
    /// Calculates the circular grid lines.
    /// </summary>
    private void CalculateGridLines(
        ICircularChartAreaModel area,
        CircularChartAreaLayout layout)
    {
        if (!area.ShowGrid) return;

        // Determine number of grid lines (typically 5)
        double range = layout.YAxisMaximum - layout.YAxisMinimum;
        if (range <= 0) return;

        double interval = CalculateNiceInterval(range);
        double startValue = Math.Ceiling(layout.YAxisMinimum / interval) * interval;

        for (double value = startValue; value <= layout.YAxisMaximum; value += interval)
        {
            var gridLayout = new CircularGridLayout
            {
                Value = value,
                IsMajor = true
            };

            // Calculate radius for this value
            double normalized = (value - layout.YAxisMinimum) / range;
            gridLayout.Radius = (float)(normalized * layout.Radius);

            // If using polygons, calculate points
            if (layout.UsePolygons && layout.SectorCount > 0)
            {
                for (int i = 0; i < layout.SectorCount; i++)
                {
                    var point = layout.ValueToPosition(value, layout.SectorAngle * i);
                    gridLayout.PolygonPoints.Add(point);
                }
            }

            layout.GridLines.Add(gridLayout);
        }
    }

    /// <summary>
    /// Calculates a "nice" interval for axis values.
    /// </summary>
    private static double CalculateNiceInterval(double range)
    {
        double roughInterval = range / 5.0;
        double magnitude = Math.Pow(10, Math.Floor(Math.Log10(roughInterval)));
        double residual = roughInterval / magnitude;

        double niceInterval;
        if (residual <= 1.5)
            niceInterval = 1 * magnitude;
        else if (residual <= 3)
            niceInterval = 2 * magnitude;
        else if (residual <= 7)
            niceInterval = 5 * magnitude;
        else
            niceInterval = 10 * magnitude;

        return niceInterval;
    }

    /// <summary>
    /// Calculates the layout for all series in the circular chart.
    /// </summary>
    private void CalculateSeriesLayouts(
        IReadOnlyList<ISeriesModel> series,
        CircularChartAreaLayout layout)
    {
        foreach (var s in series)
        {
            if (!s.IsVisible) continue;

            var seriesLayout = new SeriesLayout
            {
                Series = s,
                ChartType = s.ChartType,
                Color = s.Color,
                LineWidth = s.BorderWidth,
                DashStyle = s.BorderDashStyle
            };

            int pointIndex = 0;
            foreach (var point in s.Points)
            {
                var pointLayout = CreateCircularPointLayout(point, pointIndex, layout, s);
                seriesLayout.PointLayouts.Add(pointLayout);
                pointIndex++;
            }

            layout.SeriesLayouts.Add(seriesLayout);
        }
    }

    /// <summary>
    /// Creates a layout for a single data point in a circular chart.
    /// </summary>
    private CircularDataPointLayout CreateCircularPointLayout(
        IDataPointModel point,
        int index,
        CircularChartAreaLayout layout,
        ISeriesModel series)
    {
        var pointLayout = new CircularDataPointLayout
        {
            Point = point,
            Index = index,
            IsEmpty = point.IsEmpty,
            Label = point.Label,
            Color = point.Color.IsEmpty ? series.Color : point.Color,
            SectorIndex = index
        };

        if (!point.IsEmpty)
        {
            // For Radar charts, X value is the point index
            // For Polar charts, X value is the angle
            float angle;
            if (series.IsXValueIndexed || point.XValue == 0)
            {
                // Radar-style: use point index to determine angle
                angle = layout.SectorAngle * index;
            }
            else
            {
                // Polar-style: use X value as angle
                angle = (float)point.XValue;
            }

            pointLayout.Angle = angle;
            pointLayout.XValue = point.XValue;
            pointLayout.YValue = point.YValue;

            // Calculate normalized distance (0-1) from center
            double range = layout.YAxisMaximum - layout.YAxisMinimum;
            if (range > 0)
            {
                pointLayout.NormalizedDistance = (float)((point.YValue - layout.YAxisMinimum) / range);
                pointLayout.NormalizedDistance = Math.Max(0, Math.Min(1, pointLayout.NormalizedDistance));
            }

            // Calculate position
            pointLayout.Position = layout.ValueToPosition(point.YValue, angle);

            // Marker info
            var markerStyle = point.MarkerStyle != ChartMarkerStyle.None
                ? point.MarkerStyle
                : series.MarkerStyle;
            var markerSize = point.MarkerSize > 0 ? point.MarkerSize : series.MarkerSize;

            pointLayout.MarkerStyle = markerStyle;
            pointLayout.MarkerSize = new ChartSizeF(markerSize, markerSize);
        }

        return pointLayout;
    }
}
