namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;
    private readonly ITypeConverter _typeConverter;
    private readonly IUserInteraction _userInteraction;
    private readonly IPlanetStatisticsAnalyzer _planetStatisticsAnalyzer;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader, ITypeConverter typeConverter, IUserInteraction userInteraction, IPlanetStatisticsAnalyzer planetStatisticsAnalyzer)
    {
        _apiDataReader = apiDataReader;
        _typeConverter = typeConverter;
        _userInteraction = userInteraction;
        _planetStatisticsAnalyzer = planetStatisticsAnalyzer;
    }

    public void Run()
    {
        string baseAddress = "https://swapi.dev/api/";
        string requestUri = "planets";
        var jsonString = _apiDataReader.Read(baseAddress, requestUri).Result;
        
        var apiData = JsonSerializer.Deserialize<Root>(jsonString);

        //Stores the data about planets as List with appropriate types.
        var planets = _typeConverter.Convert(ref apiData!);

        _userInteraction.PrintPlanetsInfoTable(planets);
        _planetStatisticsAnalyzer.Analyze(planets);

        _userInteraction.PrintMessage("\nPress any key to close.");
        Console.ReadKey();
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
        string separator = new string('-', header.Length);
        
        PrintMessage(header);
        PrintMessage(separator);

        foreach (Planet planet in planets) 
        { 
            PrintMessage(planet.ToString());
        }
    }
}
