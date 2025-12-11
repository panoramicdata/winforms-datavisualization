// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Specifies style information applied to text.
/// </summary>
[Flags]
public enum ChartFontStyle
{
    /// <summary>
    /// Normal text.
    /// </summary>
    Regular = 0,

    /// <summary>
    /// Bold text.
    /// </summary>
    Bold = 1,

    /// <summary>
    /// Italic text.
    /// </summary>
    Italic = 2,

    /// <summary>
    /// Underlined text.
    /// </summary>
    Underline = 4,

    /// <summary>
    /// Text with a line through the middle.
    /// </summary>
    Strikeout = 8
}

/// <summary>
/// Defines a particular format for text, including font face, size, and style attributes.
/// Platform-agnostic replacement for System.Drawing.Font.
/// </summary>
public class ChartFont : IEquatable<ChartFont>, IDisposable
{
    private bool _disposed;

    /// <summary>
    /// Gets the face name of this ChartFont.
    /// </summary>
    public string FontFamily { get; }

    /// <summary>
    /// Gets the em-size of this ChartFont measured in the units specified by the Unit property.
    /// </summary>
    public float Size { get; }

    /// <summary>
    /// Gets style information for this ChartFont.
    /// </summary>
    public ChartFontStyle Style { get; }

    /// <summary>
    /// Gets the unit of measure for this ChartFont.
    /// </summary>
    public ChartGraphicsUnit Unit { get; }

    /// <summary>
    /// Gets a value that indicates whether this ChartFont is bold.
    /// </summary>
    public bool Bold => (Style & ChartFontStyle.Bold) != 0;

    /// <summary>
    /// Gets a value that indicates whether this font has the italic style applied.
    /// </summary>
    public bool Italic => (Style & ChartFontStyle.Italic) != 0;

    /// <summary>
    /// Gets a value that indicates whether this ChartFont specifies an underline.
    /// </summary>
    public bool Underline => (Style & ChartFontStyle.Underline) != 0;

    /// <summary>
    /// Gets a value that indicates whether this ChartFont specifies a horizontal line through the font.
    /// </summary>
    public bool Strikeout => (Style & ChartFontStyle.Strikeout) != 0;

    /// <summary>
    /// Gets the em-size, in points, of this ChartFont.
    /// </summary>
    public float SizeInPoints
    {
        get
        {
            return Unit switch
            {
                ChartGraphicsUnit.Point => Size,
                ChartGraphicsUnit.Pixel => Size * 72f / 96f, // Assuming 96 DPI
                ChartGraphicsUnit.Inch => Size * 72f,
                ChartGraphicsUnit.Millimeter => Size * 72f / 25.4f,
                _ => Size
            };
        }
    }

    /// <summary>
    /// Initializes a new ChartFont using a specified size and style.
    /// </summary>
    /// <param name="familyName">The font family name.</param>
    /// <param name="emSize">The em-size of the new font in the units specified by unit.</param>
    /// <param name="style">The ChartFontStyle of the new font.</param>
    /// <param name="unit">The ChartGraphicsUnit of the new font.</param>
    public ChartFont(string familyName, float emSize, ChartFontStyle style = ChartFontStyle.Regular, ChartGraphicsUnit unit = ChartGraphicsUnit.Point)
    {
        FontFamily = familyName ?? throw new ArgumentNullException(nameof(familyName));
        Size = emSize;
        Style = style;
        Unit = unit;
    }

    /// <summary>
    /// Initializes a new ChartFont using a specified size.
    /// </summary>
    /// <param name="familyName">The font family name.</param>
    /// <param name="emSize">The em-size of the new font in points.</param>
    public ChartFont(string familyName, float emSize)
        : this(familyName, emSize, ChartFontStyle.Regular, ChartGraphicsUnit.Point)
    {
    }

    /// <summary>
    /// Creates a ChartFont from another ChartFont with a new style.
    /// </summary>
    /// <param name="font">The source font.</param>
    /// <param name="newStyle">The new style to apply.</param>
    /// <returns>A new ChartFont with the specified style.</returns>
    public static ChartFont WithStyle(ChartFont font, ChartFontStyle newStyle) =>
        new(font.FontFamily, font.Size, newStyle, font.Unit);

    /// <summary>
    /// Creates a ChartFont from another ChartFont with a new size.
    /// </summary>
    /// <param name="font">The source font.</param>
    /// <param name="newSize">The new size.</param>
    /// <returns>A new ChartFont with the specified size.</returns>
    public static ChartFont WithSize(ChartFont font, float newSize) =>
        new(font.FontFamily, newSize, font.Style, font.Unit);

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    public override bool Equals(object? obj) =>
        obj is ChartFont other && Equals(other);

    /// <summary>
    /// Determines whether the specified ChartFont is equal to the current ChartFont.
    /// </summary>
    public bool Equals(ChartFont? other) =>
        other is not null &&
        FontFamily == other.FontFamily &&
        Size == other.Size &&
        Style == other.Style &&
        Unit == other.Unit;

    /// <summary>
    /// Returns a hash code for this ChartFont.
    /// </summary>
    public override int GetHashCode() =>
        HashCode.Combine(FontFamily, Size, Style, Unit);

    /// <summary>
    /// Converts this ChartFont to a human-readable string.
    /// </summary>
    public override string ToString() =>
        $"[ChartFont: Name={FontFamily}, Size={Size}, Style={Style}, Unit={Unit}]";

    /// <summary>
    /// Converts this ChartFont to a CSS font string.
    /// </summary>
    public string ToCss()
    {
        var style = Italic ? "italic" : "normal";
        var weight = Bold ? "bold" : "normal";
        var decoration = new List<string>();
        if (Underline) decoration.Add("underline");
        if (Strikeout) decoration.Add("line-through");
        var textDecoration = decoration.Count > 0 ? string.Join(" ", decoration) : "none";

        return $"{style} {weight} {SizeInPoints}pt '{FontFamily}'";
    }

    /// <summary>
    /// Releases all resources used by this ChartFont.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases the unmanaged resources used by the ChartFont and optionally releases the managed resources.
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

    /// <summary>
    /// Tests whether two ChartFont structures are equal.
    /// </summary>
    public static bool operator ==(ChartFont? left, ChartFont? right) =>
        left is null ? right is null : left.Equals(right);

    /// <summary>
    /// Tests whether two ChartFont structures are different.
    /// </summary>
    public static bool operator !=(ChartFont? left, ChartFont? right) =>
        !(left == right);
}
