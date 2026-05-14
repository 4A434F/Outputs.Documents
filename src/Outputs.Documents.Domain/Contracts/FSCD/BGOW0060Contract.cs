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
    "BGOW0060 contract",
    "FSCD effective account statement copybook.",
    Aliases = ["BGOW0060"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0060"])]
public sealed class BGOW0060Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0060";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0060.",
        Aliases = ["BGOW0060", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "DT-NR-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0060.",
        Aliases = ["BGOW0060", "NR-APOLICE", "COD-MOEDA", "DT-NR-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0060.",
        Aliases = ["BGOW0060", "NR-CLIENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Mediator",
        "Optional mediator party identified in BGOW0060.",
        Aliases = ["BGOW0060", "MD-NOME", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC", "MD-CPAIS", "MD-CPAIS-DESC", "MD-IDP", "MD-NIF", "MD-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "entity", "mediator"])]
    public Entity? Mediator { get; init; }

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0060.",
        Aliases = ["BGOW0060", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0060.",
        Aliases = ["BGOW0060", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0060.",
        Aliases = ["BGOW0060", "DT-VLR-REC", "DT-VLR-COM", "DT-VLR-IRS", "DT-VLR-SEL", "DT-VLR-SEG", "DT-VLR-OUT", "TR-SI-VALOR", "TR-VLR-REC", "TR-VLR-COM", "TR-VLR-IRS", "TR-VLR-SEL", "TR-VLR-SEG", "TR-VLR-OUT", "TR-SF-VALOR", "TA-VLR-COM", "TA-VLR-IRS", "TA-VLR-SEL", "TA-VLR-SEG"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0060.",
        Aliases = ["BGOW0060", "DT-EMISSAO", "DT-DATA", "DT-HORA", "DT-REFERENCIA", "DT-TIPO-MOVIMENTO", "DT-NR-APOLICE", "DT-NR-SINISTRO", "DT-NR-RECIBO", "DT-TIPO", "DT-VLR-REC", "DT-VLR-COM", "DT-VLR-IRS", "DT-VLR-SEL", "DT-VLR-SEG", "DT-VLR-OUT", "TR-SI-DATA", "TR-SI-VALOR", "TR-VLR-REC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0060.",
        Aliases = ["BGOW0060", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0060", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0060 templates.",
        Aliases = ["BGOW0060", "1241", "1255"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0060", "BGOW0060-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0060", "BGOW0060-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0060", "BGOW0060-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0060", "BGOW0060-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0060", "BGOW0060-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0060", "BGOW0060-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0060-AUX-MARCA",
        Aliases = ["BGOW0060", "BGOW0060-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0060", "BGOW0060-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente: Preencher a espaços, uma vez que é sempre para mediador",
        Aliases = ["BGOW0060", "BGOW0060-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice: Preencher a espaços, uma vez que poderá existir várias apólices associadas",
        Aliases = ["BGOW0060", "BGOW0060-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0060", "BGOW0060-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0060", "BGOW0060-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0060-DADOS-DOCUMENTO",
        Aliases = ["BGOW0060", "BGOW0060-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "MdNome",
        "Nome",
        Aliases = ["BGOW0060", "BGOW0060-MD-NOME", "MD-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdNome { get; init; }

    [DomainSearch(
        "MdLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0060", "BGOW0060-MD-LOCATION-REF", "MD-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdLocationRef { get; init; }

    [DomainSearch(
        "MdMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0060", "BGOW0060-MD-MORADA1", "MD-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdMorada1 { get; init; }

    [DomainSearch(
        "MdMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0060", "BGOW0060-MD-MORADA2", "MD-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdMorada2 { get; init; }

    [DomainSearch(
        "MdLocalidade",
        "Localidade",
        Aliases = ["BGOW0060", "BGOW0060-MD-LOCALIDADE", "MD-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdLocalidade { get; init; }

    [DomainSearch(
        "MdCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0060", "BGOW0060-MD-CPOSTAL", "MD-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdCpostal { get; init; }

    [DomainSearch(
        "MdCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0060", "BGOW0060-MD-CPOSTAL-DESC", "MD-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdCpostalDesc { get; init; }

    [DomainSearch(
        "MdCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0060", "BGOW0060-MD-CPAIS", "MD-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdCpais { get; init; }

    [DomainSearch(
        "MdCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0060", "BGOW0060-MD-CPAIS-DESC", "MD-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdCpaisDesc { get; init; }

    [DomainSearch(
        "MdIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0060", "BGOW0060-MD-IDP", "MD-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdIdp { get; init; }

    [DomainSearch(
        "MdNif",
        "Número de Identificação Fiscal do Mediador (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0060", "BGOW0060-MD-NIF", "MD-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdNif { get; init; }

    [DomainSearch(
        "MdTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0060", "BGOW0060-MD-TIPO-ENTIDADE", "MD-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? MdTipoEntidade { get; init; }

    [DomainSearch(
        "DtEmissao",
        "Data de emissão [aaaammdd]",
        Aliases = ["BGOW0060", "BGOW0060-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtEmissao { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0060", "BGOW0060-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "QteLinDet",
        "Quantidade de linhas de detalhe",
        Aliases = ["BGOW0060", "BGOW0060-QTE-LIN-DET", "QTE-LIN-DET"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? QteLinDet { get; init; }

    [DomainSearch(
        "Periodo",
        "Período (aaaa/mm)",
        Aliases = ["BGOW0060", "BGOW0060-PERIODO", "PERIODO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? Periodo { get; init; }

    [DomainSearch(
        "DtData",
        "Data [aaaammdd]",
        Aliases = ["BGOW0060", "BGOW0060-DT-DATA", "DT-DATA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtData { get; init; }

    [DomainSearch(
        "DtHora",
        "Hora (hhmmss)",
        Aliases = ["BGOW0060", "BGOW0060-DT-HORA", "DT-HORA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtHora { get; init; }

    [DomainSearch(
        "DtReferencia",
        "Referência do Movimento",
        Aliases = ["BGOW0060", "BGOW0060-DT-REFERENCIA", "DT-REFERENCIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtReferencia { get; init; }

    [DomainSearch(
        "DtTipoMovimento",
        "Tipo do Movimento",
        Aliases = ["BGOW0060", "BGOW0060-DT-TIPO-MOVIMENTO", "DT-TIPO-MOVIMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtTipoMovimento { get; init; }

    [DomainSearch(
        "DtNrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0060", "BGOW0060-DT-NR-APOLICE", "DT-NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtNrApolice { get; init; }

    [DomainSearch(
        "DtNrSinistro",
        "Número do Sinistro",
        Aliases = ["BGOW0060", "BGOW0060-DT-NR-SINISTRO", "DT-NR-SINISTRO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtNrSinistro { get; init; }

    [DomainSearch(
        "DtNrRecibo",
        "Número do Recibo (Garantir que no máximo vem 11 posições Vida / 10 posições nos restantes)",
        Aliases = ["BGOW0060", "BGOW0060-DT-NR-RECIBO", "DT-NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtNrRecibo { get; init; }

    [DomainSearch(
        "DtTipo",
        "Tipo de Recibo",
        Aliases = ["BGOW0060", "BGOW0060-DT-TIPO", "DT-TIPO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtTipo { get; init; }

    [DomainSearch(
        "DtVlrRec",
        "Valor Total do Recibo",
        Aliases = ["BGOW0060", "BGOW0060-DT-VLR-REC", "DT-VLR-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtVlrRec { get; init; }

    [DomainSearch(
        "DtVlrCom",
        "Valor Comissão",
        Aliases = ["BGOW0060", "BGOW0060-DT-VLR-COM", "DT-VLR-COM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtVlrCom { get; init; }

    [DomainSearch(
        "DtVlrIrs",
        "Valor IRS",
        Aliases = ["BGOW0060", "BGOW0060-DT-VLR-IRS", "DT-VLR-IRS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtVlrIrs { get; init; }

    [DomainSearch(
        "DtVlrSel",
        "Valor Imposto Selo",
        Aliases = ["BGOW0060", "BGOW0060-DT-VLR-SEL", "DT-VLR-SEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtVlrSel { get; init; }

    [DomainSearch(
        "DtVlrSeg",
        "Valor Segurança Social",
        Aliases = ["BGOW0060", "BGOW0060-DT-VLR-SEG", "DT-VLR-SEG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtVlrSeg { get; init; }

    [DomainSearch(
        "DtVlrOut",
        "Valor Outros Movimentos",
        Aliases = ["BGOW0060", "BGOW0060-DT-VLR-OUT", "DT-VLR-OUT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? DtVlrOut { get; init; }

    [DomainSearch(
        "TrSiData",
        "Data de Saldo Inicial do Resumo [aaaammdd]",
        Aliases = ["BGOW0060", "BGOW0060-TR-SI-DATA", "TR-SI-DATA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrSiData { get; init; }

    [DomainSearch(
        "TrSiValor",
        "Valor de Saldo Inicial do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-SI-VALOR", "TR-SI-VALOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrSiValor { get; init; }

    [DomainSearch(
        "TrVlrRec",
        "Total Valor Recibo do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-VLR-REC", "TR-VLR-REC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrVlrRec { get; init; }

    [DomainSearch(
        "TrVlrCom",
        "Total Valor Comissões do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-VLR-COM", "TR-VLR-COM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrVlrCom { get; init; }

    [DomainSearch(
        "TrVlrIrs",
        "Total Valor IRS do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-VLR-IRS", "TR-VLR-IRS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrVlrIrs { get; init; }

    [DomainSearch(
        "TrVlrSel",
        "Total Valor Imposto Selo do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-VLR-SEL", "TR-VLR-SEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrVlrSel { get; init; }

    [DomainSearch(
        "TrVlrSeg",
        "Total Valor Segurança Social do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-VLR-SEG", "TR-VLR-SEG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrVlrSeg { get; init; }

    [DomainSearch(
        "TrVlrOut",
        "Total Valor Outros Movimentos do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-VLR-OUT", "TR-VLR-OUT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrVlrOut { get; init; }

    [DomainSearch(
        "TrSfValor",
        "Valor de Saldo Final do Resumo",
        Aliases = ["BGOW0060", "BGOW0060-TR-SF-VALOR", "TR-SF-VALOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TrSfValor { get; init; }

    [DomainSearch(
        "TaVlrCom",
        "Total Valor Comissões do Acumulado Fiscal",
        Aliases = ["BGOW0060", "BGOW0060-TA-VLR-COM", "TA-VLR-COM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TaVlrCom { get; init; }

    [DomainSearch(
        "TaVlrIrs",
        "Total Valor IRS do Acumulado Fiscal",
        Aliases = ["BGOW0060", "BGOW0060-TA-VLR-IRS", "TA-VLR-IRS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TaVlrIrs { get; init; }

    [DomainSearch(
        "TaVlrSel",
        "Total Valor Imposto Selo do Acumulado Fiscal",
        Aliases = ["BGOW0060", "BGOW0060-TA-VLR-SEL", "TA-VLR-SEL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TaVlrSel { get; init; }

    [DomainSearch(
        "TaVlrSeg",
        "Total Valor Segurança Social do Acumulado Fiscal",
        Aliases = ["BGOW0060", "BGOW0060-TA-VLR-SEG", "TA-VLR-SEG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0060"])]
    public string? TaVlrSeg { get; init; }

}
