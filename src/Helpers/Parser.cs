namespace StarWarsPlanetsStats.Helpers;

public static class Parser
{
    public static int? FromStringToNullableInt(string value)
    {
        if (!int.TryParse(value, out int result))
            return null;
        return result;
    }

    public static decimal? FromStringToNullableDecimal(string value)
    {
        if (!decimal.TryParse(value, out decimal result))
            return null;
        return result;
    }
}

