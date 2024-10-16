namespace StarWarsPlanetsStats.UserInteraction;

public static class TablePrinter
{
    public static void Print<T>(IReadOnlyList<T> items)
    {
        const int columnWidth = 15;

        var properties = typeof(T).GetProperties();

        var tableString = new StringBuilder();

        foreach (var property in properties)
            tableString.Append($"{property.Name,-columnWidth}|");
        tableString.AppendLine();

        tableString.AppendLine(new string('-', properties.Length * (columnWidth + 1)));

        foreach (var item in items)
        {
            foreach (var property in properties)
            {
                var value = property.GetValue(item);
                tableString.Append($"{value,-columnWidth}|");
            }
            tableString.AppendLine();
        }

        tableString.AppendLine();
        Console.WriteLine(tableString.ToString());
    }

}

