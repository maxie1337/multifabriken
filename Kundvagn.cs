using System;

namespace multifabriken;

public class Kundvagn
{
   private List<object> produkter = new List<object>();

   public void AddProduct(object produkt) {
    produkter.Add(produkt);
    System.Console.WriteLine("Produkten har lagts till i kundvagnen!");
   }

   public void DeleteProduct(object produkt) {
    produkter.Remove(produkt);
    System.Console.WriteLine("Produkten har tagits bort ur kundvagnen!");
   }

   public void ListProducts() {
    if (produkter.Count == 0) {
    System.Console.WriteLine("Din kundvagn är tom!");
    } 
     System.Console.WriteLine("Din kundvagn: ");
     foreach (var produkt in produkter) {
        System.Console.WriteLine(produkt.ToString());
     }

   }
}
