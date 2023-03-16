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
    /// event handler for HPCheck
    /// </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// status of player
    /// </summary>
    private string status;

    /// <summary>
    /// Constructor for Player class
    /// </summary>
    /// <param name="name">name of player, default value "Player"</param>
    /// <param name="maxHp">maximum health of player, default value 100f</param>
    /// <param name="status">status of player, default value "OK"</param>
    public Player(string name = "Player", float maxHp = 100f, string status = "OK")
    {
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
        if (status == "OK")
        {
            this.status = $"{this.name} is ready to go!";
        }
        else
        {
            this.status = $"{this.name} is {status}!";
        }

        this.HPCheck += CheckStatus;
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
        // this.CheckStatus(HPCheck, new CurrentHPArgs(this.hp));
        OnCheckStatus(new CurrentHPArgs(this.hp));
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

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
            this.status = $"{this.name} is in perfect health!";

        else if (e.currentHp >= (this.maxHp / 2))
            this.status = $"{this.name} is doing well!";

        else if (e.currentHp >= (this.maxHp / 4))
            this.status = $"{this.name} isn't doing too great...";

        else if (e.currentHp > 0)
            this.status = $"{this.name} needs help!";

        else
            this.status = $"{this.name} is knocked out!";

        Console.WriteLine(this.status);
    }

    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        if (e.currentHp == 0)
        {
            // Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Health has reached zero!");
            // Console.ResetColor();
        }
        else 
            Console.WriteLine("Health is low!");

        Console.ResetColor();
    }

    /// <summary>
    /// Check status of player
    /// </summary>
    /// <param name="e">Current hp</param>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        CheckStatus(HPCheck, e);
        if (e.currentHp <= (this.maxHp / 4))
        {
            HPValueWarning(HPCheck, e);
        }
    }
}

/// <summary>
/// show currer health of player
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// current health of player
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// constructor for CurrentHPArgs
    /// </summary>
    /// <param name="newHp">new health points of player</param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
