namespace Outputs.Documents.Domain.Contracts.GIS;

[DomainSearch(
    "BGOW9062 contract",
    "GIS BGOW9062 copybook contract.",
    Aliases = ["BGOW9062"],
    Tags = ["contract", "origin:GIS", "copybook:BGOW9062"])]
public sealed class BGOW9062Contract : IDocumentModel
{
    public const string OriginSystem = "GIS";

    public const string CopybookId = "BGOW9062";

    [DomainSearch(
        "COD-COMPANHIA",
        "Código de identificação da Companhia",
        Aliases = ["BGOW9062", "BGOW9062-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "COD-MARCA",
        "Código de identificação da Marca",
        Aliases = ["BGOW9062", "BGOW9062-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "COD-ORIGEM",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW9062", "BGOW9062-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "COD-POSTALM",
        "Código postal do Mediador (Se estrangeiro deverá vir a zeros) [99990999]",
        Aliases = ["BGOW9062", "BGOW9062-COD-POSTALM", "COD-POSTALM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? CodPostalm { get; init; }

    [DomainSearch(
        "NR-MEDIADOR",
        "Número do Mediador (se existir Mediador, espaços para restantes casos)",
        Aliases = ["BGOW9062", "BGOW9062-NR-MEDIADOR", "NR-MEDIADOR"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? NrMediador { get; init; }

    [DomainSearch(
        "COD-POSTALC",
        "Código postal do Cliente (Se estrangeiro deverá vir a zeros) [99990999]",
        Aliases = ["BGOW9062", "BGOW9062-COD-POSTALC", "COD-POSTALC"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? CodPostalc { get; init; }

    [DomainSearch(
        "NR-CLIENTE",
        "Número do Cliente",
        Aliases = ["BGOW9062", "BGOW9062-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NR-APOLICE",
        "Número da Apólice",
        Aliases = ["BGOW9062", "BGOW9062-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "COD-PRODUTO",
        "Código do Produto (modalidade 2, versão 2, spaces 2)",
        Aliases = ["BGOW9062", "BGOW9062-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "DATA-HORA",
        "Data e hora da emissão do documento",
        Aliases = ["BGOW9062", "BGOW9062-DATA-HORA", "DATA-HORA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9062"])]
    public string? DataHora { get; init; }

}
