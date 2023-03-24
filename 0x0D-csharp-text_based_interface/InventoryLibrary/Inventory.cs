using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        string user_id;
        string item_id;
        int quantity;

        public Inventory(string user_id, string item_id, int quantity)
        {
            this.user_id = user_id;
            this.item_id = item_id;
            if (quantity < 0)
                throw new ArgumentException("Quantity must be greater than or equal to 0");
            this.quantity = quantity;
        }
    }
}
