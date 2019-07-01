using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.Drink.ingredient
{
    public class CoconutMilk:IIngredient,IStockItem
    {
        public const string NAME = "Coconut milk";
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ICocktail cocktailComponent { get; }
        public Dictionary<string, int> Ingredients { get; }
        public Stock Stock { get; set; }
        public CoconutMilk(Stock stock)
        {
            Name = NAME;
            Price = 3.0;
            Stock = stock;
        }
        public CoconutMilk(ICocktail cocktailComponent,Stock stock)
        {
            Name = "Coconut milk";
            Price = 3.0;
            this.cocktailComponent = cocktailComponent;
            Stock = stock;
        }
        public void Display()
        {
            Console.WriteLine(Quantity + " " + Name + " à " + Quantity * Price + " €");
        }

        public double GetPrice()
        {
            return cocktailComponent.GetPrice() + Quantity * Price;
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

            cocktailComponent.Price += Quantity * Price;
            Stock.RemoveItem(Name, quantity);
        }
    }
}