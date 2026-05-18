using System.Globalization;

namespace Outputs.Documents.Components.Formatting;

public static class DocumentFormatExtensions
{
    private static readonly CultureInfo Portuguese = CultureInfo.GetCultureInfo("pt-PT");

    public static string ToPortugueseMoney(this decimal value)
    {
        return value.ToString("N2", Portuguese);
    }

    public static string ToPortugueseMoney(this decimal? value, string emptyValue = "____")
    {
        return value?.ToPortugueseMoney() ?? emptyValue;
    }

    public static string ToPortugueseShortDate(this DateOnly value)
    {
        return value.ToString("dd-MMM-yyyy", Portuguese).ToLowerInvariant();
    }

    public static string ToPortugueseShortDate(this DateOnly? value, string emptyValue = "____")
    {
        return value?.ToPortugueseShortDate() ?? emptyValue;
    }

    public static string ToPortugueseLetterDate(this DateTime value, string location = "Lisboa")
    {
        return $"{location}, {value.Day} de {value.ToString("MMMM", Portuguese)} de {value.Year}";
    }
}
