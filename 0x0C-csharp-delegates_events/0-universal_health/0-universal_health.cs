using System;

/// <summary>
/// public class player
/// </summary>
public class Player
{
    // name of player, default value "Player"
    private string name { get; set; }

    // max health of player, default value 100f
    private float maxHp { get; set; }

    // current health of player, default value maxHp
    private float hp { get; set;}

    /// <summary>
    /// Constructor for Player class
    /// </summary>
    /// <param name="name">name of player, default value "Player"</param>
    /// <param name="maxHp">maximum health of player, default value 100f</param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }

    /// <summary>
    /// print current health of player
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
