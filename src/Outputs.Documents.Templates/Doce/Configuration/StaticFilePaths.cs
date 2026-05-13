namespace Outputs.Documents.Templates.Doce;

public sealed class StaticFilePaths
{
    public string Path { get; set; } = AppContext.BaseDirectory;

    public string Logos { get; set; } = System.IO.Path.Combine(AppContext.BaseDirectory, "wwwroot", "Logos");

    public string Fonts { get; set; } = System.IO.Path.Combine(AppContext.BaseDirectory, "wwwroot", "fonts");
}
