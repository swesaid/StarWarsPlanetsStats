namespace StarWarsPlanetsStats.Services;

public class PlanetStatisticsAnalyzer : IPlanetStatisticsAnalyzer
{
    private readonly IUserInteraction _userInteraction;
    private readonly IPlanetStatisticsUI _planetStatisticsUI;


    private readonly Dictionary<string, Func<Planet, long?>> statisticsSelectors = new()
    {
        ["population"] = planet => planet.population,
        ["diameter"] = planet => planet.diameter,
        ["surfacewater"] = planet => planet.surfacewater,
    };

    public PlanetStatisticsAnalyzer(IUserInteraction userInteraction, IPlanetStatisticsUI planetStatisticsUI)
    {
        _userInteraction = userInteraction;
        _planetStatisticsUI = planetStatisticsUI;
    }

    public void Analyze(List<Planet> planets)
    {
        string? chosenProperty = _planetStatisticsUI.ChooseStatistics(statisticsSelectors.Keys);

        if (chosenProperty is null || !statisticsSelectors.ContainsKey(chosenProperty))
            _userInteraction.PrintMessage("Invalid choice.");
        else
            _planetStatisticsUI.ShowStatistics(planets, chosenProperty, statisticsSelectors[chosenProperty]);

    }
}
