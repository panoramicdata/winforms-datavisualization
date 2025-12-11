# Phase 4: Blazor WebAssembly ChartSamples - Full Parity Plan

## Overview
This document tracks the migration of all WinForms ChartSamples to the Blazor WebAssembly application, achieving full feature parity.

---

## Current Status Summary

| Category | WinForms Samples | Blazor Samples | Coverage |
|----------|------------------|----------------|----------|
| Getting Started | 2 | 2 | ? 100% |
| Chart Types | 35 | 16 | ?? 46% |
| Chart Features | 70+ | 11 | ?? 16% |
| Chart Appearance | 5 | 2 | ?? 40% |
| **Total** | **112+** | **31** | **~28%** |

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

### Getting Started (2/2) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `BasicPopulatingData.cs` | `BasicPopulatingData.razor` | ? Complete |
| `DynamicChartCreation.cs` | `DynamicChartCreation.razor` | ? Complete |

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
| `Histogram.cs` | `HistogramCharts.razor` | ? **NEW** |
| `BoxPlotChartType.cs` | `BoxPlotCharts.razor` | ? **NEW** |
| `CombinatorialChartType.cs` | `CombinationalCharts.razor` | ? **NEW** |
| `ErrorBarChartType.cs` | `ErrorBarCharts.razor` | ? **NEW** |
| `ParetoChartType.cs` | `ParetoCharts.razor` | ? **NEW** |

### Chart Features - Completed (11/70+) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `ChartTitle.cs` / Legend samples | `TitlesLegends.razor` | ? Complete |
| `LegendAppearance.cs` | `LegendAppearance.razor` | ? **NEW** |
| `LegendStylePosition.cs` | `LegendPosition.razor` | ? **NEW** |
| Multiple Series samples | `MultipleSeries.razor` | ? Complete |
| Styling samples | `ChartStyling.razor` | ? Complete |
| Axis samples (5+) | `AxisFeatures.razor` | ? Complete |
| Label samples (8+) | `Labels.razor` | ? Complete |
| DataSeries samples (7+) | `DataSeries.razor` | ? Complete |
| ChartArea samples (6+) | `ChartArea.razor` | ? Complete |
| `UsingToolTips.cs` | `Tooltips.razor` | ? **NEW** |
| `SavingAndCopyingImages.cs` | `ExportChart.razor` | ? **NEW** |

### Chart Appearance - Completed (2/5) ?
| WinForms Sample | Blazor Page | Status |
|-----------------|-------------|--------|
| `Palettes.cs` | `ColorPalettes.razor` | ? Complete |
| `ChartAppearance.cs` | `Backgrounds.razor` | ? Complete |

---

## Remaining Work ??

### Chart Types - Remaining (19 samples)

#### Line Charts (2 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `LineCurves3D.cs` | `LineCharts3D.razor` | Low (3D) |
| Step Line (in LineCurves) | (Add to LineCharts.razor) | High |

#### Bar/Column Charts (3 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `BarColumn3D.cs` | `BarColumn3D.razor` | Low (3D) |
| `Cylinder3D.cs` | `Cylinder3D.razor` | Low (3D) |
| 100% Stacked | (Add to StackedCharts.razor) | High |

#### Area Charts (1 sample)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `AreaChart3D.cs` | `AreaCharts3D.razor` | Low (3D) |

#### Pie/Doughnut Charts (2 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `PieCollectedData.cs` | `PieCollectedData.razor` | Medium |
| Doughnut (in existing) | (Add to PieCharts.razor) | High |

#### Range Charts (2 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `Range3D.cs` | `Range3D.razor` | Low (3D) |
| `RangeBar3D.cs` | `RangeBar3D.razor` | Low (3D) |

#### Price Range Financial Charts (4 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `KagiChartType.cs` | `KagiCharts.razor` | Medium |
| `RenkoChartType.cs` | `RenkoCharts.razor` | Medium |
| `PointAndFigureChartType.cs` | `PointAndFigureCharts.razor` | Medium |
| `ThreeLineBreakChartType.cs` | `ThreeLineBreakCharts.razor` | Medium |

#### Data Distribution Charts (2 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `Histogram.cs` | `HistogramCharts.razor` | High |
| `BoxPlotChartType.cs` | `BoxPlotCharts.razor` | High |

#### Combinational Charts (2 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `CombinatorialChartType.cs` | `CombinationalCharts.razor` | High |
| `ParetoChartType.cs` | `ParetoCharts.razor` | Medium |

#### Error Bar Charts (1 sample)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `ErrorBarChartType.cs` | `ErrorBarCharts.razor` | Medium |

### Chart Features - Remaining (59+ samples)

#### Annotations (8 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `AnnotationAppearance.cs` | `AnnotationAppearance.razor` | High |
| `AnnotationAnchoring.cs` | `AnnotationAnchoring.razor` | Medium |
| `AnnotationStyles.cs` | `AnnotationStyles.razor` | Medium |
| `AnnotationEditing.cs` | `AnnotationEditing.razor` | Medium |
| `AnnotationSmartLabels.cs` | `AnnotationSmartLabels.razor` | Low |
| `AnnotationPositionChanging.cs` | `AnnotationPositionChanging.razor` | Low |
| `GroupingAnnotations.cs` | `GroupingAnnotations.razor` | Low |
| `FreeDrawAnnotation.cs` | `FreeDrawAnnotation.razor` | Low |
| `PositionChangedEvent.cs` | (Combine with above) | Low |

#### Axis Features - Additional (8 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `AxisAppearance.cs` | (Add to AxisFeatures.razor) | ? Done |
| `AxisScale.cs` | (Add to AxisFeatures.razor) | ? Done |
| `PrimarySecondaryAxis.cs` | `MultipleAxes.razor` | High |
| `LogarithmicScale.cs` | `LogarithmicScale.razor` | Medium |
| `AxisCrossing.cs` | `AxisCrossing.razor` | Medium |
| `AxisTitle.cs` | (Add to AxisFeatures.razor) | ? Done |
| `AxisMargins.cs` | `AxisMargins.razor` | Low |
| `ScaleBreaks.cs` | `ScaleBreaks.razor` | Medium |
| `HighlightDateRange.cs` | `HighlightDateRange.razor` | Low |
| `InterlacedStrips.cs` | `InterlacedStrips.razor` | Low |
| `StripIntervals.cs` | `StripIntervals.razor` | Low |
| `StripLineTitle.cs` | `StripLineTitle.razor` | Low |
| `StripLines.cs` | (Add to AxisFeatures.razor) | ? Done |
| `GridLinesTicks.cs` | (Add to AxisFeatures.razor) | ? Done |
| `MultipleYAxis.cs` | (Add to AxisFeatures.razor) | ? Done |

#### Labels - Additional (6 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `CustomLabels.cs` | (Add to Labels.razor) | ? Done |
| `SmartLabels.cs` | (Add to Labels.razor) | ? Done |
| `LabelsFormatting.cs` | (Add to Labels.razor) | ? Done |
| `LabelsKeywords.cs` | `LabelsKeywords.razor` | Medium |
| `LabelsTextStyle.cs` | `LabelsTextStyle.razor` | Low |
| `LabelsNextToAxis.cs` | `LabelsNextToAxis.razor` | Low |
| `MultilineLabels.cs` | `MultilineLabels.razor` | Low |
| `AutoFitAxesLabels.cs` | `AutoFitLabels.razor` | Low |
| `AxisLabelsInterval.cs` | `AxisLabelsInterval.razor` | Low |
| `AxisVarLabelsInterval.cs` | `AxisVarLabelsInterval.razor` | Low |
| `EquallySizedAutoFont.cs` | `EqualSizedLabels.razor` | Low |

#### Legend (12 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `LegendAppearance.cs` | `LegendAppearance.razor` | High |
| `LegendStylePosition.cs` | `LegendPosition.razor` | High |
| `LegendTitle.cs` | `LegendTitle.razor` | Medium |
| `LegendFont.cs` | `LegendFont.razor` | Low |
| `LegendCustomPosition.cs` | `LegendCustomPosition.razor` | Medium |
| `LegendCells.cs` | `LegendCells.razor` | Low |
| `LegendCellColumns.cs` | `LegendCellColumns.razor` | Low |
| `LegendCellSpan.cs` | `LegendCellSpan.razor` | Low |
| `LegendCustomItems.cs` | `LegendCustomItems.razor` | Medium |
| `MultipleLegends.cs` | `MultipleLegends.razor` | Medium |
| `LegendInteractive.cs` | `LegendInteractive.razor` | Medium |
| `MultipleLegendsWithCheckBox.cs` | `LegendCheckbox.razor` | Low |

#### Titles (3 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `ChartTitle.cs` | (Add to TitlesLegends.razor) | ? Done |
| `MultilpleTitles.cs` | `MultipleTitles.razor` | Medium |
| `TitleCustomPosition.cs` | `TitlePosition.razor` | Low |

#### Data Series - Additional (4 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `SeriesAppearance.cs` | (Add to DataSeries.razor) | ? Done |
| `UsingMarkers.cs` | (Add to DataSeries.razor) | ? Done |
| `AddingSeries.cs` | (Add to DataSeries.razor) | ? Done |
| `HidingSeries.cs` | (Add to DataSeries.razor) | ? Done |
| `SecondaryAxis.cs` | `SecondaryAxis.razor` | Medium |
| `SeriesZOrder.cs` | `SeriesZOrder.razor` | Low |
| `IndexedX.cs` | `IndexedX.razor` | Low |
| `PointWidthAndDepth.cs` | `PointWidthDepth.razor` | Low |
| `UsingLabels.cs` | `SeriesLabels.razor` | Medium |

#### Chart Area - Additional (5 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `Appearance.cs` | (Add to ChartArea.razor) | ? Done |
| `ChartArea3D.cs` | (Add to ChartArea.razor) | ? Done |
| `SeriesAndChartAreas.cs` | `SeriesChartAreas.razor` | Medium |
| `AligningChartingAreas.cs` | `AligningChartAreas.razor` | Medium |
| `AlignmentTypes.cs` | `AlignmentTypes.razor` | Low |
| `ChartAreaPosition.cs` | `ChartAreaPosition.razor` | Low |
| `ZOrder.cs` | `ChartAreaZOrder.razor` | Low |
| `ChartInDataPoint.cs` | `ChartInDataPoint.razor` | Low |
| `ChartInDoughnut.cs` | `ChartInDoughnut.razor` | Low |

#### Interactive Charting (15 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| **Cursors (7)** | | |
| `CursorAppearance.cs` | `CursorAppearance.razor` | Medium |
| `CursorInterval.cs` | `CursorInterval.razor` | Low |
| `CursorAxis.cs` | `CursorAxis.razor` | Low |
| `CursorAutoZoomScroll.cs` | `CursorAutoZoom.razor` | Low |
| `MultiChartAreaCursor.cs` | `MultiAreaCursor.razor` | Low |
| `KeyboardZoomScroll.cs` | `KeyboardZoom.razor` | Low |
| **Zooming/Scrolling (5)** | | |
| `BasicZooming.cs` | `BasicZooming.razor` | High |
| `ZoomingExtents.cs` | `ZoomingExtents.razor` | Medium |
| `ScrollBarAppearance.cs` | `ScrollBarAppearance.razor` | Low |
| `SmallScrollSize.cs` | `SmallScrollSize.razor` | Low |
| `KeyboardScrolling.cs` | `KeyboardScrolling.razor` | Low |
| **Selection (4)** | | |
| `Selection.cs` | `Selection.razor` | Medium |
| `PointsDragging.cs` | `PointsDragging.razor` | Low |
| `InteractivePie.cs` | `InteractivePie.razor` | Medium |
| `DrillDown.cs` | `DrillDown.razor` | Medium |
| **ToolTips (2)** | | |
| `UsingToolTips.cs` | `Tooltips.razor` | High |
| `CustomToolTips.cs` | `CustomTooltips.razor` | Medium |

#### Events (3 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `CursorPositionChanged.cs` | `CursorEvents.razor` | Low |
| `ScrollBarEvents.cs` | `ScrollBarEvents.razor` | Low |
| `ViewChangedEvent.cs` | `ViewChangedEvent.razor` | Low |

#### Printing (4 samples) - Web Equivalent: Export
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `PrintPreview.cs` | `ExportChart.razor` | High |
| `PrintingSettings.cs` | (Add to ExportChart.razor) | Medium |
| `PrinterFriendlyCharts.cs` | (Add to ExportChart.razor) | Low |
| `MultipagePrinting.cs` | N/A (Not applicable to web) | Skip |
| `CustomPrinting.cs` | N/A (Not applicable to web) | Skip |

#### Serialization (2 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `BasicSerialization.cs` | `Serialization.razor` | Low |
| `Templates.cs` | `Templates.razor` | Low |

#### Customizations (3 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `PrePostPaint.cs` | `CustomRendering.razor` | Low |
| `PaintingDataTable.cs` | `DataTable.razor` | Low |
| `CustomDrawnTitles.cs` | `CustomTitles.razor` | Low |

#### Saving/Copying (1 sample)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `SavingAndCopyingImages.cs` | `SaveExport.razor` | High |

### Chart Appearance - Remaining (3 samples)
| WinForms Sample | Blazor Page | Priority |
|-----------------|-------------|----------|
| `Borders.cs` | `Borders.razor` | Medium |
| `AntiAliasingSample.cs` | `AntiAliasing.razor` | Low |
| `UsingPerspectives.cs` | `Perspectives3D.razor` | Low (3D) |
| `UsingGaps3D.cs` | `Gaps3D.razor` | Low (3D) |

---

## Implementation Phases

### Phase 4.1: High Priority Chart Types (Target: +8 samples)
Focus on commonly used chart types not yet implemented.

1. `HistogramCharts.razor` - Data distribution
2. `BoxPlotCharts.razor` - Statistical analysis
3. `CombinationalCharts.razor` - Mixed chart types
4. `ErrorBarCharts.razor` - Error visualization
5. Add Step Line to `LineCharts.razor`
6. Add 100% Stacked to `StackedCharts.razor`
7. Add Doughnut options to `PieCharts.razor`
8. `ParetoCharts.razor` - Quality analysis

### Phase 4.2: Essential Chart Features (Target: +10 samples)
Focus on most commonly needed features.

1. `LegendAppearance.razor`
2. `LegendPosition.razor`
3. `MultipleAxes.razor`
4. `LogarithmicScale.razor`
5. `MultipleTitles.razor`
6. `Tooltips.razor`
7. `BasicZooming.razor`
8. `ExportChart.razor` (Download as SVG/PNG)
9. `Selection.razor`
10. `SaveExport.razor`

### Phase 4.3: Annotations (Target: +4 samples)
1. `AnnotationAppearance.razor`
2. `AnnotationAnchoring.razor`
3. `AnnotationStyles.razor`
4. `AnnotationEditing.razor`

### Phase 4.4: Advanced Financial Charts (Target: +4 samples)
1. `KagiCharts.razor`
2. `RenkoCharts.razor`
3. `PointAndFigureCharts.razor`
4. `ThreeLineBreakCharts.razor`

### Phase 4.5: Interactive Features (Target: +6 samples)
1. `DrillDown.razor`
2. `InteractivePie.razor`
3. `CustomTooltips.razor`
4. `CursorAppearance.razor`
5. `ZoomingExtents.razor`
6. `PointsDragging.razor`

### Phase 4.6: Remaining Legend & Titles (Target: +8 samples)
1. `LegendTitle.razor`
2. `LegendCustomPosition.razor`
3. `LegendCustomItems.razor`
4. `MultipleLegends.razor`
5. `LegendInteractive.razor`
6. `TitlePosition.razor`
7. `LegendCells.razor`
8. `LegendCellColumns.razor`

### Phase 4.7: Additional Axis & Label Features (Target: +8 samples)
1. `AxisCrossing.razor`
2. `ScaleBreaks.razor`
3. `LabelsKeywords.razor`
4. `LabelsTextStyle.razor`
5. `MultilineLabels.razor`
6. `SecondaryAxis.razor`
7. `SeriesLabels.razor`
8. `AxisLabelsInterval.razor`

### Phase 4.8: Chart Area & Series Advanced (Target: +6 samples)
1. `SeriesChartAreas.razor`
2. `AligningChartAreas.razor`
3. `ChartAreaPosition.razor`
4. `SeriesZOrder.razor`
5. `IndexedX.razor`
6. `PointWidthDepth.razor`

### Phase 4.9: Appearance & Styling (Target: +3 samples)
1. `Borders.razor`
2. `AntiAliasing.razor`
3. `Serialization.razor`

### Phase 4.10: Low Priority / 3D (Optional)
3D charts require significant SVG work and may be deferred:
- `LineCharts3D.razor`
- `BarColumn3D.razor`
- `Cylinder3D.razor`
- `AreaCharts3D.razor`
- `Range3D.razor`
- `RangeBar3D.razor`
- `Perspectives3D.razor`
- `Gaps3D.razor`

---

## Estimated Effort

| Phase | Samples | Estimated Hours |
|-------|---------|-----------------|
| Phase 4.1 | 8 | 8-12 |
| Phase 4.2 | 10 | 12-16 |
| Phase 4.3 | 4 | 6-8 |
| Phase 4.4 | 4 | 6-8 |
| Phase 4.5 | 6 | 10-14 |
| Phase 4.6 | 8 | 8-10 |
| Phase 4.7 | 8 | 8-10 |
| Phase 4.8 | 6 | 6-8 |
| Phase 4.9 | 3 | 3-4 |
| Phase 4.10 | 8 | 16-24 (complex) |
| **Total** | **65** | **83-114 hours** |

---

## Notes

### Features Requiring SVG Enhancement
Some WinForms features require additional SVG rendering capabilities:
- 3D charts (perspective, rotation, depth)
- Annotations with anchoring
- Interactive cursors
- Drag-and-drop points
- Real-time scrolling/zooming

### Web-Specific Alternatives
| WinForms Feature | Web Alternative |
|------------------|-----------------|
| Printing | Export to SVG/PNG download |
| GDI+ rendering | SVG rendering |
| Mouse cursors | CSS cursors + JS interop |
| Drag events | Blazor @ondrag events |
| Tooltips | HTML tooltips or JS interop |

### Skipped Samples
The following WinForms samples are not applicable to web:
- `MultipagePrinting.cs` - No web equivalent
- `CustomPrinting.cs` - Use export instead
- Utility classes (helpers, not samples)

---

## Success Criteria

1. **Sample Count**: 85+ samples (matching WinForms essentials)
2. **Chart Types**: All major chart types supported
3. **Features**: Core features (legends, axes, labels, tooltips) complete
4. **Interactivity**: Basic zoom, selection, tooltips working
5. **Export**: SVG/PNG download functionality
6. **Responsive**: Works on desktop and mobile browsers
7. **Performance**: Charts render in < 500ms

---

## File Structure Target

```
ChartSamples.Blazor/Components/Pages/
??? Index.razor
??? GettingStarted/
?   ??? BasicPopulatingData.razor ?
?   ??? DynamicChartCreation.razor ?
??? ChartTypes/
?   ??? LineCharts.razor ?
?   ??? BarColumnCharts.razor ?
?   ??? AreaCharts.razor ?
?   ??? PieCharts.razor ?
?   ??? ScatterCharts.razor ?
?   ??? PointCharts.razor ?
?   ??? RangeCharts.razor ?
?   ??? StackedCharts.razor ?
?   ??? FinancialCharts.razor ?
?   ??? CircularCharts.razor ?
?   ??? PyramidFunnelCharts.razor ?
?   ??? HistogramCharts.razor ??
?   ??? BoxPlotCharts.razor ??
?   ??? CombinationalCharts.razor ??
?   ??? ErrorBarCharts.razor ??
?   ??? ParetoCharts.razor ??
?   ??? KagiCharts.razor ??
?   ??? RenkoCharts.razor ??
?   ??? ... (more)
??? ChartFeatures/
?   ??? TitlesLegends.razor ?
?   ??? MultipleSeries.razor ?
?   ??? ChartStyling.razor ?
?   ??? AxisFeatures.razor ?
?   ??? Labels.razor ?
?   ??? DataSeries.razor ?
?   ??? ChartArea.razor ?
?   ??? Annotations/ ??
?   ??? Legend/ ??
?   ??? Interactive/ ??
?   ??? ... (more)
??? ChartAppearance/
    ??? ColorPalettes.razor ?
    ??? Backgrounds.razor ?
    ??? Borders.razor ??
    ??? ... (more)

Legend: ? Complete | ?? Planned
