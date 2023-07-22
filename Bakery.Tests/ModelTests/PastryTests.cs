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

  //-->This is the Test for Pastry, before the discounted math is applied.
  //-->So it would just be $2 a Pastry, so 7 of them would total $14
  //     [TestMethod]
  //  public void PastryOrderBasicMath_ReturnBasicPastryMath_int()
  //  {
  //   Pastry newPastry = new Pastry(7);
  //    Assert.AreEqual(14, newPastry.PastryOrder());
  //  }


      [TestMethod]
   public void PastryOrder_ReturnOrderTotal_int()
   {
    Pastry newPastry = new Pastry(7);
     Assert.AreEqual(12, newPastry.PastryOrder());
   }
  }
} 