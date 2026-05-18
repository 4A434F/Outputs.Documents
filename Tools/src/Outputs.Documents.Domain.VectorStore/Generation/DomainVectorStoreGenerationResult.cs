namespace Outputs.Documents.Domain.VectorStore.Generation;

public sealed record DomainVectorStoreGenerationResult(
    string StoreModelName,
    string DatabasePath,
    int DomainTypeCount,
    int DescriptorCount,
    IReadOnlyList<string> Messages);
