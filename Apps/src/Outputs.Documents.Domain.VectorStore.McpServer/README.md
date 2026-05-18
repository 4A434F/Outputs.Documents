# Outputs.Documents.Domain.VectorStore.McpServer

Development MCP server for the domain vector store.

The server exposes storage and search operations from `Outputs.Documents.Domain.VectorStore` over MCP HTTP by default. It does not generate embeddings.

## Status

- Maturity: development app
- Runtime: .NET 8
- Default transport: HTTP MCP endpoint
- Optional transport: stdio
- Database folder: `data/domain-vector-dbs/`

## Fast Start

Run HTTP from the repository root:

```bash
dotnet run --project Apps/src/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --urls http://localhost:5055
```

MCP endpoint:

```text
http://localhost:5055/mcp
```

Run stdio:

```bash
dotnet run --project Apps/src/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --transport stdio
```

Build:

```bash
dotnet build Apps/src/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj
```

## Project Map

| Path | Purpose |
|---|---|
| `Program.cs` | MCP server startup and service registration |
| `Tools/` | MCP tool DTOs and tool implementation |
| `Utilities/` | Database directory and transport helpers |
| `Dockerfile` | Container image for Docker MCP workflows |
| `docker-mcp-server.yaml` | Docker MCP Toolkit server definition |

## Architecture Summary

The MCP server is an app facade over the vector-store library.

```text
MCP client
  -> MCP HTTP or stdio transport
  -> VectorStoreMcpTools
  -> IDomainVectorStore
  -> SQLite databases
```

The server keeps the same rule as the library: it stores vectors but does not create embeddings.

## Usage

Normal registration flow:

1. Call `DescribeDomainType` with a full type name.
2. Embed each returned `DomainEmbeddingDescriptor.Text` with your selected embedding model.
3. Call `UpsertDomainTypeAsync` with the same type name, model name, and `DomainEmbeddingValue[]` keyed by descriptor id.

Common tools:

- `ListAlignmentPrompts`
- `ListModelsAsync`
- `DescribeDomainType`
- `UpsertDomainTypeAsync`
- `GetRecordAsync`
- `ListRecordsAsync`
- `ExactSearchAsync`
- `VectorSearchAsync`
- `HybridSearchAsync`
- `SaveAlignmentSetAsync`
- `CheckAlignmentAsync`

## Service Flow

```text
DescribeDomainType
  -> load domain type
  -> vector store describes descriptors
  -> caller embeds descriptor text
  -> UpsertDomainTypeAsync
  -> vector store persists records

Search tool
  -> modelName routes to one SQLite DB
  -> exact/vector/hybrid search
  -> records returned to MCP client
```

## Docker

Build the image:

```bash
docker build \
  -f Apps/src/Outputs.Documents.Domain.VectorStore.McpServer/Dockerfile \
  -t outputs-documents-vectorstore-mcp .
```

Run HTTP manually:

```bash
docker run --rm \
  --name outputs-documents-vectorstore-mcp \
  -p 5055:5055 \
  -v "$(pwd)/data/domain-vector-dbs:/data/domain-vector-dbs" \
  outputs-documents-vectorstore-mcp \
  --transport http \
  --urls http://+:5055
```

The volume mount keeps SQLite DB files available between sessions. Transient SQLite sidecar files are ignored.

## Docker MCP Toolkit

Register the local server definition:

```bash
docker mcp profile server add default \
  --server file://Apps/src/Outputs.Documents.Domain.VectorStore.McpServer/docker-mcp-server.yaml
```

Configure the repository-local DB folder:

```bash
docker mcp profile config outputs_documents \
  --set outputs-documents-vector-store.dbDir="$(pwd)/data/domain-vector-dbs"
```

Run the gateway:

```bash
docker mcp gateway run --profile outputs_documents
```

## Project Rules

- Do not generate embeddings in the MCP server.
- Keep tool operations aligned with the vector-store library API.
- Keep DB files accessible through `data/domain-vector-dbs/` unless explicitly configured.
- Keep transport and database path helper logic small and app-local.
- Do not move vector-store repository logic into the app.

## Development Workflow

1. Change storage behavior in `Tools/src/Outputs.Documents.Domain.VectorStore`.
2. Change MCP request/response behavior here.
3. Rebuild the app after tool changes.
4. Update Docker MCP instructions when server config changes.

## Related Documentation

- [Repository README](/Users/thepotato/Code/Outputs.Documents/README.md)
- [Vector store README](/Users/thepotato/Code/Outputs.Documents/Tools/src/Outputs.Documents.Domain.VectorStore/README.md)
- [Project overview](/Users/thepotato/Code/Outputs.Documents/Docs/PROJECT.md)
- [Rules](/Users/thepotato/Code/Outputs.Documents/Docs/RULES.md)
