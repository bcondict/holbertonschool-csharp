using System;

namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string user_id { get; set; }
        public string item_id { get; set; }
        public int quantity { get; set; }

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
