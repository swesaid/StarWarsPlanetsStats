public class Program
{ 
    public static void Main(string[] args)
    {
        IUserInteraction userInteraction = new ConsoleUserInteraction();
        IApiDataReader apiDataReader = new ApiDataReader();
        ITypeConverter typeConverter = new TypeConverter();
        StarWarsPlanetsStatsApp App = new StarWarsPlanetsStatsApp(apiDataReader, typeConverter, userInteraction);
        
        App.Run();
    }
    
}
