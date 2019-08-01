using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery
{

    public class Program
    {
        public static int breadNumbers = 0;
        public static int pastryNumbers = 0;
        public static int breadTotal = 0;
        public static int pastryTotal = 0;

        public static void Main()
        {
            BuyPrompt();
        }

        public static void BuyPrompt()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Welcome to Pierre's Bakery, loaves of bread are $5, but buy 2 and get 1 free.  Pastries are $2, or 3 for $5.  Would you like to make and order? [y / n]");
            string orderCheck = Console.ReadLine();
            if (orderCheck.ToLower() == "y")
            {
                BakeType();
            }
            else if (orderCheck.ToLower() == "n")
            {
                return;
            }
        }
        public static void BakeType()
        {
            Console.WriteLine("Would you like to purchase any bread or pastries?  cart to view cart");
            string bakeSelect = Console.ReadLine();
            if (bakeSelect.ToLower() == "bread")
            {
                BreadBuy();
            }
            else if (bakeSelect.ToLower() == "pastries")
            {
                PastryBuy();
            }
            else if (bakeSelect.ToLower() == "n" || bakeSelect.ToLower() == "cart")
            {
                Console.WriteLine("------------------------");
                int finalCost = breadTotal + pastryTotal;
                Console.WriteLine("You have " + breadNumbers + " loaves for a total of $" + breadTotal + " and " + pastryNumbers + " pastries for a total of $" + pastryTotal + ". Your Final bill is: $" + finalCost);
                Main();
            }
            else
            {
                Console.WriteLine("I'm sorry we didn't understand that");
                BakeType();
            }
        }

        public static void BreadBuy()
        {
            Console.WriteLine("How many loaves would you like to buy?");
            int breadNumber = int.Parse(Console.ReadLine());
            breadNumbers += breadNumber;
            Bread bread = new Bread(breadNumber, 5);
            breadTotal = bread.GetBreadCost(breadNumbers, 5);
            Console.WriteLine("Bread Cost: " + breadTotal);
            BakeType();
        }

        public static void PastryBuy()
        {
            Console.WriteLine("How many pasteries would you like to buy?");
            int pastryNumber = int.Parse(Console.ReadLine());
            pastryNumbers += pastryNumber;
            Pastry pastry = new Pastry(pastryNumber, 2);
            pastryTotal = pastry.GetPastryCost(pastryNumbers, 2);
            Console.WriteLine("Pastry Cost:  " + pastryTotal);

            BakeType();
        }


    }
}