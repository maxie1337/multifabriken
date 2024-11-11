using System;

namespace multifabriken;

public class Godis {

public string CandyFlavour {get; set;}
public int AmountOfCandy {get; set;}

public Godis (string candyflavour, int amountofcandy) {
    CandyFlavour = candyflavour;
    AmountOfCandy = amountofcandy;
}

    public override string ToString()
    {
        return $"Godis - Godissmak: {CandyFlavour}, Antal Godisbitar: {AmountOfCandy} bitar";
    }

}