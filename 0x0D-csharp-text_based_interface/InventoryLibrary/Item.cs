using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// class item that inherit from BaseClass
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary>
        /// name of item created
        /// </summary>
        /// <value>name of item</value>
        public string name { get; set; }

        /// <summary>
        /// description of item created
        /// </summary>
        /// <value>description of item created </value>
        public string description { get; set;}

        /// <summary>
        /// Price of item created
        /// </summary>
        /// <value>price of the item created</value>
        public float price { get; set;}

        /// <summary>
        /// tags of item created
        /// </summary>
        /// <value>tags that item have</value>
        public List<string> tags { get; set;}

        /// <summary>
        /// item constructor to set the name, description, price and tags
        /// </summary>
        /// <param name="name">Item name</param>
        /// <param name="description">Description of item</param>
        /// <param name="price">Price of item</param>
        /// <param name="tags">tags of item</param>
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
