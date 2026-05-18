using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Extensions.DependencyInjection;
using Outputs.Documents.Abstractions.Rendering;

namespace Outputs.Documents.Rendering.Razor;

public sealed class RazorComponentHtmlRenderer(IServiceProvider root)
    : IRazorComponentRenderer
{
    public Task<string> RenderAsync<TComponent>(
        IReadOnlyDictionary<string, object?>? parameters = null,
        CancellationToken cancellationToken = default)
        where TComponent : IComponent
    {
        return RenderAsync(typeof(TComponent), parameters, cancellationToken);
    }

    public Task<string> RenderAsync<TComponent>(
        object model,
        string parameterName = "Model",
        CancellationToken cancellationToken = default)
        where TComponent : IComponent
    {
        return RenderAsync(typeof(TComponent), model, parameterName, cancellationToken);
    }

    public Task<string> RenderAsync(
        Type componentType,
        object model,
        string parameterName = "Model",
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(model);

        var parameters = new Dictionary<string, object?>
        {
            [parameterName] = model
        };

        return RenderAsync(componentType, parameters, cancellationToken);
    }

    public async Task<string> RenderAsync(
        Type componentType,
        IReadOnlyDictionary<string, object?>? parameters = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(componentType);

        if (!typeof(IComponent).IsAssignableFrom(componentType))
        {
            throw new ArgumentException(
                $"Type '{componentType.FullName}' must implement {nameof(IComponent)}.",
                nameof(componentType));
        }

        cancellationToken.ThrowIfCancellationRequested();

        await using var scope = root.CreateAsyncScope();

        var renderer = scope.ServiceProvider.GetRequiredService<HtmlRenderer>();

        var parameterDictionary = parameters is null
            ? new Dictionary<string, object?>()
            : new Dictionary<string, object?>(parameters);

        var view = ParameterView.FromDictionary(parameterDictionary);

        return await renderer.Dispatcher.InvokeAsync(async () =>
        {
            cancellationToken.ThrowIfCancellationRequested();

            var rendered = await renderer.RenderComponentAsync(componentType, view);
            return rendered.ToHtmlString();
        });
    }
}
