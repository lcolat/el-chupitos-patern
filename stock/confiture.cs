namespace el_chupitos_pattern.stock 
{
    class Confiture : IStockItem
    {
        public string Name {get;set;}
        public int Price {get;set;}

        public Confiture(string name, int price){
            Name = name;
            Price = price;
        }
    } 
}