using el_chupitos_pattern.drink;
using el_chupitos_pattern.Drink.cocktail;
namespace el_chupitos_pattern.Drink.ingredient
{
    public interface IExtra:ICocktail
    {
        void AddExtra(int _quantity);
        ICocktail cocktailComponent { get; }
        int Quantity { get; set; }
    }
}