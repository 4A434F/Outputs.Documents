using Outputs.Documents.Abstractions;
using Outputs.Documents.FSCD.Contracts;

namespace Outputs.Documents.FSCD.Templates;

public sealed class BGOW0044TemplateSelectionRule : IDocumentTemplateSelectionRule<BGOW0044Contract>
{
    public Type? SelectTemplate(BGOW0044Contract model, RenderSource source)
    {
        return model.DocumentIdentification switch
        {
            "1040" => typeof(FS1040CancellationCdc1PremiumTemplate),
            "1176" => typeof(FS1176LifeNonPaymentPolicyholderWithCreditTemplate),
            _ => null
        };
    }
}
