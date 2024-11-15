using System;

namespace multifabriken;

public class Rör
{
public double Diameter { get; set;}
public double Längd { get; set;}

public Rör(double diameter, double längd)
{
    Diameter = diameter;
    Längd = längd;
}

    public override string ToString()
    {
        return $"Diameter: {Diameter} cm, Längd: {Längd} cm";
    }
}