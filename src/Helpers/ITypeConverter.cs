namespace StarWarsPlanetsStats.Helpers;

public interface ITypeConverter
{
    List<Planet> Convert(Root? root);
}

