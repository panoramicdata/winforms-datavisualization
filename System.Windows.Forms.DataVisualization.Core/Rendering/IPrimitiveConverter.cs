// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Interface for converting between platform-agnostic chart primitives and platform-specific types.
/// Each rendering platform (GDI+, SVG, Canvas, etc.) should implement this interface.
/// </summary>
/// <typeparam name="TPoint">Platform-specific point type (e.g., System.Drawing.PointF)</typeparam>
/// <typeparam name="TSize">Platform-specific size type (e.g., System.Drawing.SizeF)</typeparam>
/// <typeparam name="TRect">Platform-specific rectangle type (e.g., System.Drawing.RectangleF)</typeparam>
/// <typeparam name="TColor">Platform-specific color type (e.g., System.Drawing.Color)</typeparam>
/// <typeparam name="TFont">Platform-specific font type (e.g., System.Drawing.Font)</typeparam>
/// <typeparam name="TPen">Platform-specific pen type (e.g., System.Drawing.Pen)</typeparam>
/// <typeparam name="TBrush">Platform-specific brush type (e.g., System.Drawing.Brush)</typeparam>
/// <typeparam name="TMatrix">Platform-specific matrix type (e.g., System.Drawing.Drawing2D.Matrix)</typeparam>
/// <typeparam name="TPath">Platform-specific path type (e.g., System.Drawing.Drawing2D.GraphicsPath)</typeparam>
/// <typeparam name="TStringFormat">Platform-specific string format type (e.g., System.Drawing.StringFormat)</typeparam>
public interface IPrimitiveConverter<TPoint, TSize, TRect, TColor, TFont, TPen, TBrush, TMatrix, TPath, TStringFormat>
{
    #region To Platform-Specific

    /// <summary>
    /// Converts a ChartPointF to the platform-specific point type.
    /// </summary>
    TPoint ToPoint(ChartPointF point);

    /// <summary>
    /// Converts an array of ChartPointF to the platform-specific point array.
    /// </summary>
    TPoint[] ToPoints(ChartPointF[] points);

    /// <summary>
    /// Converts a ChartSizeF to the platform-specific size type.
    /// </summary>
    TSize ToSize(ChartSizeF size);

    /// <summary>
    /// Converts a ChartRectangleF to the platform-specific rectangle type.
    /// </summary>
    TRect ToRectangle(ChartRectangleF rect);

    /// <summary>
    /// Converts a ChartColor to the platform-specific color type.
    /// </summary>
    TColor ToColor(ChartColor color);

    /// <summary>
    /// Converts a ChartFont to the platform-specific font type.
    /// </summary>
    TFont ToFont(ChartFont font);

    /// <summary>
    /// Converts a ChartPen to the platform-specific pen type.
    /// </summary>
    TPen ToPen(ChartPen pen);

    /// <summary>
    /// Converts a ChartBrush to the platform-specific brush type.
    /// </summary>
    TBrush ToBrush(ChartBrush brush);

    /// <summary>
    /// Converts a ChartMatrix to the platform-specific matrix type.
    /// </summary>
    TMatrix ToMatrix(ChartMatrix matrix);

    /// <summary>
    /// Converts a ChartPath to the platform-specific path type.
    /// </summary>
    TPath ToPath(ChartPath path);

    /// <summary>
    /// Converts a ChartStringFormat to the platform-specific string format type.
    /// </summary>
    TStringFormat ToStringFormat(ChartStringFormat format);

    #endregion

    #region From Platform-Specific

    /// <summary>
    /// Converts a platform-specific point to ChartPointF.
    /// </summary>
    ChartPointF FromPoint(TPoint point);

    /// <summary>
    /// Converts an array of platform-specific points to ChartPointF array.
    /// </summary>
    ChartPointF[] FromPoints(TPoint[] points);

    /// <summary>
    /// Converts a platform-specific size to ChartSizeF.
    /// </summary>
    ChartSizeF FromSize(TSize size);

    /// <summary>
    /// Converts a platform-specific rectangle to ChartRectangleF.
    /// </summary>
    ChartRectangleF FromRectangle(TRect rect);

    /// <summary>
    /// Converts a platform-specific color to ChartColor.
    /// </summary>
    ChartColor FromColor(TColor color);

    /// <summary>
    /// Converts a platform-specific matrix to ChartMatrix.
    /// </summary>
    ChartMatrix FromMatrix(TMatrix matrix);

    #endregion
}

/// <summary>
/// Base class for rendering engine adapters that use a primitive converter.
/// </summary>
/// <typeparam name="TPoint">Platform-specific point type</typeparam>
/// <typeparam name="TSize">Platform-specific size type</typeparam>
/// <typeparam name="TRect">Platform-specific rectangle type</typeparam>
/// <typeparam name="TColor">Platform-specific color type</typeparam>
/// <typeparam name="TFont">Platform-specific font type</typeparam>
/// <typeparam name="TPen">Platform-specific pen type</typeparam>
/// <typeparam name="TBrush">Platform-specific brush type</typeparam>
/// <typeparam name="TMatrix">Platform-specific matrix type</typeparam>
/// <typeparam name="TPath">Platform-specific path type</typeparam>
/// <typeparam name="TStringFormat">Platform-specific string format type</typeparam>
public abstract class RenderingEngineAdapter<TPoint, TSize, TRect, TColor, TFont, TPen, TBrush, TMatrix, TPath, TStringFormat> : IRenderingEngine
{
    /// <summary>
    /// Gets the primitive converter for this rendering engine.
    /// </summary>
    protected abstract IPrimitiveConverter<TPoint, TSize, TRect, TColor, TFont, TPen, TBrush, TMatrix, TPath, TStringFormat> Converter { get; }

    #region Abstract Drawing Methods (to be implemented by derived classes)

    /// <summary>
    /// Draws a line using platform-specific types.
    /// </summary>
    protected abstract void DrawLineCore(TPen pen, TPoint pt1, TPoint pt2);

    /// <summary>
    /// Draws lines using platform-specific types.
    /// </summary>
    protected abstract void DrawLinesCore(TPen pen, TPoint[] points);

    /// <summary>
    /// Draws a rectangle using platform-specific types.
    /// </summary>
    protected abstract void DrawRectangleCore(TPen pen, TRect rect);

    /// <summary>
    /// Draws an ellipse using platform-specific types.
    /// </summary>
    protected abstract void DrawEllipseCore(TPen pen, TRect rect);

    /// <summary>
    /// Draws a polygon using platform-specific types.
    /// </summary>
    protected abstract void DrawPolygonCore(TPen pen, TPoint[] points);

    /// <summary>
    /// Draws a path using platform-specific types.
    /// </summary>
    protected abstract void DrawPathCore(TPen pen, TPath path);

    /// <summary>
    /// Draws a pie using platform-specific types.
    /// </summary>
    protected abstract void DrawPieCore(TPen pen, TRect rect, float startAngle, float sweepAngle);

    /// <summary>
    /// Draws an arc using platform-specific types.
    /// </summary>
    protected abstract void DrawArcCore(TPen pen, TRect rect, float startAngle, float sweepAngle);

    /// <summary>
    /// Draws a curve using platform-specific types.
    /// </summary>
    protected abstract void DrawCurveCore(TPen pen, TPoint[] points, int offset, int numberOfSegments, float tension);

    /// <summary>
    /// Draws a string using platform-specific types.
    /// </summary>
    protected abstract void DrawStringCore(string s, TFont font, TBrush brush, TRect layoutRectangle, TStringFormat? format);

    /// <summary>
    /// Draws a string at a point using platform-specific types.
    /// </summary>
    protected abstract void DrawStringCore(string s, TFont font, TBrush brush, TPoint point, TStringFormat? format);

    /// <summary>
    /// Fills a rectangle using platform-specific types.
    /// </summary>
    protected abstract void FillRectangleCore(TBrush brush, TRect rect);

    /// <summary>
    /// Fills an ellipse using platform-specific types.
    /// </summary>
    protected abstract void FillEllipseCore(TBrush brush, TRect rect);

    /// <summary>
    /// Fills a polygon using platform-specific types.
    /// </summary>
    protected abstract void FillPolygonCore(TBrush brush, TPoint[] points);

    /// <summary>
    /// Fills a path using platform-specific types.
    /// </summary>
    protected abstract void FillPathCore(TBrush brush, TPath path);

    /// <summary>
    /// Fills a pie using platform-specific types.
    /// </summary>
    protected abstract void FillPieCore(TBrush brush, TRect rect, float startAngle, float sweepAngle);

    /// <summary>
    /// Measures a string using platform-specific types.
    /// </summary>
    protected abstract TSize MeasureStringCore(string text, TFont font, TSize layoutArea, TStringFormat? stringFormat);

    /// <summary>
    /// Measures a string using platform-specific types.
    /// </summary>
    protected abstract TSize MeasureStringCore(string text, TFont font);

    #endregion

    #region IRenderingEngine Implementation

    public void DrawLine(ChartPen pen, ChartPointF pt1, ChartPointF pt2) =>
        DrawLineCore(Converter.ToPen(pen), Converter.ToPoint(pt1), Converter.ToPoint(pt2));

    public void DrawLine(ChartPen pen, float x1, float y1, float x2, float y2) =>
        DrawLine(pen, new ChartPointF(x1, y1), new ChartPointF(x2, y2));

    public void DrawLines(ChartPen pen, ChartPointF[] points) =>
        DrawLinesCore(Converter.ToPen(pen), Converter.ToPoints(points));

    public void DrawRectangle(ChartPen pen, float x, float y, float width, float height) =>
        DrawRectangle(pen, new ChartRectangleF(x, y, width, height));

    public void DrawRectangle(ChartPen pen, ChartRectangleF rect) =>
        DrawRectangleCore(Converter.ToPen(pen), Converter.ToRectangle(rect));

    public void DrawEllipse(ChartPen pen, float x, float y, float width, float height) =>
        DrawEllipse(pen, new ChartRectangleF(x, y, width, height));

    public void DrawEllipse(ChartPen pen, ChartRectangleF rect) =>
        DrawEllipseCore(Converter.ToPen(pen), Converter.ToRectangle(rect));

    public void DrawPolygon(ChartPen pen, ChartPointF[] points) =>
        DrawPolygonCore(Converter.ToPen(pen), Converter.ToPoints(points));

    public void DrawPath(ChartPen pen, ChartPath path) =>
        DrawPathCore(Converter.ToPen(pen), Converter.ToPath(path));

    public void DrawPie(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) =>
        DrawPieCore(Converter.ToPen(pen), Converter.ToRectangle(new ChartRectangleF(x, y, width, height)), startAngle, sweepAngle);

    public void DrawArc(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle) =>
        DrawArcCore(Converter.ToPen(pen), Converter.ToRectangle(new ChartRectangleF(x, y, width, height)), startAngle, sweepAngle);

    public void DrawCurve(ChartPen pen, ChartPointF[] points, int offset, int numberOfSegments, float tension) =>
        DrawCurveCore(Converter.ToPen(pen), Converter.ToPoints(points), offset, numberOfSegments, tension);

    public void DrawString(string s, ChartFont font, ChartBrush brush, ChartRectangleF layoutRectangle, ChartStringFormat? format) =>
        DrawStringCore(s, Converter.ToFont(font), Converter.ToBrush(brush), Converter.ToRectangle(layoutRectangle), 
            format != null ? Converter.ToStringFormat(format) : default);

    public void DrawString(string s, ChartFont font, ChartBrush brush, ChartPointF point, ChartStringFormat? format) =>
        DrawStringCore(s, Converter.ToFont(font), Converter.ToBrush(brush), Converter.ToPoint(point),
            format != null ? Converter.ToStringFormat(format) : default);

    public void FillRectangle(ChartBrush brush, float x, float y, float width, float height) =>
        FillRectangle(brush, new ChartRectangleF(x, y, width, height));

    public void FillRectangle(ChartBrush brush, ChartRectangleF rect) =>
        FillRectangleCore(Converter.ToBrush(brush), Converter.ToRectangle(rect));

    public void FillEllipse(ChartBrush brush, ChartRectangleF rect) =>
        FillEllipseCore(Converter.ToBrush(brush), Converter.ToRectangle(rect));

    public void FillEllipse(ChartBrush brush, float x, float y, float width, float height) =>
        FillEllipse(brush, new ChartRectangleF(x, y, width, height));

    public void FillPolygon(ChartBrush brush, ChartPointF[] points) =>
        FillPolygonCore(Converter.ToBrush(brush), Converter.ToPoints(points));

    public void FillPath(ChartBrush brush, ChartPath path) =>
        FillPathCore(Converter.ToBrush(brush), Converter.ToPath(path));

    public void FillPie(ChartBrush brush, float x, float y, float width, float height, float startAngle, float sweepAngle) =>
        FillPieCore(Converter.ToBrush(brush), Converter.ToRectangle(new ChartRectangleF(x, y, width, height)), startAngle, sweepAngle);

    public ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea, ChartStringFormat? stringFormat) =>
        Converter.FromSize(MeasureStringCore(text, Converter.ToFont(font), Converter.ToSize(layoutArea),
            stringFormat != null ? Converter.ToStringFormat(stringFormat) : default));

    public ChartSizeF MeasureString(string text, ChartFont font) =>
        Converter.FromSize(MeasureStringCore(text, Converter.ToFont(font)));

    #endregion

    #region Abstract State Methods

    public abstract object Save();
    public abstract void Restore(object state);
    public abstract void ResetClip();
    public abstract void SetClip(ChartRectangleF rect);
    public abstract void SetClip(ChartPath path, ChartCombineMode combineMode);
    public abstract void TranslateTransform(float dx, float dy);
    public abstract void RotateTransform(float angle);
    public abstract void ScaleTransform(float sx, float sy);
    public abstract void BeginSelection(string hRef, string title);
    public abstract void EndSelection();

    public abstract ChartMatrix Transform { get; set; }
    public abstract ChartSmoothingMode SmoothingMode { get; set; }
    public abstract ChartTextRenderingHint TextRenderingHint { get; set; }
    public abstract bool IsClipEmpty { get; }
    public abstract float Width { get; }
    public abstract float Height { get; }
    public abstract float DpiX { get; }
    public abstract float DpiY { get; }

    public abstract void Dispose();

    #endregion
}
