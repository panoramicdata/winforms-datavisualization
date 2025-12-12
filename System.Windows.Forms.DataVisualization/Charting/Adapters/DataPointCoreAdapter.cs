// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps a WinForms DataPoint to implement the platform-agnostic IDataPointModel interface.
/// </summary>
public class DataPointCoreAdapter : IDataPointModel
{
    private readonly DataPoint _dataPoint;
    private readonly Series _series;

    /// <summary>
    /// Creates a new DataPointCoreAdapter wrapping the specified DataPoint.
    /// </summary>
    /// <param name="dataPoint">The WinForms DataPoint to adapt.</param>
    /// <param name="series">The parent series of the data point.</param>
    public DataPointCoreAdapter(DataPoint dataPoint, Series series)
    {
        _dataPoint = dataPoint ?? throw new ArgumentNullException(nameof(dataPoint));
        _series = series ?? throw new ArgumentNullException(nameof(series));
    }

    /// <summary>
    /// Gets the underlying WinForms DataPoint.
    /// </summary>
    public DataPoint DataPoint => _dataPoint;

    /// <inheritdoc/>
    public double XValue => _dataPoint.XValue;

    /// <inheritdoc/>
    public double[] YValues => _dataPoint.YValues;

    /// <inheritdoc/>
    public double YValue => _dataPoint.YValues.Length > 0 ? _dataPoint.YValues[0] : 0;

    /// <inheritdoc/>
    public string AxisLabel => _dataPoint.AxisLabel ?? string.Empty;

    /// <inheritdoc/>
    public string Label => _dataPoint.Label ?? string.Empty;

    /// <inheritdoc/>
    public int LabelAngle => _dataPoint.LabelAngle;

    /// <inheritdoc/>
    public ChartColor Color
    {
        get
        {
            var color = _dataPoint.Color;
            if (color.IsEmpty)
            {
                // Fall back to series color
                var seriesColor = _series.Color;
                if (seriesColor.IsEmpty)
                {
                    return ChartColor.Empty;
                }
                return ChartColor.FromArgb(seriesColor.A, seriesColor.R, seriesColor.G, seriesColor.B);
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartColor BorderColor
    {
        get
        {
            var color = _dataPoint.BorderColor;
            if (color.IsEmpty)
            {
                return ChartColor.Empty;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public float BorderWidth => _dataPoint.BorderWidth;

    /// <inheritdoc/>
    public ChartMarkerStyle MarkerStyle
    {
        get
        {
            var style = _dataPoint.MarkerStyle;
            if (style == Charting.MarkerStyle.None)
            {
                // Fall back to series marker style
                style = _series.MarkerStyle;
            }
            return ConvertMarkerStyle(style);
        }
    }

    /// <inheritdoc/>
    public float MarkerSize
    {
        get
        {
            var size = _dataPoint.MarkerSize;
            if (size <= 0)
            {
                return _series.MarkerSize;
            }
            return size;
        }
    }

    /// <inheritdoc/>
    public ChartColor MarkerColor
    {
        get
        {
            var color = _dataPoint.MarkerColor;
            if (color.IsEmpty)
            {
                // Fall back to series marker color
                var seriesColor = _series.MarkerColor;
                if (seriesColor.IsEmpty)
                {
                    return ChartColor.Empty;
                }
                return ChartColor.FromArgb(seriesColor.A, seriesColor.R, seriesColor.G, seriesColor.B);
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public bool IsEmpty => _dataPoint.IsEmpty;

    /// <inheritdoc/>
    public bool IsValueShownAsLabel => _dataPoint.IsValueShownAsLabel;

    /// <inheritdoc/>
    public string ToolTip => _dataPoint.ToolTip ?? string.Empty;

    /// <inheritdoc/>
    public string LabelToolTip => _dataPoint.LabelToolTip ?? string.Empty;

    /// <inheritdoc/>
    public ChartColor LabelForeColor
    {
        get
        {
            var color = _dataPoint.LabelForeColor;
            if (color.IsEmpty)
            {
                return ChartColor.Black;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartColor LabelBackColor
    {
        get
        {
            var color = _dataPoint.LabelBackColor;
            if (color.IsEmpty)
            {
                return ChartColor.Empty;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartColor LabelBorderColor
    {
        get
        {
            var color = _dataPoint.LabelBorderColor;
            if (color.IsEmpty)
            {
                return ChartColor.Empty;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public float LabelBorderWidth => _dataPoint.LabelBorderWidth;

    /// <inheritdoc/>
    public Rendering.ChartDashStyle LabelBorderDashStyle => ConvertDashStyle(_dataPoint.LabelBorderDashStyle);

    private static ChartMarkerStyle ConvertMarkerStyle(Charting.MarkerStyle style)
    {
        return style switch
        {
            Charting.MarkerStyle.None => ChartMarkerStyle.None,
            Charting.MarkerStyle.Square => ChartMarkerStyle.Square,
            Charting.MarkerStyle.Circle => ChartMarkerStyle.Circle,
            Charting.MarkerStyle.Diamond => ChartMarkerStyle.Diamond,
            Charting.MarkerStyle.Triangle => ChartMarkerStyle.Triangle,
            Charting.MarkerStyle.Cross => ChartMarkerStyle.Cross,
            Charting.MarkerStyle.Star4 => ChartMarkerStyle.Star4,
            Charting.MarkerStyle.Star5 => ChartMarkerStyle.Star5,
            Charting.MarkerStyle.Star6 => ChartMarkerStyle.Star6,
            Charting.MarkerStyle.Star10 => ChartMarkerStyle.Star10,
            _ => ChartMarkerStyle.None
        };
    }

    private static Rendering.ChartDashStyle ConvertDashStyle(Charting.ChartDashStyle style)
    {
        return style switch
        {
            Charting.ChartDashStyle.Solid => Rendering.ChartDashStyle.Solid,
            Charting.ChartDashStyle.Dash => Rendering.ChartDashStyle.Dash,
            Charting.ChartDashStyle.Dot => Rendering.ChartDashStyle.Dot,
            Charting.ChartDashStyle.DashDot => Rendering.ChartDashStyle.DashDot,
            Charting.ChartDashStyle.DashDotDot => Rendering.ChartDashStyle.DashDotDot,
            _ => Rendering.ChartDashStyle.Solid
        };
    }
}
