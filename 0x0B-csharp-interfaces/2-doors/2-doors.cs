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
