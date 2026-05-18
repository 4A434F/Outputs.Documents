using System.Linq.Expressions;
using System.Reflection;
using Microsoft.AspNetCore.Components;
using Outputs.Documents.Abstractions;

namespace Outputs.Documents.Rendering;

public static class DocumentScanner
{
    public static IReadOnlyList<DocumentTemplateDescriptor> ScanTemplates(Assembly assembly)
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

    public static IReadOnlyList<Type> ScanSelectionRules(Assembly assembly)
    {
        ArgumentNullException.ThrowIfNull(assembly);

        return assembly
            .DefinedTypes
            .Where(type => !type.IsAbstract && !type.IsInterface)
            .Where(type => typeof(IDocumentTemplateSelectionRule).IsAssignableFrom(type))
            .Select(type => type.AsType())
            .ToArray();
    }

    public static DocumentTemplateDescriptor? CreateDescriptor(Type componentType)
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
            if (string.Equals(modelParameterName, "Model", StringComparison.Ordinal))
            {
                ValidateComponent(template.HeaderTemplate, componentType, "header");
                ValidateComponent(template.FooterTemplate, componentType, "footer");

                var noModelWidthCm = template.WidthCm > 0 ? template.WidthCm : (double?)null;
                var noModelHeightCm = template.HeightCm > 0 ? template.HeightCm : (double?)null;

                return new DocumentTemplateDescriptor(
                    typeof(NoDocumentModel),
                    componentType,
                    template.IsDefault,
                    template.HeaderTemplate,
                    template.FooterTemplate,
                    template.HeaderPropertyName,
                    template.FooterPropertyName,
                    noModelWidthCm,
                    noModelHeightCm,
                    modelParameterName)
                {
                    Key = string.IsNullOrWhiteSpace(template.Key) ? CreateKey(componentType) : template.Key,
                    Name = string.IsNullOrWhiteSpace(template.Name) ? componentType.Name : template.Name,
                    Group = string.IsNullOrWhiteSpace(template.Group) ? "Documents" : template.Group
                };
            }

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

        ValidateComponent(template.HeaderTemplate, componentType, "header");
        ValidateComponent(template.FooterTemplate, componentType, "footer");

        var widthCm = template.WidthCm > 0 ? template.WidthCm : (double?)null;
        var heightCm = template.HeightCm > 0 ? template.HeightCm : (double?)null;

        return new DocumentTemplateDescriptor(
            modelType,
            componentType,
            template.IsDefault,
            template.HeaderTemplate,
            template.FooterTemplate,
            template.HeaderPropertyName,
            template.FooterPropertyName,
            widthCm,
            heightCm,
            modelParameterName)
        {
            Key = string.IsNullOrWhiteSpace(template.Key) ? CreateKey(componentType) : template.Key,
            Name = string.IsNullOrWhiteSpace(template.Name) ? componentType.Name : template.Name,
            Group = string.IsNullOrWhiteSpace(template.Group) ? "Documents" : template.Group,
            HeaderPropertyAccessor = CreateAccessor(modelType, template.HeaderPropertyName, componentType, "header"),
            FooterPropertyAccessor = CreateAccessor(modelType, template.FooterPropertyName, componentType, "footer")
        };
    }

    private static string CreateKey(Type type)
    {
        return type.FullName!
            .Replace(".", "-", StringComparison.Ordinal)
            .Replace("+", "-", StringComparison.Ordinal)
            .ToLowerInvariant();
    }

    private static void ValidateComponent(Type? componentType, Type bodyTemplateType, string role)
    {
        if (componentType is not null && !typeof(IComponent).IsAssignableFrom(componentType))
        {
            throw new InvalidOperationException(
                $"Document template '{bodyTemplateType.FullName}' declares {role} template '{componentType.FullName}', but that type does not implement {nameof(IComponent)}.");
        }
    }

    private static Func<object, object?>? CreateAccessor(
        Type modelType,
        string? propertyName,
        Type componentType,
        string role)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
        {
            return null;
        }

        var property = modelType.GetProperty(propertyName, BindingFlags.Instance | BindingFlags.Public);
        if (property is null)
        {
            throw new InvalidOperationException(
                $"Document template '{componentType.FullName}' declares {role} property '{propertyName}', but model '{modelType.FullName}' has no public property with that name.");
        }

        var source = Expression.Parameter(typeof(object), "source");
        var typedSource = Expression.Convert(source, modelType);
        var propertyAccess = Expression.Property(typedSource, property);
        var boxedProperty = Expression.Convert(propertyAccess, typeof(object));
        return Expression.Lambda<Func<object, object?>>(boxedProperty, source).Compile();
    }
}
