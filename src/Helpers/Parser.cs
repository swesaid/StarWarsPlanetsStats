namespace StarWarsPlanetsStats.Helpers;

public static class Parser
{
    public static int? FromStringToNullableInt(string value)
    {
        if (!int.TryParse(value, out int result))
            return null;
        return result;
    }

    public static long? FromStringToNullableLong(string value)
    {
        if (!long.TryParse(value, out long result))
            return null;
        return result;
    }
}

