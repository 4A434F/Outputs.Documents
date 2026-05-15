using DividerContract = Outputs.Documents.DOCE.Contracts.DC002Divider;

using Outputs.Documents.SampleFinder;

namespace Outputs.Documents.DOCE.Contracts.Samples.DC002Divider;

public sealed class DefaultDividerSample : IDocumentModelSample<DividerContract>
{
    public DividerContract Create()
    {
        return new DividerContract("DOCE batch section");
    }
}
