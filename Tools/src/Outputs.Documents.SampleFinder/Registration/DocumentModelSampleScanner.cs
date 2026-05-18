using System.Reflection;
using Outputs.Documents.Abstractions.Samples;

namespace Outputs.Documents.SampleFinder;

public static class DocumentModelSampleScanner
{
    public static IReadOnlyList<DocumentModelSampleDescriptor> ScanSamples(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);

        return assembly
            .DefinedTypes
            .Where(type => !type.IsAbstract && !type.IsInterface)
            .Select(CreateDescriptor)
            .Where(descriptor => descriptor is not null)
            .Cast<DocumentModelSampleDescriptor>()
            .OrderBy(descriptor => descriptor.ModelType.FullName, StringComparer.OrdinalIgnoreCase)
            .ThenBy(descriptor => descriptor.Name, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static DocumentModelSampleDescriptor? CreateDescriptor(TypeInfo sampleType)
    {
        var sampleInterface = sampleType
            .ImplementedInterfaces
            .FirstOrDefault(type =>
                type.IsGenericType &&
                type.GetGenericTypeDefinition() == typeof(IDocumentModelSample<>));

        if (sampleInterface is null)
        {
            return null;
        }

        var modelType = sampleInterface.GetGenericArguments()[0];
        return new DocumentModelSampleDescriptor(
            CreateName(sampleType.Name),
            modelType,
            sampleType.AsType());
    }

    private static string CreateName(string typeName)
    {
        var name = typeName.EndsWith("Sample", StringComparison.Ordinal)
            ? typeName[..^"Sample".Length]
            : typeName;

        var characters = new List<char>();
        for (var index = 0; index < name.Length; index++)
        {
            var character = name[index];
            if (index > 0 && char.IsUpper(character))
            {
                characters.Add(' ');
            }

            characters.Add(character);
        }

        return new string(characters.ToArray());
    }
}
