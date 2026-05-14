using Outputs.Documents.Domain.VectorStore.Storage;

namespace Outputs.Documents.Domain.VectorStore.Tests.Support;

internal sealed class StoreScope : IDisposable
{
    private readonly string _directory;

    private StoreScope(string directory)
    {
        _directory = directory;
        Store = new DomainVectorStore(directory);
    }

    public DomainVectorStore Store { get; }

    public static StoreScope Create()
    {
        var directory = Path.Combine(
            Path.GetTempPath(),
            "outputs-documents-vector-store-tests",
            Guid.NewGuid().ToString("N"));

        return new StoreScope(directory);
    }

    public void Dispose()
    {
        if (Directory.Exists(_directory))
        {
            Directory.Delete(_directory, recursive: true);
        }
    }
}
