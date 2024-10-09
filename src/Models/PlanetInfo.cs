namespace StarWarsPlanetsStats.Models;

public record PlanetInfo
{ 
    public string Name { get; set; }
    public int Diameter { get; init; } 
    public int? SurfaceWater { get; init; }
    public decimal? Population { get; init; }

    public PlanetInfo(string name, int diameter, int? surfaceWater, decimal? population)
    {
        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }
}

