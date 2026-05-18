# Outputs.Documents.Domain

Stable shared domain concepts for document contracts.

This project contains reusable insurance and document concepts that are independent from any one origin system. Origin-specific copybook contracts live under `DOCE/src/`, `FSCD/src/`, and future origin workspaces.

## Status

- Maturity: core platform library
- Runtime: .NET 8
- Output: class library
- Stability expectation: high; types here should be reusable across origins

## Fast Start

Reference this project from origin contract projects when a contract needs a reusable business concept.

Build from the repository root:

```bash
dotnet build Core/src/Outputs.Documents.Domain/Outputs.Documents.Domain.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Documents/` | Document information, trace id, headers, footers, and document primitives |
| `Entities/` | Entity, contact, person, and party concepts |
| `Expedition/` | Dispatch, registration, and expedition concepts |
| `Locations/` | Postal address and location concepts |
| `Payments/` | Bank account and ATM/Multibanco payment references |
| `Policies/` | Policy, product, premium, coverage, and risk concepts |
| `DomainSearchAttribute.cs` | Semantic metadata used by vector-store indexing |

## Architecture Summary

The domain project is reusable vocabulary. It is not a contract dump and it is not a rendering project.

Use it when a concept is shared or likely to be shared:

- postal address;
- entity or person;
- policy reference;
- product reference;
- premium;
- coverage;
- risk detail;
- bank account;
- payment reference.
- simple document tables.

Keep fields in an origin contract when they are specific to one source-system layout or one copybook.

## Usage

Use domain concepts inside origin contracts:

```csharp
public sealed class SomeOriginContract : IDocumentModel
{
    public DocumentInformation DocumentInformation { get; init; } = new();

    public Entity Client { get; init; } = new();

    public Policy Policy { get; init; } = new();
}
```

Add semantic search metadata to reusable types and properties:

```csharp
[DomainSearch(
    "Postal address",
    "Postal address block for a recipient, client, agent, or business entity.",
    Aliases = ["morada", "address"],
    Tags = ["address", "postal"])]
public sealed class PostalAddress
{
}
```

Use a simple table primitive when a contract needs rows and totals without render formatting rules. Headers and column layout belong to the template that renders the table:

```csharp
var table = new DocumentValueTable
{
    Rows =
    [
        new DocumentValueTableRow { Cells = ["Prémio", 65.42m] }
    ],
    Totals =
    [
        new DocumentValueTableRow { Cells = ["Total", 65.42m] }
    ]
};
```

## Service Flow

```text
Origin copybook analysis
  -> identify reusable concept
  -> reuse or add Domain type
  -> annotate with DomainSearchAttribute
  -> origin contract composes the type
  -> vector-store tools can describe and index it
```

## Project Rules

- Keep this project origin-neutral.
- Do not add Razor, rendering, PDF, dashboard, storage, or DI code.
- Do not put DOCE/FSCD copybook contract classes here.
- Do not put sample data here.
- Add `DomainSearchAttribute` to searchable reusable classes and properties.
- Prefer meaningful reusable business concepts over raw copybook field dumps.

## Development Workflow

1. Check whether the concept is reusable across origins.
2. Prefer improving an existing domain type over creating duplicates.
3. Add aliases/tags when copybook field names improve search.
4. Run domain and vector-store tests when changing annotations or domain shape.
5. Update docs when a new domain area or ownership rule appears.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
