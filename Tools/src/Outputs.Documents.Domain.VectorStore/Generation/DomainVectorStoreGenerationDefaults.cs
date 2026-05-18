namespace Outputs.Documents.Domain.VectorStore.Generation;

public sealed record DomainVectorStoreGenerationDefaults(
    string Provider,
    string Model,
    string EmbeddingFormat,
    string OpenAiBaseUrl,
    string OllamaBaseUrl,
    int BatchSize);
