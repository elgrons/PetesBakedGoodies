using System.Collections.Generic;
using System;

namespace BakedGoods.Models
{
  public class Pastry
  {
    public int PastryOrder { get; set; }
    public Pastry(int pastryNum)
    {
      PastryOrder = pastryNum;
    }
    public int PastryOrderTotal(int pastryNum)
    {
      int total = pastryNum * 2;
      return total;
    }
  }
}