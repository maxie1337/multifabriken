using System;

namespace multifabriken;

public class Godis {

public string candyFlavour {get; set;}
public int amountOfCandy {get; set;}

public Godis (string candyflavour, int amountofcandy) {
    candyFlavour = candyflavour;
    amountOfCandy = amountofcandy;
}

    public override string ToString()
    {
        return $"Godis - Godissmak: {candyFlavour}, Antal Godisbitar: {amountOfCandy}";
    }

}