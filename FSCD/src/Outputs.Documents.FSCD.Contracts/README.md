# Outputs.Documents.FSCD.Contracts

FSCD copybook contracts and sample data.

This project owns FSCD-specific document models, mostly shaped from BGOW copybooks. It does not render documents and it does not reference Razor templates.

## Status

- Maturity: origin contract library
- Runtime: .NET 8
- Output: class library

## Fast Start

Build from the repository root:

```bash
dotnet build FSCD/src/Outputs.Documents.FSCD.Contracts/Outputs.Documents.FSCD.Contracts.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `BGOW0010Contract/` | FSCD BGOW0010 contract |
| `BGOW0044Contract/` | FSCD cancellation letter contract and samples |
| `BGOW0045Contract/` | FSCD BGOW0045 contract |
| `BGOW0054Contract/` | FSCD BGOW0054 contract |
| `BGOW0055Contract/` | FSCD BGOW0055 contract |
| `BGOW0056Contract/` | FSCD BGOW0056 contract |
| `BGOW0059Contract/` | FSCD BGOW0059 contract |
| `BGOW0060Contract/` | FSCD BGOW0060 contract |
| `BGOW0062Contract/` | FSCD BGOW0062 contract |
| `BGOW0070Contract/` | FSCD BGOW0070 contract |
| `BGOW0078Contract/` | FSCD BGOW0078 contract |
| `FS000CancelationLetter/` | Legacy/minimal cancellation letter contract kept during migration |
| `GlobalUsings.cs` | Shared namespace imports for contract files |

## Architecture Summary

Contracts are grouped by copybook. Reusable field groups should compose shared domain types instead of duplicating raw strings.

```text
BGOW0044 copybook
  -> BGOW0044Contract
  -> shared domain objects where possible
  -> samples beside the contract
```

## Usage

Create or update a contract:

```csharp
public sealed class BGOW0044Contract : IDocumentModel
{
}
```

Create a sample beside it:

```csharp
public sealed class FS1040PremiumCancellationSample
    : IDocumentModelSample<BGOW0044Contract>
{
    public BGOW0044Contract Create() => new();
}
```

## Service Flow

```text
Copybook structure
  -> meaningful groups
  -> shared domain objects or copybook-specific fields
  -> contract model
  -> samples
  -> template and generated integration tests
```

## Project Rules

- Do not reference templates.
- Do not reference rendering, PDF providers, dashboard, or tools.
- Keep contracts pure and source-system focused.
- Use `IDocumentModel` for renderable contracts.
- Put samples beside the contract they create.
- Add copybook names to aliases/tags when annotating reusable domain fields.
- Reuse `Outputs.Documents.Domain` types for shared structures such as entity, address, policy, premium, coverage, and payment.

## Related Documentation

- [FSCD workspace README](/Users/thepotato/Code/Outputs.Documents/FSCD/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
