using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Outputs.Documents.Domain.VectorStore.Generation.Providers;

public sealed class OllamaEmbeddingProvider : IEmbeddingProvider
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    private readonly HttpClient _client;

    public OllamaEmbeddingProvider(string baseUrl, string model, string embeddingFormat)
    {
        Name = "ollama";
        Model = model;
        EmbeddingFormat = embeddingFormat;
        _client = new HttpClient { BaseAddress = new Uri(baseUrl) };
    }

    public string Name { get; }

    public string Model { get; }

    public string EmbeddingFormat { get; }

    public async Task<IReadOnlyList<float[]>> CreateEmbeddingsAsync(
        IReadOnlyList<string> texts,
        CancellationToken cancellationToken = default)
    {
        var request = new OllamaEmbeddingRequest(Model, texts);
        using var content = new StringContent(
            JsonSerializer.Serialize(request, JsonOptions),
            Encoding.UTF8,
            "application/json");
        using var response = await _client.PostAsync("api/embed", content, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new InvalidOperationException(
                $"Ollama embedding request failed with HTTP {(int)response.StatusCode}: {body}");
        }

        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        var result = await JsonSerializer.DeserializeAsync<OllamaEmbeddingResponse>(
            stream,
            JsonOptions,
            cancellationToken)
            ?? throw new InvalidOperationException("Ollama embedding response was empty.");

        return result.Embeddings;
    }

    private sealed record OllamaEmbeddingRequest(
        [property: JsonPropertyName("model")] string Model,
        [property: JsonPropertyName("input")] IReadOnlyList<string> Input);

    private sealed record OllamaEmbeddingResponse(
        [property: JsonPropertyName("embeddings")] IReadOnlyList<float[]> Embeddings);
}
