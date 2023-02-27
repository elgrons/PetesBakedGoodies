using System;
using BakedGoods.Models;
using System.Threading;

namespace BakedGoods
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("");
      string text = @"            o                                             
      _|_ _ / ,     |)  _, |)  _ _|      _, _  _  _|   ,  
  |/\|/| |/  / \_   |/\/ | |/)|// |     / |/ \/ \/ |  / \_
  |_/|_|_|_/  \/     \/\/|_| \|_\/|_/   \/|\_/\_/\/|_/ \/ 
  (|                                      (|               "; Console. WriteLine(text);
      Console.WriteLine("Welcome to Pete's Baked Goods!");
      Console.WriteLine("The price of a single loaf of bread is $5 and the price for a single pastry is $2.");
      Console.WriteLine("");
      Console.WriteLine("~~But wait! Pete has a special DEAL for you today!~~          ");
      Console.WriteLine("***Bread is Buy 2, get 1 free and Pastry is Buy 3, get 1 free. Discount applied at checkout.*** ");
      Console.WriteLine("");
      Console.WriteLine("*Please enter a number for how many loaves of bread you would like to order:");
      string breadNumber = Console.ReadLine(); 
      Console.WriteLine("*Please enter a number for how many pastries you would like to order:");
      string pastryNumber = Console.ReadLine();
      int breadNum = int.Parse(breadNumber);
      Bread bread = new Bread(breadNum);
      Console.WriteLine($"Your selected bread amount is: {bread.BreadOrder}.");  
      int pastryNum = int.Parse(pastryNumber);
      Pastry pastry = new Pastry(pastryNum);
      Console.WriteLine($"Your selected pastry amount is: {pastry.PastryOrder}.");  
      int breadTotal = bread.BreadOrderTotal(breadNum);
      int pastryTotal = pastry.PastryOrderTotal(pastryNum);
      Console.WriteLine(""); 
      Console.WriteLine("*~*~*~*~**~*~*~*~**~*~*~*~**~*~*~*~*");
      Console.WriteLine("Your Bread order total is: $" + breadTotal + " and your Pastry order total is: $" + pastryTotal + ".");
      Console.WriteLine("*~*~*~*~**~*~*~*~**~*~*~*~**~*~*~*~*");
      Console.WriteLine(""); 
      Console.WriteLine("Thanks for visiting Pete's Baked Goodies! Enjoy your fresh baked goodies and we'll see you tomorrow!");
      Console.WriteLine("");
      string thankYouText = @"                                      
    _|_|)   _,       |)          _      |
    | |/\ / |  /|/| |/)    |  |/ \|  | |
    |_|  |\/|_/ | |_| \/    \/|\_/ \/|_o
                            (|         "; Console. WriteLine(thankYouText);
    }
    
    // public void BreadOrderAddOn(Bread bread)
    // {
    //   Console.WriteLine($"Would you like to make changes to your current order?");
    //   Console.WriteLine("Enter 'yes' to proceed, or 'no' to finish ordering.");
    //   string userInput = Console.ReadLine();  
    //   if (userInput == "yes")
    //   {
    //     Main();
    //     Console.WriteLine("*Please enter a number for how many additional loaves of bread you would like to order:");
    //     string breadNumber2 = Console.ReadLine();
    //     int breadNum2 = int.Parse(breadNumber2);
    //     int updatedBreadTotal = bread.BreadOrderUpdate(breadNum2);;
    //     Console.WriteLine("      Your Updated Bread order total is: $:" + bread.BreadOrderAddOn);
    //   }
    //   else
    //   {
    //     Console.WriteLine(""); 
    //     Console.WriteLine("<3<3<3Thanks for visiting Pete's Baked Goodies! Enjoy your fresh baked goodies and we'll see you tomorrow!<3<3<3");
    //   }
    }
  }