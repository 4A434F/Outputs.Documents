namespace Outputs.Documents.Domain.Documents;

[DomainSearch(
    "DOCE header",
    "Reusable header model with logo path, title, and subtitle for DOCE document templates.",
    Aliases = ["header", "document header", "logo header"],
    Tags = ["common", "doce", "header", "branding"])]
public class Header(string logoPath, string? title = null, string? subtitle = null)
{
    public string LogoPath { get; set; } = logoPath;

    public string? Title { get; set; } = title;

    public string? Subtitle { get; set; } = subtitle;
}
