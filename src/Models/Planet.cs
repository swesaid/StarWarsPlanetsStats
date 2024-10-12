namespace StarWarsPlanetsStats.Models;

public readonly record struct Planet
{ 
    public string Name { get; init; }
    public int ?Diameter { get; init; } 
    public int? SurfaceWater { get; init; }
    public long? Population { get; init; }

    public Planet(string name, int diameter, int? surfaceWater, long? population)
    {
        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }

    public override string ToString() => $"{Name,-25} | {Diameter,-15} | {SurfaceWater,-20} | {Population,-15} |";

    public static explicit operator Planet(Result input)
    {
        int diameter = int.Parse(input.diameter);
        int? surfaceWater = input.surface_water.ToIntOrNull();
        long? population = input.population.ToLongOrNull();

        return new Planet(input.name, diameter, surfaceWater, population) ;
    }

}

