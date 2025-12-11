// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// GDI+ implementation of the rendering engine.
/// Wraps a Graphics object to provide rendering through the IRenderingEngine interface.
/// </summary>
public class GdiRenderingEngine : RenderingEngineAdapter<PointF, SizeF, RectangleF, Color, Font, Pen, Brush, Matrix, GraphicsPath, StringFormat>
{
    private readonly Graphics _graphics;
    private readonly GdiPrimitiveConverter _converter;
    private readonly bool _ownsGraphics;

    /// <summary>
    /// Creates a new GdiRenderingEngine wrapping the specified Graphics object.
    /// </summary>
    /// <param name="graphics">The Graphics object to wrap.</param>
    /// <param name="ownsGraphics">If true, the Graphics object will be disposed when this engine is disposed.</param>
    public GdiRenderingEngine(Graphics graphics, bool ownsGraphics = false)
    {
        _graphics = graphics ?? throw new ArgumentNullException(nameof(graphics));
        _converter = new GdiPrimitiveConverter();
        _ownsGraphics = ownsGraphics;
    }

    /// <inheritdoc/>
    protected override IPrimitiveConverter<PointF, SizeF, RectangleF, Color, Font, Pen, Brush, Matrix, GraphicsPath, StringFormat> Converter => _converter;

    /// <summary>
    /// Gets the underlying Graphics object.
    /// </summary>
    public Graphics Graphics => _graphics;

    #region Drawing Implementation

    /// <inheritdoc/>
    protected override void DrawLineCore(Pen pen, PointF pt1, PointF pt2)
    {
        _graphics.DrawLine(pen, pt1, pt2);
    }

    /// <inheritdoc/>
    protected override void DrawLinesCore(Pen pen, PointF[] points)
    {
        if (points.Length >= 2)
        {
            _graphics.DrawLines(pen, points);
        }
    }

    /// <inheritdoc/>
    protected override void DrawRectangleCore(Pen pen, RectangleF rect)
    {
        _graphics.DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);
    }

    /// <inheritdoc/>
    protected override void DrawEllipseCore(Pen pen, RectangleF rect)
    {
        _graphics.DrawEllipse(pen, rect);
    }

    /// <inheritdoc/>
    protected override void DrawPolygonCore(Pen pen, PointF[] points)
    {
        if (points.Length >= 3)
        {
            _graphics.DrawPolygon(pen, points);
        }
    }

    /// <inheritdoc/>
    protected override void DrawPathCore(Pen pen, GraphicsPath path)
    {
        _graphics.DrawPath(pen, path);
    }

    /// <inheritdoc/>
    protected override void DrawPieCore(Pen pen, RectangleF rect, float startAngle, float sweepAngle)
    {
        _graphics.DrawPie(pen, rect, startAngle, sweepAngle);
    }

    /// <inheritdoc/>
    protected override void DrawArcCore(Pen pen, RectangleF rect, float startAngle, float sweepAngle)
    {
        _graphics.DrawArc(pen, rect, startAngle, sweepAngle);
    }

    /// <inheritdoc/>
    protected override void DrawCurveCore(Pen pen, PointF[] points, int offset, int numberOfSegments, float tension)
    {
        if (points.Length >= 2)
        {
            _graphics.DrawCurve(pen, points, offset, numberOfSegments, tension);
        }
    }

    /// <inheritdoc/>
    protected override void DrawStringCore(string s, Font font, Brush brush, RectangleF layoutRectangle, StringFormat? format)
    {
        _graphics.DrawString(s, font, brush, layoutRectangle, format);
    }

    /// <inheritdoc/>
    protected override void DrawStringCore(string s, Font font, Brush brush, PointF point, StringFormat? format)
    {
        _graphics.DrawString(s, font, brush, point, format);
    }

    #endregion

    #region Filling Implementation

    /// <inheritdoc/>
    protected override void FillRectangleCore(Brush brush, RectangleF rect)
    {
        _graphics.FillRectangle(brush, rect);
    }

    /// <inheritdoc/>
    protected override void FillEllipseCore(Brush brush, RectangleF rect)
    {
        _graphics.FillEllipse(brush, rect);
    }

    /// <inheritdoc/>
    protected override void FillPolygonCore(Brush brush, PointF[] points)
    {
        if (points.Length >= 3)
        {
            _graphics.FillPolygon(brush, points);
        }
    }

    /// <inheritdoc/>
    protected override void FillPathCore(Brush brush, GraphicsPath path)
    {
        _graphics.FillPath(brush, path);
    }

    /// <inheritdoc/>
    protected override void FillPieCore(Brush brush, RectangleF rect, float startAngle, float sweepAngle)
    {
        _graphics.FillPie(brush, rect, startAngle, sweepAngle);
    }

    #endregion

    #region Measurement Implementation

    /// <inheritdoc/>
    protected override SizeF MeasureStringCore(string text, Font font, SizeF layoutArea, StringFormat? stringFormat)
    {
        return _graphics.MeasureString(text, font, layoutArea, stringFormat);
    }

    /// <inheritdoc/>
    protected override SizeF MeasureStringCore(string text, Font font)
    {
        return _graphics.MeasureString(text, font);
    }

    #endregion

    #region State Management

    /// <inheritdoc/>
    public override object Save()
    {
        return _graphics.Save();
    }

    /// <inheritdoc/>
    public override void Restore(object state)
    {
        if (state is GraphicsState graphicsState)
        {
            _graphics.Restore(graphicsState);
        }
    }

    /// <inheritdoc/>
    public override void ResetClip()
    {
        _graphics.ResetClip();
    }

    /// <inheritdoc/>
    public override void SetClip(ChartRectangleF rect)
    {
        _graphics.SetClip(_converter.ToRectangle(rect));
    }

    /// <inheritdoc/>
    public override void SetClip(ChartPath path, ChartCombineMode combineMode)
    {
        var gdiPath = _converter.ToPath(path);
        var mode = combineMode switch
        {
            ChartCombineMode.Replace => CombineMode.Replace,
            ChartCombineMode.Intersect => CombineMode.Intersect,
            ChartCombineMode.Union => CombineMode.Union,
            ChartCombineMode.Xor => CombineMode.Xor,
            ChartCombineMode.Exclude => CombineMode.Exclude,
            ChartCombineMode.Complement => CombineMode.Complement,
            _ => CombineMode.Replace
        };
        _graphics.SetClip(gdiPath, mode);
    }

    /// <inheritdoc/>
    public override void TranslateTransform(float dx, float dy)
    {
        _graphics.TranslateTransform(dx, dy);
    }

    /// <inheritdoc/>
    public override void RotateTransform(float angle)
    {
        _graphics.RotateTransform(angle);
    }

    /// <inheritdoc/>
    public override void ScaleTransform(float sx, float sy)
    {
        _graphics.ScaleTransform(sx, sy);
    }

    /// <inheritdoc/>
    public override void BeginSelection(string hRef, string title)
    {
        // Selection is not directly supported in GDI+ rendering
        // This could be used for image maps or other interactive features
    }

    /// <inheritdoc/>
    public override void EndSelection()
    {
        // Selection is not directly supported in GDI+ rendering
    }

    #endregion

    #region Properties

    /// <inheritdoc/>
    public override ChartMatrix Transform
    {
        get => _converter.FromMatrix(_graphics.Transform);
        set => _graphics.Transform = _converter.ToMatrix(value);
    }

    /// <inheritdoc/>
    public override ChartSmoothingMode SmoothingMode
    {
        get => _graphics.SmoothingMode switch
        {
            System.Drawing.Drawing2D.SmoothingMode.None => ChartSmoothingMode.None,
            System.Drawing.Drawing2D.SmoothingMode.HighSpeed => ChartSmoothingMode.HighSpeed,
            System.Drawing.Drawing2D.SmoothingMode.HighQuality => ChartSmoothingMode.HighQuality,
            System.Drawing.Drawing2D.SmoothingMode.AntiAlias => ChartSmoothingMode.AntiAlias,
            _ => ChartSmoothingMode.Default
        };
        set => _graphics.SmoothingMode = value switch
        {
            ChartSmoothingMode.None => System.Drawing.Drawing2D.SmoothingMode.None,
            ChartSmoothingMode.HighSpeed => System.Drawing.Drawing2D.SmoothingMode.HighSpeed,
            ChartSmoothingMode.HighQuality => System.Drawing.Drawing2D.SmoothingMode.HighQuality,
            ChartSmoothingMode.AntiAlias => System.Drawing.Drawing2D.SmoothingMode.AntiAlias,
            _ => System.Drawing.Drawing2D.SmoothingMode.Default
        };
    }

    /// <inheritdoc/>
    public override ChartTextRenderingHint TextRenderingHint
    {
        get => _graphics.TextRenderingHint switch
        {
            System.Drawing.Text.TextRenderingHint.SystemDefault => ChartTextRenderingHint.SystemDefault,
            System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit => ChartTextRenderingHint.SingleBitPerPixelGridFit,
            System.Drawing.Text.TextRenderingHint.SingleBitPerPixel => ChartTextRenderingHint.SingleBitPerPixel,
            System.Drawing.Text.TextRenderingHint.AntiAliasGridFit => ChartTextRenderingHint.AntiAliasGridFit,
            System.Drawing.Text.TextRenderingHint.AntiAlias => ChartTextRenderingHint.AntiAlias,
            System.Drawing.Text.TextRenderingHint.ClearTypeGridFit => ChartTextRenderingHint.ClearTypeGridFit,
            _ => ChartTextRenderingHint.SystemDefault
        };
        set => _graphics.TextRenderingHint = value switch
        {
            ChartTextRenderingHint.SystemDefault => System.Drawing.Text.TextRenderingHint.SystemDefault,
            ChartTextRenderingHint.SingleBitPerPixelGridFit => System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit,
            ChartTextRenderingHint.SingleBitPerPixel => System.Drawing.Text.TextRenderingHint.SingleBitPerPixel,
            ChartTextRenderingHint.AntiAliasGridFit => System.Drawing.Text.TextRenderingHint.AntiAliasGridFit,
            ChartTextRenderingHint.AntiAlias => System.Drawing.Text.TextRenderingHint.AntiAlias,
            ChartTextRenderingHint.ClearTypeGridFit => System.Drawing.Text.TextRenderingHint.ClearTypeGridFit,
            _ => System.Drawing.Text.TextRenderingHint.SystemDefault
        };
    }

    /// <inheritdoc/>
    public override bool IsClipEmpty => _graphics.IsClipEmpty;

    /// <inheritdoc/>
    public override float Width => _graphics.VisibleClipBounds.Width;

    /// <inheritdoc/>
    public override float Height => _graphics.VisibleClipBounds.Height;

    /// <inheritdoc/>
    public override float DpiX => _graphics.DpiX;

    /// <inheritdoc/>
    public override float DpiY => _graphics.DpiY;

    #endregion

    #region IDisposable

    private bool _disposed;

    /// <inheritdoc/>
    public override void Dispose()
    {
        if (!_disposed)
        {
            if (_ownsGraphics)
            {
                _graphics.Dispose();
            }
            _disposed = true;
        }
    }

    #endregion
}
