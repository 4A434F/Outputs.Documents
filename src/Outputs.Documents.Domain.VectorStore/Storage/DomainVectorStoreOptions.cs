namespace Outputs.Documents.Domain.VectorStore.Storage;

public sealed class DomainVectorStoreOptions
{
    public DomainVectorStoreOptions(string databaseDirectory)
    {
        DatabaseDirectory = databaseDirectory;
    }

    public string DatabaseDirectory { get; }
}
