// using System.Collections.Generic;
// using System;

// namespace BakedGoods.Models
// {
//   public class Bread
//   {   
//     public int BreadOrder { get; set; }
//     // public int BreadOrderAddOn { get; set; }
//     public int BreadOrderTotal(int breadNum)
//     {
//       for (int index = 0; index > 0; index++)
//       {
//       if (index % 3 == 0)
//         {
//         int buyTwoGetOne = breadNum /3;
//         int discountedTotal = (breadNum - buyTwoGetOne) * 5;
//         Console.WriteLine($"The amount of bread you have ordered is: {discountedTotal} ");
//         }
//       else if (index !== 0);
//         int total = (breadNum  * 5);
//         Console.WriteLine($"The amount of bread you have ordered is: {total} ");
//       }
//     }
//     //   public static int BreadOrderUpdate(int breadNum2)
//     // {
//     //   BreadOrderAddOn = breadNum2;
//     //   int updatedTotal = Bread.BreadOrderAddOn + BreadOrderTotal();
//     //   return updatedTotal;
//     // }
//   }
// }