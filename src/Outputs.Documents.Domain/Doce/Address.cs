namespace Outputs.Documents.Domain.Doce;

public class Address
{
    public string? Name { get; set; }
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? AddressLine4 { get; set; }

    public Address()
    {
    }

    public Address(string? name, string? line1, string? line2 = null, string? line3 = null, string? line4 = null)
    {
        Name = name;
        AddressLine1 = line1;
        AddressLine2 = line2;
        AddressLine3 = line3;
        AddressLine4 = line4;
    }

    public IEnumerable<string> GetLines()
    {
        if (!string.IsNullOrWhiteSpace(Name)) yield return Name;
        if (!string.IsNullOrWhiteSpace(AddressLine1)) yield return AddressLine1;
        if (!string.IsNullOrWhiteSpace(AddressLine2)) yield return AddressLine2;
        if (!string.IsNullOrWhiteSpace(AddressLine3)) yield return AddressLine3;
        if (!string.IsNullOrWhiteSpace(AddressLine4)) yield return AddressLine4;
    }
}
