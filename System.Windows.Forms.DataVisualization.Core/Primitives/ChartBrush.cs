// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Defines objects used to fill the interiors of graphical shapes.
/// Platform-agnostic replacement for System.Drawing.Brush.
/// </summary>
public abstract class ChartBrush : IDisposable, ICloneable
{
    private bool _disposed;

    /// <summary>
    /// Gets the type of brush.
    /// </summary>
    public abstract ChartBrushType BrushType { get; }

    /// <summary>
    /// Creates a copy of this brush.
    /// </summary>
    public abstract object Clone();

    /// <summary>
    /// Converts this brush to SVG fill attributes.
    /// </summary>
    public abstract string ToSvgFillAttribute();

    /// <summary>
    /// Gets any additional SVG definitions required for this brush (e.g., gradient definitions).
    /// </summary>
    /// <param name="id">A unique identifier for the brush definition.</param>
    public virtual string? GetSvgDefinition(string id) => null;

    /// <summary>
    /// Releases all resources used by this ChartBrush.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases the unmanaged resources used by the ChartBrush and optionally releases the managed resources.
    /// </summary>
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

/// <summary>
/// Defines a brush of a single color.
/// Platform-agnostic replacement for System.Drawing.SolidBrush.
/// </summary>
public class ChartSolidBrush : ChartBrush
{
    /// <summary>
    /// Gets or sets the color of this ChartSolidBrush.
    /// </summary>
    public ChartColor Color { get; set; }

    /// <summary>
    /// Gets the type of brush.
    /// </summary>
    public override ChartBrushType BrushType => ChartBrushType.Solid;

    /// <summary>
    /// Initializes a new ChartSolidBrush of the specified color.
    /// </summary>
    /// <param name="color">A ChartColor structure that represents the color of this brush.</param>
    public ChartSolidBrush(ChartColor color)
    {
        Color = color;
    }

    /// <summary>
    /// Creates a copy of this brush.
    /// </summary>
    public override object Clone() => new ChartSolidBrush(Color);

    /// <summary>
    /// Converts this brush to SVG fill attributes.
    /// </summary>
    public override string ToSvgFillAttribute()
    {
        if (Color.A < 255)
        {
            return $"fill=\"{Color.ToHex()}\" fill-opacity=\"{Color.A / 255.0:F2}\"";
        }
        return $"fill=\"{Color.ToHex()}\"";
    }
}

/// <summary>
/// Encapsulates a brush with a linear gradient.
/// Platform-agnostic replacement for System.Drawing.Drawing2D.LinearGradientBrush.
/// </summary>
public class ChartLinearGradientBrush : ChartBrush
{
    /// <summary>
    /// Gets or sets the starting color of the gradient.
    /// </summary>
    public ChartColor Color1 { get; set; }

    /// <summary>
    /// Gets or sets the ending color of the gradient.
    /// </summary>
    public ChartColor Color2 { get; set; }

    /// <summary>
    /// Gets or sets the angle of the gradient.
    /// </summary>
    public float Angle { get; set; }

    /// <summary>
    /// Gets or sets the gradient mode.
    /// </summary>
    public ChartLinearGradientMode GradientMode { get; set; }

    /// <summary>
    /// Gets or sets the rectangle that defines the bounds of the gradient.
    /// </summary>
    public ChartRectangleF Rectangle { get; set; }

    /// <summary>
    /// Gets the type of brush.
    /// </summary>
    public override ChartBrushType BrushType => ChartBrushType.LinearGradient;

    /// <summary>
    /// Initializes a new ChartLinearGradientBrush with the specified colors and angle.
    /// </summary>
    public ChartLinearGradientBrush(ChartColor color1, ChartColor color2, float angle)
    {
        Color1 = color1;
        Color2 = color2;
        Angle = angle;
        Rectangle = ChartRectangleF.Empty;
    }

    /// <summary>
    /// Initializes a new ChartLinearGradientBrush with the specified rectangle, colors, and mode.
    /// </summary>
    public ChartLinearGradientBrush(ChartRectangleF rect, ChartColor color1, ChartColor color2, ChartLinearGradientMode mode)
    {
        Rectangle = rect;
        Color1 = color1;
        Color2 = color2;
        GradientMode = mode;
        Angle = mode switch
        {
            ChartLinearGradientMode.Horizontal => 0f,
            ChartLinearGradientMode.Vertical => 90f,
            ChartLinearGradientMode.ForwardDiagonal => 45f,
            ChartLinearGradientMode.BackwardDiagonal => 135f,
            _ => 0f
        };
    }

    /// <summary>
    /// Creates a copy of this brush.
    /// </summary>
    public override object Clone() => new ChartLinearGradientBrush(Color1, Color2, Angle)
    {
        Rectangle = Rectangle,
        GradientMode = GradientMode
    };

    /// <summary>
    /// Converts this brush to SVG fill attributes.
    /// </summary>
    public override string ToSvgFillAttribute() => "fill=\"url(#gradient_{ID})\"";

    /// <summary>
    /// Gets the SVG gradient definition.
    /// </summary>
    public override string GetSvgDefinition(string id)
    {
        // Convert angle to SVG gradient coordinates
        var angleRad = Angle * Math.PI / 180;
        var x1 = 50 - 50 * Math.Cos(angleRad);
        var y1 = 50 - 50 * Math.Sin(angleRad);
        var x2 = 50 + 50 * Math.Cos(angleRad);
        var y2 = 50 + 50 * Math.Sin(angleRad);

        return $@"<linearGradient id=""{id}"" x1=""{x1:F1}%"" y1=""{y1:F1}%"" x2=""{x2:F1}%"" y2=""{y2:F1}%"">
  <stop offset=""0%"" stop-color=""{Color1.ToHex()}"" {(Color1.A < 255 ? $"stop-opacity=\"{Color1.A / 255.0:F2}\"" : "")}/>
  <stop offset=""100%"" stop-color=""{Color2.ToHex()}"" {(Color2.A < 255 ? $"stop-opacity=\"{Color2.A / 255.0:F2}\"" : "")}/>
</linearGradient>";
    }
}

/// <summary>
/// Defines a rectangular brush with a hatch style.
/// Platform-agnostic replacement for System.Drawing.Drawing2D.HatchBrush.
/// </summary>
public class ChartHatchBrush : ChartBrush
{
    /// <summary>
    /// Gets the hatch style of this ChartHatchBrush.
    /// </summary>
    public ChartHatchStyle HatchStyle { get; }

    /// <summary>
    /// Gets the color of hatch lines.
    /// </summary>
    public ChartColor ForegroundColor { get; }

    /// <summary>
    /// Gets the color of spaces between the hatch lines.
    /// </summary>
    public ChartColor BackgroundColor { get; }

    /// <summary>
    /// Gets the type of brush.
    /// </summary>
    public override ChartBrushType BrushType => ChartBrushType.Hatch;

    /// <summary>
    /// Initializes a new ChartHatchBrush with the specified style and colors.
    /// </summary>
    public ChartHatchBrush(ChartHatchStyle hatchStyle, ChartColor foreColor, ChartColor backColor)
    {
        HatchStyle = hatchStyle;
        ForegroundColor = foreColor;
        BackgroundColor = backColor;
    }

    /// <summary>
    /// Creates a copy of this brush.
    /// </summary>
    public override object Clone() => new ChartHatchBrush(HatchStyle, ForegroundColor, BackgroundColor);

    /// <summary>
    /// Converts this brush to SVG fill attributes.
    /// </summary>
    public override string ToSvgFillAttribute() => "fill=\"url(#hatch_{ID})\"";

    /// <summary>
    /// Gets the SVG pattern definition for the hatch style.
    /// </summary>
    public override string GetSvgDefinition(string id)
    {
        var patternContent = GetHatchPatternSvg();
        return $@"<pattern id=""{id}"" patternUnits=""userSpaceOnUse"" width=""8"" height=""8"">
  <rect width=""8"" height=""8"" fill=""{BackgroundColor.ToHex()}""/>
  {patternContent}
</pattern>";
    }

    private string GetHatchPatternSvg()
    {
        var fg = ForegroundColor.ToHex();
        return HatchStyle switch
        {
            ChartHatchStyle.Horizontal => $"<line x1=\"0\" y1=\"4\" x2=\"8\" y2=\"4\" stroke=\"{fg}\" stroke-width=\"1\"/>",
            ChartHatchStyle.Vertical => $"<line x1=\"4\" y1=\"0\" x2=\"4\" y2=\"8\" stroke=\"{fg}\" stroke-width=\"1\"/>",
            ChartHatchStyle.ForwardDiagonal => $"<line x1=\"0\" y1=\"0\" x2=\"8\" y2=\"8\" stroke=\"{fg}\" stroke-width=\"1\"/>",
            ChartHatchStyle.BackwardDiagonal => $"<line x1=\"8\" y1=\"0\" x2=\"0\" y2=\"8\" stroke=\"{fg}\" stroke-width=\"1\"/>",
            ChartHatchStyle.Cross => $"<line x1=\"0\" y1=\"4\" x2=\"8\" y2=\"4\" stroke=\"{fg}\" stroke-width=\"1\"/><line x1=\"4\" y1=\"0\" x2=\"4\" y2=\"8\" stroke=\"{fg}\" stroke-width=\"1\"/>",
            ChartHatchStyle.DiagonalCross => $"<line x1=\"0\" y1=\"0\" x2=\"8\" y2=\"8\" stroke=\"{fg}\" stroke-width=\"1\"/><line x1=\"8\" y1=\"0\" x2=\"0\" y2=\"8\" stroke=\"{fg}\" stroke-width=\"1\"/>",
            _ => $"<rect width=\"8\" height=\"8\" fill=\"{fg}\" fill-opacity=\"0.5\"/>"
        };
    }
}
