using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;


namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    { 
      Pastry newPastry = new Pastry(2);  
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
      [TestMethod]
   public void PastryOrderBasicMath_ReturnBasicPastryMath_int()
   {
    Pastry newPastry = new Pastry(7);
     Assert.AreEqual(14, newPastry.PastryOrder());
   }
  //     [TestMethod]
  //  public void PastryOrder_ReturnOrderTotal_int()
  //  {
  //   Pastry newPastry = new Pastry(7);
  //    Assert.AreEqual(12, newPastry.PastryOrder());
  //  }
  }
} 