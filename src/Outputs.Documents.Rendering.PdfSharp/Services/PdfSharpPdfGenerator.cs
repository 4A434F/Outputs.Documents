using System.Net;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Options;
using Outputs.Documents.Abstractions;
using PdfSharpCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Fonts;
using PdfSharpCore.Pdf;
using PdfSharpCore.Utils;

namespace Outputs.Documents.Rendering.PdfSharp;

public sealed class PdfSharpPdfGenerator(IOptions<PdfSharpPdfGeneratorOptions> options) : IPdfGenerator
{
    private static readonly Regex BlockBreaks = new("</(p|div|section|article|header|footer|h[1-6]|li|tr)>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex LineBreaks = new(@"<br\s*/?>", RegexOptions.IgnoreCase | RegexOptions.Compiled);
    private static readonly Regex Tags = new("<[^>]+>", RegexOptions.Compiled);
    private static readonly object FontResolverLock = new();

    private readonly PdfSharpPdfGeneratorOptions _options = options.Value;

    public Task<byte[]> GenerateAsync(
        string bodyHtml,
        string? headerHtml = null,
        string? footerHtml = null,
        double? widthCm = null,
        double? heightCm = null,
        CancellationToken cancellationToken = default)
    {
        cancellationToken.ThrowIfCancellationRequested();

        if (string.IsNullOrWhiteSpace(bodyHtml))
        {
            throw new ArgumentException("HTML must not be null or empty.", nameof(bodyHtml));
        }

        EnsureFontResolver();

        using var document = new PdfDocument();
        var page = document.AddPage();
        ApplyPageSize(page, widthCm, heightCm);

        using var graphics = XGraphics.FromPdfPage(page);
        var font = new XFont(_options.FontName, _options.FontSize, XFontStyle.Regular);
        var text = HtmlToText(ComposeHtml(bodyHtml, headerHtml, footerHtml));
        var contentBox = CreateContentBox(page);

        DrawText(graphics, text, font, contentBox);

        using var output = new MemoryStream();
        document.Save(output, false);
        return Task.FromResult(output.ToArray());
    }

    private static void DrawText(XGraphics graphics, string text, XFont font, XRect contentBox)
    {
        var lineHeight = font.Size * 1.4;
        var y = contentBox.Top;

        foreach (var paragraph in text.Split('\n'))
        {
            foreach (var line in WrapLine(graphics, paragraph, font, contentBox.Width))
            {
                if (y + lineHeight > contentBox.Bottom)
                {
                    return;
                }

                graphics.DrawString(
                    line,
                    font,
                    XBrushes.Black,
                    new XRect(contentBox.Left, y, contentBox.Width, lineHeight),
                    XStringFormats.TopLeft);

                y += lineHeight;
            }
        }
    }

    private static IEnumerable<string> WrapLine(
        XGraphics graphics,
        string line,
        XFont font,
        double maxWidth)
    {
        if (string.IsNullOrWhiteSpace(line))
        {
            yield return string.Empty;
            yield break;
        }

        var words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var current = string.Empty;

        foreach (var word in words)
        {
            var candidate = string.IsNullOrEmpty(current) ? word : $"{current} {word}";

            if (graphics.MeasureString(candidate, font).Width <= maxWidth)
            {
                current = candidate;
                continue;
            }

            if (!string.IsNullOrEmpty(current))
            {
                yield return current;
            }

            current = word;
        }

        if (!string.IsNullOrEmpty(current))
        {
            yield return current;
        }
    }

    private void ApplyPageSize(PdfPage page, double? widthCm, double? heightCm)
    {
        if (widthCm is not null && heightCm is not null)
        {
            page.Width = CentimetersToPoints(widthCm.Value);
            page.Height = CentimetersToPoints(heightCm.Value);
            return;
        }

        page.Size = Enum.TryParse<PageSize>(_options.PageSize, out var pageSize)
            ? pageSize
            : PageSize.A4;
    }

    private XRect CreateContentBox(PdfPage page)
    {
        var left = _options.MarginLeft;
        var top = _options.MarginTop;
        var width = Math.Max(1, page.Width.Point - _options.MarginLeft - _options.MarginRight);
        var height = Math.Max(1, page.Height.Point - _options.MarginTop - _options.MarginBottom);
        return new XRect(left, top, width, height);
    }

    private static string ComposeHtml(string bodyHtml, string? headerHtml, string? footerHtml)
    {
        return $"{headerHtml ?? string.Empty}\n{bodyHtml}\n{footerHtml ?? string.Empty}";
    }

    private static string HtmlToText(string html)
    {
        var text = LineBreaks.Replace(html, "\n");
        text = BlockBreaks.Replace(text, "\n");
        text = Tags.Replace(text, string.Empty);
        text = WebUtility.HtmlDecode(text);
        text = Regex.Replace(text, "[ \\t]+", " ");
        text = Regex.Replace(text, "\\n{3,}", "\n\n");
        return text.Trim();
    }

    private static double CentimetersToPoints(double centimeters)
    {
        return centimeters * 72 / 2.54;
    }

    private static void EnsureFontResolver()
    {
        if (GlobalFontSettings.FontResolver is not null)
        {
            return;
        }

        lock (FontResolverLock)
        {
            GlobalFontSettings.FontResolver ??= new FontResolver();
        }
    }
}
