namespace el_chupitos_pattern.stock 
{
    class Confiture : IStockItem
    {
        public string Name {get;set;}
        public double Price {get;set;}

        public Confiture(string name, double price){
            Name = name;
            Price = price;
        }
    } 
}