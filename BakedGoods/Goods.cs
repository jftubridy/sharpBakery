using System;

namespace Bakery
{

    class Bread
    {
        public int Amount { get; set; }
        public int Price { get; set; }

        public Bread(int amount, int price)
        {
            Amount = amount;
            Price = price;
        }

        public int GetBreadCost(int Amount, int Price)
        {
            int startPrice = Amount * Price;
            int freeLoaf = (Amount / 3) * -5;
            int breadCost = freeLoaf + startPrice;
            return breadCost;
        }

    }
    class Pastry
    {
        public int Amount { get; set; }
        public int Price { get; set; }

        public Pastry(int amount, int price)
        {
            Amount = amount;
            Price = price;
        }

        public int GetPastryCost(int Amount, int Price)
        {
            int startPrice = Amount * Price;
            int threeDeal = (Amount / 3) * -1;
            int pastryCost = threeDeal + startPrice;
            return pastryCost;
        }

    }
}