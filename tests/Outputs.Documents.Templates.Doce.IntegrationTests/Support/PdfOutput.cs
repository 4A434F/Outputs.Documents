namespace Outputs.Documents.Templates.Doce.IntegrationTests.Support;

internal static class PdfOutput
{
    public static async Task SaveAsync(byte[] pdfBytes, string fileName)
    {
        if (pdfBytes.Length == 0)
        {
            throw new ArgumentException("PDF content cannot be empty.", nameof(pdfBytes));
        }

        var outputDirectory = Path.Combine(AppContext.BaseDirectory, "TestResults", "Pdf");
        Directory.CreateDirectory(outputDirectory);

        await File.WriteAllBytesAsync(Path.Combine(outputDirectory, fileName), pdfBytes);
    }
}
