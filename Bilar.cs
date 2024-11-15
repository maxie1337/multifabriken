using System;
using System.Dynamic;

namespace multifabriken;

public class Bilar
{
public string RegNumber {get; set;}
public string CarColour {get; set;}

public string CarModel {get; set;}

public Bilar (string regnumber, string carcolour, string carmodel) {
    RegNumber = regnumber;
    CarColour = carcolour;
    CarModel = carmodel;
}

    public override string ToString()
    {
        return $"Registreringsnummer: {RegNumber}, Färg: {CarColour}, Bilmärke: {CarModel}";
    }

}