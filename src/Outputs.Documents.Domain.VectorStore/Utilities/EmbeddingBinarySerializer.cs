using System.Buffers.Binary;

namespace Outputs.Documents.Domain.VectorStore.Utilities;

internal static class EmbeddingBinarySerializer
{
    public static byte[] Serialize(IReadOnlyList<float> embedding)
    {
        if (embedding.Count == 0)
        {
            throw new ArgumentException("Embedding must not be empty.", nameof(embedding));
        }

        var bytes = new byte[embedding.Count * sizeof(float)];
        var span = bytes.AsSpan();

        for (var index = 0; index < embedding.Count; index++)
        {
            BinaryPrimitives.WriteSingleLittleEndian(
                span.Slice(index * sizeof(float), sizeof(float)),
                embedding[index]);
        }

        return bytes;
    }

    public static float[] Deserialize(byte[] bytes)
    {
        if (bytes.Length == 0 || bytes.Length % sizeof(float) != 0)
        {
            throw new InvalidOperationException("Stored embedding blob is not a valid float array.");
        }

        var embedding = new float[bytes.Length / sizeof(float)];
        var span = bytes.AsSpan();

        for (var index = 0; index < embedding.Length; index++)
        {
            embedding[index] = BinaryPrimitives.ReadSingleLittleEndian(
                span.Slice(index * sizeof(float), sizeof(float)));
        }

        return embedding;
    }
}
