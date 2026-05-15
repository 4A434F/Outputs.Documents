# Outputs.Documents

Outputs.Documents is a .NET 8 Razor document rendering solution.

The solution is organized around one important boundary:

- `src/` contains stable platform libraries.
- `origins/` contains origin-specific contracts and templates.

That split is intentional. Stable projects should not churn every time a copybook, template, or origin-system contract changes. Origin projects are allowed to move faster.

## Top-Level Layout

```text
apps/
  Outputs.Documents.Dashboard/
  Outputs.Documents.Domain.VectorStore.McpServer/

src/
  Outputs.Documents.Abstractions/
  Outputs.Documents.Domain/
  Outputs.Documents.Rendering/
  Outputs.Documents.Rendering.Iron/
  Outputs.Documents.SampleFinder/
  Outputs.Documents.Components/

origins/
  Outputs.Documents.DOCE.Contracts/
  Outputs.Documents.DOCE.Templates/
  Outputs.Documents.FSCD.Contracts/
  Outputs.Documents.FSCD.Templates/

tools/
  Outputs.Documents.Domain.VectorStore/

tests/
  Outputs.Documents.Domain.Tests/
  Outputs.Documents.Domain.VectorStore.Tests/
  Outputs.Documents.Rendering.Tests/
  Outputs.Documents.Rendering.Iron.Tests/
  Outputs.Documents.DOCE.Templates.Tests/

data/
  domain-vector-dbs/

archive/
  migration notes, generated reports, old source material
```

## Naming Rules

Project names follow this pattern:

```text
Outputs.Documents.<Capability>
Outputs.Documents.<Origin>.<Capability>
```

Examples:

```text
Outputs.Documents.Rendering
Outputs.Documents.SampleFinder
Outputs.Documents.DOCE.Contracts
Outputs.Documents.FSCD.Templates
```

Physical folders do not always appear in namespaces. `origins/` is a repository boundary, not a product namespace.

Good:

```csharp
namespace Outputs.Documents.DOCE.Contracts;
namespace Outputs.Documents.FSCD.Templates;
```

Avoid:

```csharp
namespace Outputs.Documents.Origins.DOCE.Contracts;
```

## Stable Platform Projects

Stable projects live in `src/`.

### Outputs.Documents.Abstractions

Public contracts for rendering and template registration.

See [src/Outputs.Documents.Abstractions/README.md](src/Outputs.Documents.Abstractions/README.md).

Contains:

- `IDocumentModel`
- `IDocumentRenderer`
- `IRazorComponentRenderer`
- `IPdfGenerator`
- `RenderSource`
- `DocumentTemplateAttribute`
- `DocumentTemplateDescriptor`
- template registry and selector interfaces
- `RazorDocumentRenderingBuilder`

### Outputs.Documents.Domain

Reusable origin-neutral domain concepts.

See [src/Outputs.Documents.Domain/README.md](src/Outputs.Documents.Domain/README.md).

Contains concepts such as:

- document information
- headers and footers
- entities and contact details
- postal addresses
- policy references
- premiums
- coverages
- risks
- payment references
- `DomainSearchAttribute`

### Outputs.Documents.Rendering

Generic rendering implementation.

See [src/Outputs.Documents.Rendering/README.md](src/Outputs.Documents.Rendering/README.md).

Contains:

- Razor component to HTML rendering
- template scanning
- template catalog/registry
- template selection
- document rendering orchestration

### Outputs.Documents.Rendering.Iron

IronPDF provider for `IPdfGenerator`.

See [src/Outputs.Documents.Rendering.Iron/README.md](src/Outputs.Documents.Rendering.Iron/README.md).

### Outputs.Documents.SampleFinder

Sample model discovery and catalog infrastructure.

See [tools/Outputs.Documents.SampleFinder/README.md](tools/Outputs.Documents.SampleFinder/README.md).

Important: this project does not contain actual sample data. Actual samples live beside the contract they construct.

### Outputs.Documents.Components

Shared Razor components and layouts.

See [src/Outputs.Documents.Components/README.md](src/Outputs.Documents.Components/README.md).

Concrete origin templates do not live here.

## Origin Projects

Origin projects live in `origins/`.

Origin projects are intentionally separated from `src/` because they are tied to external source systems, copybooks, document layouts, and migration decisions.

### Outputs.Documents.DOCE.Contracts

DOCE-specific document contracts and sample data.

Shape:

```text
origins/Outputs.Documents.DOCE.Contracts/
  DC000CoverPage/
    DC000CoverPage.cs
    Samples/
      DefaultCoverPageSample.cs
```

Contract namespace:

```csharp
namespace Outputs.Documents.DOCE.Contracts;
```

Sample namespace:

```csharp
namespace Outputs.Documents.DOCE.Contracts.Samples.DC000CoverPage;
```

Samples are stored beside the contract file, but the namespace places `Samples` before the contract name. That avoids a C# namespace/type collision with the contract type itself.

Rules:

- Put DOCE-specific contract models here.
- Put sample data beside the contract it creates.
- Do not reference templates, rendering, dashboard, or PDF providers.
- Reuse stable domain types from `Outputs.Documents.Domain` when a structure is shared.

### Outputs.Documents.DOCE.Templates

DOCE-specific Razor templates.

Rules:

- Put concrete DOCE templates here.
- Reference `Outputs.Documents.DOCE.Contracts`.
- Reference shared components from `Outputs.Documents.Components`.
- Do not put sample data here.

### Outputs.Documents.FSCD.Contracts

FSCD-specific document contracts and sample data.

Shape:

```text
origins/Outputs.Documents.FSCD.Contracts/
  BGOW0044Contract/
    BGOW0044Contract.cs
    Samples/
      FS1040PremiumCancellationSample.cs
```

Rules match DOCE contracts:

- Put FSCD-specific contract models here.
- Put sample data beside the contract it creates.
- Do not reference templates, rendering, dashboard, or PDF providers.
- Reuse stable domain types from `Outputs.Documents.Domain` when a structure is shared.

### Outputs.Documents.FSCD.Templates

FSCD-specific Razor templates.

Rules match DOCE templates:

- Put concrete FSCD templates here.
- Reference `Outputs.Documents.FSCD.Contracts`.
- Reference shared components from `Outputs.Documents.Components`.
- Do not put sample data here.

## Apps

### Outputs.Documents.Dashboard

Development UI host.

Currently used to preview discovered Razor document templates and sample models.

Expected references:

- stable rendering projects
- stable sample catalog project
- selected origin contract/template projects

### Outputs.Documents.Domain.VectorStore.McpServer

MCP server host for the domain vector store.

This is an app because it exposes the vector store through an external protocol.

## Tools

### Outputs.Documents.Domain.VectorStore

Developer tool/library for semantic domain search storage and generation helpers.

This lives under `tools/` because it supports development workflows. It is not part of the production document rendering runtime.

## Dependency Direction

Preferred direction:

```text
Abstractions
  ↑
Domain
  ↑
Samples
  ↑
Origin Contracts
  ↑
Origin Templates
  ↑
Apps
```

Rendering references abstractions and domain concepts, but must not reference origin projects:

```text
Rendering -> Abstractions
Rendering -> Domain
Rendering -> Samples only when registration extension requires it? Avoid when possible.
```

Provider projects depend on abstractions:

```text
Rendering.Iron -> Abstractions
```

Avoid:

```text
src/* -> origins/*
Abstractions -> Rendering
Domain -> Templates
Contracts -> Templates
Contracts -> Rendering
Templates -> Dashboard
```

## Registration Flow

A host composes the stable rendering system with origin assemblies:

```csharp
builder.Services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithDocumentsFromAssembly(typeof(FS1040CancellationCdc1PremiumTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(DC000CoverPage).Assembly)
    .WithSamplesFromAssembly(typeof(BGOW0044Contract).Assembly);
```

Template discovery scans origin template assemblies.

Sample discovery scans origin contract assemblies.

## Validation

Use single-node MSBuild in this environment to avoid local named-pipe permission errors:

```bash
dotnet test Outputs.Documents.sln --no-restore /m:1 /nr:false
```

If project paths changed, restore the affected project first. Static graph restore may report a local macOS `CSSM_ModuleLoad()` message while still generating assets:

```bash
dotnet restore tools/Outputs.Documents.SampleFinder/Outputs.Documents.SampleFinder.csproj /p:RestoreUseStaticGraphEvaluation=true
```
