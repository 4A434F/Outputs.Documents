# Outputs.Documents.TemplateTestGenerator

Build-time source generator for provider template integration tests.

The generator removes repeated test boilerplate by discovering document templates, discovering model samples, finding a rendering fixture, and emitting xUnit theories at compile time.

## Status

- Maturity: development/test helper
- Runtime: .NET Standard 2.0 source generator
- Output: Roslyn analyzer/source generator
- Intended consumers: origin template integration test projects

## Fast Start

Reference this project as an analyzer from a test project:

```xml
<ProjectReference Include="..\..\..\Tools\src\Outputs.Documents.TemplateTestGenerator\Outputs.Documents.TemplateTestGenerator.csproj"
                  OutputItemType="Analyzer"
                  ReferenceOutputAssembly="false" />
```

Build the generator:

```bash
dotnet build Tools/src/Outputs.Documents.TemplateTestGenerator/Outputs.Documents.TemplateTestGenerator.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `DocumentTemplatePdfTestsGenerator.cs` | Incremental generator implementation |
| `README.md` | Usage and ownership notes |

## Architecture Summary

The generator scans the consuming compilation and its references.

It discovers:

- Razor template components marked with `DocumentTemplateAttribute`;
- contract samples implementing `IDocumentModelSample<TModel>`;
- a fixture type with the expected rendering method shape.

For every discovered template it emits one xUnit theory class. Each generated theory renders:

- an `empty` model row when the model has a public parameterless constructor;
- every sample implementing `IDocumentModelSample<TModel>` for the template model type.

## Usage

Create a fixture in the consuming test project:

```csharp
public sealed class TemplateRenderingFixture
{
    public bool CanRender => true;

    public Task<byte[]> RenderTemplateAsync<TTemplate, TModel>(
        TModel model,
        string outputFileName,
        CancellationToken cancellationToken = default)
    {
        // Render template + model to PDF bytes.
    }
}
```

The generator will emit test classes for discovered templates. No assembly-level configuration attribute is required.

## Service Flow

```text
Analyzer reference
  -> generator runs during compilation
  -> finds templates from referenced template assemblies
  -> finds samples from referenced contract assemblies
  -> finds fixture in consuming test project
  -> emits xUnit theories
```

Running all samples for a template model tests the contract shape. Running only related happy-path samples would miss more model/template mismatches.

## Project Rules

- Keep the generator provider-independent.
- Do not register rendering services inside generated code.
- Keep the fixture handwritten and explicit.
- Generated code may use `global::` aliases to avoid namespace collisions.
- Do not emit configuration attributes unless a real configuration need returns.

## Development Workflow

1. Start with the handwritten test shape before changing generation.
2. Update generator tests or consuming integration tests after behavior changes.
3. Inspect emitted files through the consuming project `Generated/` folder when debugging.
4. Update this README when the fixture shape or discovery rules change.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
