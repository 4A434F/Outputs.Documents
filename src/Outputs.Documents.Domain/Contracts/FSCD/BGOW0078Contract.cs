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
    "BGOW0078 contract",
    "FSCD life receipt, credit notice, and treasury receipt copybook.",
    Aliases = ["BGOW0078"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0078"])]
public sealed class BGOW0078Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0078";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0078.",
        Aliases = ["BGOW0078", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0078.",
        Aliases = ["BGOW0078", "NR-APOLICE", "COD-RAMO", "DESCR-RAMO-PROD"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0078.",
        Aliases = ["BGOW0078", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE", "DO-NOME-TOMADOR"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0078.",
        Aliases = ["BGOW0078", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0078.",
        Aliases = ["BGOW0078", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "PaymentAccount",
        "Bank-account payment details identified in BGOW0078.",
        Aliases = ["BGOW0078", "DP-IBAN", "DP-SWIFT"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "payment", "banking"])]
    public BankAccount? PaymentAccount { get; init; }

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0078.",
        Aliases = ["BGOW0078", "VLR-ILIQUIDO", "VLR-BASE-TRIBUTAVEL", "VLR-IRS-IRC", "VLR-LIQUIDO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "RiskUnit",
        "Insured object, insured person, or risk-unit data identified in BGOW0078.",
        Aliases = ["BGOW0078", "DO-NOME-TOMADOR", "DO-DESC-TIPO-SIN"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "risk"])]
    public RiskUnit RiskUnit { get; init; } = new();

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0078.",
        Aliases = ["BGOW0078", "DT-EMISSAO", "DT-OCORRENCIA", "DT-EFEITO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0078.",
        Aliases = ["BGOW0078", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0078", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0078 templates.",
        Aliases = ["BGOW0078", "1048", "1051", "1052"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0078", "BGOW0078-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0078", "BGOW0078-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0078", "BGOW0078-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0078", "BGOW0078-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0078", "BGOW0078-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0078", "BGOW0078-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0078-AUX-MARCA",
        Aliases = ["BGOW0078", "BGOW0078-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0078", "BGOW0078-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0078", "BGOW0078-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0078", "BGOW0078-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0078", "BGOW0078-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0078", "BGOW0078-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0078-DADOS-DOCUMENTO",
        Aliases = ["BGOW0078", "BGOW0078-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "TipoRecibo",
        "Tipo de Recibo:",
        Aliases = ["BGOW0078", "BGOW0078-TIPO-RECIBO", "TIPO-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? TipoRecibo { get; init; }

    [DomainSearch(
        "NrRecibo",
        "Número do Recibo",
        Aliases = ["BGOW0078", "BGOW0078-NR-RECIBO", "NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? NrRecibo { get; init; }

    [DomainSearch(
        "NrSinistro",
        "Número do Sinistro",
        Aliases = ["BGOW0078", "BGOW0078-NR-SINISTRO", "NR-SINISTRO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? NrSinistro { get; init; }

    [DomainSearch(
        "NrProcesso",
        "Número do Processo",
        Aliases = ["BGOW0078", "BGOW0078-NR-PROCESSO", "NR-PROCESSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? NrProcesso { get; init; }

    [DomainSearch(
        "CodRamo",
        "Código do Ramo SO [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0078", "BGOW0078-COD-RAMO", "COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? CodRamo { get; init; }

    [DomainSearch(
        "DescrRamoProd",
        "Descritivo do Ramo / Produto",
        Aliases = ["BGOW0078", "BGOW0078-DESCR-RAMO-PROD", "DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DescrRamoProd { get; init; }

    [DomainSearch(
        "IndConfidencial",
        "Indicador de Confidencialidade:",
        Aliases = ["BGOW0078", "BGOW0078-IND-CONFIDENCIAL", "IND-CONFIDENCIAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? IndConfidencial { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0078", "BGOW0078-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0078", "BGOW0078-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0078", "BGOW0078-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0078", "BGOW0078-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0078", "BGOW0078-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0078", "BGOW0078-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0078", "BGOW0078-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0078", "BGOW0078-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0078", "BGOW0078-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0078", "BGOW0078-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0078", "BGOW0078-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0078", "BGOW0078-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "DtEmissao",
        "Data de emissão do Recibo [aaaammdd]",
        Aliases = ["BGOW0078", "BGOW0078-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DtEmissao { get; init; }

    [DomainSearch(
        "DtOcorrencia",
        "Data de ocorrência do Sinistro [aaaammdd]",
        Aliases = ["BGOW0078", "BGOW0078-DT-OCORRENCIA", "DT-OCORRENCIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DtOcorrencia { get; init; }

    [DomainSearch(
        "DtEfeito",
        "Data efeito do  Crédito [aaaammdd]",
        Aliases = ["BGOW0078", "BGOW0078-DT-EFEITO", "DT-EFEITO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DtEfeito { get; init; }

    [DomainSearch(
        "VlrIliquido",
        "Valor Ilíquido do Recibo",
        Aliases = ["BGOW0078", "BGOW0078-VLR-ILIQUIDO", "VLR-ILIQUIDO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? VlrIliquido { get; init; }

    [DomainSearch(
        "VlrBaseTributavel",
        "Valor da Base Tributável do Recibo",
        Aliases = ["BGOW0078", "BGOW0078-VLR-BASE-TRIBUTAVEL", "VLR-BASE-TRIBUTAVEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? VlrBaseTributavel { get; init; }

    [DomainSearch(
        "VlrIrsIrc",
        "Valor do IRS/IRC retido",
        Aliases = ["BGOW0078", "BGOW0078-VLR-IRS-IRC", "VLR-IRS-IRC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? VlrIrsIrc { get; init; }

    [DomainSearch(
        "VlrLiquido",
        "Valor Líquido",
        Aliases = ["BGOW0078", "BGOW0078-VLR-LIQUIDO", "VLR-LIQUIDO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? VlrLiquido { get; init; }

    [DomainSearch(
        "DpIban",
        "IBAN (SEPA)",
        Aliases = ["BGOW0078", "BGOW0078-DP-IBAN", "DP-IBAN"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DpIban { get; init; }

    [DomainSearch(
        "DpSwift",
        "SWIFT (SEPA)",
        Aliases = ["BGOW0078", "BGOW0078-DP-SWIFT", "DP-SWIFT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DpSwift { get; init; }

    [DomainSearch(
        "DpLocalPagavel",
        "Agência disponível para efectuar o Pagamento:",
        Aliases = ["BGOW0078", "BGOW0078-DP-LOCAL-PAGAVEL", "DP-LOCAL-PAGAVEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DpLocalPagavel { get; init; }

    [DomainSearch(
        "DoNomeTomador",
        "Nome do Tomador de Seguro",
        Aliases = ["BGOW0078", "BGOW0078-DO-NOME-TOMADOR", "DO-NOME-TOMADOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DoNomeTomador { get; init; }

    [DomainSearch(
        "DoDescTipoSin",
        "Descritivo do tipo de Sinistro",
        Aliases = ["BGOW0078", "BGOW0078-DO-DESC-TIPO-SIN", "DO-DESC-TIPO-SIN"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? DoDescTipoSin { get; init; }

    [DomainSearch(
        "RaGuid",
        "Referência única do Documento",
        Aliases = ["BGOW0078", "BGOW0078-RA-GUID", "RA-GUID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0078"])]
    public string? RaGuid { get; init; }

}
