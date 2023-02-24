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
  }
}