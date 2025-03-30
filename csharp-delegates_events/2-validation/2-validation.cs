using System;

/// <summary>
/// Player Class
/// </summary>
public class Player
{
    private string name {get; set;}
    private float maxHp {get; set;}
    private float hp {get; set;}

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    /// <summary>
    /// Method Print
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name,this.hp,this.maxHp);
    }

    /// <summary>
    /// Prints the damage taked.
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            damage = 0;
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            ValidateHP(this.hp - damage);
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
    }

    /// <summary>
    /// Prints the hp points healed.
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0;
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            ValidateHP(this.hp + heal);
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }

    /// <summary>
    /// Sets the new value of the Player’s hp.
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp <= 0)
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
}

/// <summary>
/// Delegate that takes a float amount.
/// </summary>
/// <param name="num"></param>
public delegate void CalculateHealth(float num);