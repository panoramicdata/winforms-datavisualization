// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Encapsulates a 3-by-3 affine matrix that represents a geometric transform.
/// Platform-agnostic replacement for System.Drawing.Drawing2D.Matrix.
/// </summary>
public class ChartMatrix : IDisposable, ICloneable, IEquatable<ChartMatrix>
{
    private bool _disposed;
    private readonly float[] _elements;

    /// <summary>
    /// Gets an array of floating-point values that represents the elements of this ChartMatrix.
    /// </summary>
    /// <remarks>
    /// The elements are: [M11, M12, M21, M22, OffsetX, OffsetY]
    /// </remarks>
    public float[] Elements => (float[])_elements.Clone();

    /// <summary>
    /// Gets the x translation value (the dx value, or the element in the third row and first column) of this ChartMatrix.
    /// </summary>
    public float OffsetX => _elements[4];

    /// <summary>
    /// Gets the y translation value (the dy value, or the element in the third row and second column) of this ChartMatrix.
    /// </summary>
    public float OffsetY => _elements[5];

    /// <summary>
    /// Gets a value indicating whether this ChartMatrix is the identity matrix.
    /// </summary>
    public bool IsIdentity =>
        _elements[0] == 1f && _elements[1] == 0f &&
        _elements[2] == 0f && _elements[3] == 1f &&
        _elements[4] == 0f && _elements[5] == 0f;

    /// <summary>
    /// Gets a value indicating whether this ChartMatrix is invertible.
    /// </summary>
    public bool IsInvertible => GetDeterminant() != 0f;

    /// <summary>
    /// Initializes a new instance of the ChartMatrix class as the identity matrix.
    /// </summary>
    public ChartMatrix()
    {
        _elements = new float[] { 1f, 0f, 0f, 1f, 0f, 0f };
    }

    /// <summary>
    /// Initializes a new instance of the ChartMatrix class with the specified elements.
    /// </summary>
    public ChartMatrix(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        _elements = new float[] { m11, m12, m21, m22, dx, dy };
    }

    /// <summary>
    /// Initializes a new instance of the ChartMatrix class with the specified elements.
    /// </summary>
    private ChartMatrix(float[] elements)
    {
        _elements = (float[])elements.Clone();
    }

    /// <summary>
    /// Creates an exact copy of this ChartMatrix.
    /// </summary>
    public object Clone() => new ChartMatrix(_elements);

    /// <summary>
    /// Resets this ChartMatrix to have the elements of the identity matrix.
    /// </summary>
    public void Reset()
    {
        _elements[0] = 1f;
        _elements[1] = 0f;
        _elements[2] = 0f;
        _elements[3] = 1f;
        _elements[4] = 0f;
        _elements[5] = 0f;
    }

    /// <summary>
    /// Multiplies this ChartMatrix by the specified ChartMatrix by prepending the specified ChartMatrix.
    /// </summary>
    public void Multiply(ChartMatrix matrix) => Multiply(matrix, ChartMatrixOrder.Prepend);

    /// <summary>
    /// Multiplies this ChartMatrix by the specified ChartMatrix in the specified order.
    /// </summary>
    public void Multiply(ChartMatrix matrix, ChartMatrixOrder order)
    {
        var other = matrix._elements;
        float[] result = new float[6];

        if (order == ChartMatrixOrder.Prepend)
        {
            // result = matrix * this
            result[0] = other[0] * _elements[0] + other[1] * _elements[2];
            result[1] = other[0] * _elements[1] + other[1] * _elements[3];
            result[2] = other[2] * _elements[0] + other[3] * _elements[2];
            result[3] = other[2] * _elements[1] + other[3] * _elements[3];
            result[4] = other[4] * _elements[0] + other[5] * _elements[2] + _elements[4];
            result[5] = other[4] * _elements[1] + other[5] * _elements[3] + _elements[5];
        }
        else
        {
            // result = this * matrix
            result[0] = _elements[0] * other[0] + _elements[1] * other[2];
            result[1] = _elements[0] * other[1] + _elements[1] * other[3];
            result[2] = _elements[2] * other[0] + _elements[3] * other[2];
            result[3] = _elements[2] * other[1] + _elements[3] * other[3];
            result[4] = _elements[4] * other[0] + _elements[5] * other[2] + other[4];
            result[5] = _elements[4] * other[1] + _elements[5] * other[3] + other[5];
        }

        Array.Copy(result, _elements, 6);
    }

    /// <summary>
    /// Applies the specified translation vector to this ChartMatrix by prepending the translation vector.
    /// </summary>
    public void Translate(float offsetX, float offsetY) => Translate(offsetX, offsetY, ChartMatrixOrder.Prepend);

    /// <summary>
    /// Applies the specified translation vector to this ChartMatrix in the specified order.
    /// </summary>
    public void Translate(float offsetX, float offsetY, ChartMatrixOrder order)
    {
        if (order == ChartMatrixOrder.Prepend)
        {
            _elements[4] += offsetX * _elements[0] + offsetY * _elements[2];
            _elements[5] += offsetX * _elements[1] + offsetY * _elements[3];
        }
        else
        {
            _elements[4] += offsetX;
            _elements[5] += offsetY;
        }
    }

    /// <summary>
    /// Applies the specified scale vector to this ChartMatrix by prepending the scale vector.
    /// </summary>
    public void Scale(float scaleX, float scaleY) => Scale(scaleX, scaleY, ChartMatrixOrder.Prepend);

    /// <summary>
    /// Applies the specified scale vector to this ChartMatrix in the specified order.
    /// </summary>
    public void Scale(float scaleX, float scaleY, ChartMatrixOrder order)
    {
        if (order == ChartMatrixOrder.Prepend)
        {
            _elements[0] *= scaleX;
            _elements[1] *= scaleX;
            _elements[2] *= scaleY;
            _elements[3] *= scaleY;
        }
        else
        {
            _elements[0] *= scaleX;
            _elements[2] *= scaleX;
            _elements[4] *= scaleX;
            _elements[1] *= scaleY;
            _elements[3] *= scaleY;
            _elements[5] *= scaleY;
        }
    }

    /// <summary>
    /// Applies a clockwise rotation of the specified angle about the origin to this ChartMatrix.
    /// </summary>
    public void Rotate(float angle) => Rotate(angle, ChartMatrixOrder.Prepend);

    /// <summary>
    /// Applies a clockwise rotation of the specified angle about the origin to this ChartMatrix in the specified order.
    /// </summary>
    public void Rotate(float angle, ChartMatrixOrder order)
    {
        float radians = angle * (float)Math.PI / 180f;
        float cos = (float)Math.Cos(radians);
        float sin = (float)Math.Sin(radians);

        var rotation = new ChartMatrix(cos, sin, -sin, cos, 0, 0);
        Multiply(rotation, order);
    }

    /// <summary>
    /// Applies a clockwise rotation of the specified angle about the specified point to this ChartMatrix.
    /// </summary>
    public void RotateAt(float angle, ChartPointF point) => RotateAt(angle, point, ChartMatrixOrder.Prepend);

    /// <summary>
    /// Applies a clockwise rotation of the specified angle about the specified point to this ChartMatrix in the specified order.
    /// </summary>
    public void RotateAt(float angle, ChartPointF point, ChartMatrixOrder order)
    {
        if (order == ChartMatrixOrder.Prepend)
        {
            Translate(point.X, point.Y, ChartMatrixOrder.Prepend);
            Rotate(angle, ChartMatrixOrder.Prepend);
            Translate(-point.X, -point.Y, ChartMatrixOrder.Prepend);
        }
        else
        {
            Translate(-point.X, -point.Y, ChartMatrixOrder.Append);
            Rotate(angle, ChartMatrixOrder.Append);
            Translate(point.X, point.Y, ChartMatrixOrder.Append);
        }
    }

    /// <summary>
    /// Applies the specified shear vector to this ChartMatrix by prepending the shear transformation.
    /// </summary>
    public void Shear(float shearX, float shearY) => Shear(shearX, shearY, ChartMatrixOrder.Prepend);

    /// <summary>
    /// Applies the specified shear vector to this ChartMatrix in the specified order.
    /// </summary>
    public void Shear(float shearX, float shearY, ChartMatrixOrder order)
    {
        var shear = new ChartMatrix(1, shearY, shearX, 1, 0, 0);
        Multiply(shear, order);
    }

    /// <summary>
    /// Inverts this ChartMatrix, if it is invertible.
    /// </summary>
    public void Invert()
    {
        float det = GetDeterminant();
        if (det == 0f)
            throw new InvalidOperationException("Matrix is not invertible.");

        float invDet = 1f / det;
        float[] result = new float[6];
        result[0] = _elements[3] * invDet;
        result[1] = -_elements[1] * invDet;
        result[2] = -_elements[2] * invDet;
        result[3] = _elements[0] * invDet;
        result[4] = (_elements[2] * _elements[5] - _elements[3] * _elements[4]) * invDet;
        result[5] = (_elements[1] * _elements[4] - _elements[0] * _elements[5]) * invDet;

        Array.Copy(result, _elements, 6);
    }

    /// <summary>
    /// Applies the geometric transform represented by this ChartMatrix to a specified point.
    /// </summary>
    public ChartPointF TransformPoint(ChartPointF pt)
    {
        return new ChartPointF(
            pt.X * _elements[0] + pt.Y * _elements[2] + _elements[4],
            pt.X * _elements[1] + pt.Y * _elements[3] + _elements[5]
        );
    }

    /// <summary>
    /// Applies the geometric transform represented by this ChartMatrix to a specified array of points.
    /// </summary>
    public void TransformPoints(ChartPointF[] pts)
    {
        for (int i = 0; i < pts.Length; i++)
        {
            pts[i] = TransformPoint(pts[i]);
        }
    }

    /// <summary>
    /// Multiplies each vector in an array by the matrix, ignoring the translation elements.
    /// </summary>
    public void TransformVectors(ChartPointF[] pts)
    {
        for (int i = 0; i < pts.Length; i++)
        {
            float x = pts[i].X;
            float y = pts[i].Y;
            pts[i] = new ChartPointF(
                x * _elements[0] + y * _elements[2],
                x * _elements[1] + y * _elements[3]
            );
        }
    }

    private float GetDeterminant() => _elements[0] * _elements[3] - _elements[1] * _elements[2];

    /// <summary>
    /// Converts this ChartMatrix to an SVG transform attribute value.
    /// </summary>
    public string ToSvgTransform() =>
        $"matrix({_elements[0]:G9} {_elements[1]:G9} {_elements[2]:G9} {_elements[3]:G9} {_elements[4]:G9} {_elements[5]:G9})";

    /// <summary>
    /// Determines whether the specified object is equal to the current object.
    /// </summary>
    public override bool Equals(object? obj) => obj is ChartMatrix other && Equals(other);

    /// <summary>
    /// Determines whether the specified ChartMatrix is equal to the current ChartMatrix.
    /// </summary>
    public bool Equals(ChartMatrix? other)
    {
        if (other is null) return false;
        for (int i = 0; i < 6; i++)
        {
            if (_elements[i] != other._elements[i]) return false;
        }
        return true;
    }

    /// <summary>
    /// Returns a hash code for this ChartMatrix.
    /// </summary>
    public override int GetHashCode() => HashCode.Combine(_elements[0], _elements[1], _elements[2], _elements[3], _elements[4], _elements[5]);

    /// <summary>
    /// Releases all resources used by this ChartMatrix.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases the unmanaged resources used by the ChartMatrix and optionally releases the managed resources.
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            _disposed = true;
        }
    }
}

/// <summary>
/// Specifies the order for matrix transform operations.
/// </summary>
public enum ChartMatrixOrder
{
    /// <summary>
    /// The new operation is applied before the old operation.
    /// </summary>
    Prepend = 0,

    /// <summary>
    /// The new operation is applied after the old operation.
    /// </summary>
    Append = 1
}
