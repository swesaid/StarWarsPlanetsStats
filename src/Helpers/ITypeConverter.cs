namespace StarWarsPlanetsStats.Helpers;

public interface ITypeConverter
{
    List<PlanetInfo> Convert(ref Root root);
}

