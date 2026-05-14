using System.Reflection;
using Outputs.Documents.Domain.VectorStore.Records;

namespace Outputs.Documents.Domain.VectorStore.Descriptors;

public static class DomainEmbeddingDescriptorReader
{
    public static IReadOnlyList<DomainEmbeddingDescriptor> Describe(Type domainType)
    {
        ArgumentNullException.ThrowIfNull(domainType);

        var descriptors = new List<DomainEmbeddingDescriptor>();
        var typeAttribute = domainType.GetCustomAttribute<DomainSearchAttribute>();

        if (typeAttribute is not null)
        {
            descriptors.Add(CreateTypeDescriptor(domainType, typeAttribute));
        }

        descriptors.AddRange(domainType
            .GetProperties(BindingFlags.Instance | BindingFlags.Public)
            .Select(property => CreatePropertyDescriptor(domainType, property))
            .Where(descriptor => descriptor is not null)
            .Select(descriptor => descriptor!));

        if (descriptors.Count == 0)
        {
            throw new InvalidOperationException(
                $"Domain type '{domainType.FullName}' does not declare any {nameof(DomainSearchAttribute)} metadata.");
        }

        return descriptors;
    }

    private static DomainEmbeddingDescriptor CreateTypeDescriptor(
        Type domainType,
        DomainSearchAttribute attribute)
    {
        var declaration = GetDeclaration(domainType);
        var aliases = attribute.Aliases;
        var tags = attribute.Tags;

        return new DomainEmbeddingDescriptor(
            Id: CreateId(EmbeddingRecordKinds.Entity, declaration),
            Kind: EmbeddingRecordKinds.Entity,
            Declaration: declaration,
            Name: attribute.Name,
            Description: attribute.Description,
            Text: CreateEmbeddingText(EmbeddingRecordKinds.Entity, declaration, attribute.Name, attribute.Description, aliases, tags),
            Aliases: aliases,
            Tags: tags,
            Metadata: new Dictionary<string, string>
            {
                ["domainType"] = declaration
            });
    }

    private static DomainEmbeddingDescriptor? CreatePropertyDescriptor(
        Type domainType,
        PropertyInfo property)
    {
        var attribute = property.GetCustomAttribute<DomainSearchAttribute>();

        if (attribute is null)
        {
            return null;
        }

        var domainDeclaration = GetDeclaration(domainType);
        var declaration = $"{domainDeclaration}.{property.Name}";
        var aliases = attribute.Aliases;
        var tags = attribute.Tags;

        return new DomainEmbeddingDescriptor(
            Id: CreateId(EmbeddingRecordKinds.Property, declaration),
            Kind: EmbeddingRecordKinds.Property,
            Declaration: declaration,
            Name: attribute.Name,
            Description: attribute.Description,
            Text: CreateEmbeddingText(EmbeddingRecordKinds.Property, declaration, attribute.Name, attribute.Description, aliases, tags),
            Aliases: aliases,
            Tags: tags,
            Metadata: new Dictionary<string, string>
            {
                ["domainType"] = domainDeclaration,
                ["propertyName"] = property.Name,
                ["propertyType"] = GetDeclaration(property.PropertyType)
            });
    }

    private static string CreateEmbeddingText(
        string kind,
        string declaration,
        string name,
        string description,
        IReadOnlyList<string> aliases,
        IReadOnlyList<string> tags)
    {
        return string.Join(
            " ",
            new[]
            {
                $"Domain {kind}: {name}.",
                $"Declaration: {declaration}.",
                $"Description: {description}.",
                aliases.Count > 0 ? $"Aliases: {string.Join(", ", aliases)}." : null,
                tags.Count > 0 ? $"Tags: {string.Join(", ", tags)}." : null
            }.Where(part => !string.IsNullOrWhiteSpace(part)));
    }

    private static string CreateId(string kind, string declaration)
    {
        return $"{kind.ToLowerInvariant()}:{declaration}";
    }

    private static string GetDeclaration(Type type)
    {
        return type.FullName
            ?? throw new InvalidOperationException($"Type '{type.Name}' does not have a full name.");
    }
}
