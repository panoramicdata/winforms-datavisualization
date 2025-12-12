# Copilot Instructions for WinForms DataVisualization Library

## Project Overview

This is the **System.Windows.Forms.DataVisualization** charting library being modernized to support multiple rendering targets (WinForms GDI+, SVG, Blazor WebAssembly).

## ?? CRITICAL: WinForms Pixel-Perfect Preservation

**THE WINFORMS CHART OUTPUT MUST NEVER CHANGE. NOT A SINGLE PIXEL.**

The WinForms `Chart` control is the **reference implementation**. It is working correctly and producing perfect output. Any modernization work must:

1. **NEVER modify the WinForms rendering pipeline** in a way that changes output
2. **EXTRACT, don't rewrite** - When moving layout/rendering code to Core, extract the exact existing logic
3. **VERIFY pixel-perfect fidelity** - Any refactoring must produce byte-identical output
4. **TEST before and after** - Compare rendered output to ensure no regression

### Layout Engine Strategy

The goal is to share layout logic between WinForms and SVG/Blazor. The approach:

1. **Phase 1**: Extract WinForms layout logic verbatim into Core (keeping WinForms working unchanged)
2. **Phase 2**: Add abstraction layer so WinForms can optionally use Core layout
3. **Phase 3**: Verify pixel-perfect output with Core layout vs original
4. **Phase 4**: Only then can SVG/Blazor use the same Core layout

**DO NOT create simplified/new layout algorithms.** The WinForms layout code is battle-tested and produces correct output.

---

## Architecture Principles

### Core Library Approach

The modernization follows these key principles:

1. **Types move to Core project, maintaining namespaces**: When abstracting types to the platform-agnostic `System.Windows.Forms.DataVisualization.Core` project, they should:
   - Keep the **same namespace** (`System.Windows.Forms.DataVisualization.Charting`) to avoid breaking changes
   - Be **removed from the WinForms project** to prevent duplicate definitions
   - Consumers should be able to use both Core and WinForms assemblies without namespace conflicts

2. **Internal vs Public for Core types**: 
   - Types that already exist as `public` in the WinForms project should remain `public` there
   - If Core needs similar types for internal use, they should be marked `internal` to prevent conflicts
   - Only expose types as `public` in Core when they are meant to replace WinForms types

3. **Platform-Agnostic Primitives**: The Core project contains platform-agnostic replacements for System.Drawing types:
   - `ChartPointF` (replaces `PointF`)
   - `ChartRectangleF` (replaces `RectangleF`)
   - `ChartSizeF` (replaces `SizeF`)
   - `ChartColor` (replaces `Color`)
   - `ChartFont` (replaces `Font`)
   - `ChartPen`, `ChartBrush`, `ChartMatrix`, `ChartPath`, `ChartStringFormat`

4. **Rendering Abstraction**: 
   - `IRenderingEngine` in Core defines the abstract rendering contract
   - `IPrimitiveConverter<T...>` provides type conversion between Chart types and platform types
   - `RenderingEngineAdapter<T...>` is a base class for implementing renderers
   - `GdiRenderingEngine` in WinForms implements the GDI+ rendering

### Project Dependencies

```
ChartSamples (WinForms App)
    ??? System.Windows.Forms.DataVisualization (WinForms library)
            ??? System.Windows.Forms.DataVisualization.Core (Platform-agnostic)
```

### When Adding New Types

1. **Shared types** (data models, chart types, etc.): 
   - Add to Core project in `System.Windows.Forms.DataVisualization.Charting` namespace
   - Remove duplicates from WinForms project

2. **WinForms-specific types** (controls, GDI+ rendering, designers):
   - Keep in WinForms project

3. **Interfaces for abstraction**:
   - Define in Core with `I` prefix (e.g., `IChartTypeInfo`, `IDataPoint`)
   - WinForms classes implement these interfaces

### Common Issues to Avoid

- **CS0433 Ambiguous type errors**: Occur when same type name exists in both assemblies. Fix by:
  - Removing the duplicate from WinForms (preferred if type should be in Core)
  - Making the Core version `internal` (if WinForms version should remain public)
  
- **Namespace conflicts**: Always use the same namespace in Core as the original WinForms location

## File Locations

- **Core Project**: `System.Windows.Forms.DataVisualization.Core/`
  - Primitives: `Primitives/`
  - Rendering interfaces: `Rendering/`
  - Data interfaces: `Data/`
  - Chart type base: `ChartTypes/`

- **WinForms Project**: `System.Windows.Forms.DataVisualization/`
  - GDI+ rendering: `Charting/General/GdiRenderingEngine.cs`, `GdiPrimitiveConverter.cs`
  - Chart control: `Charting/`

- **Blazor Project**: `ChartSamples.Blazor/`
  - Sample pages mirroring WinForms `ChartSamples/`

- **Master Plan**: `MASTER_PLAN.md` - Contains full modernization roadmap

---

## Blazor Chart Samples - Migration Parity Guidelines

### Key Principle: Same Code, Different Rendering

**The developer should use the same code to set up charts in both WinForms and Blazor.** This includes:

- **Namespaces**: Use equivalent namespaces that mirror the WinForms structure
- **Enums**: Chart types, marker styles, line styles should use the same enum names
- **Properties**: Chart configuration properties should have identical names and behaviors
- **Data binding patterns**: Similar approaches to populating chart data

The only difference should be **how the chart is rendered**:
- WinForms: `System.Windows.Forms.DataVisualization.Charting.Chart` renders to GDI+
- Blazor: `Svg.DataVisualization.SvgChart` renders to SVG

### Migration Strategy

When a developer migrates from WinForms to Blazor:

1. **Replace the Chart control** - Swap `Chart` for `SvgChart`
2. **Update namespace imports** - Change `System.Windows.Forms.DataVisualization.Charting` to `Svg.DataVisualization`
3. **Keep the chart configuration code** - All property settings, data population, and styling should work with minimal changes

### Enum Parity Requirements

Ensure Blazor/SVG enums match WinForms naming:

| WinForms Enum | Blazor/SVG Equivalent |
|---------------|----------------------|
| `SeriesChartType.Line` | `SvgChartType.Line` |
| `SeriesChartType.Spline` | `SvgChartType.Spline` |
| `SeriesChartType.StepLine` | `SvgChartType.StepLine` |
| `MarkerStyle.Circle` | `SvgMarkerStyle.Circle` |
| `MarkerStyle.Diamond` | `SvgMarkerStyle.Diamond` |
| `ChartDashStyle.Solid` | Should have equivalent |

### Sample Page Structure

Each Blazor sample page should mirror the WinForms sample exactly:

1. **Same title and description text**
2. **Same control options** (dropdowns, checkboxes with same labels and values)
3. **Same default values**
4. **Same chart dimensions** (e.g., 412×296 for standard samples)
5. **Same data values** where applicable
6. **Same C# code snippet** showing the WinForms configuration

### Control Panel Mapping

| WinForms Control | Blazor Equivalent |
|-----------------|-------------------|
| `ComboBox` | `<select>` with `@bind` |
| `CheckBox` | `<input type="checkbox">` with `@bind` |
| `TextBox` | `<input type="text">` with `@bind` |
| `NumericUpDown` | `<input type="number">` with `@bind` |
| `Label` | `<label>` or `<span>` |

### Standard Sample Layout

```razor
<SampleBase Title="..." Description="..." CSharpCode="@_csharpCode">
    <div class="sample-layout">
        <div class="chart-panel">
            <ChartViewer Width="412" Height="296" Configure="@ConfigureChart" />
        </div>
        <div class="control-panel">
            <!-- Controls matching WinForms exactly -->
        </div>
    </div>
    <div class="sample-note">
        <!-- Additional description text from WinForms label3 -->
    </div>
</SampleBase>
```

### Code Snippets

The `CSharpCode` parameter should show WinForms-compatible code demonstrating:
- How to configure the same settings in WinForms
- Exact property names and enum values used
- Data population patterns

This helps developers understand their migration path.

### When Creating New Sample Pages

1. **Find the WinForms equivalent** in `ChartSamples/` directory
2. **Copy the exact title and description** from the WinForms sample
3. **Replicate all controls** with the same labels and options
4. **Use the same default values**
5. **Match the chart configuration code** as closely as possible
6. **Include the explanatory note** at the bottom if present in WinForms
