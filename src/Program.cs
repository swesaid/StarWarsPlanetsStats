public class Program
{ 
    public static void Main(string[] args)
    {
        IApiDataReader apiDataReader = new ApiDataReader();
        ITypeConverter typeConverter = new TypeConverter();
        StarWarsPlanetsStatsApp App = new StarWarsPlanetsStatsApp(apiDataReader, typeConverter);
        
        App.Run();
    }
    
}
