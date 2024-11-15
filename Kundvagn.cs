using System;
using System.Collections.Generic;

namespace multifabriken;
public class Kundvagn
{
    private List<Bilar> bilarLista = new List<Bilar>();
    private List<Godis> godisLista = new List<Godis>();
    private List<Rör> rörLista = new List<Rör>();
    private List<Havremjölk> havremjölkLista = new List<Havremjölk>();

    // Lägg till bil
    public void AddBil(Bilar bil)
    {
        bilarLista.Add(bil);
        Console.WriteLine("Bilen har lagts till i kundvagnen.");
    }

    // Lägg till godis
    public void AddGodis(Godis godis)
    {
        godisLista.Add(godis);
        Console.WriteLine("Godiset har lagts till i kundvagnen.");
    }

    // Lägg till rör
    public void AddRör(Rör rör)
    {
        rörLista.Add(rör);
        Console.WriteLine("Röret har lagts till i kundvagnen.");
    }

    // Lägg till havremjölk
    public void AddHavremjölk(Havremjölk havremjölk)
    {
        havremjölkLista.Add(havremjölk);
        Console.WriteLine("Havremjölken har lagts till i kundvagnen.");
    }

    // Visa alla produkter i kundvagnen
    public void ListProducts()
    {
        Console.Clear();
        Console.WriteLine("Produkter i kundvagnen:");

        Console.WriteLine("\nBilar:");
        foreach (var bil in bilarLista)
        {
            Console.WriteLine(bil);
        }

        Console.WriteLine("\nGodis:");
        foreach (var godis in godisLista)
        {
            Console.WriteLine(godis);
        }

        Console.WriteLine("\nRör:");
        foreach (var rör in rörLista)
        {
            Console.WriteLine(rör);
        }

        Console.WriteLine("\nHavremjölk:");
        foreach (var havremjölk in havremjölkLista)
        {
            Console.WriteLine(havremjölk);
        }

        Console.WriteLine("\nTryck på valfri tangent för att återgå till menyn...");
        Console.ReadKey();
    }
}
