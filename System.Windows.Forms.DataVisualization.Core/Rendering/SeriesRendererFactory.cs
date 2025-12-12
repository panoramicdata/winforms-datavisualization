// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Factory that provides the appropriate series renderer for a given chart type.
/// </summary>
public class SeriesRendererFactory
{
    private readonly Dictionary<string, ISeriesRenderer> _rendererCache;
    private readonly List<ISeriesRenderer> _renderers;
    private readonly ISeriesRenderer _defaultRenderer;

    /// <summary>
    /// Initializes a new instance of the <see cref="SeriesRendererFactory"/> class.
    /// </summary>
    public SeriesRendererFactory()
    {
        _rendererCache = new Dictionary<string, ISeriesRenderer>(StringComparer.OrdinalIgnoreCase);
        _renderers =
        [
            new LineSeriesRenderer(),
            new BarSeriesRenderer(),
            new AreaSeriesRenderer(),
            new PieSeriesRenderer(),
            new PointSeriesRenderer(),
            new RadarSeriesRenderer(),
            new PolarSeriesRenderer()
        ];
        _defaultRenderer = new LineSeriesRenderer();

        // Build the cache
        foreach (var renderer in _renderers)
        {
            foreach (var chartType in renderer.SupportedChartTypes)
            {
                _rendererCache[chartType] = renderer;
            }
        }
    }

    /// <summary>
    /// Gets the appropriate renderer for the specified chart type.
    /// </summary>
    /// <param name="chartType">The chart type name (e.g., "Line", "Bar", "Pie").</param>
    /// <returns>The series renderer for the chart type.</returns>
    public ISeriesRenderer GetRenderer(string chartType)
    {
        if (string.IsNullOrEmpty(chartType))
            return _defaultRenderer;

        // Try exact match first
        if (_rendererCache.TryGetValue(chartType, out var renderer))
            return renderer;

        // Try partial match
        string upperType = chartType.ToUpperInvariant();

        if (upperType.Contains("LINE") || upperType.Contains("SPLINE"))
            return _rendererCache.GetValueOrDefault("Line", _defaultRenderer);

        if (upperType.Contains("BAR") || upperType.Contains("COLUMN"))
            return _rendererCache.GetValueOrDefault("Column", _defaultRenderer);

        if (upperType.Contains("AREA"))
            return _rendererCache.GetValueOrDefault("Area", _defaultRenderer);

        if (upperType.Contains("PIE") || upperType.Contains("DOUGHNUT"))
            return _rendererCache.GetValueOrDefault("Pie", _defaultRenderer);

        if (upperType.Contains("POINT") || upperType.Contains("SCATTER") || upperType.Contains("BUBBLE"))
            return _rendererCache.GetValueOrDefault("Point", _defaultRenderer);

        if (upperType.Contains("RADAR"))
            return _rendererCache.GetValueOrDefault("Radar", _defaultRenderer);

        if (upperType.Contains("POLAR"))
            return _rendererCache.GetValueOrDefault("Polar", _defaultRenderer);

        // Default to line renderer
        return _defaultRenderer;
    }

    /// <summary>
    /// Registers a custom series renderer.
    /// </summary>
    /// <param name="renderer">The renderer to register.</param>
    public void RegisterRenderer(ISeriesRenderer renderer)
    {
        ArgumentNullException.ThrowIfNull(renderer);

        _renderers.Add(renderer);

        foreach (var chartType in renderer.SupportedChartTypes)
        {
            _rendererCache[chartType] = renderer;
        }
    }

    /// <summary>
    /// Gets all registered renderers.
    /// </summary>
    public IReadOnlyList<ISeriesRenderer> Renderers => _renderers.AsReadOnly();
}
