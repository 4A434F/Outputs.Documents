namespace Outputs.Documents.Domain.VectorStore.Alignment;

public sealed record AlignmentCheckResult(
    string Key,
    double Similarity,
    double Distance,
    bool IsAligned);
