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
    "BGOW0062 contract",
    "FSCD pending receipt relation copybook.",
    Aliases = ["BGOW0062"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0062"])]
public sealed class BGOW0062Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0062";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0062.",
        Aliases = ["BGOW0062", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "DT-NR-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0062.",
        Aliases = ["BGOW0062", "NR-APOLICE", "COD-MOEDA", "DT-RAMO", "DT-DESCR-RAMO", "DT-NR-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0062.",
        Aliases = ["BGOW0062", "NR-CLIENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Mediator",
        "Optional mediator party identified in BGOW0062.",
        Aliases = ["BGOW0062", "MD-NOME", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC", "MD-CPAIS", "MD-CPAIS-DESC", "MD-IDP", "MD-NIF", "MD-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "entity", "mediator"])]
    public Entity? Mediator { get; init; }

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0062.",
        Aliases = ["BGOW0062", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0062.",
        Aliases = ["BGOW0062", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0062.",
        Aliases = ["BGOW0062", "DT-VLR-PRM", "DT-VLR-REC", "TT-VLR-REC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0062.",
        Aliases = ["BGOW0062", "DT-EMISSAO", "DT-NOME", "DT-RAMO", "DT-DESCR-RAMO", "DT-NR-APOLICE", "DT-NR-SINISTRO", "DT-NR-RECIBO", "DT-TIPO-RECIBO", "DT-DATA-EMISSAO", "DT-DATA-INICIO", "DT-DATA-FIM", "DT-DATA-DEVIDO", "DT-VLR-PRM", "DT-VLR-REC", "DT-NUM-DIAS", "TT-VLR-REC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0062.",
        Aliases = ["BGOW0062", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0062", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0062 templates.",
        Aliases = ["BGOW0062", "1050"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0062", "BGOW0062-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0062", "BGOW0062-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0062", "BGOW0062-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0062", "BGOW0062-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0062", "BGOW0062-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0062", "BGOW0062-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0062-AUX-MARCA",
        Aliases = ["BGOW0062", "BGOW0062-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0062", "BGOW0062-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente: Preencher a espaços, uma vez que é sempre para mediador",
        Aliases = ["BGOW0062", "BGOW0062-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice: Preencher a espaços, uma vez que poderá existir várias apólices associadas",
        Aliases = ["BGOW0062", "BGOW0062-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0062", "BGOW0062-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0062", "BGOW0062-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0062-DADOS-DOCUMENTO",
        Aliases = ["BGOW0062", "BGOW0062-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "MdNome",
        "Nome",
        Aliases = ["BGOW0062", "BGOW0062-MD-NOME", "MD-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdNome { get; init; }

    [DomainSearch(
        "MdLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0062", "BGOW0062-MD-LOCATION-REF", "MD-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdLocationRef { get; init; }

    [DomainSearch(
        "MdMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0062", "BGOW0062-MD-MORADA1", "MD-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdMorada1 { get; init; }

    [DomainSearch(
        "MdMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0062", "BGOW0062-MD-MORADA2", "MD-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdMorada2 { get; init; }

    [DomainSearch(
        "MdLocalidade",
        "Localidade",
        Aliases = ["BGOW0062", "BGOW0062-MD-LOCALIDADE", "MD-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdLocalidade { get; init; }

    [DomainSearch(
        "MdCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0062", "BGOW0062-MD-CPOSTAL", "MD-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdCpostal { get; init; }

    [DomainSearch(
        "MdCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0062", "BGOW0062-MD-CPOSTAL-DESC", "MD-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdCpostalDesc { get; init; }

    [DomainSearch(
        "MdCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0062", "BGOW0062-MD-CPAIS", "MD-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdCpais { get; init; }

    [DomainSearch(
        "MdCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0062", "BGOW0062-MD-CPAIS-DESC", "MD-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdCpaisDesc { get; init; }

    [DomainSearch(
        "MdIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0062", "BGOW0062-MD-IDP", "MD-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdIdp { get; init; }

    [DomainSearch(
        "MdNif",
        "Número de Identificação Fiscal do Mediador (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0062", "BGOW0062-MD-NIF", "MD-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdNif { get; init; }

    [DomainSearch(
        "MdTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0062", "BGOW0062-MD-TIPO-ENTIDADE", "MD-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? MdTipoEntidade { get; init; }

    [DomainSearch(
        "DtEmissao",
        "Data de emissão Carta [aaaammdd]",
        Aliases = ["BGOW0062", "BGOW0062-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtEmissao { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0062", "BGOW0062-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "QteLinDet",
        "Quantidade de linhas de detalhe",
        Aliases = ["BGOW0062", "BGOW0062-QTE-LIN-DET", "QTE-LIN-DET"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? QteLinDet { get; init; }

    [DomainSearch(
        "DtNome",
        "Nome do Segurado",
        Aliases = ["BGOW0062", "BGOW0062-DT-NOME", "DT-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtNome { get; init; }

    [DomainSearch(
        "DtRamo",
        "Ramo da Apólice",
        Aliases = ["BGOW0062", "BGOW0062-DT-RAMO", "DT-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtRamo { get; init; }

    [DomainSearch(
        "DtDescrRamo",
        "Descritivo do Ramo",
        Aliases = ["BGOW0062", "BGOW0062-DT-DESCR-RAMO", "DT-DESCR-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtDescrRamo { get; init; }

    [DomainSearch(
        "DtNrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0062", "BGOW0062-DT-NR-APOLICE", "DT-NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtNrApolice { get; init; }

    [DomainSearch(
        "DtNrSinistro",
        "Número do Sinistro",
        Aliases = ["BGOW0062", "BGOW0062-DT-NR-SINISTRO", "DT-NR-SINISTRO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtNrSinistro { get; init; }

    [DomainSearch(
        "DtNrRecibo",
        "Número do Recibo (Garantir que no máximo vem 11 posições Vida / 10 posições nos restantes)",
        Aliases = ["BGOW0062", "BGOW0062-DT-NR-RECIBO", "DT-NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtNrRecibo { get; init; }

    [DomainSearch(
        "DtTipoRecibo",
        "Tipo de Recibo",
        Aliases = ["BGOW0062", "BGOW0062-DT-TIPO-RECIBO", "DT-TIPO-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtTipoRecibo { get; init; }

    [DomainSearch(
        "DtDataEmissao",
        "Data Emissão [aaaammdd]",
        Aliases = ["BGOW0062", "BGOW0062-DT-DATA-EMISSAO", "DT-DATA-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtDataEmissao { get; init; }

    [DomainSearch(
        "DtDataInicio",
        "Data Inicio [aaaammdd]",
        Aliases = ["BGOW0062", "BGOW0062-DT-DATA-INICIO", "DT-DATA-INICIO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtDataInicio { get; init; }

    [DomainSearch(
        "DtDataFim",
        "Data Fim [aaaammdd]",
        Aliases = ["BGOW0062", "BGOW0062-DT-DATA-FIM", "DT-DATA-FIM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtDataFim { get; init; }

    [DomainSearch(
        "DtDataDevido",
        "Data Devido [aaaammdd]",
        Aliases = ["BGOW0062", "BGOW0062-DT-DATA-DEVIDO", "DT-DATA-DEVIDO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtDataDevido { get; init; }

    [DomainSearch(
        "DtVlrPrm",
        "Valor Prémio Comercial",
        Aliases = ["BGOW0062", "BGOW0062-DT-VLR-PRM", "DT-VLR-PRM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtVlrPrm { get; init; }

    [DomainSearch(
        "DtVlrRec",
        "Valor Total Recibo",
        Aliases = ["BGOW0062", "BGOW0062-DT-VLR-REC", "DT-VLR-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtVlrRec { get; init; }

    [DomainSearch(
        "DtNumDias",
        "Nº de Dias decorridos após a Data Devido",
        Aliases = ["BGOW0062", "BGOW0062-DT-NUM-DIAS", "DT-NUM-DIAS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? DtNumDias { get; init; }

    [DomainSearch(
        "TtVlrRec",
        "Valor Total da relação de Recibos",
        Aliases = ["BGOW0062", "BGOW0062-TT-VLR-REC", "TT-VLR-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0062"])]
    public string? TtVlrRec { get; init; }

}
