using Microsoft.Extensions.DependencyInjection;

namespace Outputs.Documents.Abstractions;

/// <summary>
/// Represents an active Razor document rendering registration chain.
/// </summary>
/// <remarks>
/// This builder is a small context object used only to continue fluent registration after
/// <c>AddRazorDocumentRendering()</c>. It keeps the setup focused on document-rendering
/// concerns, so callers can chain only related extensions such as template discovery,
/// selection rules, and PDF generator registration.
/// </remarks>
/// <example>
/// <code>
/// services
///     .AddRazorDocumentRendering()
///     .WithDocumentsFromAssembly(...)
///     .WithPdfGenerator&lt;TGenerator&gt;();
/// </code>
/// </example>
public sealed class RazorDocumentRenderingBuilder(IServiceCollection services)
{
    /// <summary>
    /// Gets the underlying service collection used by extension packages to add their
    /// document-rendering services to the same registration chain.
    /// </summary>
    public IServiceCollection Services { get; } = services;
}