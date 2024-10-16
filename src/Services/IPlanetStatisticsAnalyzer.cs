namespace StarWarsPlanetsStats.Services;

public interface IPlanetStatisticsAnalyzer
{
    void Analyze(IReadOnlyList<Planet> planets);
}
