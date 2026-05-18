using Microsoft.AspNetCore.Components;

namespace Outputs.Documents.Abstractions.Rendering;

public interface IRazorComponentRenderer
{
    Task<string> RenderAsync(
        Type componentType,
        IReadOnlyDictionary<string, object?>? parameters = null,
        CancellationToken cancellationToken = default);

    Task<string> RenderAsync<TComponent>(
        IReadOnlyDictionary<string, object?>? parameters = null,
        CancellationToken cancellationToken = default)
        where TComponent : IComponent;

    Task<string> RenderAsync<TComponent>(
        object model,
        string parameterName = "Model",
        CancellationToken cancellationToken = default)
        where TComponent : IComponent;

    Task<string> RenderAsync(
        Type componentType,
        object model,
        string parameterName = "Model",
        CancellationToken cancellationToken = default);
}
