// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
    /// Main chart renderer that uses <see cref="IRenderingEngine"/> to render
    /// a chart based on a pre-calculated <see cref="ChartLayout"/>.
    /// This ensures identical output across all rendering targets (GDI+, SVG, etc.).
    /// </summary>
public class ChartRenderer
{
    private readonly AxisRenderer _axisRenderer;
    private readonly LegendRenderer _legendRenderer;
    private readonly SeriesRendererFactory _seriesRendererFactory;

    /// <summary>
    /// Initializes a new instance of the <see cref="ChartRenderer"/> class.
    /// </summary>
    public ChartRenderer()
    {
        _axisRenderer = new AxisRenderer();
        _legendRenderer = new LegendRenderer();
        _seriesRendererFactory = new SeriesRendererFactory();
    }

    /// <summary>
    /// Renders a chart using the provided rendering engine and layout.
    /// </summary>
    /// <param name="engine">The rendering engine.</param>
    /// <param name="chart">The chart model.</param>
    /// <param name="layout">The pre-calculated layout.</param>
    public void Render(IRenderingEngine engine, IChartModel chart, ChartLayout layout)
    {
        ArgumentNullException.ThrowIfNull(engine);
        ArgumentNullException.ThrowIfNull(chart);
        ArgumentNullException.ThrowIfNull(layout);

        // 1. Render background
        RenderBackground(engine, chart, layout);

        // 2. Render title
        if (!string.IsNullOrEmpty(chart.Title))
        {
            RenderTitle(engine, chart, layout);
        }

        // 3. Render legend
        if (chart.ShowLegend && chart.Series.Count > 0)
        {
            _legendRenderer.Render(engine, chart, layout);
        }

        // 4. Render each chart area
        foreach (var areaLayout in layout.ChartAreaLayouts)
        {
            RenderChartArea(engine, chart, areaLayout);
        }
    }

    /// <summary>
    /// Renders the chart background.
    /// </summary>
    private static void RenderBackground(IRenderingEngine engine, IChartModel chart, ChartLayout layout)
    {
        if (chart.BackColor.IsEmpty)
            return;

        ChartBrush brush;
        if (chart.BackGradientStyle != ChartGradientStyle.None && !chart.BackSecondaryColor.IsEmpty)
        {
            brush = CreateGradientBrush(
                new ChartRectangleF(0, 0, layout.Size.Width, layout.Size.Height),
                chart.BackColor,
                chart.BackSecondaryColor,
                chart.BackGradientStyle);
        }
        else
        {
            brush = new ChartSolidBrush(chart.BackColor);
        }

        using (brush)
        {
            engine.FillRectangle(brush, 0, 0, layout.Size.Width, layout.Size.Height);
        }
    }

    /// <summary>
    /// Renders the chart title.
    /// </summary>
    private static void RenderTitle(IRenderingEngine engine, IChartModel chart, ChartLayout layout)
    {
        if (layout.TitleBounds.IsEmpty)
            return;

        using var brush = new ChartSolidBrush(chart.TitleColor.IsEmpty ? ChartColor.Black : chart.TitleColor);
        var format = new ChartStringFormat
        {
            Alignment = ChartStringAlignment.Center,
            LineAlignment = ChartStringAlignment.Center
        };

        engine.DrawString(
            chart.Title,
            chart.TitleFont,
            brush,
            layout.TitleBounds,
            format);
    }

    /// <summary>
    /// Renders a chart area including axes, grid, and series.
    /// </summary>
    private void RenderChartArea(IRenderingEngine engine, IChartModel chart, ChartAreaLayout areaLayout)
    {
        // Check if this is a circular chart area
        if (areaLayout is CircularChartAreaLayout circularLayout)
        {
            RenderCircularChartArea(engine, chart, circularLayout);
            return;
        }

        // 1. Render chart area background
        RenderChartAreaBackground(engine, areaLayout);

        // 2. Render grid lines (before series, so they're behind data)
        if (areaLayout.ShowGrid)
        {
            RenderGridLines(engine, areaLayout);
        }

        // 3. Render axes
        if (areaLayout.AxisXLayout != null)
        {
            _axisRenderer.Render(engine, areaLayout.AxisXLayout, areaLayout.PlotAreaBounds, false);
        }
        if (areaLayout.AxisYLayout != null)
        {
            _axisRenderer.Render(engine, areaLayout.AxisYLayout, areaLayout.PlotAreaBounds, true);
        }
        if (areaLayout.AxisX2Layout != null)
        {
            _axisRenderer.Render(engine, areaLayout.AxisX2Layout, areaLayout.PlotAreaBounds, false, isSecondary: true);
        }
        if (areaLayout.AxisY2Layout != null)
        {
            _axisRenderer.Render(engine, areaLayout.AxisY2Layout, areaLayout.PlotAreaBounds, true, isSecondary: true);
        }

        // 4. Set clip to plot area for series rendering
        var state = engine.Save();
        engine.SetClip(areaLayout.PlotAreaBounds);

        // 5. Render each series
        foreach (var seriesLayout in areaLayout.SeriesLayouts)
        {
            var renderer = _seriesRendererFactory.GetRenderer(seriesLayout.ChartType);
            renderer.Render(engine, seriesLayout, areaLayout);
        }

        engine.Restore(state);

        // 6. Render data labels (after series, on top)
        foreach (var seriesLayout in areaLayout.SeriesLayouts)
        {
            RenderDataLabels(engine, seriesLayout);
        }
    }

    /// <summary>
    /// Renders the chart area background.
    /// </summary>
    private static void RenderChartAreaBackground(IRenderingEngine engine, ChartAreaLayout areaLayout)
    {
        if (areaLayout.BackColor.IsEmpty)
            return;

        ChartBrush brush;
        if (areaLayout.BackGradientStyle != ChartGradientStyle.None && !areaLayout.BackSecondaryColor.IsEmpty)
        {
            brush = CreateGradientBrush(
                areaLayout.PlotAreaBounds,
                areaLayout.BackColor,
                areaLayout.BackSecondaryColor,
                areaLayout.BackGradientStyle);
        }
        else
        {
            brush = new ChartSolidBrush(areaLayout.BackColor);
        }

        using (brush)
        {
            engine.FillRectangle(brush, areaLayout.PlotAreaBounds);
        }
    }

    /// <summary>
    /// Renders a circular chart area (Radar, Polar).
    /// </summary>
    private void RenderCircularChartArea(IRenderingEngine engine, IChartModel chart, CircularChartAreaLayout layout)
    {
        // 1. Render circular background
        RenderCircularBackground(engine, layout);

        // 2. Render circular grid (concentric circles or polygons)
        if (layout.ShowGrid)
        {
            RenderCircularGrid(engine, layout);
        }

        // 3. Render spokes (radial axes)
        RenderSpokes(engine, layout);

        // 4. Render axis labels
        RenderCircularLabels(engine, layout);

        // 5. Render each series (no clipping needed for circular charts)
        foreach (var seriesLayout in layout.SeriesLayouts)
        {
            var renderer = _seriesRendererFactory.GetRenderer(seriesLayout.ChartType);
            renderer.Render(engine, seriesLayout, layout);
        }

        // 6. Render data labels (after series, on top)
        foreach (var seriesLayout in layout.SeriesLayouts)
        {
            RenderDataLabels(engine, seriesLayout);
        }
    }

    /// <summary>
    /// Renders the circular chart background.
    /// </summary>
    private static void RenderCircularBackground(IRenderingEngine engine, CircularChartAreaLayout layout)
    {
        if (layout.BackColor.IsEmpty)
            return;

        ChartBrush brush;
        if (layout.BackGradientStyle != ChartGradientStyle.None && !layout.BackSecondaryColor.IsEmpty)
        {
            brush = CreateGradientBrush(
                layout.PlotAreaBounds,
                layout.BackColor,
                layout.BackSecondaryColor,
                layout.BackGradientStyle);
        }
        else
        {
            brush = new ChartSolidBrush(layout.BackColor);
        }

        using (brush)
        {
            if (layout.UsePolygons && layout.SectorCount > 2)
            {
                // Draw polygon background
                var points = new ChartPointF[layout.SectorCount];
                for (int i = 0; i < layout.SectorCount; i++)
                {
                    points[i] = layout.ValueToPosition(layout.YAxisMaximum, layout.IndexToAngle(i));
                }
                engine.FillPolygon(brush, points);
            }
            else
            {
                // Draw circle background
                var rect = new ChartRectangleF(
                    layout.Center.X - layout.Radius,
                    layout.Center.Y - layout.Radius,
                    layout.Radius * 2,
                    layout.Radius * 2);
                engine.FillEllipse(brush, rect);
            }
        }
    }

    /// <summary>
    /// Renders the circular grid (concentric circles or polygons).
    /// </summary>
    private static void RenderCircularGrid(IRenderingEngine engine, CircularChartAreaLayout layout)
    {
        using var pen = new ChartPen(layout.GridColor, 1f)
        {
            DashStyle = ChartDashStyle.Dot
        };

        foreach (var grid in layout.GridLines)
        {
            if (layout.UsePolygons && grid.PolygonPoints.Count > 2)
            {
                // Draw polygon grid line
                engine.DrawPolygon(pen, grid.PolygonPoints.ToArray());
            }
            else
            {
                // Draw circular grid line
                var rect = new ChartRectangleF(
                    layout.Center.X - grid.Radius,
                    layout.Center.Y - grid.Radius,
                    grid.Radius * 2,
                    grid.Radius * 2);
                engine.DrawEllipse(pen, rect);
            }
        }
    }

    /// <summary>
    /// Renders the spokes (radial axes from center to edge).
    /// </summary>
    private static void RenderSpokes(IRenderingEngine engine, CircularChartAreaLayout layout)
    {
        using var pen = new ChartPen(layout.GridColor, 1f);

        foreach (var axis in layout.CircularAxes)
        {
            engine.DrawLine(pen, axis.StartPosition, axis.EndPosition);
        }
    }

    /// <summary>
    /// Renders the labels around the circular chart.
    /// </summary>
    private static void RenderCircularLabels(IRenderingEngine engine, CircularChartAreaLayout layout)
    {
        var font = new ChartFont("Arial", 10, ChartFontStyle.Regular);
        
        foreach (var axis in layout.CircularAxes)
        {
            if (string.IsNullOrEmpty(axis.Label))
                continue;

            using var brush = new ChartSolidBrush(axis.LabelColor);
            
            // Determine text alignment based on angle
            var format = new ChartStringFormat();
            
            // Calculate label alignment based on position around the circle
            // 0 degrees is at top, going clockwise
            float angle = axis.Angle % 360;
            
            if (angle >= 315 || angle < 45)
            {
                // Top: center horizontally, align to bottom
                format.Alignment = ChartStringAlignment.Center;
                format.LineAlignment = ChartStringAlignment.Far;
            }
            else if (angle >= 45 && angle < 135)
            {
                // Right: align left, center vertically  
                format.Alignment = ChartStringAlignment.Near;
                format.LineAlignment = ChartStringAlignment.Center;
            }
            else if (angle >= 135 && angle < 225)
            {
                // Bottom: center horizontally, align to top
                format.Alignment = ChartStringAlignment.Center;
                format.LineAlignment = ChartStringAlignment.Near;
            }
            else
            {
                // Left: align right, center vertically
                format.Alignment = ChartStringAlignment.Far;
                format.LineAlignment = ChartStringAlignment.Center;
            }

            engine.DrawString(axis.Label, font, brush, axis.LabelPosition, format);
        }
    }

    /// <summary>
    /// Creates a gradient brush based on the gradient style.
    /// </summary>
    private static ChartBrush CreateGradientBrush(
        ChartRectangleF rect,
        ChartColor color1,
        ChartColor color2,
        ChartGradientStyle gradientStyle)
    {
        var mode = gradientStyle switch
        {
            ChartGradientStyle.LeftRight => ChartLinearGradientMode.Horizontal,
            ChartGradientStyle.TopBottom => ChartLinearGradientMode.Vertical,
            ChartGradientStyle.DiagonalLeft => ChartLinearGradientMode.ForwardDiagonal,
            ChartGradientStyle.DiagonalRight => ChartLinearGradientMode.BackwardDiagonal,
            // For Center, HorizontalCenter, VerticalCenter - use vertical as default
            // (more complex radial gradients would need additional support)
            _ => ChartLinearGradientMode.Vertical
        };

        return new ChartLinearGradientBrush(rect, color1, color2, mode);
    }

    /// <summary>
    /// Renders grid lines within the plot area.
    /// </summary>
    private static void RenderGridLines(IRenderingEngine engine, ChartAreaLayout areaLayout)
    {
        var plotArea = areaLayout.PlotAreaBounds;
        using var pen = new ChartPen(areaLayout.GridColor, 1f)
        {
            DashStyle = ChartDashStyle.Dot
        };

        // Vertical grid lines (from X axis ticks)
        if (areaLayout.AxisXLayout != null)
        {
            foreach (var tick in areaLayout.AxisXLayout.Ticks)
            {
                if (tick.IsMajor)
                {
                    engine.DrawLine(pen,
                        tick.PixelPosition, plotArea.Top,
                        tick.PixelPosition, plotArea.Bottom);
                }
            }
        }

        // Horizontal grid lines (from Y axis ticks)
        if (areaLayout.AxisYLayout != null)
        {
            foreach (var tick in areaLayout.AxisYLayout.Ticks)
            {
                if (tick.IsMajor)
                {
                    engine.DrawLine(pen,
                        plotArea.Left, tick.PixelPosition,
                        plotArea.Right, tick.PixelPosition);
                }
            }
        }
    }

    /// <summary>
    /// Renders data labels for a series.
    /// </summary>
    private static void RenderDataLabels(IRenderingEngine engine, SeriesLayout seriesLayout)
    {
        var series = seriesLayout.Series;
        if (series == null || !series.IsValueShownAsLabel)
            return;

        var font = series.LabelFont;
        using var brush = new ChartSolidBrush(
            series.LabelForeColor.IsEmpty ? ChartColor.Black : series.LabelForeColor);

        var format = new ChartStringFormat
        {
            Alignment = ChartStringAlignment.Center,
            LineAlignment = ChartStringAlignment.Far
        };

        foreach (var pointLayout in seriesLayout.PointLayouts)
        {
            if (pointLayout.IsEmpty)
                continue;

            string label = !string.IsNullOrEmpty(pointLayout.Label)
                ? pointLayout.Label
                : FormatValue(pointLayout.YValue, series.LabelFormat);

            if (!string.IsNullOrEmpty(label))
            {
                // Position label above the data point
                var labelPosition = new ChartPointF(
                    pointLayout.Position.X,
                    pointLayout.Position.Y - 5);

                engine.DrawString(label, font, brush, labelPosition, format);
            }
        }
    }

    /// <summary>
    /// Formats a value using the specified format string.
    /// </summary>
    private static string FormatValue(double value, string format)
    {
        if (string.IsNullOrEmpty(format))
            return value.ToString("G");

        try
        {
            return value.ToString(format);
        }
        catch
        {
            return value.ToString("G");
        }
    }
}
