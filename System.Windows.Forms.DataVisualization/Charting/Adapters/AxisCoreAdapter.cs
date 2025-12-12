// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps a WinForms Axis to implement the platform-agnostic IAxisModel interface.
/// </summary>
public class AxisCoreAdapter : IAxisModel
{
    private readonly Axis _axis;
    private readonly List<string> _customLabels;

    /// <summary>
    /// Creates a new AxisCoreAdapter wrapping the specified Axis.
    /// </summary>
    /// <param name="axis">The WinForms Axis to adapt.</param>
    public AxisCoreAdapter(Axis axis)
    {
        _axis = axis ?? throw new ArgumentNullException(nameof(axis));
        
        // Build custom labels list
        _customLabels = [];
        foreach (CustomLabel label in _axis.CustomLabels)
        {
            _customLabels.Add(label.Text ?? string.Empty);
        }
    }

    /// <summary>
    /// Gets the underlying WinForms Axis.
    /// </summary>
    public Axis Axis => _axis;

    /// <inheritdoc/>
    public bool Enabled => _axis.Enabled != AxisEnabled.False;

    /// <inheritdoc/>
    public string Title => _axis.Title ?? string.Empty;

    /// <inheritdoc/>
    public double Minimum
    {
        get
        {
            // Use view minimum if zoomed, otherwise use axis minimum
            if (!double.IsNaN(_axis.ScaleView.ViewMinimum))
            {
                return _axis.ScaleView.ViewMinimum;
            }
            return _axis.Minimum;
        }
    }

    /// <inheritdoc/>
    public double Maximum
    {
        get
        {
            // Use view maximum if zoomed, otherwise use axis maximum
            if (!double.IsNaN(_axis.ScaleView.ViewMaximum))
            {
                return _axis.ScaleView.ViewMaximum;
            }
            return _axis.Maximum;
        }
    }

    /// <inheritdoc/>
    public double Interval
    {
        get
        {
            // Return the label interval or calculate based on major grid
            if (_axis.Interval > 0)
            {
                return _axis.Interval;
            }
            if (_axis.MajorGrid.Interval > 0)
            {
                return _axis.MajorGrid.Interval;
            }
            // Auto-calculate: divide range into ~5-10 segments
            double range = Maximum - Minimum;
            if (range <= 0)
            {
                return 1.0;
            }
            return CalculateNiceInterval(range, 5);
        }
    }

    /// <inheritdoc/>
    public ChartColor LineColor
    {
        get
        {
            var color = _axis.LineColor;
            if (color.IsEmpty)
            {
                return ChartColor.Black;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public float LineWidth => _axis.LineWidth;

    /// <inheritdoc/>
    public bool ShowMajorGrid => _axis.MajorGrid.Enabled;

    /// <inheritdoc/>
    public bool ShowTickMarks => _axis.MajorTickMark.Enabled;

    /// <inheritdoc/>
    public bool ShowLabels => _axis.LabelStyle.Enabled;

    /// <inheritdoc/>
    public ChartFont LabelFont
    {
        get
        {
            var font = _axis.LabelStyle.Font;
            if (font == null)
            {
                return new ChartFont("Arial", 10);
            }
            return new ChartFont(
                font.FontFamily.Name,
                font.Size,
                ConvertFontStyle(font.Style));
        }
    }

    /// <inheritdoc/>
    public ChartFont? TitleFont
    {
        get
        {
            var font = _axis.TitleFont;
            if (font == null)
            {
                return null;
            }
            return new ChartFont(
                font.FontFamily.Name,
                font.Size,
                ConvertFontStyle(font.Style));
        }
    }

    /// <inheritdoc/>
    public ChartColor LabelColor
    {
        get
        {
            var color = _axis.LabelStyle.ForeColor;
            if (color.IsEmpty)
            {
                return ChartColor.Black;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public IReadOnlyList<string> CustomLabels => _customLabels;

    /// <inheritdoc/>
    public bool IsReversed => _axis.IsReversed;

    /// <inheritdoc/>
    public bool IsLogarithmic => _axis.IsLogarithmic;

    /// <inheritdoc/>
    public double LogarithmBase => _axis.LogarithmBase;

    /// <inheritdoc/>
    public bool IsMarginVisible => _axis.IsMarginVisible;

    /// <summary>
    /// Calculates a "nice" interval for axis labels.
    /// </summary>
    private static double CalculateNiceInterval(double range, int targetSteps)
    {
        double roughInterval = range / targetSteps;
        double magnitude = Math.Pow(10, Math.Floor(Math.Log10(roughInterval)));
        double residual = roughInterval / magnitude;

        double niceInterval;
        if (residual <= 1.5)
            niceInterval = magnitude;
        else if (residual <= 3)
            niceInterval = 2 * magnitude;
        else if (residual <= 7)
            niceInterval = 5 * magnitude;
        else
            niceInterval = 10 * magnitude;

        return niceInterval;
    }

    private static ChartFontStyle ConvertFontStyle(Drawing.FontStyle style)
    {
        ChartFontStyle result = ChartFontStyle.Regular;
        if ((style & Drawing.FontStyle.Bold) != 0)
            result |= ChartFontStyle.Bold;
        if ((style & Drawing.FontStyle.Italic) != 0)
            result |= ChartFontStyle.Italic;
        if ((style & Drawing.FontStyle.Underline) != 0)
            result |= ChartFontStyle.Underline;
        if ((style & Drawing.FontStyle.Strikeout) != 0)
            result |= ChartFontStyle.Strikeout;
        return result;
    }
}
