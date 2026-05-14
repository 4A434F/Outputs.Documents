# Outputs.Documents.Domain.VectorStore

Storage-only SQLite repository for domain semantic search records.

This project does not create embeddings. Callers ask the store to describe a C# domain type, generate embeddings elsewhere for the returned descriptor text, then register those embeddings back against the same domain type.

## Project Layout

```text
Alignment/
  Fixed alignment prompts and alignment check models.

Records/
  Stored embedding record model and record kind constants.

Descriptors/
  Reflection descriptors created from DomainSearchAttribute and embedding value DTOs.

Search/
  Exact, vector, and hybrid search result models.

Storage/
  SQLite-backed repository, DB routing, and store options.

Utilities/
  Internal hashing, vector serialization, normalization, and vector math helpers.
```

## Database Routing

The store creates one SQLite database per embedding model under:

```text
data/domain-vector-dbs/
```

Model names are sanitized for file names, and the original model name is stored inside the DB.

Example:

```text
text-embedding-3-small -> text-embedding-3-small-<hash>.sqlite
```

## Registration Flow

Callers do not build `EmbeddingRecord` directly for normal domain registration. The record metadata is derived from the C# type and its `DomainSearchAttribute` annotations so that names, aliases, tags, declarations, and embedded text stay stable between executions and embedding models.

```csharp
var descriptors = store.Describe(typeof(Address));

var embeddings = descriptors
    .Select(descriptor => new DomainEmbeddingValue(
        descriptor.Id,
        Embedding: encoder.Encode(descriptor.Text)))
    .ToArray();

await store.UpsertAsync(
    modelName: "text-embedding-3-small",
    domainType: typeof(Address),
    embeddings);
```

Rules:

- `Describe(Type)` is the model-to-database handshake. It returns the exact descriptor ids and text that must be embedded.
- `UpsertAsync(modelName, domainType, embeddings)` re-reads the same descriptors from the domain type and builds the persisted records internally.
- Every descriptor must have a matching `DomainEmbeddingValue`.
- Unknown descriptor ids are rejected.
- `modelName` is the embedding model that produced the supplied vectors and routes to the matching SQLite database file.
- Anything that should affect semantic search must be present in `DomainSearchAttribute.Name`, `Description`, `Aliases`, or `Tags`, because those fields compose the descriptor text.
- Anything that should affect exact search is stored structurally in `Name`, `Aliases`, `Tags`, `Declaration`, or `Metadata`.

`EmbeddingRecord` is still returned from read/search operations because it is the persisted shape. It should be treated as a read model, not as the public registration input.

## Descriptor Shape

`DomainEmbeddingDescriptor` contains the stable source-derived fields used for encoding and registration:

```csharp
public sealed record DomainEmbeddingDescriptor(
    string Id,
    string Kind,
    string Declaration,
    string Name,
    string Description,
    string Text,
    IReadOnlyList<string> Aliases,
    IReadOnlyList<string> Tags,
    IReadOnlyDictionary<string, string> Metadata);
```

Example descriptor id values:

```text
entity:Outputs.Documents.Domain.Locations.PostalAddress
property:Outputs.Documents.Domain.Locations.PostalAddress.Line1
```

## Search

`GetAsync(modelName, id)` is exact lookup only. It returns the exact record or `null`.

Close-match operations are separate:

```csharp
ExactSearchAsync(modelName, query)
VectorSearchAsync(modelName, queryEmbedding)
HybridSearchAsync(modelName, query, queryEmbedding)
```

Exact search checks normalized:

- `Id`
- `Declaration`
- `Name`
- `Aliases`
- `Tags`
- `Metadata`
- `Text`

Vector search uses cosine similarity over stored vectors.

Hybrid search combines exact/alias/tag/text scoring with vector similarity.

## Alignment

Alignment uses a fixed set of five prompts owned by this project:

```csharp
DomainVectorStoreAlignmentPrompts.All
```

Callers should embed those exact texts with the target embedding model and pass back only:

```csharp
new AlignmentEmbedding(
    Key: prompt.Key,
    EmbeddingModel: modelName,
    Embedding: embedding);
```

The alignment API does not accept arbitrary alignment text:

```csharp
SaveAlignmentSetAsync(modelName, embeddings)
CheckAlignmentAsync(modelName, embeddings)
```

This lets a user later re-embed the same fixed texts with the same model and verify the embedding pipeline still aligns. The default alignment threshold is `0.98` cosine similarity.

## Domain Annotation

Domain objects can use `DomainSearchAttribute` from `Outputs.Documents.Domain` to provide semantic meaning for the scanner/indexer:

```csharp
[DomainSearch(
    "Postal address",
    "Postal address block for a recipient or business entity.",
    Aliases = new[] { "morada", "recipient address" },
    Tags = new[] { "address", "postal" })]
public sealed record Address(
    [property: DomainSearch(
        "Address line 1",
        "First postal address line.",
        Aliases = new[] { "addr1" })]
    string Line1);
```

The scanner/indexer is a separate future step. This project only stores records and searches them.
