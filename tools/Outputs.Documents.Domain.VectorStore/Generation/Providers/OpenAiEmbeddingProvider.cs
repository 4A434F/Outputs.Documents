using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Outputs.Documents.Domain.VectorStore.Generation.Providers;

public sealed class OpenAiEmbeddingProvider : IEmbeddingProvider
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    private readonly HttpClient _client;

    public OpenAiEmbeddingProvider(
        string baseUrl,
        string model,
        string embeddingFormat,
        string? apiKey)
    {
        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new ArgumentException(
                "OpenAI provider requires --api-key or OPENAI_API_KEY.",
                nameof(apiKey));
        }

        Name = "openai";
        Model = model;
        EmbeddingFormat = embeddingFormat;
        _client = new HttpClient { BaseAddress = new Uri(baseUrl) };
        _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
    }

    public string Name { get; }

    public string Model { get; }

    public string EmbeddingFormat { get; }

    public async Task<IReadOnlyList<float[]>> CreateEmbeddingsAsync(
        IReadOnlyList<string> texts,
        CancellationToken cancellationToken = default)
    {
        var request = new OpenAiEmbeddingRequest(Model, texts);
        using var content = new StringContent(
            JsonSerializer.Serialize(request, JsonOptions),
            Encoding.UTF8,
            "application/json");
        using var response = await _client.PostAsync("embeddings", content, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var body = await response.Content.ReadAsStringAsync(cancellationToken);
            throw new InvalidOperationException(
                $"OpenAI embedding request failed with HTTP {(int)response.StatusCode}: {body}");
        }

        await using var stream = await response.Content.ReadAsStreamAsync(cancellationToken);
        var result = await JsonSerializer.DeserializeAsync<OpenAiEmbeddingResponse>(
            stream,
            JsonOptions,
            cancellationToken)
            ?? throw new InvalidOperationException("OpenAI embedding response was empty.");

        return result.Data
            .OrderBy(item => item.Index)
            .Select(item => item.Embedding)
            .ToArray();
    }

    private sealed record OpenAiEmbeddingRequest(
        [property: JsonPropertyName("model")] string Model,
        [property: JsonPropertyName("input")] IReadOnlyList<string> Input);

    private sealed record OpenAiEmbeddingResponse(
        [property: JsonPropertyName("data")] IReadOnlyList<OpenAiEmbeddingData> Data);

    private sealed record OpenAiEmbeddingData(
        [property: JsonPropertyName("index")] int Index,
        [property: JsonPropertyName("embedding")] float[] Embedding);
}
