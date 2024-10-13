namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatsApp
{
    private readonly IUserInteraction _userInteraction;
    private readonly IPlanetStatisticsAnalyzer _planetStatisticsAnalyzer;
    private readonly IPlanetsReader _planetsReader;

    public StarWarsPlanetsStatsApp(IUserInteraction userInteraction, IPlanetStatisticsAnalyzer planetStatisticsAnalyzer, IPlanetsReader planetsReader)
    {
        _userInteraction = userInteraction;
        _planetStatisticsAnalyzer = planetStatisticsAnalyzer;
        _planetsReader = planetsReader;
    }

    public async Task Run()
    {
        var planets = await _planetsReader.Read();

        _userInteraction.PrintPlanetsInfoTable(planets);
        _planetStatisticsAnalyzer.Analyze(planets);
    }
}


public class ConsoleUserInteraction : IUserInteraction
{
    public string? ReadFromUser()
    {
        return Console.ReadLine();
    }

    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintPlanetsInfoTable(List<Planet> planets)
    {
        string header = $"{"Name",-25} | {"Diameter",-15} | {"SurfaceWater",-20} | {"Population",-15} |";
        string separator = new ('-', header.Length);
        
        PrintMessage(header);
        PrintMessage(separator);

        foreach (Planet planet in planets) 
        { 
            PrintMessage(planet.ToString());
        }
    }
}
