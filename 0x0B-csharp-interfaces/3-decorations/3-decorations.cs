using System;

/// <summary>
/// abstract class to define a name and override ToString() method
/// </summary>
public abstract class Base
{
    /// <summary>
    /// name of the object, default is null
    /// </summary>
    public string name = null;

    /// <summary>
    /// TosString() override method
    /// </summary>
    /// <returns>'name' is a 'type'</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

/// <summary>
/// void interface
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// interface with durability and break functio
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// interface with collectable
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Door object that inherit from Base and IInteractive
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// default constructor for Door, default name is "Door"
    /// </summary>
    /// <param name="name">name of door</param>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// <summary>
    /// intectarion with door object
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked");
    }
}

/// <summary>
/// Decoration object that inherit from Base, IInteractive and IBreakable
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// isQuestItem is true if the decoration is a quest item
    /// </summary>
    public bool isQuestItem;

    /// <summary>
    /// durability of the decoration object (if it's breakable)
    /// </summary>
    /// <value>Default value to 1, not null</value>
    public int durability { get; set; }

    /// <summary>
    /// default constructor for Decoration
    /// </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact with the object
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Break the object if it's breakable
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        if (durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        if (durability < 0)
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
