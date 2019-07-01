using System;
using System.Collections.Generic;

namespace stock
{
    public class Stock
    {
        public Dictionary<string, int> Item;
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