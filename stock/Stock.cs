using System.Collections.Generic;

namespace el_chupitos_pattern.stock
{
    public class Stock
    {
        public Dictionary<string, int> Item;

        private static Stock instance = null;    

        public static Stock GetInstance()
        {
            if(instance == null){
                instance = new Stock();
            }
            return instance;
        }
        
        public Stock(){
            Item = new Dictionary<string, int>();
        }
        public void RemoveItem(string StockItem, int quantity){
            Item[StockItem] -= quantity; 
 
        } 

        public void AddItem(string StockItem, int quantity){
            if(Item.ContainsKey(StockItem)){
                Item[StockItem] += quantity; 
            }
            else{
                Item.Add(StockItem, quantity);
            }
        }

    } 
}