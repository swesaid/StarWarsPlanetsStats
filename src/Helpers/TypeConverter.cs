namespace StarWarsPlanetsStats.Helpers;

public class TypeConverter : ITypeConverter
{
    public List<Planet> Convert(ref Root root)
    {
        List<Planet> result = new List<Planet>();

        foreach (var planet in root.results)
        {
            int diameter = int.Parse(planet.diameter);
            int? surfaceWater = Parser.FromStringToNullableInt(planet?.surface_water!);
            long? population = Parser.FromStringToNullableLong(planet?.population!);
            var planetInfo = new Planet(planet!.name, diameter, surfaceWater, population);

            result.Add(planetInfo);
        }

        return result;
    }
}

