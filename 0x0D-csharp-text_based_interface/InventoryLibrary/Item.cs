namespace InventoryLibrary;

public class Item : BaseClass
{
    public string name;

    public Item(
        string name,
        string description = "",
        float price = 0.0f,
        List<string> tags = null
    )
    {
        this.name = name;
        this.description = description;
        this.price = Math.Round(price, 2);
        this.tags = tags;
    }

    BaseClass baseClass = new BaseClass();

}
