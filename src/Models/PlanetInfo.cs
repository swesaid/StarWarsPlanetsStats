namespace StarWarsPlanetsStats.Models;

public record PlanetInfo
{ 
    public string name { get; init; }
    public int ?diameter { get; init; } 
    public int? surfacewater { get; init; }
    public long? population { get; init; }

    public PlanetInfo(string name, int diameter, int? surfaceWater, long? population)
    {
        this.name = name;
        this.diameter = diameter;
        surfacewater = surfaceWater;
        this.population = population;
    }

    public override string ToString() => $"{name,-25} | {diameter,-15} | {surfacewater,-20} | {population,-15} |";

}

