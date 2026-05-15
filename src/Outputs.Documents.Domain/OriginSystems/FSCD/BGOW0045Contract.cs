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
    "BGOW0045 contract",
    "FSCD fleet aggregated receipt movement copybook.",
    Aliases = ["BGOW0045"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0045"])]
public sealed class BGOW0045Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0045";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0045.",
        Aliases = ["BGOW0045", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "TIPO-DOCUMENTO", "COD-PRODUTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0045.",
        Aliases = ["BGOW0045", "NR-APOLICE", "TIPO-APOLICE", "COD-MOEDA", "COD-PRODUTO", "COD-RAMO", "DESCR-RAMO-PROD"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0045.",
        Aliases = ["BGOW0045", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0045.",
        Aliases = ["BGOW0045", "NR-AGENTE", "AG-NOME", "AG-LOCATION-REF", "AG-MORADA1", "AG-MORADA2", "AG-LOCALIDADE", "AG-CPOSTAL", "AG-CPOSTAL-DESC", "AG-CPAIS", "AG-CPAIS-DESC", "AG-IDP", "AG-TELEFONE", "AG-TELEMOVEL", "AG-EMAIL", "AG-NR-CNT-VENDA", "AG-VLR-CNT-VENDA", "AG-NR-CNT-COBRA", "AG-VLR-CNT-COBRA"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0045.",
        Aliases = ["BGOW0045", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "AG-LOCATION-REF", "AG-MORADA1", "AG-MORADA2", "AG-LOCALIDADE", "AG-CPOSTAL", "AG-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0045.",
        Aliases = ["BGOW0045", "VLR-TOTAL-RECIBO", "AG-VLR-CNT-VENDA", "AG-VLR-CNT-COBRA", "AG-VLR-CNT-ESPEC", "AG-VLR-CNT-PARCE", "FRT-VLR-ANUAL", "FRT-VLR-RISCO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "RiskUnit",
        "Insured object, insured person, or risk-unit data identified in BGOW0045.",
        Aliases = ["BGOW0045", "FRT-DT-INI-RISCO", "FRT-DT-FIM-RISCO", "FRT-VLR-RISCO", "FTR-TOT-RISCO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "risk"])]
    public RiskUnit RiskUnit { get; init; } = new();

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0045.",
        Aliases = ["BGOW0045", "DT-INI-APOL", "DT-FIM-APOL", "DT-INI-REC", "DT-FIM-REC", "DT-EXTRACAO", "DT-EMISSAO", "VLR-TOTAL-RECIBO", "FRT-TIPO-TRANSAC", "FRT-OBSERVACAO", "FRT-DT-PROCESSO", "FRT-DT-APROVACAO", "FRT-DT-INI-RISCO", "FRT-DT-FIM-RISCO", "FRT-VLR-ANUAL", "FRT-VLR-RISCO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0045.",
        Aliases = ["BGOW0045", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0045", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0045 templates.",
        Aliases = ["BGOW0045", "1130"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0045", "BGOW0045-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0045", "BGOW0045-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0045", "BGOW0045-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0045", "BGOW0045-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0045", "BGOW0045-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0045", "BGOW0045-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0045-AUX-MARCA",
        Aliases = ["BGOW0045", "BGOW0045-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0045", "BGOW0045-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0045", "BGOW0045-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0045", "BGOW0045-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0045", "BGOW0045-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0045", "BGOW0045-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0045-DADOS-DOCUMENTO",
        Aliases = ["BGOW0045", "BGOW0045-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "TipoDocumento",
        "Tipo de Documento",
        Aliases = ["BGOW0045", "BGOW0045-TIPO-DOCUMENTO", "TIPO-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? TipoDocumento { get; init; }

    [DomainSearch(
        "NrRecibo",
        "Número do Recibo [Garantir que no máximo vem 11 posições]",
        Aliases = ["BGOW0045", "BGOW0045-NR-RECIBO", "NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? NrRecibo { get; init; }

    [DomainSearch(
        "TipoApolice",
        "Tipo de Apólice (Fraccionamento)",
        Aliases = ["BGOW0045", "BGOW0045-TIPO-APOLICE", "TIPO-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? TipoApolice { get; init; }

    [DomainSearch(
        "FraccaoNr",
        "Número de fracção (Valores de 001 a 012, 'RC ', ...)",
        Aliases = ["BGOW0045", "BGOW0045-FRACCAO-NR", "FRACCAO-NR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FraccaoNr { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0045", "BGOW0045-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "CodProduto",
        "Código de Produto [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0045", "BGOW0045-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "CodRamo",
        "Código do Ramo SO [Garantir que no máximo vem 6 posições]",
        Aliases = ["BGOW0045", "BGOW0045-COD-RAMO", "COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? CodRamo { get; init; }

    [DomainSearch(
        "DescrRamoProd",
        "Descritivo do Ramo / Produto",
        Aliases = ["BGOW0045", "BGOW0045-DESCR-RAMO-PROD", "DESCR-RAMO-PROD"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DescrRamoProd { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0045", "BGOW0045-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0045", "BGOW0045-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0045", "BGOW0045-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0045", "BGOW0045-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0045", "BGOW0045-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0045", "BGOW0045-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0045", "BGOW0045-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0045", "BGOW0045-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0045", "BGOW0045-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0045", "BGOW0045-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0045", "BGOW0045-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0045", "BGOW0045-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "DtIniApol",
        "Periodo da Apólice - inicio [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-DT-INI-APOL", "DT-INI-APOL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DtIniApol { get; init; }

    [DomainSearch(
        "DtFimApol",
        "Periodo da Apólice - fim [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-DT-FIM-APOL", "DT-FIM-APOL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DtFimApol { get; init; }

    [DomainSearch(
        "DtIniRec",
        "Periodo do Recibo - inicio [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-DT-INI-REC", "DT-INI-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DtIniRec { get; init; }

    [DomainSearch(
        "DtFimRec",
        "Periodo do Recibo - fim [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-DT-FIM-REC", "DT-FIM-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DtFimRec { get; init; }

    [DomainSearch(
        "DtExtracao",
        "Data de extracção [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-DT-EXTRACAO", "DT-EXTRACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DtExtracao { get; init; }

    [DomainSearch(
        "DtEmissao",
        "Data de emissão [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? DtEmissao { get; init; }

    [DomainSearch(
        "VlrTotalRecibo",
        "Valor total do Recibo (Valor a pagar)",
        Aliases = ["BGOW0045", "BGOW0045-VLR-TOTAL-RECIBO", "VLR-TOTAL-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? VlrTotalRecibo { get; init; }

    [DomainSearch(
        "AgNome",
        "Nome",
        Aliases = ["BGOW0045", "BGOW0045-AG-NOME", "AG-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgNome { get; init; }

    [DomainSearch(
        "AgLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0045", "BGOW0045-AG-LOCATION-REF", "AG-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgLocationRef { get; init; }

    [DomainSearch(
        "AgMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0045", "BGOW0045-AG-MORADA1", "AG-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgMorada1 { get; init; }

    [DomainSearch(
        "AgMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0045", "BGOW0045-AG-MORADA2", "AG-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgMorada2 { get; init; }

    [DomainSearch(
        "AgLocalidade",
        "Localidade",
        Aliases = ["BGOW0045", "BGOW0045-AG-LOCALIDADE", "AG-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgLocalidade { get; init; }

    [DomainSearch(
        "AgCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0045", "BGOW0045-AG-CPOSTAL", "AG-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgCpostal { get; init; }

    [DomainSearch(
        "AgCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0045", "BGOW0045-AG-CPOSTAL-DESC", "AG-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgCpostalDesc { get; init; }

    [DomainSearch(
        "AgCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0045", "BGOW0045-AG-CPAIS", "AG-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgCpais { get; init; }

    [DomainSearch(
        "AgCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0045", "BGOW0045-AG-CPAIS-DESC", "AG-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgCpaisDesc { get; init; }

    [DomainSearch(
        "AgIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0045", "BGOW0045-AG-IDP", "AG-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgIdp { get; init; }

    [DomainSearch(
        "AgTelefone",
        "Número de telefone",
        Aliases = ["BGOW0045", "BGOW0045-AG-TELEFONE", "AG-TELEFONE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgTelefone { get; init; }

    [DomainSearch(
        "AgTelemovel",
        "Número de telemóvel",
        Aliases = ["BGOW0045", "BGOW0045-AG-TELEMOVEL", "AG-TELEMOVEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgTelemovel { get; init; }

    [DomainSearch(
        "AgEmail",
        "e-mail",
        Aliases = ["BGOW0045", "BGOW0045-AG-EMAIL", "AG-EMAIL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgEmail { get; init; }

    [DomainSearch(
        "AgNrCntVenda",
        "Conta Mediação",
        Aliases = ["BGOW0045", "BGOW0045-AG-NR-CNT-VENDA", "AG-NR-CNT-VENDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgNrCntVenda { get; init; }

    [DomainSearch(
        "AgVlrCntVenda",
        "Comissão de Mediação",
        Aliases = ["BGOW0045", "BGOW0045-AG-VLR-CNT-VENDA", "AG-VLR-CNT-VENDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgVlrCntVenda { get; init; }

    [DomainSearch(
        "AgNrCntCobra",
        "Conta Cobrança",
        Aliases = ["BGOW0045", "BGOW0045-AG-NR-CNT-COBRA", "AG-NR-CNT-COBRA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgNrCntCobra { get; init; }

    [DomainSearch(
        "AgVlrCntCobra",
        "Comissão de Cobrança",
        Aliases = ["BGOW0045", "BGOW0045-AG-VLR-CNT-COBRA", "AG-VLR-CNT-COBRA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgVlrCntCobra { get; init; }

    [DomainSearch(
        "AgNrCntEspec",
        "Conta Especial",
        Aliases = ["BGOW0045", "BGOW0045-AG-NR-CNT-ESPEC", "AG-NR-CNT-ESPEC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgNrCntEspec { get; init; }

    [DomainSearch(
        "AgVlrCntEspec",
        "Comissão Especial",
        Aliases = ["BGOW0045", "BGOW0045-AG-VLR-CNT-ESPEC", "AG-VLR-CNT-ESPEC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgVlrCntEspec { get; init; }

    [DomainSearch(
        "AgNrCntParce",
        "Conta Parceria",
        Aliases = ["BGOW0045", "BGOW0045-AG-NR-CNT-PARCE", "AG-NR-CNT-PARCE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgNrCntParce { get; init; }

    [DomainSearch(
        "AgVlrCntParce",
        "Comissão Parceria",
        Aliases = ["BGOW0045", "BGOW0045-AG-VLR-CNT-PARCE", "AG-VLR-CNT-PARCE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? AgVlrCntParce { get; init; }

    [DomainSearch(
        "FrtTipoTransac",
        "Tipo de transacção",
        Aliases = ["BGOW0045", "BGOW0045-FRT-TIPO-TRANSAC", "FRT-TIPO-TRANSAC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtTipoTransac { get; init; }

    [DomainSearch(
        "FrtObservacao",
        "Matrícula",
        Aliases = ["BGOW0045", "BGOW0045-FRT-OBSERVACAO", "FRT-OBSERVACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtObservacao { get; init; }

    [DomainSearch(
        "FrtDtProcesso",
        "Data de processamento [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-FRT-DT-PROCESSO", "FRT-DT-PROCESSO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtDtProcesso { get; init; }

    [DomainSearch(
        "FrtDtAprovacao",
        "Data de aprovação [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-FRT-DT-APROVACAO", "FRT-DT-APROVACAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtDtAprovacao { get; init; }

    [DomainSearch(
        "FrtDtIniRisco",
        "Data inicio de risco [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-FRT-DT-INI-RISCO", "FRT-DT-INI-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtDtIniRisco { get; init; }

    [DomainSearch(
        "FrtDtFimRisco",
        "Data fim de risco [aaaammdd]",
        Aliases = ["BGOW0045", "BGOW0045-FRT-DT-FIM-RISCO", "FRT-DT-FIM-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtDtFimRisco { get; init; }

    [DomainSearch(
        "FrtVlrAnual",
        "Valor do Premio Anual",
        Aliases = ["BGOW0045", "BGOW0045-FRT-VLR-ANUAL", "FRT-VLR-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtVlrAnual { get; init; }

    [DomainSearch(
        "FrtVlrRisco",
        "Valor do Premio de Risco",
        Aliases = ["BGOW0045", "BGOW0045-FRT-VLR-RISCO", "FRT-VLR-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FrtVlrRisco { get; init; }

    [DomainSearch(
        "FtrTotAnual",
        "Total Anual",
        Aliases = ["BGOW0045", "BGOW0045-FTR-TOT-ANUAL", "FTR-TOT-ANUAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FtrTotAnual { get; init; }

    [DomainSearch(
        "FtrTotRisco",
        "Total Risco",
        Aliases = ["BGOW0045", "BGOW0045-FTR-TOT-RISCO", "FTR-TOT-RISCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0045"])]
    public string? FtrTotRisco { get; init; }

}
