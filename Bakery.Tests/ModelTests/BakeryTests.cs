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

    [TestMethod]
    public void BreadOrderPrice_ReturnsBreadTotalPriceIfBuying2WithDeal()
    {
      int breadOrder = 2;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadOrderPrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void BreadOrderPrice_ReturnsBreadTotalPriceIfBuying4WithDeal()
    {
      int breadOrder = 4;
      Bread newBreadOrder = new Bread(breadOrder);
      int result = newBreadOrder.BreadOrderPrice();
      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryOrderPrice_ReturnsPastryTotalPriceIfBuying1_int()
    {
      int pastryOrder = 1;
      Pastry newOrderPastry = new Pastry(pastryOrder);
      int result = newOrderPastry.PastryOrderPrice();
      Assert.AreEqual(2,result);
    }

    [TestMethod]
    public void PastryOrderPrice_ReturnsPastryTotalPriceIfBuying3WithDeal_int()
    {
      int pastryOrder = 3;
      Pastry newPastryOrder = new Pastry(pastryOrder);
      int result = newPastryOrder.PastryOrderPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void PastryOrderPrice_ReturnsPastryTotalPriceIfBuying6WithDeal()
    {
      int pastryOrder = 6;
      Pastry newPastryOrder = new Pastry(pastryOrder);
      int result = newPastryOrder.PastryOrderPrice();
      Assert.AreEqual(10, result);
    }
  }
}
