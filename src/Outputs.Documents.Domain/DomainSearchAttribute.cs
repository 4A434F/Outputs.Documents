namespace Outputs.Documents.Domain;

[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Struct |
    AttributeTargets.Interface |
    AttributeTargets.Property |
    AttributeTargets.Parameter,
    AllowMultiple = false)]
public sealed class DomainSearchAttribute : Attribute
{
    public DomainSearchAttribute(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; }

    public string Description { get; }

    public string[] Aliases { get; set; } = [];

    public string[] Tags { get; set; } = [];
}
