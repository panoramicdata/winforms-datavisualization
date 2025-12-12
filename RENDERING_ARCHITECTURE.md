# Chart Rendering Architecture - Migration Plan

**Phase 4.5 of the Master Plan**

> This document provides detailed architecture for unifying the chart rendering between WinForms and SVG/Blazor.
> See `MASTER_PLAN.md` Phase 4.5 and `PHASE4_PLAN.md` for status tracking.

## Status Summary

| Sub-Phase | Description | Status |
|-----------|-------------|--------|
| **4.5.1** | Core Model Interfaces | ? Complete |
| **4.5.2** | Layout Engine | ? Complete |
| **4.5.3** | Chart Renderer | ?? Not Started |
| **4.5.4** | WinForms Adapter | ?? Not Started |
| **4.5.5** | SvgChart Integration | ?? Not Started |

### Completed Work
- `System.Windows.Forms.DataVisualization.Core/Models/IChartModel.cs`
- `System.Windows.Forms.DataVisualization.Core/Models/ISeriesModel.cs`
- `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayout.cs` - Layout result classes
- `System.Windows.Forms.DataVisualization.Core/Layout/AxisLayoutCalculator.cs` - Axis layout calculations
- `System.Windows.Forms.DataVisualization.Core/Layout/ChartLayoutEngine.cs` - Main layout engine
- `System.Windows.Forms.DataVisualization.Core.Tests/` - Unit tests (15 tests, all passing)

---

## Current State Analysis

### The Problem

Currently there are **TWO completely separate rendering implementations**:

1. **WinForms (`System.Windows.Forms.DataVisualization`)** - 15,000+ lines of code
2. **SVG (`Svg.DataVisualization`)** - ~600 lines in `SvgChart.cs`

They **cannot produce identical output** because they have different:
- Layout algorithms
- Axis calculations
- Data point positioning
- Legend rendering
- Grid line spacing
- Font/text handling

### WinForms Rendering Pipeline

```
Chart.OnPaint()
    ??? ChartPicture.Paint(Graphics)
            ??? Resize(ChartGraphics)           // Layout calculation
            ?   ??? Calculate title positions
            ?   ??? Calculate legend positions
            ?   ??? Calculate chart area positions
            ?   ??? For each ChartArea:
            ?       ??? ChartArea.Resize()      // Axis layout
            ?           ??? Calculate axis label sizes
            ?           ??? Calculate tick marks
            ?           ??? Calculate plot area position
            ?           ??? Calculate inner plot position
            ?
            ??? For each ChartArea:
                    ??? ChartArea.Paint(ChartGraphics)
                            ??? PaintAreaBack()     // Background
                            ??? Axis.PaintGrids()   // Grid lines
                            ??? Axis.PaintStrips()  // Strip lines
                            ??? IChartType.Paint()  // Series data
                            ?   ??? e.g., PointChart.Paint()
                            ?       ??? ProcessChartType()
                            ?           ??? For each DataPoint:
                            ?               ??? Calculate position
                            ?               ??? DrawPointMarker()
                            ?               ??? DrawLabels()
                            ??? Axis.Paint()        // Axis lines & labels
```

### Key Files in WinForms Rendering

| File | Lines | Responsibility |
|------|-------|----------------|
| `Chart.cs` | ~3,000 | Control, data binding |
| `ChartPicture.cs` | ~2,500 | Layout coordination, background |
| `ChartArea.cs` | ~4,500 | Area layout, axes coordination |
| `ChartGraphics.cs` | ~2,500 | Drawing wrapper, relative coordinates |
| `ChartRenderingEngine.cs` | ~500 | GDI+ rendering abstraction |
| `Axis.cs` | ~3,000 | Axis layout, labels, ticks |
| `PointChart.cs` | ~1,500 | Point/marker rendering |
| `LineChart.cs` | ~500 | Line rendering |
| `BarChart.cs` | ~2,000 | Bar/column rendering |

### Current SVG Implementation

```
SvgChart.RenderToSvg()
    ??? Render(SvgRenderingEngine)
            ??? Calculate layout (simplified)
            ??? Draw background
            ??? Draw title
            ??? Draw axes (simplified)
            ??? Draw series (simplified)
            ?   ??? Switch on ChartType:
            ?       ??? DrawLineSeries()
            ?       ??? DrawSplineSeries()
            ?       ??? DrawAreaSeries()
            ?       ??? DrawColumnSeries()
            ?       ??? DrawPieSeries()
            ??? Draw legend (simplified)
```

---

## Target Architecture

### Goal

**Single layout engine in Core, multiple renderers**

```
???????????????????????????????????????????????????????????????????????
?                    Core Project (Platform-Agnostic)                  ?
?  ?????????????????????????????????????????????????????????????????  ?
?  ?                      Chart Model                               ?  ?
?  ?  IChartModel, ISeriesModel, IDataPointModel, IAxisModel       ?  ?
?  ?????????????????????????????????????????????????????????????????  ?
?                              ?                                       ?
?                              ?                                       ?
?  ?????????????????????????????????????????????????????????????????  ?
?  ?                   Layout Engine                                ?  ?
?  ?  - ChartLayoutEngine (calculates all positions)               ?  ?
?  ?  - AxisLayoutCalculator                                        ?  ?
?  ?  - LegendLayoutCalculator                                      ?  ?
?  ?  - TitleLayoutCalculator                                       ?  ?
?  ?  - DataPointPositionCalculator                                 ?  ?
?  ?????????????????????????????????????????????????????????????????  ?
?                              ?                                       ?
?                              ?                                       ?
?  ?????????????????????????????????????????????????????????????????  ?
?  ?                   Chart Renderer                               ?  ?
?  ?  - ChartRenderer (uses IRenderingEngine)                       ?  ?
?  ?  - AxisRenderer                                                ?  ?
?  ?  - SeriesRenderer (Line, Bar, Pie, etc.)                      ?  ?
?  ?  - LegendRenderer                                              ?  ?
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
? Engine          ?   ? Engine          ?   ? CanvasEngine    ?
? (WinForms)      ?   ? (Blazor)        ?   ? SkiaEngine      ?
???????????????????   ???????????????????   ???????????????????
```

---

## Migration Strategy

### Phase 1: Create Core Chart Models (Week 1-2)

Create platform-agnostic interfaces and models in Core:

```csharp
// Core/Models/IChartModel.cs
public interface IChartModel
{
    float Width { get; }
    float Height { get; }
    ChartColor BackColor { get; }
    string Title { get; }
    IReadOnlyList<IChartAreaModel> ChartAreas { get; }
    IReadOnlyList<ISeriesModel> Series { get; }
    IReadOnlyList<ILegendModel> Legends { get; }
}

public interface IChartAreaModel
{
    string Name { get; }
    ChartRectangleF Position { get; }
    ChartRectangleF InnerPlotPosition { get; }
    IAxisModel AxisX { get; }
    IAxisModel AxisY { get; }
    IAxisModel AxisX2 { get; }
    IAxisModel AxisY2 { get; }
}

public interface IAxisModel
{
    double Minimum { get; }
    double Maximum { get; }
    double Interval { get; }
    string Title { get; }
    bool Enabled { get; }
    IReadOnlyList<string> Labels { get; }
}

public interface ISeriesModel
{
    string Name { get; }
    string ChartType { get; }
    string ChartArea { get; }
    ChartColor Color { get; }
    IReadOnlyList<IDataPointModel> Points { get; }
}

public interface IDataPointModel
{
    double XValue { get; }
    double[] YValues { get; }
    string Label { get; }
    ChartColor Color { get; }
}
```

### Phase 2: Create Layout Engine (Week 2-4)

Extract layout logic from WinForms into Core:

```csharp
// Core/Layout/ChartLayoutEngine.cs
public class ChartLayoutEngine
{
    public ChartLayout CalculateLayout(IChartModel chart, ChartSizeF size)
    {
        var layout = new ChartLayout(size);
        
        // Calculate title position
        layout.TitleBounds = CalculateTitleBounds(chart, layout);
        
        // Calculate legend position
        layout.LegendBounds = CalculateLegendBounds(chart, layout);
        
        // Calculate chart areas
        foreach (var area in chart.ChartAreas)
        {
            var areaLayout = CalculateChartAreaLayout(area, layout);
            layout.ChartAreaLayouts.Add(areaLayout);
        }
        
        return layout;
    }
    
    private ChartAreaLayout CalculateChartAreaLayout(IChartAreaModel area, ChartLayout parent)
    {
        var layout = new ChartAreaLayout();
        
        // Calculate axis layouts
        layout.AxisXLayout = _axisLayoutCalculator.Calculate(area.AxisX, ...);
        layout.AxisYLayout = _axisLayoutCalculator.Calculate(area.AxisY, ...);
        
        // Calculate plot area (after axis sizes are known)
        layout.PlotAreaBounds = CalculatePlotArea(layout);
        
        // Calculate data point positions
        foreach (var series in parent.Chart.Series.Where(s => s.ChartArea == area.Name))
        {
            var seriesLayout = CalculateSeriesLayout(series, layout);
            layout.SeriesLayouts.Add(seriesLayout);
        }
        
        return layout;
    }
}

public class ChartLayout
{
    public ChartRectangleF TitleBounds { get; set; }
    public ChartRectangleF LegendBounds { get; set; }
    public List<ChartAreaLayout> ChartAreaLayouts { get; } = new();
}

public class ChartAreaLayout
{
    public ChartRectangleF Bounds { get; set; }
    public ChartRectangleF PlotAreaBounds { get; set; }
    public AxisLayout AxisXLayout { get; set; }
    public AxisLayout AxisYLayout { get; set; }
    public List<SeriesLayout> SeriesLayouts { get; } = new();
}

public class SeriesLayout
{
    public ISeriesModel Series { get; set; }
    public List<DataPointLayout> PointLayouts { get; } = new();
}

public class DataPointLayout
{
    public IDataPointModel Point { get; set; }
    public ChartPointF Position { get; set; }  // Calculated screen position
    public ChartSizeF MarkerSize { get; set; }
}
```

### Phase 3: Create Chart Renderer (Week 4-5)

Create renderer that uses IRenderingEngine:

```csharp
// Core/Rendering/ChartRenderer.cs
public class ChartRenderer
{
    private readonly ChartLayoutEngine _layoutEngine;
    
    public void Render(IChartModel chart, IRenderingEngine engine)
    {
        // Calculate layout
        var layout = _layoutEngine.CalculateLayout(chart, new ChartSizeF(engine.Width, engine.Height));
        
        // Draw background
        using var backBrush = new ChartSolidBrush(chart.BackColor);
        engine.FillRectangle(backBrush, 0, 0, engine.Width, engine.Height);
        
        // Draw title
        if (!string.IsNullOrEmpty(chart.Title))
        {
            DrawTitle(engine, chart, layout);
        }
        
        // Draw chart areas
        foreach (var areaLayout in layout.ChartAreaLayouts)
        {
            DrawChartArea(engine, areaLayout);
        }
        
        // Draw legend
        DrawLegend(engine, chart, layout);
    }
    
    private void DrawChartArea(IRenderingEngine engine, ChartAreaLayout layout)
    {
        // Draw background
        DrawChartAreaBackground(engine, layout);
        
        // Draw grid lines
        DrawGridLines(engine, layout);
        
        // Draw axes
        DrawAxis(engine, layout.AxisXLayout);
        DrawAxis(engine, layout.AxisYLayout);
        
        // Draw series
        foreach (var seriesLayout in layout.SeriesLayouts)
        {
            var renderer = GetSeriesRenderer(seriesLayout.Series.ChartType);
            renderer.Render(engine, seriesLayout);
        }
    }
}
```

### Phase 4: Create WinForms Adapter (Week 5-6)

Create adapter to use Core renderer with WinForms Chart:

```csharp
// WinForms/ChartCoreAdapter.cs
public class ChartCoreAdapter : IChartModel
{
    private readonly Chart _chart;
    
    public ChartCoreAdapter(Chart chart) => _chart = chart;
    
    public float Width => _chart.Width;
    public float Height => _chart.Height;
    public ChartColor BackColor => ChartColor.FromArgb(_chart.BackColor.ToArgb());
    // ... map all properties
}

// Usage in Chart control:
public class Chart : Control
{
    private readonly ChartRenderer _coreRenderer = new();
    
    protected override void OnPaint(PaintEventArgs e)
    {
        using var engine = new GdiRenderingEngine(e.Graphics);
        var model = new ChartCoreAdapter(this);
        _coreRenderer.Render(model, engine);
    }
}
```

### Phase 5: Update SvgChart to Use Core (Week 6)

```csharp
// Svg.DataVisualization/SvgChart.cs
public class SvgChart : IChartModel
{
    private readonly ChartRenderer _renderer = new();
    
    public string RenderToSvg()
    {
        using var engine = new SvgRenderingEngine(Width, Height);
        _renderer.Render(this, engine);
        return engine.GetSvgContent();
    }
}
```

---

## Files to Create/Modify

### New Files in Core

| File | Purpose |
|------|---------|
| `Models/IChartModel.cs` | Chart model interface |
| `Models/IChartAreaModel.cs` | Chart area model interface |
| `Models/IAxisModel.cs` | Axis model interface |
| `Models/ISeriesModel.cs` | Series model interface |
| `Models/IDataPointModel.cs` | Data point model interface |
| `Layout/ChartLayoutEngine.cs` | Main layout calculator |
| `Layout/AxisLayoutCalculator.cs` | Axis layout calculator |
| `Layout/LegendLayoutCalculator.cs` | Legend layout calculator |
| `Layout/ChartLayout.cs` | Layout result classes |
| `Rendering/ChartRenderer.cs` | Main chart renderer |
| `Rendering/AxisRenderer.cs` | Axis rendering |
| `Rendering/LegendRenderer.cs` | Legend rendering |
| `Rendering/SeriesRenderers/LineSeriesRenderer.cs` | Line chart rendering |
| `Rendering/SeriesRenderers/BarSeriesRenderer.cs` | Bar chart rendering |
| `Rendering/SeriesRenderers/PieSeriesRenderer.cs` | Pie chart rendering |

### Modified Files

| File | Changes |
|------|---------|
| `Svg.DataVisualization/SvgChart.cs` | Use Core ChartRenderer |
| `WinForms/Chart.cs` | Option to use Core renderer |

---

## Timeline

| Week | Phase | Deliverables |
|------|-------|--------------|
| 1-2 | Phase 1 | Core model interfaces |
| 2-4 | Phase 2 | Layout engine with tests |
| 4-5 | Phase 3 | Chart renderer |
| 5-6 | Phase 4 | WinForms adapter |
| 6 | Phase 5 | SvgChart integration |
| 7 | Testing | Verify identical output |

---

## Success Criteria

1. **Identical Output**: Given the same chart configuration, WinForms and SVG render identically
2. **No Breaking Changes**: Existing WinForms API continues to work
3. **Test Coverage**: Layout calculations have unit tests
4. **Performance**: No significant performance regression

---

## Risks & Mitigations

| Risk | Mitigation |
|------|------------|
| Layout complexity | Start with simple charts (Line, Bar), add complexity incrementally |
| Performance regression | Profile and optimize critical paths |
| API breaking changes | Use adapter pattern to maintain compatibility |
| 3D charts | Defer 3D support to later phase |

---

## Next Steps

1. ? Complete architecture analysis (this document)
2. ? Create Core model interfaces (Phase 4.5.1)
   - `IChartModel`, `IChartAreaModel`, `IAxisModel`
   - `ISeriesModel`, `IDataPointModel`
   - `ChartMarkerStyle`, `ChartAxisType`, `ChartLegendPosition` enums
3. ? Create layout engine (Phase 4.5.2)
   - `ChartLayout.cs` - Result classes (ChartLayout, ChartAreaLayout, AxisLayout, SeriesLayout, DataPointLayout, etc.)
   - `AxisLayoutCalculator.cs` - Nice interval calculation, tick positioning, label generation
   - `ChartLayoutEngine.cs` - Main orchestrator for title, legend, chart areas, axes, series
   - Unit tests (15 tests passing)
4. ?? Create ChartRenderer with Line support (Phase 4.5.3)
5. ?? Create WinForms adapter (Phase 4.5.4)
6. ?? Update SvgChart to use Core renderer (Phase 4.5.5)
7. ?? Expand to other chart types
8. ?? Test for identical output between WinForms and SVG

---

## Related Documents

- **`MASTER_PLAN.md`** - Overall modernization plan (Phase 4.5 section)
- **`PHASE4_PLAN.md`** - Blazor samples and Phase 4.5 tracking
- **`.github/copilot-instructions.md`** - Development guidelines
