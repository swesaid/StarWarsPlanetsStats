namespace StarWarsPlanetsStats.Services;

public class PlanetStatisticsAnalyzer : IPlanetStatisticsAnalyzer
{
    private readonly IUserInteraction _userInteraction;
    private readonly IPlanetStatisticsUI _planetStatisticsUI;


    private readonly Dictionary<string, Func<Planet, long?>> statisticsSelectors = new()
    {
        ["population"] = planet => planet.Population,
        ["diameter"] = planet => planet.Diameter,
        ["surface water"] = planet => planet.SurfaceWater,
    };

    public PlanetStatisticsAnalyzer(IUserInteraction userInteraction, IPlanetStatisticsUI planetStatisticsUI)
    {
        _userInteraction = userInteraction;
        _planetStatisticsUI = planetStatisticsUI;
    }

    public void Analyze(IReadOnlyList<Planet> planets)
    {
        string? chosenProperty = _planetStatisticsUI.ChooseStatistics(statisticsSelectors.Keys);

        if (chosenProperty is null || !statisticsSelectors.ContainsKey(chosenProperty))
            _userInteraction.PrintMessage("Invalid choice.");
        else
            _planetStatisticsUI.ShowStatistics(planets, chosenProperty, statisticsSelectors[chosenProperty]);

    }
}
