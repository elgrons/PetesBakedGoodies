using System.Collections.Generic;
using System;

namespace BakedGoods.Models
{
  public class Bread
  {   
    public int BreadOrder { get; set; }
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
  }
}