using System;
using System.ComponentModel.DataAnnotations;

namespace multifabriken;

public class Havremjölk
{
public double Fetthalt {get; set;}
public double Litermängd {get; set;}

public Havremjölk (double fetthalt, double litermängd) {
    Fetthalt = fetthalt;
    Litermängd = litermängd;
}

    public override string ToString()
    {
        return $"Havremjölk - Fetthalt: {Fetthalt}%, Litermängd: {Litermängd} L";
    }
}