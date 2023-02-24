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
    [TestMethod]
      public void OrderTotal_DeterminePastryOrderTotal_Int()
      {
      //Arrange
      int pastryNum = 2;
      Pastry newDonut = new Pastry(pastryNum);
      int greatDeal = pastryNum /4;
      int pTotal = (pastryNum - greatDeal) * 2;
      //Act
      int pastryTotal = newDonut.PastryOrderTotal(pastryNum);
      //Assert
      Assert.AreEqual(pTotal, pastryTotal);
      }
        [TestMethod]
      public void OrderTotal_DeterminePastryTotalWithBuyTwoGetOneFree_Int()
      {
      //Arrange
      int pastryNum = 3;
      Pastry newDonut = new Pastry(pastryNum);
      int greatDeal = pastryNum /4;
      int pTotal = (pastryNum - greatDeal) * 2;
      //Act
      int pastryTotal = newDonut.PastryOrderTotal(pastryNum);
      //Assert
      Assert.AreEqual(pTotal, pastryTotal);
      }
  }
}