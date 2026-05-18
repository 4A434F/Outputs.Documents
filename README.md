# Outputs.Documents

Outputs.Documents is a .NET 8 document rendering workspace for transforming typed document contracts into Razor-based HTML and PDF documents.

It separates stable rendering infrastructure, shared document components, origin-specific contracts, and origin-specific templates so each source system can evolve without coupling the core renderer to business document families.

## Status

- Maturity: active development
- Runtime: .NET 8
- Main scope: Razor component templates, HTML rendering, PDF generation, document samples, and provider/origin workspaces
- Important warning: rules and design decisions must be written in this repository, not only remembered from chat

## Fast Start

### Requirements

- .NET 8 SDK
- IronPDF license when running IronPDF integration paths
- Docker only when working with the vector-store MCP server container

### Build

```bash
dotnet build Outputs.Documents.sln
```

### Test

```bash
dotnet test Outputs.Documents.sln
```

### Run Dashboard

```bash
dotnet run --project Apps/src/Outputs.Documents.Dashboard/Outputs.Documents.Dashboard.csproj --launch-profile http
```

Open:

```text
http://localhost:5090
```

## Repository Map

| Path | Purpose |
|---|---|
| `Core/src/` | Stable platform libraries: abstractions, domain concepts, shared components, rendering, PDF providers |
| `Core/tests/` | Tests for stable platform libraries |
| `DOCE/src/` | DOCE contracts and Razor templates |
| `DOCE/tests/` | DOCE template unit and integration tests |
| `FSCD/src/` | FSCD contracts and Razor templates |
| `FSCD/tests/` | FSCD template integration tests |
| `Apps/src/` | Runnable applications such as dashboard and MCP server |
| `Tools/src/` | Reusable development helper libraries and generators |
| `Tools/tests/` | Tool tests |
| `Docs/` | Project documentation, rules, decisions, migration notes, and archived source material |
| `data/domain-vector-dbs/` | Repository-local SQLite vector-store databases |

## Architecture Summary

The production rendering flow is:

1. A caller provides an `IDocumentModel` and `RenderSource`.
2. Registered template descriptors are resolved from Razor component metadata.
3. Selection rules may choose one template for the model and source.
4. The renderer renders the selected Razor component to HTML.
5. Optional header/footer components are rendered from descriptor metadata.
6. A registered `IPdfGenerator` converts the HTML into PDF bytes.

The development preview/test flow can render templates directly through `IRazorComponentRenderer` without the full selector pipeline.

For the complete system explanation, read [Docs/PROJECT.md](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md).

## Usage

Register rendering, templates, samples, and a PDF provider:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(SomeTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(SomeSample).Assembly)
    .WithIronPdfGenerator();
```

Render a document:

```csharp
var pdf = await renderer.RenderAsync(
    model,
    new RenderSource(IsPreview: true),
    cancellationToken);
```

Render a known Razor component directly:

```csharp
var html = await razorRenderer.RenderAsync(
    typeof(SomeTemplate),
    model,
    parameterName: "Model",
    cancellationToken);
```

## Project Rules

Important project rules live in:

- [Docs/RULES.md](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
- [Docs/DECISIONS.md](/Users/thepotato/Code/Outputs.Documents/Docs/DECISIONS.md)

If a rule, decision, or convention is not written in the repository, it should be treated as unstable memory. Agents and developers must not rely on chat history as the source of truth.

## Development Workflow

1. Read the relevant docs before changing behavior.
2. Keep core projects origin-neutral.
3. Keep origin contracts and templates inside their origin workspace.
4. Run the smallest relevant tests first, then broader tests when behavior crosses boundaries.
5. Update documentation when behavior, rules, folder ownership, or registration conventions change.

## Related Documentation

- [Docs/PROJECT.md](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Docs/RULES.md](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
- [Docs/DECISIONS.md](/Users/thepotato/Code/Outputs.Documents/Docs/DECISIONS.md)
- [Docs/provider-layout.md](/Users/thepotato/Code/Outputs.Documents/Docs/provider-layout.md)
