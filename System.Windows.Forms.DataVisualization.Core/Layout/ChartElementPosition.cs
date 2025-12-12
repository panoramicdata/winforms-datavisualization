// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Interface representing a chart element position using relative coordinates (0-100).
/// This is the platform-agnostic version of ElementPosition used in layout calculations.
/// </summary>
public interface IElementPosition
{
    /// <summary>
    /// Gets or sets the X position of the element (0-100).
    /// </summary>
    float X { get; set; }

    /// <summary>
    /// Gets or sets the Y position of the element (0-100).
    /// </summary>
    float Y { get; set; }

    /// <summary>
    /// Gets or sets the width of the element (0-100).
    /// </summary>
    float Width { get; set; }

    /// <summary>
    /// Gets or sets the height of the element (0-100).
    /// </summary>
    float Height { get; set; }

    /// <summary>
    /// Gets or sets a flag indicating whether the position is calculated automatically.
    /// </summary>
    bool Auto { get; set; }

    /// <summary>
    /// Gets the right position (X + Width).
    /// </summary>
    float Right { get; }

    /// <summary>
    /// Gets the bottom position (Y + Height).
    /// </summary>
    float Bottom { get; }

    /// <summary>
    /// Gets the size of the element.
    /// </summary>
    ChartSizeF Size { get; }

    /// <summary>
    /// Converts the element position to a ChartRectangleF.
    /// </summary>
    /// <returns>A ChartRectangleF representing the position.</returns>
    ChartRectangleF ToRectangleF();

    /// <summary>
    /// Sets the position from a ChartRectangleF.
    /// </summary>
    /// <param name="rect">The rectangle to set from.</param>
    void FromRectangleF(ChartRectangleF rect);

    /// <summary>
    /// Sets the position without modifying the Auto property.
    /// </summary>
    /// <param name="x">X position.</param>
    /// <param name="y">Y position.</param>
    /// <param name="width">Width.</param>
    /// <param name="height">Height.</param>
    void SetPositionNoAuto(float x, float y, float width, float height);
}

/// <summary>
/// Core implementation of element position using relative coordinates (0-100).
/// This class represents the position and size of a chart element in relative coordinates,
/// where (0,0) is the top-left corner and (100,100) is the bottom-right corner.
/// </summary>
public class ChartElementPosition : IElementPosition
{
    private float _x;
    private float _y;
    private float _width;
    private float _height;
    private bool _auto = true;

    /// <summary>
    /// Initializes a new instance of the ChartElementPosition class.
    /// </summary>
    public ChartElementPosition()
    {
    }

    /// <summary>
    /// Initializes a new instance of the ChartElementPosition class with specified values.
    /// </summary>
    /// <param name="x">X position (0-100).</param>
    /// <param name="y">Y position (0-100).</param>
    /// <param name="width">Width (0-100).</param>
    /// <param name="height">Height (0-100).</param>
    public ChartElementPosition(float x, float y, float width, float height)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;
        _auto = false;
    }

    /// <inheritdoc/>
    public float X
    {
        get => _x;
        set
        {
            ValidateCoordinate(value, nameof(X));
            _x = value;
            _auto = false;
            AdjustWidth();
        }
    }

    /// <inheritdoc/>
    public float Y
    {
        get => _y;
        set
        {
            ValidateCoordinate(value, nameof(Y));
            _y = value;
            _auto = false;
            AdjustHeight();
        }
    }

    /// <inheritdoc/>
    public float Width
    {
        get => _width;
        set
        {
            ValidateCoordinate(value, nameof(Width));
            _width = value;
            _auto = false;
            AdjustX();
        }
    }

    /// <inheritdoc/>
    public float Height
    {
        get => _height;
        set
        {
            ValidateCoordinate(value, nameof(Height));
            _height = value;
            _auto = false;
            AdjustY();
        }
    }

    /// <inheritdoc/>
    public bool Auto
    {
        get => _auto;
        set
        {
            if (value != _auto)
            {
                if (value)
                {
                    _x = 0;
                    _y = 0;
                    _width = 0;
                    _height = 0;
                }
                _auto = value;
            }
        }
    }

    /// <inheritdoc/>
    public float Right => _x + _width;

    /// <inheritdoc/>
    public float Bottom => _y + _height;

    /// <inheritdoc/>
    public ChartSizeF Size => new(_width, _height);

    /// <inheritdoc/>
    public ChartRectangleF ToRectangleF() => new(_x, _y, _width, _height);

    /// <inheritdoc/>
    public void FromRectangleF(ChartRectangleF rect)
    {
        _x = rect.X;
        _y = rect.Y;
        _width = rect.Width;
        _height = rect.Height;
        _auto = false;
    }

    /// <inheritdoc/>
    public void SetPositionNoAuto(float x, float y, float width, float height)
    {
        bool oldAuto = _auto;
        _x = x;
        _y = y;
        _width = width;
        _height = height;
        _auto = oldAuto;
    }

    /// <summary>
    /// Creates a copy of this position.
    /// </summary>
    /// <returns>A new ChartElementPosition with the same values.</returns>
    public ChartElementPosition Clone()
    {
        return new ChartElementPosition
        {
            _x = _x,
            _y = _y,
            _width = _width,
            _height = _height,
            _auto = _auto
        };
    }

    /// <summary>
    /// Determines whether the specified object is equal to the current position.
    /// </summary>
    public override bool Equals(object? obj)
    {
        if (obj is ChartElementPosition other)
        {
            if (_auto && other._auto)
                return true;
            return _x == other._x && _y == other._y && 
                   _width == other._width && _height == other._height;
        }
        return false;
    }

    /// <summary>
    /// Returns a hash code for this position.
    /// </summary>
    public override int GetHashCode()
    {
        return HashCode.Combine(_x, _y, _width, _height, _auto);
    }

    /// <summary>
    /// Returns a string representation of the position.
    /// </summary>
    public override string ToString()
    {
        if (_auto)
            return "Auto";
        return $"{_x}, {_y}, {_width}, {_height}";
    }

    #region Helper Methods

    private static void ValidateCoordinate(float value, string paramName)
    {
        if (value < 0.0 || value > 100.0)
        {
            throw new ArgumentOutOfRangeException(paramName, 
                $"The {paramName} value must be between 0 and 100.");
        }
    }

    private void AdjustWidth()
    {
        if (_x + _width > 100)
            _width = 100 - _x;
    }

    private void AdjustHeight()
    {
        if (_y + _height > 100)
            _height = 100 - _y;
    }

    private void AdjustX()
    {
        if (_x + _width > 100)
            _x = 100 - _width;
    }

    private void AdjustY()
    {
        if (_y + _height > 100)
            _y = 100 - _height;
    }

    #endregion
}
