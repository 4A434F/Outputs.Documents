using Outputs.Documents.FSCD.Contracts;
using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Payments;
using Outputs.Documents.Domain.Policies;
using Outputs.Documents.Domain.Policies.Risks;

using Outputs.Documents.Abstractions.Samples;

namespace Outputs.Documents.FSCD.Contracts.Samples.BGOW0044Contract;

public sealed class FS1040PremiumCancellationSample : IDocumentModelSample<global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract>
{
    public global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract Create()
    {
        return new global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract
        {
            DocumentIdentification = "1040",
            Description = "CDC1 Cancellation Letter (FSCD) - Premium",
            PrimaryProgram = "PGOC114A",
            PrimaryCopybook = "BGOW0044",
            LayoutCode = "FS1040",
            OutputPrefix = "FS",
            Status = "Preview",
            PrimaryOverlays = "Sample preview data",
            Client = new Entity
            {
                Name = "ALOUNIVERSE UNIP LDA",
                TaxIdentificationNumber = "517061554",
                Address = new PostalAddress
                {
                    Name = "ALOUNIVERSE UNIP LDA",
                    Line1 = "R LUIS ADELINO FONSECA LT 1A",
                    PostalCode = "7005-345",
                    PostalCodeDescription = "EVORA"
                }
            },
            Policy = new PolicyReference
            {
                PolicyNumber = "RC66435585"
            },
            Product = new ProductReference
            {
                BranchProductDescription = "RC Exploração - Org. Eventos"
            },
            RiskUnit = new RiskUnit
            {
                Description = "Resp. Civil Geral"
            },
            IssueDate = new DateOnly(2026, 5, 13),
            CancellationDate = new DateOnly(2026, 5, 14),
            DebtAmount = 232.91m,
            AtmPayment = new AtmPaymentReference
            {
                Entity = "10420",
                Reference = "386 246 748"
            }
        };
    }
}
