namespace Outputs.Documents.Domain.VectorStore.McpServer;

internal enum VectorStoreMcpTransport
{
    Http,
    Stdio
}

internal static class VectorStoreMcpTransportResolver
{
    public static VectorStoreMcpTransport Resolve(IReadOnlyList<string> args)
    {
        var value = ResolveArgument(args, "--transport") ?? "http";

        return value.ToLowerInvariant() switch
        {
            "http" => VectorStoreMcpTransport.Http,
            "stdio" => VectorStoreMcpTransport.Stdio,
            _ => throw new ArgumentException(
                $"Unknown MCP transport '{value}'. Supported values are 'http' and 'stdio'.")
        };
    }

    private static string? ResolveArgument(IReadOnlyList<string> args, string name)
    {
        for (var index = 0; index < args.Count; index++)
        {
            var arg = args[index];

            if (string.Equals(arg, name, StringComparison.OrdinalIgnoreCase) &&
                index + 1 < args.Count)
            {
                return args[index + 1];
            }

            var prefix = $"{name}=";
            if (arg.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
            {
                return arg[prefix.Length..];
            }
        }

        return null;
    }
}
