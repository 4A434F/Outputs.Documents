namespace Outputs.Documents.Domain.VectorStore.Records;

public sealed record EmbeddingRecord
{
    public required string Id { get; init; }

    public required string Kind { get; init; }

    public required string Declaration { get; init; }

    public required string Name { get; init; }

    public required string Text { get; init; }

    public required string EmbeddingModel { get; init; }

    public required float[] Embedding { get; init; }

    public IReadOnlyList<string> Aliases { get; init; } = [];

    public IReadOnlyList<string> Tags { get; init; } = [];

    public IReadOnlyDictionary<string, string> Metadata { get; init; } =
        new Dictionary<string, string>();
}
