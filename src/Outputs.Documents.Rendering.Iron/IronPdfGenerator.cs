using System.Text;
using IronPdf;
using IronPdf.Rendering;
using Microsoft.Extensions.Options;
using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Rendering.Iron;

public sealed class IronPdfGenerator(IOptions<IronPdfGeneratorOptions> options) : IPdfGenerator
{
    private readonly IronPdfGeneratorOptions _options = options.Value;

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

        ApplyLicense(_options);

        var renderer = new ChromePdfRenderer();
        ApplyDefaults(renderer.RenderingOptions, _options);

        var renderingOptions = renderer.RenderingOptions;
        renderingOptions.InputEncoding = Encoding.UTF8;

        if (widthCm is not null && heightCm is not null)
        {
            renderingOptions.PaperSize = PdfPaperSize.Custom;
            renderingOptions.MarginTop = 0;
            renderingOptions.MarginRight = 0;
            renderingOptions.MarginBottom = 0;
            renderingOptions.MarginLeft = 0;
            renderingOptions.SetCustomPaperSizeinCentimeters(widthCm.Value, heightCm.Value);
        }

        renderingOptions.HtmlHeader = new HtmlHeaderFooter { HtmlFragment = headerHtml ?? string.Empty };
        renderingOptions.HtmlFooter = new HtmlHeaderFooter { HtmlFragment = footerHtml ?? string.Empty };

        using var pdf = renderer.RenderHtmlAsPdf(bodyHtml);
        return Task.FromResult(pdf.BinaryData);
    }

    private static void ApplyLicense(IronPdfGeneratorOptions options)
    {
        if (!string.IsNullOrWhiteSpace(options.LicenseKey))
        {
            License.LicenseKey = options.LicenseKey;
        }
    }

    private static void ApplyDefaults(ChromePdfRenderOptions renderingOptions, IronPdfGeneratorOptions options)
    {
        renderingOptions.PaperSize = Enum.TryParse<PdfPaperSize>(options.PaperSize, out var paperSize)
            ? paperSize
            : PdfPaperSize.A4;

        renderingOptions.MarginTop = options.MarginTop;
        renderingOptions.MarginRight = options.MarginRight;
        renderingOptions.MarginBottom = options.MarginBottom;
        renderingOptions.MarginLeft = options.MarginLeft;

        renderingOptions.EnableJavaScript = options.EnableJavaScript;
        renderingOptions.CssMediaType = Enum.TryParse<PdfCssMediaType>(options.CssMediaType, out var cssMediaType)
            ? cssMediaType
            : PdfCssMediaType.Print;

        renderingOptions.CustomCssUrl = ResolveCssUrl(options.BaseUrl);
        renderingOptions.HtmlHeader = new HtmlHeaderFooter { HtmlFragment = string.Empty };
        renderingOptions.HtmlFooter = new HtmlHeaderFooter { HtmlFragment = string.Empty };
        renderingOptions.Zoom = options.Scale;
    }

    private static string? ResolveCssUrl(string? baseUrl)
    {
        if (string.IsNullOrWhiteSpace(baseUrl))
        {
            return null;
        }

        var absolutePath = Path.IsPathRooted(baseUrl)
            ? baseUrl
            : Path.Combine(Directory.GetCurrentDirectory(), baseUrl);

        return Directory.Exists(absolutePath) ? absolutePath : null;
    }
}
