namespace Outputs.Documents.Abstractions;

public sealed record DocumentTemplateDescriptor(
    Type ModelType,
    Type BodyTemplateType,
    bool IsDefault,
    Type? HeaderTemplateType,
    Type? FooterTemplateType,
    string? HeaderPropertyName,
    string? FooterPropertyName,
    double? WidthCm,
    double? HeightCm,
    string ModelParameterName)
{
    public string Key { get; init; } = CreateKey(BodyTemplateType);

    public string Name { get; init; } = BodyTemplateType.Name;

    public string Group { get; init; } = "Documents";

    public Func<object, object?>? HeaderPropertyAccessor { get; init; }

    public Func<object, object?>? FooterPropertyAccessor { get; init; }

    private static string CreateKey(Type type)
    {
        return type.FullName!
            .Replace(".", "-", StringComparison.Ordinal)
            .Replace("+", "-", StringComparison.Ordinal)
            .ToLowerInvariant();
    }
}
