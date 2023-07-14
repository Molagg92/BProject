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

  }
}