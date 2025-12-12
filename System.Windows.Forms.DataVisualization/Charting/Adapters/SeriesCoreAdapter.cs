// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Adapters;

/// <summary>
/// Adapter that wraps a WinForms Series to implement the platform-agnostic ISeriesModel interface.
/// </summary>
public class SeriesCoreAdapter : ISeriesModel
{
    private readonly Series _series;
    private readonly List<IDataPointModel> _points;

    /// <summary>
    /// Creates a new SeriesCoreAdapter wrapping the specified Series.
    /// </summary>
    /// <param name="series">The WinForms Series to adapt.</param>
    public SeriesCoreAdapter(Series series)
    {
        _series = series ?? throw new ArgumentNullException(nameof(series));
        
        // Create adapters for data points
        _points = [];
        foreach (DataPoint point in _series.Points)
        {
            _points.Add(new DataPointCoreAdapter(point, _series));
        }
    }

    /// <summary>
    /// Gets the underlying WinForms Series.
    /// </summary>
    public Series Series => _series;

    /// <inheritdoc/>
    public string Name => _series.Name ?? string.Empty;

    /// <inheritdoc/>
    public string ChartType => _series.ChartTypeName ?? "Line";

    /// <inheritdoc/>
    public string ChartArea => _series.ChartArea ?? string.Empty;

    /// <inheritdoc/>
    public ChartColor Color
    {
        get
        {
            var color = _series.Color;
            if (color.IsEmpty)
            {
                return ChartColor.FromArgb(65, 140, 240); // Default blue
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartColor BorderColor
    {
        get
        {
            var color = _series.BorderColor;
            if (color.IsEmpty)
            {
                return ChartColor.Empty;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public float BorderWidth => _series.BorderWidth;

    /// <inheritdoc/>
    public Rendering.ChartDashStyle BorderDashStyle => ConvertDashStyle(_series.BorderDashStyle);

    /// <inheritdoc/>
    public IReadOnlyList<IDataPointModel> Points => _points;

    /// <inheritdoc/>
    public bool ShowMarkers => _series.MarkerStyle != Charting.MarkerStyle.None;

    /// <inheritdoc/>
    public ChartMarkerStyle MarkerStyle => ConvertMarkerStyle(_series.MarkerStyle);

    /// <inheritdoc/>
    public float MarkerSize => _series.MarkerSize;

    /// <inheritdoc/>
    public ChartColor MarkerColor
    {
        get
        {
            var color = _series.MarkerColor;
            if (color.IsEmpty)
            {
                return ChartColor.Empty;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public ChartColor MarkerBorderColor
    {
        get
        {
            var color = _series.MarkerBorderColor;
            if (color.IsEmpty)
            {
                return ChartColor.Empty;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public float MarkerBorderWidth => _series.MarkerBorderWidth;

    /// <inheritdoc/>
    public bool IsValueShownAsLabel => _series.IsValueShownAsLabel;

    /// <inheritdoc/>
    public string LabelFormat => _series.LabelFormat ?? string.Empty;

    /// <inheritdoc/>
    public ChartFont LabelFont
    {
        get
        {
            var font = _series.Font;
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
    public ChartColor LabelForeColor
    {
        get
        {
            var color = _series.LabelForeColor;
            if (color.IsEmpty)
            {
                return ChartColor.Black;
            }
            return ChartColor.FromArgb(color.A, color.R, color.G, color.B);
        }
    }

    /// <inheritdoc/>
    public bool IsVisible => _series.Enabled;

    /// <inheritdoc/>
    public bool IsXValueIndexed => _series.IsXValueIndexed;

    /// <inheritdoc/>
    public ChartAxisType XAxisType => _series.XAxisType == AxisType.Primary 
        ? ChartAxisType.Primary 
        : ChartAxisType.Secondary;

    /// <inheritdoc/>
    public ChartAxisType YAxisType => _series.YAxisType == AxisType.Primary 
        ? ChartAxisType.Primary 
        : ChartAxisType.Secondary;

    /// <summary>
    /// Refreshes the adapter to pick up changes in the underlying Series.
    /// </summary>
    public void Refresh()
    {
        _points.Clear();
        foreach (DataPoint point in _series.Points)
        {
            _points.Add(new DataPointCoreAdapter(point, _series));
        }
    }

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
