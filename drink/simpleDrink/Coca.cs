using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.Drink.ingredient;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.drink.simpleDrink
{
    public class Coca: IIngredient,IStockItem
    {
        public const string NAME = "Coca";
        public string Name { get; set; }
        public double Price { get; set; }
        public ICocktail cocktailComponent { get; }
        public int Quantity { get; set; }
        public Dictionary<string, int> Ingredients { get; }
        public Stock Stock { get; set; }

        public Coca(Stock stock)
        {
            Name = NAME;
            Price = 5.0;
            Stock = stock;
        }
        public Coca(ICocktail cocktailComponent, Stock stock)
        {
            Name = NAME;
            Price = 5.0;
            this.cocktailComponent = cocktailComponent;
            Stock = stock;
        }
        public void Display()
        {
            Console.WriteLine(Name + " " + Price + " €");
        }

        public double GetPrice()
        {
            return Price;
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