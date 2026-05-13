namespace Outputs.Documents.Abstractions;

public interface IPdfGenerator
{
    Task<byte[]> GenerateAsync(
        string bodyHtml,
        string? headerHtml = null,
        string? footerHtml = null,
        double? widthCm = null,
        double? heightCm = null,
        CancellationToken cancellationToken = default);
}
