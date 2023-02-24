using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;
using System.Collections.Generic; 
using System;

namespace BakedGoods.Tests
{
  [TestClass]
  public class PastryTests
  {
  [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newDonut = new Pastry(pastryNum);
      Assert.AreEqual(typeof(Pastry), newDonut.GetType());
    }

  }
}