namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;
    private readonly ITypeConverter _typeConverter;
    private readonly IUserInteraction _userInteraction;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader, ITypeConverter typeConverter, IUserInteraction userInteraction)
    {
        _apiDataReader = apiDataReader;
        _typeConverter = typeConverter;
        _userInteraction = userInteraction;
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
        _userInteraction.PrintAvailableProperties();

        _userInteraction.PrintMessage("\nPress any key to close.");
        Console.ReadKey();
    }
}

public class ConsoleUserInteraction : IUserInteraction
{
    public void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintPlanetsInfoTable(List<PlanetInfo> planets)
    {
        string header = $"{"Name",-25} | {"Diameter",-15} | {"SurfaceWater",-20} | {"Population",-15} |";
        string separator = new string('-', header.Length);
        
        PrintMessage(header);
        PrintMessage(separator);

        foreach (PlanetInfo planet in planets) 
        { 
            PrintMessage(planet.ToString());
        }
    }

    public void PrintAvailableProperties()
    {
        PrintMessage("\nThe statistics of which property would you like to see ?\n");
        
        Type type = typeof(PlanetInfo);
        var properties = type.GetProperties().Where(property => property.Name != "EqualityContract");

        foreach (var property in properties) 
            PrintMessage(property.Name);
    }
}


