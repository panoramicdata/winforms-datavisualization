# Layout Engine Extraction Plan

## Overview

This document outlines the step-by-step approach for extracting the WinForms layout engine to the Core library. The goal is to share the exact same layout logic between WinForms and SVG/Blazor while maintaining **pixel-perfect fidelity** with the WinForms reference implementation.

## Phase 1: Foundation (Completed ?)

### 1.1 ILayoutGraphics Interface ?
**File:** `System.Windows.Forms.DataVisualization.Core/Layout/ILayoutGraphics.cs`

Abstracts graphics operations needed for layout calculations:
- Coordinate conversion (relative ? absolute)
- Text measurement
- Chart dimensions

### 1.2 WinForms Adapter ?
**File:** `System.Windows.Forms.DataVisualization/Charting/Utilities/ChartGraphicsLayoutAdapter.cs`

Wraps `ChartGraphics` to implement `ILayoutGraphics`, providing GDI+-compatible coordinate conversion and text measurement.

### 1.3 ChartElementPosition ?
**File:** `System.Windows.Forms.DataVisualization.Core/Layout/ChartElementPosition.cs`

Core version of `ElementPosition` for storing relative (0-100) positions of chart elements.

---

## Phase 2: Axis Layout Extraction (Completed ?)

### 2.1 AxisLayoutCalculator ?
**File:** `System.Windows.Forms.DataVisualization.Core/Layout/AxisLayoutCalculator.cs`

Calculates axis layout including:
- Mark/tick mark sizes
- Label sizes and positions
- Title sizes
- Nice interval calculation
- Custom label support

### 2.2 AxisLayout Model ?
**File:** `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayout.cs`

Contains calculated axis state:
- Minimum/Maximum values
- Interval
- Tick positions
- Label positions and text
- ValueToPixel/PixelToValue conversion

---

## Phase 3: ChartArea Layout (Completed ?)

### 3.1 ChartAreaLayout ?
Integrated into `ChartLayoutEngine.CalculateChartAreaLayout()`:
- Plot area calculation
- Axis space reservation
- Series layout calculation
- Data point positioning

### 3.2 ChartLayout ?
**File:** `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayout.cs`

Complete layout output model:
- Title bounds
- Legend bounds
- Content bounds
- Chart area layouts (multiple)
- Series and point layouts

---

## Phase 4: ChartPicture Layout (Completed ?)

### 4.1 ChartLayoutEngine ?
**File:** `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayoutEngine.cs`

Main layout engine handling:
- Overall chart layout
- Title positioning
- Legend positioning
- Chart area grid distribution
- Padding and margins

---

## Phase 5: Integration (Completed ?)

### 5.1 Model Interfaces ?
- `IChartModel` - Chart abstraction
- `IChartAreaModel` - Chart area abstraction
- `IAxisModel` - Axis abstraction
- `ISeriesModel` - Series abstraction
- `IDataPointModel` - Data point abstraction

### 5.2 SVG Integration ?
**Files:**
- `Svg.DataVisualization/SvgChart.cs` - Uses Core layout engine
- `Svg.DataVisualization/Adapters/*.cs` - Adapters implementing Core interfaces

### 5.3 Rendering Integration ?
**Files:**
- `System.Windows.Forms.DataVisualization.Core/Rendering/ChartRenderer.cs`
- `System.Windows.Forms.DataVisualization.Core/Rendering/AxisRenderer.cs`
- `System.Windows.Forms.DataVisualization.Core/Rendering/LegendRenderer.cs`
- `System.Windows.Forms.DataVisualization.Core/Rendering/SeriesRenderers/*.cs`

---

## Phase 6: Testing and Verification (In Progress ??)

### 6.1 Layout Engine Tests ?
**File:** `System.Windows.Forms.DataVisualization.Core.Tests/ChartLayoutEngineTests.cs`

57 tests covering:
- Basic layout calculations
- Axis layout (ticks, labels, intervals)
- Layout fidelity (determinism, margins, scaling)
- Legend/title impact
- Multiple chart areas
- Multiple series

### 6.2 WinForms Comparison Tests ?
**Status:** Not yet implemented

Future work: Create tests that compare Core layout output to WinForms ChartArea.Resize() results to verify pixel-perfect fidelity.

---

## Phase 7: Circular Chart Layout (Completed ?)

**Status:** Extracted and integrated with SVG/Blazor.

### 7.1 Core Circular Layout Components ?

Created in `System.Windows.Forms.DataVisualization.Core`:

- **`ChartTypes/ICircularChartType.cs`** - Interface defining circular chart behavior
  - `RadarDrawingStyle` enum (Area, Line, Marker)
  - `PolarDrawingStyle` enum (Line, Marker)
  - `CircularAxisLabelsStyle` enum (Auto, Circular, Radial, Horizontal)
  - `CircularAreaDrawingStyle` enum (Circle, Polygon)

- **`Models/IChartModel.cs`** - Extended with circular interfaces
  - `ICircularChartAreaModel` - Circular chart area abstraction
  - `ICircularAxisModel` - Circular axis (spoke) abstraction

- **`Layout/CircularChartLayout.cs`** - Layout result models
  - `CircularChartAreaLayout` - Layout with center, radius, sectors
  - `CircularAxisLayout` - Position and label for each spoke
  - `CircularGridLayout` - Concentric grid circles/polygons
  - `CircularDataPointLayout` - Point with angle and distance

- **`Layout/CircularLayoutEngine.cs`** - Layout calculation engine
  - Calculates center point and radius
  - Handles Y axis range from data
  - Positions circular axes (spokes)
  - Calculates grid lines
  - Converts data values to polar positions

### 7.2 Series Renderers ?

Created in `System.Windows.Forms.DataVisualization.Core/Rendering/SeriesRenderers`:

- **`RadarSeriesRenderer.cs`** - Renders Radar charts
  - Area, Line, and Marker drawing styles
  - Filled polygons from center
  - Closed figure (connects last point to first)

- **`PolarSeriesRenderer.cs`** - Renders Polar charts
  - Line and Marker drawing styles
  - Points ordered by X value (angle)
  - Open figure (doesn't close automatically)

### 7.3 SVG Integration ?

Added to `Svg.DataVisualization`:

- **`SvgChart.cs`** - Extended with circular types
  - `SvgChartType.Radar` and `SvgChartType.Polar`
  - `SvgCircularChartArea` class
  - `SvgCircularLabelsStyle` and `SvgCircularAreaStyle` enums

- **`Adapters/SvgCircularChartAreaAdapter.cs`** - Implements `ICircularChartAreaModel`
  - Auto-detects Radar/Polar series
  - Creates circular axis models from labels
  - Converts SVG enums to Core enums

### 7.4 Blazor Sample ?

Updated `ChartSamples.Blazor/Components/Pages/ChartTypes/CircularCharts.razor`:
- Uses `SvgChartType.Radar` and `SvgChartType.Polar`
- Properly configures circular charts

---

## Remaining Work

### Features Still Pending

1. ~~**Circular Charts**~~ ? **COMPLETED**

2. **3D Charts** ?
   - WinForms handles `Area3DStyle.Enable3D`
   - Wall width adjustments
   - Lower priority - focus on 2D first

3. **Scroll Bars** ?
   - WinForms axis scroll bar sizing
   - Not applicable to SVG/Blazor rendering
   - Can remain WinForms-only

4. **Auto-Fit Font Sizing** ?
   - WinForms `IsSameFontSizeForAllAxes` support
   - Axis label auto-fit fonts
   - Partial implementation in Core

5. **Chart Area Alignment** ?
   - WinForms `AlignWithChartArea` property
   - `AreaAlignmentStyles` and `AreaAlignmentOrientations`
   - Medium priority

---

## Files Created/Modified

### Core Layout Files (Created)
- `System.Windows.Forms.DataVisualization.Core/Layout/ILayoutGraphics.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/ChartElementPosition.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayoutEngine.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/AxisLayoutCalculator.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayout.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/ITextMeasurer.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/CircularChartLayout.cs` ? NEW
- `System.Windows.Forms.DataVisualization.Core/Layout/CircularLayoutEngine.cs` ? NEW
- `System.Windows.Forms.DataVisualization.Core/ChartTypes/ICircularChartType.cs` ? NEW
- `System.Windows.Forms.DataVisualization.Core/Rendering/SeriesRenderers/RadarSeriesRenderer.cs` ? NEW
- `System.Windows.Forms.DataVisualization.Core/Rendering/SeriesRenderers/PolarSeriesRenderer.cs` ? NEW

### WinForms Adapters (Created)
- `System.Windows.Forms.DataVisualization/Charting/Utilities/ChartGraphicsLayoutAdapter.cs`
- `System.Windows.Forms.DataVisualization/Charting/Utilities/GdiTextMeasurer.cs`
- `System.Windows.Forms.DataVisualization/Charting/Adapters/*.cs`

### SVG Adapters (Created)
- `Svg.DataVisualization/Adapters/SvgChartAdapter.cs`
- `Svg.DataVisualization/Adapters/SvgChartAreaAdapter.cs`
- `Svg.DataVisualization/Adapters/SvgAxisAdapter.cs`
- `Svg.DataVisualization/Adapters/SvgSeriesAdapter.cs`
- `Svg.DataVisualization/Adapters/SvgDataPointAdapter.cs`
- `Svg.DataVisualization/Adapters/SvgCircularChartAreaAdapter.cs` ? NEW
- `Svg.DataVisualization/SvgTextMeasurer.cs`

### Test Files (Created)
- `System.Windows.Forms.DataVisualization.Core.Tests/ChartLayoutEngineTests.cs`

---

## Architecture Summary

```
???????????????????????????????????????????????????????????????
?                      Consumer Code                          ?
?   (SvgChart, Blazor ChartViewer, WinForms Chart)           ?
???????????????????????????????????????????????????????????????
                              ?
                              ?
???????????????????????????????????????????????????????????????
?                    Adapter Layer                            ?
?   SvgChartAdapter, SvgCircularChartAreaAdapter, etc.       ?
?   (Implements IChartModel, ICircularChartAreaModel, etc.)  ?
???????????????????????????????????????????????????????????????
                              ?
                              ?
???????????????????????????????????????????????????????????????
?              Core Layout Engine                             ?
?   ChartLayoutEngine ? AxisLayoutCalculator                 ?
?   CircularLayoutEngine ?                                  ?
?   (Platform-agnostic, uses ITextMeasurer)                  ?
???????????????????????????????????????????????????????????????
                              ?
                              ?
???????????????????????????????????????????????????????????????
?                    ChartLayout                              ?
?   Complete calculated layout with all positions             ?
?   CircularChartAreaLayout ?                               ?
???????????????????????????????????????????????????????????????
                              ?
                              ?
???????????????????????????????????????????????????????????????
?                    Core Renderer                            ?
?   ChartRenderer ? AxisRenderer, SeriesRenderers            ?
?   RadarSeriesRenderer, PolarSeriesRenderer ?              ?
?   (Uses IRenderingEngine abstraction)                      ?
???????????????????????????????????????????????????????????????
                              ?
                              ?
???????????????????????????????????????????????????????????????
?              Rendering Engine                               ?
?   SvgRenderingEngine, GdiRenderingEngine (future)          ?
?   (Platform-specific drawing operations)                   ?
???????????????????????????????????????????????????????????????
```

---

## Success Criteria

- [x] Core layout engine calculates positions without GDI+ dependencies
- [x] SVG charts use Core layout engine successfully
- [x] Layout tests pass (57 tests)
- [x] Multiple chart types render correctly in SVG
- [x] Circular chart layout extracted to Core ?
- [x] Radar and Polar charts render in SVG ?
- [ ] WinForms can optionally use Core layout (future)
- [ ] Pixel-perfect comparison tests pass (future)

---

## Priority Order for Remaining Work

1. ~~**Phase 7: Circular Chart Layout**~~ ? COMPLETED

2. **Auto-Fit Font Sizing** - MEDIUM PRIORITY
   - Improves layout quality
   - Better label sizing

3. **Chart Area Alignment** - MEDIUM PRIORITY
   - Useful for dashboard layouts
   - Multiple aligned chart areas

4. **3D Charts** - LOW PRIORITY
   - Complex implementation
   - Less common in web scenarios
   - Focus on 2D first

5. **Scroll Bars** - NOT NEEDED for SVG/Blazor
   - WinForms-specific interactive feature
   - Can remain WinForms-only

---

## Last Updated
2025-12-11 - Circular chart layout COMPLETED. Radar and Polar charts now work in SVG/Blazor.

