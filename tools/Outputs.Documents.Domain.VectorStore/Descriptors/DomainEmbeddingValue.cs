namespace Outputs.Documents.Domain.VectorStore.Descriptors;

public sealed record DomainEmbeddingValue(
    string DescriptorId,
    float[] Embedding);
