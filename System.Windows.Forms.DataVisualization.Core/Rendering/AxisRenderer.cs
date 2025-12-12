// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Renders axis elements including lines, tick marks, labels, and titles.
/// </summary>
public class AxisRenderer
{
    /// <summary>
    /// Default tick mark length in pixels.
    /// </summary>
    private const float TickLength = 5f;

    /// <summary>
    /// Gap between axis elements in pixels.
    /// </summary>
    private const float ElementGap = 3f;

    /// <summary>
    /// Renders an axis.
    /// </summary>
    /// <param name="engine">The rendering engine.</param>
    /// <param name="axisLayout">The axis layout.</param>
    /// <param name="plotArea">The plot area bounds.</param>
    /// <param name="isVertical">Whether this is a vertical (Y) axis.</param>
    /// <param name="isSecondary">Whether this is a secondary axis (right/top).</param>
    public void Render(
        IRenderingEngine engine,
        AxisLayout axisLayout,
        ChartRectangleF plotArea,
        bool isVertical,
        bool isSecondary = false)
    {
        if (!axisLayout.IsEnabled)
            return;

        var axis = axisLayout.Axis;
        var lineColor = axis?.LineColor ?? ChartColor.Black;
        var lineWidth = axis?.LineWidth ?? 1f;

        using var linePen = new ChartPen(lineColor, lineWidth);

        // Draw axis line
        RenderAxisLine(engine, linePen, plotArea, isVertical, isSecondary);

        // Draw tick marks
        RenderTickMarks(engine, linePen, axisLayout, plotArea, isVertical, isSecondary);

        // Draw labels
        if (axis?.ShowLabels == true)
        {
            RenderLabels(engine, axisLayout, plotArea, isVertical, isSecondary);
        }

        // Draw axis title
        if (!string.IsNullOrEmpty(axis?.Title))
        {
            RenderTitle(engine, axisLayout, plotArea, isVertical, isSecondary);
        }
    }

    /// <summary>
    /// Renders the axis line.
    /// </summary>
    private static void RenderAxisLine(
        IRenderingEngine engine,
        ChartPen pen,
        ChartRectangleF plotArea,
        bool isVertical,
        bool isSecondary)
    {
        if (isVertical)
        {
            float x = isSecondary ? plotArea.Right : plotArea.Left;
            engine.DrawLine(pen, x, plotArea.Top, x, plotArea.Bottom);
        }
        else
        {
            float y = isSecondary ? plotArea.Top : plotArea.Bottom;
            engine.DrawLine(pen, plotArea.Left, y, plotArea.Right, y);
        }
    }

    /// <summary>
    /// Renders tick marks along the axis.
    /// </summary>
    private static void RenderTickMarks(
        IRenderingEngine engine,
        ChartPen pen,
        AxisLayout axisLayout,
        ChartRectangleF plotArea,
        bool isVertical,
        bool isSecondary)
    {
        if (axisLayout.Axis?.ShowTickMarks != true)
            return;

        foreach (var tick in axisLayout.Ticks)
        {
            float tickLen = tick.IsMajor ? TickLength : TickLength / 2;

            if (isVertical)
            {
                float x = isSecondary ? plotArea.Right : plotArea.Left;
                float direction = isSecondary ? 1 : -1;
                engine.DrawLine(pen,
                    x, tick.PixelPosition,
                    x + direction * tickLen, tick.PixelPosition);
            }
            else
            {
                float y = isSecondary ? plotArea.Top : plotArea.Bottom;
                float direction = isSecondary ? -1 : 1;
                engine.DrawLine(pen,
                    tick.PixelPosition, y,
                    tick.PixelPosition, y + direction * tickLen);
            }
        }
    }

    /// <summary>
    /// Renders axis labels.
    /// </summary>
    private static void RenderLabels(
        IRenderingEngine engine,
        AxisLayout axisLayout,
        ChartRectangleF plotArea,
        bool isVertical,
        bool isSecondary)
    {
        var axis = axisLayout.Axis;
        if (axis == null)
            return;

        var font = axis.LabelFont;
        using var brush = new ChartSolidBrush(
            axis.LabelColor.IsEmpty ? ChartColor.Black : axis.LabelColor);

        foreach (var label in axisLayout.Labels)
        {
            var format = new ChartStringFormat();

            ChartPointF position;

            if (isVertical)
            {
                // Y axis: labels to the left/right of the axis
                if (isSecondary)
                {
                    position = new ChartPointF(
                        plotArea.Right + TickLength + ElementGap,
                        label.Position.Y);
                    format.Alignment = ChartStringAlignment.Near;
                }
                else
                {
                    position = new ChartPointF(
                        plotArea.Left - TickLength - ElementGap,
                        label.Position.Y);
                    format.Alignment = ChartStringAlignment.Far;
                }
                format.LineAlignment = ChartStringAlignment.Center;
            }
            else
            {
                // X axis: labels below/above the axis
                if (isSecondary)
                {
                    position = new ChartPointF(
                        label.Position.X,
                        plotArea.Top - TickLength - ElementGap);
                    format.LineAlignment = ChartStringAlignment.Far;
                }
                else
                {
                    position = new ChartPointF(
                        label.Position.X,
                        plotArea.Bottom + TickLength + ElementGap);
                    format.LineAlignment = ChartStringAlignment.Near;
                }
                format.Alignment = ChartStringAlignment.Center;
            }

            engine.DrawString(label.Text, font, brush, position, format);
        }
    }

    /// <summary>
    /// Renders the axis title.
    /// </summary>
    private static void RenderTitle(
        IRenderingEngine engine,
        AxisLayout axisLayout,
        ChartRectangleF plotArea,
        bool isVertical,
        bool isSecondary)
    {
        var axis = axisLayout.Axis;
        if (axis == null || string.IsNullOrEmpty(axis.Title))
            return;

        var font = axis.LabelFont; // Could use a separate title font
        using var brush = new ChartSolidBrush(
            axis.LabelColor.IsEmpty ? ChartColor.Black : axis.LabelColor);

        var format = new ChartStringFormat
        {
            Alignment = ChartStringAlignment.Center,
            LineAlignment = ChartStringAlignment.Center
        };

        if (isVertical)
        {
            // Vertical axis title: rotated 90 degrees
            var state = engine.Save();

            float centerY = plotArea.Top + plotArea.Height / 2;
            float titleX = isSecondary
                ? plotArea.Right + axisLayout.TotalSize - 15
                : plotArea.Left - axisLayout.TotalSize + 15;

            engine.TranslateTransform(titleX, centerY);
            engine.RotateTransform(isSecondary ? 90 : -90);

            engine.DrawString(axis.Title, font, brush, new ChartPointF(0, 0), format);

            engine.Restore(state);
        }
        else
        {
            // Horizontal axis title: below/above labels
            float centerX = plotArea.Left + plotArea.Width / 2;
            float titleY = isSecondary
                ? plotArea.Top - axisLayout.TotalSize + 10
                : plotArea.Bottom + axisLayout.TotalSize - 10;

            engine.DrawString(axis.Title, font, brush, new ChartPointF(centerX, titleY), format);
        }
    }
}
