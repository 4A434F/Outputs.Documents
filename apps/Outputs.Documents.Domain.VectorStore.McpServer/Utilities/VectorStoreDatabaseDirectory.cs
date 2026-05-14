namespace Outputs.Documents.Domain.VectorStore.McpServer.Utilities;

internal static class VectorStoreDatabaseDirectory
{
    private const string EnvironmentVariableName = "OUTPUTS_DOCUMENTS_VECTOR_STORE_DB_DIR";

    public static string Resolve(IReadOnlyList<string> args)
    {
        var fromArgs = ResolveFromArgs(args);

        if (!string.IsNullOrWhiteSpace(fromArgs))
        {
            return Path.GetFullPath(fromArgs);
        }

        var fromEnvironment = Environment.GetEnvironmentVariable(EnvironmentVariableName);

        if (!string.IsNullOrWhiteSpace(fromEnvironment))
        {
            return Path.GetFullPath(fromEnvironment);
        }

        return Path.Combine(FindRepositoryRoot(), "data", "domain-vector-dbs");
    }

    private static string? ResolveFromArgs(IReadOnlyList<string> args)
    {
        for (var index = 0; index < args.Count; index++)
        {
            var arg = args[index];

            if (string.Equals(arg, "--db-dir", StringComparison.OrdinalIgnoreCase) &&
                index + 1 < args.Count)
            {
                return args[index + 1];
            }

            const string prefix = "--db-dir=";
            if (arg.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                return arg[prefix.Length..];
            }
        }

        return null;
    }

    private static string FindRepositoryRoot()
    {
        var directory = new DirectoryInfo(AppContext.BaseDirectory);

        while (directory is not null)
        {
            if (File.Exists(Path.Combine(directory.FullName, "Outputs.Documents.sln")))
            {
                return directory.FullName;
            }

            directory = directory.Parent;
        }

        return Directory.GetCurrentDirectory();
    }
}
