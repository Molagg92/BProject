using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

  [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

  [TestMethod]
    public void BreadOrder_ReturnOrderTotal_int()
    { 
    Bread newBread2 = new Bread(2);
    Assert.AreEqual(1, newBread2.BreadOrder());
    } 

  }
}