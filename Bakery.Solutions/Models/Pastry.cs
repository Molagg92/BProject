using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int Price = 2;
    public int PastryQuantity { get; set; }
    public Pastry(int Quantity)
    {
      PastryQuantity = Quantity;
    }
     public int PastryOrder()
    {
      return  ((PastryQuantity / 4) * 3 + (PastryQuantity % 4)) * Price;
    }
  }
}