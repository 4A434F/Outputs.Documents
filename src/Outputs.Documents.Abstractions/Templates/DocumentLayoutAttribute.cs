namespace Outputs.Documents.Abstractions;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public sealed class DocumentLayoutAttribute : Attribute
{
    public DocumentLayoutAttribute()
    {
    }

    public DocumentLayoutAttribute(
        Type? headerTemplate = null,
        Type? footerTemplate = null,
        string? headerPropertyName = null,
        string? footerPropertyName = null,
        double widthCm = 0,
        double heightCm = 0)
    {
        HeaderTemplateType = headerTemplate;
        FooterTemplateType = footerTemplate;
        HeaderPropertyName = headerPropertyName;
        FooterPropertyName = footerPropertyName;
        WidthCm = widthCm > 0 ? widthCm : null;
        HeightCm = heightCm > 0 ? heightCm : null;
    }

    public Type? HeaderTemplateType { get; }

    public Type? FooterTemplateType { get; }

    public string? HeaderPropertyName { get; }

    public string? FooterPropertyName { get; }

    public double? WidthCm { get; set; }

    public double? HeightCm { get; set; }
}
