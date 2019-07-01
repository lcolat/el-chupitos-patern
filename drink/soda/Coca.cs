using System;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.drink.soda
{
    public class Coca:IDrink,IStockItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public void Display()
        {
            Console.WriteLine(Name + " " + Price + " €");
        }

        public double GetPrice()
        {
            return Price;
        }
    }
}