// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Base class for chart type registry implementations.
/// Provides a repository for registering and retrieving chart types.
/// </summary>
public abstract class ChartTypeRegistryBase : IDisposable
{
    /// <summary>
    /// Storage for registered chart types (name -> type).
    /// </summary>
    protected readonly Dictionary<string, Type> RegisteredChartTypes = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Storage for created chart type instances.
    /// </summary>
    protected readonly Dictionary<string, IChartTypeInfo> CreatedChartTypes = new(StringComparer.OrdinalIgnoreCase);

    /// <summary>
    /// Registers a chart type with the specified name.
    /// </summary>
    /// <param name="name">The unique name of the chart type.</param>
    /// <param name="chartType">The type that implements IChartTypeInfo.</param>
    /// <exception cref="ArgumentException">
    /// Thrown when a chart type with the same name is already registered with a different type,
    /// or when the type does not implement IChartTypeInfo.
    /// </exception>
    public virtual void Register(string name, Type chartType)
    {
        ArgumentNullException.ThrowIfNull(name);
        ArgumentNullException.ThrowIfNull(chartType);

        // Check if chart type with specified name is already registered
        if (RegisteredChartTypes.TryGetValue(name, out var existingType))
        {
            // If same type provided - ignore
            if (existingType == chartType)
                return;

            throw new ArgumentException($"Chart type with name '{name}' is already registered.", nameof(name));
        }

        // Verify the type implements IChartTypeInfo
        if (!typeof(IChartTypeInfo).IsAssignableFrom(chartType))
        {
            throw new ArgumentException($"Type '{chartType.FullName}' must implement IChartTypeInfo interface.", nameof(chartType));
        }

        RegisteredChartTypes[name] = chartType;
    }

    /// <summary>
    /// Gets a chart type by name.
    /// </summary>
    /// <param name="name">The name of the chart type.</param>
    /// <returns>The chart type instance.</returns>
    /// <exception cref="ArgumentException">Thrown when the chart type is not registered.</exception>
    public virtual IChartTypeInfo GetChartType(string name)
    {
        ArgumentNullException.ThrowIfNull(name);

        if (!RegisteredChartTypes.ContainsKey(name))
        {
            throw new ArgumentException($"Chart type '{name}' is not registered.", nameof(name));
        }

        // Check if already created
        if (!CreatedChartTypes.TryGetValue(name, out var chartType))
        {
            // Create new instance
            var type = RegisteredChartTypes[name];
            chartType = (IChartTypeInfo?)Activator.CreateInstance(type)
                ?? throw new InvalidOperationException($"Failed to create instance of chart type '{name}'.");
            CreatedChartTypes[name] = chartType;
        }

        return chartType;
    }

    /// <summary>
    /// Checks if a chart type with the specified name is registered.
    /// </summary>
    /// <param name="name">The name of the chart type.</param>
    /// <returns>True if the chart type is registered; otherwise, false.</returns>
    public bool IsRegistered(string name)
    {
        return !string.IsNullOrEmpty(name) && RegisteredChartTypes.ContainsKey(name);
    }

    /// <summary>
    /// Gets all registered chart type names.
    /// </summary>
    /// <returns>A collection of registered chart type names.</returns>
    public IEnumerable<string> GetRegisteredChartTypeNames()
    {
        return RegisteredChartTypes.Keys;
    }

    /// <summary>
    /// Releases resources used by the chart type registry.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases resources used by the chart type registry.
    /// </summary>
    /// <param name="disposing">True to release managed resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            foreach (var chartType in CreatedChartTypes.Values)
            {
                chartType.Dispose();
            }
            CreatedChartTypes.Clear();
            RegisteredChartTypes.Clear();
        }
    }
}

/// <summary>
/// Contains constant strings defining names of all standard chart types.
/// </summary>
internal static class ChartTypeNames
{
    /// <summary>Area chart type name.</summary>
    public const string Area = "Area";

    /// <summary>Range bar chart type name.</summary>
    public const string RangeBar = "RangeBar";

    /// <summary>Bar chart type name.</summary>
    public const string Bar = "Bar";

    /// <summary>Spline area chart type name.</summary>
    public const string SplineArea = "SplineArea";

    /// <summary>Box plot chart type name.</summary>
    public const string BoxPlot = "BoxPlot";

    /// <summary>Bubble chart type name.</summary>
    public const string Bubble = "Bubble";

    /// <summary>Column chart type name.</summary>
    public const string Column = "Column";

    /// <summary>Range column chart type name.</summary>
    public const string RangeColumn = "RangeColumn";

    /// <summary>Doughnut chart type name.</summary>
    public const string Doughnut = "Doughnut";

    /// <summary>Error bar chart type name.</summary>
    public const string ErrorBar = "ErrorBar";

    /// <summary>Fast line chart type name.</summary>
    public const string FastLine = "FastLine";

    /// <summary>Fast point chart type name.</summary>
    public const string FastPoint = "FastPoint";

    /// <summary>Funnel chart type name.</summary>
    public const string Funnel = "Funnel";

    /// <summary>Pyramid chart type name.</summary>
    public const string Pyramid = "Pyramid";

    /// <summary>Kagi chart type name.</summary>
    public const string Kagi = "Kagi";

    /// <summary>Spline chart type name.</summary>
    public const string Spline = "Spline";

    /// <summary>Line chart type name.</summary>
    public const string Line = "Line";

    /// <summary>Point and figure chart type name.</summary>
    public const string PointAndFigure = "PointAndFigure";

    /// <summary>Pie chart type name.</summary>
    public const string Pie = "Pie";

    /// <summary>Point chart type name.</summary>
    public const string Point = "Point";

    /// <summary>Polar chart type name.</summary>
    public const string Polar = "Polar";

    /// <summary>Radar chart type name.</summary>
    public const string Radar = "Radar";

    /// <summary>Spline range chart type name.</summary>
    public const string SplineRange = "SplineRange";

    /// <summary>Range chart type name.</summary>
    public const string Range = "Range";

    /// <summary>Renko chart type name.</summary>
    public const string Renko = "Renko";

    /// <summary>100% stacked area chart type name.</summary>
    public const string OneHundredPercentStackedArea = "100%StackedArea";

    /// <summary>Stacked area chart type name.</summary>
    public const string StackedArea = "StackedArea";

    /// <summary>100% stacked bar chart type name.</summary>
    public const string OneHundredPercentStackedBar = "100%StackedBar";

    /// <summary>Stacked bar chart type name.</summary>
    public const string StackedBar = "StackedBar";

    /// <summary>100% stacked column chart type name.</summary>
    public const string OneHundredPercentStackedColumn = "100%StackedColumn";

    /// <summary>Stacked column chart type name.</summary>
    public const string StackedColumn = "StackedColumn";

    /// <summary>Step line chart type name.</summary>
    public const string StepLine = "StepLine";

    /// <summary>Candlestick chart type name.</summary>
    public const string Candlestick = "Candlestick";

    /// <summary>Stock chart type name.</summary>
    public const string Stock = "Stock";

    /// <summary>Three line break chart type name.</summary>
    public const string ThreeLineBreak = "ThreeLineBreak";
}
