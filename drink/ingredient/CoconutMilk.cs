using System;
using System.Collections.Generic;
using el_chupitos_pattern.Drink.cocktail;

namespace el_chupitos_pattern.Drink.ingredient
{
    public class CoconutMilk:IIngredient
    {
        public string Name { get; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ICocktail cocktailComponent { get; }
        public CoconutMilk()
        {
            Name = "Coconut milk";
            Price = 3.0;
        }
        public CoconutMilk(ICocktail cocktailComponent)
        {
            Name = "Coconut milk";
            Price = 3.0;
            this.cocktailComponent = cocktailComponent;
        }
        public void Display()
        {
            Console.WriteLine(Quantity + " " + Name + " à " + Quantity * Price + " €");
        }

        public double GetPrice()
        {
            return cocktailComponent.GetPrice() + Quantity * Price;
        }

        public void AddExtra(int _quantity)
        {
            Quantity = _quantity;
            if (cocktailComponent.Ingredients.ContainsKey(Name))
            {
                cocktailComponent.Ingredients[Name] += _quantity;
            }else
            {
                cocktailComponent.Ingredients.Add(Name,_quantity);
            }

            cocktailComponent.Price += Quantity * Price;
        }

        public Dictionary<string, int> Ingredients { get; }
    }
}