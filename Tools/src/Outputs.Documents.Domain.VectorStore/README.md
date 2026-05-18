# Outputs.Documents.Domain.VectorStore

Storage-only SQLite repository for domain semantic search records.

This project does not create embeddings. Callers ask the store to describe a C# domain type, generate embeddings elsewhere for the returned descriptor text, then register those embeddings back against the same domain type.

## Status

- Maturity: development/helper library
- Runtime: .NET 8
- Output: class library
- Database: SQLite, one database per embedding model
- Important warning: embedding generation belongs outside this project

## Fast Start

Build from the repository root:

```bash
dotnet build Tools/src/Outputs.Documents.Domain.VectorStore/Outputs.Documents.Domain.VectorStore.csproj
```

Run focused tests:

```bash
dotnet test Tools/tests/Outputs.Documents.Domain.VectorStore.UnitTests/Outputs.Documents.Domain.VectorStore.UnitTests.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Alignment/` | Fixed alignment prompts and alignment check models |
| `Descriptors/` | Domain descriptors created from `DomainSearchAttribute` |
| `Generation/` | Optional generation workflow and embedding provider adapters |
| `Records/` | Persisted embedding record models and record kind constants |
| `Search/` | Exact, vector, and hybrid search result models |
| `Storage/` | SQLite repository, database routing, and options |
| `Utilities/` | Hashing, vector serialization, normalization, and vector math |

## Architecture Summary

The store is a repository, not an encoder.

```text
C# domain type
  -> Describe(Type)
  -> caller embeds descriptor.Text
  -> UpsertAsync(modelName, domainType, embeddings)
  -> SQLite database for modelName
  -> exact/vector/hybrid search
```

The C# type remains the source of truth for metadata. `UpsertAsync` re-reads descriptors from the type and rejects missing or unknown embedding values.

## Usage

Describe a domain type:

```csharp
var descriptors = store.Describe(typeof(PostalAddress));
```

Encode descriptor text outside this project:

```csharp
var embeddings = descriptors
    .Select(descriptor => new DomainEmbeddingValue(
        descriptor.Id,
        Embedding: encoder.Encode(descriptor.Text)))
    .ToArray();
```

Register embeddings:

```csharp
await store.UpsertAsync(
    modelName: "text-embedding-3-small",
    domainType: typeof(PostalAddress),
    embeddings,
    cancellationToken);
```

Search:

```csharp
var exact = await store.ExactSearchAsync(modelName, "postal address");
var vector = await store.VectorSearchAsync(modelName, queryEmbedding);
var hybrid = await store.HybridSearchAsync(modelName, "morada", queryEmbedding);
```

## Service Flow

```text
DomainSearchAttribute
  -> DomainEmbeddingDescriptorReader
  -> DomainEmbeddingDescriptor[]
  -> external embedding provider
  -> DomainVectorStore.UpsertAsync(...)
  -> ModelDatabaseRouter
  -> SQLite file under data/domain-vector-dbs/
```

Database files are routed by embedding model name. The model name is sanitized for the file name and the original model name is stored inside the database.

## Alignment

Alignment uses the fixed prompt set owned by this project:

```csharp
DomainVectorStoreAlignmentPrompts.All
```

Callers embed those exact texts with the target embedding model and pass the resulting vectors to:

```csharp
SaveAlignmentSetAsync(modelName, embeddings)
CheckAlignmentAsync(modelName, embeddings)
```

The API does not accept arbitrary alignment text. This keeps the check stable between runs.

## Project Rules

- Do not create embeddings in this project.
- Do not accept arbitrary metadata for normal domain registration.
- Treat `EmbeddingRecord` as a read/persisted model, not the normal public registration input.
- Keep descriptor ids stable.
- Put semantic meaning in `DomainSearchAttribute.Name`, `Description`, `Aliases`, and `Tags`.
- Keep exact search and vector search separate, with hybrid search as an explicit combination.

## Development Workflow

1. Update domain annotations first when semantic meaning changes.
2. Run vector-store unit tests after changing descriptors, routing, or search.
3. Update MCP docs when public tool behavior changes.
4. Update this README when descriptor, search, or alignment flow changes.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
- [MCP server README](/Users/thepotato/Code/Outputs.Documents/Apps/src/Outputs.Documents.Domain.VectorStore.McpServer/README.md)
