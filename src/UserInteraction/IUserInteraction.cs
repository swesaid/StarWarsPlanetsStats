namespace StarWarsPlanetsStats.UserInteraction;

public interface IUserInteraction
{
    void PrintMessage(string message);
    void PrintPlanetsInfoTable(List<Planet> planets);
    string? ReadFromUser();
}
