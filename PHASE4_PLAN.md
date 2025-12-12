# Phase 4: Blazor WebAssembly ChartSamples - Full Parity Plan

## Overview
This document tracks the migration of all WinForms ChartSamples to the Blazor WebAssembly application, achieving full feature parity.

---

## Current Status Summary

| Category | WinForms Samples | Blazor Samples | Coverage |
|----------|------------------|----------------|----------|
| Getting Started | 6 | 2 | ?? 33% |
| Chart Types | 35 | 16 | ?? 46% |
| Chart Features | 70+ | 20 | ?? 29% |
| Chart Appearance | 13 | 3 | ?? 23% |
| **Total** | **124+** | **41** | **~33%** |

---

## Priority: Menu System Parity ??

### Goal
Align the Blazor navigation menu structure with the WinForms ChartSamples tree view for consistent parity testing.

### WinForms Menu Structure (from DynSampleConfig.xml)

```
??? Getting Started
?   ??? Chart Elements (Overview)
?   ??? Coordinate System (Overview)
?   ??? Text Elements (Overview)
?   ??? Series and Points (Overview)
?   ??? Basic Data Population ?
?   ??? Creating a Chart Dynamically ?
?
??? Chart Types
?   ??? Advanced Financial Charts
?   ?   ??? Gallery
?   ?   ??? Stock and Candlestick Charts ?
?   ??? Price Change Financial Charts
?   ?   ??? Gallery
?   ?   ??? Kagi Chart
?   ?   ??? Renko Chart
?   ?   ??? Point and Figure Chart
?   ?   ??? Three Line Break Chart
?   ??? Bar and Column Charts
?   ?   ??? Gallery
?   ?   ??? 3D Bar and Column Charts
?   ?   ??? 3D Cylinder Chart
?   ?   ??? Bar and Column Charts ?
?   ?   ??? Stacked Bar and Column Charts ?
?   ??? Line Charts
?   ?   ??? Gallery
?   ?   ??? Line, Step Line and Curve Charts ?
?   ?   ??? Fast Line Chart
?   ?   ??? 3D Line and Curve Charts
?   ??? Point Charts
?   ?   ??? Gallery
?   ?   ??? Bubble Charts ?
?   ?   ??? Point Charts ?
?   ?   ??? Fast Point Chart
?   ??? Pie and Doughnut Charts
?   ?   ??? Gallery
?   ?   ??? Doughnut Chart in Doughnut
?   ?   ??? Pie and Doughnut Charts ?
?   ?   ??? Collecting Small Pie Segments
?   ?   ??? Supplemental Pie Charts
?   ??? Area Charts
?   ?   ??? Gallery
?   ?   ??? 3D Area and Spline Area Charts
?   ?   ??? Area and Spline Area Charts ?
?   ??? Range Charts
?   ?   ??? Gallery
?   ?   ??? Range and Spline Range Charts ?
?   ?   ??? 3D Range and Spline Range Charts
?   ?   ??? Range Bar Chart ?
?   ?   ??? 3D Range Bar Chart
?   ?   ??? Range Column Chart
?   ??? Circular Charts
?   ?   ??? Gallery
?   ?   ??? Polar Chart ?
?   ?   ??? Radar Chart ?
?   ??? Combinational Charts
?   ?   ??? Gallery
?   ?   ??? Combination of Chart Types ?
?   ?   ??? Pareto Chart ?
?   ??? Data Distribution Charts
?   ?   ??? Box Plot Chart ?
?   ?   ??? Histogram Chart ?
?   ??? Accumulation Charts
?   ?   ??? Gallery
?   ?   ??? Funnel Chart ?
?   ?   ??? Pyramid Chart ?
?   ??? Error Bar Chart ?
?
??? Appearance
?   ??? Plotting Area Appearance
?   ??? Anti Aliasing
?   ??? Chart Background Appearance ?
?   ??? Border Appearance ?
?   ??? 3D Point Gap and Depth
?   ??? 3D Perspective
?   ??? Axis Line Appearance
?   ??? Strip Line Appearance
?   ??? 3D Rotation and Elevation
?   ??? Series Appearance
?   ??? Cursor Appearance
?   ??? Scrollbar Appearance
?   ??? Legend Appearance ?
?
??? Chart Features
?   ??? Data Series
?   ?   ??? Overview
?   ?   ??? Series and Chart Areas
?   ?   ??? Adding and Removing Series at Run-Time
?   ?   ??? Hiding Series
?   ?   ??? Indexed X Values
?   ?   ??? Points Width and 3D Depth
?   ?   ??? Secondary Y Axis
?   ?   ??? Series Z Order
?   ?   ??? Series Appearance
?   ?   ??? Using Labels
?   ?   ??? Using Markers
?   ?   ??? Custom ToolTips ?
?   ?   ??? Smart Labels
?   ??? Chart Areas
?   ?   ??? Overview
?   ?   ??? Chart Area and Plotting Area Positions
?   ?   ??? Plotting Area Appearance
?   ?   ??? Alignment Types
?   ?   ??? Mini-Chart in Data Points
?   ?   ??? Doughnut Chart in Doughnut
?   ?   ??? Z Order
?   ?   ??? Points Width and 3D Depth
?   ?   ??? Cursor Position Changed
?   ?   ??? Cursor Appearance
?   ?   ??? Cursor Axis Attachment
?   ?   ??? Cursor Intervals
?   ?   ??? Keyboard Zoom/Scroll Cursors
?   ?   ??? Multi Chart Area Cursor
?   ?   ??? Auto Zoom/Scroll Cursors
?   ??? Axes
?   ?   ??? Overview
?   ?   ??? Axis Line Appearance
?   ?   ??? Multiple Y Axes ?
?   ?   ??? Axis Title
?   ?   ??? Axis Margins
?   ?   ??? Axis Scale
?   ?   ??? Logarithmic Scale ?
?   ?   ??? Scale Breaks
?   ?   ??? Crossing and Reverse Axis Properties
?   ?   ??? Grid Lines and Tick Marks
?   ?   ??? Primary and Secondary Axes
?   ?   ??? Strip Line Titles
?   ?   ??? Strip Line Appearance
?   ?   ??? Interlaced Strip Lines
?   ?   ??? Setting Variable Label Intervals
?   ?   ??? Highlighting Dates Using StripLines
?   ?   ??? Offset Strip Lines
?   ?   ??? Labels Next To Axis
?   ?   ??? Auto Fit Axes Labels
?   ?   ??? Axis Labels Interval
?   ?   ??? Custom Labels
?   ?   ??? Equally Sized Axes Labels
?   ??? Legends
?   ?   ??? Overview
?   ?   ??? Appearance ?
?   ?   ??? Interactive Legend
?   ?   ??? Style and Auto Positioning ?
?   ?   ??? Setting Multiple Columns
?   ?   ??? Legend Font
?   ?   ??? Adding a Legend Title
?   ?   ??? Series Legend Assignment
?   ?   ??? Explicit Positioning
?   ?   ??? Multiple Legends
?   ?   ??? Custom Legend Items
?   ?   ??? Legend Cells
?   ?   ??? Legend Cell Span
?   ??? Labels
?   ?   ??? Overview
?   ?   ??? Smart Labels
?   ?   ??? Axis and Data Point Labels
?   ?   ??? Axis Labels Interval
?   ?   ??? Labels Text Style
?   ?   ??? Formatting Labels
?   ?   ??? Using Keywords in Labels
?   ?   ??? Setting Variable Label Intervals
?   ?   ??? Labels Next To Axis
?   ?   ??? Auto Fit Axes Labels
?   ?   ??? Custom Labels
?   ?   ??? Equally Sized Axes Labels
?   ??? Titles
?   ?   ??? Overview
?   ?   ??? Chart Title
?   ?   ??? Legend Title
?   ?   ??? Axis Title
?   ?   ??? Strip Line Titles
?   ?   ??? Multiple Titles ?
?   ?   ??? Explicit Positioning
?   ??? Annotations
?   ?   ??? Overview
?   ?   ??? Annotation Appearance
?   ?   ??? Annotation Types
?   ?   ??? Annotation Smart Labels
?   ?   ??? Annotation Anchoring
?   ?   ??? Free-drawing Annotations
?   ?   ??? Editing Annotation Text
?   ?   ??? Grouping Annotations
?   ?   ??? AnnotationPositionChanging Event
?   ?   ??? AnnotationPositionChanged Event
?   ??? Customization and Events
?   ?   ??? Overview
?   ?   ??? PrePaint and PostPaint Events
?   ?   ??? Custom Painting an Image
?   ?   ??? Custom Painting a DataTable
?   ?   ??? Customizing the Scrollbar
?   ?   ??? Custom ToolTips
?   ?   ??? AnnotationPositionChanged Event
?   ?   ??? AnnotationPositionChanging Event
?   ?   ??? AxisViewChanged Event
?   ?   ??? CursorPositionChanged Event
?   ??? Interactive Charting
?   ?   ??? Overview
?   ?   ??? Selection
?   ?   ?   ??? Drill Down ?
?   ?   ?   ??? Interactive Pie Chart ?
?   ?   ?   ??? Changing Values by Dragging
?   ?   ?   ??? Selection of Data Points ?
?   ?   ??? Cursors
?   ?   ?   ??? Cursor Appearance
?   ?   ?   ??? Cursor Axis Attachment
?   ?   ?   ??? Cursor Intervals
?   ?   ?   ??? Keyboard Zoom/Scroll Cursors
?   ?   ?   ??? Multi Chart Area Cursor
?   ?   ?   ??? Auto Zoom/Scroll Cursors
?   ?   ??? Zooming and Scrolling
?   ?   ?   ??? Basic Zooming ?
?   ?   ?   ??? Scrollbar Appearance
?   ?   ?   ??? Scrolling Axis with the Keyboard
?   ?   ?   ??? Small Scrolling Size
?   ?   ?   ??? Limiting View Size
?   ?   ?   ??? AxisScrollBarClicked Event
?   ?   ?   ??? Multi Chart Area Cursor
?   ?   ??? Tooltips
?   ?       ??? Standard ToolTips ?
?   ?       ??? Custom ToolTips ?
?   ??? Printing
?   ?   ??? Overview
?   ?   ??? Printing and Previewing
?   ?   ??? Programmatic Print Settings
?   ?   ??? Printer Friendly Charts
?   ?   ??? Multipage Printing
?   ?   ??? Custom Printing
?   ??? Serialization
?   ?   ??? Overview
?   ?   ??? Basic Serialization
?   ?   ??? Using Templates
?   ?   ??? Printer Friendly Charts
?   ??? Palettes ?
?   ??? Saving And Copying Images ?
```

### Menu Parity Implementation Status

| Section | WinForms Items | Blazor Items | Status |
|---------|---------------|--------------|--------|
| Getting Started | 6 | 2 | ?? 33% |
| Chart Types | 35 nested | 16 flat | ?? Restructure |
| Appearance | 13 | 3 | ?? 23% |
| Chart Features | 70+ nested | 20 flat | ?? Restructure |

---

## Completed Work ?

### Project Infrastructure ?
- [x] Created `ChartSamples.Blazor.csproj` targeting `net10.0`
- [x] Added project reference to `Svg.DataVisualization`
- [x] Configured Blazor WebAssembly packages (v10.0.1)
- [x] Added to solution file
- [x] Created `wwwroot/index.html` with Font Awesome 6 CDN
- [x] Created `wwwroot/css/app.css` with comprehensive styling
- [x] Created `Properties/launchSettings.json`

### Core Components ?
- [x] `App.razor` - Root component with routing
- [x] `Program.cs` - WebAssembly entry point
- [x] `_Imports.razor` - Global using statements
- [x] `MainLayout.razor` - Main layout with sidebar
- [x] `NavMenu.razor` - Navigation with Font Awesome icons
- [x] `ChartViewer.razor` - Reusable SVG chart rendering component
- [x] `SampleBase.razor` - Base layout for sample pages with tabs

### Getting Started (6/6) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `BasicPopulatingData.cs` | `BasicPopulatingData.razor` | ? Complete |
| `DynamicChartCreation.cs` | `DynamicChartCreation.razor` | ? Complete |
| `TextElementsOverview.cs` | `TextElementsOverview.razor` | ? **NEW Phase 4.2** |
| `ChartElementsOverview.cs` | `ChartElementsOverview.razor` | ? **NEW Phase 4.2** |
| `CoordinateSystemOverview.cs` | `CoordinateSystemOverview.razor` | ? **NEW Phase 4.2** |
| `SeriesAndPointsOverview.cs` | `SeriesAndPointsOverview.razor` | ? **NEW Phase 4.2** |

### Chart Types - Completed (16/35) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `LineCurvesChartType.cs` | `LineCharts.razor` | ? Enhanced (FastLine, StepLine) |
| `BarColumnChartType.cs` | `BarColumnCharts.razor` | ? Complete |
| `AreaChartType.cs` | `AreaCharts.razor` | ? Complete |
| `PieChart3D.cs` / `PieCollected.cs` | `PieCharts.razor` | ? Enhanced (Doughnut, Exploded) |
| N/A (Scatter) | `ScatterCharts.razor` | ? Complete |
| `PointChartType.cs` / `BubbleChartType.cs` | `PointCharts.razor` | ? Complete |
| `RangeChartType.cs` / `RangeBarChartType.cs` | `RangeCharts.razor` | ? Complete |
| `StackedChartType.cs` | `StackedCharts.razor` | ? Enhanced (100% Stacked) |
| `FinancialChartType.cs` | `FinancialCharts.razor` | ? Complete |
| `PolarChartType.cs` / `RadarChartType.cs` | `CircularCharts.razor` | ? Complete |
| `PyramidChartType.cs` / `FunnelChartType.cs` | `PyramidFunnelCharts.razor` | ? Complete |
| `Histogram.cs` | `HistogramCharts.razor` | ? Complete |
| `BoxPlotChartType.cs` | `BoxPlotCharts.razor` | ? Complete |
| `CombinatorialChartType.cs` | `CombinationalCharts.razor` | ? Complete |
| `ErrorBarChartType.cs` | `ErrorBarCharts.razor` | ? Complete |
| `ParetoChartType.cs` | `ParetoCharts.razor` | ? Complete |

### Chart Features - Completed (20/70+) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `ChartTitle.cs` / Legend samples | `TitlesLegends.razor` | ? Complete |
| `MultilpleTitles.cs` | `MultipleTitles.razor` | ? **NEW Phase 4.2** |
| `LegendAppearance.cs` | `LegendAppearance.razor` | ? Complete |
| `LegendStylePosition.cs` | `LegendPosition.razor` | ? Complete |
| Multiple Series samples | `MultipleSeries.razor` | ? Complete |
| Styling samples | `ChartStyling.razor` | ? Complete |
| Axis samples (5+) | `AxisFeatures.razor` | ? Complete |
| `PrimarySecondaryAxis.cs` | `MultipleAxes.razor` | ? **NEW Phase 4.2** |
| `LogarithmicScale.cs` | `LogarithmicScale.razor` | ? **NEW Phase 4.2** |
| Label samples (8+) | `Labels.razor` | ? Complete |
| DataSeries samples (7+) | `DataSeries.razor` | ? Complete |
| ChartArea samples (6+) | `ChartArea.razor` | ? Complete |
| `UsingToolTips.cs` | `Tooltips.razor` | ? Complete |
| `CustomToolTips.cs` | `CustomTooltips.razor` | ? **NEW Phase 4.2** |
| `BasicZooming.cs` | `Zooming.razor` | ? **NEW Phase 4.2** |
| `Selection.cs` | `Selection.razor` | ? **NEW Phase 4.2** |
| `DrillDown.cs` | `DrillDown.razor` | ? **NEW Phase 4.2** |
| `InteractivePie.cs` | `InteractivePie.razor` | ? **NEW Phase 4.2** |
| `SavingAndCopyingImages.cs` | `ExportChart.razor` | ? Complete |

### Chart Appearance - Completed (3/13) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `Palettes.cs` | `ColorPalettes.razor` | ? Complete |
| `ChartAppearance.cs` | `Backgrounds.razor` | ? Complete |
| `Borders.cs` | `Borders.razor` | ? **NEW Phase 4.2** |

---

## Phase Completion Summary

### Phase 4.1 ? COMPLETE
- Created 5 new chart types (Histogram, BoxPlot, Combinational, ErrorBar, Pareto)
- Enhanced 3 existing pages (LineCharts, StackedCharts, PieCharts)
- Created 4 new feature pages (Tooltips, Export, LegendAppearance, LegendPosition)

### Phase 4.2 ? COMPLETE  
- Created 9 new feature pages:
  - `MultipleAxes.razor` - Primary/Secondary Y axes
  - `LogarithmicScale.razor` - Log10/Log2 scale options
  - `MultipleTitles.razor` - Multiple chart titles
  - `Zooming.razor` - Zoom and scroll controls
  - `Selection.razor` - Data point selection
  - `DrillDown.razor` - 3-level drill navigation
  - `InteractivePie.razor` - Slice selection & explosion
  - `CustomTooltips.razor` - Rich tooltip formats
  - `Borders.razor` - Border styling options

---

## Phase 4.5: Unified Rendering Architecture ?

### Problem
The current Blazor samples use `SvgChart` which has its own simplified layout code (~600 lines). The WinForms `Chart` has 15,000+ lines of layout/rendering code. **They cannot produce identical output** because they use different:
- Layout algorithms
- Axis calculations  
- Data point positioning
- Grid line spacing
- Legend rendering

### Solution
Create a **single layout engine in Core** that both WinForms and SVG use, ensuring identical chart output.

See **`RENDERING_ARCHITECTURE.md`** for detailed architecture documentation.

### Sub-Phase Status

| Phase | Description | Status |
|-------|-------------|--------|
| **4.5.1** | Core Model Interfaces | ? Complete |
| **4.5.2** | Layout Engine | ? Complete |
| **4.5.3** | Chart Renderer | ? Complete |
| **4.5.4** | WinForms Adapter | ? Complete |
| **4.5.5** | SvgChart Integration | ? Complete |

### Phase 4.5.1: Core Model Interfaces ?

**Status: COMPLETE**

Created platform-agnostic model interfaces in `System.Windows.Forms.DataVisualization.Core/Models/`:

| File | Interfaces/Types |
|------|------------------|
| `IChartModel.cs` | `IChartModel`, `IChartAreaModel`, `IAxisModel`, `ChartLegendPosition` |
| `ISeriesModel.cs` | `ISeriesModel`, `IDataPointModel`, `ChartMarkerStyle`, `ChartAxisType` |

### Phase 4.5.2: Layout Engine ?

**Status: COMPLETE**

Created layout calculation classes in `System.Windows.Forms.DataVisualization.Core/Layout/`:

| File | Purpose |
|------|---------|
| `ChartLayout.cs` | Result classes: `ChartLayout`, `ChartAreaLayout`, `AxisLayout`, `AxisTickLayout`, `AxisLabelLayout`, `SeriesLayout`, `DataPointLayout`, `LegendLayout`, `LegendItemLayout` |
| `AxisLayoutCalculator.cs` | Axis label sizes, tick marks, positions, nice interval calculation, coordinate conversion |
| `ChartLayoutEngine.cs` | Main layout calculator - title, legend, chart areas, axes, series positioning |

Unit tests created in `System.Windows.Forms.DataVisualization.Core.Tests/`:
- `ChartLayoutEngineTests.cs` - 15 tests covering layout calculations

### Phase 4.5.3: Chart Renderer ?

**Status: COMPLETE**

Created chart rendering classes in `System.Windows.Forms.DataVisualization.Core/Rendering/`:

| File | Purpose |
|------|---------|
| `ChartRenderer.cs` | Main chart renderer using `IRenderingEngine` |
| `AxisRenderer.cs` | Axis lines, labels, ticks, grid |
| `LegendRenderer.cs` | Legend rendering with chart-type-specific symbols |
| `ISeriesRenderer.cs` | Interface for chart type renderers |
| `SeriesRendererFactory.cs` | Factory to get appropriate renderer by chart type |
| `SeriesRenderers/LineSeriesRenderer.cs` | Line, Spline, StepLine, FastLine charts |
| `SeriesRenderers/BarSeriesRenderer.cs` | Bar, Column, Stacked variants |
| `SeriesRenderers/AreaSeriesRenderer.cs` | Area, SplineArea, StackedArea, Range charts |
| `SeriesRenderers/PieSeriesRenderer.cs` | Pie and Doughnut charts |
| `SeriesRenderers/PointSeriesRenderer.cs` | Point, FastPoint, Bubble, Scatter charts |

Unit tests created in `System.Windows.Forms.DataVisualization.Core.Tests/`:
- `ChartRendererTests.cs` - 10 tests for ChartRenderer and SeriesRendererFactory
- `MockRenderingEngine` - Test double for IRenderingEngine

### Phase 4.5.4: WinForms Adapter ?

**Status: COMPLETE**

Created adapter classes in `System.Windows.Forms.DataVisualization/Charting/Adapters/`:

| File | Purpose |
|------|---------|
| `ChartCoreAdapter.cs` | Implements `IChartModel` wrapping WinForms `Chart` |
| `ChartAreaCoreAdapter.cs` | Implements `IChartAreaModel` wrapping `ChartArea` |
| `AxisCoreAdapter.cs` | Implements `IAxisModel` wrapping `Axis` |
| `SeriesCoreAdapter.cs` | Implements `ISeriesModel` wrapping `Series` |
| `DataPointCoreAdapter.cs` | Implements `IDataPointModel` wrapping `DataPoint` |

### Phase 4.5.5: SvgChart Integration ?

**Status: COMPLETE**

Created adapter classes in `Svg.DataVisualization/Adapters/`:

| File | Purpose |
|------|---------|
| `SvgChartAdapter.cs` | Implements `IChartModel` wrapping `SvgChart` |
| `SvgChartAreaAdapter.cs` | Implements `IChartAreaModel` wrapping `SvgChartArea` |
| `SvgAxisAdapter.cs` | Implements `IAxisModel` with auto-calculated bounds |
| `SvgSeriesAdapter.cs` | Implements `ISeriesModel` wrapping `SvgChartSeries` |
| `SvgDataPointAdapter.cs` | Implements `IDataPointModel` wrapping `SvgDataPoint` |

Changes to `Svg.DataVisualization/SvgChart.cs`:
- Modified `Render()` to use `ChartLayoutEngine` and `ChartRenderer`
- Removed ~400 lines of custom layout/rendering code
- Added references to Core adapters and layout/rendering classes

### Estimated Effort

| Sub-Phase | Weeks |
|-----------|-------|
| 4.5.1 Core Model Interfaces | ? Done |
| 4.5.2 Layout Engine | ? Done |
| 4.5.3 Chart Renderer | ? Done |
| 4.5.4 WinForms Adapter | ? Done |
| 4.5.5 SvgChart Integration | ? Done |
| **Total** | **COMPLETE** |

---

## Remaining Work ?? (Sample Pages)

### Getting Started
- [ ] **Chart Elements (Overview)** - `ChartElementsOverview.razor`
- [ ] **Coordinate System (Overview)** - `CoordinateSystemOverview.razor`
- [ ] **Text Elements (Overview)** - `TextElementsOverview.razor`
- [ ] **Series and Points (Overview)** - `SeriesAndPointsOverview.razor`
- [ ] Basic Data Population - `BasicPopulatingData.razor`
- [ ] Creating a Chart Dynamically - `DynamicChartCreation.razor`

### Chart Types
- [ ] **Advanced Financial Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Stock and Candlestick Charts
- [ ] **Price Change Financial Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Kagi Chart
  - [ ] Renko Chart
  - [ ] Point and Figure Chart
  - [ ] Three Line Break Chart
- [ ] **Bar and Column Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] 3D Bar and Column Charts
  - [ ] 3D Cylinder Chart
  - [ ] Bar and Column Charts
  - [ ] Stacked Bar and Column Charts
- [ ] **Line Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Line, Step Line and Curve Charts
  - [ ] Fast Line Chart
  - [ ] 3D Line and Curve Charts
- [ ] **Point Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Bubble Charts
  - [ ] Point Charts
  - [ ] Fast Point Chart
- [ ] **Pie and Doughnut Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Doughnut Chart in Doughnut
  - [ ] Pie and Doughnut Charts
  - [ ] Collecting Small Pie Segments
  - [ ] Supplemental Pie Charts
- [ ] **Area Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] 3D Area and Spline Area Charts
  - [ ] Area and Spline Area Charts
- [ ] **Range Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Range and Spline Range Charts
  - [ ] 3D Range and Spline Range Charts
  - [ ] Range Bar Chart
  - [ ] 3D Range Bar Chart
  - [ ] Range Column Chart
- [ ] **Circular Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Polar Chart
  - [ ] Radar Chart
- [ ] **Combinational Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Combination of Chart Types
  - [ ] Pareto Chart
- [ ] **Data Distribution Charts** - Restructure to nested layout
  - [ ] Box Plot Chart
  - [ ] Histogram Chart
- [ ] **Accumulation Charts** - Restructure to nested layout
  - [ ] Gallery
  - [ ] Funnel Chart
  - [ ] Pyramid Chart
- [ ] **Error Bar Chart** - Restructure to nested layout

### Appearance
- [ ] Plotting Area Appearance
- [ ] Anti Aliasing
- [ ] Chart Background Appearance
- [ ] Border Appearance
- [ ] 3D Point Gap and Depth
- [ ] 3D Perspective
- [ ] Axis Line Appearance
- [ ] Strip Line Appearance
- [ ] 3D Rotation and Elevation
- [ ] Series Appearance
- [ ] Cursor Appearance
- [ ] Scrollbar Appearance
- [ ] Legend Appearance

### Chart Features
- [ ] Data Series
  - [ ] Overview
  - [ ] Series and Chart Areas
  - [ ] Adding and Removing Series at Run-Time
  - [ ] Hiding Series
  - [ ] Indexed X Values
  - [ ] Points Width and 3D Depth
  - [ ] Secondary Y Axis
  - [ ] Series Z Order
  - [ ] Series Appearance
  - [ ] Using Labels
  - [ ] Using Markers
  - [ ] Custom ToolTips
  - [ ] Smart Labels
- [ ] Chart Areas
  - [ ] Overview
  - [ ] Chart Area and Plotting Area Positions
  - [ ] Plotting Area Appearance
  - [ ] Alignment Types
  - [ ] Mini-Chart in Data Points
  - [ ] Doughnut Chart in Doughnut
  - [ ] Z Order
  - [ ] Points Width and 3D Depth
  - [ ] Cursor Position Changed
  - [ ] Cursor Appearance
  - [ ] Cursor Axis Attachment
  - [ ] Cursor Intervals
  - [ ] Keyboard Zoom/Scroll Cursors
  - [ ] Multi Chart Area Cursor
  - [ ] Auto Zoom/Scroll Cursors
- [ ] Axes
  - [ ] Overview
  - [ ] Axis Line Appearance
  - [ ] Multiple Y Axes
  - [ ] Axis Title
  - [ ] Axis Margins
  - [ ] Axis Scale
  - [ ] Logarithmic Scale
  - [ ] Scale Breaks
  - [ ] Crossing and Reverse Axis Properties
  - [ ] Grid Lines and Tick Marks
  - [ ] Primary and Secondary Axes
  - [ ] Strip Line Titles
  - [ ] Strip Line Appearance
  - [ ] Interlaced Strip Lines
  - [ ] Setting Variable Label Intervals
  - [ ] Highlighting Dates Using StripLines
  - [ ] Offset Strip Lines
  - [ ] Labels Next To Axis
  - [ ] Auto Fit Axes Labels
  - [ ] Axis Labels Interval
  - [ ] Custom Labels
  - [ ] Equally Sized Axes Labels
- [ ] Legends
  - [ ] Overview
  - [ ] Appearance
  - [ ] Interactive Legend
  - [ ] Style and Auto Positioning
  - [ ] Setting Multiple Columns
  - [ ] Legend Font
  - [ ] Adding a Legend Title
  - [ ] Series Legend Assignment
  - [ ] Explicit Positioning
  - [ ] Multiple Legends
  - [ ] Custom Legend Items
  - [ ] Legend Cells
  - [ ] Legend Cell Span
- [ ] Labels
  - [ ] Overview
  - [ ] Smart Labels
  - [ ] Axis and Data Point Labels
  - [ ] Axis Labels Interval
  - [ ] Labels Text Style
  - [ ] Formatting Labels
  - [ ] Using Keywords in Labels
  - [ ] Setting Variable Label Intervals
  - [ ] Labels Next To Axis
  - [ ] Auto Fit Axes Labels
  - [ ] Custom Labels
  - [ ] Equally Sized Axes Labels
- [ ] Titles
  - [ ] Overview
  - [ ] Chart Title
  - [ ] Legend Title
  - [ ] Axis Title
  - [ ] Strip Line Titles
  - [ ] Multiple Titles
  - [ ] Explicit Positioning
- [ ] Annotations
  - [ ] Overview
  - [ ] Annotation Appearance
  - [ ] Annotation Types
  - [ ] Annotation Smart Labels
  - [ ] Annotation Anchoring
  - [ ] Free-drawing Annotations
  - [ ] Editing Annotation Text
  - [ ] Grouping Annotations
  - [ ] AnnotationPositionChanging Event
  - [ ] AnnotationPositionChanged Event
- [ ] Customization and Events
  - [ ] Overview
  - [ ] PrePaint and PostPaint Events
  - [ ] Custom Painting an Image
  - [ ] Custom Painting a DataTable
  - [ ] Customizing the Scrollbar
  - [ ] Custom ToolTips
  - [ ] AnnotationPositionChanged Event
  - [ ] AnnotationPositionChanging Event
  - [ ] AxisViewChanged Event
  - [ ] CursorPositionChanged Event
- [ ] Interactive Charting
  - [ ] Overview
  - [ ] Selection
    - [ ] Drill Down
    - [ ] Interactive Pie Chart
    - [ ] Changing Values by Dragging
    - [ ] Selection of Data Points
  - [ ] Cursors
    - [ ] Cursor Appearance
    - [ ] Cursor Axis Attachment
    - [ ] Cursor Intervals
    - [ ] Keyboard Zoom/Scroll Cursors
    - [ ] Multi Chart Area Cursor
    - [ ] Auto Zoom/Scroll Cursors
  - [ ] Zooming and Scrolling
    - [ ] Basic Zooming
    - [ ] Scrollbar Appearance
    - [ ] Scrolling Axis with the Keyboard
    - [ ] Small Scrolling Size
    - [ ] Limiting View Size
    - [ ] AxisScrollBarClicked Event
    - [ ] Multi Chart Area Cursor
  - [ ] Tooltips
    - [ ] Standard ToolTips
    - [ ] Custom ToolTips
- [ ] Printing
  - [ ] Overview
  - [ ] Printing and Previewing
  - [ ] Programmatic Print Settings
  - [ ] Printer Friendly Charts
  - [ ] Multipage Printing
  - [ ] Custom Printing
- [ ] Serialization
  - [ ] Overview
  - [ ] Basic Serialization
  - [ ] Using Templates
  - [ ] Printer Friendly Charts
