# Copilot Instructions for WinForms DataVisualization Library

## Project Overview

This is the **System.Windows.Forms.DataVisualization** charting library being modernized to support multiple rendering targets (WinForms GDI+, SVG, Blazor WebAssembly).

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

- **Master Plan**: `MASTER_PLAN.md` - Contains full modernization roadmap
