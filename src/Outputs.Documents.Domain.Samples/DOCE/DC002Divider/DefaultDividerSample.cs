using DividerContract = Outputs.Documents.Domain.Contracts.DOCE.DC002Divider;

namespace Outputs.Documents.Domain.Samples.DOCE.DC002Divider;

public sealed class DefaultDividerSample : IDocumentModelSample<DividerContract>
{
    public DividerContract Create()
    {
        return new DividerContract("DOCE batch section");
    }
}
