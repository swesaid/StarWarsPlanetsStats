namespace StarWarsPlanetsStats.Helpers;

public interface ITypeConverter
{
    IReadOnlyList<Planet> Convert(Root? root);
}

