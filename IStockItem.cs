using System;
using System.Collections.Generic;

namespace stock
{
    interface IStockItem {
        string Name { get; set;}
        int Price { get; set;}
    } 
}