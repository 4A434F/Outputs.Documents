# Outputs.Documents.Domain.VectorStore

Storage-only SQLite repository for domain semantic search records.

This project does not create embeddings. Callers generate embeddings elsewhere, then pass the embedding model name, encoded vector, and searchable metadata into this repository.

## Project Layout

```text
Alignment/
  Fixed alignment prompts and alignment check models.

Records/
  Stored embedding record model and record kind constants.

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

## Record Shape

`EmbeddingRecord` stores both structured exact-search fields and semantic vector-search fields:

```csharp
new EmbeddingRecord
{
    Id = "property:Outputs.Documents.Domain.Doce.Address.Line1",
    Kind = EmbeddingRecordKinds.Property,
    Declaration = "Outputs.Documents.Domain.Doce.Address.Line1",
    Name = "Line1",
    Aliases = ["addr1", "morada linha 1"],
    Tags = ["address-line"],
    Text = "Domain property: Address.Line1. First postal address line...",
    EmbeddingModel = "text-embedding-3-small",
    Embedding = embedding
};
```

Rules:

- `Kind` says what the vector represents: `Entity`, `Property`, `EntityDocument`, or `Alignment`.
- `Declaration` is the stable source declaration identity, usually a full type/property name.
- `Text` is the exact text that was embedded.
- Anything that should affect semantic search must be included in `Text` before encoding.
- Anything that should affect exact search should also be stored structurally in `Name`, `Aliases`, `Tags`, `Declaration`, or `Metadata`.

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
