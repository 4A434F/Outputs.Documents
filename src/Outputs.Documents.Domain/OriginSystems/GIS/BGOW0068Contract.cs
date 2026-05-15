namespace Outputs.Documents.Domain.Contracts.GIS;

[DomainSearch(
    "BGOW0068 contract",
    "GIS BGOW0068 copybook contract.",
    Aliases = ["BGOW0068"],
    Tags = ["contract", "origin:GIS", "copybook:BGOW0068"])]
public sealed class BGOW0068Contract : IDocumentModel
{
    public const string OriginSystem = "GIS";

    public const string CopybookId = "BGOW0068";

    [DomainSearch(
        "COD-COMPANHIA",
        "Código de identificação da Companhia",
        Aliases = ["BGOW0068", "BGOW0068-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "COD-MARCA",
        "Código de identificação da Marca",
        Aliases = ["BGOW0068", "BGOW0068-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "COD-ORIGEM",
        "Código de identificação do Sistema Origem",
        Aliases = ["BGOW0068", "BGOW0068-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "COD-POSTALM",
        "Código postal do Mediador (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0068", "BGOW0068-COD-POSTALM", "COD-POSTALM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? CodPostalm { get; init; }

    [DomainSearch(
        "NR-MEDIADOR",
        "Número do Mediador",
        Aliases = ["BGOW0068", "BGOW0068-NR-MEDIADOR", "NR-MEDIADOR"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? NrMediador { get; init; }

    [DomainSearch(
        "COD-POSTALC",
        "Código postal do Cliente (Se estrangeiro deverá vir a zeros) [9999-999]",
        Aliases = ["BGOW0068", "BGOW0068-COD-POSTALC", "COD-POSTALC"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? CodPostalc { get; init; }

    [DomainSearch(
        "NR-CLIENTE",
        "Número do Cliente",
        Aliases = ["BGOW0068", "BGOW0068-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NR-APOLICE",
        "Número da Apólice",
        Aliases = ["BGOW0068", "BGOW0068-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "COD-PRODUTO",
        "Código do Produto",
        Aliases = ["BGOW0068", "BGOW0068-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "DATA-HORA",
        "Data e hora da emissão do documento [AAAAMMDDhhmmss]",
        Aliases = ["BGOW0068", "BGOW0068-DATA-HORA", "DATA-HORA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0068"])]
    public string? DataHora { get; init; }

}
