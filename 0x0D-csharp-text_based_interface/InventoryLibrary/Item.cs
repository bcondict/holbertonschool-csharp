using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string name;
        public string description;
        public float price;
        public List<string> tags;

        public Item(
            string name,
            string description = "",
            float price = 0.0f,
            List<string> tags = null
        )
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.tags = tags;
        }
    }
}
