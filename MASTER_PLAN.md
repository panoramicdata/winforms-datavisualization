# Master Plan: Data Visualization Library Modernization

## Overview

This document outlines a phased approach to modernize the `System.Windows.Forms.DataVisualization` charting library by:
1. Abstracting the data layer into a platform-agnostic core project
2. Maintaining namespace compatibility across projects
3. Introducing rendering abstractions for multiple output targets
4. Adding SVG rendering support
5. Creating a Blazor WebAssembly version of the ChartSamples application

---

## Current Architecture

```
+-------------------------------------------------------------+
|                      ChartSamples                           |
|                   (WinForms Application)                    |
+-------------------------------------------------------------+
                              |
                              v
+-------------------------------------------------------------+
|         System.Windows.Forms.DataVisualization              |
|  +--------------+  +--------------+  +-------------------+  |
|  | Data Models  |  |  Rendering   |  |  WinForms Control |  |
|  | (DataPoint,  |  | (GDI+/GDI    |  |   (Chart Control) |  |
|  |  DataSeries) |  |  Graphics)   |  |                   |  |
|  +--------------+  +--------------+  +-------------------+  |
+-------------------------------------------------------------+
```

## Target Architecture

```
+------------------+  +------------------+  +------------------+
|   ChartSamples   |  |ChartSamples.Blazor|  |  Other Future   |
|   (WinForms)     |  |   (WebAssembly)   |  |  Applications   |
+------------------+  +------------------+  +------------------+
         |                     |                     |
         v                     v                     v
+-------------------------------------------------------------+
|       System.Windows.Forms.DataVisualization                |
|              (WinForms Rendering Layer)                     |
|  +-------------------------------------------------------+  |
|  |  GdiRenderingEngine (implements IRenderingEngine)     |  |
|  |  Chart WinForms Control                               |  |
|  +-------------------------------------------------------+  |
+-------------------------------------------------------------+
                              |
         +--------------------+--------------------+
         |                                         |
         v                                         v
+-------------------------------------------------------------+
|                  Svg.DataVisualization                      |
|              (SVG Rendering Layer)                          |
|  +-------------------------------------------------------+  |
|  |  SvgRenderingEngine (implements IRenderingEngine)     |  |
|  +-------------------------------------------------------+  |
+-------------------------------------------------------------+
                              |
                              v
+-------------------------------------------------------------+
|          System.Windows.Forms.DataVisualization.Core        |
|              (Platform-Agnostic Data Layer)                 |
|  +-------------+ +-------------+ +------------------------+ |
|  | Data Models | | Chart Types | |  IRenderingEngine      | |
|  | (DataPoint, | | (Line, Bar, | |  (Rendering            | |
|  |  DataSeries,| |  Pie, etc.) | |   Abstraction)         | |
|  |  ChartArea) | |             | |                        | |
|  +-------------+ +-------------+ +------------------------+ |
+-------------------------------------------------------------+
```

---

## Phase 1: Create Core Data Layer Project

**Status: COMPLETE ?**

### Completed Tasks ?

#### 1.1 Create New Core Project ?
- [x] Created `System.Windows.Forms.DataVisualization.Core` project
- [x] Targeting `net10.0` (platform-agnostic)
- [x] Configured as a class library with NuGet packaging support

#### 1.2 Define Platform-Agnostic Primitives ?
Created platform-agnostic replacements for `System.Drawing` types in `Primitives/` folder:
- [x] `ChartPointF` (replaces `PointF`)
- [x] `ChartRectangleF` (replaces `RectangleF`)
- [x] `ChartSizeF` (replaces `SizeF`)
- [x] `ChartColor` (replaces `Color`)
- [x] `ChartFont` (replaces `Font`)
- [x] `ChartPen` (replaces `Pen`)
- [x] `ChartBrush` (replaces `Brush`) - includes `ChartSolidBrush`, `ChartLinearGradientBrush`, `ChartHatchBrush`
- [x] `ChartMatrix` (replaces `Matrix`)
- [x] `ChartPath` (replaces `GraphicsPath`)
- [x] `ChartStringFormat` (replaces `StringFormat`)
- [x] `ChartEnumerations.cs` - All supporting enums (`ChartSmoothingMode`, `ChartTextRenderingHint`, `ChartCombineMode`, `ChartDashStyle`, `ChartLineCap`, `ChartLineJoin`, `ChartHatchStyle`, `ChartLinearGradientMode`, `ChartStringAlignment`, `ChartStringTrimming`, `ChartStringFormatFlags`, `ChartFillMode`, etc.)

#### 1.3 Define Core Rendering Interfaces ?
- [x] `IRenderingEngine` - Complete platform-agnostic rendering interface in `Rendering/IRenderingEngine.cs`
- [x] `IPrimitiveConverter<T...>` - Generic interface for converting between chart primitives and platform types
- [x] `RenderingEngineAdapter<T...>` - Abstract base class that implements `IRenderingEngine` using converters

#### 1.4 Update WinForms Project References ?
- [x] Added project reference from `System.Windows.Forms.DataVisualization` to Core project
- [x] Added Core project to solution file (`.slnx`)
- [x] Solution builds successfully

#### 1.5 Define Core Data Model Interfaces ?
Created platform-agnostic interfaces in `Data/` folder:
- [x] `IDataPoint` - Interface for data point properties and methods
- [x] `IDataSeries` - Interface for data series properties and methods
- [x] `IChartArea` - Interface for chart area properties
- [x] `ChartEnums.cs` - Shared enumerations (`ChartValueType`, `MarkerStyle`, `GradientStyle`, `ChartHatchStyle`, `ChartDashStyle`, `ChartImageWrapMode`, `ChartImageAlignmentStyle`)

#### 1.6 Define Core Chart Type Interfaces ?
Created chart type abstractions in `ChartTypes/` folder:
- [x] `IChartType` - Platform-agnostic interface for chart type implementations
- [x] `ChartTypeRegistryBase` - Base class for chart type registry
- [x] `ChartTypeNames` - Constants for all standard chart type names
- [x] `LegendImageStyle` - Enum for legend display styles

#### 1.7 Implement WinForms Rendering Adapter ?
- [x] `GdiPrimitiveConverter` - Converts between chart primitives and System.Drawing types
- [x] `GdiRenderingEngine` - Implements IRenderingEngine using GDI+ Graphics

### Core Project Structure

```
System.Windows.Forms.DataVisualization.Core/
+-- Primitives/
|   +-- ChartPointF.cs
|   +-- ChartRectangleF.cs
|   +-- ChartSizeF.cs
|   +-- ChartColor.cs
|   +-- ChartFont.cs
|   +-- ChartPen.cs
|   +-- ChartBrush.cs
|   +-- ChartMatrix.cs
|   +-- ChartPath.cs
|   +-- ChartStringFormat.cs
|   +-- ChartEnumerations.cs
+-- Rendering/
|   +-- IRenderingEngine.cs
|   +-- IPrimitiveConverter.cs
+-- Data/
|   +-- IDataModels.cs
|   +-- ChartEnums.cs
+-- ChartTypes/
    +-- IChartType.cs
    +-- ChartTypeRegistryBase.cs
```

### WinForms Project Additions

```
System.Windows.Forms.DataVisualization/
+-- Charting/General/
    +-- GdiPrimitiveConverter.cs  (NEW)
    +-- GdiRenderingEngine.cs     (NEW)
```

### Deliverables ?
- [x] New `System.Windows.Forms.DataVisualization.Core.csproj`
- [x] Platform-agnostic primitive types
- [x] `IRenderingEngine` interface
- [x] Core data model interfaces (`IDataPoint`, `IDataSeries`, `IChartArea`)
- [x] Core chart type interfaces (`IChartType`, `ChartTypeRegistryBase`)
- [x] `GdiRenderingEngine` implementation for WinForms
- [x] `GdiPrimitiveConverter` for System.Drawing type conversions
- [x] Updated WinForms project with Core dependency

### Notes
The existing `DataPoint`, `Series`, and `ChartArea` classes in the WinForms project are heavily coupled with `System.Drawing` types and WinForms-specific functionality. Rather than moving these complex classes to the Core project (which would require extensive refactoring and risk breaking existing functionality), we created:
1. **Interfaces** in the Core project that define the essential contracts
2. **Rendering abstractions** that allow new rendering engines (SVG, Canvas, etc.) to be implemented
3. **GDI+ adapter** that bridges the Core abstractions with existing WinForms rendering

This approach allows gradual migration while maintaining backward compatibility.

---

## Phase 2: Maintain Namespace Compatibility

**Status: COMPLETE ?**

### Objective
Ensure both Core and WinForms projects use consistent namespaces for seamless compatibility.

### Completed Tasks ?

#### 2.1 Namespace Structure ?
All projects use consistent namespace patterns:

```
System.Windows.Forms.DataVisualization.Core
+-- System.Windows.Forms.DataVisualization.Charting
|   +-- IRenderingEngine.cs
|   +-- IDataModels.cs (IDataPoint, IDataSeries, IChartArea, ChartValueType)
|   +-- ChartTypeRegistryBase.cs
|   +-- IChartType.cs (IChartTypeInfo)
+-- System.Windows.Forms.DataVisualization.Charting.Rendering
    +-- Primitives/ (ChartPointF, ChartColor, ChartPen, ChartBrush, etc.)

System.Windows.Forms.DataVisualization
+-- System.Windows.Forms.DataVisualization.Charting
|   +-- Chart.cs (WinForms control)
|   +-- GdiRenderingEngine.cs
|   +-- GdiPrimitiveConverter.cs
|   +-- ChartGraphics.cs
|   +-- Design/ (WinForms designers)
+-- System.Windows.Forms.DataVisualization.Charting.ChartTypes
    +-- ChartTypeRegistry.cs
    +-- IChartType.cs (WinForms-specific)
    +-- [All chart type implementations]
```

#### 2.2 Namespace Design Decisions ?
- **Main namespace** (`System.Windows.Forms.DataVisualization.Charting`): Contains core interfaces and public API types
- **Rendering sub-namespace** (`...Charting.Rendering`): Contains platform-agnostic primitive types (ChartColor, ChartPen, etc.)
- **ChartTypes sub-namespace** (`...Charting.ChartTypes`): Contains WinForms-specific chart type implementations

#### 2.3 Type Coexistence Strategy ?
Rather than using `[TypeForwardedTo]` attributes, the architecture uses:
- **Interfaces in Core**: Platform-agnostic contracts (`IDataPoint`, `IDataSeries`, `IChartTypeInfo`)
- **Implementations in WinForms**: Full implementations with platform-specific features
- **Internal Core types**: Some types like `ChartTypeNames`, `LegendImageStyle` are `internal` in Core to avoid conflicts with WinForms public types

#### 2.4 Conditional Compilation ?
Not required - the architecture cleanly separates platform-agnostic code (Core) from platform-specific code (WinForms) without needing `#if` directives.

### Deliverables ?
- [x] Consistent namespace usage across all projects
- [x] Clear separation between Core abstractions and WinForms implementations
- [x] Solution builds successfully without namespace conflicts
- [x] Documentation of namespace structure (this document)

### Notes
The namespace structure allows:
1. WinForms consumers to use the existing API without changes
2. Future SVG/Blazor implementations to reference Core without WinForms dependencies
3. No breaking changes to existing code

---

## Phase 3: Create SVG Rendering Project

**Status: COMPLETE ?**

### Objective
Create `Svg.DataVisualization` project that implements SVG rendering.

### Completed Tasks ?

#### 3.1 Create SVG Project ?
- [x] Created `Svg.DataVisualization.csproj` targeting `net10.0`
- [x] Added project reference to Core project
- [x] Added project to solution
- [x] Configured for NuGet package generation

#### 3.2 Implement SVG Rendering Engine ?
Created `SvgRenderingEngine` class implementing `IRenderingEngine`:
- [x] All drawing methods (DrawLine, DrawRectangle, DrawEllipse, DrawPolygon, DrawPath, DrawPie, DrawArc, DrawCurve, DrawString)
- [x] All filling methods (FillRectangle, FillEllipse, FillPolygon, FillPath, FillPie)
- [x] Text measurement (approximate, since SVG doesn't provide built-in metrics)
- [x] State management (Save, Restore, SetClip, ResetClip)
- [x] Transform operations (TranslateTransform, RotateTransform, ScaleTransform)
- [x] Selection/interactivity support (BeginSelection, EndSelection for hyperlinks)
- [x] SVG output methods (GetSvgContent, SaveToFile, ToStream)
- [x] Support for SVG defs (gradients, patterns)

#### 3.3 SVG Primitive Converters ?
Created `SvgPrimitiveConverter` static class with conversions:
- [x] `ToSvgColor` - ChartColor to SVG color string (hex or rgba)
- [x] `ToSvgStrokeAttributes` - ChartPen to SVG stroke attributes
- [x] `ToSvgDashArray` - ChartDashStyle to SVG stroke-dasharray
- [x] `ToSvgLineCap` - ChartLineCap to SVG stroke-linecap
- [x] `ToSvgLineJoin` - ChartLineJoin to SVG stroke-linejoin
- [x] `ToSvgFillAttributes` - ChartBrush to SVG fill attributes
- [x] `ToSvgGradientDefinition` - ChartLinearGradientBrush to SVG linearGradient element
- [x] `ToSvgHatchDefinition` - ChartHatchBrush to SVG pattern element
- [x] `ToSvgFontAttributes` - ChartFont to SVG font attributes
- [x] `ToSvgPathData` - ChartPath to SVG path d attribute
- [x] `ToSvgTransform` - ChartMatrix to SVG transform attribute
- [x] `ToSvgTextAlignment` - ChartStringFormat to SVG text-anchor/dominant-baseline
- [x] `ToSvgArcPath` - Arc/pie path generation

#### 3.4 SVG Chart Wrapper ?
Created `SvgChart` class for easy chart generation:
- [x] Simplified API for creating charts without WinForms
- [x] Support for multiple chart types: Line, Area, Bar, Column, Scatter, Pie
- [x] Series collection with data points
- [x] Chart areas with customizable background and grid
- [x] Legend support (right or bottom position)
- [x] Title support
- [x] Auto-calculated data bounds
- [x] Default color palette

#### 3.5 Unit Tests ?
Created `Svg.DataVisualization.Tests` project with 41 tests:
- [x] `SvgPrimitiveConverterTests` - Tests for all primitive conversions
- [x] `SvgRenderingEngineTests` - Tests for SVG element generation
- [x] `SvgChartTests` - Tests for chart rendering

### SVG Project Structure

```
Svg.DataVisualization/
+-- Svg.DataVisualization.csproj
+-- SvgPrimitiveConverter.cs
+-- SvgRenderingEngine.cs
+-- SvgChart.cs

Svg.DataVisualization.Tests/
+-- Svg.DataVisualization.Tests.csproj
+-- SvgRenderingTests.cs
```

### Deliverables ?
- [x] `Svg.DataVisualization.csproj`
- [x] `SvgRenderingEngine` class implementing `IRenderingEngine`
- [x] `SvgPrimitiveConverter` static utility class
- [x] `SvgChart` wrapper class with support for 6 chart types
- [x] `SvgChartSeries`, `SvgDataPoint`, `SvgChartArea` supporting classes
- [x] Unit tests (41 tests, all passing)

### Example Usage

```csharp
// Create a simple line chart
using var chart = new SvgChart
{
    Title = "Monthly Sales",
    Width = 600,
    Height = 400
};

var series = new SvgChartSeries("Sales")
{
    ChartType = SvgChartType.Line,
    Color = ChartColor.FromArgb(65, 140, 240)
};
series.Points.Add(new SvgDataPoint(1, 100));
series.Points.Add(new SvgDataPoint(2, 150));
series.Points.Add(new SvgDataPoint(3, 120));
chart.Series.Add(series);

// Get SVG content
string svg = chart.RenderToSvg();

// Or save directly to file
chart.SaveToFile("chart.svg");
```

---

## Phase 4: Create Blazor WebAssembly ChartSamples

### Objective
Create a Blazor WebAssembly version of ChartSamples that renders charts in the browser.

### Tasks

#### 4.1 Create Blazor Project Structure

```
ChartSamples.Blazor/
+-- ChartSamples.Blazor.csproj
+-- wwwroot/
|   +-- index.html
|   +-- css/
|   +-- images/
+-- Pages/
|   +-- Index.razor
|   +-- ChartTypes/
|   |   +-- LineCharts.razor
|   |   +-- BarColumnCharts.razor
|   |   +-- PieCharts.razor
|   |   +-- ...
|   +-- ChartFeatures/
|   |   +-- Annotations.razor
|   |   +-- Axis.razor
|   |   +-- Labels.razor
|   |   +-- ...
|   +-- GettingStarted/
|       +-- BasicPopulatingData.razor
|       +-- DynamicChartCreation.razor
+-- Components/
|   +-- ChartViewer.razor
|   +-- SampleLayout.razor
|   +-- CodeViewer.razor
|   +-- SampleNavigation.razor
+-- Shared/
|   +-- MainLayout.razor
|   +-- NavMenu.razor
+-- Services/
    +-- SampleDataService.cs
```

#### 4.2 Create ChartViewer Component

```razor
@* ChartViewer.razor *@
@using System.Windows.Forms.DataVisualization.Charting

<div class="chart-container" style="width: @(Width)px; height: @(Height)px;">
    @((MarkupString)SvgContent)
</div>

@code {
    [Parameter] public int Width { get; set; } = 600;
    [Parameter] public int Height { get; set; } = 400;
    [Parameter] public Action<SvgChart> Configure { get; set; }
    
    private string SvgContent { get; set; } = "";
    
    protected override void OnParametersSet()
    {
        var chart = new SvgChart { Width = Width, Height = Height };
        Configure?.Invoke(chart);
        SvgContent = chart.RenderToSvg();
    }
}
```

#### 4.3 Migrate All Samples
Port each WinForms sample to Blazor:

| WinForms Sample | Blazor Page |
|-----------------|-------------|
| `AreaChartType.cs` | `Pages/ChartTypes/AreaCharts.razor` |
| `BarColumnChartType.cs` | `Pages/ChartTypes/BarColumnCharts.razor` |
| `LineChartType.cs` | `Pages/ChartTypes/LineCharts.razor` |
| `PieChart3D.cs` | `Pages/ChartTypes/PieCharts.razor` |
| ... | ... |

Each sample page will:
1. Display the chart using `ChartViewer` component
2. Show configuration options (if any)
3. Display source code
4. Provide interactive controls where applicable

#### 4.4 Sample Navigation Structure
Mirror the WinForms sample tree structure:

```razor
@* NavMenu.razor structure *@
- Getting Started
  - Basic Populating Data
  - Dynamic Chart Creation
- Chart Types
  - Line Charts
  - Bar/Column Charts
  - Pie/Doughnut Charts
  - Area Charts
  - Point Charts
  - Range Charts
  - Financial Charts
  - Circular Charts
  - Pyramid/Funnel Charts
- Chart Features
  - Annotations
  - Axis
  - Labels
  - Legend
  - Titles
  - Data Series
  - Chart Area
  - Interactive Charting
  - Serialization
  - Printing (export options)
- Chart Appearance
  - Borders
  - Palettes
  - 3D Effects
```

#### 4.5 Interactive Features
Implement browser-based interactive features:
- Tooltips (via JavaScript interop or CSS)
- Click handlers on chart elements
- Zoom/pan via touch and mouse
- Export to PNG/SVG download

#### 4.6 Code Display Component

```razor
@* CodeViewer.razor *@
<div class="code-viewer">
    <div class="code-tabs">
        <button @onclick="() => ShowCSharp = true">C#</button>
        <button @onclick="() => ShowCSharp = false">Razor</button>
    </div>
    <pre class="code-content">
        @if (ShowCSharp)
        {
            <code>@CSharpCode</code>
        }
        else
        {
            <code>@RazorCode</code>
        }
    </pre>
</div>

@code {
    [Parameter] public string CSharpCode { get; set; }
    [Parameter] public string RazorCode { get; set; }
    private bool ShowCSharp { get; set; } = true;
}
```

### Deliverables
- `ChartSamples.Blazor.csproj` (Blazor WebAssembly)
- All WinForms samples ported to Blazor
- Responsive chart viewer component
- Sample navigation matching WinForms structure
- Code viewer with syntax highlighting
- Interactive chart features (tooltips, zoom)

---

## Phase 5: Testing & Documentation

### Tasks

#### 5.1 Unit Tests
- Core data model tests
- Chart calculation tests
- SVG rendering output tests
- Rendering engine interface compliance tests

#### 5.2 Integration Tests
- WinForms rendering vs SVG rendering comparison
- Blazor component rendering tests
- Cross-browser SVG compatibility

#### 5.3 Visual Regression Tests
- Screenshot comparison for WinForms charts
- SVG output comparison
- Blazor rendered chart comparison

#### 5.4 Documentation
- API documentation for Core library
- Migration guide from WinForms to SVG
- Blazor integration guide
- Sample code for common scenarios

### Deliverables
- Test projects for each library
- Visual regression test suite
- API documentation
- Migration guides

---

## Project Structure Summary

```
Solution/
+-- System.Windows.Forms.DataVisualization.Core/
|   +-- System.Windows.Forms.DataVisualization.Core.csproj
|   +-- [Platform-agnostic chart logic]
|
+-- System.Windows.Forms.DataVisualization/
|   +-- System.Windows.Forms.DataVisualization.csproj
|   +-- [WinForms rendering + Chart control]
|
+-- Svg.DataVisualization/
|   +-- Svg.DataVisualization.csproj
|   +-- [SVG rendering engine]
|
+-- ChartSamples/
|   +-- ChartSamples.csproj
|   +-- [WinForms sample application]
|
+-- ChartSamples.Blazor/
|   +-- ChartSamples.Blazor.csproj
|   +-- [Blazor WebAssembly samples]
|
+-- Tests/
|   +-- Core.Tests/
|   +-- Svg.Tests/
|   +-- Blazor.Tests/
|
+-- MASTER_PLAN.md
```

---

## Timeline Estimates

| Phase | Description | Estimated Effort |
|-------|-------------|------------------|
| Phase 1 | Core Data Layer Project | 4-6 weeks |
| Phase 2 | Namespace Compatibility | 1-2 weeks |
| Phase 3 | SVG Rendering Project | 3-4 weeks |
| Phase 4 | Blazor WebAssembly Samples | 4-6 weeks |
| Phase 5 | Testing & Documentation | 2-3 weeks |
| **Total** | | **14-21 weeks** |

---

## Dependencies

### NuGet Packages

**Core Project:**
- No external dependencies (platform-agnostic)

**WinForms Project:**
- System.Drawing.Common (existing)

**SVG Project:**
- None required (pure string-based SVG generation)
- Optional: SvgNet for complex path operations

**Blazor Project:**
- Microsoft.AspNetCore.Components.WebAssembly
- Microsoft.AspNetCore.Components.WebAssembly.DevServer

---

## Risk Mitigation

| Risk | Mitigation |
|------|------------|
| Breaking changes to existing API | Use type forwarding and maintain namespaces |
| SVG rendering quality differences | Implement comprehensive visual comparison tests |
| Performance in Blazor/WASM | Use lazy loading, virtualization for large charts |
| Complex chart types (3D) in SVG | Implement 2D projection algorithms in Core |
| Font measurement differences | Create abstraction with platform-specific implementations |

---

## Success Criteria

1. **Core Library**: All existing chart types render correctly using abstract interfaces
2. **Namespace Compatibility**: Existing code using `System.Windows.Forms.DataVisualization.Charting` compiles without changes
3. **SVG Rendering**: Visual parity with GDI+ rendering for all chart types
4. **Blazor Samples**: All WinForms samples functional in browser
5. **Tests**: >90% code coverage, all visual regression tests pass
