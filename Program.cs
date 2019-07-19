using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery {

    public class Program
        {

           

        public static void Main()
            {
            BuyPrompt();
            //int breadCost = GetBreadCost();
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
            Console.WriteLine("Would you like to purchase any bread or pastries?  type n to return");
            string bakeSelect = Console.ReadLine();
            if (bakeSelect.ToLower() == "bread")
                {
                BreadBuy();
                }
            else if (bakeSelect.ToLower() == "pastries")
                {
                PastryBuy();
                }
            else if (bakeSelect.ToLower() == "n" || bakeSelect.ToLower() == "no")
                {
                BuyPrompt();
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
            Bread bread = new Bread(breadNumber, 5);
            //error CS1503: Argument 1: cannot convert from 'method group' to 'ReadOnlySpan<char>'
            //int breadPrice = int.Parse(bread.GetBreadCost);
            //error CS0428: Cannot convert method group 'GetBreadCost' to non-delegate type 'int'
            //int breadPrice = bread.GetBreadCost;
            //Console.WriteLine(breadPrice);
            //Getting CS1503 cannot convert from 'method group' to 'bool'
            //Console.WriteLine(bread.GetBreadCost);
             //CS0103 'GetBreadCost does not exist in current context  for these below
            //GetBreadCost();
            //Console.WriteLine(newBread.GetBreadCost());

            int breadCost = ((breadNumber/3)*-5+(breadNumber*5));
            Console.WriteLine(breadCost);
            BakeType();
            }

        public static void PastryBuy()
            {
            //come back and change this to use classes
            Console.WriteLine("How many pasteries would you like to buy?");
            int pastryNumber = int.Parse(Console.ReadLine());
            Pastry pastry = new Pastry(pastryNumber, 2);
            int pastryCost = ((pastryNumber/3)*-1+(pastryNumber*2));
            Console.WriteLine(pastryCost);

            BakeType();
            }
        public static void CurrentCart()
            {
            int finalCost = (breadCost = pastryCost);
            Console.WriteLine("You have " + breadNumber + " for a total of $" + breadCost + " and " + pastryNumber + " for a total of $" + pastryCost + ". Your Final bill is: $" + finalCost);
            }
        }
}
    
    /*
       The application will return the total cost of the order.

Pierre offers the following deals:

Bread: Buy 2, get 1 free. A single loaf costs $5.

Pastry: Buy 1 for \$2 or 3 for $5.*/
 /*   public class Pastry
        {
        public static void Main()
            {

            }
        }*/