namespace StarWarsPlanetsStats.Helpers;

public interface ITypeConverter
{
    List<Planet> Convert(ref Root root);
}

