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

    /// <summary>
    /// Player's calclulate health delegate
    /// </summary>
    /// <param name="amount">amount for health</param>
    public delegate void CalculateHealth (float amount);

    /// <summary>
    /// take damage from player
    /// </summary>
    /// <param name="damage">amount of damage that player takes</param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
            return;
        }
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    /// <summary>
    /// take heal for player
    /// </summary>
    /// <param name="heal">amout of heal that player takes</param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
            return;
        }
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }
}
