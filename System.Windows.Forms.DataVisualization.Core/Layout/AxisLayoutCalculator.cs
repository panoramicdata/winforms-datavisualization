// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Calculates axis layout including labels, tick marks, and positioning.
/// </summary>
public class AxisLayoutCalculator
{
    private readonly ITextMeasurer _textMeasurer;

    /// <summary>
    /// Default margin around axes in pixels.
    /// </summary>
    private const float DefaultAxisMargin = 5f;

    /// <summary>
    /// Default tick mark length in pixels.
    /// </summary>
    private const float DefaultTickLength = 5f;

    /// <summary>
    /// Default font for axis labels.
    /// </summary>
    private static readonly ChartFont DefaultAxisFont = new("Arial", 10, ChartFontStyle.Regular);

    /// <summary>
    /// Creates a new AxisLayoutCalculator with the default text measurer.
    /// </summary>
    public AxisLayoutCalculator()
        : this(DefaultTextMeasurer.Instance)
    {
    }

    /// <summary>
    /// Creates a new AxisLayoutCalculator with the specified text measurer.
    /// </summary>
    /// <param name="textMeasurer">The text measurer to use for layout calculations.</param>
    public AxisLayoutCalculator(ITextMeasurer textMeasurer)
    {
        _textMeasurer = textMeasurer ?? DefaultTextMeasurer.Instance;
    }

    /// <summary>
    /// Calculates the layout for an axis.
    /// </summary>
    /// <param name="axis">The axis model.</param>
    /// <param name="isVertical">Whether this is a vertical (Y) axis.</param>
    /// <param name="plotAreaSize">The size of the plot area.</param>
    /// <param name="dataMinimum">The minimum data value (if auto-scaling).</param>
    /// <param name="dataMaximum">The maximum data value (if auto-scaling).</param>
    /// <returns>The calculated axis layout.</returns>
    public AxisLayout Calculate(
        IAxisModel? axis,
        bool isVertical,
        float plotAreaSize,
        double dataMinimum,
        double dataMaximum)
    {
        var layout = new AxisLayout
        {
            Axis = axis,
            IsVertical = isVertical,
            IsEnabled = axis?.Enabled ?? false
        };

        if (axis == null || !axis.Enabled)
        {
            layout.TotalSize = 0;
            return layout;
        }

        // Determine axis range
        layout.Minimum = axis.Minimum;
        layout.Maximum = axis.Maximum;

        // If min/max are not set, use data range with nice rounding
        if (double.IsNaN(layout.Minimum) || layout.Minimum == 0 && layout.Maximum == 0)
        {
            layout.Minimum = dataMinimum;
        }
        if (double.IsNaN(layout.Maximum) || layout.Minimum == 0 && layout.Maximum == 0)
        {
            layout.Maximum = dataMaximum;
        }

        // Ensure we have a valid range
        if (layout.Minimum >= layout.Maximum)
        {
            layout.Maximum = layout.Minimum + 1;
        }

        // Apply margin if configured
        if (axis.IsMarginVisible)
        {
            double range = layout.Maximum - layout.Minimum;
            double margin = range * 0.05; // 5% margin
            layout.Minimum -= margin;
            layout.Maximum += margin;
        }

        // Calculate interval
        layout.Interval = axis.Interval;
        if (double.IsNaN(layout.Interval) || layout.Interval <= 0)
        {
            layout.Interval = CalculateNiceInterval(layout.Minimum, layout.Maximum);
        }

        // Calculate tick positions
        CalculateTicks(layout, plotAreaSize);

        // Calculate labels
        CalculateLabels(layout, axis, plotAreaSize);

        // Calculate total size needed for this axis
        layout.TotalSize = CalculateTotalSize(layout, axis, isVertical);

        return layout;
    }

    /// <summary>
    /// Calculates a "nice" interval for the axis based on the data range.
    /// </summary>
    private static double CalculateNiceInterval(double minimum, double maximum)
    {
        double range = maximum - minimum;
        if (range <= 0)
            return 1;

        // Target approximately 5-10 intervals
        double roughInterval = range / 7;

        // Find the magnitude of the interval
        double magnitude = Math.Pow(10, Math.Floor(Math.Log10(roughInterval)));

        // Normalize to 1-10 range
        double normalized = roughInterval / magnitude;

        // Round to nice values: 1, 2, 5, 10
        double niceNormalized;
        if (normalized <= 1.5)
            niceNormalized = 1;
        else if (normalized <= 3)
            niceNormalized = 2;
        else if (normalized <= 7)
            niceNormalized = 5;
        else
            niceNormalized = 10;

        return niceNormalized * magnitude;
    }

    /// <summary>
    /// Rounds a value to a nice number for axis minimum/maximum.
    /// </summary>
    private static double RoundToNice(double value, bool roundDown)
    {
        if (value == 0)
            return 0;

        double magnitude = Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(value))));
        double normalized = value / magnitude;

        double rounded;
        if (roundDown)
            rounded = Math.Floor(normalized);
        else
            rounded = Math.Ceiling(normalized);

        return rounded * magnitude;
    }

    /// <summary>
    /// Calculates tick mark positions.
    /// </summary>
    private static void CalculateTicks(AxisLayout layout, float plotAreaSize)
    {
        layout.Ticks.Clear();

        if (layout.Interval <= 0 || plotAreaSize <= 0)
            return;

        // Start from first tick at or after minimum
        double firstTick = Math.Ceiling(layout.Minimum / layout.Interval) * layout.Interval;

        // Generate ticks
        for (double value = firstTick; value <= layout.Maximum + layout.Interval * 0.001; value += layout.Interval)
        {
            float pixelPos = layout.ValueToPixel(value, 0, plotAreaSize);

            layout.Ticks.Add(new AxisTickLayout
            {
                Value = value,
                PixelPosition = pixelPos,
                IsMajor = true
            });

            // Safety limit
            if (layout.Ticks.Count > 100)
                break;
        }
    }

    /// <summary>
    /// Calculates label positions and text.
    /// </summary>
    private void CalculateLabels(AxisLayout layout, IAxisModel axis, float plotAreaSize)
    {
        layout.Labels.Clear();

        if (!axis.ShowLabels || plotAreaSize <= 0)
            return;

        // Use custom labels if provided
        if (axis.CustomLabels.Count > 0)
        {
            CalculateCustomLabels(layout, axis, plotAreaSize);
            return;
        }

        // Generate labels at tick positions
        var labelFont = axis.Font ?? DefaultAxisFont;
        
        foreach (var tick in layout.Ticks)
        {
            string text = FormatLabelValue(tick.Value, layout.Interval);
            var textSize = _textMeasurer.MeasureString(text, labelFont);

            var label = new AxisLabelLayout
            {
                Value = tick.Value,
                Text = text,
                Position = layout.IsVertical
                    ? new ChartPointF(0, tick.PixelPosition)
                    : new ChartPointF(tick.PixelPosition, 0)
            };

            // Use measured label bounds
            float labelWidth = textSize.Width;
            float labelHeight = textSize.Height;

            if (layout.IsVertical)
            {
                // Label to the left of axis
                label.Bounds = new ChartRectangleF(
                    -labelWidth - DefaultAxisMargin,
                    tick.PixelPosition - labelHeight / 2,
                    labelWidth,
                    labelHeight);
            }
            else
            {
                // Label below axis
                label.Bounds = new ChartRectangleF(
                    tick.PixelPosition - labelWidth / 2,
                    DefaultAxisMargin,
                    labelWidth,
                    labelHeight);
            }

            layout.Labels.Add(label);
        }
    }

    /// <summary>
    /// Calculates labels from custom label list.
    /// </summary>
    private void CalculateCustomLabels(AxisLayout layout, IAxisModel axis, float plotAreaSize)
    {
        int labelCount = axis.CustomLabels.Count;
        if (labelCount == 0)
            return;

        var labelFont = axis.Font ?? DefaultAxisFont;

        for (int i = 0; i < labelCount; i++)
        {
            // Distribute labels evenly across the axis
            double value = layout.Minimum + (layout.Maximum - layout.Minimum) * i / Math.Max(1, labelCount - 1);
            float pixelPos = layout.ValueToPixel(value, 0, plotAreaSize);

            string text = axis.CustomLabels[i];
            var textSize = _textMeasurer.MeasureString(text, labelFont);
            float labelWidth = textSize.Width;
            float labelHeight = textSize.Height;

            var label = new AxisLabelLayout
            {
                Value = value,
                Text = text,
                Position = layout.IsVertical
                    ? new ChartPointF(0, pixelPos)
                    : new ChartPointF(pixelPos, 0)
            };

            if (layout.IsVertical)
            {
                label.Bounds = new ChartRectangleF(
                    -labelWidth - DefaultAxisMargin,
                    pixelPos - labelHeight / 2,
                    labelWidth,
                    labelHeight);
            }
            else
            {
                label.Bounds = new ChartRectangleF(
                    pixelPos - labelWidth / 2,
                    DefaultAxisMargin,
                    labelWidth,
                    labelHeight);
            }

            layout.Labels.Add(label);
        }
    }

    /// <summary>
    /// Formats a numeric value for display as a label.
    /// </summary>
    private static string FormatLabelValue(double value, double interval)
    {
        // Determine appropriate decimal places based on interval
        int decimals = 0;
        if (interval < 1)
        {
            decimals = (int)Math.Ceiling(-Math.Log10(interval));
        }

        // Handle very small values near zero
        if (Math.Abs(value) < interval * 0.0001)
            value = 0;

        return decimals > 0
            ? value.ToString($"F{decimals}")
            : value.ToString("G");
    }

    /// <summary>
    /// Calculates the total size needed for this axis (labels + title + tick marks).
    /// </summary>
    private float CalculateTotalSize(AxisLayout layout, IAxisModel axis, bool isVertical)
    {
        if (!layout.IsEnabled)
            return 0;

        float size = DefaultAxisMargin;
        var labelFont = axis.Font ?? DefaultAxisFont;

        // Tick marks
        if (axis.ShowTickMarks)
            size += DefaultTickLength;

        // Labels
        if (axis.ShowLabels && layout.Labels.Count > 0)
        {
            if (isVertical)
            {
                // Find widest label
                float maxWidth = 0;
                foreach (var label in layout.Labels)
                {
                    maxWidth = Math.Max(maxWidth, label.Bounds.Width);
                }
                size += maxWidth + DefaultAxisMargin;
            }
            else
            {
                // Use measured label height
                if (layout.Labels.Count > 0)
                {
                    size += layout.Labels[0].Bounds.Height + DefaultAxisMargin;
                }
                else
                {
                    var sampleSize = _textMeasurer.MeasureString("0", labelFont);
                    size += sampleSize.Height + DefaultAxisMargin;
                }
            }
        }

        // Title
        if (!string.IsNullOrEmpty(axis.Title))
        {
            var titleFont = axis.TitleFont ?? new ChartFont("Arial", 12, ChartFontStyle.Bold);
            var titleSize = _textMeasurer.MeasureString(axis.Title, titleFont);
            size += titleSize.Height + DefaultAxisMargin;
        }

        return size;
    }

    /// <summary>
    /// Updates label positions after the plot area position is finalized.
    /// </summary>
    /// <param name="layout">The axis layout to update.</param>
    /// <param name="plotArea">The finalized plot area bounds.</param>
    public void UpdatePositions(AxisLayout layout, ChartRectangleF plotArea)
    {
        if (!layout.IsEnabled)
            return;

        float plotStart, plotSize;

        if (layout.IsVertical)
        {
            plotStart = plotArea.Y;
            plotSize = plotArea.Height;
        }
        else
        {
            plotStart = plotArea.X;
            plotSize = plotArea.Width;
        }

        // Update tick positions
        foreach (var tick in layout.Ticks)
        {
            tick.PixelPosition = layout.ValueToPixel(tick.Value, plotStart, plotSize);
        }

        // Update label positions
        foreach (var label in layout.Labels)
        {
            float pixelPos = layout.ValueToPixel(label.Value, plotStart, plotSize);

            if (layout.IsVertical)
            {
                // Labels to the left of plot area
                label.Position = new ChartPointF(plotArea.X - DefaultAxisMargin, pixelPos);
                label.Bounds = new ChartRectangleF(
                    plotArea.X - label.Bounds.Width - DefaultAxisMargin,
                    pixelPos - label.Bounds.Height / 2,
                    label.Bounds.Width,
                    label.Bounds.Height);
            }
            else
            {
                // Labels below plot area
                label.Position = new ChartPointF(pixelPos, plotArea.Bottom + DefaultAxisMargin);
                label.Bounds = new ChartRectangleF(
                    pixelPos - label.Bounds.Width / 2,
                    plotArea.Bottom + DefaultAxisMargin,
                    label.Bounds.Width,
                    label.Bounds.Height);
            }
        }
    }
}
