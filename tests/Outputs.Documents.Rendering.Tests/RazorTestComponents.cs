using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace Outputs.Documents.Rendering.Tests;

public sealed class GreetingComponent : ComponentBase
{
    [Parameter]
    public string Name { get; set; } = string.Empty;

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "p");
        builder.AddContent(1, $"Hello {Name}");
        builder.CloseElement();
    }
}

public sealed class ModelEchoComponent : ComponentBase
{
    [Parameter]
    public object Model { get; set; } = default!;

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "p");
        builder.AddContent(1, Model.GetType().Name);
        builder.CloseElement();
    }
}

public sealed class CustomParameterModelEchoComponent : ComponentBase
{
    [Parameter]
    public object Document { get; set; } = default!;

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "p");
        builder.AddContent(1, Document.GetType().Name);
        builder.CloseElement();
    }
}

public sealed class StaticComponent : ComponentBase
{
    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "p");
        builder.AddContent(1, "Static content");
        builder.CloseElement();
    }
}
