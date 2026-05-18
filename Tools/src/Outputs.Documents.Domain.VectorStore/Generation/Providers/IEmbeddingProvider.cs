namespace Outputs.Documents.Domain.VectorStore.Generation.Providers;

public interface IEmbeddingProvider
{
    string Name { get; }

    string Model { get; }

    string EmbeddingFormat { get; }

    Task<IReadOnlyList<float[]>> CreateEmbeddingsAsync(
        IReadOnlyList<string> texts,
        CancellationToken cancellationToken = default);
}
