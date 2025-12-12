// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders the chart legend including the box, items, symbols, and text.
/// </summary>
public class LegendRenderer
{
    /// <summary>
    /// Padding inside the legend box.
    /// </summary>
    private const float LegendPadding = 8f;

    /// <summary>
    /// Size of the color symbol.
    /// </summary>
    private const float SymbolSize = 12f;

    /// <summary>
    /// Gap between symbol and text.
    /// </summary>
    private const float SymbolTextGap = 6f;

    /// <summary>
    /// Height of each legend item.
    /// </summary>
    private const float ItemHeight = 18f;

    /// <summary>
    /// Renders the legend.
    /// </summary>
    /// <param name="engine">The rendering engine.</param>
    /// <param name="chart">The chart model.</param>
    /// <param name="layout">The chart layout.</param>
    public void Render(IRenderingEngine engine, IChartModel chart, ChartLayout layout)
    {
        if (layout.LegendBounds.IsEmpty || chart.Series.Count == 0)
            return;

        // Draw legend background
        RenderLegendBackground(engine, layout.LegendBounds);

        // Draw legend border
        RenderLegendBorder(engine, layout.LegendBounds);

        // Draw legend items
        RenderLegendItems(engine, chart, layout);
    }

    /// <summary>
    /// Renders the legend background.
    /// </summary>
    private static void RenderLegendBackground(IRenderingEngine engine, ChartRectangleF bounds)
    {
        using var brush = new ChartSolidBrush(ChartColor.FromArgb(250, 250, 250));
        engine.FillRectangle(brush, bounds);
    }

    /// <summary>
    /// Renders the legend border.
    /// </summary>
    private static void RenderLegendBorder(IRenderingEngine engine, ChartRectangleF bounds)
    {
        using var pen = new ChartPen(ChartColor.FromArgb(200, 200, 200), 1f);
        engine.DrawRectangle(pen, bounds);
    }

    /// <summary>
    /// Renders legend items for each series.
    /// </summary>
    private static void RenderLegendItems(IRenderingEngine engine, IChartModel chart, ChartLayout layout)
    {
        var bounds = layout.LegendBounds;
        bool isHorizontal = chart.LegendPosition == ChartLegendPosition.Top ||
                           chart.LegendPosition == ChartLegendPosition.Bottom;

        float currentX = bounds.X + LegendPadding;
        float currentY = bounds.Y + LegendPadding;

        var font = chart.Series.Count > 0 ? chart.Series[0].LabelFont : new ChartFont("Arial", 9);
        using var textBrush = new ChartSolidBrush(ChartColor.Black);

        var format = new ChartStringFormat
        {
            Alignment = ChartStringAlignment.Near,
            LineAlignment = ChartStringAlignment.Center
        };

        foreach (var series in chart.Series)
        {
            if (!series.IsVisible)
                continue;

            var seriesColor = series.Color.IsEmpty ? ChartColor.Gray : series.Color;

            // Calculate item width
            float textWidth = series.Name.Length * 7f; // Approximate
            float itemWidth = SymbolSize + SymbolTextGap + textWidth + LegendPadding;

            // Check if we need to wrap to next row/column
            if (isHorizontal)
            {
                if (currentX + itemWidth > bounds.Right - LegendPadding)
                {
                    currentX = bounds.X + LegendPadding;
                    currentY += ItemHeight;
                }
            }
            else
            {
                if (currentY + ItemHeight > bounds.Bottom - LegendPadding)
                {
                    // Skip if no more room
                    break;
                }
            }

            // Draw symbol
            var symbolBounds = new ChartRectangleF(
                currentX,
                currentY + (ItemHeight - SymbolSize) / 2,
                SymbolSize,
                SymbolSize);

            RenderLegendSymbol(engine, series, symbolBounds, seriesColor);

            // Draw text
            var textPosition = new ChartPointF(
                currentX + SymbolSize + SymbolTextGap,
                currentY + ItemHeight / 2);

            engine.DrawString(series.Name, font, textBrush, textPosition, format);

            // Move to next item
            if (isHorizontal)
            {
                currentX += itemWidth;
            }
            else
            {
                currentY += ItemHeight;
            }
        }
    }

    /// <summary>
    /// Renders a legend symbol based on the series chart type.
    /// </summary>
    private static void RenderLegendSymbol(
        IRenderingEngine engine,
        ISeriesModel series,
        ChartRectangleF bounds,
        ChartColor color)
    {
        using var fillBrush = new ChartSolidBrush(color);
        using var linePen = new ChartPen(color, 2f);

        string chartType = series.ChartType.ToUpperInvariant();

        if (chartType.Contains("LINE") || chartType.Contains("SPLINE"))
        {
            // Line symbol: horizontal line with optional marker
            float y = bounds.Y + bounds.Height / 2;
            engine.DrawLine(linePen, bounds.Left, y, bounds.Right, y);

            if (series.ShowMarkers && series.MarkerStyle != ChartMarkerStyle.None)
            {
                float markerSize = Math.Min(bounds.Width, bounds.Height) * 0.6f;
                RenderMarker(engine, series.MarkerStyle, bounds.X + bounds.Width / 2, y, markerSize, color);
            }
        }
        else if (chartType.Contains("PIE") || chartType.Contains("DOUGHNUT"))
        {
            // Pie symbol: filled pie slice
            engine.FillPie(fillBrush, bounds.X, bounds.Y, bounds.Width, bounds.Height, 0, 270);
            using var borderPen = new ChartPen(ChartColor.FromArgb(100, 100, 100), 1f);
            engine.DrawPie(borderPen, bounds.X, bounds.Y, bounds.Width, bounds.Height, 0, 270);
        }
        else if (chartType.Contains("AREA"))
        {
            // Area symbol: filled triangle
            var points = new[]
            {
                new ChartPointF(bounds.Left, bounds.Bottom),
                new ChartPointF(bounds.Left + bounds.Width / 2, bounds.Top),
                new ChartPointF(bounds.Right, bounds.Bottom)
            };
            engine.FillPolygon(fillBrush, points);
        }
        else if (chartType.Contains("POINT") || chartType.Contains("SCATTER") || chartType.Contains("BUBBLE"))
        {
            // Point symbol: circle
            engine.FillEllipse(fillBrush, bounds);
        }
        else
        {
            // Default: filled rectangle (for bar, column, etc.)
            engine.FillRectangle(fillBrush, bounds);
            using var borderPen = new ChartPen(ChartColor.FromArgb(100, 100, 100), 1f);
            engine.DrawRectangle(borderPen, bounds);
        }
    }

    /// <summary>
    /// Renders a marker at the specified position.
    /// </summary>
    private static void RenderMarker(
        IRenderingEngine engine,
        ChartMarkerStyle style,
        float x,
        float y,
        float size,
        ChartColor color)
    {
        using var brush = new ChartSolidBrush(color);
        using var pen = new ChartPen(color, 1f);

        float halfSize = size / 2;

        switch (style)
        {
            case ChartMarkerStyle.Circle:
                engine.FillEllipse(brush, x - halfSize, y - halfSize, size, size);
                break;

            case ChartMarkerStyle.Square:
                engine.FillRectangle(brush, x - halfSize, y - halfSize, size, size);
                break;

            case ChartMarkerStyle.Diamond:
                var diamondPoints = new[]
                {
                    new ChartPointF(x, y - halfSize),
                    new ChartPointF(x + halfSize, y),
                    new ChartPointF(x, y + halfSize),
                    new ChartPointF(x - halfSize, y)
                };
                engine.FillPolygon(brush, diamondPoints);
                break;

            case ChartMarkerStyle.Triangle:
                var trianglePoints = new[]
                {
                    new ChartPointF(x, y - halfSize),
                    new ChartPointF(x + halfSize, y + halfSize),
                    new ChartPointF(x - halfSize, y + halfSize)
                };
                engine.FillPolygon(brush, trianglePoints);
                break;

            case ChartMarkerStyle.Cross:
                engine.DrawLine(pen, x - halfSize, y, x + halfSize, y);
                engine.DrawLine(pen, x, y - halfSize, x, y + halfSize);
                break;

            default:
                // Default to circle
                engine.FillEllipse(brush, x - halfSize, y - halfSize, size, size);
                break;
        }
    }
}
