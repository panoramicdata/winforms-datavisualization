// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Platform-agnostic rendering engine interface.
/// Defines methods and properties that must be implemented by any chart rendering engine.
/// This interface enables rendering to different targets such as GDI+, SVG, Canvas, etc.
/// </summary>
public interface IRenderingEngine : IDisposable
{
    #region Drawing Methods

    /// <summary>
    /// Draws a line connecting two ChartPointF structures.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the line.</param>
    /// <param name="pt1">ChartPointF structure that represents the first point to connect.</param>
    /// <param name="pt2">ChartPointF structure that represents the second point to connect.</param>
    void DrawLine(ChartPen pen, ChartPointF pt1, ChartPointF pt2);

    /// <summary>
    /// Draws a line connecting the two points specified by coordinate pairs.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the line.</param>
    /// <param name="x1">x-coordinate of the first point.</param>
    /// <param name="y1">y-coordinate of the first point.</param>
    /// <param name="x2">x-coordinate of the second point.</param>
    /// <param name="y2">y-coordinate of the second point.</param>
    void DrawLine(ChartPen pen, float x1, float y1, float x2, float y2);

    /// <summary>
    /// Draws a series of line segments that connect an array of ChartPointF structures.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the line segments.</param>
    /// <param name="points">Array of ChartPointF structures that represent the points to connect.</param>
    void DrawLines(ChartPen pen, ChartPointF[] points);

    /// <summary>
    /// Draws a rectangle specified by a coordinate pair, a width, and a height.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the rectangle.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the rectangle to draw.</param>
    /// <param name="width">Width of the rectangle to draw.</param>
    /// <param name="height">Height of the rectangle to draw.</param>
    void DrawRectangle(ChartPen pen, float x, float y, float width, float height);

    /// <summary>
    /// Draws a rectangle specified by a ChartRectangleF structure.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the rectangle.</param>
    /// <param name="rect">ChartRectangleF structure that represents the rectangle to draw.</param>
    void DrawRectangle(ChartPen pen, ChartRectangleF rect);

    /// <summary>
    /// Draws an ellipse defined by a bounding rectangle specified by coordinates.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the ellipse.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="width">Width of the bounding rectangle.</param>
    /// <param name="height">Height of the bounding rectangle.</param>
    void DrawEllipse(ChartPen pen, float x, float y, float width, float height);

    /// <summary>
    /// Draws an ellipse defined by a bounding ChartRectangleF.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the ellipse.</param>
    /// <param name="rect">ChartRectangleF structure that defines the boundaries of the ellipse.</param>
    void DrawEllipse(ChartPen pen, ChartRectangleF rect);

    /// <summary>
    /// Draws a polygon defined by an array of ChartPointF structures.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the polygon.</param>
    /// <param name="points">Array of ChartPointF structures that represent the vertices of the polygon.</param>
    void DrawPolygon(ChartPen pen, ChartPointF[] points);

    /// <summary>
    /// Draws a ChartPath object.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the path.</param>
    /// <param name="path">ChartPath object to draw.</param>
    void DrawPath(ChartPen pen, ChartPath path);

    /// <summary>
    /// Draws a pie shape defined by an ellipse and two radial lines.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the pie shape.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="width">Width of the bounding rectangle.</param>
    /// <param name="height">Height of the bounding rectangle.</param>
    /// <param name="startAngle">Angle measured in degrees clockwise from the x-axis to the first side of the pie shape.</param>
    /// <param name="sweepAngle">Angle measured in degrees clockwise from startAngle to the second side of the pie shape.</param>
    void DrawPie(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle);

    /// <summary>
    /// Draws an arc representing a portion of an ellipse.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and style of the arc.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the rectangle that defines the ellipse.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the rectangle that defines the ellipse.</param>
    /// <param name="width">Width of the rectangle that defines the ellipse.</param>
    /// <param name="height">Height of the rectangle that defines the ellipse.</param>
    /// <param name="startAngle">Angle in degrees measured clockwise from the x-axis to the starting point of the arc.</param>
    /// <param name="sweepAngle">Angle in degrees measured clockwise from startAngle to ending point of the arc.</param>
    void DrawArc(ChartPen pen, float x, float y, float width, float height, float startAngle, float sweepAngle);

    /// <summary>
    /// Draws a cardinal spline through a specified array of ChartPointF structures.
    /// </summary>
    /// <param name="pen">Pen object that determines the color, width, and height of the curve.</param>
    /// <param name="points">Array of ChartPointF structures that define the spline.</param>
    /// <param name="offset">Offset from the first element to the starting point in the curve.</param>
    /// <param name="numberOfSegments">Number of segments after the starting point to include in the curve.</param>
    /// <param name="tension">Value greater than or equal to 0.0F that specifies the tension of the curve.</param>
    void DrawCurve(ChartPen pen, ChartPointF[] points, int offset, int numberOfSegments, float tension);

    /// <summary>
    /// Draws the specified text string in the specified rectangle.
    /// </summary>
    /// <param name="s">String to draw.</param>
    /// <param name="font">Font object that defines the text format of the string.</param>
    /// <param name="brush">Brush object that determines the color and texture of the drawn text.</param>
    /// <param name="layoutRectangle">ChartRectangleF structure that specifies the location of the drawn text.</param>
    /// <param name="format">ChartStringFormat object that specifies formatting properties.</param>
    void DrawString(string s, ChartFont font, ChartBrush brush, ChartRectangleF layoutRectangle, ChartStringFormat? format);

    /// <summary>
    /// Draws the specified text string at the specified location.
    /// </summary>
    /// <param name="s">String to draw.</param>
    /// <param name="font">Font object that defines the text format of the string.</param>
    /// <param name="brush">Brush object that determines the color and texture of the drawn text.</param>
    /// <param name="point">ChartPointF structure that specifies the upper-left corner of the drawn text.</param>
    /// <param name="format">ChartStringFormat object that specifies formatting properties.</param>
    void DrawString(string s, ChartFont font, ChartBrush brush, ChartPointF point, ChartStringFormat? format);

    #endregion

    #region Filling Methods

    /// <summary>
    /// Fills the interior of a rectangle specified by coordinates.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the rectangle to fill.</param>
    /// <param name="width">Width of the rectangle to fill.</param>
    /// <param name="height">Height of the rectangle to fill.</param>
    void FillRectangle(ChartBrush brush, float x, float y, float width, float height);

    /// <summary>
    /// Fills the interior of a rectangle specified by a ChartRectangleF structure.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="rect">ChartRectangleF structure that represents the rectangle to fill.</param>
    void FillRectangle(ChartBrush brush, ChartRectangleF rect);

    /// <summary>
    /// Fills the interior of an ellipse defined by a bounding rectangle.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="rect">ChartRectangleF structure that represents the bounding rectangle.</param>
    void FillEllipse(ChartBrush brush, ChartRectangleF rect);

    /// <summary>
    /// Fills the interior of an ellipse defined by a bounding rectangle.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="width">Width of the bounding rectangle.</param>
    /// <param name="height">Height of the bounding rectangle.</param>
    void FillEllipse(ChartBrush brush, float x, float y, float width, float height);

    /// <summary>
    /// Fills the interior of a polygon defined by an array of points.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="points">Array of ChartPointF structures that represent the vertices of the polygon to fill.</param>
    void FillPolygon(ChartBrush brush, ChartPointF[] points);

    /// <summary>
    /// Fills the interior of a ChartPath object.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="path">ChartPath object that represents the path to fill.</param>
    void FillPath(ChartBrush brush, ChartPath path);

    /// <summary>
    /// Fills the interior of a pie section.
    /// </summary>
    /// <param name="brush">Brush object that determines the characteristics of the fill.</param>
    /// <param name="x">x-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="y">y-coordinate of the upper-left corner of the bounding rectangle.</param>
    /// <param name="width">Width of the bounding rectangle.</param>
    /// <param name="height">Height of the bounding rectangle.</param>
    /// <param name="startAngle">Angle in degrees measured clockwise from the x-axis to the first side of the pie section.</param>
    /// <param name="sweepAngle">Angle in degrees measured clockwise from startAngle to the second side of the pie section.</param>
    void FillPie(ChartBrush brush, float x, float y, float width, float height, float startAngle, float sweepAngle);

    #endregion

    #region Measurement Methods

    /// <summary>
    /// Measures the specified string when drawn with the specified Font.
    /// </summary>
    /// <param name="text">String to measure.</param>
    /// <param name="font">Font object defines the text format of the string.</param>
    /// <param name="layoutArea">ChartSizeF structure that specifies the maximum layout area for the text.</param>
    /// <param name="stringFormat">ChartStringFormat object that represents formatting information.</param>
    /// <returns>ChartSizeF structure that represents the size of the string.</returns>
    ChartSizeF MeasureString(string text, ChartFont font, ChartSizeF layoutArea, ChartStringFormat? stringFormat);

    /// <summary>
    /// Measures the specified string when drawn with the specified Font.
    /// </summary>
    /// <param name="text">String to measure.</param>
    /// <param name="font">Font object defines the text format of the string.</param>
    /// <returns>ChartSizeF structure that represents the size of the string.</returns>
    ChartSizeF MeasureString(string text, ChartFont font);

    #endregion

    #region State Management

    /// <summary>
    /// Saves the current state of this rendering engine.
    /// </summary>
    /// <returns>An object that represents the saved state.</returns>
    object Save();

    /// <summary>
    /// Restores the state of this rendering engine to a previously saved state.
    /// </summary>
    /// <param name="state">Object that represents the state to restore.</param>
    void Restore(object state);

    /// <summary>
    /// Resets the clip region to an infinite region.
    /// </summary>
    void ResetClip();

    /// <summary>
    /// Sets the clipping region to the specified rectangle.
    /// </summary>
    /// <param name="rect">ChartRectangleF structure that represents the new clip region.</param>
    void SetClip(ChartRectangleF rect);

    /// <summary>
    /// Sets the clipping region to the specified path.
    /// </summary>
    /// <param name="path">ChartPath object to combine.</param>
    /// <param name="combineMode">Member of the ChartCombineMode enumeration that specifies the combining operation.</param>
    void SetClip(ChartPath path, ChartCombineMode combineMode);

    /// <summary>
    /// Prepends the specified translation to the transformation matrix.
    /// </summary>
    /// <param name="dx">x component of the translation.</param>
    /// <param name="dy">y component of the translation.</param>
    void TranslateTransform(float dx, float dy);

    /// <summary>
    /// Prepends the specified rotation to the transformation matrix.
    /// </summary>
    /// <param name="angle">Angle of rotation in degrees.</param>
    void RotateTransform(float angle);

    /// <summary>
    /// Prepends the specified scale to the transformation matrix.
    /// </summary>
    /// <param name="sx">Scale factor in the x direction.</param>
    /// <param name="sy">Scale factor in the y direction.</param>
    void ScaleTransform(float sx, float sy);

    #endregion

    #region Selection/Interactivity

    /// <summary>
    /// Begins a selection region for interactive features (e.g., SVG hyperlinks, tooltips).
    /// </summary>
    /// <param name="hRef">The location of the referenced object, expressed as a URI reference.</param>
    /// <param name="title">Title which could be used for tooltips.</param>
    void BeginSelection(string hRef, string title);

    /// <summary>
    /// Ends the current selection region.
    /// </summary>
    void EndSelection();

    #endregion

    #region Properties

    /// <summary>
    /// Gets or sets the world transformation matrix.
    /// </summary>
    ChartMatrix Transform { get; set; }

    /// <summary>
    /// Gets or sets the rendering quality.
    /// </summary>
    ChartSmoothingMode SmoothingMode { get; set; }

    /// <summary>
    /// Gets or sets the rendering mode for text.
    /// </summary>
    ChartTextRenderingHint TextRenderingHint { get; set; }

    /// <summary>
    /// Gets a value indicating whether the clipping region is empty.
    /// </summary>
    bool IsClipEmpty { get; }

    /// <summary>
    /// Gets the width of the rendering surface.
    /// </summary>
    float Width { get; }

    /// <summary>
    /// Gets the height of the rendering surface.
    /// </summary>
    float Height { get; }

    /// <summary>
    /// Gets the DPI (dots per inch) in the X direction.
    /// </summary>
    float DpiX { get; }

    /// <summary>
    /// Gets the DPI (dots per inch) in the Y direction.
    /// </summary>
    float DpiY { get; }

    #endregion
}
