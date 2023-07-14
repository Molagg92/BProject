using System.Collections.Generic;
using System;

namespace Bakery.Models
{
public class Bread
  {
    public int Price = 5;
    public int LoafQuantity { get; set; }

    public Bread(int Quantity)
    {
      LoafQuantity = Quantity;
    }

    public int BreadOrder()
    {

      return ((LoafQuantity / 3) * 2 + (LoafQuantity % 3)) * Price;
    }
  }
}