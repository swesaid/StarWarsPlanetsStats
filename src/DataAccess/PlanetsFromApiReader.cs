namespace StarWarsPlanetsStats.DataAccess;

public class PlanetsFromApiReader : IPlanetsReader
{
    private readonly IApiDataReader _apiDataReader;
    private readonly IApiDataReader _secondaryApiDataReader;
    private readonly IUserInteraction _userInteraction;
    private readonly ITypeConverter _typeConverter;

    public PlanetsFromApiReader(IApiDataReader apiDataReader, IApiDataReader secondaryApiDataReader, IUserInteraction userInteraction, ITypeConverter typeConverter)
    {
        _apiDataReader = apiDataReader;
        _secondaryApiDataReader = secondaryApiDataReader;
        _userInteraction = userInteraction;
        _typeConverter = typeConverter;
    }

    public async Task<List<Planet>> Read()
    {
        string? jsonString = null;
        string baseAddress = "https://swapi.dev/api/";
        string requestUri = "planets";

        try
        {
            jsonString = await _apiDataReader.Read(baseAddress, requestUri);
        }
        catch (HttpRequestException ex)
        {
            _userInteraction.PrintMessage("API request was unsuccessful." +
                                          "Switching to mock data." +
                                          "Exception: " + ex.Message);
        }

        jsonString ??= await _secondaryApiDataReader.Read(baseAddress, requestUri);
        var apiData = JsonSerializer.Deserialize<Root>(jsonString);

        return _typeConverter.Convert(apiData);
    }


}
