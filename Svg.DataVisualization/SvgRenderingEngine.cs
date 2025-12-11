// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// SVG implementation of the rendering engine.
/// Generates SVG markup from chart drawing operations.
/// </summary>
public class SvgRenderingEngine : IRenderingEngine
{
    private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

    private readonly StringBuilder _content;
    private readonly StringBuilder _definitions;
    private readonly Stack<string> _groupStack;
    private readonly Stack<SvgState> _stateStack;
    private int _definitionCounter;
    private SvgState _currentState;
    private bool _disposed;

    /// <summary>
    /// Gets the width of the SVG canvas.
    /// </summary>
    public float Width { get; }

    /// <summary>
    /// Gets the height of the SVG canvas.
    /// </summary>
    public float Height { get; }

    /// <summary>
    /// Gets or sets the DPI in the X direction. Default is 96.
    /// </summary>
    public float DpiX { get; set; } = 96f;

    /// <summary>
    /// Gets or sets the DPI in the Y direction. Default is 96.
    /// </summary>
    public float DpiY { get; set; } = 96f;

    /// <summary>
    /// Gets or sets the rendering quality.
    /// </summary>
    public ChartSmoothingMode SmoothingMode { get; set; } = ChartSmoothingMode.Default;

    /// <summary>
    /// Gets or sets the text rendering mode.
    /// </summary>
    public ChartTextRenderingHint TextRenderingHint { get; set; } = ChartTextRenderingHint.SystemDefault;

    /// <summary>
    /// Gets or sets the transformation matrix.
    /// </summary>
    public ChartMatrix Transform
    {
        get => _currentState.Transform;
        set => _currentState.Transform = value;
    }

    /// <summary>
    /// Gets a value indicating whether the clip region is empty.
    /// </summary>
    public bool IsClipEmpty => _currentState.ClipRect.IsEmpty;

    /// <summary>
    /// Creates a new SVG rendering engine with the specified dimensions.
    /// </summary>
    /// <param name="width">Width of the SVG canvas.</param>
    /// <param name="height">Height of the SVG canvas.</param>
    public SvgRenderingEngine(float width, float height)
    {
        Width = width;
        Height = height;
        _content = new StringBuilder();
        _definitions = new StringBuilder();
        _groupStack = new Stack<string>();
        _stateStack = new Stack<SvgState>();
        _currentState = new SvgState();
        _definitionCounter = 0;
    }

    #region Drawing Methods

    /// <inheritdoc/>
    public void DrawLine(ChartPen pen, ChartPointF pt1, ChartPointF pt2)
    {
        DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt2.Y);
    }

    /// <inheritdoc/>
    public void DrawLine(ChartPen pen, float x1, float y1, float x2, float y2)
    {
        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <line x1=\"{F(x1)}\" y1=\"{F(y1)}\" x2=\"{F(x2)}\" y2=\"{F(y2)}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawLines(ChartPen pen, ChartPointF[] points)
    {
        if (points.Length < 2)
            return;

        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();
        var pointsStr = string.Join(" ", points.Select(p => $"{F(p.X)},{F(p.Y)}"));

        _content.AppendLine($"  <polyline points=\"{pointsStr}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawRectangle(ChartPen pen, float x, float y, float width, float height)
    {
        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <rect x=\"{F(x)}\" y=\"{F(y)}\" width=\"{F(width)}\" height=\"{F(height)}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawRectangle(ChartPen pen, ChartRectangleF rect)
    {
        DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
    }

    /// <inheritdoc/>
    public void DrawEllipse(ChartPen pen, float x, float y, float width, float height)
    {
        var rect = new ChartRectangleF(x, y, width, height);
        DrawEllipse(pen, rect);
    }

    /// <inheritdoc/>
    public void DrawEllipse(ChartPen pen, ChartRectangleF rect)
    {
        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var ellipseAttrs = SvgPrimitiveConverter.ToSvgEllipseAttributes(rect);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <ellipse {ellipseAttrs} {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawPolygon(ChartPen pen, ChartPointF[] points)
    {
        if (points.Length < 3)
            return;

        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();
        var pointsStr = string.Join(" ", points.Select(p => $"{F(p.X)},{F(p.Y)}"));

        _content.AppendLine($"  <polygon points=\"{pointsStr}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawPath(ChartPen pen, ChartPath path)
    {
        var pathData = SvgPrimitiveConverter.ToSvgPathData(path);
        if (string.IsNullOrEmpty(pathData))
            return;

        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <path d=\"{pathData}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawPie(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle)
    {
        var rect = new ChartRectangleF(x, y, width, height);
        var pathData = SvgPrimitiveConverter.ToSvgArcPath(rect, startAngle, sweepAngle, includeCenterPoint: true);
        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <path d=\"{pathData}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawArc(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle)
    {
        var rect = new ChartRectangleF(x, y, width, height);
        var pathData = SvgPrimitiveConverter.ToSvgArcPath(rect, startAngle, sweepAngle, includeCenterPoint: false);
        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <path d=\"{pathData}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawCurve(ChartPen pen, ChartPointF[] points, int offset, int numberOfSegments, float tension)
    {
        if (points.Length < 2)
            return;

        // Convert cardinal spline to cubic Bezier path
        var pathData = ConvertCardinalSplineToPath(points, offset, numberOfSegments, tension);
        var strokeAttrs = SvgPrimitiveConverter.ToSvgStrokeAttributes(pen);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <path d=\"{pathData}\" {strokeAttrs} fill=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void DrawString(string s, ChartFont font, ChartBrush brush, ChartRectangleF layoutRectangle, ChartStringFormat? format)
    {
        DrawString(s, font, brush, new ChartPointF(layoutRectangle.X, layoutRectangle.Y), format);
    }

    /// <inheritdoc/>
    public void DrawString(string s, ChartFont font, ChartBrush brush, ChartPointF point, ChartStringFormat? format)
    {
        if (string.IsNullOrEmpty(s))
            return;

        var fontAttrs = SvgPrimitiveConverter.ToSvgFontAttributes(font);
        var fillAttrs = GetFillAttributes(brush);
        var alignAttrs = format != null ? SvgPrimitiveConverter.ToSvgTextAlignment(format) : "";
        var transform = GetTransformAttribute();

        // Escape XML special characters
        var escapedText = System.Security.SecurityElement.Escape(s);

        _content.AppendLine($"  <text x=\"{F(point.X)}\" y=\"{F(point.Y)}\" {fontAttrs} {fillAttrs} {alignAttrs}{transform}>{escapedText}</text>");
    }

    #endregion

    #region Filling Methods

    /// <inheritdoc/>
    public void FillRectangle(ChartBrush brush, float x, float y, float width, float height)
    {
        var fillAttrs = GetFillAttributes(brush);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <rect x=\"{F(x)}\" y=\"{F(y)}\" width=\"{F(width)}\" height=\"{F(height)}\" {fillAttrs} stroke=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void FillRectangle(ChartBrush brush, ChartRectangleF rect)
    {
        FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height);
    }

    /// <inheritdoc/>
    public void FillEllipse(ChartBrush brush, ChartRectangleF rect)
    {
        FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);
    }

    /// <inheritdoc/>
    public void FillEllipse(ChartBrush brush, float x, float y, float width, float height)
    {
        var rect = new ChartRectangleF(x, y, width, height);
        var ellipseAttrs = SvgPrimitiveConverter.ToSvgEllipseAttributes(rect);
        var fillAttrs = GetFillAttributes(brush);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <ellipse {ellipseAttrs} {fillAttrs} stroke=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void FillPolygon(ChartBrush brush, ChartPointF[] points)
    {
        if (points.Length < 3)
            return;

        var fillAttrs = GetFillAttributes(brush);
        var transform = GetTransformAttribute();
        var pointsStr = string.Join(" ", points.Select(p => $"{F(p.X)},{F(p.Y)}"));

        _content.AppendLine($"  <polygon points=\"{pointsStr}\" {fillAttrs} stroke=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void FillPath(ChartBrush brush, ChartPath path)
    {
        var pathData = SvgPrimitiveConverter.ToSvgPathData(path);
        if (string.IsNullOrEmpty(pathData))
            return;

        var fillAttrs = GetFillAttributes(brush);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <path d=\"{pathData}\" {fillAttrs} stroke=\"none\"{transform}/>");
    }

    /// <inheritdoc/>
    public void FillPie(ChartBrush brush, float x, float y, float width, float height, float startAngle, float sweepAngle)
    {
        var rect = new ChartRectangleF(x, y, width, height);
        var pathData = SvgPrimitiveConverter.ToSvgArcPath(rect, startAngle, sweepAngle, includeCenterPoint: true);
        var fillAttrs = GetFillAttributes(brush);
        var transform = GetTransformAttribute();

        _content.AppendLine($"  <path d=\"{pathData}\" {fillAttrs} stroke=\"none\"{transform}/>");
    }

    #endregion

    #region Measurement Methods

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea, ChartStringFormat? stringFormat)
    {
        // Approximate text measurement - SVG doesn't provide built-in text metrics
        // Use a simple estimation based on font size and character count
        var estimatedWidth = text.Length * font.Size * 0.6f;
        var estimatedHeight = font.Size * 1.2f;

        // Clamp to layout area if specified
        if (layoutArea.Width > 0)
            estimatedWidth = Math.Min(estimatedWidth, layoutArea.Width);
        if (layoutArea.Height > 0)
            estimatedHeight = Math.Min(estimatedHeight, layoutArea.Height);

        return new ChartSizeF(estimatedWidth, estimatedHeight);
    }

    /// <inheritdoc/>
    public ChartSizeF MeasureString(string text, ChartFont font)
    {
        return MeasureString(text, font, ChartSizeF.Empty, null);
    }

    #endregion

    #region State Management

    /// <inheritdoc/>
    public object Save()
    {
        var savedState = _currentState.Clone();
        _stateStack.Push(savedState);
        return _stateStack.Count;
    }

    /// <inheritdoc/>
    public void Restore(object state)
    {
        if (state is int stateIndex && _stateStack.Count > 0)
        {
            while (_stateStack.Count >= stateIndex && _stateStack.Count > 0)
            {
                _currentState = _stateStack.Pop();
            }
        }
    }

    /// <inheritdoc/>
    public void ResetClip()
    {
        _currentState.ClipRect = ChartRectangleF.Empty;
        _currentState.ClipPath = null;
    }

    /// <inheritdoc/>
    public void SetClip(ChartRectangleF rect)
    {
        _currentState.ClipRect = rect;
    }

    /// <inheritdoc/>
    public void SetClip(ChartPath path, ChartCombineMode combineMode)
    {
        _currentState.ClipPath = path;
    }

    /// <inheritdoc/>
    public void TranslateTransform(float dx, float dy)
    {
        _currentState.Transform = _currentState.Transform.Clone();
        _currentState.Transform.Translate(dx, dy);
    }

    /// <inheritdoc/>
    public void RotateTransform(float angle)
    {
        _currentState.Transform = _currentState.Transform.Clone();
        _currentState.Transform.Rotate(angle);
    }

    /// <inheritdoc/>
    public void ScaleTransform(float sx, float sy)
    {
        _currentState.Transform = _currentState.Transform.Clone();
        _currentState.Transform.Scale(sx, sy);
    }

    /// <inheritdoc/>
    public void BeginSelection(string hRef, string title)
    {
        var escapedHref = System.Security.SecurityElement.Escape(hRef ?? "");
        var escapedTitle = System.Security.SecurityElement.Escape(title ?? "");

        _content.AppendLine($"  <a href=\"{escapedHref}\">");
        if (!string.IsNullOrEmpty(escapedTitle))
        {
            _content.AppendLine($"    <title>{escapedTitle}</title>");
        }
        _groupStack.Push("a");
    }

    /// <inheritdoc/>
    public void EndSelection()
    {
        if (_groupStack.Count > 0 && _groupStack.Peek() == "a")
        {
            _groupStack.Pop();
            _content.AppendLine("  </a>");
        }
    }

    #endregion

    #region SVG Output

    /// <summary>
    /// Gets the complete SVG document as a string.
    /// </summary>
    /// <returns>The SVG document string.</returns>
    public string GetSvgContent()
    {
        var sb = new StringBuilder();

        // SVG header
        sb.AppendLine($"<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"{F(Width)}\" height=\"{F(Height)}\" viewBox=\"0 0 {F(Width)} {F(Height)}\">");

        // Definitions (gradients, patterns, etc.)
        if (_definitions.Length > 0)
        {
            sb.AppendLine("  <defs>");
            sb.Append(_definitions);
            sb.AppendLine("  </defs>");
        }

        // Content
        sb.Append(_content);

        // Close any remaining groups
        while (_groupStack.Count > 0)
        {
            var tag = _groupStack.Pop();
            sb.AppendLine($"  </{tag}>");
        }

        sb.AppendLine("</svg>");

        return sb.ToString();
    }

    /// <summary>
    /// Saves the SVG content to a file.
    /// </summary>
    /// <param name="path">The file path to save to.</param>
    public void SaveToFile(string path)
    {
        File.WriteAllText(path, GetSvgContent());
    }

    /// <summary>
    /// Gets the SVG content as a stream.
    /// </summary>
    /// <returns>A stream containing the SVG content.</returns>
    public Stream ToStream()
    {
        var bytes = Encoding.UTF8.GetBytes(GetSvgContent());
        return new MemoryStream(bytes);
    }

    #endregion

    #region Helper Methods

    private string F(float value) => value.ToString(Inv);

    private string GetTransformAttribute()
    {
        if (_currentState.Transform.IsIdentity)
            return "";

        var transformValue = SvgPrimitiveConverter.ToSvgTransform(_currentState.Transform);
        return $" transform=\"{transformValue}\"";
    }

    private string GetFillAttributes(ChartBrush brush)
    {
        if (brush is ChartLinearGradientBrush gradientBrush)
        {
            var id = $"gradient_{_definitionCounter++}";
            var gradientDef = SvgPrimitiveConverter.ToSvgGradientDefinition(gradientBrush, id);
            _definitions.AppendLine($"    {gradientDef}");
            return $"fill=\"url(#{id})\"";
        }
        else if (brush is ChartHatchBrush hatchBrush)
        {
            var id = $"pattern_{_definitionCounter++}";
            var patternDef = SvgPrimitiveConverter.ToSvgHatchDefinition(hatchBrush, id);
            _definitions.AppendLine($"    {patternDef}");
            return $"fill=\"url(#{id})\"";
        }
        else
        {
            return SvgPrimitiveConverter.ToSvgFillAttributes(brush);
        }
    }

    private static string ConvertCardinalSplineToPath(ChartPointF[] points, int offset, int numberOfSegments, float tension)
    {
        var sb = new StringBuilder();
        var endIndex = Math.Min(offset + numberOfSegments + 1, points.Length);

        if (endIndex - offset < 2)
            return string.Empty;

        sb.Append($"M {points[offset].X.ToString(Inv)},{points[offset].Y.ToString(Inv)} ");

        for (int i = offset; i < endIndex - 1; i++)
        {
            var p0 = i > 0 ? points[i - 1] : points[i];
            var p1 = points[i];
            var p2 = points[i + 1];
            var p3 = i + 2 < points.Length ? points[i + 2] : p2;

            // Calculate control points for cubic bezier
            var cp1x = p1.X + (p2.X - p0.X) * tension / 3f;
            var cp1y = p1.Y + (p2.Y - p0.Y) * tension / 3f;
            var cp2x = p2.X - (p3.X - p1.X) * tension / 3f;
            var cp2y = p2.Y - (p3.Y - p1.Y) * tension / 3f;

            sb.Append($"C {cp1x.ToString(Inv)},{cp1y.ToString(Inv)} {cp2x.ToString(Inv)},{cp2y.ToString(Inv)} {p2.X.ToString(Inv)},{p2.Y.ToString(Inv)} ");
        }

        return sb.ToString().TrimEnd();
    }

    #endregion

    #region IDisposable

    /// <inheritdoc/>
    public void Dispose()
    {
        if (!_disposed)
        {
            _content.Clear();
            _definitions.Clear();
            _groupStack.Clear();
            _stateStack.Clear();
            _disposed = true;
        }
    }

    #endregion

    /// <summary>
    /// Internal state for save/restore operations.
    /// </summary>
    private class SvgState
    {
        public ChartMatrix Transform { get; set; } = ChartMatrix.Identity;
        public ChartRectangleF ClipRect { get; set; } = ChartRectangleF.Empty;
        public ChartPath? ClipPath { get; set; }

        public SvgState Clone()
        {
            return new SvgState
            {
                Transform = Transform.Clone(),
                ClipRect = ClipRect,
                ClipPath = ClipPath
            };
        }
    }
}
