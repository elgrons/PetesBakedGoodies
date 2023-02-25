using System.Collections.Generic;
using System;

namespace BakedGoods.Models
{
  public class Bread
  {   
    public int BreadOrder { get; set; }
    public int BreadOrderAddOn { get; set; }
    public Bread(int breadNum)
    {
      BreadOrder = breadNum;
    }
    public int BreadOrderTotal(int breadNum)
    {
      int buyTwoGetOne = breadNum /3;
      int total = (breadNum - buyTwoGetOne) * 5;
      return total;
    }
    //   public static int BreadOrderUpdate(int breadNum2)
    // {
    //   BreadOrderAddOn = breadNum2;
    //   int updatedTotal = Bread.BreadOrderAddOn + BreadOrderTotal();
    //   return updatedTotal;
    // }
  }
}