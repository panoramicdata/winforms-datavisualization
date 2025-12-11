// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Represents an ordered pair of floating-point x- and y-coordinates that defines a point in a two-dimensional plane.
/// Platform-agnostic replacement for System.Drawing.PointF.
/// </summary>
public struct ChartPointF : IEquatable<ChartPointF>
{
    /// <summary>
    /// Represents a ChartPointF that has X and Y values set to zero.
    /// </summary>
    public static readonly ChartPointF Empty = new(0f, 0f);

    /// <summary>
    /// Gets or sets the x-coordinate of this ChartPointF.
    /// </summary>
    public float X { get; set; }

    /// <summary>
    /// Gets or sets the y-coordinate of this ChartPointF.
    /// </summary>
    public float Y { get; set; }

    /// <summary>
    /// Gets a value indicating whether this ChartPointF is empty.
    /// </summary>
    public readonly bool IsEmpty => X == 0f && Y == 0f;

    /// <summary>
    /// Initializes a new instance of the ChartPointF struct with the specified coordinates.
    /// </summary>
    /// <param name="x">The horizontal position of the point.</param>
    /// <param name="y">The vertical position of the point.</param>
    public ChartPointF(float x, float y)
    {
        X = x;
        Y = y;
    }

    /// <summary>
    /// Translates a ChartPointF by a given ChartSizeF.
    /// </summary>
    public static ChartPointF operator +(ChartPointF pt, ChartSizeF sz) =>
        new(pt.X + sz.Width, pt.Y + sz.Height);

    /// <summary>
    /// Translates a ChartPointF by the negative of a given ChartSizeF.
    /// </summary>
    public static ChartPointF operator -(ChartPointF pt, ChartSizeF sz) =>
        new(pt.X - sz.Width, pt.Y - sz.Height);

    /// <summary>
    /// Compares two ChartPointF structures for equality.
    /// </summary>
    public static bool operator ==(ChartPointF left, ChartPointF right) =>
        left.X == right.X && left.Y == right.Y;

    /// <summary>
    /// Compares two ChartPointF structures for inequality.
    /// </summary>
    public static bool operator !=(ChartPointF left, ChartPointF right) =>
        !(left == right);

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    public readonly override bool Equals(object? obj) =>
        obj is ChartPointF other && Equals(other);

    /// <summary>
    /// Determines whether the specified ChartPointF is equal to the current ChartPointF.
    /// </summary>
    public readonly bool Equals(ChartPointF other) =>
        X == other.X && Y == other.Y;

    /// <summary>
    /// Returns a hash code for this ChartPointF.
    /// </summary>
    public readonly override int GetHashCode() =>
        HashCode.Combine(X, Y);

    /// <summary>
    /// Converts this ChartPointF to a human-readable string.
    /// </summary>
    public readonly override string ToString() =>
        $"{{X={X}, Y={Y}}}";
}
