using System;
using BakedGoods.Models;

namespace BakedGoods
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("");
      Console.WriteLine("            Welcome to Pete's Baked Goodies!");
      Console.WriteLine("      The price of a single loaf of bread is $5 and the price for a single pastry is $2.");
      Console.WriteLine("      ~~But wait! Pete has a special DEAL for you today! Bread is Buy 2, get 1 free and Pastry is Buy 3, get 1 free.~~          ");
      Console.WriteLine("");
      Console.WriteLine("*Please enter a number for how many loaves of bread you would like to order:");
      string breadNumber = Console.ReadLine(); 
      Console.WriteLine("*Please enter a number for how many pastries you would like to order:");
      string pastryNumber = Console.ReadLine();
      int breadNum = int.Parse(breadNumber);
      Bread bread = new Bread(breadNum);
      Console.WriteLine($"      Your selected bread amount is: {bread.BreadOrder}.");  
      int pastryNum = int.Parse(pastryNumber);
      Pastry pastry = new Pastry(pastryNum);
      Console.WriteLine($"      Your selected pastry amount is: {pastry.PastryOrder}.");  
      int breadTotal = bread.BreadOrderTotal(breadNum);
      int pastryTotal = pastry.PastryOrderTotal(pastryNum);
      Console.WriteLine("");
      Console.WriteLine("      Your Bread order total is: $" + breadTotal + " and your Pastry order total is: $" + pastryTotal + ".");
      Console.WriteLine("");
      Console.WriteLine("      Thanks for visiting Pete's Baked Goodies! Enjoy your fresh baked goodies and we'll see you tomorrow!");
    }
  }
}