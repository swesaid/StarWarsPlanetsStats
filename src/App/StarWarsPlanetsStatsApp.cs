namespace StarWarsPlanetsStats.App;

public class StarWarsPlanetsStatsApp
{
    private readonly IApiDataReader _apiDataReader;
    private readonly ITypeConverter _typeConverter;

    public StarWarsPlanetsStatsApp(IApiDataReader apiDataReader, ITypeConverter typeConverter)
    {
        _apiDataReader = apiDataReader;
        _typeConverter = typeConverter;
    }
    public void Run()
    {
        string baseAddress = "https://swapi.dev/api/";
        string requestUri = "planets";
        var jsonString = _apiDataReader.Read(baseAddress, requestUri).Result;
        
        var apiData = JsonSerializer.Deserialize<Root>(jsonString);

        //Stores the data about planets as List with appropriate types.
        var planets = _typeConverter.Convert(ref apiData!);

        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
    }
}

