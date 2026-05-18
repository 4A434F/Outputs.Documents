# Outputs.Documents.SampleFinder

Sample model discovery and catalog infrastructure.

This project finds sample builders from origin contract assemblies. It does not contain actual sample data. Actual samples live beside the contract they construct.

## Status

- Maturity: development/helper library
- Runtime: .NET 8
- Output: class library
- Intended consumers: tests, dashboard/preview tools, and development workflows

## Fast Start

Reference this project from a host or test fixture that needs sample discovery.

Build from the repository root:

```bash
dotnet build Tools/src/Outputs.Documents.SampleFinder/Outputs.Documents.SampleFinder.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Registration/` | Assembly scanner and `.WithSamplesFromAssembly(...)` extension |
| `Samples/` | Catalog, catalog collection, descriptor, and lookup abstractions |

## Architecture Summary

Sample authoring and sample discovery are intentionally split.

```text
Origin contract project
  -> implements IDocumentModelSample<TModel>
  -> SampleFinder scans the assembly
  -> DocumentModelSampleCatalog stores descriptors
  -> tests/UI ask the catalog for samples
```

The authoring interface lives in `Outputs.Documents.Abstractions` so origin contracts do not depend on this tool project.

## Usage

Register samples in the same fluent rendering chain:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(SomeTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(SomeSample).Assembly);
```

Implement a sample beside the contract:

```csharp
public sealed class DefaultSomeDocumentSample
    : IDocumentModelSample<SomeDocumentModel>
{
    public SomeDocumentModel Create() => new();
}
```

## Service Flow

```text
WithSamplesFromAssembly(assembly)
  -> DocumentModelSampleScanner.ScanSamples(assembly)
  -> DocumentModelSampleCatalog for that assembly
  -> IDocumentModelSampleCatalog = DocumentModelSampleCatalogCollection
```

Multiple assemblies can register their own catalog. The collection composes them.

## Project Rules

- Do not put sample data classes here.
- Do not reference origin projects.
- Do not reference rendering, components, dashboard, or PDF providers unless a future use case explicitly requires it.
- Keep sample discovery assembly-based.
- Keep sample classes simple data builders.

## Development Workflow

1. Change sample authoring contracts in `Outputs.Documents.Abstractions`.
2. Change discovery/catalog behavior here.
3. Add tests when discovery rules change.
4. Update this README when the sample registration flow changes.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
