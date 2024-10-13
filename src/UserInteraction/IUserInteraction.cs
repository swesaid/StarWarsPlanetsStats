namespace StarWarsPlanetsStats.UserInteraction;

public interface IUserInteraction
{
    void PrintMessage(string message);
    string? ReadFromUser();
}
