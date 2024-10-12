namespace StarWarsPlanetsStats.Helpers;

public class TypeConverter : ITypeConverter
{
    public List<Planet> Convert(Root? root)
    {
        ArgumentNullException.ThrowIfNull(root);

        return root.results.Select(rootObj => (Planet)rootObj).ToList();
    }
}

//var result = new List<Planet>();

//foreach (var planet in root.results)
//{
//    int diameter = int.Parse(planet.diameter);
//    int? surfaceWater = planet.surface_water.ToIntOrNull();
//    long? population = planet.population.ToLongOrNull();

//    var newPlanet = new Planet(planet!.name, diameter, surfaceWater, population);

//    result.Add(newPlanet);
//}

//return result;

