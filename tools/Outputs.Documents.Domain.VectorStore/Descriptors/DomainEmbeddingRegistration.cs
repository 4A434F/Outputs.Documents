namespace Outputs.Documents.Domain.VectorStore.Descriptors;

public sealed record DomainEmbeddingRegistration(
    Type DomainType,
    IReadOnlyList<DomainEmbeddingValue> Embeddings);
