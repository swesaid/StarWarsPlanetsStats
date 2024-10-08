namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader)
    {
        _apiDataReader = apiDataReader;
    }
    public void Run()
    {
        string baseAddress = "https://swapi.dev/api/";
        string requestUri = "planets";
        var json = _apiDataReader.Read(baseAddress, requestUri).Result;

        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}

