using System.Security.Cryptography;
using System.Text;

namespace Outputs.Documents.Domain.VectorStore.Storage;

public sealed class ModelDatabaseRouter
{
    private readonly string _databaseDirectory;

    public ModelDatabaseRouter(string databaseDirectory)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(databaseDirectory);
        _databaseDirectory = databaseDirectory;
    }

    public string GetDatabasePath(string modelName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelName);

        Directory.CreateDirectory(_databaseDirectory);
        return BuildDatabasePath(modelName);
    }

    public string? GetExistingDatabasePath(string modelName)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelName);

        var databasePath = BuildDatabasePath(modelName);
        return File.Exists(databasePath)
            ? databasePath
            : null;
    }

    private string BuildDatabasePath(string modelName)
    {
        var sanitizedName = SanitizeModelName(modelName);
        var hash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(modelName)))
            .ToLowerInvariant()[..12];

        return Path.Combine(_databaseDirectory, $"{sanitizedName}-{hash}.sqlite");
    }

    public IReadOnlyList<string> GetDatabasePaths()
    {
        if (!Directory.Exists(_databaseDirectory))
        {
            return [];
        }

        return Directory
            .EnumerateFiles(_databaseDirectory, "*.sqlite", SearchOption.TopDirectoryOnly)
            .Order(StringComparer.OrdinalIgnoreCase)
            .ToList();
    }

    private static string SanitizeModelName(string modelName)
    {
        var builder = new StringBuilder(modelName.Length);
        var previousWasSeparator = false;

        foreach (var character in modelName.Trim().ToLowerInvariant())
        {
            if (char.IsLetterOrDigit(character) || character is '.' or '-' or '_')
            {
                builder.Append(character);
                previousWasSeparator = false;
                continue;
            }

            if (!previousWasSeparator)
            {
                builder.Append('-');
                previousWasSeparator = true;
            }
        }

        var sanitized = builder.ToString().Trim('-', '.', '_');
        return string.IsNullOrWhiteSpace(sanitized)
            ? "embedding-model"
            : sanitized;
    }
}
