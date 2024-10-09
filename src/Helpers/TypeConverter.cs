namespace StarWarsPlanetsStats.Helpers;

public class TypeConverter : ITypeConverter
{
    public List<PlanetInfo> Convert(ref Root root)
    {
        List<PlanetInfo> result = new List<PlanetInfo>();

        foreach (var planet in root.results)
        {
            int diameter = int.Parse(planet.diameter);
            int? surfaceWater = Parser.FromStringToNullableInt(planet?.surface_water!);
            decimal? population = Parser.FromStringToNullableDecimal(planet?.population!);
            var planetInfo = new PlanetInfo(planet!.name, diameter, surfaceWater, population);

            result.Add(planetInfo);
        }

        return result;
    }
}

