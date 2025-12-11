// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.Rendering;

/// <summary>
/// Stores a set of four floating-point numbers that represent the location and size of a rectangle.
/// Platform-agnostic replacement for System.Drawing.RectangleF.
/// </summary>
public struct ChartRectangleF : IEquatable<ChartRectangleF>
{
    /// <summary>
    /// Represents an instance of the ChartRectangleF class with its members uninitialized.
    /// </summary>
    public static readonly ChartRectangleF Empty = new(0f, 0f, 0f, 0f);

    /// <summary>
    /// Gets or sets the x-coordinate of the upper-left corner of this ChartRectangleF structure.
    /// </summary>
    public float X { get; set; }

    /// <summary>
    /// Gets or sets the y-coordinate of the upper-left corner of this ChartRectangleF structure.
    /// </summary>
    public float Y { get; set; }

    /// <summary>
    /// Gets or sets the width of this ChartRectangleF structure.
    /// </summary>
    public float Width { get; set; }

    /// <summary>
    /// Gets or sets the height of this ChartRectangleF structure.
    /// </summary>
    public float Height { get; set; }

    /// <summary>
    /// Gets the x-coordinate of the left edge of this ChartRectangleF structure.
    /// </summary>
    public readonly float Left => X;

    /// <summary>
    /// Gets the y-coordinate of the top edge of this ChartRectangleF structure.
    /// </summary>
    public readonly float Top => Y;

    /// <summary>
    /// Gets the x-coordinate that is the sum of X and Width of this ChartRectangleF structure.
    /// </summary>
    public readonly float Right => X + Width;

    /// <summary>
    /// Gets the y-coordinate that is the sum of Y and Height of this ChartRectangleF structure.
    /// </summary>
    public readonly float Bottom => Y + Height;

    /// <summary>
    /// Gets or sets the coordinates of the upper-left corner of this ChartRectangleF structure.
    /// </summary>
    public ChartPointF Location
    {
        readonly get => new(X, Y);
        set
        {
            X = value.X;
            Y = value.Y;
        }
    }

    /// <summary>
    /// Gets or sets the size of this ChartRectangleF.
    /// </summary>
    public ChartSizeF Size
    {
        readonly get => new(Width, Height);
        set
        {
            Width = value.Width;
            Height = value.Height;
        }
    }

    /// <summary>
    /// Tests whether the Width or Height property of this ChartRectangleF has a value of zero.
    /// </summary>
    public readonly bool IsEmpty => Width <= 0 || Height <= 0;

    /// <summary>
    /// Initializes a new instance of the ChartRectangleF class with the specified location and size.
    /// </summary>
    /// <param name="x">The x-coordinate of the upper-left corner of the rectangle.</param>
    /// <param name="y">The y-coordinate of the upper-left corner of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <param name="height">The height of the rectangle.</param>
    public ChartRectangleF(float x, float y, float width, float height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    /// <summary>
    /// Initializes a new instance of the ChartRectangleF class with the specified location and size.
    /// </summary>
    /// <param name="location">A ChartPointF that represents the upper-left corner of the rectangular region.</param>
    /// <param name="size">A ChartSizeF that represents the width and height of the rectangular region.</param>
    public ChartRectangleF(ChartPointF location, ChartSizeF size)
    {
        X = location.X;
        Y = location.Y;
        Width = size.Width;
        Height = size.Height;
    }

    /// <summary>
    /// Creates a ChartRectangleF structure with upper-left corner and lower-right corner at the specified locations.
    /// </summary>
    /// <param name="left">The x-coordinate of the upper-left corner of the rectangular region.</param>
    /// <param name="top">The y-coordinate of the upper-left corner of the rectangular region.</param>
    /// <param name="right">The x-coordinate of the lower-right corner of the rectangular region.</param>
    /// <param name="bottom">The y-coordinate of the lower-right corner of the rectangular region.</param>
    /// <returns>The new ChartRectangleF that this method creates.</returns>
    public static ChartRectangleF FromLTRB(float left, float top, float right, float bottom) =>
        new(left, top, right - left, bottom - top);

    /// <summary>
    /// Determines if the specified point is contained within this ChartRectangleF structure.
    /// </summary>
    /// <param name="x">The x-coordinate of the point to test.</param>
    /// <param name="y">The y-coordinate of the point to test.</param>
    /// <returns>true if the point defined by x and y is contained within this ChartRectangleF structure; otherwise, false.</returns>
    public readonly bool Contains(float x, float y) =>
        X <= x && x < X + Width && Y <= y && y < Y + Height;

    /// <summary>
    /// Determines if the specified point is contained within this ChartRectangleF structure.
    /// </summary>
    /// <param name="pt">The ChartPointF to test.</param>
    /// <returns>true if the point represented by the pt parameter is contained within this ChartRectangleF structure; otherwise, false.</returns>
    public readonly bool Contains(ChartPointF pt) =>
        Contains(pt.X, pt.Y);

    /// <summary>
    /// Determines if the rectangular region represented by rect is entirely contained within this ChartRectangleF structure.
    /// </summary>
    /// <param name="rect">The ChartRectangleF to test.</param>
    /// <returns>true if the rectangular region represented by rect is entirely contained within the rectangular region represented by this ChartRectangleF; otherwise, false.</returns>
    public readonly bool Contains(ChartRectangleF rect) =>
        X <= rect.X && rect.X + rect.Width <= X + Width &&
        Y <= rect.Y && rect.Y + rect.Height <= Y + Height;

    /// <summary>
    /// Enlarges this ChartRectangleF by the specified amount.
    /// </summary>
    /// <param name="x">The amount to inflate this ChartRectangleF horizontally.</param>
    /// <param name="y">The amount to inflate this ChartRectangleF vertically.</param>
    public void Inflate(float x, float y)
    {
        X -= x;
        Y -= y;
        Width += 2 * x;
        Height += 2 * y;
    }

    /// <summary>
    /// Enlarges this ChartRectangleF by the specified amount.
    /// </summary>
    /// <param name="size">The amount to inflate this rectangle.</param>
    public void Inflate(ChartSizeF size) =>
        Inflate(size.Width, size.Height);

    /// <summary>
    /// Creates and returns an enlarged copy of the specified ChartRectangleF structure.
    /// </summary>
    /// <param name="rect">The ChartRectangleF to be copied.</param>
    /// <param name="x">The amount to enlarge the copy of the rectangle horizontally.</param>
    /// <param name="y">The amount to enlarge the copy of the rectangle vertically.</param>
    /// <returns>The enlarged ChartRectangleF.</returns>
    public static ChartRectangleF Inflate(ChartRectangleF rect, float x, float y)
    {
        var r = rect;
        r.Inflate(x, y);
        return r;
    }

    /// <summary>
    /// Replaces this ChartRectangleF structure with the intersection of itself and the specified ChartRectangleF structure.
    /// </summary>
    /// <param name="rect">The rectangle to intersect.</param>
    public void Intersect(ChartRectangleF rect)
    {
        var result = Intersect(rect, this);
        X = result.X;
        Y = result.Y;
        Width = result.Width;
        Height = result.Height;
    }

    /// <summary>
    /// Returns a ChartRectangleF structure that represents the intersection of two rectangles.
    /// </summary>
    /// <param name="a">A rectangle to intersect.</param>
    /// <param name="b">A rectangle to intersect.</param>
    /// <returns>A third ChartRectangleF structure the size of which represents the overlapped area of the two specified rectangles.</returns>
    public static ChartRectangleF Intersect(ChartRectangleF a, ChartRectangleF b)
    {
        float x1 = Math.Max(a.X, b.X);
        float x2 = Math.Min(a.X + a.Width, b.X + b.Width);
        float y1 = Math.Max(a.Y, b.Y);
        float y2 = Math.Min(a.Y + a.Height, b.Y + b.Height);

        if (x2 >= x1 && y2 >= y1)
            return new ChartRectangleF(x1, y1, x2 - x1, y2 - y1);

        return Empty;
    }

    /// <summary>
    /// Determines if this rectangle intersects with rect.
    /// </summary>
    /// <param name="rect">The rectangle to test.</param>
    /// <returns>true if there is any intersection; otherwise, false.</returns>
    public readonly bool IntersectsWith(ChartRectangleF rect) =>
        rect.X < X + Width && X < rect.X + rect.Width &&
        rect.Y < Y + Height && Y < rect.Y + rect.Height;

    /// <summary>
    /// Creates the smallest possible third rectangle that can contain both of two rectangles that form a union.
    /// </summary>
    /// <param name="a">A rectangle to union.</param>
    /// <param name="b">A rectangle to union.</param>
    /// <returns>A third ChartRectangleF structure that contains both of the two rectangles that form the union.</returns>
    public static ChartRectangleF Union(ChartRectangleF a, ChartRectangleF b)
    {
        float x1 = Math.Min(a.X, b.X);
        float x2 = Math.Max(a.X + a.Width, b.X + b.Width);
        float y1 = Math.Min(a.Y, b.Y);
        float y2 = Math.Max(a.Y + a.Height, b.Y + b.Height);

        return new ChartRectangleF(x1, y1, x2 - x1, y2 - y1);
    }

    /// <summary>
    /// Adjusts the location of this rectangle by the specified amount.
    /// </summary>
    /// <param name="pos">The amount to offset the location.</param>
    public void Offset(ChartPointF pos) =>
        Offset(pos.X, pos.Y);

    /// <summary>
    /// Adjusts the location of this rectangle by the specified amount.
    /// </summary>
    /// <param name="x">The amount to offset the location horizontally.</param>
    /// <param name="y">The amount to offset the location vertically.</param>
    public void Offset(float x, float y)
    {
        X += x;
        Y += y;
    }

    /// <summary>
    /// Tests whether two ChartRectangleF structures have equal location and size.
    /// </summary>
    public static bool operator ==(ChartRectangleF left, ChartRectangleF right) =>
        left.X == right.X && left.Y == right.Y &&
        left.Width == right.Width && left.Height == right.Height;

    /// <summary>
    /// Tests whether two ChartRectangleF structures differ in location or size.
    /// </summary>
    public static bool operator !=(ChartRectangleF left, ChartRectangleF right) =>
        !(left == right);

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    public readonly override bool Equals(object? obj) =>
        obj is ChartRectangleF other && Equals(other);

    /// <summary>
    /// Determines whether the specified ChartRectangleF is equal to the current ChartRectangleF.
    /// </summary>
    public readonly bool Equals(ChartRectangleF other) =>
        this == other;

    /// <summary>
    /// Returns a hash code for this ChartRectangleF structure.
    /// </summary>
    public readonly override int GetHashCode() =>
        HashCode.Combine(X, Y, Width, Height);

    /// <summary>
    /// Converts this ChartRectangleF to a human-readable string.
    /// </summary>
    public readonly override string ToString() =>
        $"{{X={X}, Y={Y}, Width={Width}, Height={Height}}}";
}
