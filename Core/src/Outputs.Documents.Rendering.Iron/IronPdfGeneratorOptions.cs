namespace Outputs.Documents.Rendering.Iron;

public sealed class IronPdfGeneratorOptions
{
    public string? LicenseKey { get; set; }

    public string PaperSize { get; set; } = "A4";

    public string CssMediaType { get; set; } = "Print";

    public bool EnableJavaScript { get; set; }

    public string? BaseUrl { get; set; }

    public double MarginTop { get; set; } = 30;

    public double MarginRight { get; set; }

    public double MarginBottom { get; set; } = 17;

    public double MarginLeft { get; set; }

    public int Scale { get; set; } = 100;
}
