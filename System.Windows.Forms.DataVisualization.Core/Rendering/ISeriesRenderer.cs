// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Layout;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Interface for series renderers that handle specific chart types.
/// Each chart type (Line, Bar, Pie, etc.) has its own implementation.
/// </summary>
public interface ISeriesRenderer
{
    /// <summary>
    /// Renders a data series.
    /// </summary>
    /// <param name="engine">The rendering engine.</param>
    /// <param name="seriesLayout">The series layout with calculated positions.</param>
    /// <param name="areaLayout">The chart area layout.</param>
    void Render(IRenderingEngine engine, SeriesLayout seriesLayout, ChartAreaLayout areaLayout);

    /// <summary>
    /// Gets the chart types that this renderer can handle.
    /// </summary>
    IEnumerable<string> SupportedChartTypes { get; }
}
