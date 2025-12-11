// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Represents a series of connected lines and curves.
/// Platform-agnostic replacement for System.Drawing.Drawing2D.GraphicsPath.
/// </summary>
public class ChartPath : IDisposable, ICloneable
{
    private bool _disposed;
    private readonly List<ChartPathSegment> _segments = new();
    private ChartPointF _currentPoint;

    /// <summary>
    /// Gets or sets the fill mode for this ChartPath.
    /// </summary>
    public ChartFillMode FillMode { get; set; } = ChartFillMode.Alternate;

    /// <summary>
    /// Gets the number of elements in the path.
    /// </summary>
    public int PointCount => _segments.Sum(s => s.Points.Length);

    /// <summary>
    /// Gets a value indicating whether this path has no segments.
    /// </summary>
    public bool IsEmpty => _segments.Count == 0;

    /// <summary>
    /// Initializes a new instance of the ChartPath class.
    /// </summary>
    public ChartPath()
    {
    }

    /// <summary>
    /// Initializes a new instance of the ChartPath class with the specified fill mode.
    /// </summary>
    public ChartPath(ChartFillMode fillMode)
    {
        FillMode = fillMode;
    }

    /// <summary>
    /// Gets all path points.
    /// </summary>
    public ChartPointF[] PathPoints => _segments.SelectMany(s => s.Points).ToArray();

    /// <summary>
    /// Gets all path segment types.
    /// </summary>
    public ChartPathPointType[] PathTypes
    {
        get
        {
            var types = new List<ChartPathPointType>();
            foreach (var segment in _segments)
            {
                for (int i = 0; i < segment.Points.Length; i++)
                {
                    var type = segment.Type;
                    if (i == 0 && segment.IsStartPoint)
                        type = ChartPathPointType.Start;
                    if (i == segment.Points.Length - 1 && segment.CloseFigure)
                        type |= ChartPathPointType.CloseSubpath;
                    types.Add(type);
                }
            }
            return types.ToArray();
        }
    }

    /// <summary>
    /// Starts a new figure without closing the current figure.
    /// </summary>
    public void StartFigure()
    {
        // Mark that next segment starts a new figure
        _currentPoint = ChartPointF.Empty;
    }

    /// <summary>
    /// Closes the current figure and starts a new figure.
    /// </summary>
    public void CloseFigure()
    {
        if (_segments.Count > 0)
        {
            _segments[^1].CloseFigure = true;
        }
    }

    /// <summary>
    /// Closes all open figures in this path and starts a new figure.
    /// </summary>
    public void CloseAllFigures()
    {
        foreach (var segment in _segments)
        {
            segment.CloseFigure = true;
        }
    }

    /// <summary>
    /// Appends a line segment to this ChartPath.
    /// </summary>
    public void AddLine(float x1, float y1, float x2, float y2)
    {
        AddLine(new ChartPointF(x1, y1), new ChartPointF(x2, y2));
    }

    /// <summary>
    /// Appends a line segment to this ChartPath.
    /// </summary>
    public void AddLine(ChartPointF pt1, ChartPointF pt2)
    {
        bool isStart = _currentPoint.IsEmpty || _currentPoint != pt1;
        _segments.Add(new ChartPathSegment(ChartPathPointType.Line, new[] { pt1, pt2 }, isStart));
        _currentPoint = pt2;
    }

    /// <summary>
    /// Appends a series of connected line segments to this ChartPath.
    /// </summary>
    public void AddLines(ChartPointF[] points)
    {
        if (points.Length < 2) return;
        
        bool isStart = _currentPoint.IsEmpty || _currentPoint != points[0];
        _segments.Add(new ChartPathSegment(ChartPathPointType.Line, points, isStart));
        _currentPoint = points[^1];
    }

    /// <summary>
    /// Appends a rectangle to this ChartPath.
    /// </summary>
    public void AddRectangle(ChartRectangleF rect)
    {
        var points = new[]
        {
            new ChartPointF(rect.X, rect.Y),
            new ChartPointF(rect.Right, rect.Y),
            new ChartPointF(rect.Right, rect.Bottom),
            new ChartPointF(rect.X, rect.Bottom)
        };
        _segments.Add(new ChartPathSegment(ChartPathPointType.Line, points, true) { CloseFigure = true });
        _currentPoint = ChartPointF.Empty;
    }

    /// <summary>
    /// Appends an ellipse to this ChartPath.
    /// </summary>
    public void AddEllipse(float x, float y, float width, float height)
    {
        AddEllipse(new ChartRectangleF(x, y, width, height));
    }

    /// <summary>
    /// Appends an ellipse to this ChartPath.
    /// </summary>
    public void AddEllipse(ChartRectangleF rect)
    {
        // Approximate ellipse with Bezier curves
        float cx = rect.X + rect.Width / 2;
        float cy = rect.Y + rect.Height / 2;
        float rx = rect.Width / 2;
        float ry = rect.Height / 2;
        
        // Magic number for bezier approximation of circle/ellipse
        float k = 0.5522848f;
        float kx = k * rx;
        float ky = k * ry;

        var points = new List<ChartPointF>
        {
            new(cx, cy - ry), // Start at top
        };

        // Top-right quarter
        points.AddRange(new[]
        {
            new ChartPointF(cx + kx, cy - ry),
            new ChartPointF(cx + rx, cy - ky),
            new ChartPointF(cx + rx, cy)
        });

        // Bottom-right quarter
        points.AddRange(new[]
        {
            new ChartPointF(cx + rx, cy + ky),
            new ChartPointF(cx + kx, cy + ry),
            new ChartPointF(cx, cy + ry)
        });

        // Bottom-left quarter
        points.AddRange(new[]
        {
            new ChartPointF(cx - kx, cy + ry),
            new ChartPointF(cx - rx, cy + ky),
            new ChartPointF(cx - rx, cy)
        });

        // Top-left quarter
        points.AddRange(new[]
        {
            new ChartPointF(cx - rx, cy - ky),
            new ChartPointF(cx - kx, cy - ry),
            new ChartPointF(cx, cy - ry)
        });

        _segments.Add(new ChartPathSegment(ChartPathPointType.Bezier, points.ToArray(), true) { CloseFigure = true });
        _currentPoint = ChartPointF.Empty;
    }

    /// <summary>
    /// Appends an arc to this ChartPath.
    /// </summary>
    public void AddArc(float x, float y, float width, float height, float startAngle, float sweepAngle)
    {
        AddArc(new ChartRectangleF(x, y, width, height), startAngle, sweepAngle);
    }

    /// <summary>
    /// Appends an arc to this ChartPath.
    /// </summary>
    public void AddArc(ChartRectangleF rect, float startAngle, float sweepAngle)
    {
        // Convert angles to radians
        float startRad = startAngle * (float)Math.PI / 180f;
        float sweepRad = sweepAngle * (float)Math.PI / 180f;

        float cx = rect.X + rect.Width / 2;
        float cy = rect.Y + rect.Height / 2;
        float rx = rect.Width / 2;
        float ry = rect.Height / 2;

        // Calculate start and end points
        var startPt = new ChartPointF(
            cx + rx * (float)Math.Cos(startRad),
            cy + ry * (float)Math.Sin(startRad)
        );
        
        // Store arc parameters for SVG generation
        _segments.Add(new ChartPathArcSegment(startPt, rx, ry, 0, sweepAngle > 180, sweepAngle > 0, 
            new ChartPointF(
                cx + rx * (float)Math.Cos(startRad + sweepRad),
                cy + ry * (float)Math.Sin(startRad + sweepRad)
            ), _currentPoint.IsEmpty));
        
        _currentPoint = _segments[^1].Points[^1];
    }

    /// <summary>
    /// Appends a pie shape to this ChartPath.
    /// </summary>
    public void AddPie(float x, float y, float width, float height, float startAngle, float sweepAngle)
    {
        float cx = x + width / 2;
        float cy = y + height / 2;
        
        // Move to center
        var centerPt = new ChartPointF(cx, cy);
        AddLine(centerPt, GetArcPoint(cx, cy, width / 2, height / 2, startAngle));
        AddArc(x, y, width, height, startAngle, sweepAngle);
        CloseFigure();
    }

    /// <summary>
    /// Appends a polygon to this ChartPath.
    /// </summary>
    public void AddPolygon(ChartPointF[] points)
    {
        if (points.Length < 3) return;
        _segments.Add(new ChartPathSegment(ChartPathPointType.Line, points, true) { CloseFigure = true });
        _currentPoint = ChartPointF.Empty;
    }

    /// <summary>
    /// Appends a cubic Bezier curve to this ChartPath.
    /// </summary>
    public void AddBezier(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
    {
        AddBezier(new ChartPointF(x1, y1), new ChartPointF(x2, y2), new ChartPointF(x3, y3), new ChartPointF(x4, y4));
    }

    /// <summary>
    /// Appends a cubic Bezier curve to this ChartPath.
    /// </summary>
    public void AddBezier(ChartPointF pt1, ChartPointF pt2, ChartPointF pt3, ChartPointF pt4)
    {
        bool isStart = _currentPoint.IsEmpty || _currentPoint != pt1;
        _segments.Add(new ChartPathSegment(ChartPathPointType.Bezier, new[] { pt1, pt2, pt3, pt4 }, isStart));
        _currentPoint = pt4;
    }

    /// <summary>
    /// Appends a cardinal spline curve to this ChartPath.
    /// </summary>
    public void AddCurve(ChartPointF[] points, float tension = 0.5f)
    {
        if (points.Length < 2) return;
        
        // Convert cardinal spline to Bezier curves
        bool isStart = _currentPoint.IsEmpty || _currentPoint != points[0];
        _segments.Add(new ChartPathSegment(ChartPathPointType.Bezier, points, isStart) { Tension = tension });
        _currentPoint = points[^1];
    }

    /// <summary>
    /// Appends a closed cardinal spline curve to this ChartPath.
    /// </summary>
    public void AddClosedCurve(ChartPointF[] points, float tension = 0.5f)
    {
        if (points.Length < 3) return;
        AddCurve(points, tension);
        CloseFigure();
    }

    /// <summary>
    /// Appends a text string to this ChartPath.
    /// </summary>
    public void AddString(string s, ChartFont font, ChartPointF origin, ChartStringFormat? format = null)
    {
        // Store string information - actual rendering depends on the platform
        _segments.Add(new ChartPathStringSegment(s, font, origin, format ?? new ChartStringFormat()));
        _currentPoint = ChartPointF.Empty;
    }

    /// <summary>
    /// Appends another path to this ChartPath.
    /// </summary>
    public void AddPath(ChartPath path, bool connect)
    {
        if (path.IsEmpty) return;
        
        foreach (var segment in path._segments)
        {
            var clone = segment.Clone();
            if (connect && _segments.Count > 0)
            {
                clone.IsStartPoint = false;
            }
            _segments.Add(clone);
        }
        
        if (path._segments.Count > 0)
        {
            _currentPoint = path._currentPoint;
        }
    }

    /// <summary>
    /// Clears all path segments.
    /// </summary>
    public void Reset()
    {
        _segments.Clear();
        _currentPoint = ChartPointF.Empty;
    }

    /// <summary>
    /// Applies a transform matrix to all points in the path.
    /// </summary>
    public void Transform(ChartMatrix matrix)
    {
        foreach (var segment in _segments)
        {
            for (int i = 0; i < segment.Points.Length; i++)
            {
                segment.Points[i] = matrix.TransformPoint(segment.Points[i]);
            }
        }
    }

    /// <summary>
    /// Gets the bounding rectangle of this path.
    /// </summary>
    public ChartRectangleF GetBounds()
    {
        if (IsEmpty) return ChartRectangleF.Empty;

        var allPoints = PathPoints;
        float minX = allPoints.Min(p => p.X);
        float minY = allPoints.Min(p => p.Y);
        float maxX = allPoints.Max(p => p.X);
        float maxY = allPoints.Max(p => p.Y);

        return new ChartRectangleF(minX, minY, maxX - minX, maxY - minY);
    }

    /// <summary>
    /// Determines whether this path contains the specified point.
    /// </summary>
    public bool IsVisible(ChartPointF pt)
    {
        // Simple bounding box check - full implementation would require point-in-polygon
        return GetBounds().Contains(pt);
    }

    /// <summary>
    /// Creates a copy of this ChartPath.
    /// </summary>
    public object Clone()
    {
        var clone = new ChartPath(FillMode);
        foreach (var segment in _segments)
        {
            clone._segments.Add(segment.Clone());
        }
        clone._currentPoint = _currentPoint;
        return clone;
    }

    /// <summary>
    /// Converts this path to SVG path data.
    /// </summary>
    public string ToSvgPathData()
    {
        var sb = new System.Text.StringBuilder();
        ChartPointF? figureStart = null;

        foreach (var segment in _segments)
        {
            if (segment is ChartPathArcSegment arc)
            {
                if (arc.IsStartPoint)
                {
                    sb.Append($"M {arc.Points[0].X:G9} {arc.Points[0].Y:G9} ");
                    figureStart = arc.Points[0];
                }
                sb.Append($"A {arc.RadiusX:G9} {arc.RadiusY:G9} {arc.XAxisRotation:G9} {(arc.LargeArc ? 1 : 0)} {(arc.Sweep ? 1 : 0)} {arc.Points[^1].X:G9} {arc.Points[^1].Y:G9} ");
            }
            else if (segment is ChartPathStringSegment)
            {
                // Text paths require special handling - typically rendered separately
                continue;
            }
            else
            {
                var points = segment.Points;
                if (points.Length == 0) continue;

                if (segment.IsStartPoint)
                {
                    sb.Append($"M {points[0].X:G9} {points[0].Y:G9} ");
                    figureStart = points[0];
                }

                switch (segment.Type)
                {
                    case ChartPathPointType.Line:
                        for (int i = segment.IsStartPoint ? 1 : 0; i < points.Length; i++)
                        {
                            sb.Append($"L {points[i].X:G9} {points[i].Y:G9} ");
                        }
                        break;
                    case ChartPathPointType.Bezier:
                        for (int i = segment.IsStartPoint ? 1 : 0; i < points.Length; i += 3)
                        {
                            if (i + 2 < points.Length)
                            {
                                sb.Append($"C {points[i].X:G9} {points[i].Y:G9} {points[i + 1].X:G9} {points[i + 1].Y:G9} {points[i + 2].X:G9} {points[i + 2].Y:G9} ");
                            }
                        }
                        break;
                }

                if (segment.CloseFigure)
                {
                    sb.Append("Z ");
                }
            }
        }

        return sb.ToString().Trim();
    }

    private static ChartPointF GetArcPoint(float cx, float cy, float rx, float ry, float angleDegrees)
    {
        float rad = angleDegrees * (float)Math.PI / 180f;
        return new ChartPointF(
            cx + rx * (float)Math.Cos(rad),
            cy + ry * (float)Math.Sin(rad)
        );
    }

    /// <summary>
    /// Releases all resources used by this ChartPath.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases the unmanaged resources used by the ChartPath and optionally releases the managed resources.
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _segments.Clear();
            }
            _disposed = true;
        }
    }
}

/// <summary>
/// Specifies the type of point in a path.
/// </summary>
[Flags]
public enum ChartPathPointType : byte
{
    /// <summary>
    /// Specifies a starting point of a subpath.
    /// </summary>
    Start = 0,

    /// <summary>
    /// Specifies a line segment.
    /// </summary>
    Line = 1,

    /// <summary>
    /// Specifies a cubic Bezier curve.
    /// </summary>
    Bezier = 3,

    /// <summary>
    /// Specifies that the corresponding point is the last point in a closed subpath.
    /// </summary>
    CloseSubpath = 128
}

/// <summary>
/// Represents a segment of a chart path.
/// </summary>
internal class ChartPathSegment
{
    public ChartPathPointType Type { get; }
    public ChartPointF[] Points { get; protected set; }
    public bool IsStartPoint { get; set; }
    public bool CloseFigure { get; set; }
    public float Tension { get; set; }

    public ChartPathSegment(ChartPathPointType type, ChartPointF[] points, bool isStartPoint)
    {
        Type = type;
        Points = (ChartPointF[])points.Clone();
        IsStartPoint = isStartPoint;
    }

    public virtual ChartPathSegment Clone() => new(Type, Points, IsStartPoint)
    {
        CloseFigure = CloseFigure,
        Tension = Tension
    };
}

/// <summary>
/// Represents an arc segment of a chart path.
/// </summary>
internal class ChartPathArcSegment : ChartPathSegment
{
    public float RadiusX { get; }
    public float RadiusY { get; }
    public float XAxisRotation { get; }
    public bool LargeArc { get; }
    public bool Sweep { get; }

    public ChartPathArcSegment(ChartPointF start, float rx, float ry, float xAxisRotation, bool largeArc, bool sweep, ChartPointF end, bool isStartPoint)
        : base(ChartPathPointType.Line, new[] { start, end }, isStartPoint)
    {
        RadiusX = rx;
        RadiusY = ry;
        XAxisRotation = xAxisRotation;
        LargeArc = largeArc;
        Sweep = sweep;
    }

    public override ChartPathSegment Clone() => new ChartPathArcSegment(Points[0], RadiusX, RadiusY, XAxisRotation, LargeArc, Sweep, Points[1], IsStartPoint)
    {
        CloseFigure = CloseFigure
    };
}

/// <summary>
/// Represents a text string segment of a chart path.
/// </summary>
internal class ChartPathStringSegment : ChartPathSegment
{
    public string Text { get; }
    public ChartFont Font { get; }
    public ChartStringFormat Format { get; }

    public ChartPathStringSegment(string text, ChartFont font, ChartPointF origin, ChartStringFormat format)
        : base(ChartPathPointType.Start, new[] { origin }, true)
    {
        Text = text;
        Font = font;
        Format = format;
    }

    public override ChartPathSegment Clone() => new ChartPathStringSegment(Text, Font, Points[0], Format)
    {
        CloseFigure = CloseFigure
    };
}
