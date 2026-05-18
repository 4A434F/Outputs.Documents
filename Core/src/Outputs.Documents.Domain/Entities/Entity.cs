using Outputs.Documents.Domain.Locations;

namespace Outputs.Documents.Domain.Entities;

[DomainSearch(
    "Entity",
    "Reusable person or organization entity block used for clients, mediators, creditors, and other document parties.",
    Aliases = ["entity", "client", "cliente", "entidade", "DADOS-CLIENTE", "CLIENT-REFERENCE", "TM-ADDRESSEE"],
    Tags = ["common", "entity", "party"])]
public sealed class Entity
{
    [DomainSearch(
        "Entity reference",
        "Source-system reference or number that identifies the entity within the document context.",
        Aliases = ["CLIENT-REFERENCE", "BGOW9068-CLIENT-REFERENCE", "NR-CLIENTE", "BGOW9064-NR-CLIENTE"],
        Tags = ["field", "entity"])]
    public string? Reference { get; init; }

    [DomainSearch(
        "Entity number",
        "Source-system number that identifies the entity in contexts that use number terminology.",
        Aliases = ["Number", "CLIENT-REFERENCE", "BGOW9068-CLIENT-REFERENCE", "NR-CLIENTE", "BGOW9064-NR-CLIENTE"],
        Tags = ["field", "entity"])]
    public string? Number { get; init; }

    [DomainSearch(
        "Name",
        "Entity display name.",
        Aliases = ["CL-NOME", "BGOW9064-CL-NOME", "TM-ADDRESSEE", "BGOW9068-TM-ADDRESSEE"],
        Tags = ["field", "entity"])]
    public string? Name { get; init; }

    [DomainSearch(
        "Tax identification number",
        "Entity fiscal or tax identification number.",
        Aliases = ["CL-NIF", "BGOW9064-CL-NIF", "NIF"],
        Tags = ["field", "entity"])]
    public string? TaxIdentificationNumber { get; init; }

    [DomainSearch(
        "Entity type",
        "Entity type code, such as individual or collective.",
        Aliases = ["CL-TIPO-ENTIDADE", "BGOW9064-CL-TIPO-ENTIDADE"],
        Tags = ["field", "entity"])]
    public string? TypeCode { get; init; }

    [DomainSearch(
        "Entity type",
        "Normalized entity type when the source value is known as person, organization, or unknown.",
        Aliases = ["tipo entidade", "party type", "entity type"],
        Tags = ["field", "entity"])]
    public EntityType Type { get; init; }

    [DomainSearch(
        "Entity address",
        "Postal address associated with the entity when the source copybook sends the party and address together.",
        Aliases = ["DADOS-MORADA", "TM-ADDRESS1", "BGOW9068-TM-ADDRESS1", "MR-MORADA1", "BGOW9064-MR-MORADA1"],
        Tags = ["field", "entity", "address"])]
    public PostalAddress? Address { get; init; }

    [DomainSearch(
        "Entity contact details",
        "Phone, mobile phone, and email contacts associated with the entity.",
        Aliases = ["contactos", "telefone", "telemovel", "email", "AG-TELEFONE", "AG-TELEMOVEL", "AG-EMAIL"],
        Tags = ["field", "entity", "contact"])]
    public ContactDetails? Contact { get; init; }
}
