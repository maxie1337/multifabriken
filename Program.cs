using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection.Metadata;

namespace multifabriken
{
    class Program
    {

        static Kundvagn kundvagn = new Kundvagn();
        static void Main(string[] args)
        {
            
        bool run = true;

        while (run) {
            Console.Clear();
            System.Console.WriteLine("Välkommen till multifabriken! Vad vill du beställa?");
            System.Console.WriteLine("1. Beställ din bil");
            System.Console.WriteLine("2. Beställ godis");
            System.Console.WriteLine("3. Beställ Havremjölk");
            System.Console.WriteLine("4. Beställ rör av olika längd");
            System.Console.WriteLine("5. Se kundvagn");
            System.Console.WriteLine("6. Logga ut");

            Console.Write("Välj ett alternativ: ");
            string val = Console.ReadLine();

            switch(val) {

                case "1":
                OrderCar();
                break;

                case "2":
                OrderCandy();
                break;

                case "3":
                OrderMilk();
                break;

                case "4":
                OrderPipe();
                break;

                case "5":
                kundvagn.ListProducts();
                break;
                
                case "6":
                run = false;
                break; 

                default:
                System.Console.WriteLine("Ogiltigt val, försök igen");
                break;

            }

            if (run) {
                System.Console.WriteLine("Tryck på valfri tangent för att återgå till menyn");
                Console.ReadKey();
            }
        }

        static void OrderCar() {
            Console.Clear();
            System.Console.WriteLine("Fyll i följande uppgifter för att beställa din nya bil:");
            System.Console.WriteLine("1. Registreringsnummer");
            System.Console.WriteLine("2. Färg på bilen");
            System.Console.WriteLine("3. Modell på bilen");
            System.Console.WriteLine("När du har skrivit in dina alternativ, tryck på enter för att spara bilen i kundvagnen!");

            System.Console.Write("Registreringsnummer: ");
            string regNumber = Console.ReadLine();

            System.Console.Write("Färg på bilen: ");
            string carColor = Console.ReadLine();

            System.Console.Write("Modell på bilen: ");
            string carModel = Console.ReadLine();

            
            if (!string.IsNullOrEmpty(regNumber) && 
                !string.IsNullOrEmpty(carColor) && 
                !string.IsNullOrEmpty(carModel))
           {
             Console.WriteLine($"Din bil med Registreringsnummer {regNumber}, färgen {carColor} och modellen {carModel} är nu beställd.");
             Bilar bil = new Bilar(regNumber, carColor, carModel);
             kundvagn.AddProduct(bil);

             Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
             Console.ReadKey(); 
             return;
           } else
           {
             Console.WriteLine("Du har missat att skriva in något av alternativen, kontrollera och försök igen.");
             Console.WriteLine("Tryck på valfri tangent för att beställa igen!");
             Console.ReadKey();
             OrderCar();
           }

            

            

        }

        static void OrderCandy() {

            Console.Clear();
            System.Console.WriteLine("Fyll i följande uppgifter för att beställa ditt godis:");
            System.Console.WriteLine("1. Godissmak");
            System.Console.WriteLine("2. Antal Godisbitar");
            System.Console.WriteLine("När du har skrivit in dina alternativ, tryck på enter för att spara ditt godis till kundvagnen!");

            System.Console.Write("Godissmak: ");
            string candyFlavour = Console.ReadLine();

            System.Console.Write("Antal Godisbitar: ");
            string candyAmount = Console.ReadLine();


            
            if (!string.IsNullOrEmpty(candyFlavour) && 
                int.TryParse(candyAmount, out int amount))
           {
             Console.WriteLine($"Din godisbeställning med smak {candyFlavour} på {candyAmount} bitar är nu beställd");
             Godis godis = new Godis(candyFlavour, candyAmount);
             kundvagn.AddProduct(godis);

             Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
             Console.ReadKey(); 
             return;
           } else
           {
             Console.WriteLine("Du har missat att skriva in något av alternativen, kontrollera och försök igen.");
             Console.WriteLine("Tryck på valfri tangent för att beställa igen!");
             Console.ReadKey();
             OrderCandy();
           }

        }

        static void OrderMilk() {

            Console.Clear();
            System.Console.WriteLine("Fyll i följande uppgifter för att beställa din nya bil:");
            System.Console.WriteLine("1. Registreringsnummer");
            System.Console.WriteLine("2. Färg på bilen");
            System.Console.WriteLine("3. Modell på bilen");
            System.Console.WriteLine("När du har skrivit in dina alternativ, tryck på enter för att spara bilen i kundvagnen!");

            System.Console.Write("Registreringsnummer: ");
            string regNumber = Console.ReadLine();

            System.Console.Write("Färg på bilen: ");
            string carColor = Console.ReadLine();

            System.Console.Write("Modell på bilen: ");
            string carModel = Console.ReadLine();

            
            if (!string.IsNullOrEmpty(regNumber) && 
                !string.IsNullOrEmpty(carColor) && 
                !string.IsNullOrEmpty(carModel))
           {
             Console.WriteLine($"Din bil med Registreringsnummer {regNumber}, färgen {carColor} och modellen {carModel} är nu beställd.");
             Bilar bil = new Bilar(regNumber, carColor, carModel);
             kundvagn.AddProduct(bil);

             Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
             Console.ReadKey(); 
             return;
           } else
           {
             Console.WriteLine("Du har missat att skriva in något av alternativen, kontrollera och försök igen.");
             Console.WriteLine("Tryck på valfri tangent för att beställa igen!");
             Console.ReadKey();
             OrderCar();
           }

        }

        static void OrderPipe () {

            Console.Clear();
            System.Console.WriteLine("Fyll i följande uppgifter för att beställa din nya bil:");
            System.Console.WriteLine("1. Registreringsnummer");
            System.Console.WriteLine("2. Färg på bilen");
            System.Console.WriteLine("3. Modell på bilen");
            System.Console.WriteLine("När du har skrivit in dina alternativ, tryck på enter för att spara bilen i kundvagnen!");

            System.Console.Write("Registreringsnummer: ");
            string regNumber = Console.ReadLine();

            System.Console.Write("Färg på bilen: ");
            string carColor = Console.ReadLine();

            System.Console.Write("Modell på bilen: ");
            string carModel = Console.ReadLine();

            
            if (!string.IsNullOrEmpty(regNumber) && 
                !string.IsNullOrEmpty(carColor) && 
                !string.IsNullOrEmpty(carModel))
           {
             Console.WriteLine($"Din bil med Registreringsnummer {regNumber}, färgen {carColor} och modellen {carModel} är nu beställd.");
             Bilar bil = new Bilar(regNumber, carColor, carModel);
             kundvagn.AddProduct(bil);

             Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
             Console.ReadKey(); 
             return;
           } else
           {
             Console.WriteLine("Du har missat att skriva in något av alternativen, kontrollera och försök igen.");
             Console.WriteLine("Tryck på valfri tangent för att beställa igen!");
             Console.ReadKey();
             OrderCar();
           }

        }

        }
    }

}
