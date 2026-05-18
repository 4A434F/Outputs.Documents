using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Outputs.Documents.TemplateTestGenerator;

[Generator]
public sealed class DocumentTemplatePdfTestsGenerator : IIncrementalGenerator
{
    private const string DocumentTemplateAttributeName =
        "Outputs.Documents.Abstractions.DocumentTemplateAttribute";

    private const string DocumentModelSampleInterfaceMetadataName =
        "Outputs.Documents.Abstractions.Samples.IDocumentModelSample`1";

    private const string ParameterAttributeName =
        "Microsoft.AspNetCore.Components.ParameterAttribute";

    private static readonly SymbolDisplayFormat TypeFormat =
        SymbolDisplayFormat.FullyQualifiedFormat;

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var generation = context.CompilationProvider.Select(static (compilation, cancellationToken) =>
            BuildGeneration(compilation, cancellationToken));

        context.RegisterSourceOutput(generation, static (productionContext, generatedSources) =>
        {
            foreach (var source in generatedSources)
            {
                productionContext.AddSource(source.HintName, SourceText.From(source.Source, Encoding.UTF8));
            }
        });
    }

    private static ImmutableArray<GeneratedSource> BuildGeneration(
        Compilation compilation,
        CancellationToken cancellationToken)
    {
        var fixture = FindRenderingFixture(compilation, cancellationToken);
        if (fixture is null)
        {
            return ImmutableArray<GeneratedSource>.Empty;
        }

        var templateAttribute = compilation.GetTypeByMetadataName(DocumentTemplateAttributeName);
        var sampleInterface = compilation.GetTypeByMetadataName(DocumentModelSampleInterfaceMetadataName);
        var parameterAttribute = compilation.GetTypeByMetadataName(ParameterAttributeName);
        if (templateAttribute is null || sampleInterface is null || parameterAttribute is null)
        {
            return ImmutableArray<GeneratedSource>.Empty;
        }

        var templates = GetCandidateAssemblies(compilation, ".Templates")
            .SelectMany(assembly => GetAllTypes(assembly.GlobalNamespace, cancellationToken))
            .Select(type => TryCreateTemplate(type, templateAttribute, parameterAttribute))
            .Where(template => template is not null)
            .Cast<TemplateInfo>()
            .OrderBy(template => template.TemplateType.ToDisplayString(), StringComparer.Ordinal)
            .ToArray();

        if (templates.Length == 0)
        {
            return ImmutableArray<GeneratedSource>.Empty;
        }

        var samplesByModel = GetCandidateAssemblies(compilation, ".Contracts")
            .SelectMany(assembly => GetAllTypes(assembly.GlobalNamespace, cancellationToken))
            .Select(type => TryCreateSample(type, sampleInterface))
            .Where(sample => sample is not null)
            .Cast<SampleInfo>()
            .GroupBy(sample => sample.ModelType, SymbolEqualityComparer.Default)
            .ToDictionary(
                group => group.Key,
                group => group
                    .OrderBy(sample => sample.SampleType.Name, StringComparer.Ordinal)
                    .ToArray(),
                SymbolEqualityComparer.Default);

        var generated = ImmutableArray.CreateBuilder<GeneratedSource>();

        var configuration = new GeneratorConfiguration(
            fixture,
            InferOutputPrefix(compilation.AssemblyName),
            $"{SanitizeNamespace(compilation.AssemblyName ?? "Generated")}.Generated",
            "IronPdfTests");

        foreach (var template in templates)
        {
            cancellationToken.ThrowIfCancellationRequested();

            var samples = samplesByModel.TryGetValue(template.ModelType, out var foundSamples)
                ? foundSamples
                : Array.Empty<SampleInfo>();

            generated.Add(CreateSource(compilation.AssemblyName, configuration, template, samples));
        }

        return generated.ToImmutable();
    }

    private static TemplateInfo? TryCreateTemplate(
        INamedTypeSymbol type,
        INamedTypeSymbol templateAttribute,
        INamedTypeSymbol parameterAttribute)
    {
        if (type.TypeKind != TypeKind.Class || type.IsAbstract)
        {
            return null;
        }

        var attribute = type
            .GetAttributes()
            .FirstOrDefault(candidate => SymbolEqualityComparer.Default.Equals(candidate.AttributeClass, templateAttribute));

        if (attribute is null)
        {
            return null;
        }

        var modelParameterName = GetStringNamedArgument(attribute, "ModelParameterName");
        if (string.IsNullOrWhiteSpace(modelParameterName))
        {
            modelParameterName = "Model";
        }

        var modelProperty = type
            .GetMembers(modelParameterName!)
            .OfType<IPropertySymbol>()
            .FirstOrDefault(property =>
                property.DeclaredAccessibility == Accessibility.Public
                && property.GetAttributes().Any(candidate =>
                    SymbolEqualityComparer.Default.Equals(candidate.AttributeClass, parameterAttribute)));

        if (modelProperty is null || modelProperty.Type is not INamedTypeSymbol modelType)
        {
            return null;
        }

        return new TemplateInfo(
            type,
            modelType,
            GetStringNamedArgument(attribute, "Key") ?? CreateKey(type),
            HasPublicParameterlessConstructor(modelType));
    }

    private static SampleInfo? TryCreateSample(
        INamedTypeSymbol type,
        INamedTypeSymbol sampleInterface)
    {
        if (type.TypeKind != TypeKind.Class || type.IsAbstract)
        {
            return null;
        }

        var implementedSample = type.AllInterfaces.FirstOrDefault(candidate =>
            candidate is INamedTypeSymbol named
            && named.IsGenericType
            && SymbolEqualityComparer.Default.Equals(named.ConstructedFrom, sampleInterface));

        if (implementedSample is not INamedTypeSymbol sample || sample.TypeArguments.Length != 1)
        {
            return null;
        }

        if (sample.TypeArguments[0] is not INamedTypeSymbol modelType)
        {
            return null;
        }

        return new SampleInfo(type, modelType);
    }

    private static INamedTypeSymbol? FindRenderingFixture(
        Compilation compilation,
        CancellationToken cancellationToken)
    {
        return GetAllTypes(compilation.Assembly.GlobalNamespace, cancellationToken)
            .Where(type => type.TypeKind == TypeKind.Class && !type.IsAbstract)
            .Where(HasRenderingFixtureShape)
            .OrderBy(type => type.ToDisplayString(), StringComparer.Ordinal)
            .FirstOrDefault();
    }

    private static bool HasRenderingFixtureShape(INamedTypeSymbol type)
    {
        var canRender = type
            .GetMembers("CanRender")
            .OfType<IPropertySymbol>()
            .Any(property =>
                property.DeclaredAccessibility == Accessibility.Public
                && property.Type.SpecialType == SpecialType.System_Boolean);

        if (!canRender)
        {
            return false;
        }

        return type
            .GetMembers("RenderTemplateAsync")
            .OfType<IMethodSymbol>()
            .Any(method =>
                method.DeclaredAccessibility == Accessibility.Public
                && method.TypeParameters.Length == 2
                && method.Parameters.Length >= 2);
    }

    private static GeneratedSource CreateSource(
        string? assemblyName,
        GeneratorConfiguration configuration,
        TemplateInfo template,
        IReadOnlyList<SampleInfo> samples)
    {
        var namespaceName = string.IsNullOrWhiteSpace(configuration.Namespace)
            ? $"{SanitizeNamespace(assemblyName ?? "Generated")}.Generated"
            : configuration.Namespace!;

        var className = $"{SanitizeIdentifier(template.TemplateType.Name)}{configuration.ClassSuffix}";
        var fixtureTypeName = configuration.FixtureType.ToDisplayString(TypeFormat);
        var templateTypeName = template.TemplateType.ToDisplayString(TypeFormat);
        var modelTypeName = template.ModelType.ToDisplayString(TypeFormat);
        var outputPrefix = string.IsNullOrWhiteSpace(configuration.OutputPrefix)
            ? "template"
            : SanitizeFileSegment(configuration.OutputPrefix!);
        var templateKey = SanitizeFileSegment(template.Key);

        var source = new StringBuilder();
        source.AppendLine("// <auto-generated />");
        source.AppendLine("#nullable enable");
        source.AppendLine();
        source.Append("namespace ").Append(namespaceName).AppendLine(";");
        source.AppendLine();
        source.Append("public sealed class ").Append(className).Append('(').Append(fixtureTypeName).AppendLine(" fixture)");
        source.Append("    : global::Xunit.IClassFixture<").Append(fixtureTypeName).AppendLine(">");
        source.AppendLine("{");
        source.AppendLine("    [global::Xunit.Theory]");
        source.AppendLine("    [global::Xunit.Trait(\"Category\", \"Integration\")]");
        source.AppendLine("    [global::Xunit.MemberData(nameof(Models))]");
        source.AppendLine("    public async global::System.Threading.Tasks.Task Template_RendersModelAsPdfWithIron(");
        source.AppendLine("        string caseName,");
        source.Append("        ").Append(modelTypeName).AppendLine(" model)");
        source.AppendLine("    {");
        source.AppendLine("        if (!fixture.CanRender)");
        source.AppendLine("        {");
        source.AppendLine("            return;");
        source.AppendLine("        }");
        source.AppendLine();
        source.Append("        await fixture.RenderTemplateAsync<").Append(templateTypeName).Append(", ").Append(modelTypeName).AppendLine(">(");
        source.AppendLine("            model,");
        source.Append("            $\"").Append(outputPrefix).Append('-').Append(templateKey).AppendLine("-{caseName}.pdf\");");
        source.AppendLine("    }");
        source.AppendLine();
        source.Append("    public static global::Xunit.TheoryData<string, ").Append(modelTypeName).AppendLine("> Models()");
        source.AppendLine("    {");
        source.Append("        return new global::Xunit.TheoryData<string, ").Append(modelTypeName).AppendLine(">");
        source.AppendLine("        {");

        if (template.ModelHasPublicParameterlessConstructor)
        {
            source.Append("            { \"empty\", new ").Append(modelTypeName).AppendLine("() },");
        }

        foreach (var sample in samples)
        {
            var sampleTypeName = sample.SampleType.ToDisplayString(TypeFormat);
            source.Append("            { \"")
                .Append(SanitizeFileSegment(sample.SampleType.Name))
                .Append("\", new ")
                .Append(sampleTypeName)
                .AppendLine("().Create() },");
        }

        source.AppendLine("        };");
        source.AppendLine("    }");
        source.AppendLine("}");

        return new GeneratedSource($"{className}.g.cs", source.ToString());
    }

    private static IEnumerable<IAssemblySymbol> GetCandidateAssemblies(
        Compilation compilation,
        string assemblyNameSuffix)
    {
        return compilation.SourceModule
            .ReferencedAssemblySymbols
            .Where(assembly =>
                assembly.Name.StartsWith("Outputs.Documents.", StringComparison.Ordinal)
                && assembly.Name.EndsWith(assemblyNameSuffix, StringComparison.Ordinal));
    }

    private static IEnumerable<INamedTypeSymbol> GetAllTypes(
        INamespaceSymbol namespaceSymbol,
        CancellationToken cancellationToken)
    {
        foreach (var type in namespaceSymbol.GetTypeMembers())
        {
            cancellationToken.ThrowIfCancellationRequested();

            yield return type;

            foreach (var nestedType in GetNestedTypes(type, cancellationToken))
            {
                yield return nestedType;
            }
        }

        foreach (var childNamespace in namespaceSymbol.GetNamespaceMembers())
        {
            foreach (var type in GetAllTypes(childNamespace, cancellationToken))
            {
                yield return type;
            }
        }
    }

    private static IEnumerable<INamedTypeSymbol> GetNestedTypes(
        INamedTypeSymbol type,
        CancellationToken cancellationToken)
    {
        foreach (var nestedType in type.GetTypeMembers())
        {
            cancellationToken.ThrowIfCancellationRequested();

            yield return nestedType;

            foreach (var childType in GetNestedTypes(nestedType, cancellationToken))
            {
                yield return childType;
            }
        }
    }

    private static bool HasPublicParameterlessConstructor(INamedTypeSymbol type)
    {
        return type.InstanceConstructors.Any(constructor =>
            constructor.DeclaredAccessibility == Accessibility.Public
            && constructor.Parameters.Length == 0);
    }

    private static string? GetStringNamedArgument(AttributeData attribute, string name)
    {
        foreach (var argument in attribute.NamedArguments)
        {
            if (string.Equals(argument.Key, name, StringComparison.Ordinal))
            {
                return argument.Value.Value as string;
            }
        }

        return null;
    }

    private static string CreateKey(INamedTypeSymbol type)
    {
        return type
            .ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)
            .Replace("global::", string.Empty)
            .Replace(".", "-")
            .Replace("+", "-")
            .ToLowerInvariant();
    }

    private static string SanitizeNamespace(string value)
    {
        var parts = value
            .Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(SanitizeIdentifier)
            .Where(part => part.Length > 0)
            .ToArray();

        return parts.Length == 0 ? "Generated" : string.Join(".", parts);
    }

    private static string InferOutputPrefix(string? assemblyName)
    {
        if (string.IsNullOrWhiteSpace(assemblyName))
        {
            return "template";
        }

        var safeAssemblyName = assemblyName!;
        var parts = safeAssemblyName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        for (var index = 0; index < parts.Length; index++)
        {
            if (string.Equals(parts[index], "Documents", StringComparison.Ordinal)
                && index + 1 < parts.Length)
            {
                return SanitizeFileSegment(parts[index + 1]);
            }
        }

        return SanitizeFileSegment(safeAssemblyName);
    }

    private static string SanitizeIdentifier(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return "Generated";
        }

        var builder = new StringBuilder(value.Length);
        for (var index = 0; index < value.Length; index++)
        {
            var current = value[index];
            if (index == 0)
            {
                builder.Append(char.IsLetter(current) || current == '_' ? current : '_');
                continue;
            }

            builder.Append(char.IsLetterOrDigit(current) || current == '_' ? current : '_');
        }

        return builder.ToString();
    }

    private static string SanitizeFileSegment(string value)
    {
        var builder = new StringBuilder(value.Length);
        var previousWasSeparator = false;

        foreach (var current in value)
        {
            if (char.IsLetterOrDigit(current))
            {
                builder.Append(char.ToLowerInvariant(current));
                previousWasSeparator = false;
                continue;
            }

            if (!previousWasSeparator)
            {
                builder.Append('-');
                previousWasSeparator = true;
            }
        }

        return builder.ToString().Trim('-');
    }

    private sealed class GeneratedSource
    {
        public GeneratedSource(string hintName, string source)
        {
            HintName = hintName;
            Source = source;
        }

        public string HintName { get; }

        public string Source { get; }
    }

    private sealed class GeneratorConfiguration
    {
        public GeneratorConfiguration(
            INamedTypeSymbol fixtureType,
            string? outputPrefix,
            string? @namespace,
            string classSuffix)
        {
            FixtureType = fixtureType;
            OutputPrefix = outputPrefix;
            Namespace = @namespace;
            ClassSuffix = classSuffix;
        }

        public INamedTypeSymbol FixtureType { get; }

        public string? OutputPrefix { get; }

        public string? Namespace { get; }

        public string ClassSuffix { get; }
    }

    private sealed class TemplateInfo
    {
        public TemplateInfo(
            INamedTypeSymbol templateType,
            INamedTypeSymbol modelType,
            string key,
            bool modelHasPublicParameterlessConstructor)
        {
            TemplateType = templateType;
            ModelType = modelType;
            Key = key;
            ModelHasPublicParameterlessConstructor = modelHasPublicParameterlessConstructor;
        }

        public INamedTypeSymbol TemplateType { get; }

        public INamedTypeSymbol ModelType { get; }

        public string Key { get; }

        public bool ModelHasPublicParameterlessConstructor { get; }
    }

    private sealed class SampleInfo
    {
        public SampleInfo(INamedTypeSymbol sampleType, INamedTypeSymbol modelType)
        {
            SampleType = sampleType;
            ModelType = modelType;
        }

        public INamedTypeSymbol SampleType { get; }

        public INamedTypeSymbol ModelType { get; }
    }
}
