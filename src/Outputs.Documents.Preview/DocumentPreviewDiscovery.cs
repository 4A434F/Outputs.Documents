using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Outputs.Documents.Abstractions;
using Outputs.Documents.Preview.Abstractions;

namespace Outputs.Documents.Preview;

public static class DocumentPreviewDiscovery
{
    public static IReadOnlyList<DocumentTemplateDescriptor> DiscoverTemplates(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);

        return assembly
            .DefinedTypes
            .Where(type => !type.IsAbstract && typeof(IComponent).IsAssignableFrom(type))
            .Select(type => type.AsType())
            .Select(CreateDescriptor)
            .Where(descriptor => descriptor is not null)
            .Cast<DocumentTemplateDescriptor>()
            .ToArray();
    }

    public static IReadOnlyList<Type> DiscoverScenarioProviders(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);

        return assembly
            .DefinedTypes
            .Where(type => !type.IsAbstract && !type.IsInterface)
            .Where(type => typeof(IDocumentPreviewScenarioProvider).IsAssignableFrom(type))
            .Select(type => type.AsType())
            .ToArray();
    }

    private static DocumentTemplateDescriptor? CreateDescriptor(Type componentType)
    {
        var template = componentType.GetCustomAttribute<DocumentTemplateAttribute>();
        if (template is null)
        {
            return null;
        }

        var modelParameterName = string.IsNullOrWhiteSpace(template.ModelParameterName)
            ? "Model"
            : template.ModelParameterName;

        var modelParameter = componentType.GetProperty(
            modelParameterName,
            BindingFlags.Instance | BindingFlags.Public);

        if (modelParameter is null)
        {
            throw new InvalidOperationException(
                $"Document template '{componentType.FullName}' declares model parameter '{modelParameterName}', but no public property with that name exists.");
        }

        if (modelParameter.GetCustomAttribute<ParameterAttribute>() is null)
        {
            throw new InvalidOperationException(
                $"Document template '{componentType.FullName}' model property '{modelParameterName}' must be marked with [Parameter].");
        }

        var modelType = modelParameter.PropertyType;
        if (modelType == typeof(object) || modelType == typeof(void))
        {
            throw new InvalidOperationException(
                $"Document template '{componentType.FullName}' model property '{modelParameterName}' has unusable type '{modelType.FullName}'.");
        }

        var layout = componentType.GetCustomAttribute<DocumentLayoutAttribute>();

        return new DocumentTemplateDescriptor(
            modelType,
            componentType,
            template.IsDefault,
            layout?.HeaderTemplateType,
            layout?.FooterTemplateType,
            layout?.HeaderPropertyName,
            layout?.FooterPropertyName,
            layout?.WidthCm,
            layout?.HeightCm,
            modelParameterName)
        {
            Key = string.IsNullOrWhiteSpace(template.Key) ? CreateKey(componentType) : template.Key,
            Name = string.IsNullOrWhiteSpace(template.Name) ? componentType.Name : template.Name,
            Group = string.IsNullOrWhiteSpace(template.Group) ? "Documents" : template.Group,
            HeaderPropertyAccessor = CreateAccessor(modelType, layout?.HeaderPropertyName),
            FooterPropertyAccessor = CreateAccessor(modelType, layout?.FooterPropertyName)
        };
    }

    private static Func<object, object?>? CreateAccessor(Type modelType, string? propertyName)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
        {
            return null;
        }

        var property = modelType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
        if (property is null)
        {
            return null;
        }

        var source = Expression.Parameter(typeof(object), "source");
        var typedSource = Expression.Convert(source, modelType);
        var propertyAccess = Expression.Property(typedSource, property);
        var boxedProperty = Expression.Convert(propertyAccess, typeof(object));
        return Expression.Lambda<Func<object, object?>>(boxedProperty, source).Compile();
    }

    private static string CreateKey(Type type)
    {
        return type.FullName!
            .Replace(".", "-", StringComparison.Ordinal)
            .Replace("+", "-", StringComparison.Ordinal)
            .ToLowerInvariant();
    }
}
