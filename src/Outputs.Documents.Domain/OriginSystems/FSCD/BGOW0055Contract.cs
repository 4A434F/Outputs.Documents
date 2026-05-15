using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Documents.Primitives;
using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Payments;
using Outputs.Documents.Domain.Policies;
using Outputs.Documents.Domain.Policies.Coverages;
using Outputs.Documents.Domain.Policies.Risks;
namespace Outputs.Documents.Domain.Contracts.FSCD;

[DomainSearch(
    "BGOW0055 contract",
    "FSCD payment and debit rejection letter copybook.",
    Aliases = ["BGOW0055"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0055"])]
public sealed class BGOW0055Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0055";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0055.",
        Aliases = ["BGOW0055", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "NR-APOLICE-SO", "COD-PRODUTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0055.",
        Aliases = ["BGOW0055", "NR-APOLICE", "NR-APOLICE-SO", "COD-MOEDA", "COD-PRODUTO", "COD-RAMO", "DESCR-RAMO-PROD"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0055.",
        Aliases = ["BGOW0055", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0055.",
        Aliases = ["BGOW0055", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0055.",
        Aliases = ["BGOW0055", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "PaymentAccount",
        "Bank-account payment details identified in BGOW0055.",
        Aliases = ["BGOW0055", "CNT-NOME-BANCO", "CNT-IBAN", "CNT-SWIFT", "DEB-ADD"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "payment", "banking"])]
    public BankAccount? PaymentAccount { get; init; }

    [DomainSearch(
        "AtmPayment",
        "ATM payment entity/reference details identified in BGOW0055.",
        Aliases = ["BGOW0055", "ATM-ENTIDADE", "ATM-REF"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "payment", "atm"])]
    public AtmPaymentReference? AtmPayment { get; init; }

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0055.",
        Aliases = ["BGOW0055", "VLR-PAGAMENTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0055.",
        Aliases = ["BGOW0055", "DT-CARTA", "DT-VENCIMENTO", "DT-RESGATE", "DT-LIMITE-PAG"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0055.",
        Aliases = ["BGOW0055", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0055", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0055 templates.",
        Aliases = ["BGOW0055", "0481", "1142", "1143", "1146"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0055", "BGOW0055-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0055", "BGOW0055-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0055", "BGOW0055-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0055", "BGOW0055-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0055", "BGOW0055-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0055", "BGOW0055-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0055-AUX-MARCA",
        Aliases = ["BGOW0055", "BGOW0055-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0055", "BGOW0055-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0055", "BGOW0055-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0055", "BGOW0055-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0055", "BGOW0055-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0055", "BGOW0055-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0055-DADOS-DOCUMENTO",
        Aliases = ["BGOW0055", "BGOW0055-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "TipoCarta",
        "Tipo de Carta",
        Aliases = ["BGOW0055", "BGOW0055-TIPO-CARTA", "TIPO-CARTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? TipoCarta { get; init; }

    [DomainSearch(
        "CodMotivo",
        "Código do motivo de rejeição SEPA",
        Aliases = ["BGOW0055", "BGOW0055-COD-MOTIVO", "COD-MOTIVO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodMotivo { get; init; }

    [DomainSearch(
        "DescrMotivo",
        "Descritivo do motivo de rejeição SEPA",
        Aliases = ["BGOW0055", "BGOW0055-DESCR-MOTIVO", "DESCR-MOTIVO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DescrMotivo { get; init; }

    [DomainSearch(
        "NrApoliceSo",
        "Número da apólice Poupança Auto",
        Aliases = ["BGOW0055", "BGOW0055-NR-APOLICE-SO", "NR-APOLICE-SO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? NrApoliceSo { get; init; }

    [DomainSearch(
        "NrReciboSo",
        "Número do Recibo [Garantir que no máximo vem 11 posições Vida / 10 posições nos restantes]",
        Aliases = ["BGOW0055", "BGOW0055-NR-RECIBO-SO", "NR-RECIBO-SO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? NrReciboSo { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0055", "BGOW0055-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "CodProduto",
        "Código de Produto",
        Aliases = ["BGOW0055", "BGOW0055-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "CodRamo",
        "Código do Ramo SO",
        Aliases = ["BGOW0055", "BGOW0055-COD-RAMO", "COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CodRamo { get; init; }

    [DomainSearch(
        "DescrRamoProd",
        "Descritivo do Ramo / Produto",
        Aliases = ["BGOW0055", "BGOW0055-DESCR-RAMO-PROD", "DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DescrRamoProd { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0055", "BGOW0055-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0055", "BGOW0055-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0055", "BGOW0055-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0055", "BGOW0055-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0055", "BGOW0055-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0055", "BGOW0055-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0055", "BGOW0055-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0055", "BGOW0055-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0055", "BGOW0055-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0055", "BGOW0055-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0055", "BGOW0055-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0055", "BGOW0055-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "DtCarta",
        "Data emissão da carta [aaaammdd]",
        Aliases = ["BGOW0055", "BGOW0055-DT-CARTA", "DT-CARTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DtCarta { get; init; }

    [DomainSearch(
        "DtVencimento",
        "Data vencimento [aaaammdd]",
        Aliases = ["BGOW0055", "BGOW0055-DT-VENCIMENTO", "DT-VENCIMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DtVencimento { get; init; }

    [DomainSearch(
        "DtResgate",
        "Data de resgate [aaaammdd]",
        Aliases = ["BGOW0055", "BGOW0055-DT-RESGATE", "DT-RESGATE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DtResgate { get; init; }

    [DomainSearch(
        "DtLimitePag",
        "Data limite de pagamento [aaaammdd]",
        Aliases = ["BGOW0055", "BGOW0055-DT-LIMITE-PAG", "DT-LIMITE-PAG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DtLimitePag { get; init; }

    [DomainSearch(
        "VlrPagamento",
        "Valor em divida ou resgatado",
        Aliases = ["BGOW0055", "BGOW0055-VLR-PAGAMENTO", "VLR-PAGAMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? VlrPagamento { get; init; }

    [DomainSearch(
        "CntNomeBanco",
        "Nome do banco",
        Aliases = ["BGOW0055", "BGOW0055-CNT-NOME-BANCO", "CNT-NOME-BANCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CntNomeBanco { get; init; }

    [DomainSearch(
        "CntIban",
        "IBAN (SEPA)",
        Aliases = ["BGOW0055", "BGOW0055-CNT-IBAN", "CNT-IBAN"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CntIban { get; init; }

    [DomainSearch(
        "CntSwift",
        "SWIFT (SEPA)",
        Aliases = ["BGOW0055", "BGOW0055-CNT-SWIFT", "CNT-SWIFT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? CntSwift { get; init; }

    [DomainSearch(
        "IdCredor",
        "Identificação do credor (SEPA)",
        Aliases = ["BGOW0055", "BGOW0055-ID-CREDOR", "ID-CREDOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? IdCredor { get; init; }

    [DomainSearch(
        "DebAdd",
        "Número da ADD",
        Aliases = ["BGOW0055", "BGOW0055-DEB-ADD", "DEB-ADD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? DebAdd { get; init; }

    [DomainSearch(
        "AtmEntidade",
        "Entidade",
        Aliases = ["BGOW0055", "BGOW0055-ATM-ENTIDADE", "ATM-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? AtmEntidade { get; init; }

    [DomainSearch(
        "AtmRef",
        "Referência",
        Aliases = ["BGOW0055", "BGOW0055-ATM-REF", "ATM-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0055"])]
    public string? AtmRef { get; init; }

}
