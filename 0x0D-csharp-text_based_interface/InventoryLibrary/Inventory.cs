using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Invetory class that save the user_id, item_id and quantity
    /// inherits from BaseClass
    /// </summary>
    public class Inventory : BaseClass
    {
        /// <summary>
        /// user id that have the item, passed by user
        /// </summary>
        /// <value>id gived by user</value>
        public string user_id { get; set; }

        /// <summary>
        /// item id that the user have, passed by user
        /// </summary>
        /// <value>id gived by user</value>
        public string item_id { get; set; }

        /// <summary>
        /// quantity of the item that the user have, passed by user
        /// if the quantity is less than 1, the quantity is set to 1
        /// </summary>
        /// <value>value passed </value>
        public int quantity { get; set; }

        /// <summary>
        /// default constructor to set the user_id, item_id and quantity
        /// </summary>
        /// <param name="user_id">user id existent</param>
        /// <param name="item_id">item id existent</param>
        /// <param name="quantity">quantity of item that user have</param>
        public Inventory(string user_id, string item_id, int quantity)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 1)
                quantity = 1;
            this.quantity = quantity;
        }
    }
}
