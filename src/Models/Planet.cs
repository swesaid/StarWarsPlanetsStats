﻿namespace StarWarsPlanetsStats.Models;

public readonly record struct Planet
{ 
    public string Name { get; }
    public int? Diameter { get; } 
    public int? SurfaceWater { get; }
    public long? Population { get; }

    public Planet(string name, int diameter, int? surfaceWater, long? population)
    {
        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }


    public static explicit operator Planet(Result input)
    {
        int diameter = int.Parse(input.diameter);
        int? surfaceWater = input.surface_water.ToIntOrNull();
        long? population = input.population.ToLongOrNull();

        return new Planet(input.name, diameter, surfaceWater, population) ;
    }

}

