using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string name { get; set; }
        public string description { get; set;}
        public float price { get; set;}
        public List<string> tags { get; set;}

        public Item(
            string name,
            string description = null,
            float price = 0.00f,
            List<string> tags = null
        )
        {
            this.name = name;
            this.description = description;
            this.price = (float) (Math.Round(price, 2));
            this.tags = tags;
        }
    }
}
