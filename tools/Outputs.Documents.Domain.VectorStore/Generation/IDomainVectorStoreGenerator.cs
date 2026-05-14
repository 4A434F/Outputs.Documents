namespace Outputs.Documents.Domain.VectorStore.Generation;

public interface IDomainVectorStoreGenerator
{
    DomainVectorStoreGenerationDefaults GetDefaults();

    Task<DomainVectorStoreGenerationResult> GenerateAsync(
        DomainVectorStoreGenerationRequest request,
        CancellationToken cancellationToken = default);
}
