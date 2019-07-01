using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.Drink.ingredient;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.drink.simpleDrink
{
    public class Rum: IIngredient,IStockItem
    {
        public const string NAME = "Rum";
        public string Name { get; set; }
        public double Price { get; set; }
        public ICocktail cocktailComponent { get; }
        public int Quantity { get; set; }
        public Dictionary<string, int> Ingredients { get; }
        public Stock Stock { get; set; }
        public Rum(Stock stock)
        {
            Name = NAME;
            Price = 8.0;
            Stock = stock;
        }
        public Rum(ICocktail cocktailComponent,Stock stock)
        {
            Name = NAME;
            Price = 8.0;
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