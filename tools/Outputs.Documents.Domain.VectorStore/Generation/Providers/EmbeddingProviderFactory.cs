namespace Outputs.Documents.Domain.VectorStore.Generation.Providers;

public static class EmbeddingProviderFactory
{
    public static IEmbeddingProvider Create(DomainVectorStoreGenerationRequest request)
    {
        return request.Provider.ToLowerInvariant() switch
        {
            "ollama" => new OllamaEmbeddingProvider(request.OllamaBaseUrl, request.Model, request.EmbeddingFormat),
            "openai" => new OpenAiEmbeddingProvider(request.OpenAiBaseUrl, request.Model, request.EmbeddingFormat, request.OpenAiApiKey),
            _ => throw new ArgumentException($"Unknown embedding provider '{request.Provider}'. Use 'ollama' or 'openai'.")
        };
    }
}
