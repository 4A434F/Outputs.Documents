# Outputs.Documents.Domain.VectorStore.McpServer

Development MCP server for the domain vector store.

The server exposes the storage/search operations from `Outputs.Documents.Domain.VectorStore` over MCP HTTP by default. It does not generate embeddings. Callers ask the server to describe a loaded C# domain type, embed the returned descriptor text elsewhere, then register the vectors back against that same domain type.

## Run

HTTP is the default transport:

```bash
dotnet run --project apps/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --urls http://localhost:5055
```

MCP endpoint:

```text
http://localhost:5055/mcp
```

Stdio is still available when a local MCP host wants to spawn the process:

```bash
dotnet run --project apps/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --transport stdio
```

By default the server uses:

```text
data/domain-vector-dbs/
```

Override the DB folder with either:

```bash
OUTPUTS_DOCUMENTS_VECTOR_STORE_DB_DIR=/path/to/dbs dotnet run --project apps/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj
```

or:

```bash
dotnet run --project apps/Outputs.Documents.Domain.VectorStore.McpServer/Outputs.Documents.Domain.VectorStore.McpServer.csproj -- --db-dir /path/to/dbs --urls http://localhost:5055
```

## Tools

- `ListAlignmentPrompts`
- `ListModelsAsync`
- `DescribeDomainType`
- `UpsertDomainTypeAsync`
- `GetRecordAsync`
- `ListRecordsAsync`
- `DeleteRecordAsync`
- `DeleteByDeclarationAsync`
- `ExactSearchAsync`
- `VectorSearchAsync`
- `HybridSearchAsync`
- `SaveAlignmentSetAsync`
- `CheckAlignmentAsync`

The normal registration flow is:

1. Call `DescribeDomainType` with a full type name such as `Outputs.Documents.FSCD.Contracts.FS000CancelationLetter`.
2. Embed each returned `DomainEmbeddingDescriptor.Text` with your selected embedding model.
3. Call `UpsertDomainTypeAsync` with the same type name, model name, and `DomainEmbeddingValue[]` keyed by descriptor id.

The server does not accept arbitrary record metadata for domain registration. Names, aliases, tags, declarations, and embedded text are read from the C# type and `DomainSearchAttribute` so the database remains aligned with the source model.

## Docker

Build the MCP server image from the repository root:

```bash
docker build \
  -f apps/Outputs.Documents.Domain.VectorStore.McpServer/Dockerfile \
  -t outputs-documents-vectorstore-mcp .
```

The image defaults to stdio because Docker MCP Gateway starts catalog images as local MCP servers. To run the HTTP endpoint manually, pass the HTTP transport explicitly:

```bash
docker run --rm \
  --name outputs-documents-vectorstore-mcp \
  -p 5055:5055 \
  -v "$(pwd)/data/domain-vector-dbs:/data/domain-vector-dbs" \
  outputs-documents-vectorstore-mcp \
  --transport http \
  --urls http://+:5055
```

MCP endpoint:

```text
http://localhost:5055/mcp
```

The volume mount keeps SQLite DB files on the host. Without the volume, the container can still run, but any DB files created inside the container disappear when the container is removed.

SQLite database files live in the repository at:

```text
data/domain-vector-dbs/
```

The Docker MCP server definition bind-mounts a configured host folder to `/data/domain-vector-dbs` inside the container:

```yaml
volumes:
  - "{{outputs-documents-vector-store.dbDir|volume|target:/data/domain-vector-dbs}}"
```

Each developer configures `dbDir` once for their clone. For this repository, point it at the repo-local DB folder:

```bash
docker mcp profile config outputs_documents \
  --set outputs-documents-vector-store.dbDir="$(pwd)/data/domain-vector-dbs"
```

This keeps the DB files accessible between MCP sessions and allows committed `.sqlite` files to travel with the project. Transient SQLite sidecar files (`*.sqlite-wal`, `*.sqlite-shm`, `*.sqlite-journal`) are ignored.

## Docker MCP Toolkit

Docker MCP Toolkit can use the local server definition in this project:

```bash
docker mcp profile server add default \
  --server file://apps/Outputs.Documents.Domain.VectorStore.McpServer/docker-mcp-server.yaml
```

After adding it, list the profile servers:

```bash
docker mcp profile server ls --filter profile=default
```

The server can then be reached by any client connected to Docker MCP Gateway:

```bash
docker mcp gateway run --profile default
```

For a custom Docker MCP catalog, create an OCI catalog from the local server definition:

```bash
docker mcp catalog create outputs-documents/mcp-catalog:latest \
  --title "Outputs.Documents MCP Catalog" \
  --server file://apps/Outputs.Documents.Domain.VectorStore.McpServer/docker-mcp-server.yaml
```

Inspect the catalog:

```bash
docker mcp catalog show outputs-documents/mcp-catalog:latest
docker mcp catalog server ls outputs-documents/mcp-catalog:latest
```

Create a dedicated profile from the custom catalog:

```bash
docker mcp profile create --name outputs-documents

docker mcp profile server add outputs_documents \
  --server catalog://outputs-documents/mcp-catalog:latest/outputs-documents-vector-store

docker mcp profile config outputs_documents \
  --set outputs-documents-vector-store.dbDir="$(pwd)/data/domain-vector-dbs"
```

Docker normalizes the profile id to `outputs_documents`. Verify the tools through the Docker MCP Gateway:

```bash
docker mcp tools ls \
  --gateway-arg=--profile \
  --gateway-arg=outputs_documents
```

Connect a supported client to that profile:

```bash
docker mcp client connect vscode --profile outputs_documents
```

For a manual stdio client configuration, point the client at the Docker MCP Gateway:

```json
{
  "servers": {
    "MCP_DOCKER": {
      "command": "docker",
      "args": ["mcp", "gateway", "run", "--profile", "outputs_documents"],
      "type": "stdio"
    }
  }
}
```

To share the catalog through a registry, tag it with your registry/org reference and push it:

```bash
docker mcp catalog tag outputs-documents/mcp-catalog:latest registry.example.com/outputs-documents/mcp-catalog:latest
docker mcp catalog push registry.example.com/outputs-documents/mcp-catalog:latest
```

## Notes

- `GetRecordAsync` is exact id lookup only.
- Exact/vector/hybrid search are separate tools.
- Alignment uses the fixed prompts returned by `ListAlignmentPrompts`.
- This MCP server stores vectors only; embedding generation belongs to the caller.
