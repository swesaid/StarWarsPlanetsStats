namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatsApp
{
    private readonly IUserInteraction _userInteraction;
    private readonly IPlanetStatisticsAnalyzer _planetStatisticsAnalyzer;
    private readonly IPlanetsReader _planetsReader;
    private readonly IPlanetStatisticsUI _planetStatisticsUI;

    public StarWarsPlanetsStatsApp(IUserInteraction userInteraction, IPlanetStatisticsAnalyzer planetStatisticsAnalyzer, IPlanetsReader planetsReader, IPlanetStatisticsUI planetStatisticsUI)
    {
        _userInteraction = userInteraction;
        _planetStatisticsAnalyzer = planetStatisticsAnalyzer;
        _planetsReader = planetsReader;
        _planetStatisticsUI = planetStatisticsUI;
    }

    public async Task Run()
    {
        var planets = await _planetsReader.Read();

        _planetStatisticsUI.ShowPlanets(planets);
        _planetStatisticsAnalyzer.Analyze(planets);
    }
}