using System.Security.Cryptography;
using System.Text;

namespace Outputs.Documents.Domain.VectorStore.Utilities;

internal static class ContentHash
{
    public static string Compute(string content)
    {
        return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(content)))
            .ToLowerInvariant();
    }
}
