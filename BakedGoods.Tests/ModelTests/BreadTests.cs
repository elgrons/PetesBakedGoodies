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
    public void ClassNameConstructor_CreatesInstanceOfClassName_ClassName()
    {
      // Arrange
      Bread newBaguette = new Bread(2, 3, 8);
      // Act
      //not needed here
      // Assert
    Assert.AreEqual(typeof(Bread), newBaguette.GetType());
    }
  }
}