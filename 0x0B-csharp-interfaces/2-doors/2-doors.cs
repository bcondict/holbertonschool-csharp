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
    /// <summary>
    /// Used for interactions.
    /// </summary>
    void Interact();
}

/// <summary>
/// interface with durability and break functio
/// </summary>
interface IBreakable
{
    /// <summary>
    /// Used for item durability.
    /// </summary>
    /// <value>Getter and setter</value>
    int durability { get; set; }

    /// <summary>
    /// Used to break an item.
    /// </summary>
    void Break();
}

/// <summary>
/// interface with collectable
/// </summary>
interface ICollectable
{
    /// <summary>
    /// Used to check if collected or not.
    /// </summary>
    /// <value>Getter and setter</value>
    bool isCollected { get; set; }

    /// <summary>
    /// Used to collect something.
    /// </summary>
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
        Console.WriteLine($"You try to open the {name}. It's locked");
    }
}
