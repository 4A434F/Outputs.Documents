namespace Outputs.Documents.Domain.VectorStore.Alignment;

public sealed record AlignmentEmbedding(
    string Key,
    string EmbeddingModel,
    float[] Embedding);
