namespace StarWarsPlanetsStats.UserInteraction;

public class ConsoleUserInteraction : IUserInteraction
{
    public string? ReadFromUser()
    {
        return Console.ReadLine();
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}

