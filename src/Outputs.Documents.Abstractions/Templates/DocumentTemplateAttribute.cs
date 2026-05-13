namespace Outputs.Documents.Abstractions;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class DocumentTemplateAttribute(bool isDefault = false) : Attribute
{
    public bool IsDefault { get; } = isDefault;

    public string ModelParameterName { get; set; } = "Model";

    public string? Key { get; set; }

    public string? Name { get; set; }

    public string? Group { get; set; }
}
