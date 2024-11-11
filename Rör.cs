using System;

namespace multifabriken;

public class Rör
{
  public double Diameter { get; }
        public double Längd { get; }

        public Rör(double diameter, double längd)
        {
            Diameter = diameter;
            Längd = längd;
        }

        public override string ToString()
        {
            return $"Rör - Diameter: {Diameter} cm, Längd: {Längd} cm";
        }
}