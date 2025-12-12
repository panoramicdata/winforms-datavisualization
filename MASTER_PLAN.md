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

#### 3.4 SvgChart Class
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

**Status: COMPLETE ?**

### Objective
Create a Blazor WebAssembly version of ChartSamples that renders charts in the browser using SVG.

### Completed Tasks ?

#### 4.1 Create Blazor Project Structure ?
- [x] Created `ChartSamples.Blazor.csproj` targeting `net10.0`
- [x] Added project reference to `Svg.DataVisualization`
- [x] Configured Blazor WebAssembly packages (v10.0.1)
- [x] Added to solution file

#### 4.2 Create Static Assets ?
- [x] `wwwroot/index.html` with Font Awesome 6 CDN
- [x] `wwwroot/css/app.css` with comprehensive styling
- [x] Responsive design for mobile/desktop

#### 4.3 Create Core Components ?
- [x] `App.razor` - Root component with routing
- [x] `MainLayout.razor` - Main layout with sidebar
- [x] `NavMenu.razor` - Navigation with Font Awesome icons and expandable groups
- [x] `ChartViewer.razor` - Reusable SVG chart rendering component
- [x] `SampleBase.razor` - Base layout for sample pages with tabs

#### 4.4 Create Sample Pages ?

**Getting Started:**
- [x] `BasicPopulatingData.razor` - Data binding examples
- [x] `DynamicChartCreation.razor` - Runtime chart configuration

**Chart Types:**
- [x] `LineCharts.razor` - Line, Spline, StepLine
- [x] `BarColumnCharts.razor` - Vertical and horizontal bars
- [x] `AreaCharts.razor` - Area charts with multiple series
- [x] `PieCharts.razor` - Pie and doughnut charts
- [x] `ScatterCharts.razor` - Scatter/point plots

**Chart Features:**
- [x] `TitlesLegends.razor` - Title and legend configuration
- [x] `MultipleSeries.razor` - Multi-series charts
- [x] `ChartStyling.razor` - Styling and theming

**Chart Appearance:**
- [x] `ColorPalettes.razor` - Color palette examples
- [x] `Backgrounds.razor` - Background styling

#### 4.5 Interactive Features ?
- [x] Dynamic chart updates via UI controls
- [x] Real-time parameter changes (chart type, series count, etc.)
- [x] Code viewer with sample C# code
- [x] Responsive chart sizing

### Blazor Project Structure

```
ChartSamples.Blazor/
??? ChartSamples.Blazor.csproj
??? _Imports.razor
??? App.razor
??? Program.cs
??? Properties/
?   ??? launchSettings.json
??? wwwroot/
?   ??? index.html
?   ??? css/
?       ??? app.css
??? Components/
    ??? ChartViewer.razor
    ??? SampleBase.razor
    ??? Layout/
    ?   ??? MainLayout.razor
    ?   ??? NavMenu.razor
    ??? Pages/
        ??? Index.razor
        ??? GettingStarted/
        ?   ??? BasicPopulatingData.razor
        ?   ??? DynamicChartCreation.razor
        ??? ChartTypes/
        ?   ??? LineCharts.razor
        ?   ??? BarColumnCharts.razor
        ?   ??? AreaCharts.razor
        ?   ??? PieCharts.razor
        ?   ??? ScatterCharts.razor
        ??? ChartFeatures/
        ?   ??? TitlesLegends.razor
        ?   ??? MultipleSeries.razor
        ?   ??? ChartStyling.razor
        ??? ChartAppearance/
            ??? ColorPalettes.razor
            ??? Backgrounds.razor
```

### Deliverables ?
- [x] `ChartSamples.Blazor.csproj` (Blazor WebAssembly)
- [x] 12 sample pages covering major chart types and features
- [x] Responsive chart viewer component with SVG rendering
- [x] Navigation matching WinForms sample structure
- [x] Code viewer showing C# implementation
- [x] Font Awesome 6 icons throughout UI
- [x] Interactive controls for chart customization

### Example Usage

```razor
@page "/my-chart"

<ChartViewer Width="600" Height="400" Configure="@ConfigureChart" />

@code {
    private void ConfigureChart(SvgChart chart)
    {
        chart.Title = "Sales Data";
        
        var series = new SvgChartSeries("Revenue")
        {
            ChartType = SvgChartType.Line,
            Color = ChartColor.FromArgb(65, 140, 240)
        };
        series.Points.Add(new SvgDataPoint(1, 100));
        series.Points.Add(new SvgDataPoint(2, 150));
        chart.Series.Add(series);
    }
}
```

---

## Phase 4.5: Unified Rendering Architecture

**Status: IN PROGRESS ??**

### Problem Statement
Currently there are **TWO completely separate rendering implementations**:
1. **WinForms** (`System.Windows.Forms.DataVisualization`) - 15,000+ lines of tightly-coupled GDI+ rendering
2. **SVG** (`Svg.DataVisualization`) - ~600 lines in `SvgChart.cs` with simplified layout

They **cannot produce identical output** because they have different layout algorithms, axis calculations, data point positioning, legend rendering, and grid line spacing.

### Objective
Create a **single layout engine in Core** that calculates all chart positions, then multiple renderers that draw to different targets using `IRenderingEngine`.

### Target Architecture

```
???????????????????????????????????????????????????????????????????????
?                    Core Project (Platform-Agnostic)                  ?
?  ?????????????????????????????????????????????????????????????????  ?
?  ?  Chart Model Interfaces                                        ?  ?
?  ?  IChartModel, ISeriesModel, IDataPointModel, IAxisModel       ?  ?
?  ?????????????????????????????????????????????????????????????????  ?
?                              ?                                       ?
?                              ?                                       ?
?  ?????????????????????????????????????????????????????????????????  ?
?  ?  Layout Engine                                                 ?  ?
?  ?  ChartLayoutEngine, AxisLayoutCalculator, LegendLayoutCalc    ?  ?
?  ?????????????????????????????????????????????????????????????????  ?
?                              ?                                       ?
?                              ?                                       ?
?  ?????????????????????????????????????????????????????????????????  ?
?  ?  Chart Renderer                                                ?  ?
?  ?  ChartRenderer, AxisRenderer, SeriesRenderers (Line, Bar...)  ?  ?
?  ?????????????????????????????????????????????????????????????????  ?
?                              ?                                       ?
?                              ?                                       ?
?                     IRenderingEngine                                 ?
???????????????????????????????????????????????????????????????????????
                               ?
         ?????????????????????????????????????????????
         ?                     ?                     ?
???????????????????   ???????????????????   ???????????????????
? GdiRendering    ?   ? SvgRendering    ?   ? Future:         ?
? Engine          ?   ? Engine          ?   ? SkiaEngine      ?
? (WinForms)      ?   ? (Blazor)        ?   ? CanvasEngine    ?
???????????????????   ???????????????????   ???????????????????
```

### Sub-Phases

#### Phase 4.5.1: Create Core Chart Model Interfaces ?
**Status: COMPLETE**

Created platform-agnostic model interfaces in `System.Windows.Forms.DataVisualization.Core/Models/`:
- [x] `IChartModel.cs` - Chart, ChartArea, Axis interfaces
- [x] `ISeriesModel.cs` - Series and DataPoint interfaces
- [x] `ChartMarkerStyle` enum
- [x] `ChartAxisType` enum
- [x] `ChartLegendPosition` enum

#### Phase 4.5.2: Create Layout Engine
**Status: COMPLETE ?**

Extract layout logic from WinForms `ChartPicture.Resize()` and `ChartArea.Resize()`:
- [x] `ChartLayout.cs` - Layout result classes (ChartLayout, ChartAreaLayout, AxisLayout, AxisTickLayout, AxisLabelLayout, SeriesLayout, DataPointLayout, LegendLayout, LegendItemLayout)
- [x] `AxisLayoutCalculator.cs` - Axis label sizes, tick marks, positions, nice interval calculation
- [x] `ChartLayoutEngine.cs` - Main layout calculator with title, legend, chart area, and series positioning
- [x] Unit tests - 15 tests in `System.Windows.Forms.DataVisualization.Core.Tests` project

#### Phase 4.5.3: Create Chart Renderer
**Status: NOT STARTED**

Create renderer that uses calculated layout and `IRenderingEngine`:
- [ ] `ChartRenderer.cs` - Main chart renderer
- [ ] `AxisRenderer.cs` - Axis lines, labels, ticks, grid
- [ ] `LegendRenderer.cs` - Legend rendering
- [ ] `SeriesRenderers/LineSeriesRenderer.cs` - Line chart rendering
- [ ] `SeriesRenderers/BarSeriesRenderer.cs` - Bar chart rendering
- [ ] `SeriesRenderers/PieSeriesRenderer.cs` - Pie chart rendering
- [ ] Additional series renderers as needed

#### Phase 4.5.4: Create WinForms Adapter
**Status: NOT STARTED**

Create adapter to use Core renderer with existing WinForms Chart:
- [ ] `ChartCoreAdapter.cs` - Implements `IChartModel` wrapping WinForms `Chart`
- [ ] `ChartAreaAdapter.cs` - Wraps `ChartArea`
- [ ] `SeriesAdapter.cs` - Wraps `Series`
- [ ] Update `Chart.OnPaint()` to optionally use Core renderer

#### Phase 4.5.5: Update SvgChart to Use Core
**Status: NOT STARTED**

Update `Svg.DataVisualization` to use Core layout engine:
- [ ] `SvgChart` implements `IChartModel`
- [ ] Remove custom layout code from `SvgChart.cs`
- [ ] Use `ChartRenderer` with `SvgRenderingEngine`

### Documentation
- [x] `RENDERING_ARCHITECTURE.md` - Detailed architecture document with code examples

### Success Criteria
1. **Identical Output**: Given the same chart configuration, WinForms and SVG render identically
2. **No Breaking Changes**: Existing WinForms API continues to work
3. **Test Coverage**: Layout calculations have unit tests
4. **Performance**: No significant performance regression

### Timeline Estimate
| Sub-Phase | Description | Estimated Effort |
|-----------|-------------|------------------|
| 4.5.1 | Core Model Interfaces | ? Complete |
| 4.5.2 | Layout Engine | 2-3 weeks |
| 4.5.3 | Chart Renderer | 1-2 weeks |
| 4.5.4 | WinForms Adapter | 1 week |
| 4.5.5 | SvgChart Integration | 1 week |
| **Total** | | **5-7 weeks** |

### Risks & Mitigations
| Risk | Mitigation |
|------|------------|
| Layout complexity | Start with simple charts (Line, Bar), add complexity incrementally |
| Performance regression | Profile and optimize critical paths |
| API breaking changes | Use adapter pattern to maintain compatibility |
| 3D charts | Defer 3D support to later phase |

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
| Phase 4.5 | Unified Rendering Architecture | 5-7 weeks |
| Phase 5 | Testing & Documentation | 2-3 weeks |
| **Total** | | **17-29 weeks** |

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
