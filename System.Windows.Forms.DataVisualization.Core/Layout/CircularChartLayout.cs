// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.ChartTypes;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting.Layout;

/// <summary>
/// Contains the calculated layout for a circular chart area (Radar, Polar).
/// </summary>
public class CircularChartAreaLayout : ChartAreaLayout
{
    /// <summary>
    /// Gets or sets the center point of the circular area in absolute pixels.
    /// </summary>
    public ChartPointF Center { get; set; }

    /// <summary>
    /// Gets or sets the radius of the circular area in pixels.
    /// </summary>
    public float Radius { get; set; }

    /// <summary>
    /// Gets or sets the number of sectors (spokes) in the chart.
    /// </summary>
    public int SectorCount { get; set; }

    /// <summary>
    /// Gets or sets the angle between sectors in degrees.
    /// </summary>
    public float SectorAngle { get; set; }

    /// <summary>
    /// Gets or sets whether to draw as polygon (true) or circles (false).
    /// </summary>
    public bool UsePolygons { get; set; }

    /// <summary>
    /// Gets the collection of circular axis layouts (one per sector).
    /// </summary>
    public List<CircularAxisLayout> CircularAxes { get; } = [];

    /// <summary>
    /// Gets or sets the circular labels style.
    /// </summary>
    public CircularAxisLabelsStyle LabelsStyle { get; set; } = CircularAxisLabelsStyle.Horizontal;

    /// <summary>
    /// Gets or sets the minimum Y axis value.
    /// </summary>
    public double YAxisMinimum { get; set; }

    /// <summary>
    /// Gets or sets the maximum Y axis value.
    /// </summary>
    public double YAxisMaximum { get; set; }

    /// <summary>
    /// Gets the collection of circular grid lines (concentric circles or polygons).
    /// </summary>
    public List<CircularGridLayout> GridLines { get; } = [];

    /// <summary>
    /// Converts a Y value and angle to a pixel position.
    /// </summary>
    /// <param name="yValue">The Y data value (distance from center).</param>
    /// <param name="angleDegrees">The angle in degrees.</param>
    /// <returns>The calculated pixel position.</returns>
    public ChartPointF ValueToPosition(double yValue, float angleDegrees)
    {
        // Normalize Y value to 0-1 range based on axis min/max
        double range = YAxisMaximum - YAxisMinimum;
        if (range <= 0) range = 1;

        double normalizedY = (yValue - YAxisMinimum) / range;
        normalizedY = Math.Max(0, Math.Min(1, normalizedY)); // Clamp to 0-1

        // Calculate distance from center
        float distance = (float)(normalizedY * Radius);

        // Convert angle to radians (0 degrees is at top, clockwise)
        // Subtract 90 to make 0 degrees point up
        double angleRadians = (angleDegrees - 90) * Math.PI / 180.0;

        // Calculate position
        float x = Center.X + distance * (float)Math.Cos(angleRadians);
        float y = Center.Y + distance * (float)Math.Sin(angleRadians);

        return new ChartPointF(x, y);
    }

    /// <summary>
    /// Converts an angle index to degrees.
    /// </summary>
    /// <param name="index">The sector index.</param>
    /// <returns>The angle in degrees.</returns>
    public float IndexToAngle(int index)
    {
        if (SectorCount <= 0) return 0;
        return SectorAngle * index;
    }
}

/// <summary>
/// Contains the calculated layout for a circular axis (spoke).
/// </summary>
public class CircularAxisLayout
{
    /// <summary>
    /// Gets or sets the index of this axis.
    /// </summary>
    public int Index { get; set; }

    /// <summary>
    /// Gets or sets the angle of this axis in degrees (0-360, 0 at top).
    /// </summary>
    public float Angle { get; set; }

    /// <summary>
    /// Gets or sets the start position (center of chart).
    /// </summary>
    public ChartPointF StartPosition { get; set; }

    /// <summary>
    /// Gets or sets the end position (at the edge).
    /// </summary>
    public ChartPointF EndPosition { get; set; }

    /// <summary>
    /// Gets or sets the label text for this axis.
    /// </summary>
    public string Label { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the label position.
    /// </summary>
    public ChartPointF LabelPosition { get; set; }

    /// <summary>
    /// Gets or sets the label color.
    /// </summary>
    public ChartColor LabelColor { get; set; } = ChartColor.Black;

    /// <summary>
    /// Gets or sets the label bounds.
    /// </summary>
    public ChartRectangleF LabelBounds { get; set; }

    /// <summary>
    /// Gets or sets the label angle (for rotated labels).
    /// </summary>
    public float LabelAngle { get; set; }
}

/// <summary>
/// Contains the calculated layout for a circular grid line (concentric circle or polygon).
/// </summary>
public class CircularGridLayout
{
    /// <summary>
    /// Gets or sets the Y value this grid line represents.
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// Gets or sets the radius of this grid line.
    /// </summary>
    public float Radius { get; set; }

    /// <summary>
    /// Gets or sets whether this is a major grid line.
    /// </summary>
    public bool IsMajor { get; set; } = true;

    /// <summary>
    /// Gets the polygon points (if UsePolygons is true).
    /// </summary>
    public List<ChartPointF> PolygonPoints { get; } = [];
}

/// <summary>
/// Contains the calculated layout for a data point in a circular chart.
/// </summary>
public class CircularDataPointLayout : DataPointLayout
{
    /// <summary>
    /// Gets or sets the angle of this point in degrees.
    /// </summary>
    public float Angle { get; set; }

    /// <summary>
    /// Gets or sets the normalized distance from center (0-1).
    /// </summary>
    public float NormalizedDistance { get; set; }

    /// <summary>
    /// Gets or sets the sector index for this point.
    /// </summary>
    public int SectorIndex { get; set; }
}
