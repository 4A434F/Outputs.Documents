namespace Outputs.Documents.Domain.Doce;

public class Header(string logoPath, string? title = null, string? subtitle = null)
{
    public string LogoPath { get; set; } = logoPath;

    public string? Title { get; set; } = title;

    public string? Subtitle { get; set; } = subtitle;
}
