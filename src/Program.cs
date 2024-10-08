public class Program
{ 
    public static void Main(string[] args)
    {
        IApiDataReader apiDataReader = new ApiDataReader();
        StarWarsPlanetsStatsApp App = new StarWarsPlanetsStatsApp(apiDataReader);
        
        App.Run();
    }
    
}
