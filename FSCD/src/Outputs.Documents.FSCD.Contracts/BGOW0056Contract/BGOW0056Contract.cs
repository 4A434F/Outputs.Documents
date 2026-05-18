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
    "BGOW0056 contract",
    "FSCD remuneration-in-kind letter copybook.",
    Aliases = ["BGOW0056"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0056"])]
public sealed class BGOW0056Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0056";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0056.",
        Aliases = ["BGOW0056", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0056.",
        Aliases = ["BGOW0056", "NR-APOLICE", "COD-MOEDA"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0056.",
        Aliases = ["BGOW0056", "NR-CLIENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Mediator",
        "Optional mediator party identified in BGOW0056.",
        Aliases = ["BGOW0056", "MD-NOME", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC", "MD-CPAIS", "MD-CPAIS-DESC", "MD-IDP", "MD-NIF", "MD-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "entity", "mediator"])]
    public Entity? Mediator { get; init; }

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0056.",
        Aliases = ["BGOW0056", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0056.",
        Aliases = ["BGOW0056", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0056.",
        Aliases = ["BGOW0056", "VLR-RECEBER", "DT-VLR-DESCR", "TT-VALOR"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "TextBlocks",
        "Document text, notes, clauses, or message lines identified in BGOW0056.",
        Aliases = ["BGOW0056", "DT-DESCRITIVO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "text"])]
    public IReadOnlyList<TextBlock> TextBlocks { get; init; } = [];

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0056.",
        Aliases = ["BGOW0056", "DT-CARTA", "DT-DESCRITIVO", "DT-VLR-DESCR", "TT-VALOR"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0056.",
        Aliases = ["BGOW0056", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0056", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0056 templates.",
        Aliases = ["BGOW0056", "1147"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0056"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0056", "BGOW0056-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0056", "BGOW0056-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0056", "BGOW0056-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0056", "BGOW0056-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0056", "BGOW0056-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0056", "BGOW0056-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0056-AUX-MARCA",
        Aliases = ["BGOW0056", "BGOW0056-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0056", "BGOW0056-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0056", "BGOW0056-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0056", "BGOW0056-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0056", "BGOW0056-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0056", "BGOW0056-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0056-DADOS-DOCUMENTO",
        Aliases = ["BGOW0056", "BGOW0056-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0056", "BGOW0056-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "QteLinDet",
        "Quantidade de linhas de detalhe",
        Aliases = ["BGOW0056", "BGOW0056-QTE-LIN-DET", "QTE-LIN-DET"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? QteLinDet { get; init; }

    [DomainSearch(
        "DtCarta",
        "Data emissão da carta [aaaammdd]",
        Aliases = ["BGOW0056", "BGOW0056-DT-CARTA", "DT-CARTA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? DtCarta { get; init; }

    [DomainSearch(
        "VlrReceber",
        "Valor a receber",
        Aliases = ["BGOW0056", "BGOW0056-VLR-RECEBER", "VLR-RECEBER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? VlrReceber { get; init; }

    [DomainSearch(
        "MdNome",
        "Nome",
        Aliases = ["BGOW0056", "BGOW0056-MD-NOME", "MD-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdNome { get; init; }

    [DomainSearch(
        "MdLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0056", "BGOW0056-MD-LOCATION-REF", "MD-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdLocationRef { get; init; }

    [DomainSearch(
        "MdMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0056", "BGOW0056-MD-MORADA1", "MD-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdMorada1 { get; init; }

    [DomainSearch(
        "MdMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0056", "BGOW0056-MD-MORADA2", "MD-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdMorada2 { get; init; }

    [DomainSearch(
        "MdLocalidade",
        "Localidade",
        Aliases = ["BGOW0056", "BGOW0056-MD-LOCALIDADE", "MD-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdLocalidade { get; init; }

    [DomainSearch(
        "MdCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0056", "BGOW0056-MD-CPOSTAL", "MD-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdCpostal { get; init; }

    [DomainSearch(
        "MdCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0056", "BGOW0056-MD-CPOSTAL-DESC", "MD-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdCpostalDesc { get; init; }

    [DomainSearch(
        "MdCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0056", "BGOW0056-MD-CPAIS", "MD-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdCpais { get; init; }

    [DomainSearch(
        "MdCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0056", "BGOW0056-MD-CPAIS-DESC", "MD-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdCpaisDesc { get; init; }

    [DomainSearch(
        "MdIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0056", "BGOW0056-MD-IDP", "MD-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdIdp { get; init; }

    [DomainSearch(
        "MdNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0056", "BGOW0056-MD-NIF", "MD-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdNif { get; init; }

    [DomainSearch(
        "MdTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0056", "BGOW0056-MD-TIPO-ENTIDADE", "MD-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? MdTipoEntidade { get; init; }

    [DomainSearch(
        "DtDescritivo",
        "Descritivo da remuneração",
        Aliases = ["BGOW0056", "BGOW0056-DT-DESCRITIVO", "DT-DESCRITIVO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? DtDescritivo { get; init; }

    [DomainSearch(
        "DtVlrDescr",
        "Valor da remuneração",
        Aliases = ["BGOW0056", "BGOW0056-DT-VLR-DESCR", "DT-VLR-DESCR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? DtVlrDescr { get; init; }

    [DomainSearch(
        "TtValor",
        "Valor total da remuneração",
        Aliases = ["BGOW0056", "BGOW0056-TT-VALOR", "TT-VALOR"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0056"])]
    public string? TtValor { get; init; }

}
