namespace Outputs.Documents.Domain.Contracts.FGS;

[DomainSearch(
    "BGOW0015 contract",
    "FGS BGOW0015 copybook contract.",
    Aliases = ["BGOW0015"],
    Tags = ["contract", "origin:FGS", "copybook:BGOW0015"])]
public sealed class BGOW0015Contract : IDocumentModel
{
    public const string OriginSystem = "FGS";

    public const string CopybookId = "BGOW0015";

    [DomainSearch(
        "COD-COMPANHIA",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0015", "BGOW0015-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "COD-MARCA",
        "Código de identificação da Marca",
        Aliases = ["BGOW0015", "BGOW0015-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "COD-ORIGEM",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0015", "BGOW0015-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "COD-POSTALM",
        "Código Postal do Mediador -este campo só deve vir preenchido se o documento for passivel de ser entregue ao mediador.",
        Aliases = ["BGOW0015", "BGOW0015-COD-POSTALM", "COD-POSTALM"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? CodPostalm { get; init; }

    [DomainSearch(
        "NR-MEDIADOR",
        "Número do Mediador -este campo só deve vir preenchido se o documento for passivel de ser entregue ao mediador.",
        Aliases = ["BGOW0015", "BGOW0015-NR-MEDIADOR", "NR-MEDIADOR"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? NrMediador { get; init; }

    [DomainSearch(
        "COD-POSTALC",
        "Código Postal do Cliente -este campo deve ser preenchido com o valor do codigo postal da entidade a quem o documento vai endereçado.",
        Aliases = ["BGOW0015", "BGOW0015-COD-POSTALC", "COD-POSTALC"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? CodPostalc { get; init; }

    [DomainSearch(
        "NR-CLIENTE",
        "Número do Cliente -este campo deve ser preenchido com o valor do numero da entidade a quem o documento vai endereçado.",
        Aliases = ["BGOW0015", "BGOW0015-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NR-APOLICE",
        "Número da Apólice ATENÇÃO: Quando o documento refere mais do que uma apólice o campo NR-APOLICE deve vir do SO preenchido a espaços.",
        Aliases = ["BGOW0015", "BGOW0015-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "COD-PRODUTO",
        "Código de Produto",
        Aliases = ["BGOW0015", "BGOW0015-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "DATA-HORA",
        "Data e Hora de emissão do documento",
        Aliases = ["BGOW0015", "BGOW0015-DATA-HORA", "DATA-HORA"],
        Tags = ["field", "origin:FGS", "copybook:BGOW0015"])]
    public string? DataHora { get; init; }

}
