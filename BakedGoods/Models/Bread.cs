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
      int total = breadNum * 5;
      return total;
    }
  }
}