# Outputs.Documents.DOCE.Contracts

DOCE document contracts and sample data.

This project owns DOCE-specific API/document models. It does not render documents and it does not reference Razor templates.

## Status

- Maturity: origin contract library
- Runtime: .NET 8
- Output: class library

## Fast Start

Build from the repository root:

```bash
dotnet build DOCE/src/Outputs.Documents.DOCE.Contracts/Outputs.Documents.DOCE.Contracts.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `DC000CoverPage/` | Cover page contract and samples |
| `DC001CourtesyLetter/` | Courtesy letter contract and samples |
| `DC002Divider/` | Divider contract and samples |
| `DC003CttDispatchSheet/` | CTT dispatch sheet contract and samples |
| `DC004DeliveryNote/` | Delivery note contract and samples |
| `DC005RegTicketPage/` | Registered ticket page contract and samples |
| `GlobalUsings.cs` | Shared namespace imports for contract files |

## Architecture Summary

Each contract folder contains the contract and its samples.

```text
DC001CourtesyLetter/
  DC001CourtesyLetter.cs
  Samples/
    DefaultCourtesyLetterSample.cs
```

Samples are colocated with the contract because they validate that contract shape. They are discovered by `Outputs.Documents.SampleFinder`.

## Usage

Create a contract:

```csharp
public sealed class DC001CourtesyLetter : IDocumentModel
{
}
```

Create a sample beside it:

```csharp
public sealed class DefaultCourtesyLetterSample
    : IDocumentModelSample<DC001CourtesyLetter>
{
    public DC001CourtesyLetter Create() => new();
}
```

## Service Flow

```text
Contract model
  -> sample data builder
  -> template model parameter
  -> generated integration tests
```

## Project Rules

- Do not reference templates.
- Do not reference rendering, PDF providers, dashboard, or tools.
- Keep contracts pure and serializable where possible.
- Use `IDocumentModel` for renderable contracts.
- Put samples beside the contract they create.
- Reuse `Outputs.Documents.Domain` types for shared document concepts.

## Related Documentation

- [DOCE workspace README](/Users/thepotato/Code/Outputs.Documents/DOCE/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
