using Outputs.Documents.Domain.VectorStore;

namespace Outputs.Documents.Tools.Dashboard.Services;

public sealed class VectorStoreSearchService(IDomainVectorStore vectorStore)
{
    public async Task<VectorStoreOverview> GetOverviewAsync(
        string? selectedModel,
        CancellationToken cancellationToken = default)
    {
        var models = await vectorStore.ListModelsAsync(cancellationToken);
        var model = ResolveSelectedModel(models, selectedModel);

        if (model is null)
        {
            return new VectorStoreOverview(models, null, [], 0);
        }

        var records = await vectorStore.ListAsync(model, cancellationToken: cancellationToken);
        var kinds = records
            .Select(record => record.Kind)
            .Where(kind => !string.IsNullOrWhiteSpace(kind))
            .Distinct(StringComparer.OrdinalIgnoreCase)
            .Order(StringComparer.OrdinalIgnoreCase)
            .ToList();

        return new VectorStoreOverview(models, model, kinds, records.Count);
    }

    public async Task<IReadOnlyList<VectorStoreSearchResultItem>> SearchAsync(
        VectorStoreSearchRequest request,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(request.ModelName);
        ArgumentException.ThrowIfNullOrWhiteSpace(request.Query);

        var limit = Math.Clamp(request.Limit, 1, 50);
        var kind = string.IsNullOrWhiteSpace(request.Kind) ? null : request.Kind;

        var results = await vectorStore.ExactSearchAsync(
            request.ModelName,
            request.Query,
            limit,
            kind,
            cancellationToken);

        return results
            .Select(result =>
            {
                var record = result.Record;

                return new VectorStoreSearchResultItem(
                    record.Id,
                    record.Kind,
                    record.Declaration,
                    record.Name,
                    record.Text,
                    result.MatchKind,
                    result.Score,
                    record.Embedding.Length,
                    record.Aliases,
                    record.Tags,
                    record.Metadata);
            })
            .ToList();
    }

    private static string? ResolveSelectedModel(
        IReadOnlyList<string> models,
        string? selectedModel)
    {
        if (models.Count == 0)
        {
            return null;
        }

        if (!string.IsNullOrWhiteSpace(selectedModel) &&
            models.Any(model => string.Equals(model, selectedModel, StringComparison.Ordinal)))
        {
            return selectedModel;
        }

        return models[0];
    }
}
