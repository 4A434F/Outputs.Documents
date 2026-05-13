namespace Outputs.Documents.Abstractions;

public sealed record RenderSource(
    string? Name = null,
    string? Operation = null,
    bool IsPreview = false,
    bool IsReprint = false,
    bool IsBatch = false,
    IReadOnlyDictionary<string, object?>? Metadata = null)
{
    public IReadOnlyDictionary<string, object?> Metadata { get; init; } =
        Metadata ?? new Dictionary<string, object?>();

    public static RenderSource Empty { get; } = new();

    public override string ToString()
    {
        return $"Name='{Name ?? ""}', Operation='{Operation ?? ""}', IsPreview={IsPreview}, IsReprint={IsReprint}, IsBatch={IsBatch}";
    }
}
