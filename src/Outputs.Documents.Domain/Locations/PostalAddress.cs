namespace Outputs.Documents.Domain.Locations;

[DomainSearch(
    "Postal address",
    "Reusable postal address block with recipient name, address lines, locality, postal code, country, and door information.",
    Aliases = ["morada", "address", "postal address", "localidade", "codigo postal", "DADOS-MORADA", "MR-NOME", "MR-MORADA1", "TM-ADDRESSEE", "TM-ADDRESS1"],
    Tags = ["common", "location", "address"])]
public sealed class PostalAddress
{
    public PostalAddress()
    {
    }

    public PostalAddress(
        string? name,
        string? line1,
        string? line2 = null,
        string? line3 = null,
        string? line4 = null)
    {
        Name = name;
        Line1 = line1;
        Line2 = line2;
        Line3 = line3;
        Line4 = line4;
    }

    [DomainSearch(
        "Recipient name",
        "Recipient or address name.",
        Aliases = ["MR-NOME", "BGOW9064-MR-NOME", "TM-ADDRESSEE", "BGOW9068-TM-ADDRESSEE"],
        Tags = ["field", "address"])]
    public string? Name { get; set; }

    [DomainSearch(
        "Address reference",
        "Address location reference from the source system.",
        Aliases = ["MR-LOCATION-REF", "BGOW9064-MR-LOCATION-REF", "LOCATION-REF"],
        Tags = ["field", "address"])]
    public string? Reference { get; set; }

    [DomainSearch(
        "Address line 1",
        "First address line.",
        Aliases = ["MR-MORADA1", "BGOW9064-MR-MORADA1", "TM-ADDRESS1", "BGOW9068-TM-ADDRESS1"],
        Tags = ["field", "address"])]
    public string? Line1 { get; set; }

    [DomainSearch(
        "Address line 2",
        "Second address line.",
        Aliases = ["MR-MORADA2", "BGOW9064-MR-MORADA2", "TM-ADDRESS2", "BGOW9068-TM-ADDRESS2"],
        Tags = ["field", "address"])]
    public string? Line2 { get; set; }

    [DomainSearch(
        "Address line 3",
        "Third display address line used by template-facing address blocks.",
        Aliases = ["AddressLine3", "TM-ADDRESS3", "BGOW9068-TM-ADDRESS3"],
        Tags = ["field", "address"])]
    public string? Line3 { get; set; }

    [DomainSearch(
        "Address line 4",
        "Fourth display address line used by template-facing address blocks.",
        Aliases = ["AddressLine4", "TM-ADDRESS4", "BGOW9068-TM-ADDRESS4"],
        Tags = ["field", "address"])]
    public string? Line4 { get; set; }

    [DomainSearch(
        "Locality",
        "Address locality.",
        Aliases = ["MR-LOCALIDADE", "BGOW9064-MR-LOCALIDADE", "TM-ADDRESS3", "BGOW9068-TM-ADDRESS3"],
        Tags = ["field", "address"])]
    public string? Locality { get; set; }

    [DomainSearch(
        "Postal code",
        "Address postal code.",
        Aliases = ["MR-CPOSTAL", "BGOW9064-MR-CPOSTAL", "POST-CODE", "BGOW9068-POST-CODE", "AG-POST-CODE", "BGOW9068-AG-POST-CODE"],
        Tags = ["field", "address"])]
    public string? PostalCode { get; set; }

    [DomainSearch(
        "Postal code description",
        "Address postal-code description.",
        Aliases = ["MR-CPOSTAL-DESC", "BGOW9064-MR-CPOSTAL-DESC", "TM-ADDRESS4", "BGOW9068-TM-ADDRESS4"],
        Tags = ["field", "address"])]
    public string? PostalCodeDescription { get; set; }

    [DomainSearch(
        "Country code",
        "Address country code.",
        Aliases = ["MR-CPAIS", "BGOW9064-MR-CPAIS"],
        Tags = ["field", "address"])]
    public string? CountryCode { get; set; }

    [DomainSearch(
        "Country description",
        "Address country description.",
        Aliases = ["MR-CPAIS-DESC", "BGOW9064-MR-CPAIS-DESC"],
        Tags = ["field", "address"])]
    public string? CountryDescription { get; set; }

    [DomainSearch(
        "Door identifier",
        "Door identifier in the postal/address system.",
        Aliases = ["MR-IDP", "BGOW9064-MR-IDP", "TM-NUM-PORTA", "BGOW9068-TM-NUM-PORTA"],
        Tags = ["field", "address"])]
    public string? DoorIdentifier { get; set; }

    [DomainSearch(
        "Door type code",
        "Door type or source-system door identifier category used with the door identifier.",
        Aliases = ["TM-TNUM-PORTA", "BGOW9068-TM-TNUM-PORTA"],
        Tags = ["field", "address", "copybook:BGOW9068"])]
    public string? DoorTypeCode { get; set; }

    public IEnumerable<string> GetLines()
    {
        if (!string.IsNullOrWhiteSpace(Name)) yield return Name;
        if (!string.IsNullOrWhiteSpace(Line1)) yield return Line1;
        if (!string.IsNullOrWhiteSpace(Line2)) yield return Line2;
        if (!string.IsNullOrWhiteSpace(Line3)) yield return Line3;
        if (!string.IsNullOrWhiteSpace(Line4)) yield return Line4;
        if (!string.IsNullOrWhiteSpace(Locality)) yield return Locality;
        if (!string.IsNullOrWhiteSpace(PostalCodeDescription)) yield return PostalCodeDescription;
    }
}
