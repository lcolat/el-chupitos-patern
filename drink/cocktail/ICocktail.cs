using System.Collections.Generic;
using el_chupitos_pattern.drink;

namespace el_chupitos_pattern.Drink.cocktail
{
    public interface ICocktail : IDrink
    {
        Dictionary<string,int> Ingredients { get; }
    }
}