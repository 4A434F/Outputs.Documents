namespace Outputs.Documents.SampleFinder;

public sealed record DocumentModelSampleDescriptor(
    string Name,
    Type ModelType,
    Type SampleType);
