using System;
using BakedGoods.Models;

namespace BakedGoods
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pete's Baked Goodies!");
      Console.WriteLine("The price of a single loaf of bread is $5 and the price for a single pastry is $2.");
      Console.WriteLine("But Pete has a deal for you!");
      Console.WriteLine("*~*Bread is Buy 2, get 1 free and Pastry is Buy 3, get 1 free.*~*");
      Console.WriteLine("Please enter a number for how many loaves of bread you would like to order:");
      string breadNumber = Console.ReadLine(); 
      Console.WriteLine("Please enter a number for how many pastries you would like to order:");
      string pastryNumber = Console.ReadLine();
      int breadNum = int.Parse(breadNumber);
      Bread bread = new Bread(breadNum);
      int pastryNum = int.Parse(pastryNumber);
      Pastry pastry = new Pastry(pastryNum);
      Console.WriteLine($"You have ordered {bread.BreadOrder} breads.");  
      Console.WriteLine($"You have ordered {pastry.PastryOrder} pastries.");  
      Console.WriteLine("Your order total is: $");
      Console.WriteLine("Thanks for visiting Pete's Baked Goodies! Enjoy your goodies!");
    }

  }
}