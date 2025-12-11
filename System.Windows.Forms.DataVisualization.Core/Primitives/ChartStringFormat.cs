// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows.Forms.DataVisualization.Charting.Rendering;

namespace System.Windows.Forms.DataVisualization.Charting;

/// <summary>
/// Encapsulates text layout information (such as alignment, orientation, and tab stops),
/// display manipulations (such as ellipsis insertion and national digit substitution),
/// and OpenType features.
/// Platform-agnostic replacement for System.Drawing.StringFormat.
/// </summary>
public class ChartStringFormat : IDisposable, ICloneable
{
    private bool _disposed;

    /// <summary>
    /// Gets or sets horizontal alignment of the string.
    /// </summary>
    public ChartStringAlignment Alignment { get; set; } = ChartStringAlignment.Near;

    /// <summary>
    /// Gets or sets the vertical alignment of the string.
    /// </summary>
    public ChartStringAlignment LineAlignment { get; set; } = ChartStringAlignment.Near;

    /// <summary>
    /// Gets or sets the ChartStringFormatFlags enumeration that contains formatting information.
    /// </summary>
    public ChartStringFormatFlags FormatFlags { get; set; }

    /// <summary>
    /// Gets or sets the ChartStringTrimming enumeration for this ChartStringFormat object.
    /// </summary>
    public ChartStringTrimming Trimming { get; set; } = ChartStringTrimming.Character;

    /// <summary>
    /// Gets or sets the HotkeyPrefix object for this ChartStringFormat object.
    /// </summary>
    public ChartHotkeyPrefix HotkeyPrefix { get; set; } = ChartHotkeyPrefix.None;

    /// <summary>
    /// Initializes a new ChartStringFormat object.
    /// </summary>
    public ChartStringFormat()
    {
    }

    /// <summary>
    /// Initializes a new ChartStringFormat object with the specified ChartStringFormatFlags enumeration.
    /// </summary>
    public ChartStringFormat(ChartStringFormatFlags flags)
    {
        FormatFlags = flags;
    }

    /// <summary>
    /// Initializes a new ChartStringFormat object from the specified existing ChartStringFormat object.
    /// </summary>
    public ChartStringFormat(ChartStringFormat format)
    {
        ArgumentNullException.ThrowIfNull(format);
        Alignment = format.Alignment;
        LineAlignment = format.LineAlignment;
        FormatFlags = format.FormatFlags;
        Trimming = format.Trimming;
        HotkeyPrefix = format.HotkeyPrefix;
    }

    /// <summary>
    /// Gets a generic default ChartStringFormat object.
    /// </summary>
    public static ChartStringFormat GenericDefault => new();

    /// <summary>
    /// Gets a generic typographic ChartStringFormat object.
    /// </summary>
    public static ChartStringFormat GenericTypographic => new()
    {
        FormatFlags = ChartStringFormatFlags.FitBlackBox | ChartStringFormatFlags.LineLimit | ChartStringFormatFlags.NoClip,
        Trimming = ChartStringTrimming.None
    };

    /// <summary>
    /// Creates an exact copy of this ChartStringFormat object.
    /// </summary>
    public object Clone() => new ChartStringFormat(this);

    /// <summary>
    /// Converts this ChartStringFormat to CSS text alignment properties.
    /// </summary>
    public string ToCssTextAlign()
    {
        return Alignment switch
        {
            ChartStringAlignment.Near => "start",
            ChartStringAlignment.Center => "middle",
            ChartStringAlignment.Far => "end",
            _ => "start"
        };
    }

    /// <summary>
    /// Converts this ChartStringFormat to SVG text anchor value.
    /// </summary>
    public string ToSvgTextAnchor()
    {
        return Alignment switch
        {
            ChartStringAlignment.Near => "start",
            ChartStringAlignment.Center => "middle",
            ChartStringAlignment.Far => "end",
            _ => "start"
        };
    }

    /// <summary>
    /// Converts this ChartStringFormat to SVG dominant-baseline value.
    /// </summary>
    public string ToSvgDominantBaseline()
    {
        return LineAlignment switch
        {
            ChartStringAlignment.Near => "text-before-edge",
            ChartStringAlignment.Center => "central",
            ChartStringAlignment.Far => "text-after-edge",
            _ => "text-before-edge"
        };
    }

    /// <summary>
    /// Releases all resources used by this ChartStringFormat object.
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases the unmanaged resources used by the ChartStringFormat and optionally releases the managed resources.
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            _disposed = true;
        }
    }
}

/// <summary>
/// Specifies the type of display for hotkey prefixes.
/// </summary>
public enum ChartHotkeyPrefix
{
    /// <summary>
    /// No hotkey prefix.
    /// </summary>
    None = 0,

    /// <summary>
    /// Display the hotkey prefix.
    /// </summary>
    Show = 1,

    /// <summary>
    /// Do not display the hotkey prefix.
    /// </summary>
    Hide = 2
}
