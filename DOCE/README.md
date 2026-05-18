# DOCE Workspace

DOCE contains source-system contracts, Razor templates, samples, and tests for DOCE documents.

This folder is shaped like a future standalone repository while still referencing the shared `Core/src` projects from this repo.

## Status

- Maturity: origin workspace
- Runtime: .NET 8
- Current projects: DOCE contracts, DOCE templates, template unit tests, template integration tests

## Fast Start

Build DOCE projects:

```bash
dotnet build DOCE/src/Outputs.Documents.DOCE.Contracts/Outputs.Documents.DOCE.Contracts.csproj
dotnet build DOCE/src/Outputs.Documents.DOCE.Templates/Outputs.Documents.DOCE.Templates.csproj
```

Run DOCE tests:

```bash
dotnet test DOCE/tests/Outputs.Documents.DOCE.Templates.UnitTests/Outputs.Documents.DOCE.Templates.UnitTests.csproj
dotnet test DOCE/tests/Outputs.Documents.DOCE.Templates.IntegrationTests/Outputs.Documents.DOCE.Templates.IntegrationTests.csproj
```

## Workspace Map

| Path | Purpose |
|---|---|
| `src/Outputs.Documents.DOCE.Contracts/` | DOCE document contracts and samples |
| `src/Outputs.Documents.DOCE.Templates/` | DOCE Razor templates |
| `tests/Outputs.Documents.DOCE.Templates.UnitTests/` | Template registration/scanning tests |
| `tests/Outputs.Documents.DOCE.Templates.IntegrationTests/` | Generated PDF rendering integration tests |

## Architecture Summary

```text
DOCE contract + sample
  -> DOCE template
  -> shared components/layouts
  -> rendering tests or host app
```

Contracts do not depend on templates. Templates depend on contracts and shared components.

## Usage

Register DOCE templates and samples:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(CourtesyLetterTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(DefaultCourtesyLetterSample).Assembly);
```

## Project Rules

- Put DOCE-specific contracts in the DOCE contracts project.
- Put DOCE-specific templates in the DOCE templates project.
- Put sample data beside the contract it creates.
- Do not put reusable rendering or component code here.
- Reuse `Outputs.Documents.Domain` concepts when a field group is shared.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Provider layout](/Users/thepotato/Code/Outputs.Documents/Docs/provider-layout.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
