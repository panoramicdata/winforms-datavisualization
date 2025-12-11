// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Stores an ordered pair of floating-point numbers, typically the width and height of a rectangle.
/// Platform-agnostic replacement for System.Drawing.SizeF.
/// </summary>
public struct ChartSizeF : IEquatable<ChartSizeF>
{
    /// <summary>
    /// Gets a ChartSizeF structure that has a Height and Width value of 0.
    /// </summary>
    public static readonly ChartSizeF Empty = new(0f, 0f);

    /// <summary>
    /// Gets or sets the horizontal component of this ChartSizeF structure.
    /// </summary>
    public float Width { get; set; }

    /// <summary>
    /// Gets or sets the vertical component of this ChartSizeF structure.
    /// </summary>
    public float Height { get; set; }

    /// <summary>
    /// Gets a value that indicates whether this ChartSizeF structure has zero width and height.
    /// </summary>
    public readonly bool IsEmpty => Width == 0f && Height == 0f;

    /// <summary>
    /// Initializes a new instance of the ChartSizeF structure from the specified dimensions.
    /// </summary>
    /// <param name="width">The width component of the new ChartSizeF.</param>
    /// <param name="height">The height component of the new ChartSizeF.</param>
    public ChartSizeF(float width, float height)
    {
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Initializes a new instance of the ChartSizeF structure from the specified ChartPointF.
    /// </summary>
    /// <param name="pt">The ChartPointF structure from which to initialize this ChartSizeF structure.</param>
    public ChartSizeF(ChartPointF pt)
    {
        Width = pt.X;
        Height = pt.Y;
    }

    /// <summary>
    /// Adds the width and height of one ChartSizeF structure to the width and height of another ChartSizeF structure.
    /// </summary>
    public static ChartSizeF operator +(ChartSizeF sz1, ChartSizeF sz2) =>
        new(sz1.Width + sz2.Width, sz1.Height + sz2.Height);

    /// <summary>
    /// Subtracts the width and height of one ChartSizeF structure from the width and height of another ChartSizeF structure.
    /// </summary>
    public static ChartSizeF operator -(ChartSizeF sz1, ChartSizeF sz2) =>
        new(sz1.Width - sz2.Width, sz1.Height - sz2.Height);

    /// <summary>
    /// Multiplies ChartSizeF by a float producing ChartSizeF.
    /// </summary>
    public static ChartSizeF operator *(float left, ChartSizeF right) =>
        new(left * right.Width, left * right.Height);

    /// <summary>
    /// Multiplies ChartSizeF by a float producing ChartSizeF.
    /// </summary>
    public static ChartSizeF operator *(ChartSizeF left, float right) =>
        new(left.Width * right, left.Height * right);

    /// <summary>
    /// Divides ChartSizeF by a float producing ChartSizeF.
    /// </summary>
    public static ChartSizeF operator /(ChartSizeF left, float right) =>
        new(left.Width / right, left.Height / right);

    /// <summary>
    /// Tests whether two ChartSizeF structures are equal.
    /// </summary>
    public static bool operator ==(ChartSizeF sz1, ChartSizeF sz2) =>
        sz1.Width == sz2.Width && sz1.Height == sz2.Height;

    /// <summary>
    /// Tests whether two ChartSizeF structures are different.
    /// </summary>
    public static bool operator !=(ChartSizeF sz1, ChartSizeF sz2) =>
        !(sz1 == sz2);

    /// <summary>
    /// Converts this ChartSizeF to a ChartPointF.
    /// </summary>
    public readonly ChartPointF ToPointF() => new(Width, Height);

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    public readonly override bool Equals(object? obj) =>
        obj is ChartSizeF other && Equals(other);

    /// <summary>
    /// Determines whether the specified ChartSizeF is equal to the current ChartSizeF.
    /// </summary>
    public readonly bool Equals(ChartSizeF other) =>
        Width == other.Width && Height == other.Height;

    /// <summary>
    /// Returns a hash code for this ChartSizeF structure.
    /// </summary>
    public readonly override int GetHashCode() =>
        HashCode.Combine(Width, Height);

    /// <summary>
    /// Converts this ChartSizeF to a human-readable string.
    /// </summary>
    public readonly override string ToString() =>
        $"{{Width={Width}, Height={Height}}}";
}
