using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Payments;
using Outputs.Documents.Domain.Policies;

using Outputs.Documents.Abstractions.Samples;

namespace Outputs.Documents.FSCD.Contracts.Samples.BGOW0044Contract;

public sealed class FS1176LifeNonPaymentPolicyholderWithCreditSample : IDocumentModelSample<global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract>
{
    public global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract Create()
    {
        return new global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract
        {
            DocumentIdentification = "1176",
            Description = "Life Non-Payment Letter FP01 (FSCD) - Policyholder With Credit",
            PrimaryProgram = "PGOC114A",
            PrimaryCopybook = "BGOW0044",
            LayoutCode = "FS1176",
            OutputPrefix = "FS",
            Status = "Preview",
            Client = new Entity
            {
                Name = "RUBEN FILIPE GOUVEIA CORTE",
                TaxIdentificationNumber = "231786026",
                Address = new PostalAddress
                {
                    Name = "RUBEN FILIPE GOUVEIA CORTE",
                    Line1 = "ED GARAJAU ATLANTIC BL A RC D",
                    Line2 = "ESTRADA GARAJAU",
                    PostalCode = "9125-254",
                    PostalCodeDescription = "CANIÇO"
                }
            },
            PolicyholderName = "RUBEN FILIPE GOUVEIA CORTE",
            InsuredPeople =
            [
                new Entity
                {
                    Name = "RUBEN FILIPE GOUVEIA CORTE",
                    TaxIdentificationNumber = "231786026"
                },
                new Entity
                {
                    Name = "CARINA JOSE RODRIGUES GASPAR CORTE",
                    TaxIdentificationNumber = "228557305"
                }
            ],
            BeneficiaryIntervenorName = "CAIXA GERAL DEPOSITOS SA",
            BankProcess = "PT 00350/4/000280/2085",
            Policy = new PolicyReference
            {
                PolicyNumber = "8510016260"
            },
            Product = new ProductReference
            {
                BranchProductDescription = "Seguro Vida Crédito Habitação"
            },
            IssueDate = new DateOnly(2026, 5, 13),
            DueDate = new DateOnly(2026, 3, 13),
            PaymentLimitDate = new DateOnly(2026, 6, 11),
            DebtAmount = 65.42m,
            AtmPayment = new AtmPaymentReference
            {
                Entity = "10420",
                Reference = "386 246 748"
            },
            ReceiptDetails =
            [
                new global::Outputs.Documents.FSCD.Contracts.BGOW0044Contract.ReceiptDetail
                {
                    ReceiptNumber = "88760389221",
                    StartDate = new DateOnly(2026, 3, 13),
                    EndDate = new DateOnly(2026, 4, 12),
                    Amount = 65.42m
                }
            ]
        };
    }
}
