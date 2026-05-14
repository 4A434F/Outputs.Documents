using Outputs.Documents.Domain.VectorStore.Descriptors;
using Outputs.Documents.Domain.VectorStore.Generation.Domain;
using Outputs.Documents.Domain.VectorStore.Generation.Providers;
using Outputs.Documents.Domain.VectorStore.Storage;

namespace Outputs.Documents.Domain.VectorStore.Generation;

public sealed class DomainVectorStoreGenerator : IDomainVectorStoreGenerator
{
    public DomainVectorStoreGenerationDefaults GetDefaults()
    {
        return new DomainVectorStoreGenerationDefaults(
            Provider: "ollama",
            Model: "qwen3-embedding:latest",
            EmbeddingFormat: "float32",
            OpenAiBaseUrl: Environment.GetEnvironmentVariable("OPENAI_BASE_URL") ?? "https://api.openai.com/v1/",
            OllamaBaseUrl: Environment.GetEnvironmentVariable("OLLAMA_BASE_URL") ?? "http://127.0.0.1:11434/",
            BatchSize: 16);
    }

    public async Task<DomainVectorStoreGenerationResult> GenerateAsync(
        DomainVectorStoreGenerationRequest request,
        CancellationToken cancellationToken = default)
    {
        var provider = EmbeddingProviderFactory.Create(request);
        var vectorStore = new DomainVectorStore(request.DatabaseDirectory);
        var router = new ModelDatabaseRouter(request.DatabaseDirectory);
        var storeModelName = $"{provider.Name}:{provider.Model}:{provider.EmbeddingFormat}";
        var domainTypes = DomainTypeDiscovery.GetDomainTypes();
        var messages = new List<string>();
        var descriptorCount = 0;

        foreach (var domainType in domainTypes)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var descriptors = vectorStore.Describe(domainType);
            var values = new List<DomainEmbeddingValue>(descriptors.Count);

            foreach (var batch in descriptors.Chunk(request.BatchSize))
            {
                var embeddings = await provider.CreateEmbeddingsAsync(
                    batch.Select(descriptor => descriptor.Text).ToArray(),
                    cancellationToken);

                if (embeddings.Count != batch.Length)
                {
                    throw new InvalidOperationException(
                        $"Provider returned '{embeddings.Count}' embeddings for '{batch.Length}' descriptor texts.");
                }

                values.AddRange(batch.Select((descriptor, index) =>
                    new DomainEmbeddingValue(descriptor.Id, embeddings[index])));
            }

            await vectorStore.UpsertAsync(storeModelName, domainType, values, cancellationToken);

            descriptorCount += descriptors.Count;
            messages.Add($"{domainType.Name}: {descriptors.Count} descriptors");
        }

        return new DomainVectorStoreGenerationResult(
            storeModelName,
            router.GetDatabasePath(storeModelName),
            domainTypes.Count,
            descriptorCount,
            messages);
    }
}
