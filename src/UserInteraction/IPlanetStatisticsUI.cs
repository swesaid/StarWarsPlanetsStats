namespace StarWarsPlanetsStats.UserInteraction;

public interface IPlanetStatisticsUI
{
    string? ChooseStatistics(IEnumerable<string> statisticsProperties);
    void ShowStatistics(IReadOnlyList<Planet> planets, string chosenProperty, Func<Planet, long?> selector);
    void ShowPlanets(IReadOnlyList<Planet> planets);


}