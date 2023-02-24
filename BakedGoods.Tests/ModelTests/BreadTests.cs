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
      int breadNum = 1;
      Bread newBaguette = new Bread(breadNum);
      Assert.AreEqual(typeof(Bread), newBaguette.GetType());
    }
  [TestMethod]
    public void GetBreadOrder_SetValueOfBreadOrder_Int()
    {
      //Arrange
      int breadNum = 1;
      Bread newBaguette = new Bread(breadNum);
      //Act
      newBaguette.BreadOrder = breadNum;
      //Assert 
      Assert.AreEqual(breadNum, newBaguette.BreadOrder);
    }
  }
}