using System.Collections.Generic;
using el_chupitos_pattern.drink;
using el_chupitos_pattern.stock;

namespace el_chupitos_pattern.Drink.cocktail
{
    public interface ICocktail : IDrink
    {
        Dictionary<string,int> Ingredients { get; }
        Stock Stock { get; set; }
    }
}