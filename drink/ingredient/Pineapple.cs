using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.cocktail;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.Drink.ingredient
{
    public class Pineapple:IIngredient,IStockItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ICocktail cocktailComponent { get; }
        public Pineapple()
        {
            Name = "Pineapple";
            Price = 2.5;
        }
        public Pineapple(ICocktail cocktailComponent)
        {
            Name = "Pineapple";
            Price = 2.5;
            this.cocktailComponent = cocktailComponent;
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

            cocktailComponent.Price += Quantity * Price;
        }


        public Dictionary<string, int> Ingredients { get; }
    }
}