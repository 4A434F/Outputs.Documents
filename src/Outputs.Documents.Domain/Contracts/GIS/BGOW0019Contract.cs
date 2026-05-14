namespace Outputs.Documents.Domain.Contracts.GIS;

[DomainSearch(
    "BGOW0019 contract",
    "GIS BGOW0019 copybook contract.",
    Aliases = ["BGOW0019"],
    Tags = ["contract", "origin:GIS", "copybook:BGOW0019"])]
public sealed class BGOW0019Contract : IDocumentModel
{
    public const string OriginSystem = "GIS";

    public const string CopybookId = "BGOW0019";

    [DomainSearch(
        "COD-COMPANHIA",
        "Código de identificação da Companhia (deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-COD-COMPANHIA", "COD-COMPANHIA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? CodCompanhia { get; init; }

    [DomainSearch(
        "COD-MARCA",
        "Código de identificação da Marca(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-COD-MARCA", "COD-MARCA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? CodMarca { get; init; }

    [DomainSearch(
        "COD-ORIGEM",
        "Código de identificação do Sistema Origem(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-COD-ORIGEM", "COD-ORIGEM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? CodOrigem { get; init; }

    [DomainSearch(
        "COD-POSTALM",
        "Código Postal do Mediador -este campo só deve vir preenchido se o documento for passivel de ser entregue ao mediador.(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-COD-POSTALM", "COD-POSTALM"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? CodPostalm { get; init; }

    [DomainSearch(
        "NR-MEDIADOR",
        "Número do Mediador -este campo só deve vir preenchido se o documento for passivel de ser entregue ao mediador.(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-NR-MEDIADOR", "NR-MEDIADOR"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? NrMediador { get; init; }

    [DomainSearch(
        "COD-POSTALC",
        "Código Postal do Cliente -este campo deve ser preenchido com o valor do codigo postal da entidade a quem o documento vai endereçado.(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-COD-POSTALC", "COD-POSTALC"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? CodPostalc { get; init; }

    [DomainSearch(
        "NR-CLIENTE",
        "Número do Cliente -este campo deve ser preenchido com o valor do numero da entidade a quem o documento vai endereçado.(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-NR-CLIENTE", "NR-CLIENTE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? NrCliente { get; init; }

    [DomainSearch(
        "NR-APOLICE",
        "Número da Apólice ATENÇÃO: Quando o documento refere mais do que uma apólice o campo NR-APOLICE deve vir do SO preenchido a espaços. Nos casos das propostas (quando ainda não existe numero de apólice) o campo deve vir a todo a espaços - o ramo e a apólice (deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-NR-APOLICE", "NR-APOLICE"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? NrApolice { get; init; }

    [DomainSearch(
        "COD-PRODUTO",
        "Código de Produto(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-COD-PRODUTO", "COD-PRODUTO"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? CodProduto { get; init; }

    [DomainSearch(
        "DATA-HORA",
        "Data e Hora de emissão do documento(deve ser repetido em todas as linhas do documento)",
        Aliases = ["BGOW0019", "BGOW0019-DATA-HORA", "DATA-HORA"],
        Tags = ["field", "origin:GIS", "copybook:BGOW0019"])]
    public string? DataHora { get; init; }

}
