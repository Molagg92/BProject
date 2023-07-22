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

      // // For testing purposes, we have removed the discount so that this BreadOrder method returns the bread's true cost.
       return  LoafQuantity * Price;
      // // ((LoafQuantity / 3) * 2 + (LoafQuantity % 3))
    }
  }
}