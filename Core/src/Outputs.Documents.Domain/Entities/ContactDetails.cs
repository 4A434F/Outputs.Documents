namespace Outputs.Documents.Domain.Entities;

[DomainSearch(
    "Contact details",
    "Reusable contact block for phone, mobile phone, and e-mail values.",
    Aliases = ["contactos", "telefone", "telemovel", "email"],
    Tags = ["common", "entity", "contact"])]
public sealed class ContactDetails
{
    public string? PhoneNumber { get; init; }

    public string? MobileNumber { get; init; }

    public string? Email { get; init; }
}
