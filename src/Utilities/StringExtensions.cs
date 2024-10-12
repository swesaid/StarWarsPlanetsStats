namespace StarWarsPlanetsStats.Utilities;

public static class StringExtensions
{
    public static int? ToIntOrNull(this string? value)
    {
        return int.TryParse(value, out var result) ? result : null;
    }

    public static long? ToLongOrNull(this string? value)
    {
        return long.TryParse(value, out var result) ? result : null;
    }


}
