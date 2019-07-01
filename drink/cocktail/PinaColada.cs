using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.ingredient;

namespace el_chupitos_pattern.Drink.cocktail
{
    public class PinaColada:ICocktail
    {
        public string Name { get; }
        public double Price { get; set; }
        public Dictionary<string, int> Ingredients { get; }
        public PinaColada()
        {
            Name = "Piña Colada";
            Price = 6.0;
            Ingredients = new Dictionary<string, int> {{new Pineapple().Name, 2}, {new CoconutMilk().Name, 4}};
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