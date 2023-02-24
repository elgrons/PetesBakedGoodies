using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;
using System.Collections.Generic; 
using System;

namespace BakedGoods.Tests
{
  [TestClass]
  public class BreadTests
  {
  [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBaguette = new Bread();
    Assert.AreEqual(typeof(Bread), newBaguette.GetType());
    }
        [TestMethod]
    public void GetBreadOrder_ReturnBreadOrder_Int()
    {
      //Arrange
      int BreadOrder = 1;
      Bread newBaguette = new Bread();
      //Act
      int result = newBaguette.BreadOrder;
      //Assert 
      Assert.AreEqual(BreadOrder, result);
    }
  }
}