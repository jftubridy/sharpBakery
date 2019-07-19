using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery {

    public class Program
        {

     
        public static List<string> breadAmmount = new List<string>();
        public static List<string> pastryAmmount = new List<string>();

        public static void Main()
            {
            BuyPrompt();
            }

        public static void BuyPrompt()
            {
            Console.WriteLine("Welcome to Pierre's Bakery, loaves of bread are $5, but buy 2 and get 1 free.  Pastries $2, or 3 for $5.  Would you like to make and order? [y / n]");
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
            Console.WriteLine("Would you like to purchase bread or pastries?");
            string bakeSelect = Console.ReadLine();
            if bakeSelect.ToLower() == "bread")
                {
                BreadBuy();
                }
            else if (bakeSelect.ToLower() == "pastries");
                {
                PastryBuy();
                }
            else
                {
            Console.WriteLine("I'm sorry we didn't understand that");
            BuyPrompt();
                }
            }
        }
    }
    /*When the user runs the application, they should receive a prompt with a welcome message along with the cost for both Bread and Pastry.

A user should be able to specify how many loaves of Bread and how many Pastrys they'd like.

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

}
