using System.Collections.Generic;
using System;
using el_chupitos_pattern.drink;

namespace el_chupitos_pattern.order
{
    public class Order : IComponent
    {
        public List<IDrink> drinks;
        private IOrderState state;

        public Order()
        {
            drinks = new List<IDrink>();
        }

        public void AddDrink(IDrink drink)
        {
            this.drinks.Add(drink);
        }

        public void SetState(IOrderState state)
        {
            this.state = state;
        }

        public void Action()
        {
            this.state.Action(this);
        }

        public double GetPrice()
        {
            double price = 0;

            foreach (IDrink drink in this.drinks)
            {
                price += drink.GetPrice();
            }

            return price;
        }
    }
}