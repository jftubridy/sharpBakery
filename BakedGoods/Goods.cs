using System;

namespace BakedGoods {

    class Bread
        {
        public string Type { get; set; }
        public int Price { get; set; }
         
        public Bread(string type, int price)
            {
            Type = type;
            Price = price;
            }

        /*public string GetType()
            {
            return _type;
            }

        public int GetPrice()
            {
            return _price;
            }

        public */
        }
    class Pastry
        {
        public string Type { get; set; }
        public int Price { get; set; }

        public Pastry(string type, int price)
            {
            Type = type;
            Price = price;
            }
        }
}