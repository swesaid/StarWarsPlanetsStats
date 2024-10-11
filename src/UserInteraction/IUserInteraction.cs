
namespace StarWarsPlanetsStats.UserInteraction;

public interface IUserInteraction
{
    void PrintMessage(string message);
    void PrintPlanetsInfoTable(List<PlanetInfo> planets);
    void PrintAvailableProperties();
    string? ReadFromUser();
    void ShowStatistics(List<PlanetInfo> planets, string chosenProperty, Func<PlanetInfo, long?> func);
}
