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
    "BGOW0054 contract",
    "FSCD transfer and cheque letter copybook.",
    Aliases = ["BGOW0054"],
    Tags = ["contract", "origin:FSCD", "copybook:BGOW0054"])]
public sealed class BGOW0054Contract : IDocumentModel
{
    public const string OriginSystem = "FSCD";

    public const string CopybookId = "BGOW0054";

    #region Identified reusable structures

    [DomainSearch(
        "DocumentInformation",
        "Structured document envelope and routing information identified in BGOW0054.",
        Aliases = ["BGOW0054", "COD-DOCUMENTO", "TIPO-IMPRESSAO", "USERID", "COD-COMPANHIA", "COD-MARCA", "AUX-MARCA", "NR-AGENTE", "NR-CLIENTE", "NR-APOLICE", "COD-ORIGEM", "IND-FLYER", "DT-NR-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "document"])]
    public DocumentInformation DocumentInformation { get; init; } = new();

    [DomainSearch(
        "Policy",
        "Structured policy, product, branch, certificate, or adherent context identified in BGOW0054.",
        Aliases = ["BGOW0054", "NR-APOLICE", "COD-MOEDA", "DT-COD-RAMO", "DT-NR-APOLICE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "policy"])]
    public Policy Policy { get; init; } = new();

    [DomainSearch(
        "Client",
        "Structured client, policyholder, or destination party identified in BGOW0054.",
        Aliases = ["BGOW0054", "NR-CLIENTE", "CL-NOME", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "CL-CPAIS", "CL-CPAIS-DESC", "CL-IDP", "CL-NIF", "CL-TIPO-ENTIDADE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "entity", "client"])]
    public Entity Client { get; init; } = new();

    [DomainSearch(
        "Agent",
        "Optional agent or collecting mediator party identified in BGOW0054.",
        Aliases = ["BGOW0054", "NR-AGENTE"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "entity", "agent"])]
    public Entity? Agent { get; init; }

    [DomainSearch(
        "Creditor",
        "Optional creditor or mortgage creditor party identified in BGOW0054.",
        Aliases = ["BGOW0054", "CH-NR-CHEQUE", "CH-DATA-CHEQUE", "CH-LINHA-OTICA", "CH-EXTENSO-L1", "CH-EXTENSO-L2"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "entity", "creditor"])]
    public Entity? Creditor { get; init; }

    [DomainSearch(
        "Lawyer",
        "Optional lawyer party identified in BGOW0054.",
        Aliases = ["BGOW0054", "AD-NUMERO", "AD-NOME", "AD-LOCATION-REF", "AD-MORADA1", "AD-MORADA2", "AD-LOCALIDADE", "AD-CPOSTAL", "AD-CPOSTAL-DESC", "AD-CPAIS", "AD-CPAIS-DESC", "AD-IDP"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "entity", "lawyer"])]
    public Entity? Lawyer { get; init; }

    [DomainSearch(
        "MailingAddress",
        "Structured postal destination or mailing address identified in BGOW0054.",
        Aliases = ["BGOW0054", "CL-LOCATION-REF", "CL-MORADA1", "CL-MORADA2", "CL-LOCALIDADE", "CL-CPOSTAL", "CL-CPOSTAL-DESC", "AD-LOCATION-REF", "AD-MORADA1", "AD-MORADA2", "AD-LOCALIDADE", "AD-CPOSTAL", "AD-CPOSTAL-DESC"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "address"])]
    public PostalAddress MailingAddress { get; init; } = new();

    [DomainSearch(
        "PaymentAccount",
        "Bank-account payment details identified in BGOW0054.",
        Aliases = ["BGOW0054", "DEB-NOME-BANCO", "DEB-IBAN", "DEB-SWIFT"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "payment", "banking"])]
    public BankAccount? PaymentAccount { get; init; }

    [DomainSearch(
        "Premium",
        "Premium, value, capital, or total amounts identified in BGOW0054.",
        Aliases = ["BGOW0054", "DT-VLR-IRS", "DT-VLR-RECIBO", "TT-VLR-IRS", "TT-VLR-RECIBO", "TT-VLR-RET", "TT-VLR-TOT", "TT-VLR-TOTT"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "premium", "amount"])]
    public Premium Premium { get; init; } = new();

    [DomainSearch(
        "TextBlocks",
        "Document text, notes, clauses, or message lines identified in BGOW0054.",
        Aliases = ["BGOW0054", "CH-LINHA-OTICA", "DT-DESCRITIVO1", "DT-DESCRITIVO2", "DT-DESCRITIVO3", "DT-DESCRITIVO4"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "text"])]
    public IReadOnlyList<TextBlock> TextBlocks { get; init; } = [];

    [DomainSearch(
        "Tables",
        "Repeated detail, footer, list, statement, or tabular blocks identified in BGOW0054.",
        Aliases = ["BGOW0054", "DT-EMISSAO", "DT-COD-RAMO", "DT-NR-SINISTRO", "DT-NR-RECIBO", "DT-NR-APOLICE", "DT-DESCRITIVO1", "DT-DESCRITIVO2", "DT-DESCRITIVO3", "DT-DESCRITIVO4", "DT-VLR-IRS", "DT-VLR-RECIBO", "TT-VLR-IRS", "TT-VLR-RECIBO", "TT-VLR-RET", "TT-VLR-TOT", "TT-VLR-TOTT"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "table"])]
    public IReadOnlyList<GenericTable> Tables { get; init; } = [];

    [DomainSearch(
        "PrintRecordControl",
        "Record type, document sequence, or print-payload control fields identified in BGOW0054.",
        Aliases = ["BGOW0054", "TIPO-REGISTO"],
        Tags = ["structure", "origin:FSCD", "copybook:BGOW0054", "print-payload"])]
    public PrintPayloadRecordControl PrintRecordControl { get; init; } = new();
    #endregion




    [DomainSearch(
        "Document identification",
        "Outputs document identification associated with BGOW0054 templates.",
        Aliases = ["BGOW0054", "1144", "1145"],
        Tags = ["field", "selector", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DocumentIdentification { get; init; }

    [DomainSearch(
        "CodDocumento",
        "Código de documento",
        Aliases = ["BGOW0054", "BGOW0054-COD-DOCUMENTO", "COD-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? CodDocumento { get; init; }

    [DomainSearch(
        "TipoRegisto",
        "Tipo de registo",
        Aliases = ["BGOW0054", "BGOW0054-TIPO-REGISTO", "TIPO-REGISTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? TipoRegisto { get; init; }

    [DomainSearch(
        "TipoImpressao",
        "Tipo de impressão",
        Aliases = ["BGOW0054", "BGOW0054-TIPO-IMPRESSAO", "TIPO-IMPRESSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? TipoImpressao { get; init; }

    [DomainSearch(
        "Userid",
        "User Id da impressão OnLine",
        Aliases = ["BGOW0054", "BGOW0054-USERID", "USERID"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? Userid { get; init; }

    [DomainSearch(
        "CodCompanhia",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0054", "BGOW0054-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "CodMarca",
        "Código de identificação da Marca",
        Aliases = ["BGOW0054", "BGOW0054-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "AuxMarca",
        "BGOW0054-AUX-MARCA",
        Aliases = ["BGOW0054", "BGOW0054-AUX-MARCA", "AUX-MARCA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AuxMarca { get; init; }

    [DomainSearch(
        "NrAgente",
        "Número do Mediador",
        Aliases = ["BGOW0054", "BGOW0054-NR-AGENTE", "NR-AGENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? NrAgente { get; init; }

    [DomainSearch(
        "NrCliente",
        "Número do Cliente",
        Aliases = ["BGOW0054", "BGOW0054-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NrApolice",
        "Número da Apólice: Preencher a espaços, uma vez que poderá existir várias apólices associadas",
        Aliases = ["BGOW0054", "BGOW0054-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "CodOrigem",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0054", "BGOW0054-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "IndFlyer",
        "Indicador de inclusão de Flyer (ex: \"V\" - Cobertura PVC)",
        Aliases = ["BGOW0054", "BGOW0054-IND-FLYER", "IND-FLYER"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? IndFlyer { get; init; }

    [DomainSearch(
        "DadosDocumento",
        "BGOW0054-DADOS-DOCUMENTO",
        Aliases = ["BGOW0054", "BGOW0054-DADOS-DOCUMENTO", "DADOS-DOCUMENTO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DadosDocumento { get; init; }

    [DomainSearch(
        "ClNome",
        "Nome",
        Aliases = ["BGOW0054", "BGOW0054-CL-NOME", "CL-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClNome { get; init; }

    [DomainSearch(
        "ClLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0054", "BGOW0054-CL-LOCATION-REF", "CL-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClLocationRef { get; init; }

    [DomainSearch(
        "ClMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0054", "BGOW0054-CL-MORADA1", "CL-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClMorada1 { get; init; }

    [DomainSearch(
        "ClMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0054", "BGOW0054-CL-MORADA2", "CL-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClMorada2 { get; init; }

    [DomainSearch(
        "ClLocalidade",
        "Localidade",
        Aliases = ["BGOW0054", "BGOW0054-CL-LOCALIDADE", "CL-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClLocalidade { get; init; }

    [DomainSearch(
        "ClCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0054", "BGOW0054-CL-CPOSTAL", "CL-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClCpostal { get; init; }

    [DomainSearch(
        "ClCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0054", "BGOW0054-CL-CPOSTAL-DESC", "CL-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClCpostalDesc { get; init; }

    [DomainSearch(
        "ClCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0054", "BGOW0054-CL-CPAIS", "CL-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClCpais { get; init; }

    [DomainSearch(
        "ClCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0054", "BGOW0054-CL-CPAIS-DESC", "CL-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClCpaisDesc { get; init; }

    [DomainSearch(
        "ClIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0054", "BGOW0054-CL-IDP", "CL-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClIdp { get; init; }

    [DomainSearch(
        "ClNif",
        "Número de identificação fiscal (No caso de Portugal será PT999999999)",
        Aliases = ["BGOW0054", "BGOW0054-CL-NIF", "CL-NIF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClNif { get; init; }

    [DomainSearch(
        "ClTipoEntidade",
        "Tipo Entidade",
        Aliases = ["BGOW0054", "BGOW0054-CL-TIPO-ENTIDADE", "CL-TIPO-ENTIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ClTipoEntidade { get; init; }

    [DomainSearch(
        "AdNumero",
        "Número de advogado",
        Aliases = ["BGOW0054", "BGOW0054-AD-NUMERO", "AD-NUMERO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdNumero { get; init; }

    [DomainSearch(
        "AdNome",
        "Nome",
        Aliases = ["BGOW0054", "BGOW0054-AD-NOME", "AD-NOME"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdNome { get; init; }

    [DomainSearch(
        "AdLocationRef",
        "Referência da morada",
        Aliases = ["BGOW0054", "BGOW0054-AD-LOCATION-REF", "AD-LOCATION-REF"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdLocationRef { get; init; }

    [DomainSearch(
        "AdMorada1",
        "Dados de morada 1",
        Aliases = ["BGOW0054", "BGOW0054-AD-MORADA1", "AD-MORADA1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdMorada1 { get; init; }

    [DomainSearch(
        "AdMorada2",
        "Dados de morada 2",
        Aliases = ["BGOW0054", "BGOW0054-AD-MORADA2", "AD-MORADA2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdMorada2 { get; init; }

    [DomainSearch(
        "AdLocalidade",
        "Localidade",
        Aliases = ["BGOW0054", "BGOW0054-AD-LOCALIDADE", "AD-LOCALIDADE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdLocalidade { get; init; }

    [DomainSearch(
        "AdCpostal",
        "Código postal (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0054", "BGOW0054-AD-CPOSTAL", "AD-CPOSTAL"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdCpostal { get; init; }

    [DomainSearch(
        "AdCpostalDesc",
        "Descritivo do código postal",
        Aliases = ["BGOW0054", "BGOW0054-AD-CPOSTAL-DESC", "AD-CPOSTAL-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdCpostalDesc { get; init; }

    [DomainSearch(
        "AdCpais",
        "Código do País (Se estrangeiro, diferente de 620)",
        Aliases = ["BGOW0054", "BGOW0054-AD-CPAIS", "AD-CPAIS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdCpais { get; init; }

    [DomainSearch(
        "AdCpaisDesc",
        "Descritivo do País",
        Aliases = ["BGOW0054", "BGOW0054-AD-CPAIS-DESC", "AD-CPAIS-DESC"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdCpaisDesc { get; init; }

    [DomainSearch(
        "AdIdp",
        "Identificação da Porta (no CBC)",
        Aliases = ["BGOW0054", "BGOW0054-AD-IDP", "AD-IDP"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? AdIdp { get; init; }

    [DomainSearch(
        "DtEmissao",
        "Data de emissão [aaaammdd]",
        Aliases = ["BGOW0054", "BGOW0054-DT-EMISSAO", "DT-EMISSAO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtEmissao { get; init; }

    [DomainSearch(
        "DebNomeBanco",
        "Nome do Banco",
        Aliases = ["BGOW0054", "BGOW0054-DEB-NOME-BANCO", "DEB-NOME-BANCO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DebNomeBanco { get; init; }

    [DomainSearch(
        "DebIban",
        "IBAN",
        Aliases = ["BGOW0054", "BGOW0054-DEB-IBAN", "DEB-IBAN"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DebIban { get; init; }

    [DomainSearch(
        "DebSwift",
        "BICSWIFT",
        Aliases = ["BGOW0054", "BGOW0054-DEB-SWIFT", "DEB-SWIFT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DebSwift { get; init; }

    [DomainSearch(
        "ChNrCheque",
        "Número do Cheque",
        Aliases = ["BGOW0054", "BGOW0054-CH-NR-CHEQUE", "CH-NR-CHEQUE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ChNrCheque { get; init; }

    [DomainSearch(
        "ChDataCheque",
        "Data do cheque - formato AAAAMMDD",
        Aliases = ["BGOW0054", "BGOW0054-CH-DATA-CHEQUE", "CH-DATA-CHEQUE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ChDataCheque { get; init; }

    [DomainSearch(
        "ChLinhaOtica",
        "Linha otica do cheque",
        Aliases = ["BGOW0054", "BGOW0054-CH-LINHA-OTICA", "CH-LINHA-OTICA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ChLinhaOtica { get; init; }

    [DomainSearch(
        "ChExtensoL1",
        "Valor por extenso - preenchido com \"*\" até fim",
        Aliases = ["BGOW0054", "BGOW0054-CH-EXTENSO-L1", "CH-EXTENSO-L1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ChExtensoL1 { get; init; }

    [DomainSearch(
        "ChExtensoL2",
        "Linha2 do valor por extenso (se necessário)",
        Aliases = ["BGOW0054", "BGOW0054-CH-EXTENSO-L2", "CH-EXTENSO-L2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? ChExtensoL2 { get; init; }

    [DomainSearch(
        "CodMoeda",
        "Código de moeda (ex: EUR)",
        Aliases = ["BGOW0054", "BGOW0054-COD-MOEDA", "COD-MOEDA"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? CodMoeda { get; init; }

    [DomainSearch(
        "QteLinDet",
        "Quantidade de linhas de detalhe / máximo de 37 linhas para carta cheque",
        Aliases = ["BGOW0054", "BGOW0054-QTE-LIN-DET", "QTE-LIN-DET"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? QteLinDet { get; init; }

    [DomainSearch(
        "DtCodRamo",
        "Código de Ramo",
        Aliases = ["BGOW0054", "BGOW0054-DT-COD-RAMO", "DT-COD-RAMO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtCodRamo { get; init; }

    [DomainSearch(
        "DtNrSinistro",
        "Número do Sinistro",
        Aliases = ["BGOW0054", "BGOW0054-DT-NR-SINISTRO", "DT-NR-SINISTRO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtNrSinistro { get; init; }

    [DomainSearch(
        "DtNrRecibo",
        "Número do Recibo [Garantir que no máximo vem 11 posições Vida / 10 posições nos restantes]",
        Aliases = ["BGOW0054", "BGOW0054-DT-NR-RECIBO", "DT-NR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtNrRecibo { get; init; }

    [DomainSearch(
        "DtNrApolice",
        "Número da Apólice",
        Aliases = ["BGOW0054", "BGOW0054-DT-NR-APOLICE", "DT-NR-APOLICE"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtNrApolice { get; init; }

    [DomainSearch(
        "DtDescritivo1",
        "Descritivo linha 1",
        Aliases = ["BGOW0054", "BGOW0054-DT-DESCRITIVO1", "DT-DESCRITIVO1"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtDescritivo1 { get; init; }

    [DomainSearch(
        "DtDescritivo2",
        "Descritivo linha 2",
        Aliases = ["BGOW0054", "BGOW0054-DT-DESCRITIVO2", "DT-DESCRITIVO2"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtDescritivo2 { get; init; }

    [DomainSearch(
        "DtDescritivo3",
        "Descritivo linha 3",
        Aliases = ["BGOW0054", "BGOW0054-DT-DESCRITIVO3", "DT-DESCRITIVO3"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtDescritivo3 { get; init; }

    [DomainSearch(
        "DtDescritivo4",
        "Descritivo linha 4",
        Aliases = ["BGOW0054", "BGOW0054-DT-DESCRITIVO4", "DT-DESCRITIVO4"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtDescritivo4 { get; init; }

    [DomainSearch(
        "DtVlrIrs",
        "Valor Base Sujeito IRS",
        Aliases = ["BGOW0054", "BGOW0054-DT-VLR-IRS", "DT-VLR-IRS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtVlrIrs { get; init; }

    [DomainSearch(
        "DtVlrRecibo",
        "Valor Recibo",
        Aliases = ["BGOW0054", "BGOW0054-DT-VLR-RECIBO", "DT-VLR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? DtVlrRecibo { get; init; }

    [DomainSearch(
        "TtVlrIrs",
        "Total Valor Base Sujeito IRS",
        Aliases = ["BGOW0054", "BGOW0054-TT-VLR-IRS", "TT-VLR-IRS"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? TtVlrIrs { get; init; }

    [DomainSearch(
        "TtVlrRecibo",
        "Total Valor Recibo",
        Aliases = ["BGOW0054", "BGOW0054-TT-VLR-RECIBO", "TT-VLR-RECIBO"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? TtVlrRecibo { get; init; }

    [DomainSearch(
        "TtVlrRet",
        "Total Valor IRS - Retenção Efetuada",
        Aliases = ["BGOW0054", "BGOW0054-TT-VLR-RET", "TT-VLR-RET"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? TtVlrRet { get; init; }

    [DomainSearch(
        "TtVlrTot",
        "Total Valor",
        Aliases = ["BGOW0054", "BGOW0054-TT-VLR-TOT", "TT-VLR-TOT"],
        Tags = ["field", "origin:FSCD", "copybook:BGOW0054"])]
    public string? TtVlrTot { get; init; }

}
