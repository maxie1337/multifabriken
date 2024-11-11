using System;
using System.Dynamic;

namespace multifabriken;

public class Bilar
{
public string regNumber {get; set;}
public string carColour {get; set;}

public string carModel {get; set;}

public Bilar (string regnumber, string carcolour, string carmodel) {
    regNumber = regnumber;
    carColour = carcolour;
    carModel = carmodel;
}

    public override string ToString()
    {
        return $"Bil - Registreringsnummber: {regNumber}, Färg: {carColour}, Bilmärke: {carModel}";
    }

}