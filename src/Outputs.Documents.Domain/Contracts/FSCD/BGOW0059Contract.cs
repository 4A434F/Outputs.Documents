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
    "BGOW0059 contract",
    "FSCD payment order copybook.",
    Aliases = ["BGOW0059"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0059"])]
public sealed class BGOW0059Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0059";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0059.",
        Aliases = ["BGOW0059", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0059.",
        Aliases = ["BGOW0059", "NR-APOLICE", "COD-MOEDA"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0059.",
        Aliases = ["BGOW0059", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Mediator",
        "Optional mediator party identified in BGOW0059.",
        Aliases = ["BGOW0059", "MD-NOME", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC", "MD-CPAIS", "MD-CPAIS-DESC", "MD-IDP"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "entity", "mediator"])]
    public Entity? Mediator { get; init; }

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0059.",
        Aliases = ["BGOW0059", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "Creditor",
        "Optional creditor or mortgage creditor party identified in BGOW0059.",
        Aliases = ["BGOW0059", "CH-NR-CHEQUE", "CH-DATA-CHEQUE", "CH-LINHA-OTICA", "CH-EXTENSO-L1", "CH-EXTENSO-L2"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "entity", "creditor"])]
    public Entity? Creditor { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0059.",
        Aliases = ["BGOW0059", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "MD-LOCATION-REF", "MD-MORADA1", "MD-MORADA2", "MD-LOCALIDADE", "MD-CPOSTAL", "MD-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "PaymentAccount",
        "Bank-account payment details identified in BGOW0059.",
        Aliases = ["BGOW0059", "DEB-NOME-BANCO", "DEB-IBAN", "DEB-SWIFT"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "payment", "banking"])]
    public BankAccount? PaymentAccount { get; init; }

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0059.",
        Aliases = ["BGOW0059", "DT-VLR-ORDEM-PAG"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "TextBlocks",
        "Document text, notes, clauses, or message lines identified in BGOW0059.",
        Aliases = ["BGOW0059", "CH-LINHA-OTICA"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "text"])]
    public IReadOnlyList<TextBlock> TextBlocks { get; init; } = [];

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0059.",
        Aliases = ["BGOW0059", "DT-EMISSAO", "DT-CREDITO", "DT-VLR-ORDEM-PAG"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0059.",
        Aliases = ["BGOW0059", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0059", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0059 templates.",
        Aliases = ["BGOW0059", "1149", "1150"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0059", "BGOW0059-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0059", "BGOW0059-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0059", "BGOW0059-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0059", "BGOW0059-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0059", "BGOW0059-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0059", "BGOW0059-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "'028' - Eurobic",
        Aliases = ["BGOW0059", "BGOW0059-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0059", "BGOW0059-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0059", "BGOW0059-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0059", "BGOW0059-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0059", "BGOW0059-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0059", "BGOW0059-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0059-DADOS-DOCUMENTO",
        Aliases = ["BGOW0059", "BGOW0059-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0059", "BGOW0059-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0059", "BGOW0059-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0059", "BGOW0059-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0059", "BGOW0059-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0059", "BGOW0059-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0059", "BGOW0059-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0059", "BGOW0059-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0059", "BGOW0059-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0059", "BGOW0059-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0059", "BGOW0059-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0059", "BGOW0059-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0059", "BGOW0059-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "MdNome",
        "Nome do Mediador",
        Aliases = ["BGOW0059", "BGOW0059-MD-NOME", "MD-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdNome { get; init; }

    [DomainSearch(
        "MdLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0059", "BGOW0059-MD-LOCATION-REF", "MD-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdLocationRef { get; init; }

    [DomainSearch(
        "MdMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0059", "BGOW0059-MD-MORADA1", "MD-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdMorada1 { get; init; }

    [DomainSearch(
        "MdMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0059", "BGOW0059-MD-MORADA2", "MD-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdMorada2 { get; init; }

    [DomainSearch(
        "MdLocalidade",
        "Localidade",
        Aliases = ["BGOW0059", "BGOW0059-MD-LOCALIDADE", "MD-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdLocalidade { get; init; }

    [DomainSearch(
        "MdCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0059", "BGOW0059-MD-CPOSTAL", "MD-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdCpostal { get; init; }

    [DomainSearch(
        "MdCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0059", "BGOW0059-MD-CPOSTAL-DESC", "MD-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdCpostalDesc { get; init; }

    [DomainSearch(
        "MdCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0059", "BGOW0059-MD-CPAIS", "MD-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdCpais { get; init; }

    [DomainSearch(
        "MdCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0059", "BGOW0059-MD-CPAIS-DESC", "MD-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdCpaisDesc { get; init; }

    [DomainSearch(
        "MdIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0059", "BGOW0059-MD-IDP", "MD-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? MdIdp { get; init; }

    [DomainSearch(
        "DtEmissao",
        "Data de emissão [aaaammdd]",
        Aliases = ["BGOW0059", "BGOW0059-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DtEmissao { get; init; }

    [DomainSearch(
        "DtCredito",
        "Data de crédito  [aaaammdd]",
        Aliases = ["BGOW0059", "BGOW0059-DT-CREDITO", "DT-CREDITO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DtCredito { get; init; }

    [DomainSearch(
        "DebNomeBanco",
        "Descritivo Banco",
        Aliases = ["BGOW0059", "BGOW0059-DEB-NOME-BANCO", "DEB-NOME-BANCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DebNomeBanco { get; init; }

    [DomainSearch(
        "DebIban",
        "IBAN",
        Aliases = ["BGOW0059", "BGOW0059-DEB-IBAN", "DEB-IBAN"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DebIban { get; init; }

    [DomainSearch(
        "DebSwift",
        "BICSWIFT",
        Aliases = ["BGOW0059", "BGOW0059-DEB-SWIFT", "DEB-SWIFT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DebSwift { get; init; }

    [DomainSearch(
        "ChNrCheque",
        "Número do Cheque",
        Aliases = ["BGOW0059", "BGOW0059-CH-NR-CHEQUE", "CH-NR-CHEQUE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ChNrCheque { get; init; }

    [DomainSearch(
        "ChDataCheque",
        "Data do cheque - formato AAAAMMDD",
        Aliases = ["BGOW0059", "BGOW0059-CH-DATA-CHEQUE", "CH-DATA-CHEQUE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ChDataCheque { get; init; }

    [DomainSearch(
        "ChLinhaOtica",
        "Linha otica do cheque",
        Aliases = ["BGOW0059", "BGOW0059-CH-LINHA-OTICA", "CH-LINHA-OTICA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ChLinhaOtica { get; init; }

    [DomainSearch(
        "ChExtensoL1",
        "Valor por extenso - preenchido com \"*\" até fim",
        Aliases = ["BGOW0059", "BGOW0059-CH-EXTENSO-L1", "CH-EXTENSO-L1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ChExtensoL1 { get; init; }

    [DomainSearch(
        "ChExtensoL2",
        "BGOW0059-CH-EXTENSO-L2",
        Aliases = ["BGOW0059", "BGOW0059-CH-EXTENSO-L2", "CH-EXTENSO-L2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? ChExtensoL2 { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0059", "BGOW0059-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "NrOrdemPag",
        "Número ordem de pagamento",
        Aliases = ["BGOW0059", "BGOW0059-NR-ORDEM-PAG", "NR-ORDEM-PAG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? NrOrdemPag { get; init; }

    [DomainSearch(
        "DtVlrOrdemPag",
        "Valor Ordem de Pagamento",
        Aliases = ["BGOW0059", "BGOW0059-DT-VLR-ORDEM-PAG", "DT-VLR-ORDEM-PAG"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? DtVlrOrdemPag { get; init; }

    [DomainSearch(
        "NrDocumento",
        "Número de documento",
        Aliases = ["BGOW0059", "BGOW0059-NR-DOCUMENTO", "NR-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? NrDocumento { get; init; }

    [DomainSearch(
        "InfoAdicional",
        "Informação Adicional [opcional - observações colocadas pelo utilizador]",
        Aliases = ["BGOW0059", "BGOW0059-INFO-ADICIONAL", "INFO-ADICIONAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0059"])]
    public string? InfoAdicional { get; init; }

}
