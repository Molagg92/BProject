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

  }
}