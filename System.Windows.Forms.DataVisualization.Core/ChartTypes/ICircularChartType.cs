// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting.ChartTypes;

/// <summary>
/// ICircularChartType interface provides behavior information for circular 
/// chart types like Radar or Polar. This interface defines how circular
/// charts should be laid out and rendered.
/// </summary>
public interface ICircularChartType
{
    /// <summary>
    /// Checks if closed figure should be drawn even in Line drawing mode.
    /// For Radar charts, this returns true (data forms a closed polygon).
    /// For Polar charts, this returns false (data can be open).
    /// </summary>
    /// <returns>True if closed figure should be drawn even in Line drawing mode.</returns>
    bool RequireClosedFigure();

    /// <summary>
    /// Checks if Y axis position may be changed using X axis Crossing property.
    /// For Radar charts, this returns false.
    /// For Polar charts, this returns true (Y axis can rotate around center).
    /// </summary>
    /// <returns>True if Y axis position may be changed using X axis Crossing property.</returns>
    bool XAxisCrossingSupported();

    /// <summary>
    /// Checks if automatic X axis labels are supported.
    /// For Radar charts, this returns false (labels come from data points).
    /// For Polar charts, this returns true (labels are angle values).
    /// </summary>
    /// <returns>True if automatic X axis labels are supported.</returns>
    bool XAxisLabelsSupported();

    /// <summary>
    /// Checks if radial grid lines (X axis) are supported by the chart type.
    /// </summary>
    /// <returns>True if radial grid lines are supported.</returns>
    bool RadialGridLinesSupported();

    /// <summary>
    /// Gets number of sectors in the circular chart area.
    /// For Radar charts, this is the number of data points.
    /// For Polar charts, this is typically 12 (30-degree increments) or based on axis interval.
    /// </summary>
    /// <param name="series">Collection of series to calculate sectors for.</param>
    /// <returns>Returns number of sectors in circular chart.</returns>
    int GetNumberOfSectors(IReadOnlyList<ISeriesModel> series);

    /// <summary>
    /// Get a location of each Y axis in degrees.
    /// For Radar charts, this returns positions at each sector.
    /// For Polar charts, this typically returns a single position (can be modified by crossing).
    /// </summary>
    /// <param name="sectorCount">Number of sectors in the chart.</param>
    /// <param name="axisCrossing">Optional axis crossing value for rotation.</param>
    /// <returns>Returns an array of one or more locations of Y axis in degrees.</returns>
    float[] GetYAxisLocations(int sectorCount, double? axisCrossing = null);
}

/// <summary>
/// Circular chart drawing style for Radar charts.
/// </summary>
public enum RadarDrawingStyle
{
    /// <summary>
    /// Series are drawn as filled areas.
    /// </summary>
    Area,

    /// <summary>
    /// Series are drawn as lines.
    /// </summary>
    Line,

    /// <summary>
    /// Series are drawn as markers only.
    /// </summary>
    Marker
}

/// <summary>
/// Polar chart drawing style.
/// </summary>
public enum PolarDrawingStyle
{
    /// <summary>
    /// Series are drawn as lines.
    /// </summary>
    Line,

    /// <summary>
    /// Series are drawn as markers only.
    /// </summary>
    Marker
}

/// <summary>
/// Style for labels around circular chart area.
/// </summary>
public enum CircularAxisLabelsStyle
{
    /// <summary>
    /// Automatic label positioning.
    /// </summary>
    Auto,

    /// <summary>
    /// Labels follow the circular path.
    /// </summary>
    Circular,

    /// <summary>
    /// Labels radiate outward from center.
    /// </summary>
    Radial,

    /// <summary>
    /// Labels are always horizontal.
    /// </summary>
    Horizontal
}

/// <summary>
/// Style for the circular area background.
/// </summary>
public enum CircularAreaDrawingStyle
{
    /// <summary>
    /// Background is drawn as a circle.
    /// </summary>
    Circle,

    /// <summary>
    /// Background is drawn as a polygon matching the number of sectors.
    /// </summary>
    Polygon
}
