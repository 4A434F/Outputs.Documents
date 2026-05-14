using System.Reflection;
using Outputs.Documents.Domain;

namespace Outputs.Documents.Domain.Tests;

public sealed class DomainSearchCoverageTests
{
    [Fact]
    public void PublicDomainObjects_DeclareDomainSearchAttribute()
    {
        var missingTypes = typeof(DomainSearchAttribute).Assembly
            .GetExportedTypes()
            .Where(IsDomainObject)
            .Where(type => type.GetCustomAttribute<DomainSearchAttribute>() is null)
            .Select(type => type.FullName)
            .Order(StringComparer.Ordinal)
            .ToArray();

        Assert.True(
            missingTypes.Length == 0,
            $"Domain objects missing {nameof(DomainSearchAttribute)}:{Environment.NewLine}{string.Join(Environment.NewLine, missingTypes)}");
    }

    private static bool IsDomainObject(Type type)
    {
        return type is { IsClass: true, IsAbstract: false } && IsSearchableDomainNamespace(type);
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
