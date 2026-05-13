using Microsoft.Extensions.DependencyInjection;

namespace Outputs.Documents.Preview.Abstractions;

/// <summary>
/// Keeps document preview registration in a domain-specific chain so template and scenario
/// discovery stays consistent at application startup instead of being mixed with unrelated
/// service registrations.
/// </summary>
public sealed class RazorDocumentPreviewBuilder(IServiceCollection services)
{
    public IServiceCollection Services { get; } = services;
}
