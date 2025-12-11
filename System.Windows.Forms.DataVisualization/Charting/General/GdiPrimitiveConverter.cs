// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting.Rendering;
using PlatformDashStyle = System.Drawing.Drawing2D.DashStyle;
using CoreDashStyle = System.Windows.Forms.DataVisualization.Charting.Rendering.ChartDashStyle;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Converts between platform-agnostic chart primitives and GDI+ types.
/// </summary>
public class GdiPrimitiveConverter : IPrimitiveConverter<PointF, SizeF, RectangleF, Color, Font, Pen, Brush, Matrix, GraphicsPath, StringFormat>
{
    /// <summary>
    /// Default font family to use when converting fonts.
    /// </summary>
    private const string DefaultFontFamily = "Microsoft Sans Serif";

    #region To Platform-Specific

    /// <inheritdoc/>
    public PointF ToPoint(ChartPointF point) => new(point.X, point.Y);

    /// <inheritdoc/>
    public PointF[] ToPoints(ChartPointF[] points)
    {
        if (points == null) return [];
        
        var result = new PointF[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            result[i] = ToPoint(points[i]);
        }
        return result;
    }

    /// <inheritdoc/>
    public SizeF ToSize(ChartSizeF size) => new(size.Width, size.Height);

    /// <inheritdoc/>
    public RectangleF ToRectangle(ChartRectangleF rect) => new(rect.X, rect.Y, rect.Width, rect.Height);

    /// <inheritdoc/>
    public Color ToColor(ChartColor color) => Color.FromArgb(color.A, color.R, color.G, color.B);

    /// <inheritdoc/>
    public Font ToFont(ChartFont font)
    {
        var style = FontStyle.Regular;
        if (font.Bold) style |= FontStyle.Bold;
        if (font.Italic) style |= FontStyle.Italic;
        if (font.Underline) style |= FontStyle.Underline;
        if (font.Strikeout) style |= FontStyle.Strikeout;

        var unit = font.Unit switch
        {
            ChartGraphicsUnit.Pixel => GraphicsUnit.Pixel,
            ChartGraphicsUnit.Point => GraphicsUnit.Point,
            ChartGraphicsUnit.Inch => GraphicsUnit.Inch,
            ChartGraphicsUnit.Document => GraphicsUnit.Document,
            ChartGraphicsUnit.Millimeter => GraphicsUnit.Millimeter,
            _ => GraphicsUnit.Point
        };

        return new Font(font.FontFamily ?? DefaultFontFamily, font.Size, style, unit);
    }

    /// <inheritdoc/>
    public Pen ToPen(ChartPen pen)
    {
        var gdiPen = new Pen(ToColor(pen.Color), pen.Width);
        
        gdiPen.DashStyle = pen.DashStyle switch
        {
            CoreDashStyle.Solid => PlatformDashStyle.Solid,
            CoreDashStyle.Dash => PlatformDashStyle.Dash,
            CoreDashStyle.Dot => PlatformDashStyle.Dot,
            CoreDashStyle.DashDot => PlatformDashStyle.DashDot,
            CoreDashStyle.DashDotDot => PlatformDashStyle.DashDotDot,
            _ => PlatformDashStyle.Solid
        };

        gdiPen.StartCap = ToLineCap(pen.StartCap);
        gdiPen.EndCap = ToLineCap(pen.EndCap);
        gdiPen.LineJoin = ToLineJoin(pen.LineJoin);

        return gdiPen;
    }

    /// <inheritdoc/>
    public Brush ToBrush(ChartBrush brush)
    {
        return brush switch
        {
            ChartSolidBrush solidBrush => new SolidBrush(ToColor(solidBrush.Color)),
            ChartLinearGradientBrush gradientBrush => CreateLinearGradientBrush(gradientBrush),
            ChartHatchBrush hatchBrush => CreateHatchBrush(hatchBrush),
            _ => new SolidBrush(Color.Black)
        };
    }

    /// <inheritdoc/>
    public Matrix ToMatrix(ChartMatrix matrix)
    {
        var elements = matrix.Elements;
        return new Matrix(
            elements[0], elements[1],
            elements[2], elements[3],
            elements[4], elements[5]);
    }

    /// <inheritdoc/>
    public GraphicsPath ToPath(ChartPath path)
    {
        var gdiPath = new GraphicsPath();
        gdiPath.FillMode = path.FillMode == ChartFillMode.Alternate ? FillMode.Alternate : FillMode.Winding;

        // Get path data
        var points = path.PathPoints;
        var types = path.PathTypes;

        if (points.Length == 0)
            return gdiPath;

        // Rebuild path from points and types
        int i = 0;
        while (i < points.Length)
        {
            var pointType = types[i];
            var baseType = (ChartPathPointType)((byte)pointType & 0x07);
            bool closeSubpath = ((byte)pointType & (byte)ChartPathPointType.CloseSubpath) != 0;

            switch (baseType)
            {
                case ChartPathPointType.Start:
                    gdiPath.StartFigure();
                    i++;
                    break;

                case ChartPathPointType.Line:
                    if (i > 0)
                    {
                        gdiPath.AddLine(ToPoint(points[i - 1]), ToPoint(points[i]));
                    }
                    i++;
                    break;

                case ChartPathPointType.Bezier:
                    if (i + 2 < points.Length)
                    {
                        gdiPath.AddBezier(
                            ToPoint(points[i - 1]),
                            ToPoint(points[i]),
                            ToPoint(points[i + 1]),
                            ToPoint(points[i + 2]));
                        i += 3;
                    }
                    else
                    {
                        i++;
                    }
                    break;

                default:
                    i++;
                    break;
            }

            if (closeSubpath)
            {
                gdiPath.CloseFigure();
            }
        }

        return gdiPath;
    }

    /// <inheritdoc/>
    public StringFormat ToStringFormat(ChartStringFormat format)
    {
        var sf = new StringFormat();
        
        sf.Alignment = format.Alignment switch
        {
            ChartStringAlignment.Near => StringAlignment.Near,
            ChartStringAlignment.Center => StringAlignment.Center,
            ChartStringAlignment.Far => StringAlignment.Far,
            _ => StringAlignment.Near
        };

        sf.LineAlignment = format.LineAlignment switch
        {
            ChartStringAlignment.Near => StringAlignment.Near,
            ChartStringAlignment.Center => StringAlignment.Center,
            ChartStringAlignment.Far => StringAlignment.Far,
            _ => StringAlignment.Near
        };

        sf.Trimming = format.Trimming switch
        {
            ChartStringTrimming.None => StringTrimming.None,
            ChartStringTrimming.Character => StringTrimming.Character,
            ChartStringTrimming.Word => StringTrimming.Word,
            ChartStringTrimming.EllipsisCharacter => StringTrimming.EllipsisCharacter,
            ChartStringTrimming.EllipsisWord => StringTrimming.EllipsisWord,
            ChartStringTrimming.EllipsisPath => StringTrimming.EllipsisPath,
            _ => StringTrimming.None
        };

        sf.FormatFlags = (StringFormatFlags)format.FormatFlags;

        return sf;
    }

    #endregion

    #region From Platform-Specific

    /// <inheritdoc/>
    public ChartPointF FromPoint(PointF point) => new(point.X, point.Y);

    /// <inheritdoc/>
    public ChartPointF[] FromPoints(PointF[] points)
    {
        if (points == null) return [];
        
        var result = new ChartPointF[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            result[i] = FromPoint(points[i]);
        }
        return result;
    }

    /// <inheritdoc/>
    public ChartSizeF FromSize(SizeF size) => new(size.Width, size.Height);

    /// <inheritdoc/>
    public ChartRectangleF FromRectangle(RectangleF rect) => new(rect.X, rect.Y, rect.Width, rect.Height);

    /// <inheritdoc/>
    public ChartColor FromColor(Color color) => ChartColor.FromArgb(color.A, color.R, color.G, color.B);

    /// <inheritdoc/>
    public ChartMatrix FromMatrix(Matrix matrix)
    {
        var elements = matrix.Elements;
        return new ChartMatrix(elements[0], elements[1], elements[2], elements[3], elements[4], elements[5]);
    }

    #endregion

    #region Helper Methods

    private static LineCap ToLineCap(ChartLineCap cap)
    {
        return cap switch
        {
            ChartLineCap.Flat => LineCap.Flat,
            ChartLineCap.Square => LineCap.Square,
            ChartLineCap.Round => LineCap.Round,
            ChartLineCap.Triangle => LineCap.Triangle,
            ChartLineCap.NoAnchor => LineCap.NoAnchor,
            ChartLineCap.SquareAnchor => LineCap.SquareAnchor,
            ChartLineCap.RoundAnchor => LineCap.RoundAnchor,
            ChartLineCap.DiamondAnchor => LineCap.DiamondAnchor,
            ChartLineCap.ArrowAnchor => LineCap.ArrowAnchor,
            _ => LineCap.Flat
        };
    }

    private static LineJoin ToLineJoin(ChartLineJoin join)
    {
        return join switch
        {
            ChartLineJoin.Miter => LineJoin.Miter,
            ChartLineJoin.Bevel => LineJoin.Bevel,
            ChartLineJoin.Round => LineJoin.Round,
            ChartLineJoin.MiterClipped => LineJoin.MiterClipped,
            _ => LineJoin.Miter
        };
    }

    private LinearGradientBrush CreateLinearGradientBrush(ChartLinearGradientBrush brush)
    {
        var rect = ToRectangle(brush.Rectangle);
        if (rect.Width == 0) rect.Width = 1;
        if (rect.Height == 0) rect.Height = 1;

        var mode = brush.GradientMode switch
        {
            ChartLinearGradientMode.Horizontal => LinearGradientMode.Horizontal,
            ChartLinearGradientMode.Vertical => LinearGradientMode.Vertical,
            ChartLinearGradientMode.ForwardDiagonal => LinearGradientMode.ForwardDiagonal,
            ChartLinearGradientMode.BackwardDiagonal => LinearGradientMode.BackwardDiagonal,
            _ => LinearGradientMode.Horizontal
        };

        return new LinearGradientBrush(rect, ToColor(brush.Color1), ToColor(brush.Color2), mode);
    }

    private HatchBrush CreateHatchBrush(ChartHatchBrush brush)
    {
        var style = (HatchStyle)brush.HatchStyle;
        return new HatchBrush(style, ToColor(brush.ForegroundColor), ToColor(brush.BackgroundColor));
    }

    #endregion
}
