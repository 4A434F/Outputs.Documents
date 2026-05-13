namespace Outputs.Documents.Rendering.PdfSharp;

public sealed class PdfSharpPdfGeneratorOptions
{
    public string PageSize { get; set; } = "A4";

    public int MarginTop { get; set; } = 30;

    public int MarginRight { get; set; }

    public int MarginBottom { get; set; } = 17;

    public int MarginLeft { get; set; }

    public string FontName { get; set; } = "Arial";

    public double FontSize { get; set; } = 11;
}
