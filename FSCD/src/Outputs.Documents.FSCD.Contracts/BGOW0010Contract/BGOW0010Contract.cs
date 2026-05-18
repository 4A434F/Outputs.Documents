using Outputs.Documents.Domain.Documents;
using Outputs.Documents.Domain.Documents.Primitives;
using Outputs.Documents.Domain.Entities;
using Outputs.Documents.Domain.Locations;
using Outputs.Documents.Domain.Payments;
using Outputs.Documents.Domain.Policies;
using Outputs.Documents.Domain.Policies.Coverages;
using Outputs.Documents.Domain.Policies.Risks;
namespace Outputs.Documents.FSCD.Contracts;

[DomainSearch(
    "BGOW0010 contract",
    "FSCD receipt, premium notice, and annual statement interface copybook.",
    Aliases = ["BGOW0010"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0010"])]
public sealed class BGOW0010Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0010";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0010.",
        Aliases = ["BGOW0010", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "TIPO-DOCUMENTO", "COD-PRODUTO", "VH-MARCA", "TA-NR-APOLICE", "TA-COD-PRODUTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0010.",
        Aliases = ["BGOW0010", "NR-APOLICE", "COD-MOEDA", "COD-PRODUTO", "COD-RAMO", "DESCR-RAMO-PROD", "POU-APOLICE", "VI-TIPO-APOLICE", "PS-ADERENTE", "PI-POLICY-BUS-COUNTRY", "TA-NR-APOLICE", "TA-COD-PRODUTO", "TA-COD-RAMO", "TA-DESCR-RAMO-PROD", "TA-VI-TIPO-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0010.",
        Aliases = ["BGOW0010", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE", "CTT-CLIENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0010.",
        Aliases = ["BGOW0010", "NR-AGENTE", "AG-NOME", "AG-LOCATION-REF", "AG-MORADA1", "AG-MORADA2", "AG-LOCALIDADE", "AG-CPOSTAL", "AG-CPOSTAL-DESC", "AG-CPAIS", "AG-CPAIS-DESC", "AG-IDP", "AG-TELEFONE", "AG-TELEMOVEL", "AG-EMAIL", "AG-NR-CNT-VENDA", "AG-VLR-CNT-VENDA", "AG-NR-CNT-COBRA", "AG-VLR-CNT-COBRA"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "Creditor",
        "Optional creditor or mortgage creditor party identified in BGOW0010.",
        Aliases = ["BGOW0010", "CH-QUANT", "CH-NUMBER", "CH-NOME", "CH-LOCATION-REF", "CH-MORADA1", "CH-MORADA2", "CH-LOCALIDADE", "CH-CPOSTAL", "CH-CPOSTAL-DESC", "CH-CPAIS", "CH-CPAIS-DESC", "CH-IDP"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "entity", "creditor"])]
    public Entity? Creditor { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0010.",
        Aliases = ["BGOW0010", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "AG-LOCATION-REF", "AG-MORADA1", "AG-MORADA2", "AG-LOCALIDADE", "AG-CPOSTAL", "AG-CPOSTAL-DESC", "CH-LOCATION-REF", "CH-MORADA1", "CH-MORADA2", "CH-LOCALIDADE", "CH-CPOSTAL", "CH-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "PaymentAccount",
        "Bank-account payment details identified in BGOW0010.",
        Aliases = ["BGOW0010", "DEB-NOME-BANCO", "DEB-IBAN", "DEB-SWIFT", "DEB-ID-CREDOR", "DEB-ADD"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "payment", "banking"])]
    public BankAccount? PaymentAccount { get; init; }

    [DomainSearch(
        "AtmPayment",
        "ATM payment entity/reference details identified in BGOW0010.",
        Aliases = ["BGOW0010", "ATM-ENTIDADE", "ATM-REF"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "payment", "atm"])]
    public AtmPaymentReference? AtmPayment { get; init; }

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0010.",
        Aliases = ["BGOW0010", "VLR-CAPITAL-RECIBO", "VLR-PREMIO-RISCO", "VLR-BONIFICACAO", "VLR-TOTAL-RECIBO", "VLR-FRACC", "VLR-FAT", "VLR-FGA", "VLR-SNB", "VLR-INEM", "VLR-CVERDE", "VLR-SELOS", "VLR-ACTA", "VLR-IMP-SELO", "VLR-FUND-CALAM", "VLR-FGA-OCOBERT", "VLR-FGA-RCIVIL", "VLR-BONUS", "VLR-PR-SIMPLES"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "RiskUnit",
        "Insured object, insured person, or risk-unit data identified in BGOW0010.",
        Aliases = ["BGOW0010", "VLR-PREMIO-RISCO", "UR-QUANT", "UR-TIPO", "PS-1-NOME", "PS-1-NIF", "PS-1-DT-NASC", "PS-2-NOME", "PS-2-NIF", "PS-2-DT-NASC", "VH-MARCA", "VH-MODELO", "VH-VERSAO", "VH-MATRICULA", "VG-CARTA-COND", "VG-CATEGORIA", "VO-OBJETO", "MR-OBJETO", "MR-MORADA1"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "risk"])]
    public RiskUnit RiskUnit { get; init; } = new();

    [DomainSearch(
        "TextBlocks",
        "Document text, notes, clauses, or message lines identified in BGOW0010.",
        Aliases = ["BGOW0010", "MR-IND-TEXT-FRENT", "MR-IND-TEXT-VERSO", "MR-TEXT-FRENT", "AT-IND-TEXT-FRENT", "AT-TEXT-FRENT", "MS-INDIC-MENSAGENS", "NC-IND-NOTA-ADIC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "text"])]
    public IReadOnlyList<TextBlock> TextBlocks { get; init; } = [];

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0010.",
        Aliases = ["BGOW0010", "DT-INI-RECI", "DT-FIM-RECI", "DT-CRI-RECI", "DT-LIM-PAG", "DT-LIM-DEVOL", "DT-CESSACAO", "VLR-TOTAL-RECIBO", "DT-IND-APOL-AGREGADA", "EXT5-VLR-TOTAL", "DT-VLR-CAPITAL-RECIBO", "DT-VLR-PREMIO-RISCO", "DT-VLR-BONIFICACAO", "DT-VLR-TOTAL-RECIBO", "DT-VLR-FRACC", "DT-VLR-FAT", "DT-VLR-FGA", "DT-VLR-SNB", "DT-VLR-INEM"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0010.",
        Aliases = ["BGOW0010", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0010", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0010 templates.",
        Aliases = ["BGOW0010", "1101", "1102", "1103", "1104", "1105", "1106", "1107", "1108", "1109", "1110", "1111", "1112", "1113", "1114", "1115", "1116", "1128", "1129", "1131", "1132", "1151", "1152", "1153"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0010", "BGOW0010-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0010", "BGOW0010-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0010", "BGOW0010-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0010", "BGOW0010-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0010-AUX-MARCA",
        Aliases = ["BGOW0010", "BGOW0010-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0010", "BGOW0010-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0010", "BGOW0010-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0010", "BGOW0010-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0010", "BGOW0010-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0010", "BGOW0010-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0010-DADOS-DOCUMENTO",
        Aliases = ["BGOW0010", "BGOW0010-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "TipoDocumento",
        "Tipo de Documento",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-DOCUMENTO", "TIPO-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoDocumento { get; init; }

    [DomainSearch(
        "TipoRecibo",
        "Tipo de Recibo",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-RECIBO", "TIPO-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoRecibo { get; init; }

    [DomainSearch(
        "TipoCobranca",
        "Tipo de Cobrança",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-COBRANCA", "TIPO-COBRANCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoCobranca { get; init; }

    [DomainSearch(
        "NrRecibo",
        "Número do Recibo [Garantir que no máximo vem 11 posições Vida / 10 posições nos restantes]",
        Aliases = ["BGOW0010", "BGOW0010-NR-RECIBO", "NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? NrRecibo { get; init; }

    [DomainSearch(
        "TipoEmissao",
        "Espécie de Recibo",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-EMISSAO", "TIPO-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoEmissao { get; init; }

    [DomainSearch(
        "TipoFracciona",
        "Periocidade de Pagamento / Frequência de pagamento",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-FRACCIONA", "TIPO-FRACCIONA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoFracciona { get; init; }

    [DomainSearch(
        "TipoRenovacao",
        "Modo de Renovação",
        Aliases = ["BGOW0010", "BGOW0010-TIPO-RENOVACAO", "TIPO-RENOVACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TipoRenovacao { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0010", "BGOW0010-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "CodProduto",
        "Código de Produto [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0010", "BGOW0010-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "CodRamo",
        "Código do Ramo SO [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0010", "BGOW0010-COD-RAMO", "COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CodRamo { get; init; }

    [DomainSearch(
        "DescrRamoProd",
        "Descritivo do Ramo / Produto (Para apresentação no A-R)",
        Aliases = ["BGOW0010", "BGOW0010-DESCR-RAMO-PROD", "DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DescrRamoProd { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0010", "BGOW0010-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0010", "BGOW0010-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0010", "BGOW0010-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0010", "BGOW0010-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0010", "BGOW0010-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0010", "BGOW0010-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0010", "BGOW0010-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0010", "BGOW0010-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0010", "BGOW0010-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0010", "BGOW0010-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0010", "BGOW0010-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0010", "BGOW0010-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "DtIniReci",
        "Periodo do recibo - inicio [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-DT-INI-RECI", "DT-INI-RECI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtIniReci { get; init; }

    [DomainSearch(
        "DtFimReci",
        "Periodo do recibo - fim [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-DT-FIM-RECI", "DT-FIM-RECI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtFimReci { get; init; }

    [DomainSearch(
        "DtCriReci",
        "Emissão do recibo [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-DT-CRI-RECI", "DT-CRI-RECI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtCriReci { get; init; }

    [DomainSearch(
        "DtLimPag",
        "[aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-DT-LIM-PAG", "DT-LIM-PAG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtLimPag { get; init; }

    [DomainSearch(
        "DtLimDevol",
        "[aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-DT-LIM-DEVOL", "DT-LIM-DEVOL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtLimDevol { get; init; }

    [DomainSearch(
        "DtCessacao",
        "[aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-DT-CESSACAO", "DT-CESSACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtCessacao { get; init; }

    [DomainSearch(
        "VlrCapitalRecibo",
        "Valor do capital / valor da entrega - Descritivo: 'CAPITAL' | 'PREMIO INVEST' |'CAPITAL ENTREGUE'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-CAPITAL-RECIBO", "VLR-CAPITAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrCapitalRecibo { get; init; }

    [DomainSearch(
        "VlrPremioRisco",
        "Valor de Prémio de Risco - Descritivo: 'PRÉMIO RISCO'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-PREMIO-RISCO", "VLR-PREMIO-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrPremioRisco { get; init; }

    [DomainSearch(
        "VlrBonificacao",
        "Bonificação (Colheitas) - Descritivo: 'BONIFICAÇÃO'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-BONIFICACAO", "VLR-BONIFICACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrBonificacao { get; init; }

    [DomainSearch(
        "VlrTotalRecibo",
        "Prémio total recibo - Descritivo: 'VALOR A PAGAR' | 'VALOR A RECEBER' | 'TOTAL DE PRÉMIOS'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-TOTAL-RECIBO", "VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrTotalRecibo { get; init; }

    [DomainSearch(
        "VlrFracc",
        "Custo de Fraccionamento - Descritivo: 'CUSTO FRACCIONAMENTO'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-FRACC", "VLR-FRACC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrFracc { get; init; }

    [DomainSearch(
        "VlrFat",
        "Fundo de Garantia de Acidentes de Trabalho - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-FAT", "VLR-FAT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrFat { get; init; }

    [DomainSearch(
        "VlrFga",
        "Fundo de Garantia Automóvel - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-FGA", "VLR-FGA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrFga { get; init; }

    [DomainSearch(
        "VlrSnb",
        "Imposto Serviço Nacional de Bombeiros - Descritivo: 'SNB' | 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-SNB", "VLR-SNB"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrSnb { get; init; }

    [DomainSearch(
        "VlrInem",
        "Imposto INEM - Descritivo: 'INEM'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-INEM", "VLR-INEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrInem { get; init; }

    [DomainSearch(
        "VlrCverde",
        "Custo da Carta Verde - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-CVERDE", "VLR-CVERDE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrCverde { get; init; }

    [DomainSearch(
        "VlrSelos",
        "Descritivo: 'SELO de GARANTIA'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-SELOS", "VLR-SELOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrSelos { get; init; }

    [DomainSearch(
        "VlrActa",
        "Custo da Acta/Apólice - Descritivo: 'APÓLICE / ACTA' | 'CUSTO CERTIFICADO'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-ACTA", "VLR-ACTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrActa { get; init; }

    [DomainSearch(
        "VlrImpSelo",
        "Imposto de Selo - Descritivo: 'SELO'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-IMP-SELO", "VLR-IMP-SELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrImpSelo { get; init; }

    [DomainSearch(
        "VlrFundCalam",
        "Fundo de calamidades - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-FUND-CALAM", "VLR-FUND-CALAM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrFundCalam { get; init; }

    [DomainSearch(
        "VlrFgaOcobert",
        "FGA, Outras Coberturas do Ramo Contabilistico - Descritivo: 'FGA-PR (*)'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-FGA-OCOBERT", "VLR-FGA-OCOBERT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrFgaOcobert { get; init; }

    [DomainSearch(
        "VlrFgaRcivil",
        "FGA, Responsabilidade Civil do Ramo Contabilistico - Descritivo: 'FGA (*)'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-FGA-RCIVIL", "VLR-FGA-RCIVIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrFgaRcivil { get; init; }

    [DomainSearch(
        "VlrBonus",
        "Bónus - Descritivo: 'BONUS'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-BONUS", "VLR-BONUS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrBonus { get; init; }

    [DomainSearch(
        "VlrPrSimples",
        "Prémio Simples - Descritivo: 'PRÉMIO COMERCIAL'",
        Aliases = ["BGOW0010", "BGOW0010-VLR-PR-SIMPLES", "VLR-PR-SIMPLES"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrPrSimples { get; init; }

    [DomainSearch(
        "VlrPrAnual",
        "Actualização do Prémio Anual",
        Aliases = ["BGOW0010", "BGOW0010-VLR-PR-ANUAL", "VLR-PR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VlrPrAnual { get; init; }

    [DomainSearch(
        "DebNomeBanco",
        "Nome do banco",
        Aliases = ["BGOW0010", "BGOW0010-DEB-NOME-BANCO", "DEB-NOME-BANCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DebNomeBanco { get; init; }

    [DomainSearch(
        "DebIban",
        "IBAN (SEPA)",
        Aliases = ["BGOW0010", "BGOW0010-DEB-IBAN", "DEB-IBAN"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DebIban { get; init; }

    [DomainSearch(
        "DebSwift",
        "SWIFT (SEPA)",
        Aliases = ["BGOW0010", "BGOW0010-DEB-SWIFT", "DEB-SWIFT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DebSwift { get; init; }

    [DomainSearch(
        "DebIdCredor",
        "Entidade Credora (SEPA)",
        Aliases = ["BGOW0010", "BGOW0010-DEB-ID-CREDOR", "DEB-ID-CREDOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DebIdCredor { get; init; }

    [DomainSearch(
        "DebAdd",
        "Número da ADD",
        Aliases = ["BGOW0010", "BGOW0010-DEB-ADD", "DEB-ADD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DebAdd { get; init; }

    [DomainSearch(
        "AtmEntidade",
        "Entidade",
        Aliases = ["BGOW0010", "BGOW0010-ATM-ENTIDADE", "ATM-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AtmEntidade { get; init; }

    [DomainSearch(
        "AtmRef",
        "Referência",
        Aliases = ["BGOW0010", "BGOW0010-ATM-REF", "ATM-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AtmRef { get; init; }

    [DomainSearch(
        "CttCliente",
        "Cliente CTT",
        Aliases = ["BGOW0010", "BGOW0010-CTT-CLIENTE", "CTT-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CttCliente { get; init; }

    [DomainSearch(
        "CttRef",
        "Referência CTT",
        Aliases = ["BGOW0010", "BGOW0010-CTT-REF", "CTT-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CttRef { get; init; }

    [DomainSearch(
        "NumerosAgente",
        "Código de barras TAG",
        Aliases = ["BGOW0010", "BGOW0010-NUMEROS-AGENTE", "NUMEROS-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? NumerosAgente { get; init; }

    [DomainSearch(
        "PouApolice",
        "Número da Apólice Poupança Auto",
        Aliases = ["BGOW0010", "BGOW0010-POU-APOLICE", "POU-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? PouApolice { get; init; }

    [DomainSearch(
        "AgNome",
        "Nome",
        Aliases = ["BGOW0010", "BGOW0010-AG-NOME", "AG-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgNome { get; init; }

    [DomainSearch(
        "AgLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0010", "BGOW0010-AG-LOCATION-REF", "AG-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgLocationRef { get; init; }

    [DomainSearch(
        "AgMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0010", "BGOW0010-AG-MORADA1", "AG-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgMorada1 { get; init; }

    [DomainSearch(
        "AgMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0010", "BGOW0010-AG-MORADA2", "AG-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgMorada2 { get; init; }

    [DomainSearch(
        "AgLocalidade",
        "Localidade",
        Aliases = ["BGOW0010", "BGOW0010-AG-LOCALIDADE", "AG-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgLocalidade { get; init; }

    [DomainSearch(
        "AgCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0010", "BGOW0010-AG-CPOSTAL", "AG-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgCpostal { get; init; }

    [DomainSearch(
        "AgCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0010", "BGOW0010-AG-CPOSTAL-DESC", "AG-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgCpostalDesc { get; init; }

    [DomainSearch(
        "AgCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0010", "BGOW0010-AG-CPAIS", "AG-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgCpais { get; init; }

    [DomainSearch(
        "AgCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0010", "BGOW0010-AG-CPAIS-DESC", "AG-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgCpaisDesc { get; init; }

    [DomainSearch(
        "AgIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0010", "BGOW0010-AG-IDP", "AG-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgIdp { get; init; }

    [DomainSearch(
        "AgTelefone",
        "Número de telefone",
        Aliases = ["BGOW0010", "BGOW0010-AG-TELEFONE", "AG-TELEFONE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgTelefone { get; init; }

    [DomainSearch(
        "AgTelemovel",
        "Número de telemóvel",
        Aliases = ["BGOW0010", "BGOW0010-AG-TELEMOVEL", "AG-TELEMOVEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgTelemovel { get; init; }

    [DomainSearch(
        "AgEmail",
        "e-mail",
        Aliases = ["BGOW0010", "BGOW0010-AG-EMAIL", "AG-EMAIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgEmail { get; init; }

    [DomainSearch(
        "AgNrCntVenda",
        "Conta Mediação",
        Aliases = ["BGOW0010", "BGOW0010-AG-NR-CNT-VENDA", "AG-NR-CNT-VENDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgNrCntVenda { get; init; }

    [DomainSearch(
        "AgVlrCntVenda",
        "Comissão de Mediação",
        Aliases = ["BGOW0010", "BGOW0010-AG-VLR-CNT-VENDA", "AG-VLR-CNT-VENDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgVlrCntVenda { get; init; }

    [DomainSearch(
        "AgNrCntCobra",
        "Conta Cobrança",
        Aliases = ["BGOW0010", "BGOW0010-AG-NR-CNT-COBRA", "AG-NR-CNT-COBRA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgNrCntCobra { get; init; }

    [DomainSearch(
        "AgVlrCntCobra",
        "Comissão de Cobrança",
        Aliases = ["BGOW0010", "BGOW0010-AG-VLR-CNT-COBRA", "AG-VLR-CNT-COBRA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgVlrCntCobra { get; init; }

    [DomainSearch(
        "AgNrCntEspec",
        "Conta Especial",
        Aliases = ["BGOW0010", "BGOW0010-AG-NR-CNT-ESPEC", "AG-NR-CNT-ESPEC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgNrCntEspec { get; init; }

    [DomainSearch(
        "AgVlrCntEspec",
        "Comissão Especial",
        Aliases = ["BGOW0010", "BGOW0010-AG-VLR-CNT-ESPEC", "AG-VLR-CNT-ESPEC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgVlrCntEspec { get; init; }

    [DomainSearch(
        "AgNrCntParce",
        "Conta Parceria",
        Aliases = ["BGOW0010", "BGOW0010-AG-NR-CNT-PARCE", "AG-NR-CNT-PARCE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgNrCntParce { get; init; }

    [DomainSearch(
        "AgVlrCntParce",
        "Comissão Parceria",
        Aliases = ["BGOW0010", "BGOW0010-AG-VLR-CNT-PARCE", "AG-VLR-CNT-PARCE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AgVlrCntParce { get; init; }

    [DomainSearch(
        "ChQuant",
        "Número de Credores Hipotecários (Só preenche abaixo se for 1)",
        Aliases = ["BGOW0010", "BGOW0010-CH-QUANT", "CH-QUANT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChQuant { get; init; }

    [DomainSearch(
        "ChNumber",
        "Número de Cliente do Credor Hipotecário",
        Aliases = ["BGOW0010", "BGOW0010-CH-NUMBER", "CH-NUMBER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChNumber { get; init; }

    [DomainSearch(
        "ChNome",
        "Nome",
        Aliases = ["BGOW0010", "BGOW0010-CH-NOME", "CH-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChNome { get; init; }

    [DomainSearch(
        "ChLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0010", "BGOW0010-CH-LOCATION-REF", "CH-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChLocationRef { get; init; }

    [DomainSearch(
        "ChMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0010", "BGOW0010-CH-MORADA1", "CH-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChMorada1 { get; init; }

    [DomainSearch(
        "ChMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0010", "BGOW0010-CH-MORADA2", "CH-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChMorada2 { get; init; }

    [DomainSearch(
        "ChLocalidade",
        "Localidade",
        Aliases = ["BGOW0010", "BGOW0010-CH-LOCALIDADE", "CH-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChLocalidade { get; init; }

    [DomainSearch(
        "ChCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0010", "BGOW0010-CH-CPOSTAL", "CH-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChCpostal { get; init; }

    [DomainSearch(
        "ChCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0010", "BGOW0010-CH-CPOSTAL-DESC", "CH-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChCpostalDesc { get; init; }

    [DomainSearch(
        "ChCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0010", "BGOW0010-CH-CPAIS", "CH-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChCpais { get; init; }

    [DomainSearch(
        "ChCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0010", "BGOW0010-CH-CPAIS-DESC", "CH-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChCpaisDesc { get; init; }

    [DomainSearch(
        "ChIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0010", "BGOW0010-CH-IDP", "CH-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ChIdp { get; init; }

    [DomainSearch(
        "UrQuant",
        "Número de unidades em risco",
        Aliases = ["BGOW0010", "BGOW0010-UR-QUANT", "UR-QUANT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? UrQuant { get; init; }

    [DomainSearch(
        "UrTipo",
        "Tipo de Unidade em risco",
        Aliases = ["BGOW0010", "BGOW0010-UR-TIPO", "UR-TIPO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? UrTipo { get; init; }

    [DomainSearch(
        "DadosUr",
        "BGOW0010-DADOS-UR",
        Aliases = ["BGOW0010", "BGOW0010-DADOS-UR", "DADOS-UR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DadosUr { get; init; }

    [DomainSearch(
        "GrDetail",
        "Descritivo da unidade em risco (Objeto seguro)",
        Aliases = ["BGOW0010", "BGOW0010-GR-DETAIL", "GR-DETAIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? GrDetail { get; init; }

    [DomainSearch(
        "Ps1Nome",
        "Nome Pessoa segura 1",
        Aliases = ["BGOW0010", "BGOW0010-PS-1-NOME", "PS-1-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ps1Nome { get; init; }

    [DomainSearch(
        "Ps1Nif",
        "NIF Pessoa segura 1  (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0010", "BGOW0010-PS-1-NIF", "PS-1-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ps1Nif { get; init; }

    [DomainSearch(
        "Ps1DtNasc",
        "Data de Nascimento Pessoa segura 1 [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-PS-1-DT-NASC", "PS-1-DT-NASC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ps1DtNasc { get; init; }

    [DomainSearch(
        "Ps2Nome",
        "Nome Pessoa segura 2",
        Aliases = ["BGOW0010", "BGOW0010-PS-2-NOME", "PS-2-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ps2Nome { get; init; }

    [DomainSearch(
        "Ps2Nif",
        "NIF Pessoa segura 2  (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0010", "BGOW0010-PS-2-NIF", "PS-2-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ps2Nif { get; init; }

    [DomainSearch(
        "Ps2DtNasc",
        "Data de Nascimento Pessoa segura 2 [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-PS-2-DT-NASC", "PS-2-DT-NASC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ps2DtNasc { get; init; }

    [DomainSearch(
        "ViEncarAquisicao",
        "Valor dos encargos Aquisição - componente da parcela com Descritivo: 'ENCARGOS'",
        Aliases = ["BGOW0010", "BGOW0010-VI-ENCAR-AQUISICAO", "VI-ENCAR-AQUISICAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ViEncarAquisicao { get; init; }

    [DomainSearch(
        "ViEncarPenaliza",
        "Valor dos encargos Penalização - Parcela das Faturas de Indemnizações com Descritivo: ENCARGOS/COMISSÕES",
        Aliases = ["BGOW0010", "BGOW0010-VI-ENCAR-PENALIZA", "VI-ENCAR-PENALIZA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ViEncarPenaliza { get; init; }

    [DomainSearch(
        "ViTipoApolice",
        "Tipo de Apólice Vida",
        Aliases = ["BGOW0010", "BGOW0010-VI-TIPO-APOLICE", "VI-TIPO-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ViTipoApolice { get; init; }

    [DomainSearch(
        "AuArea",
        "BGOW0010-AU-AREA",
        Aliases = ["BGOW0010", "BGOW0010-AU-AREA", "AU-AREA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AuArea { get; init; }

    [DomainSearch(
        "VhMarca",
        "Marca",
        Aliases = ["BGOW0010", "BGOW0010-VH-MARCA", "VH-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VhMarca { get; init; }

    [DomainSearch(
        "VhModelo",
        "Modelo",
        Aliases = ["BGOW0010", "BGOW0010-VH-MODELO", "VH-MODELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VhModelo { get; init; }

    [DomainSearch(
        "VhVersao",
        "Versão",
        Aliases = ["BGOW0010", "BGOW0010-VH-VERSAO", "VH-VERSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VhVersao { get; init; }

    [DomainSearch(
        "VhMatricula",
        "Matrícula",
        Aliases = ["BGOW0010", "BGOW0010-VH-MATRICULA", "VH-MATRICULA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VhMatricula { get; init; }

    [DomainSearch(
        "VgCartaCond",
        "Carta de Condução",
        Aliases = ["BGOW0010", "BGOW0010-VG-CARTA-COND", "VG-CARTA-COND"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VgCartaCond { get; init; }

    [DomainSearch(
        "VgCategoria",
        "Categoria (ex: Garagista até 3500Kg)",
        Aliases = ["BGOW0010", "BGOW0010-VG-CATEGORIA", "VG-CATEGORIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VgCategoria { get; init; }

    [DomainSearch(
        "VoObjeto",
        "BGOW0010-VO-OBJETO",
        Aliases = ["BGOW0010", "BGOW0010-VO-OBJETO", "VO-OBJETO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? VoObjeto { get; init; }

    [DomainSearch(
        "MrObjeto",
        "Objeto",
        Aliases = ["BGOW0010", "BGOW0010-MR-OBJETO", "MR-OBJETO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrObjeto { get; init; }

    [DomainSearch(
        "MrMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0010", "BGOW0010-MR-MORADA1", "MR-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrMorada1 { get; init; }

    [DomainSearch(
        "MrMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0010", "BGOW0010-MR-MORADA2", "MR-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrMorada2 { get; init; }

    [DomainSearch(
        "MrLocalidade",
        "Localidade",
        Aliases = ["BGOW0010", "BGOW0010-MR-LOCALIDADE", "MR-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrLocalidade { get; init; }

    [DomainSearch(
        "MrCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0010", "BGOW0010-MR-CPOSTAL", "MR-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrCpostal { get; init; }

    [DomainSearch(
        "MrCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0010", "BGOW0010-MR-CPOSTAL-DESC", "MR-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrCpostalDesc { get; init; }

    [DomainSearch(
        "AtObjeto",
        "Objeto",
        Aliases = ["BGOW0010", "BGOW0010-AT-OBJETO", "AT-OBJETO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AtObjeto { get; init; }

    [DomainSearch(
        "DadosOut",
        "BGOW0010-DADOS-OUT",
        Aliases = ["BGOW0010", "BGOW0010-DADOS-OUT", "DADOS-OUT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DadosOut { get; init; }

    [DomainSearch(
        "PsTipo",
        "Tipo de apólice Vida",
        Aliases = ["BGOW0010", "BGOW0010-PS-TIPO", "PS-TIPO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? PsTipo { get; init; }

    [DomainSearch(
        "PsAderente",
        "Número de Aderente - 'PES. SEGURA' (Obs: Preenchido, significa que o nr de apólice é composto)",
        Aliases = ["BGOW0010", "BGOW0010-PS-ADERENTE", "PS-ADERENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? PsAderente { get; init; }

    [DomainSearch(
        "LtQtRecibos",
        "Quantidade de recibos no lote",
        Aliases = ["BGOW0010", "BGOW0010-LT-QT-RECIBOS", "LT-QT-RECIBOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? LtQtRecibos { get; init; }

    [DomainSearch(
        "MrIndTextFrent",
        "Indicador de inclusão de texto no Aviso (ex: \"S\" - MR Hab)",
        Aliases = ["BGOW0010", "BGOW0010-MR-IND-TEXT-FRENT", "MR-IND-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrIndTextFrent { get; init; }

    [DomainSearch(
        "MrIndTextVerso",
        "Indicador de inclusão de texto no verso do Aviso (ex: \"1\" - Riscos Simples e \"2\" - Riscos Industriais)",
        Aliases = ["BGOW0010", "BGOW0010-MR-IND-TEXT-VERSO", "MR-IND-TEXT-VERSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrIndTextVerso { get; init; }

    [DomainSearch(
        "MrCapImov",
        "Descritivo: 'CAPITAL IMÓVEL'",
        Aliases = ["BGOW0010", "BGOW0010-MR-CAP-IMOV", "MR-CAP-IMOV"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrCapImov { get; init; }

    [DomainSearch(
        "MrTipoActz",
        "Tipo de atualização tarifária (ex: \"CA\" - Convencionada, \"IA\" - Indexada, \"SA\" - Sem actualização, \"VA\" - Vários)",
        Aliases = ["BGOW0010", "BGOW0010-MR-TIPO-ACTZ", "MR-TIPO-ACTZ"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrTipoActz { get; init; }

    [DomainSearch(
        "MrTextFrent",
        "Inclusão de texto na frente do Aviso",
        Aliases = ["BGOW0010", "BGOW0010-MR-TEXT-FRENT", "MR-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MrTextFrent { get; init; }

    [DomainSearch(
        "AtIndTextFrent",
        "Indicador de inclusão de texto no Aviso (ex: \"A\" - AT Portaria e \"T\" - AT Tarif)",
        Aliases = ["BGOW0010", "BGOW0010-AT-IND-TEXT-FRENT", "AT-IND-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AtIndTextFrent { get; init; }

    [DomainSearch(
        "AtTextFrent",
        "Inclusão de texto na frente do Aviso",
        Aliases = ["BGOW0010", "BGOW0010-AT-TEXT-FRENT", "AT-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AtTextFrent { get; init; }

    [DomainSearch(
        "Ext1TipoLayout",
        "Tipo de layout (ex: \"N\" - Novo, \"A\" - Alteração) [\"N\" inclui alterações ao Tipo Pagamento para EFT]",
        Aliases = ["BGOW0010", "BGOW0010-EXT1-TIPO-LAYOUT", "EXT1-TIPO-LAYOUT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext1TipoLayout { get; init; }

    [DomainSearch(
        "Ext1DtIniAnui",
        "Periodo da anuidade - inicio [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-EXT1-DT-INI-ANUI", "EXT1-DT-INI-ANUI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext1DtIniAnui { get; init; }

    [DomainSearch(
        "Ext1DtFimAnui",
        "Periodo da anuidade - fim [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-EXT1-DT-FIM-ANUI", "EXT1-DT-FIM-ANUI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext1DtFimAnui { get; init; }

    [DomainSearch(
        "Ext1VlrTotPago",
        "Valor Total da Anuidade já pago",
        Aliases = ["BGOW0010", "BGOW0010-EXT1-VLR-TOT-PAGO", "EXT1-VLR-TOT-PAGO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext1VlrTotPago { get; init; }

    [DomainSearch(
        "CfNifEmitente",
        "Número de Identificação do Emitente",
        Aliases = ["BGOW0010", "BGOW0010-CF-NIF-EMITENTE", "CF-NIF-EMITENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfNifEmitente { get; init; }

    [DomainSearch(
        "CfNumCertifAviso",
        "Número de Certificação do Aviso",
        Aliases = ["BGOW0010", "BGOW0010-CF-NUM-CERTIF-AVISO", "CF-NUM-CERTIF-AVISO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfNumCertifAviso { get; init; }

    [DomainSearch(
        "CfAtcud",
        "Código Único do Documento",
        Aliases = ["BGOW0010", "BGOW0010-CF-ATCUD", "CF-ATCUD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfAtcud { get; init; }

    [DomainSearch(
        "CfNumProgCertif",
        "Número do Programa de Certificação",
        Aliases = ["BGOW0010", "BGOW0010-CF-NUM-PROG-CERTIF", "CF-NUM-PROG-CERTIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfNumProgCertif { get; init; }

    [DomainSearch(
        "CfHash",
        "Número do HASH",
        Aliases = ["BGOW0010", "BGOW0010-CF-HASH", "CF-HASH"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfHash { get; init; }

    [DomainSearch(
        "CfNumCompromisso",
        "Número do Compromisso",
        Aliases = ["BGOW0010", "BGOW0010-CF-NUM-COMPROMISSO", "CF-NUM-COMPROMISSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfNumCompromisso { get; init; }

    [DomainSearch(
        "CfBaseTributavel",
        "Valor Base Tributável",
        Aliases = ["BGOW0010", "BGOW0010-CF-BASE-TRIBUTAVEL", "CF-BASE-TRIBUTAVEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfBaseTributavel { get; init; }

    [DomainSearch(
        "CfEstadoDocumento",
        "Estado do Documento",
        Aliases = ["BGOW0010", "BGOW0010-CF-ESTADO-DOCUMENTO", "CF-ESTADO-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfEstadoDocumento { get; init; }

    [DomainSearch(
        "CfEspacoFiscalIva",
        "Espaço Fiscal",
        Aliases = ["BGOW0010", "BGOW0010-CF-ESPACO-FISCAL-IVA", "CF-ESPACO-FISCAL-IVA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfEspacoFiscalIva { get; init; }

    [DomainSearch(
        "CfNumCertifFatura",
        "Número de Certificação da Fatura",
        Aliases = ["BGOW0010", "BGOW0010-CF-NUM-CERTIF-FATURA", "CF-NUM-CERTIF-FATURA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? CfNumCertifFatura { get; init; }

    [DomainSearch(
        "MsIndicMensagens",
        "Indicador de mensagem temporária",
        Aliases = ["BGOW0010", "BGOW0010-MS-INDIC-MENSAGENS", "MS-INDIC-MENSAGENS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? MsIndicMensagens { get; init; }

    [DomainSearch(
        "RaGuid",
        "Chave Única do documento",
        Aliases = ["BGOW0010", "BGOW0010-RA-GUID", "RA-GUID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? RaGuid { get; init; }

    [DomainSearch(
        "ApPrTotAno",
        "Valor do Prémio Total da Anuidade",
        Aliases = ["BGOW0010", "BGOW0010-AP-PR-TOT-ANO", "AP-PR-TOT-ANO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ApPrTotAno { get; init; }

    [DomainSearch(
        "ApPrTotAnoAnt",
        "Valor do Prémio Total da Anuidade anterior",
        Aliases = ["BGOW0010", "BGOW0010-AP-PR-TOT-ANO-ANT", "AP-PR-TOT-ANO-ANT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? ApPrTotAnoAnt { get; init; }

    [DomainSearch(
        "AfVarPremioTot",
        "Percentagem da variação do Prémio Total",
        Aliases = ["BGOW0010", "BGOW0010-AF-VAR-PREMIO-TOT", "AF-VAR-PREMIO-TOT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfVarPremioTot { get; init; }

    [DomainSearch(
        "AfFatFiscalidade",
        "Percentagem da variação do Prémio atribuída ao Fator Fiscalidade",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-FISCALIDADE", "AF-FAT-FISCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatFiscalidade { get; init; }

    [DomainSearch(
        "AfFatSinistros",
        "Percentagem da variação do Prémio atribuída ao Fator Sinistralidade",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-SINISTROS", "AF-FAT-SINISTROS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatSinistros { get; init; }

    [DomainSearch(
        "AfFatInflacao",
        "Percentagem da variação do Prémio atribuída ao Fator Inflação",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-INFLACAO", "AF-FAT-INFLACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatInflacao { get; init; }

    [DomainSearch(
        "AfFatVarCapitais",
        "Percentagem da variação do Prémio atribuída ao Fator variação de Capitais",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-VAR-CAPITAIS", "AF-FAT-VAR-CAPITAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatVarCapitais { get; init; }

    [DomainSearch(
        "AfFatVitality",
        "Percentagem da variação do Prémio atribuída ao Fator Vitality ( só para Saúde)",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-VITALITY", "AF-FAT-VITALITY"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatVitality { get; init; }

    [DomainSearch(
        "AfFatIdade",
        "Percentagem da variação do Prémio atribuída ao Fator Idade ( só para Saúde)",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-IDADE", "AF-FAT-IDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatIdade { get; init; }

    [DomainSearch(
        "AfFatOutros",
        "Percentagem da variação do Prémio atribuída a outros Fatores",
        Aliases = ["BGOW0010", "BGOW0010-AF-FAT-OUTROS", "AF-FAT-OUTROS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? AfFatOutros { get; init; }

    [DomainSearch(
        "DtIndApolAgregada",
        "Indicador de Apólice Agregada (S/N)",
        Aliases = ["BGOW0010", "BGOW0010-DT-IND-APOL-AGREGADA", "DT-IND-APOL-AGREGADA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtIndApolAgregada { get; init; }

    [DomainSearch(
        "PiPolicyBusCountry",
        "País do negócio da Apólice",
        Aliases = ["BGOW0010", "BGOW0010-PI-POLICY-BUS-COUNTRY", "PI-POLICY-BUS-COUNTRY"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? PiPolicyBusCountry { get; init; }

    [DomainSearch(
        "PiVlrImposto",
        "Valor de Impostos para Apólices de programas Internacionais:  somatório de impostos fiscais(VFISC), parafiscais(VPFIS) e consórcios(VCONS)",
        Aliases = ["BGOW0010", "BGOW0010-PI-VLR-IMPOSTO", "PI-VLR-IMPOSTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? PiVlrImposto { get; init; }

    [DomainSearch(
        "NcIndNotaAdic",
        "Indicador de existência de nota Adicional do Recibo de Acerto",
        Aliases = ["BGOW0010", "BGOW0010-NC-IND-NOTA-ADIC", "NC-IND-NOTA-ADIC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? NcIndNotaAdic { get; init; }

    [DomainSearch(
        "Ext2InstalmentNr",
        "Número de fracção (Valores de 001 a 012, e 999)",
        Aliases = ["BGOW0010", "BGOW0010-EXT2-INSTALMENT-NR", "EXT2-INSTALMENT-NR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext2InstalmentNr { get; init; }

    [DomainSearch(
        "Ext2DtIniRec",
        "Data inicio [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-EXT2-DT-INI-REC", "EXT2-DT-INI-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext2DtIniRec { get; init; }

    [DomainSearch(
        "Ext2DtFimRec",
        "Data fim [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-EXT2-DT-FIM-REC", "EXT2-DT-FIM-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext2DtFimRec { get; init; }

    [DomainSearch(
        "Ext2VlrMov",
        "Valor do movimento",
        Aliases = ["BGOW0010", "BGOW0010-EXT2-VLR-MOV", "EXT2-VLR-MOV"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext2VlrMov { get; init; }

    [DomainSearch(
        "Ext2DtVencim",
        "Data vencimento [aaaammdd]",
        Aliases = ["BGOW0010", "BGOW0010-EXT2-DT-VENCIM", "EXT2-DT-VENCIM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext2DtVencim { get; init; }

    [DomainSearch(
        "Ext5VlrTotal",
        "Valor total",
        Aliases = ["BGOW0010", "BGOW0010-EXT5-VLR-TOTAL", "EXT5-VLR-TOTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? Ext5VlrTotal { get; init; }

    [DomainSearch(
        "TaNrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0010", "BGOW0010-TA-NR-APOLICE", "TA-NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TaNrApolice { get; init; }

    [DomainSearch(
        "TaCodProduto",
        "Código de Produto [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0010", "BGOW0010-TA-COD-PRODUTO", "TA-COD-PRODUTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TaCodProduto { get; init; }

    [DomainSearch(
        "TaCodRamo",
        "Código do Ramo SO [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0010", "BGOW0010-TA-COD-RAMO", "TA-COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TaCodRamo { get; init; }

    [DomainSearch(
        "TaDescrRamoProd",
        "Descritivo do Ramo / Produto (Para apresentação no A-R)",
        Aliases = ["BGOW0010", "BGOW0010-TA-DESCR-RAMO-PROD", "TA-DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TaDescrRamoProd { get; init; }

    [DomainSearch(
        "TaViTipoApolice",
        "Tipo de Apólice Vida",
        Aliases = ["BGOW0010", "BGOW0010-TA-VI-TIPO-APOLICE", "TA-VI-TIPO-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? TaViTipoApolice { get; init; }

    [DomainSearch(
        "DtVlrCapitalRecibo",
        "Valor do capital / valor da entrega - Descritivo: 'CAPITAL' | 'PREMIO INVEST' |'CAPITAL ENTREGUE'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-CAPITAL-RECIBO", "DT-VLR-CAPITAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrCapitalRecibo { get; init; }

    [DomainSearch(
        "DtVlrPremioRisco",
        "Valor de Prémio de Risco - Descritivo: 'PRÉMIO RISCO'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-PREMIO-RISCO", "DT-VLR-PREMIO-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrPremioRisco { get; init; }

    [DomainSearch(
        "DtVlrBonificacao",
        "Bonificação (Colheitas) - Descritivo: 'BONIFICAÇÃO'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-BONIFICACAO", "DT-VLR-BONIFICACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrBonificacao { get; init; }

    [DomainSearch(
        "DtVlrTotalRecibo",
        "Prémio total recibo - Descritivo: 'VALOR A PAGAR' | 'VALOR A RECEBER' | 'TOTAL DE PRÉMIOS'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-TOTAL-RECIBO", "DT-VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrTotalRecibo { get; init; }

    [DomainSearch(
        "DtVlrFracc",
        "Custo de Fraccionamento - Descritivo: 'CUSTO FRACCIONAMENTO'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-FRACC", "DT-VLR-FRACC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrFracc { get; init; }

    [DomainSearch(
        "DtVlrFat",
        "Fundo de Garantia de Acidentes de Trabalho - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-FAT", "DT-VLR-FAT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrFat { get; init; }

    [DomainSearch(
        "DtVlrFga",
        "Fundo de Garantia Automóvel - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-FGA", "DT-VLR-FGA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrFga { get; init; }

    [DomainSearch(
        "DtVlrSnb",
        "Imposto Serviço Nacional de Bombeiros - Descritivo: 'SNB' | 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-SNB", "DT-VLR-SNB"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrSnb { get; init; }

    [DomainSearch(
        "DtVlrInem",
        "Imposto INEM - Descritivo: 'INEM'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-INEM", "DT-VLR-INEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrInem { get; init; }

    [DomainSearch(
        "DtVlrCverde",
        "Custo da Carta Verde - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-CVERDE", "DT-VLR-CVERDE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrCverde { get; init; }

    [DomainSearch(
        "DtVlrSelos",
        "Descritivo: 'SELO de GARANTIA'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-SELOS", "DT-VLR-SELOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrSelos { get; init; }

    [DomainSearch(
        "DtVlrActa",
        "Custo da Acta/Apólice - Descritivo: 'APÓLICE / ACTA' | 'CUSTO CERTIFICADO'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-ACTA", "DT-VLR-ACTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrActa { get; init; }

    [DomainSearch(
        "DtVlrImpSelo",
        "Imposto de Selo - Descritivo: 'SELO'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-IMP-SELO", "DT-VLR-IMP-SELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrImpSelo { get; init; }

    [DomainSearch(
        "DtVlrFundCalam",
        "Fundo de calamidades - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-FUND-CALAM", "DT-VLR-FUND-CALAM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrFundCalam { get; init; }

    [DomainSearch(
        "DtVlrFgaOcobert",
        "FGA, Outras Coberturas do Ramo Contabilistico - Descritivo: 'FGA-PR (*)'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-FGA-OCOBERT", "DT-VLR-FGA-OCOBERT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrFgaOcobert { get; init; }

    [DomainSearch(
        "DtVlrFgaRcivil",
        "FGA, Responsabilidade Civil do Ramo Contabilistico - Descritivo: 'FGA (*)'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-FGA-RCIVIL", "DT-VLR-FGA-RCIVIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrFgaRcivil { get; init; }

    [DomainSearch(
        "DtVlrBonus",
        "Bónus - Descritivo: 'BONUS'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-BONUS", "DT-VLR-BONUS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrBonus { get; init; }

    [DomainSearch(
        "DtVlrPrSimples",
        "Prémio Simples - Descritivo: 'PRÉMIO COMERCIAL'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-PR-SIMPLES", "DT-VLR-PR-SIMPLES"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrPrSimples { get; init; }

    [DomainSearch(
        "DtVlrPrAnual",
        "Actualização do Prémio Anual",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-PR-ANUAL", "DT-VLR-PR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrPrAnual { get; init; }

    [DomainSearch(
        "DtVlrEncAquis",
        "Valor dos encargos Aquisição - componente da parcela com Descritivo: 'ENCARGOS'",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-ENC-AQUIS", "DT-VLR-ENC-AQUIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrEncAquis { get; init; }

    [DomainSearch(
        "DtVlrEncPenal",
        "Valor dos encargos Penalização - Parcela das Faturas de Indemnizações com Descritivo: ENCARGOS/COMISSÕES",
        Aliases = ["BGOW0010", "BGOW0010-DT-VLR-ENC-PENAL", "DT-VLR-ENC-PENAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? DtVlrEncPenal { get; init; }

    [DomainSearch(
        "FtTotRegistos",
        "Quantidade de Apólices",
        Aliases = ["BGOW0010", "BGOW0010-FT-TOT-REGISTOS", "FT-TOT-REGISTOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtTotRegistos { get; init; }

    [DomainSearch(
        "FtVlrCapitalRecibo",
        "Valor do capital / valor da entrega - Descritivo: 'CAPITAL' | 'PREMIO INVEST' |'CAPITAL ENTREGUE'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-CAPITAL-RECIBO", "FT-VLR-CAPITAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrCapitalRecibo { get; init; }

    [DomainSearch(
        "FtVlrPremioRisco",
        "Valor de Prémio de Risco - Descritivo: 'PRÉMIO RISCO'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-PREMIO-RISCO", "FT-VLR-PREMIO-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrPremioRisco { get; init; }

    [DomainSearch(
        "FtVlrBonificacao",
        "Bonificação (Colheitas) - Descritivo: 'BONIFICAÇÃO'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-BONIFICACAO", "FT-VLR-BONIFICACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrBonificacao { get; init; }

    [DomainSearch(
        "FtVlrTotalRecibo",
        "Prémio total recibo - Descritivo: 'VALOR A PAGAR' | 'VALOR A RECEBER' | 'TOTAL DE PRÉMIOS'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-TOTAL-RECIBO", "FT-VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrTotalRecibo { get; init; }

    [DomainSearch(
        "FtVlrFracc",
        "Custo de Fraccionamento - Descritivo: 'CUSTO FRACCIONAMENTO'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-FRACC", "FT-VLR-FRACC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrFracc { get; init; }

    [DomainSearch(
        "FtVlrFat",
        "Fundo de Garantia de Acidentes de Trabalho - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-FAT", "FT-VLR-FAT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrFat { get; init; }

    [DomainSearch(
        "FtVlrFga",
        "Fundo de Garantia Automóvel - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-FGA", "FT-VLR-FGA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrFga { get; init; }

    [DomainSearch(
        "FtVlrSnb",
        "Imposto Serviço Nacional de Bombeiros - Descritivo: 'SNB' | 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-SNB", "FT-VLR-SNB"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrSnb { get; init; }

    [DomainSearch(
        "FtVlrInem",
        "Imposto INEM - Descritivo: 'INEM'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-INEM", "FT-VLR-INEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrInem { get; init; }

    [DomainSearch(
        "FtVlrCverde",
        "Custo da Carta Verde - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-CVERDE", "FT-VLR-CVERDE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrCverde { get; init; }

    [DomainSearch(
        "FtVlrSelos",
        "Descritivo: 'SELO de GARANTIA'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-SELOS", "FT-VLR-SELOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrSelos { get; init; }

    [DomainSearch(
        "FtVlrActa",
        "Custo da Acta/Apólice - Descritivo: 'APÓLICE / ACTA' | 'CUSTO CERTIFICADO'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-ACTA", "FT-VLR-ACTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrActa { get; init; }

    [DomainSearch(
        "FtVlrImpSelo",
        "Imposto de Selo - Descritivo: 'SELO'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-IMP-SELO", "FT-VLR-IMP-SELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrImpSelo { get; init; }

    [DomainSearch(
        "FtVlrFundCalam",
        "Fundo de calamidades - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-FUND-CALAM", "FT-VLR-FUND-CALAM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrFundCalam { get; init; }

    [DomainSearch(
        "FtVlrFgaOcobert",
        "FGA, Outras Coberturas do Ramo Contabilistico - Descritivo: 'FGA-PR (*)'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-FGA-OCOBERT", "FT-VLR-FGA-OCOBERT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrFgaOcobert { get; init; }

    [DomainSearch(
        "FtVlrFgaRcivil",
        "FGA, Responsabilidade Civil do Ramo Contabilistico - Descritivo: 'FGA (*)'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-FGA-RCIVIL", "FT-VLR-FGA-RCIVIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrFgaRcivil { get; init; }

    [DomainSearch(
        "FtVlrBonus",
        "Bónus - Descritivo: 'BONUS'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-BONUS", "FT-VLR-BONUS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrBonus { get; init; }

    [DomainSearch(
        "FtVlrPrSimples",
        "Prémio Simples - Descritivo: 'PRÉMIO COMERCIAL'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-PR-SIMPLES", "FT-VLR-PR-SIMPLES"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrPrSimples { get; init; }

    [DomainSearch(
        "FtVlrPrAnual",
        "Actualização do Prémio Anual",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-PR-ANUAL", "FT-VLR-PR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrPrAnual { get; init; }

    [DomainSearch(
        "FtVlrEncAquis",
        "Valor dos encargos Aquisição - componente da parcela com Descritivo: 'ENCARGOS'",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-ENC-AQUIS", "FT-VLR-ENC-AQUIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrEncAquis { get; init; }

    [DomainSearch(
        "FtVlrEncPenal",
        "Valor dos encargos Penalização - Parcela das Faturas de Indemnizações com Descritivo: ENCARGOS/COMISSÕES",
        Aliases = ["BGOW0010", "BGOW0010-FT-VLR-ENC-PENAL", "FT-VLR-ENC-PENAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0010"])]
    public string? FtVlrEncPenal { get; init; }

}
