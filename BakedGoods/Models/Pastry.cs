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
  }
}