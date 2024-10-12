namespace StarWarsPlanetsStats.UserInteraction;

public interface IPlanetStatisticsUI
{
    string? ChooseStatistics(IEnumerable<string> statisticsProperties);
    void ShowStatistics(List<Planet> planets, string chosenProperty, Func<Planet, long?> selector);

}