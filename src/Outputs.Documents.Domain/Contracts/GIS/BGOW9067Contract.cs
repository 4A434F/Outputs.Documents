namespace Outputs.Documents.Domain.Contracts.GIS;

[DomainSearch(
    "BGOW9067 contract",
    "GIS BGOW9067 copybook contract.",
    Aliases = ["BGOW9067"],
    Tags = ["contract", "origin:GIS", "copybook:BGOW9067"])]
public sealed class BGOW9067Contract : IDocumentModel
{
    public const string OriginSystem = "GIS";

    public const string CopybookId = "BGOW9067";

    [DomainSearch(
        "COD-COMPANHIA",
        "Código de identificação da Companhia",
        Aliases = ["BGOW9067", "BGOW9067-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "COD-MARCA",
        "Código de identificação da Marca",
        Aliases = ["BGOW9067", "BGOW9067-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "COD-ORIGEM",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW9067", "BGOW9067-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "COD-POSTALM",
        "Código postal do Mediador (Se estrangeiro deverá vir a zeros) [99990999]",
        Aliases = ["BGOW9067", "BGOW9067-COD-POSTALM", "COD-POSTALM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? CodPostalm { get; init; }

    [DomainSearch(
        "NR-MEDIADOR",
        "Número do Mediador (se existir Mediador, espaços para restantes casos)",
        Aliases = ["BGOW9067", "BGOW9067-NR-MEDIADOR", "NR-MEDIADOR"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? NrMediador { get; init; }

    [DomainSearch(
        "COD-POSTALC",
        "Código postal do Cliente (Se estrangeiro deverá vir a zeros) [99990999]",
        Aliases = ["BGOW9067", "BGOW9067-COD-POSTALC", "COD-POSTALC"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? CodPostalc { get; init; }

    [DomainSearch(
        "NR-CLIENTE",
        "Número do Cliente",
        Aliases = ["BGOW9067", "BGOW9067-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NR-APOLICE",
        "Número da Apólice",
        Aliases = ["BGOW9067", "BGOW9067-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "COD-PRODUTO",
        "Código do Produto (modalidade 2, versão 2, spaces 2)",
        Aliases = ["BGOW9067", "BGOW9067-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "DATA-HORA",
        "Data e hora da emissão do documento",
        Aliases = ["BGOW9067", "BGOW9067-DATA-HORA", "DATA-HORA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW9067"])]
    public string? DataHora { get; init; }

}
