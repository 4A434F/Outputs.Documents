# FSCD Workspace

FSCD contains source-system contracts, Razor templates, samples, and tests for FSCD documents.

This folder is shaped like a future standalone repository while still referencing the shared `Core/src` projects from this repo.

## Status

- Maturity: origin workspace
- Runtime: .NET 8
- Current projects: FSCD contracts, FSCD templates, template integration tests

## Fast Start

Build FSCD projects:

```bash
dotnet build FSCD/src/Outputs.Documents.FSCD.Contracts/Outputs.Documents.FSCD.Contracts.csproj
dotnet build FSCD/src/Outputs.Documents.FSCD.Templates/Outputs.Documents.FSCD.Templates.csproj
```

Run FSCD integration tests:

```bash
dotnet test FSCD/tests/Outputs.Documents.FSCD.Templates.IntegrationTests/Outputs.Documents.FSCD.Templates.IntegrationTests.csproj
```

## Workspace Map

| Path | Purpose |
|---|---|
| `src/Outputs.Documents.FSCD.Contracts/` | FSCD copybook contracts and samples |
| `src/Outputs.Documents.FSCD.Templates/` | FSCD Razor templates and selection rules |
| `tests/Outputs.Documents.FSCD.Templates.IntegrationTests/` | Generated PDF rendering integration tests |

## Architecture Summary

```text
FSCD copybook contract + sample
  -> FSCD template/rule
  -> shared components/layouts
  -> rendering tests or host app
```

Contracts do not depend on templates. Templates depend on contracts and shared components.

## Usage

Register FSCD templates and samples:

```csharp
services
    .AddRazorDocumentRendering()
    .WithDocumentsFromAssembly(typeof(FS1040CancellationCdc1PremiumTemplate).Assembly)
    .WithSamplesFromAssembly(typeof(FS1040PremiumCancellationSample).Assembly);
```

## Project Rules

- Put FSCD copybook contracts in the FSCD contracts project.
- Put FSCD-specific templates and selection rules in the FSCD templates project.
- Put sample data beside the contract it creates.
- Do not put reusable rendering or component code here.
- Reuse `Outputs.Documents.Domain` concepts when a field group is shared.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Provider layout](/Users/thepotato/Code/Outputs.Documents/Docs/provider-layout.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
