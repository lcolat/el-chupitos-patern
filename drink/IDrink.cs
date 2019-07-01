namespace el_chupitos_pattern.drink
{
    public interface IDrink
    {
        string  Name { get; }
        double Price { get; set; }
        void Display();
        double GetPrice();
    }
}