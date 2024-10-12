﻿public class Program
{ 
    public async static Task Main(string[] args)
    {
        try
        {
            IUserInteraction userInteraction = new ConsoleUserInteraction();
            IApiDataReader apiDataReader = new ApiDataReader();
            IApiDataReader secondaryApiDataReader = new MockStarWarsApiDataReader();
            ITypeConverter typeConverter = new TypeConverter();
            IPlanetStatisticsUI planetStatisticsUI = new PlanetStatisticsConsoleUI(userInteraction);
            IPlanetStatisticsAnalyzer planetStatisticsAnalyzer = new PlanetStatisticsAnalyzer(userInteraction, planetStatisticsUI);
            IPlanetsReader planetsReader = new PlanetsFromApiReader(apiDataReader, secondaryApiDataReader, userInteraction, typeConverter);

            StarWarsPlanetsStatsApp App =  new StarWarsPlanetsStatsApp(userInteraction, planetStatisticsAnalyzer, planetsReader);
        
            await App.Run();

        }
        catch(Exception ex)
        {
            Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed." +
                              "Exception message: " + ex.Message);
        }
    }
    
}
