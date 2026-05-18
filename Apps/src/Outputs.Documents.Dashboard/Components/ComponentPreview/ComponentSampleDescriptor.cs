namespace Outputs.Documents.Dashboard.Components.ComponentPreview;

public sealed class ComponentSampleDescriptor
{
    public required string Key { get; init; }

    public required string Name { get; init; }

    public required string Group { get; init; }

    public required string Description { get; init; }

    public required Type ComponentType { get; init; }

    public required Dictionary<string, object?> Parameters { get; init; }

    public string PageSize { get; init; } = "Free";
}
