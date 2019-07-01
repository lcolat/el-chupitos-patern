using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.ingredient;
using el_chupitos_pattern.drink.simpleDrink;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.Drink.cocktail
{
    public class CubaLibre:ICocktail
    {
        public string Name { get; }
        public double Price { get; set; }
        public Dictionary<string, int> Ingredients { get; }
        public Stock Stock { get; set; }

        public CubaLibre(Stock stock)
        {
            Name = "Cuba Libre";
            Price = 6.0;
            Ingredients = new Dictionary<string, int> {{Lime.NAME, 1}, {Coca.NAME, 2}, {Rum.NAME, 2}};
            Stock = stock;
            stock.RemoveItem(Lime.NAME, 1);
            stock.RemoveItem(Coca.NAME, 1);
            stock.RemoveItem(Rum.NAME, 2);
        }
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