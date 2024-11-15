using System;

namespace multifabriken;

public class Godis {

public string CandyFlavour {get; set;}
public string AmountOfCandy {get; set;}

public Godis (string candyflavour, string amountofcandy) {
    CandyFlavour = candyflavour;
    AmountOfCandy = amountofcandy;
}

    public override string ToString()
    {
        return $"Godis - Godissmak: {CandyFlavour}, Antal Godisbitar: {AmountOfCandy} bitar";
    }

}