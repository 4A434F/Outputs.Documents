namespace Outputs.Documents.Abstractions;

public interface IDocumentRenderer
{
    Task<byte[]> RenderAsync<TModel>(
        TModel model,
        RenderSource source,
        CancellationToken cancellationToken = default)
        where TModel : IDocumentModel;

    Task<byte[]> RenderAsync<TModel>(
        TModel model,
        CancellationToken cancellationToken = default)
        where TModel : IDocumentModel;
}
