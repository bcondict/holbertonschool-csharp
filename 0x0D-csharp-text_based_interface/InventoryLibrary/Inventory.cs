namespace InventoryLibrary;

public class Inventory
{
    string user_id;
    string item_id;
    int quantity;

    public Inventory(string user_id, string item_id, int quantity)
    {
        this.user_id = user_id;
        this.item_id = item_id;
        if (quantity < 0)
            throw new System.ArgumentException("Quantity cannot be less than 0", "original");
        this.quantity = quantity;
    }
}
