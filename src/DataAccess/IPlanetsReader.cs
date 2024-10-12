namespace StarWarsPlanetsStats.DataAccess;

public interface IPlanetsReader
{
    Task<List<Planet>> Read();

}