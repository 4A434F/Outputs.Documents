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
    "BGOW0070 contract",
    "FSCD invoice and credit note copybook.",
    Aliases = ["BGOW0070"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0070"])]
public sealed class BGOW0070Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0070";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0070.",
        Aliases = ["BGOW0070", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "TIPO-DOCUMENTO", "COD-PRODUTO", "VH-MARCA", "TA-NR-APOLICE", "TA-COD-PRODUTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0070.",
        Aliases = ["BGOW0070", "NR-APOLICE", "COD-MOEDA", "COD-PRODUTO", "COD-RAMO", "DESCR-RAMO-PROD", "VI-TIPO-APOLICE", "PS-ADERENTE", "TA-NR-APOLICE", "TA-COD-PRODUTO", "TA-COD-RAMO", "TA-DESCR-RAMO-PROD", "TA-VI-TIPO-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0070.",
        Aliases = ["BGOW0070", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0070.",
        Aliases = ["BGOW0070", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0070.",
        Aliases = ["BGOW0070", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "MR-MORADA1", "MR-MORADA2", "MR-LOCALIDADE", "MR-CPOSTAL", "MR-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0070.",
        Aliases = ["BGOW0070", "VLR-CAPITAL-RECIBO", "VLR-PREMIO-RISCO", "VLR-BONIFICACAO", "VLR-TOTAL-RECIBO", "VLR-FRACC", "VLR-FAT", "VLR-FGA", "VLR-SNB", "VLR-INEM", "VLR-CVERDE", "VLR-SELOS", "VLR-ACTA", "VLR-IMP-SELO", "VLR-FUND-CALAM", "VLR-FGA-OCOBERT", "VLR-FGA-RCIVIL", "VLR-BONUS", "VLR-PR-SIMPLES"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "RiskUnit",
        "Insured object, insured person, or risk-unit data identified in BGOW0070.",
        Aliases = ["BGOW0070", "VLR-PREMIO-RISCO", "UR-QUANT", "UR-TIPO", "PS-1-NOME", "PS-1-NIF", "PS-1-DT-NASC", "PS-2-NOME", "PS-2-NIF", "PS-2-DT-NASC", "VH-MARCA", "VH-MODELO", "VH-VERSAO", "VH-MATRICULA", "VG-CARTA-COND", "VG-CATEGORIA", "VO-OBJETO", "MR-OBJETO", "MR-MORADA1"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "risk"])]
    public RiskUnit RiskUnit { get; init; } = new();

    [DomainSearch(
        "TextBlocks",
        "Document text, notes, clauses, or message lines identified in BGOW0070.",
        Aliases = ["BGOW0070", "MR-IND-TEXT-FRENT", "MR-IND-TEXT-VERSO", "MR-TEXT-FRENT", "AT-IND-TEXT-FRENT", "AT-TEXT-FRENT", "MS-INDIC-MENSAGENS"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "text"])]
    public IReadOnlyList<TextBlock> TextBlocks { get; init; } = [];

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0070.",
        Aliases = ["BGOW0070", "DT-INI-RECI", "DT-FIM-RECI", "DT-CRI-RECI", "DT-LIM-PAG", "DT-LIM-DEVOL", "DT-CESSACAO", "VLR-TOTAL-RECIBO", "DADOS-EXTRATO", "DT-IND-APOL-AGREGADA", "DT-VLR-CAPITAL-RECIBO", "DT-VLR-PREMIO-RISCO", "DT-VLR-BONIFICACAO", "DT-VLR-TOTAL-RECIBO", "DT-VLR-FRACC", "DT-VLR-FAT", "DT-VLR-FGA", "DT-VLR-SNB", "DT-VLR-INEM"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0070.",
        Aliases = ["BGOW0070", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0070", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0070 templates.",
        Aliases = ["BGOW0070", "1317", "1318"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0070", "BGOW0070-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0070", "BGOW0070-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0070", "BGOW0070-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0070", "BGOW0070-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0070", "BGOW0070-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0070", "BGOW0070-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0070-AUX-MARCA",
        Aliases = ["BGOW0070", "BGOW0070-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0070", "BGOW0070-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0070", "BGOW0070-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0070", "BGOW0070-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0070", "BGOW0070-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0070", "BGOW0070-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0070-DADOS-DOCUMENTO",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "TipoDocumento",
        "Tipo de Documento",
        Aliases = ["BGOW0070", "BGOW0070-TIPO-DOCUMENTO", "TIPO-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TipoDocumento { get; init; }

    [DomainSearch(
        "TipoRecibo",
        "Tipo de Recibo",
        Aliases = ["BGOW0070", "BGOW0070-TIPO-RECIBO", "TIPO-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TipoRecibo { get; init; }

    [DomainSearch(
        "NrRecibo",
        "Número do Recibo [Garantir que no máximo vem 11 posições Vida / 10 posições nos restantes]",
        Aliases = ["BGOW0070", "BGOW0070-NR-RECIBO", "NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? NrRecibo { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0070", "BGOW0070-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "CodProduto",
        "Código de Produto [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0070", "BGOW0070-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "CodRamo",
        "Código do Ramo SO [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0070", "BGOW0070-COD-RAMO", "COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CodRamo { get; init; }

    [DomainSearch(
        "DescrRamoProd",
        "Descritivo do Ramo / Produto (Para apresentação no A-R)",
        Aliases = ["BGOW0070", "BGOW0070-DESCR-RAMO-PROD", "DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DescrRamoProd { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0070", "BGOW0070-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0070", "BGOW0070-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0070", "BGOW0070-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0070", "BGOW0070-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0070", "BGOW0070-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0070", "BGOW0070-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0070", "BGOW0070-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0070", "BGOW0070-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0070", "BGOW0070-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0070", "BGOW0070-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0070", "BGOW0070-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0070", "BGOW0070-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "DtIniReci",
        "Periodo do recibo - inicio [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-DT-INI-RECI", "DT-INI-RECI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtIniReci { get; init; }

    [DomainSearch(
        "DtFimReci",
        "Periodo do recibo - fim [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-DT-FIM-RECI", "DT-FIM-RECI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtFimReci { get; init; }

    [DomainSearch(
        "DtCriReci",
        "Emissão do recibo [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-DT-CRI-RECI", "DT-CRI-RECI"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtCriReci { get; init; }

    [DomainSearch(
        "DtLimPag",
        "Data Limite de Pagamento [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-DT-LIM-PAG", "DT-LIM-PAG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtLimPag { get; init; }

    [DomainSearch(
        "DtLimDevol",
        "Data Limite de Devolução [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-DT-LIM-DEVOL", "DT-LIM-DEVOL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtLimDevol { get; init; }

    [DomainSearch(
        "DtCessacao",
        "Data de Cessação [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-DT-CESSACAO", "DT-CESSACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtCessacao { get; init; }

    [DomainSearch(
        "VlrCapitalRecibo",
        "Valor do capital / valor da entrega - Descritivo: 'CAPITAL' | 'PREMIO INVEST' |'CAPITAL ENTREGUE'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-CAPITAL-RECIBO", "VLR-CAPITAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrCapitalRecibo { get; init; }

    [DomainSearch(
        "VlrPremioRisco",
        "Valor de Prémio de Risco - Descritivo: 'PRÉMIO RISCO'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-PREMIO-RISCO", "VLR-PREMIO-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrPremioRisco { get; init; }

    [DomainSearch(
        "VlrBonificacao",
        "Bonificação (Colheitas) - Descritivo: 'BONIFICAÇÃO'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-BONIFICACAO", "VLR-BONIFICACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrBonificacao { get; init; }

    [DomainSearch(
        "VlrTotalRecibo",
        "Prémio total recibo - Descritivo: 'VALOR A PAGAR' | 'VALOR A RECEBER' | 'TOTAL DE PRÉMIOS'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-TOTAL-RECIBO", "VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrTotalRecibo { get; init; }

    [DomainSearch(
        "VlrFracc",
        "Custo de Fraccionamento - Descritivo: 'CUSTO FRACCIONAMENTO'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-FRACC", "VLR-FRACC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrFracc { get; init; }

    [DomainSearch(
        "VlrFat",
        "Fundo de Garantia de Acidentes de Trabalho - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-FAT", "VLR-FAT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrFat { get; init; }

    [DomainSearch(
        "VlrFga",
        "Fundo de Garantia Automóvel - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-FGA", "VLR-FGA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrFga { get; init; }

    [DomainSearch(
        "VlrSnb",
        "Imposto Serviço Nacional de Bombeiros - Descritivo: 'SNB' | 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-SNB", "VLR-SNB"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrSnb { get; init; }

    [DomainSearch(
        "VlrInem",
        "Imposto INEM - Descritivo: 'INEM'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-INEM", "VLR-INEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrInem { get; init; }

    [DomainSearch(
        "VlrCverde",
        "Custo da Carta Verde - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-CVERDE", "VLR-CVERDE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrCverde { get; init; }

    [DomainSearch(
        "VlrSelos",
        "Descritivo: 'SELO de GARANTIA'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-SELOS", "VLR-SELOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrSelos { get; init; }

    [DomainSearch(
        "VlrActa",
        "Custo da Acta/Apólice - Descritivo: 'APÓLICE / ACTA' | 'CUSTO CERTIFICADO'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-ACTA", "VLR-ACTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrActa { get; init; }

    [DomainSearch(
        "VlrImpSelo",
        "Imposto de Selo - Descritivo: 'SELO'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-IMP-SELO", "VLR-IMP-SELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrImpSelo { get; init; }

    [DomainSearch(
        "VlrFundCalam",
        "Fundo de calamidades - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-FUND-CALAM", "VLR-FUND-CALAM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrFundCalam { get; init; }

    [DomainSearch(
        "VlrFgaOcobert",
        "FGA, Outras Coberturas do Ramo Contabilistico - Descritivo: 'FGA-PR (*)'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-FGA-OCOBERT", "VLR-FGA-OCOBERT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrFgaOcobert { get; init; }

    [DomainSearch(
        "VlrFgaRcivil",
        "FGA, Responsabilidade Civil do Ramo Contabilistico - Descritivo: 'FGA (*)'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-FGA-RCIVIL", "VLR-FGA-RCIVIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrFgaRcivil { get; init; }

    [DomainSearch(
        "VlrBonus",
        "Bónus - Descritivo: 'BONUS'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-BONUS", "VLR-BONUS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrBonus { get; init; }

    [DomainSearch(
        "VlrPrSimples",
        "Prémio Simples - Descritivo: 'PRÉMIO COMERCIAL'",
        Aliases = ["BGOW0070", "BGOW0070-VLR-PR-SIMPLES", "VLR-PR-SIMPLES"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrPrSimples { get; init; }

    [DomainSearch(
        "VlrPrAnual",
        "Actualização do Prémio Anual",
        Aliases = ["BGOW0070", "BGOW0070-VLR-PR-ANUAL", "VLR-PR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VlrPrAnual { get; init; }

    [DomainSearch(
        "DadosPagamento",
        "(originalmente DADOS-PAGAMENTO)",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-PAGAMENTO", "DADOS-PAGAMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosPagamento { get; init; }

    [DomainSearch(
        "DadosAgente",
        "(originalmente DADOS-AGENTE)",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-AGENTE", "DADOS-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosAgente { get; init; }

    [DomainSearch(
        "DadosCredorhip",
        "(originalmente DADOS-CREDORHIP)",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-CREDORHIP", "DADOS-CREDORHIP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosCredorhip { get; init; }

    [DomainSearch(
        "UrQuant",
        "Número de unidades em risco",
        Aliases = ["BGOW0070", "BGOW0070-UR-QUANT", "UR-QUANT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? UrQuant { get; init; }

    [DomainSearch(
        "UrTipo",
        "Tipo de Unidade em risco",
        Aliases = ["BGOW0070", "BGOW0070-UR-TIPO", "UR-TIPO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? UrTipo { get; init; }

    [DomainSearch(
        "DadosUr",
        "BGOW0070-DADOS-UR",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-UR", "DADOS-UR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosUr { get; init; }

    [DomainSearch(
        "GrDetail",
        "Descritivo da unidade em risco (Objeto seguro)",
        Aliases = ["BGOW0070", "BGOW0070-GR-DETAIL", "GR-DETAIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? GrDetail { get; init; }

    [DomainSearch(
        "Ps1Nome",
        "Nome Pessoa segura 1",
        Aliases = ["BGOW0070", "BGOW0070-PS-1-NOME", "PS-1-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Ps1Nome { get; init; }

    [DomainSearch(
        "Ps1Nif",
        "NIF Pessoa segura 1  (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0070", "BGOW0070-PS-1-NIF", "PS-1-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Ps1Nif { get; init; }

    [DomainSearch(
        "Ps1DtNasc",
        "Data de Nascimento Pessoa segura 1 [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-PS-1-DT-NASC", "PS-1-DT-NASC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Ps1DtNasc { get; init; }

    [DomainSearch(
        "Ps2Nome",
        "Nome Pessoa segura 2",
        Aliases = ["BGOW0070", "BGOW0070-PS-2-NOME", "PS-2-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Ps2Nome { get; init; }

    [DomainSearch(
        "Ps2Nif",
        "NIF Pessoa segura 2  (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0070", "BGOW0070-PS-2-NIF", "PS-2-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Ps2Nif { get; init; }

    [DomainSearch(
        "Ps2DtNasc",
        "Data de Nascimento Pessoa segura 2 [aaaammdd]",
        Aliases = ["BGOW0070", "BGOW0070-PS-2-DT-NASC", "PS-2-DT-NASC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? Ps2DtNasc { get; init; }

    [DomainSearch(
        "ViEncarAquisicao",
        "Valor dos encargos Aquisição - componente da parcela com Descritivo: 'ENCARGOS'",
        Aliases = ["BGOW0070", "BGOW0070-VI-ENCAR-AQUISICAO", "VI-ENCAR-AQUISICAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ViEncarAquisicao { get; init; }

    [DomainSearch(
        "ViEncarPenaliza",
        "Valor dos encargos Penalização - Parcela das Faturas de Indemnizações com Descritivo: ENCARGOS/COMISSÕES",
        Aliases = ["BGOW0070", "BGOW0070-VI-ENCAR-PENALIZA", "VI-ENCAR-PENALIZA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ViEncarPenaliza { get; init; }

    [DomainSearch(
        "ViTipoApolice",
        "Tipo de Apólice Vida",
        Aliases = ["BGOW0070", "BGOW0070-VI-TIPO-APOLICE", "VI-TIPO-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? ViTipoApolice { get; init; }

    [DomainSearch(
        "AuArea",
        "BGOW0070-AU-AREA",
        Aliases = ["BGOW0070", "BGOW0070-AU-AREA", "AU-AREA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? AuArea { get; init; }

    [DomainSearch(
        "VhMarca",
        "Marca",
        Aliases = ["BGOW0070", "BGOW0070-VH-MARCA", "VH-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VhMarca { get; init; }

    [DomainSearch(
        "VhModelo",
        "Modelo",
        Aliases = ["BGOW0070", "BGOW0070-VH-MODELO", "VH-MODELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VhModelo { get; init; }

    [DomainSearch(
        "VhVersao",
        "Versão",
        Aliases = ["BGOW0070", "BGOW0070-VH-VERSAO", "VH-VERSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VhVersao { get; init; }

    [DomainSearch(
        "VhMatricula",
        "Matrícula",
        Aliases = ["BGOW0070", "BGOW0070-VH-MATRICULA", "VH-MATRICULA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VhMatricula { get; init; }

    [DomainSearch(
        "VgCartaCond",
        "Carta de Condução",
        Aliases = ["BGOW0070", "BGOW0070-VG-CARTA-COND", "VG-CARTA-COND"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VgCartaCond { get; init; }

    [DomainSearch(
        "VgCategoria",
        "Categoria (ex: Garagista até 3500Kg)",
        Aliases = ["BGOW0070", "BGOW0070-VG-CATEGORIA", "VG-CATEGORIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VgCategoria { get; init; }

    [DomainSearch(
        "VoObjeto",
        "Objeto",
        Aliases = ["BGOW0070", "BGOW0070-VO-OBJETO", "VO-OBJETO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? VoObjeto { get; init; }

    [DomainSearch(
        "MrObjeto",
        "Objeto",
        Aliases = ["BGOW0070", "BGOW0070-MR-OBJETO", "MR-OBJETO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrObjeto { get; init; }

    [DomainSearch(
        "MrMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0070", "BGOW0070-MR-MORADA1", "MR-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrMorada1 { get; init; }

    [DomainSearch(
        "MrMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0070", "BGOW0070-MR-MORADA2", "MR-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrMorada2 { get; init; }

    [DomainSearch(
        "MrLocalidade",
        "Localidade",
        Aliases = ["BGOW0070", "BGOW0070-MR-LOCALIDADE", "MR-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrLocalidade { get; init; }

    [DomainSearch(
        "MrCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0070", "BGOW0070-MR-CPOSTAL", "MR-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrCpostal { get; init; }

    [DomainSearch(
        "MrCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0070", "BGOW0070-MR-CPOSTAL-DESC", "MR-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrCpostalDesc { get; init; }

    [DomainSearch(
        "AtObjeto",
        "Objeto",
        Aliases = ["BGOW0070", "BGOW0070-AT-OBJETO", "AT-OBJETO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? AtObjeto { get; init; }

    [DomainSearch(
        "DadosOut",
        "BGOW0070-DADOS-OUT",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-OUT", "DADOS-OUT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosOut { get; init; }

    [DomainSearch(
        "PsTipo",
        "Tipo de apólice Vida",
        Aliases = ["BGOW0070", "BGOW0070-PS-TIPO", "PS-TIPO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? PsTipo { get; init; }

    [DomainSearch(
        "PsAderente",
        "Número de Aderente - 'PES. SEGURA' (Obs: Preenchido, significa que o nr de apólice é composto)",
        Aliases = ["BGOW0070", "BGOW0070-PS-ADERENTE", "PS-ADERENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? PsAderente { get; init; }

    [DomainSearch(
        "MrIndTextFrent",
        "Indicador de inclusão de texto no Aviso (ex: \"S\" - MR Hab)",
        Aliases = ["BGOW0070", "BGOW0070-MR-IND-TEXT-FRENT", "MR-IND-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrIndTextFrent { get; init; }

    [DomainSearch(
        "MrIndTextVerso",
        "Indicador de inclusão de texto no verso do Aviso (ex: \"1\" - Riscos Simples e \"2\" - Riscos Industriais)",
        Aliases = ["BGOW0070", "BGOW0070-MR-IND-TEXT-VERSO", "MR-IND-TEXT-VERSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrIndTextVerso { get; init; }

    [DomainSearch(
        "MrCapImov",
        "Descritivo: 'CAPITAL IMÓVEL'",
        Aliases = ["BGOW0070", "BGOW0070-MR-CAP-IMOV", "MR-CAP-IMOV"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrCapImov { get; init; }

    [DomainSearch(
        "MrTipoActz",
        "Tipo de atualização tarifária (ex: \"CA\" - Convencionada, \"IA\" - Indexada, \"SA\" - Sem actualização, \"VA\" - Vários)",
        Aliases = ["BGOW0070", "BGOW0070-MR-TIPO-ACTZ", "MR-TIPO-ACTZ"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrTipoActz { get; init; }

    [DomainSearch(
        "MrTextFrent",
        "Inclusão de texto na frente do Aviso",
        Aliases = ["BGOW0070", "BGOW0070-MR-TEXT-FRENT", "MR-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MrTextFrent { get; init; }

    [DomainSearch(
        "AtIndTextFrent",
        "Indicador de inclusão de texto no Aviso (ex: \"A\" - AT Portaria e \"T\" - AT Tarif)",
        Aliases = ["BGOW0070", "BGOW0070-AT-IND-TEXT-FRENT", "AT-IND-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? AtIndTextFrent { get; init; }

    [DomainSearch(
        "AtTextFrent",
        "Inclusão de texto na frente do Aviso",
        Aliases = ["BGOW0070", "BGOW0070-AT-TEXT-FRENT", "AT-TEXT-FRENT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? AtTextFrent { get; init; }

    [DomainSearch(
        "DadosExtrato",
        "(originalmente DADOS-EXTRATO)",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-EXTRATO", "DADOS-EXTRATO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosExtrato { get; init; }

    [DomainSearch(
        "CfNifEmitente",
        "NIF da Entidade emissora",
        Aliases = ["BGOW0070", "BGOW0070-CF-NIF-EMITENTE", "CF-NIF-EMITENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfNifEmitente { get; init; }

    [DomainSearch(
        "CfNumCertifAvso",
        "Número de Certificação do Recibo correspondente",
        Aliases = ["BGOW0070", "BGOW0070-CF-NUM-CERTIF-AVSO", "CF-NUM-CERTIF-AVSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfNumCertifAvso { get; init; }

    [DomainSearch(
        "CfAtcud",
        "Código único de Documento",
        Aliases = ["BGOW0070", "BGOW0070-CF-ATCUD", "CF-ATCUD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfAtcud { get; init; }

    [DomainSearch(
        "CfNumProgCertif",
        "Número do Programa usado para Certificação do Documento",
        Aliases = ["BGOW0070", "BGOW0070-CF-NUM-PROG-CERTIF", "CF-NUM-PROG-CERTIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfNumProgCertif { get; init; }

    [DomainSearch(
        "CfHash",
        "Código Hash",
        Aliases = ["BGOW0070", "BGOW0070-CF-HASH", "CF-HASH"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfHash { get; init; }

    [DomainSearch(
        "CfNumCompromisso",
        "Número do Compromisso",
        Aliases = ["BGOW0070", "BGOW0070-CF-NUM-COMPROMISSO", "CF-NUM-COMPROMISSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfNumCompromisso { get; init; }

    [DomainSearch(
        "CfBaseTributavel",
        "Valor Base para tributação pelas Finanças",
        Aliases = ["BGOW0070", "BGOW0070-CF-BASE-TRIBUTAVEL", "CF-BASE-TRIBUTAVEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfBaseTributavel { get; init; }

    [DomainSearch(
        "CfEstadoDocumento",
        "Estado do Documento",
        Aliases = ["BGOW0070", "BGOW0070-CF-ESTADO-DOCUMENTO", "CF-ESTADO-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfEstadoDocumento { get; init; }

    [DomainSearch(
        "CfEspacoFiscalIva",
        "Espaço Fiscal do IVA",
        Aliases = ["BGOW0070", "BGOW0070-CF-ESPACO-FISCAL-IVA", "CF-ESPACO-FISCAL-IVA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfEspacoFiscalIva { get; init; }

    [DomainSearch(
        "CfNumCertifFatura",
        "Número de Certificação da Fatura / Nota de Crédito",
        Aliases = ["BGOW0070", "BGOW0070-CF-NUM-CERTIF-FATURA", "CF-NUM-CERTIF-FATURA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? CfNumCertifFatura { get; init; }

    [DomainSearch(
        "MsIndicMensagens",
        "Indicador da existência de Mensagem adicional",
        Aliases = ["BGOW0070", "BGOW0070-MS-INDIC-MENSAGENS", "MS-INDIC-MENSAGENS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? MsIndicMensagens { get; init; }

    [DomainSearch(
        "RaGuid",
        "Chave Única do documento",
        Aliases = ["BGOW0070", "BGOW0070-RA-GUID", "RA-GUID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? RaGuid { get; init; }

    [DomainSearch(
        "DadosAsf",
        "(originalmente DADOS-ASF)",
        Aliases = ["BGOW0070", "BGOW0070-DADOS-ASF", "DADOS-ASF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DadosAsf { get; init; }

    [DomainSearch(
        "DtIndApolAgregada",
        "Indicador de Apólice Agregada (S/N)",
        Aliases = ["BGOW0070", "BGOW0070-DT-IND-APOL-AGREGADA", "DT-IND-APOL-AGREGADA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtIndApolAgregada { get; init; }

    [DomainSearch(
        "TaNrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0070", "BGOW0070-TA-NR-APOLICE", "TA-NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TaNrApolice { get; init; }

    [DomainSearch(
        "TaCodProduto",
        "Código de Produto [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0070", "BGOW0070-TA-COD-PRODUTO", "TA-COD-PRODUTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TaCodProduto { get; init; }

    [DomainSearch(
        "TaCodRamo",
        "Código do Ramo SO [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0070", "BGOW0070-TA-COD-RAMO", "TA-COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TaCodRamo { get; init; }

    [DomainSearch(
        "TaDescrRamoProd",
        "Descritivo do Ramo / Produto (Para apresentação no A-R)",
        Aliases = ["BGOW0070", "BGOW0070-TA-DESCR-RAMO-PROD", "TA-DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TaDescrRamoProd { get; init; }

    [DomainSearch(
        "TaViTipoApolice",
        "Tipo de Apólice Vida",
        Aliases = ["BGOW0070", "BGOW0070-TA-VI-TIPO-APOLICE", "TA-VI-TIPO-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? TaViTipoApolice { get; init; }

    [DomainSearch(
        "DtVlrCapitalRecibo",
        "Valor do capital / valor da entrega - Descritivo: 'CAPITAL' | 'PREMIO INVEST' |'CAPITAL ENTREGUE'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-CAPITAL-RECIBO", "DT-VLR-CAPITAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrCapitalRecibo { get; init; }

    [DomainSearch(
        "DtVlrPremioRisco",
        "Valor de Prémio de Risco - Descritivo: 'PRÉMIO RISCO'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-PREMIO-RISCO", "DT-VLR-PREMIO-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrPremioRisco { get; init; }

    [DomainSearch(
        "DtVlrBonificacao",
        "Bonificação (Colheitas) - Descritivo: 'BONIFICAÇÃO'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-BONIFICACAO", "DT-VLR-BONIFICACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrBonificacao { get; init; }

    [DomainSearch(
        "DtVlrTotalRecibo",
        "Prémio total recibo - Descritivo: 'VALOR A PAGAR' | 'VALOR A RECEBER' | 'TOTAL DE PRÉMIOS'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-TOTAL-RECIBO", "DT-VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrTotalRecibo { get; init; }

    [DomainSearch(
        "DtVlrFracc",
        "Custo de Fraccionamento - Descritivo: 'CUSTO FRACCIONAMENTO'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-FRACC", "DT-VLR-FRACC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrFracc { get; init; }

    [DomainSearch(
        "DtVlrFat",
        "Fundo de Garantia de Acidentes de Trabalho - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-FAT", "DT-VLR-FAT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrFat { get; init; }

    [DomainSearch(
        "DtVlrFga",
        "Fundo de Garantia Automóvel - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-FGA", "DT-VLR-FGA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrFga { get; init; }

    [DomainSearch(
        "DtVlrSnb",
        "Imposto Serviço Nacional de Bombeiros - Descritivo: 'SNB' | 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-SNB", "DT-VLR-SNB"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrSnb { get; init; }

    [DomainSearch(
        "DtVlrInem",
        "Imposto INEM - Descritivo: 'INEM'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-INEM", "DT-VLR-INEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrInem { get; init; }

    [DomainSearch(
        "DtVlrCverde",
        "Custo da Carta Verde - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-CVERDE", "DT-VLR-CVERDE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrCverde { get; init; }

    [DomainSearch(
        "DtVlrSelos",
        "Descritivo: 'SELO de GARANTIA'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-SELOS", "DT-VLR-SELOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrSelos { get; init; }

    [DomainSearch(
        "DtVlrActa",
        "Custo da Acta/Apólice - Descritivo: 'APÓLICE / ACTA' | 'CUSTO CERTIFICADO'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-ACTA", "DT-VLR-ACTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrActa { get; init; }

    [DomainSearch(
        "DtVlrImpSelo",
        "Imposto de Selo - Descritivo: 'SELO'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-IMP-SELO", "DT-VLR-IMP-SELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrImpSelo { get; init; }

    [DomainSearch(
        "DtVlrFundCalam",
        "Fundo de calamidades - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-FUND-CALAM", "DT-VLR-FUND-CALAM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrFundCalam { get; init; }

    [DomainSearch(
        "DtVlrFgaOcobert",
        "FGA, Outras Coberturas do Ramo Contabilistico - Descritivo: 'FGA-PR (*)'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-FGA-OCOBERT", "DT-VLR-FGA-OCOBERT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrFgaOcobert { get; init; }

    [DomainSearch(
        "DtVlrFgaRcivil",
        "FGA, Responsabilidade Civil do Ramo Contabilistico - Descritivo: 'FGA (*)'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-FGA-RCIVIL", "DT-VLR-FGA-RCIVIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrFgaRcivil { get; init; }

    [DomainSearch(
        "DtVlrBonus",
        "Bónus - Descritivo: 'BONUS'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-BONUS", "DT-VLR-BONUS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrBonus { get; init; }

    [DomainSearch(
        "DtVlrPrSimples",
        "Prémio Simples - Descritivo: 'PRÉMIO COMERCIAL'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-PR-SIMPLES", "DT-VLR-PR-SIMPLES"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrPrSimples { get; init; }

    [DomainSearch(
        "DtVlrPrAnual",
        "Actualização do Prémio Anual",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-PR-ANUAL", "DT-VLR-PR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrPrAnual { get; init; }

    [DomainSearch(
        "DtVlrEncAquis",
        "Valor dos encargos Aquisição - componente da parcela com Descritivo: 'ENCARGOS'",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-ENC-AQUIS", "DT-VLR-ENC-AQUIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrEncAquis { get; init; }

    [DomainSearch(
        "DtVlrEncPenal",
        "Valor dos encargos Penalização - Parcela das Faturas de Indemnizações com Descritivo: ENCARGOS/COMISSÕES",
        Aliases = ["BGOW0070", "BGOW0070-DT-VLR-ENC-PENAL", "DT-VLR-ENC-PENAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? DtVlrEncPenal { get; init; }

    [DomainSearch(
        "FtTotRegistos",
        "Número da Apólice",
        Aliases = ["BGOW0070", "BGOW0070-FT-TOT-REGISTOS", "FT-TOT-REGISTOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtTotRegistos { get; init; }

    [DomainSearch(
        "FtVlrCapitalRecibo",
        "Valor do capital / valor da entrega - Descritivo: 'CAPITAL' | 'PREMIO INVEST' |'CAPITAL ENTREGUE'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-CAPITAL-RECIBO", "FT-VLR-CAPITAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrCapitalRecibo { get; init; }

    [DomainSearch(
        "FtVlrPremioRisco",
        "Valor de Prémio de Risco - Descritivo: 'PRÉMIO RISCO'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-PREMIO-RISCO", "FT-VLR-PREMIO-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrPremioRisco { get; init; }

    [DomainSearch(
        "FtVlrBonificacao",
        "Bonificação (Colheitas) - Descritivo: 'BONIFICAÇÃO'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-BONIFICACAO", "FT-VLR-BONIFICACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrBonificacao { get; init; }

    [DomainSearch(
        "FtVlrTotalRecibo",
        "Prémio total recibo - Descritivo: 'VALOR A PAGAR' | 'VALOR A RECEBER' | 'TOTAL DE PRÉMIOS'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-TOTAL-RECIBO", "FT-VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrTotalRecibo { get; init; }

    [DomainSearch(
        "FtVlrFracc",
        "Custo de Fraccionamento - Descritivo: 'CUSTO FRACCIONAMENTO'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-FRACC", "FT-VLR-FRACC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrFracc { get; init; }

    [DomainSearch(
        "FtVlrFat",
        "Fundo de Garantia de Acidentes de Trabalho - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-FAT", "FT-VLR-FAT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrFat { get; init; }

    [DomainSearch(
        "FtVlrFga",
        "Fundo de Garantia Automóvel - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-FGA", "FT-VLR-FGA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrFga { get; init; }

    [DomainSearch(
        "FtVlrSnb",
        "Imposto Serviço Nacional de Bombeiros - Descritivo: 'SNB' | 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-SNB", "FT-VLR-SNB"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrSnb { get; init; }

    [DomainSearch(
        "FtVlrInem",
        "Imposto INEM - Descritivo: 'INEM'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-INEM", "FT-VLR-INEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrInem { get; init; }

    [DomainSearch(
        "FtVlrCverde",
        "Custo da Carta Verde - Descritivo: 'CV / SNB / FAT'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-CVERDE", "FT-VLR-CVERDE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrCverde { get; init; }

    [DomainSearch(
        "FtVlrSelos",
        "Descritivo: 'SELO de GARANTIA'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-SELOS", "FT-VLR-SELOS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrSelos { get; init; }

    [DomainSearch(
        "FtVlrActa",
        "Custo da Acta/Apólice - Descritivo: 'APÓLICE / ACTA' | 'CUSTO CERTIFICADO'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-ACTA", "FT-VLR-ACTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrActa { get; init; }

    [DomainSearch(
        "FtVlrImpSelo",
        "Imposto de Selo - Descritivo: 'SELO'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-IMP-SELO", "FT-VLR-IMP-SELO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrImpSelo { get; init; }

    [DomainSearch(
        "FtVlrFundCalam",
        "Fundo de calamidades - Descritivo: 'F.CALAM / FGA'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-FUND-CALAM", "FT-VLR-FUND-CALAM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrFundCalam { get; init; }

    [DomainSearch(
        "FtVlrFgaOcobert",
        "FGA, Outras Coberturas do Ramo Contabilistico - Descritivo: 'FGA-PR (*)'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-FGA-OCOBERT", "FT-VLR-FGA-OCOBERT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrFgaOcobert { get; init; }

    [DomainSearch(
        "FtVlrFgaRcivil",
        "FGA, Responsabilidade Civil do Ramo Contabilistico - Descritivo: 'FGA (*)'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-FGA-RCIVIL", "FT-VLR-FGA-RCIVIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrFgaRcivil { get; init; }

    [DomainSearch(
        "FtVlrBonus",
        "Bónus - Descritivo: 'BONUS'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-BONUS", "FT-VLR-BONUS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrBonus { get; init; }

    [DomainSearch(
        "FtVlrPrSimples",
        "Prémio Simples - Descritivo: 'PRÉMIO COMERCIAL'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-PR-SIMPLES", "FT-VLR-PR-SIMPLES"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrPrSimples { get; init; }

    [DomainSearch(
        "FtVlrPrAnual",
        "Actualização do Prémio Anual",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-PR-ANUAL", "FT-VLR-PR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrPrAnual { get; init; }

    [DomainSearch(
        "FtVlrEncAquis",
        "Valor dos encargos Aquisição - componente da parcela com Descritivo: 'ENCARGOS'",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-ENC-AQUIS", "FT-VLR-ENC-AQUIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrEncAquis { get; init; }

    [DomainSearch(
        "FtVlrEncPenal",
        "Valor dos encargos Penalização - Parcela das Faturas de Indemnizações com Descritivo: ENCARGOS/COMISSÕES",
        Aliases = ["BGOW0070", "BGOW0070-FT-VLR-ENC-PENAL", "FT-VLR-ENC-PENAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0070"])]
    public string? FtVlrEncPenal { get; init; }

}
