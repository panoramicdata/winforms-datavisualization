// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Represents an ARGB (alpha, red, green, blue) color.
/// Platform-agnostic replacement for System.Drawing.Color.
/// </summary>
public readonly struct ChartColor : IEquatable<ChartColor>
{
    private readonly uint _value;

    /// <summary>
    /// Gets the alpha component value of this ChartColor structure.
    /// </summary>
    public byte A => (byte)((_value >> 24) & 0xFF);

    /// <summary>
    /// Gets the red component value of this ChartColor structure.
    /// </summary>
    public byte R => (byte)((_value >> 16) & 0xFF);

    /// <summary>
    /// Gets the green component value of this ChartColor structure.
    /// </summary>
    public byte G => (byte)((_value >> 8) & 0xFF);

    /// <summary>
    /// Gets the blue component value of this ChartColor structure.
    /// </summary>
    public byte B => (byte)(_value & 0xFF);

    /// <summary>
    /// Gets a value indicating whether this ChartColor structure is uninitialized.
    /// </summary>
    public bool IsEmpty => _value == 0;

    /// <summary>
    /// Initializes a new instance of the ChartColor structure from the specified ARGB value.
    /// </summary>
    private ChartColor(uint value)
    {
        _value = value;
    }

    /// <summary>
    /// Creates a ChartColor structure from the four ARGB component values.
    /// </summary>
    /// <param name="alpha">The alpha component.</param>
    /// <param name="red">The red component.</param>
    /// <param name="green">The green component.</param>
    /// <param name="blue">The blue component.</param>
    /// <returns>The ChartColor that this method creates.</returns>
    public static ChartColor FromArgb(int alpha, int red, int green, int blue) =>
        new(((uint)alpha << 24) | ((uint)red << 16) | ((uint)green << 8) | (uint)blue);

    /// <summary>
    /// Creates a ChartColor structure from the three RGB component values (alpha is 255).
    /// </summary>
    /// <param name="red">The red component.</param>
    /// <param name="green">The green component.</param>
    /// <param name="blue">The blue component.</param>
    /// <returns>The ChartColor that this method creates.</returns>
    public static ChartColor FromArgb(int red, int green, int blue) =>
        FromArgb(255, red, green, blue);

    /// <summary>
    /// Creates a ChartColor structure from a 32-bit ARGB value.
    /// </summary>
    /// <param name="argb">A value specifying the 32-bit ARGB value.</param>
    /// <returns>The ChartColor that this method creates.</returns>
    public static ChartColor FromArgb(int argb) =>
        new((uint)argb);

    /// <summary>
    /// Creates a ChartColor structure from the specified color, but with a new alpha value.
    /// </summary>
    /// <param name="alpha">The alpha value for the new ChartColor.</param>
    /// <param name="baseColor">The ChartColor from which to create the new ChartColor.</param>
    /// <returns>The ChartColor that this method creates.</returns>
    public static ChartColor FromArgb(int alpha, ChartColor baseColor) =>
        FromArgb(alpha, baseColor.R, baseColor.G, baseColor.B);

    /// <summary>
    /// Gets the 32-bit ARGB value of this ChartColor structure.
    /// </summary>
    /// <returns>The 32-bit ARGB value of this ChartColor.</returns>
    public int ToArgb() => (int)_value;

    /// <summary>
    /// Gets the hue-saturation-brightness (HSB) brightness value for this ChartColor structure.
    /// </summary>
    /// <returns>The brightness of this ChartColor. The brightness ranges from 0.0 through 1.0.</returns>
    public float GetBrightness()
    {
        float r = R / 255.0f;
        float g = G / 255.0f;
        float b = B / 255.0f;

        float max = Math.Max(r, Math.Max(g, b));
        float min = Math.Min(r, Math.Min(g, b));

        return (max + min) / 2.0f;
    }

    /// <summary>
    /// Gets the hue-saturation-brightness (HSB) hue value, in degrees, for this ChartColor structure.
    /// </summary>
    /// <returns>The hue, in degrees, of this ChartColor. The hue is measured in degrees, ranging from 0.0 through 360.0.</returns>
    public float GetHue()
    {
        if (R == G && G == B)
            return 0f;

        float r = R / 255.0f;
        float g = G / 255.0f;
        float b = B / 255.0f;

        float max = Math.Max(r, Math.Max(g, b));
        float min = Math.Min(r, Math.Min(g, b));
        float delta = max - min;

        float hue;
        if (r == max)
            hue = (g - b) / delta;
        else if (g == max)
            hue = 2f + (b - r) / delta;
        else
            hue = 4f + (r - g) / delta;

        hue *= 60f;
        if (hue < 0f)
            hue += 360f;

        return hue;
    }

    /// <summary>
    /// Gets the hue-saturation-brightness (HSB) saturation value for this ChartColor structure.
    /// </summary>
    /// <returns>The saturation of this ChartColor. The saturation ranges from 0.0 through 1.0.</returns>
    public float GetSaturation()
    {
        float r = R / 255.0f;
        float g = G / 255.0f;
        float b = B / 255.0f;

        float max = Math.Max(r, Math.Max(g, b));
        float min = Math.Min(r, Math.Min(g, b));

        if (max == min)
            return 0f;

        float l = (max + min) / 2.0f;

        if (l <= 0.5f)
            return (max - min) / (max + min);
        else
            return (max - min) / (2.0f - max - min);
    }

    // Common colors
    public static ChartColor Empty => new(0);
    public static ChartColor Transparent => FromArgb(0, 255, 255, 255);
    public static ChartColor Black => FromArgb(255, 0, 0, 0);
    public static ChartColor White => FromArgb(255, 255, 255, 255);
    public static ChartColor Red => FromArgb(255, 255, 0, 0);
    public static ChartColor Green => FromArgb(255, 0, 128, 0);
    public static ChartColor Blue => FromArgb(255, 0, 0, 255);
    public static ChartColor Yellow => FromArgb(255, 255, 255, 0);
    public static ChartColor Orange => FromArgb(255, 255, 165, 0);
    public static ChartColor Purple => FromArgb(255, 128, 0, 128);
    public static ChartColor Gray => FromArgb(255, 128, 128, 128);
    public static ChartColor LightGray => FromArgb(255, 211, 211, 211);
    public static ChartColor DarkGray => FromArgb(255, 169, 169, 169);
    public static ChartColor Cyan => FromArgb(255, 0, 255, 255);
    public static ChartColor Magenta => FromArgb(255, 255, 0, 255);
    public static ChartColor Brown => FromArgb(255, 165, 42, 42);
    public static ChartColor Pink => FromArgb(255, 255, 192, 203);
    public static ChartColor Navy => FromArgb(255, 0, 0, 128);
    public static ChartColor Teal => FromArgb(255, 0, 128, 128);
    public static ChartColor Olive => FromArgb(255, 128, 128, 0);
    public static ChartColor Maroon => FromArgb(255, 128, 0, 0);
    public static ChartColor Silver => FromArgb(255, 192, 192, 192);
    public static ChartColor Lime => FromArgb(255, 0, 255, 0);
    public static ChartColor Aqua => FromArgb(255, 0, 255, 255);
    public static ChartColor Fuchsia => FromArgb(255, 255, 0, 255);
    public static ChartColor Coral => FromArgb(255, 255, 127, 80);
    public static ChartColor Crimson => FromArgb(255, 220, 20, 60);
    public static ChartColor DarkBlue => FromArgb(255, 0, 0, 139);
    public static ChartColor DarkGreen => FromArgb(255, 0, 100, 0);
    public static ChartColor DarkRed => FromArgb(255, 139, 0, 0);
    public static ChartColor Gold => FromArgb(255, 255, 215, 0);
    public static ChartColor Indigo => FromArgb(255, 75, 0, 130);
    public static ChartColor Khaki => FromArgb(255, 240, 230, 140);
    public static ChartColor LightBlue => FromArgb(255, 173, 216, 230);
    public static ChartColor LightGreen => FromArgb(255, 144, 238, 144);
    public static ChartColor SkyBlue => FromArgb(255, 135, 206, 235);
    public static ChartColor SlateGray => FromArgb(255, 112, 128, 144);
    public static ChartColor SteelBlue => FromArgb(255, 70, 130, 180);
    public static ChartColor Tan => FromArgb(255, 210, 180, 140);
    public static ChartColor Turquoise => FromArgb(255, 64, 224, 208);
    public static ChartColor Violet => FromArgb(255, 238, 130, 238);
    public static ChartColor Wheat => FromArgb(255, 245, 222, 179);

    /// <summary>
    /// Tests whether two ChartColor structures are equal.
    /// </summary>
    public static bool operator ==(ChartColor left, ChartColor right) =>
        left._value == right._value;

    /// <summary>
    /// Tests whether two ChartColor structures are different.
    /// </summary>
    public static bool operator !=(ChartColor left, ChartColor right) =>
        left._value != right._value;

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is ChartColor other && Equals(other);

    /// <summary>
    /// Determines whether the specified ChartColor is equal to the current ChartColor.
    /// </summary>
    public bool Equals(ChartColor other) =>
        _value == other._value;

    /// <summary>
    /// Returns a hash code for this ChartColor structure.
    /// </summary>
    public override int GetHashCode() =>
        _value.GetHashCode();

    /// <summary>
    /// Converts this ChartColor structure to a human-readable string.
    /// </summary>
    public override string ToString() =>
        $"ChartColor [A={A}, R={R}, G={G}, B={B}]";

    /// <summary>
    /// Converts this ChartColor to a hexadecimal string representation.
    /// </summary>
    /// <param name="includeAlpha">Whether to include the alpha component.</param>
    /// <returns>A hexadecimal string representation of this color.</returns>
    public string ToHex(bool includeAlpha = false) =>
        includeAlpha
            ? $"#{A:X2}{R:X2}{G:X2}{B:X2}"
            : $"#{R:X2}{G:X2}{B:X2}";

    /// <summary>
    /// Converts this ChartColor to an RGB or RGBA CSS string.
    /// </summary>
    /// <returns>An RGB or RGBA CSS string.</returns>
    public string ToCss() =>
        A == 255
            ? $"rgb({R}, {G}, {B})"
            : $"rgba({R}, {G}, {B}, {A / 255.0:F2})";
}
