namespace Outputs.Documents.Domain.Contracts.GIS;

[DomainSearch(
    "BGOW0046 contract",
    "GIS BGOW0046 copybook contract.",
    Aliases = ["BGOW0046"],
    Tags = ["contract", "origin:GIS", "copybook:BGOW0046"])]
public sealed class BGOW0046Contract : IDocumentModel
{
    public const string OriginSystem = "GIS";

    public const string CopybookId = "BGOW0046";

    [DomainSearch(
        "COD-COMPANHIA",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0046", "BGOW0046-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "COD-MARCA",
        "Código de identificação da Marca",
        Aliases = ["BGOW0046", "BGOW0046-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "COD-ORIGEM",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0046", "BGOW0046-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "COD-POSTALM",
        "Código Postal do Mediador",
        Aliases = ["BGOW0046", "BGOW0046-COD-POSTALM", "COD-POSTALM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? CodPostalm { get; init; }

    [DomainSearch(
        "NR-MEDIADOR",
        "Número do Mediador",
        Aliases = ["BGOW0046", "BGOW0046-NR-MEDIADOR", "NR-MEDIADOR"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? NrMediador { get; init; }

    [DomainSearch(
        "COD-POSTALC",
        "Código Postal do Cliente",
        Aliases = ["BGOW0046", "BGOW0046-COD-POSTALC", "COD-POSTALC"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? CodPostalc { get; init; }

    [DomainSearch(
        "NR-CLIENTE",
        "Número do Cliente",
        Aliases = ["BGOW0046", "BGOW0046-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NR-APOLICE",
        "Número da Apólice",
        Aliases = ["BGOW0046", "BGOW0046-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "COD-PRODUTO",
        "Código de Produto",
        Aliases = ["BGOW0046", "BGOW0046-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "DATA-HORA",
        "Data e Hora de emissão do documento",
        Aliases = ["BGOW0046", "BGOW0046-DATA-HORA", "DATA-HORA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0046"])]
    public string? DataHora { get; init; }

}
