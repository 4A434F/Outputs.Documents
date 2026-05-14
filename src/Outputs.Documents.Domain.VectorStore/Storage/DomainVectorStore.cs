using System.Data;
using System.Text.Json;
using Microsoft.Data.Sqlite;
using Outputs.Documents.Domain.VectorStore.Alignment;
using Outputs.Documents.Domain.VectorStore.Records;
using Outputs.Documents.Domain.VectorStore.Search;
using Outputs.Documents.Domain.VectorStore.Utilities;

namespace Outputs.Documents.Domain.VectorStore.Storage;

public sealed class DomainVectorStore : IDomainVectorStore
{
    private static readonly JsonSerializerOptions JsonOptions = new(JsonSerializerDefaults.Web);

    private readonly ModelDatabaseRouter _router;

    public DomainVectorStore(string databaseDirectory)
        : this(new DomainVectorStoreOptions(databaseDirectory))
    {
    }

    public DomainVectorStore(DomainVectorStoreOptions options)
    {
        _router = new ModelDatabaseRouter(options.DatabaseDirectory);
    }

    public async Task UpsertAsync(
        string modelName,
        EmbeddingRecord record,
        CancellationToken cancellationToken = default)
    {
        ValidateRecord(modelName, record);

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        await EnsureDimensionAsync(connection, record.Embedding.Length, cancellationToken);
        await UpsertRecordAsync(connection, record, cancellationToken);
    }

    public async Task UpsertManyAsync(
        string modelName,
        IEnumerable<EmbeddingRecord> records,
        CancellationToken cancellationToken = default)
    {
        var recordList = records.ToList();

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        await using var transaction = await connection.BeginTransactionAsync(cancellationToken);

        foreach (var record in recordList)
        {
            ValidateRecord(modelName, record);
            await EnsureDimensionAsync(connection, record.Embedding.Length, cancellationToken);
            await UpsertRecordAsync(connection, record, cancellationToken);
        }

        await transaction.CommitAsync(cancellationToken);
    }

    public async Task<EmbeddingRecord?> GetAsync(
        string modelName,
        string id,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT
                id,
                kind,
                declaration,
                name,
                aliases_json,
                tags_json,
                text,
                embedding_model,
                embedding,
                metadata_json
            FROM embedding_records
            WHERE id = $id;
            """;
        command.Parameters.AddWithValue("$id", id);

        await using var reader = await command.ExecuteReaderAsync(cancellationToken);
        return await reader.ReadAsync(cancellationToken)
            ? ReadEmbeddingRecord(reader)
            : null;
    }

    public async Task<IReadOnlyList<EmbeddingRecord>> ListAsync(
        string modelName,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        return await ListInternalAsync(connection, kind, cancellationToken);
    }

    public async Task DeleteAsync(
        string modelName,
        string id,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        await using var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM embedding_records WHERE id = $id;";
        command.Parameters.AddWithValue("$id", id);
        await command.ExecuteNonQueryAsync(cancellationToken);
    }

    public async Task DeleteByDeclarationAsync(
        string modelName,
        string kind,
        string declaration,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(kind);
        ArgumentException.ThrowIfNullOrWhiteSpace(declaration);

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        await using var command = connection.CreateCommand();
        command.CommandText = """
            DELETE FROM embedding_records
            WHERE kind = $kind AND declaration = $declaration;
            """;
        command.Parameters.AddWithValue("$kind", kind);
        command.Parameters.AddWithValue("$declaration", declaration);
        await command.ExecuteNonQueryAsync(cancellationToken);
    }

    public async Task<IReadOnlyList<string>> ListModelsAsync(
        CancellationToken cancellationToken = default)
    {
        var models = new List<string>();

        foreach (var databasePath in _router.GetDatabasePaths())
        {
            await using var connection = new SqliteConnection($"Data Source={databasePath}");
            await connection.OpenAsync(cancellationToken);

            if (!await TableExistsAsync(connection, "model_metadata", cancellationToken))
            {
                continue;
            }

            await using var command = connection.CreateCommand();
            command.CommandText = """
                SELECT value
                FROM model_metadata
                WHERE key = 'embedding_model';
                """;

            var modelName = await command.ExecuteScalarAsync(cancellationToken) as string;

            if (!string.IsNullOrWhiteSpace(modelName))
            {
                models.Add(modelName);
            }
        }

        return models
            .Distinct(StringComparer.Ordinal)
            .Order(StringComparer.Ordinal)
            .ToList();
    }

    public async Task<IReadOnlyList<ExactSearchResult>> ExactSearchAsync(
        string modelName,
        string query,
        int limit = 10,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(limit);

        var normalizedQuery = TextNormalizer.Normalize(query);
        var records = await ListAsync(modelName, kind, cancellationToken);

        return records
            .Select(record => ScoreExact(record, normalizedQuery))
            .Where(result => result is not null)
            .Select(result => result!)
            .OrderByDescending(result => result.Score)
            .ThenBy(result => result.Record.Name, StringComparer.OrdinalIgnoreCase)
            .Take(limit)
            .ToList();
    }

    public async Task<IReadOnlyList<VectorSearchResult>> VectorSearchAsync(
        string modelName,
        float[] queryEmbedding,
        int limit = 10,
        double? minScore = null,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        ValidateSearchEmbedding(queryEmbedding, limit);

        var records = await ListAsync(modelName, kind, cancellationToken);

        return records
            .Where(record => record.Embedding.Length == queryEmbedding.Length)
            .Select(record =>
            {
                var similarity = VectorMath.CosineSimilarity(record.Embedding, queryEmbedding);
                return new VectorSearchResult(record, similarity, 1 - similarity);
            })
            .Where(result => minScore is null || result.Similarity >= minScore)
            .OrderByDescending(result => result.Similarity)
            .ThenBy(result => result.Record.Name, StringComparer.OrdinalIgnoreCase)
            .Take(limit)
            .ToList();
    }

    public async Task<IReadOnlyList<HybridSearchResult>> HybridSearchAsync(
        string modelName,
        string query,
        float[] queryEmbedding,
        int limit = 10,
        double? minScore = null,
        string? kind = null,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(query);
        ValidateSearchEmbedding(queryEmbedding, limit);

        var exactResults = await ExactSearchAsync(
            modelName,
            query,
            int.MaxValue,
            kind,
            cancellationToken);

        var vectorResults = await VectorSearchAsync(
            modelName,
            queryEmbedding,
            int.MaxValue,
            null,
            kind,
            cancellationToken);

        var byId = new Dictionary<string, HybridSearchAccumulator>(StringComparer.Ordinal);

        foreach (var result in exactResults)
        {
            var accumulator = GetAccumulator(byId, result.Record);
            accumulator.Score += result.Score;
            accumulator.MatchKinds.AddRange(SplitMatchKinds(result.MatchKind));
        }

        foreach (var result in vectorResults)
        {
            var accumulator = GetAccumulator(byId, result.Record);
            accumulator.VectorSimilarity = result.Similarity;
            accumulator.Score += Math.Max(0, result.Similarity);
            accumulator.MatchKinds.Add("Vector");
        }

        return byId.Values
            .Select(accumulator => accumulator.ToResult())
            .Where(result => minScore is null || result.Score >= minScore)
            .OrderByDescending(result => result.Score)
            .ThenBy(result => result.Record.Name, StringComparer.OrdinalIgnoreCase)
            .Take(limit)
            .ToList();
    }

    public async Task SaveAlignmentSetAsync(
        string modelName,
        IEnumerable<AlignmentEmbedding> embeddings,
        CancellationToken cancellationToken = default)
    {
        var embeddingList = ValidateAlignmentEmbeddings(modelName, embeddings);
        var promptsByKey = DomainVectorStoreAlignmentPrompts.All.ToDictionary(
            prompt => prompt.Key,
            StringComparer.Ordinal);

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        await using var transaction = await connection.BeginTransactionAsync(cancellationToken);

        await using (var deleteCommand = connection.CreateCommand())
        {
            deleteCommand.CommandText = "DELETE FROM alignment_records;";
            await deleteCommand.ExecuteNonQueryAsync(cancellationToken);
        }

        foreach (var embedding in embeddingList)
        {
            var prompt = promptsByKey[embedding.Key];
            await EnsureDimensionAsync(connection, embedding.Embedding.Length, cancellationToken);
            await UpsertAlignmentEmbeddingAsync(connection, prompt, embedding, cancellationToken);
        }

        await transaction.CommitAsync(cancellationToken);
    }

    public async Task<IReadOnlyList<AlignmentCheckResult>> CheckAlignmentAsync(
        string modelName,
        IEnumerable<AlignmentEmbedding> embeddings,
        double minimumSimilarity = 0.98,
        CancellationToken cancellationToken = default)
    {
        var embeddingList = ValidateAlignmentEmbeddings(modelName, embeddings);

        await using var connection = await OpenConnectionAsync(modelName, cancellationToken);
        var storedRecords = await ReadAlignmentEmbeddingsAsync(connection, cancellationToken);
        var storedByKey = storedRecords.ToDictionary(record => record.Key, StringComparer.Ordinal);
        var results = new List<AlignmentCheckResult>(embeddingList.Count);

        foreach (var embedding in embeddingList)
        {
            if (!storedByKey.TryGetValue(embedding.Key, out var storedRecord))
            {
                throw new InvalidOperationException(
                    $"No alignment baseline was found for key '{embedding.Key}'.");
            }

            var similarity = VectorMath.CosineSimilarity(storedRecord.Embedding, embedding.Embedding);
            results.Add(new AlignmentCheckResult(
                embedding.Key,
                similarity,
                1 - similarity,
                similarity >= minimumSimilarity));
        }

        return results;
    }

    private async Task<SqliteConnection> OpenConnectionAsync(
        string modelName,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelName);

        var databasePath = _router.GetDatabasePath(modelName);
        var connection = new SqliteConnection($"Data Source={databasePath}");
        await connection.OpenAsync(cancellationToken);
        await EnsureSchemaAsync(connection, modelName, cancellationToken);
        return connection;
    }

    private static async Task EnsureSchemaAsync(
        SqliteConnection connection,
        string modelName,
        CancellationToken cancellationToken)
    {
        await using var command = connection.CreateCommand();
        command.CommandText = """
            CREATE TABLE IF NOT EXISTS model_metadata (
                key TEXT PRIMARY KEY,
                value TEXT NOT NULL
            );

            CREATE TABLE IF NOT EXISTS embedding_records (
                id TEXT PRIMARY KEY,
                kind TEXT NOT NULL,
                declaration TEXT NOT NULL,
                name TEXT NOT NULL,
                normalized_name TEXT NOT NULL,
                aliases_json TEXT NOT NULL,
                normalized_aliases_json TEXT NOT NULL,
                tags_json TEXT NOT NULL,
                text TEXT NOT NULL,
                embedding_model TEXT NOT NULL,
                embedding_dimension INTEGER NOT NULL,
                embedding BLOB NOT NULL,
                metadata_json TEXT NOT NULL,
                content_hash TEXT NOT NULL,
                created_at TEXT NOT NULL,
                updated_at TEXT NOT NULL
            );

            CREATE INDEX IF NOT EXISTS ix_embedding_records_declaration
                ON embedding_records(kind, declaration);

            CREATE INDEX IF NOT EXISTS ix_embedding_records_normalized_name
                ON embedding_records(normalized_name);

            CREATE INDEX IF NOT EXISTS ix_embedding_records_embedding_model
                ON embedding_records(embedding_model);

            CREATE TABLE IF NOT EXISTS alignment_records (
                key TEXT PRIMARY KEY,
                text TEXT NOT NULL,
                embedding_model TEXT NOT NULL,
                embedding_dimension INTEGER NOT NULL,
                embedding BLOB NOT NULL,
                content_hash TEXT NOT NULL,
                created_at TEXT NOT NULL,
                updated_at TEXT NOT NULL
            );

            INSERT INTO model_metadata(key, value)
            VALUES ('embedding_model', $modelName)
            ON CONFLICT(key) DO UPDATE SET value = excluded.value;
            """;
        command.Parameters.AddWithValue("$modelName", modelName);
        await command.ExecuteNonQueryAsync(cancellationToken);
    }

    private static async Task<bool> TableExistsAsync(
        SqliteConnection connection,
        string tableName,
        CancellationToken cancellationToken)
    {
        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT 1
            FROM sqlite_master
            WHERE type = 'table' AND name = $tableName;
            """;
        command.Parameters.AddWithValue("$tableName", tableName);
        return await command.ExecuteScalarAsync(cancellationToken) is not null;
    }

    private static async Task EnsureDimensionAsync(
        SqliteConnection connection,
        int dimension,
        CancellationToken cancellationToken)
    {
        if (dimension <= 0)
        {
            throw new ArgumentException("Embedding dimension must be greater than zero.");
        }

        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT embedding_dimension
            FROM embedding_records
            LIMIT 1;
            """;

        var existing = await command.ExecuteScalarAsync(cancellationToken);

        if (existing is null)
        {
            command.CommandText = """
                SELECT embedding_dimension
                FROM alignment_records
                LIMIT 1;
                """;
            existing = await command.ExecuteScalarAsync(cancellationToken);
        }

        if (existing is not null && Convert.ToInt32(existing) != dimension)
        {
            throw new InvalidOperationException(
                $"Embedding dimension mismatch. Existing DB dimension is '{existing}', but received '{dimension}'.");
        }
    }

    private static async Task UpsertRecordAsync(
        SqliteConnection connection,
        EmbeddingRecord record,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.UtcNow.ToString("O");

        await using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO embedding_records (
                id,
                kind,
                declaration,
                name,
                normalized_name,
                aliases_json,
                normalized_aliases_json,
                tags_json,
                text,
                embedding_model,
                embedding_dimension,
                embedding,
                metadata_json,
                content_hash,
                created_at,
                updated_at
            )
            VALUES (
                $id,
                $kind,
                $declaration,
                $name,
                $normalizedName,
                $aliasesJson,
                $normalizedAliasesJson,
                $tagsJson,
                $text,
                $embeddingModel,
                $embeddingDimension,
                $embedding,
                $metadataJson,
                $contentHash,
                $now,
                $now
            )
            ON CONFLICT(id) DO UPDATE SET
                kind = excluded.kind,
                declaration = excluded.declaration,
                name = excluded.name,
                normalized_name = excluded.normalized_name,
                aliases_json = excluded.aliases_json,
                normalized_aliases_json = excluded.normalized_aliases_json,
                tags_json = excluded.tags_json,
                text = excluded.text,
                embedding_model = excluded.embedding_model,
                embedding_dimension = excluded.embedding_dimension,
                embedding = excluded.embedding,
                metadata_json = excluded.metadata_json,
                content_hash = excluded.content_hash,
                updated_at = excluded.updated_at;
            """;
        command.Parameters.AddWithValue("$id", record.Id);
        command.Parameters.AddWithValue("$kind", record.Kind);
        command.Parameters.AddWithValue("$declaration", record.Declaration);
        command.Parameters.AddWithValue("$name", record.Name);
        command.Parameters.AddWithValue("$normalizedName", TextNormalizer.Normalize(record.Name));
        command.Parameters.AddWithValue("$aliasesJson", Serialize(record.Aliases));
        command.Parameters.AddWithValue("$normalizedAliasesJson", Serialize(record.Aliases.Select(TextNormalizer.Normalize).ToArray()));
        command.Parameters.AddWithValue("$tagsJson", Serialize(record.Tags));
        command.Parameters.AddWithValue("$text", record.Text);
        command.Parameters.AddWithValue("$embeddingModel", record.EmbeddingModel);
        command.Parameters.AddWithValue("$embeddingDimension", record.Embedding.Length);
        command.Parameters.Add("$embedding", SqliteType.Blob).Value = EmbeddingBinarySerializer.Serialize(record.Embedding);
        command.Parameters.AddWithValue("$metadataJson", Serialize(record.Metadata));
        command.Parameters.AddWithValue("$contentHash", ContentHash.Compute(record.Text));
        command.Parameters.AddWithValue("$now", now);
        await command.ExecuteNonQueryAsync(cancellationToken);
    }

    private static async Task<IReadOnlyList<EmbeddingRecord>> ListInternalAsync(
        SqliteConnection connection,
        string? kind,
        CancellationToken cancellationToken)
    {
        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT
                id,
                kind,
                declaration,
                name,
                aliases_json,
                tags_json,
                text,
                embedding_model,
                embedding,
                metadata_json
            FROM embedding_records
            WHERE $kind IS NULL OR kind = $kind
            ORDER BY kind, name, id;
            """;
        command.Parameters.AddWithValue("$kind", (object?)kind ?? DBNull.Value);

        var records = new List<EmbeddingRecord>();
        await using var reader = await command.ExecuteReaderAsync(cancellationToken);

        while (await reader.ReadAsync(cancellationToken))
        {
            records.Add(ReadEmbeddingRecord(reader));
        }

        return records;
    }

    private static EmbeddingRecord ReadEmbeddingRecord(SqliteDataReader reader)
    {
        return new EmbeddingRecord
        {
            Id = GetString(reader, "id"),
            Kind = GetString(reader, "kind"),
            Declaration = GetString(reader, "declaration"),
            Name = GetString(reader, "name"),
            Aliases = Deserialize<List<string>>(GetString(reader, "aliases_json")),
            Tags = Deserialize<List<string>>(GetString(reader, "tags_json")),
            Text = GetString(reader, "text"),
            EmbeddingModel = GetString(reader, "embedding_model"),
            Embedding = EmbeddingBinarySerializer.Deserialize((byte[])reader["embedding"]),
            Metadata = Deserialize<Dictionary<string, string>>(GetString(reader, "metadata_json"))
        };
    }

    private static ExactSearchResult? ScoreExact(EmbeddingRecord record, string normalizedQuery)
    {
        var score = 0d;
        var matchKinds = new List<string>();

        AddMatch(record.Id, "Id", 1.1);
        AddMatch(record.Declaration, "Declaration", 1.0);
        AddMatch(record.Name, "Name", 1.2);

        foreach (var alias in record.Aliases)
        {
            AddMatch(alias, "Alias", 1.1);
        }

        foreach (var tag in record.Tags)
        {
            AddMatch(tag, "Tag", 0.7);
        }

        foreach (var (key, value) in record.Metadata)
        {
            AddMatch(key, "MetadataKey", 0.5);
            AddMatch(value, "MetadataValue", 0.5);
        }

        var normalizedText = TextNormalizer.Normalize(record.Text);

        if (normalizedText.Contains(normalizedQuery, StringComparison.Ordinal))
        {
            score += 0.35;
            matchKinds.Add("Text");
        }

        return score > 0
            ? new ExactSearchResult(record, string.Join(", ", matchKinds.Distinct(StringComparer.Ordinal)), score)
            : null;

        void AddMatch(string value, string kind, double exactScore)
        {
            var normalizedValue = TextNormalizer.Normalize(value);

            if (normalizedValue == normalizedQuery)
            {
                score += exactScore;
                matchKinds.Add(kind);
                return;
            }

            if (normalizedValue.Contains(normalizedQuery, StringComparison.InvariantCultureIgnoreCase))
            {
                score += exactScore * 0.6;
                matchKinds.Add($"{kind}Contains");
            }
        }
    }

    private static async Task UpsertAlignmentEmbeddingAsync(
        SqliteConnection connection,
        AlignmentPrompt prompt,
        AlignmentEmbedding embedding,
        CancellationToken cancellationToken)
    {
        var now = DateTimeOffset.UtcNow.ToString("O");

        await using var command = connection.CreateCommand();
        command.CommandText = """
            INSERT INTO alignment_records (
                key,
                text,
                embedding_model,
                embedding_dimension,
                embedding,
                content_hash,
                created_at,
                updated_at
            )
            VALUES (
                $key,
                $text,
                $embeddingModel,
                $embeddingDimension,
                $embedding,
                $contentHash,
                $now,
                $now
            )
            ON CONFLICT(key) DO UPDATE SET
                text = excluded.text,
                embedding_model = excluded.embedding_model,
                embedding_dimension = excluded.embedding_dimension,
                embedding = excluded.embedding,
                content_hash = excluded.content_hash,
                updated_at = excluded.updated_at;
            """;
        command.Parameters.AddWithValue("$key", prompt.Key);
        command.Parameters.AddWithValue("$text", prompt.Text);
        command.Parameters.AddWithValue("$embeddingModel", embedding.EmbeddingModel);
        command.Parameters.AddWithValue("$embeddingDimension", embedding.Embedding.Length);
        command.Parameters.Add("$embedding", SqliteType.Blob).Value = EmbeddingBinarySerializer.Serialize(embedding.Embedding);
        command.Parameters.AddWithValue("$contentHash", ContentHash.Compute(prompt.Text));
        command.Parameters.AddWithValue("$now", now);
        await command.ExecuteNonQueryAsync(cancellationToken);
    }

    private static async Task<IReadOnlyList<StoredAlignmentEmbedding>> ReadAlignmentEmbeddingsAsync(
        SqliteConnection connection,
        CancellationToken cancellationToken)
    {
        await using var command = connection.CreateCommand();
        command.CommandText = """
            SELECT key, text, embedding_model, embedding
            FROM alignment_records
            ORDER BY key;
            """;

        var records = new List<StoredAlignmentEmbedding>();
        await using var reader = await command.ExecuteReaderAsync(cancellationToken);

        while (await reader.ReadAsync(cancellationToken))
        {
            records.Add(new StoredAlignmentEmbedding(
                GetString(reader, "key"),
                GetString(reader, "text"),
                GetString(reader, "embedding_model"),
                EmbeddingBinarySerializer.Deserialize((byte[])reader["embedding"])));
        }

        return records;
    }

    private static void ValidateRecord(string modelName, EmbeddingRecord record)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelName);
        ArgumentException.ThrowIfNullOrWhiteSpace(record.Id);
        ArgumentException.ThrowIfNullOrWhiteSpace(record.Kind);
        ArgumentException.ThrowIfNullOrWhiteSpace(record.Declaration);
        ArgumentException.ThrowIfNullOrWhiteSpace(record.Name);
        ArgumentException.ThrowIfNullOrWhiteSpace(record.Text);

        if (!string.Equals(record.EmbeddingModel, modelName, StringComparison.Ordinal))
        {
            throw new ArgumentException(
                $"Record embedding model '{record.EmbeddingModel}' must match target model '{modelName}'.",
                nameof(record));
        }

        if (record.Embedding.Length == 0)
        {
            throw new ArgumentException("Record embedding must not be empty.", nameof(record));
        }
    }

    private static IReadOnlyList<AlignmentEmbedding> ValidateAlignmentEmbeddings(
        string modelName,
        IEnumerable<AlignmentEmbedding> embeddings)
    {
        var embeddingList = embeddings.ToList();
        var expectedKeys = DomainVectorStoreAlignmentPrompts.All
            .Select(prompt => prompt.Key)
            .Order(StringComparer.Ordinal)
            .ToArray();
        var receivedKeys = embeddingList
            .Select(embedding => embedding.Key)
            .Order(StringComparer.Ordinal)
            .ToArray();

        if (!expectedKeys.SequenceEqual(receivedKeys, StringComparer.Ordinal))
        {
            throw new ArgumentException(
                $"Alignment requires exactly the fixed keys: {string.Join(", ", expectedKeys)}.",
                nameof(embeddings));
        }

        foreach (var embedding in embeddingList)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(embedding.Key);

            if (!string.Equals(embedding.EmbeddingModel, modelName, StringComparison.Ordinal))
            {
                throw new ArgumentException(
                    $"Alignment embedding model '{embedding.EmbeddingModel}' must match target model '{modelName}'.",
                    nameof(embeddings));
            }

            if (embedding.Embedding.Length == 0)
            {
                throw new ArgumentException("Alignment embedding must not be empty.", nameof(embeddings));
            }
        }

        return embeddingList;
    }

    private static void ValidateSearchEmbedding(float[] queryEmbedding, int limit)
    {
        ArgumentNullException.ThrowIfNull(queryEmbedding);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(limit);

        if (queryEmbedding.Length == 0)
        {
            throw new ArgumentException("Query embedding must not be empty.", nameof(queryEmbedding));
        }
    }

    private static HybridSearchAccumulator GetAccumulator(
        Dictionary<string, HybridSearchAccumulator> byId,
        EmbeddingRecord record)
    {
        if (byId.TryGetValue(record.Id, out var accumulator))
        {
            return accumulator;
        }

        accumulator = new HybridSearchAccumulator(record);
        byId.Add(record.Id, accumulator);
        return accumulator;
    }

    private static IReadOnlyList<string> SplitMatchKinds(string matchKind)
    {
        return matchKind
            .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
            .ToList();
    }

    private static string Serialize<T>(T value)
    {
        return JsonSerializer.Serialize(value, JsonOptions);
    }

    private static T Deserialize<T>(string value)
    {
        return JsonSerializer.Deserialize<T>(value, JsonOptions)
            ?? throw new InvalidOperationException("Could not deserialize stored JSON value.");
    }

    private static string GetString(SqliteDataReader reader, string name)
    {
        return reader.GetString(reader.GetOrdinal(name));
    }

    private sealed class HybridSearchAccumulator
    {
        public HybridSearchAccumulator(EmbeddingRecord record)
        {
            Record = record;
        }

        public EmbeddingRecord Record { get; }

        public double Score { get; set; }

        public double? VectorSimilarity { get; set; }

        public List<string> MatchKinds { get; } = [];

        public HybridSearchResult ToResult()
        {
            return new HybridSearchResult(
                Record,
                Score,
                VectorSimilarity,
                MatchKinds.Distinct(StringComparer.Ordinal).ToList());
        }
    }

    private sealed record StoredAlignmentEmbedding(
        string Key,
        string Text,
        string EmbeddingModel,
        float[] Embedding);
}
