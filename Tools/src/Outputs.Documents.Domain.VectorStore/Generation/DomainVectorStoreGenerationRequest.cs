namespace Outputs.Documents.Domain.VectorStore.Generation;

public sealed record DomainVectorStoreGenerationRequest(
    string Provider,
    string Model,
    string EmbeddingFormat,
    string DatabaseDirectory,
    string? OpenAiApiKey,
    string OpenAiBaseUrl,
    string OllamaBaseUrl,
    int BatchSize);
