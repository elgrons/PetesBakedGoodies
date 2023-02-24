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
      int pastryNum = 1;
      Pastry newDonut = new Pastry(pastryNum);
      Assert.AreEqual(typeof(Pastry), newDonut.GetType());
    }
    [TestMethod]
    public void GetPastryOrder_SetValueOfPastryOrder_Int()
    {
      //Arrange
      int pastryNum = 1;
      Pastry newDonut = new Pastry(pastryNum);
      //Act
      newDonut.PastryOrder = pastryNum;
      //Assert 
      Assert.AreEqual(pastryNum, newDonut.PastryOrder);
    }
  }
}