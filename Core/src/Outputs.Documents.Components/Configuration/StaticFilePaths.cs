namespace Outputs.Documents.Components;

public sealed class StaticFilePaths
{
    private string Path { get; set; } = System.IO.Path.Combine(AppContext.BaseDirectory, "wwwroot");

    private string Logos { get; set; } = "Logos";

    private string Fonts { get; set; } = "fonts";

    private string Signatures { get; set; } = "assinaturas";

    private string PaymentIcons { get; set; } = "payment-icons";

    public string? TryReadLogoDataUri(string fileName)
    {
        return TryReadDataUri(Logos, fileName);
    }

    public string? TryReadSignatureDataUri(string fileName)
    {
        return TryReadDataUri(Signatures, fileName);
    }

    public string? TryReadPaymentIconDataUri(string fileName)
    {
        return TryReadDataUri(PaymentIcons, fileName);
    }

    public string? TryReadFontBase64(string fileName)
    {
        var fullPath = ResolvePath(Fonts, fileName);
        return fullPath is not null && File.Exists(fullPath)
            ? Convert.ToBase64String(File.ReadAllBytes(fullPath))
            : null;
    }

    private string? TryReadDataUri(string directory, string fileName)
    {
        var fullPath = ResolvePath(directory, fileName);
        if (fullPath is null || !File.Exists(fullPath))
        {
            return null;
        }

        var bytes = File.ReadAllBytes(fullPath);
        return $"data:{GetContentType(fullPath)};base64,{Convert.ToBase64String(bytes)}";
    }

    private string? ResolvePath(string directory, string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return null;
        }

        if (System.IO.Path.IsPathRooted(fileName))
        {
            return fileName;
        }

        var baseDirectory = System.IO.Path.IsPathRooted(directory)
            ? directory
            : System.IO.Path.Combine(Path, directory);

        return System.IO.Path.Combine(baseDirectory, fileName);
    }

    private static string GetContentType(string path)
    {
        return System.IO.Path.GetExtension(path).ToLowerInvariant() switch
        {
            ".gif" => "image/gif",
            ".jpg" or ".jpeg" => "image/jpeg",
            ".png" => "image/png",
            ".svg" => "image/svg+xml",
            ".ttf" => "font/ttf",
            ".woff" => "font/woff",
            ".woff2" => "font/woff2",
            _ => "application/octet-stream"
        };
    }
}
