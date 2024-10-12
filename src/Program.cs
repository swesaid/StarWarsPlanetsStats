public class Program
{ 
    public static void Main(string[] args)
    {
        IUserInteraction userInteraction = new ConsoleUserInteraction();
        IApiDataReader apiDataReader = new ApiDataReader();
        ITypeConverter typeConverter = new TypeConverter();
        IPlanetStatisticsUI planetStatisticsUI = new PlanetStatisticsConsoleUI(userInteraction);
        IPlanetStatisticsAnalyzer planetStatisticsAnalyzer = new PlanetStatisticsAnalyzer(userInteraction, planetStatisticsUI);

        StarWarsPlanetsStatsApp App = new StarWarsPlanetsStatsApp(apiDataReader, typeConverter, userInteraction, planetStatisticsAnalyzer);
        
        App.Run();
    }
    
}
