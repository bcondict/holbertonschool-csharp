using System;

/// <summary>
/// abstract class to define a name and override ToString() method
/// </summary>
public abstract class Base
{
    public string name;

    /// <summary>
    /// TosString() override method
    /// </summary>
    /// <returns>'name' is a 'type'</returns>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}
