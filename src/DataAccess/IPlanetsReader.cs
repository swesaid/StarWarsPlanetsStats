namespace StarWarsPlanetsStats.DataAccess;

public interface IPlanetsReader
{
    Task<IReadOnlyList<Planet>> Read();

}