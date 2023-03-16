using System;

/// <summary>
/// modifier for player's damage
/// </summary>
public enum Modifier
{
    /// <summary>
    /// weak modifier value 0.5
    /// </summary>
    Weak,

    /// <summary>
    /// base modifier value 1
    /// </summary>
    Base,

    /// <summary>
    /// strong modifier value 1.5
    /// </summary>
    Strong
}

/// <summary>
/// Calculate modifier for player's damage
/// </summary>
/// <param name="baseValue">base value of damage</param>
/// <param name="modifier">modifier for damage</param>
/// <returns>new value</returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

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
        this.ValidateHP(this.hp - damage);
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
        this.ValidateHP(this.hp + heal);
    }

    /// <summary>
    /// Validate player's new HP
    /// </summary>
    /// <param name="newHp">health points to validate if it's possible assing it to player</param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            this.hp = 0;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
    }

    /// <summary>
    /// apply modifier for player's damage
    /// </summary>
    /// <param name="baseValue">base value </param>
    /// <param name="modifier">value of modifier</param>
    /// <returns>new value of player value</returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        float modifierValue = 1f;

        if (modifier == Modifier.Weak)
            modifierValue = 0.5f;
        else if (modifier == Modifier.Base)
            modifierValue = 1f;
        else if (modifier == Modifier.Strong)
            modifierValue = 1.5f;
        return (baseValue * modifierValue);
    }
}
