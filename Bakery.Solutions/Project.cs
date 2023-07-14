using System;
using Bakery.Models;
using System.Collections.Generic;

namespace ProjectName
{
    class Program
    {
        static void Main()
        {
          
            Console.WriteLine("");
            Console.WriteLine("==================================");
            Console.WriteLine("Pierre's Bakery");
            Console.WriteLine("==================================");
            Console.WriteLine("Press Enter to Continue");
            Console.WriteLine("");

            // Order Bread!
            Console.ReadLine();
            Console.WriteLine("::How many loaves of bread?::");
            Console.WriteLine("");
            Console.WriteLine("Single Loaf of Bread - $5");
            Console.WriteLine("Buy 2, Get 1 Free!");
            Console.WriteLine("==================================");
            Console.WriteLine("");
            string breadInput = Console.ReadLine();  
            int breadWants = int.Parse(breadInput);
            Bread newBread = new Bread(breadWants);
            Console.WriteLine("");

            // Order Pastry!
            Console.WriteLine("::How many pastries?::");
            Console.WriteLine("");
            Console.WriteLine("Single Pastry - $2");
            Console.WriteLine("Buy 3, Get 1 Free!");
            Console.WriteLine("==================================");
            Console.WriteLine("");
            string pastryInput = Console.ReadLine();
            int pastryWants = int.Parse(pastryInput);
            Pastry newPastry = new Pastry(pastryWants);
            Console.WriteLine("");

            // Point of Sale!
            int totalCost = newBread.BreadOrder() + newPastry.PastryOrder();
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine("::ORDER DETAILS::");
            Console.WriteLine(""); 
            Console.WriteLine($"{breadWants} loaves of bread: ${newBread.BreadOrder()}");
            Console.WriteLine($"{pastryWants} pastries: ${newPastry.PastryOrder()}");
            Console.WriteLine(""); 
            Console.WriteLine($"Your total: ${totalCost}!"); 
            Console.WriteLine(""); 
            Console.WriteLine($"Thank You, and Have a lovely day");  
            Console.WriteLine("==================================");
            Console.WriteLine("");
            Console.WriteLine("Enter to Exit");
            Console.ReadLine();
            
        }
    }
}