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
/// TestObject class that inherits from Base and 3 interfaces
/// </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// <summary>
    /// durability of the object
    /// </summary>
    /// <value>default to 0</value>
    public int durability { get; set; }

    /// <summary>
    /// isCollected of the object
    /// </summary>
    /// <value>defualt to false</value>
    public bool isCollected { get; set; }

    /// <summary>
    /// name of the object
    /// </summary>
    /// <value>default is "Test Object"</value>
    public new string name { get; set; }

    /// <summary>
    /// interaction of the object
    /// </summary>
    public void Interact()
    {
    }

    /// <summary>
    /// break the object
    /// </summary>
    public void Break()
    {
    }

    /// <summary>
    /// collection of the object
    /// </summary>
    public void Collect()
    {
    }
}
