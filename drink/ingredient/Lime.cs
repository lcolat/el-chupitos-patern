using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.Drink.ingredient
{
    public class Lime:IIngredient,IStockItem
    {
        public const string NAME = "Lime";
        public string Name { get; set; }
        public double Price { get; set; }
        public ICocktail cocktailComponent { get; }
        public int Quantity { get; set; }
        public Dictionary<string, int> Ingredients { get; }
        public Stock Stock { get; set; }
        public Lime(Stock stock)
        {
            Name = NAME;
            Price = 1.5;
            Stock = stock;
        }
        public Lime(ICocktail cocktailComponent, Stock stock)
        {
            Name = NAME;
            Price = 1.5;
            this.cocktailComponent = cocktailComponent;
            Stock = stock;
        }

        public void Display()
        {
            Console.WriteLine(Quantity + " " + Name + " à " + Quantity * Price + " €");
        }
        public double GetPrice()
        {
            return cocktailComponent.GetPrice();
        }
        public void AddExtra(int quantity)
        {
            Quantity = quantity;
            if (cocktailComponent.Ingredients.ContainsKey(Name))
            {
                cocktailComponent.Ingredients[Name] += quantity;
            }else
            {
                cocktailComponent.Ingredients.Add(Name,quantity);
            }
            cocktailComponent.Price = cocktailComponent.Price + Quantity * Price;
            Stock.RemoveItem(Name, quantity);
        }
    }
}