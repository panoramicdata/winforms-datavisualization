// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Defines an object used to draw lines and curves.
/// Platform-agnostic replacement for System.Drawing.Pen.
/// </summary>
public class ChartPen : IDisposable, ICloneable
{
    private bool _disposed;

    /// <summary>
    /// Gets or sets the color of this ChartPen.
    /// </summary>
    public ChartColor Color { get; set; }

    /// <summary>
    /// Gets or sets the width of this ChartPen.
    /// </summary>
    public float Width { get; set; }

    /// <summary>
    /// Gets or sets the style used for dashed lines drawn with this ChartPen.
    /// </summary>
    public ChartDashStyle DashStyle { get; set; }

    /// <summary>
    /// Gets or sets the cap style used at the beginning of lines drawn with this ChartPen.
    /// </summary>
    public ChartLineCap StartCap { get; set; }

    /// <summary>
    /// Gets or sets the cap style used at the end of lines drawn with this ChartPen.
    /// </summary>
    public ChartLineCap EndCap { get; set; }

    /// <summary>
    /// Gets or sets the join style for the ends of two consecutive lines drawn with this ChartPen.
    /// </summary>
    public ChartLineJoin LineJoin { get; set; }

    /// <summary>
    /// Gets or sets the limit of the thickness of the join on a mitered corner.
    /// </summary>
    public float MiterLimit { get; set; }

    /// <summary>
    /// Gets or sets an array of values that specifies a compound pen.
    /// </summary>
    public float[]? DashPattern { get; set; }

    /// <summary>
    /// Gets or sets the distance from the start of a line to the beginning of a dash pattern.
    /// </summary>
    public float DashOffset { get; set; }

    /// <summary>
    /// Initializes a new instance of the ChartPen class with the specified color.
    /// </summary>
    /// <param name="color">A ChartColor structure that indicates the color of this ChartPen.</param>
    public ChartPen(ChartColor color)
        : this(color, 1f)
    {
    }

    /// <summary>
    /// Initializes a new instance of the ChartPen class with the specified color and width.
    /// </summary>
    /// <param name="color">A ChartColor structure that indicates the color of this ChartPen.</param>
    /// <param name="width">A value indicating the width of this ChartPen.</param>
    public ChartPen(ChartColor color, float width)
    {
        Color = color;
        Width = width;
        DashStyle = ChartDashStyle.Solid;
        StartCap = ChartLineCap.Flat;
        EndCap = ChartLineCap.Flat;
        LineJoin = ChartLineJoin.Miter;
        MiterLimit = 10f;
        DashOffset = 0f;
    }

    /// <summary>
    /// Creates an exact copy of this ChartPen.
    /// </summary>
    /// <returns>A new ChartPen that is a copy of this ChartPen.</returns>
    public object Clone()
    {
        var clone = new ChartPen(Color, Width)
        {
            DashStyle = DashStyle,
            StartCap = StartCap,
            EndCap = EndCap,
            LineJoin = LineJoin,
            MiterLimit = MiterLimit,
            DashOffset = DashOffset,
            DashPattern = DashPattern?.ToArray()
        };
        return clone;
    }

    /// <summary>
    /// Converts this ChartPen to SVG stroke attributes.
    /// </summary>
    /// <returns>A string containing SVG stroke attributes.</returns>
    public string ToSvgStrokeAttributes()
    {
        var attrs = new List<string>
        {
            $"stroke=\"{Color.ToHex()}\"",
            $"stroke-width=\"{Width}\""
        };

        if (Color.A < 255)
        {
            attrs.Add($"stroke-opacity=\"{Color.A / 255.0:F2}\"");
        }

        switch (DashStyle)
        {
            case ChartDashStyle.Dash:
                attrs.Add($"stroke-dasharray=\"{Width * 3},{Width}\"");
                break;
            case ChartDashStyle.Dot:
                attrs.Add($"stroke-dasharray=\"{Width},{Width}\"");
                break;
            case ChartDashStyle.DashDot:
                attrs.Add($"stroke-dasharray=\"{Width * 3},{Width},{Width},{Width}\"");
                break;
            case ChartDashStyle.DashDotDot:
                attrs.Add($"stroke-dasharray=\"{Width * 3},{Width},{Width},{Width},{Width},{Width}\"");
                break;
            case ChartDashStyle.Custom when DashPattern != null:
                attrs.Add($"stroke-dasharray=\"{string.Join(",", DashPattern.Select(p => p * Width))}\"");
                break;
        }

        if (DashOffset != 0)
        {
            attrs.Add($"stroke-dashoffset=\"{DashOffset}\"");
        }

        switch (StartCap)
        {
            case ChartLineCap.Round:
                attrs.Add("stroke-linecap=\"round\"");
                break;
            case ChartLineCap.Square:
                attrs.Add("stroke-linecap=\"square\"");
                break;
            default:
                attrs.Add("stroke-linecap=\"butt\"");
                break;
        }

        switch (LineJoin)
        {
            case ChartLineJoin.Round:
                attrs.Add("stroke-linejoin=\"round\"");
                break;
            case ChartLineJoin.Bevel:
                attrs.Add("stroke-linejoin=\"bevel\"");
                break;
            default:
                attrs.Add("stroke-linejoin=\"miter\"");
                attrs.Add($"stroke-miterlimit=\"{MiterLimit}\"");
                break;
        }

        return string.Join(" ", attrs);
    }

    /// <summary>
    /// Releases all resources used by this ChartPen.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases the unmanaged resources used by the ChartPen and optionally releases the managed resources.
    /// </summary>
    /// <param name="disposing">true to release both managed and unmanaged resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Dispose managed resources if any
            }
            _disposed = true;
        }
    }
}
