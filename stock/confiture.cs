using System;
using System.Collections.Generic;

namespace stock 
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