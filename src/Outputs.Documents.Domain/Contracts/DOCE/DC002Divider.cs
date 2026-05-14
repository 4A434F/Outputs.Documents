
namespace Outputs.Documents.Domain.Contracts.DOCE;

[DomainSearch(
    "DC002 Divider",
    "DOCE divider contract used to separate document batches or sections with a label.",
    Aliases = ["divider", "separator", "separador"],
    Tags = ["contract", "doce", "DC002", "divider"])]
public record DC002Divider(string Label) : IDocumentModel;
