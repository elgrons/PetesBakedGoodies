using System.Collections.Generic;
using System;

namespace BakedGoods.Models
{
  public class Bread
  {
    private int _side1;
    public int Side1
    {
      get { return _side1; }
      set { _side1 = value; }
    }
    public int Side2 { get; set; }
    private int _side3;
    private static List<Bread> _instances = new List<Bread> {};

    public Bread(int length1, int length2, int length3)
    {
      _side1 = length1;
      Side2 = length2;
      _side3 = length3;
      _instances.Add(this);
    }

  }
}