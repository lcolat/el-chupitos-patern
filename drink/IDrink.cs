namespace el_chupitos_pattern.drink
{
    public interface IDrink : IComponent
    {
        string  Name { get; }
        double Price { get; set; }
        void Display();
    }
}