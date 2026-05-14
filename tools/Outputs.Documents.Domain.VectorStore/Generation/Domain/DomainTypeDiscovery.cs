using System.Reflection;
using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.VectorStore.Generation.Domain;

public static class DomainTypeDiscovery
{
    public static IReadOnlyList<Type> GetDomainTypes()
    {
        return typeof(DomainSearchAttribute).Assembly
            .GetExportedTypes()
            .Where(type => type is { IsClass: true, IsAbstract: false })
            .Where(IsSearchableDomainNamespace)
            .Where(type => type.GetCustomAttribute<DomainSearchAttribute>() is not null)
            .OrderBy(type => type.FullName, StringComparer.Ordinal)
            .ToArray();
    }

    private static bool IsSearchableDomainNamespace(Type type)
    {
        return type.Namespace?.StartsWith("Outputs.Documents.Domain.Contracts", StringComparison.Ordinal) == true ||
            type.Namespace?.StartsWith("Outputs.Documents.Domain.Documents", StringComparison.Ordinal) == true ||
            type.Namespace?.StartsWith("Outputs.Documents.Domain.Entities", StringComparison.Ordinal) == true ||
            type.Namespace?.StartsWith("Outputs.Documents.Domain.Expedition", StringComparison.Ordinal) == true ||
            type.Namespace?.StartsWith("Outputs.Documents.Domain.Locations", StringComparison.Ordinal) == true ||
            type.Namespace?.StartsWith("Outputs.Documents.Domain.Payments", StringComparison.Ordinal) == true ||
            type.Namespace?.StartsWith("Outputs.Documents.Domain.Policies", StringComparison.Ordinal) == true;
    }
}
