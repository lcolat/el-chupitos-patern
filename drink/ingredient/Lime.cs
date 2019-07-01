using System;
using System.Collections.Generic;
using el_chupitos_pattern.drink;
using el_chupitos_pattern.Drink.cocktail;

namespace el_chupitos_pattern.Drink.ingredient
{
    public class Lime:IIngredient
    {
        public string Name { get; }
        public double Price { get; set; }
        public ICocktail cocktailComponent { get; }
        public int Quantity { get; set; }

        public Lime(ICocktail cocktailComponent)
        {
            Name = "Lime";
            Price = 1.5;
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
            cocktailComponent.Price = cocktailComponent.Price + Quantity * Price;
        }

        public Dictionary<string, int> Ingredients { get; }
    }
}