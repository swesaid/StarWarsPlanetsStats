namespace StarWarsPlanetsStats.UserInteraction;

public class PlanetStatisticsConsoleUI : IPlanetStatisticsUI
{
    private readonly IUserInteraction _userInteraction;

    public PlanetStatisticsConsoleUI(IUserInteraction userInteraction)
    {
        _userInteraction = userInteraction;
    }

    public string? ChooseStatistics(IEnumerable<string> statisticsProperties)
    {
        _userInteraction.PrintMessage("\nThe statistics of which property would you like to see ?\n");
        _userInteraction.PrintMessage(string.Join(Environment.NewLine, statisticsProperties) + Environment.NewLine);

        return _userInteraction.ReadFromUser();

    }

    public void ShowStatistics(List<Planet> planets, string chosenProperty, Func<Planet, long?> selector)
    {
        var min = planets.MinBy(planet => selector(planet));
        var max = planets.MaxBy(planet => selector(planet));

        _userInteraction.PrintMessage($"Max {chosenProperty} is {selector(max)} (planet: {max.name})");
        _userInteraction.PrintMessage($"Min {chosenProperty} is {selector(min)} (planet: {min.name})");
    }


}