namespace Outputs.Documents.Domain.VectorStore.Descriptors;

public sealed record DomainEmbeddingDescriptor(
    string Id,
    string Kind,
    string Declaration,
    string Name,
    string Description,
    string Text,
    IReadOnlyList<string> Aliases,
    IReadOnlyList<string> Tags,
    IReadOnlyDictionary<string, string> Metadata);
