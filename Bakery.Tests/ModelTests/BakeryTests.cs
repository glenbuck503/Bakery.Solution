using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceofBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadOrderPrice_ReturnsBreadTotalPriceBuying1_int()
    {
      int breadOrder = 1;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadOrderPrice();
      Assert.AreEqual(5, result);
    }


  }
}