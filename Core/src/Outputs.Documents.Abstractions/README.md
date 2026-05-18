# Outputs.Documents.Abstractions

Stable public contracts for the document rendering stack.

This project defines the small surface area that contracts, templates, rendering implementations, tools, and apps can safely share. It must stay free of concrete DOCE/FSCD types, Razor component implementations, PDF provider implementations, storage, and dashboard concerns.

## Status

- Maturity: core platform library
- Runtime: .NET 8
- Output: class library
- Stability expectation: high; changes here ripple through almost every project

## Fast Start

Reference this project from contracts, templates, rendering implementations, tools, or apps that need document rendering abstractions.

Build from the repository root:

```bash
dotnet build Core/src/Outputs.Documents.Abstractions/Outputs.Documents.Abstractions.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Models/` | Shared document model contracts such as `IDocumentModel` and `NoDocumentModel` |
| `Registration/` | Cross-project fluent registration builder |
| `Rendering/` | Rendering contracts and render request context |
| `Samples/` | Sample authoring contract used by origin contract projects |
| `Templates/` | Template metadata, descriptors, registry, selector, and rule contracts |

## Architecture Summary

This project is the shared language of the system. Implementation projects consume these contracts but this project does not consume implementation projects.

Allowed dependency direction:

```text
Rendering -> Abstractions
Components -> Abstractions
Origin Contracts -> Abstractions
Origin Templates -> Abstractions
Apps -> Abstractions
Tools -> Abstractions
```

Avoid:

```text
Abstractions -> Rendering
Abstractions -> Origin Contracts
Abstractions -> Apps
Abstractions -> Tools
```

## Usage

Declare a renderable document model:

```csharp
public sealed class SomeDocumentModel : IDocumentModel
{
}
```

Declare a sample beside a contract:

```csharp
public sealed class DefaultSomeDocumentSample
    : IDocumentModelSample<SomeDocumentModel>
{
    public SomeDocumentModel Create() => new();
}
```

Use the shared rendering builder from other extension methods:

```csharp
public static RazorDocumentRenderingBuilder WithSomething(
    this RazorDocumentRenderingBuilder builder)
{
    builder.Services.AddSingleton<Something>();
    return builder;
}
```

## Service Flow

```text
Host
  -> AddRazorDocumentRendering()
  -> RazorDocumentRenderingBuilder
  -> WithDocumentsFromAssembly(...)
  -> WithSamplesFromAssembly(...)
  -> WithPdfGenerator(...)
```

`RazorDocumentRenderingBuilder` exists so rendering, templates, sample discovery, and PDF providers can extend one fluent registration chain without forcing those implementation projects to reference each other.

## Project Rules

- Keep interfaces small and stable.
- Do not reference origin projects.
- Do not reference concrete PDF providers.
- Do not place Razor components here.
- Do not place scanner implementations here.
- Do not place domain business structures here unless they are true rendering abstractions.
- The template component type is the production template identity.
- Do not add string template keys for production selection.

## Development Workflow

1. Check [Docs/RULES.md](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md) before changing public contracts.
2. Update all affected implementation projects and tests.
3. Prefer additive changes when possible.
4. Update this README when folder ownership or usage changes.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
