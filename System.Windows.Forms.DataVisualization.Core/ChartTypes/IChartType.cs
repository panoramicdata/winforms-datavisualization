// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Defines how series/points should be displayed in the legend.
/// </summary>
internal enum LegendImageStyle
{
    /// <summary>
    /// The legend displays a filled rectangle.
    /// </summary>
    Rectangle,

    /// <summary>
    /// The legend displays a line.
    /// </summary>
    Line,

    /// <summary>
    /// The legend displays a marker.
    /// </summary>
    Marker
}

/// <summary>
/// Platform-agnostic interface that defines the contract for chart type metadata.
/// This interface provides information about chart type behavior and rendering requirements
/// without the platform-specific rendering methods.
/// </summary>
/// <remarks>
/// This is a Core library interface. The WinForms project has its own 
/// <c>System.Windows.Forms.DataVisualization.Charting.ChartTypes.IChartType</c> interface 
/// that extends this with platform-specific rendering methods.
/// </remarks>
public interface IChartTypeInfo : IDisposable
{
    #region Properties

    /// <summary>
    /// Gets the unique name of the chart type.
    /// </summary>
    string Name { get; }

    /// <summary>
    /// Gets a value indicating whether this chart type is stacked.
    /// </summary>
    bool Stacked { get; }

    /// <summary>
    /// Gets a value indicating whether this stacked chart type supports groups.
    /// </summary>
    bool SupportStackedGroups { get; }

    /// <summary>
    /// Gets a value indicating whether stacked chart type should draw 
    /// positive and negative data points separately (Bar and Column Stacked types).
    /// </summary>
    bool StackSign { get; }

    /// <summary>
    /// Gets a value indicating whether this chart type requires axes.
    /// </summary>
    bool RequireAxes { get; }

    /// <summary>
    /// Gets a value indicating whether this chart type requires a circular chart area.
    /// </summary>
    bool CircularChartArea { get; }

    /// <summary>
    /// Gets a value indicating whether this chart type supports logarithmic axes.
    /// </summary>
    bool SupportLogarithmicAxes { get; }

    /// <summary>
    /// Gets a value indicating whether this chart type requires switching the value (Y) axes position.
    /// </summary>
    bool SwitchValueAxes { get; }

    /// <summary>
    /// Gets a value indicating whether chart series can be placed side-by-side.
    /// </summary>
    bool SideBySideSeries { get; }

    /// <summary>
    /// Gets a value indicating whether each data point must be represented in the legend.
    /// </summary>
    bool DataPointsInLegend { get; }

    /// <summary>
    /// Gets a value indicating whether palette colors should be applied to each data point.
    /// If false, the color is applied to the series.
    /// </summary>
    bool ApplyPaletteColorsToPoints { get; }

    /// <summary>
    /// Gets a value indicating whether extra Y values are connected to the scale of the Y axis.
    /// </summary>
    bool ExtraYValuesConnectedToYAxis { get; }

    /// <summary>
    /// Gets a value indicating whether the crossing value should be automatically set to zero
    /// for this chart type (Bar, Column, Area, etc.).
    /// </summary>
    bool ZeroCrossing { get; }

    /// <summary>
    /// Gets the number of Y values per point supported by this chart type.
    /// </summary>
    int YValuesPerPoint { get; }

    /// <summary>
    /// Gets a value indicating whether this chart type uses two Y values for scale (e.g., Bubble chart).
    /// </summary>
    bool SecondYScale { get; }

    /// <summary>
    /// Gets a value indicating whether this is a hundred percent chart.
    /// When true, axis scale from 0 to 100 percent should be used.
    /// </summary>
    bool HundredPercent { get; }

    /// <summary>
    /// Gets a value indicating whether negative 100% stacked values are shown
    /// on the other side of the X axis.
    /// </summary>
    bool HundredPercentSupportNegative { get; }

    #endregion
}
