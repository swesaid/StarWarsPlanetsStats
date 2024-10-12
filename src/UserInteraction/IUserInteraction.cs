
namespace StarWarsPlanetsStats.UserInteraction;

public interface IUserInteraction
{
    void PrintMessage(string message);
    void PrintPlanetsInfoTable(List<Planet> planets);
    void PrintAvailableProperties();
    string? ReadFromUser();
    void ShowStatistics(List<Planet> planets, string chosenProperty, Func<Planet, long?> func);
}
