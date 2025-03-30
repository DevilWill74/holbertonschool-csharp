using System;

/// <summary>
/// Player Class
/// </summary>
public class Player
{
    private string name {get; set;}
    private float maxHp {get; set;}
    private float hp {get; set;}
    private string status {get; set;}

    /// <summary>
    /// EventHandler of type CurrentHPArgs.
    /// </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.status = $"{this.name} is ready to go!";
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
        HPCheck += CheckStatus;
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
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
            ValidateHP(this.hp - damage);
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
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
            ValidateHP(this.hp + heal);
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
        HPCheck(hp, new CurrentHPArgs(hp));
    }

    /// <summary>
    /// Method ApplyModifier.
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return (baseValue/2);
        }
        else if (modifier == Modifier.Strong)
        {
            return (baseValue*1.5f);
        }
        return baseValue;
    }

    /// <summary>
    /// Set the Player’s status to the following and print it.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if ((this.maxHp/2) <= e.currentHp && e.currentHp < this.maxHp)
        {
            this.status = $"{this.name} is doing well!";
        }
        else if ((this.maxHp/4) <= e.currentHp && e.currentHp < (this.maxHp/2))
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (0 < e.currentHp && e.currentHp < (this.maxHp/4))
        {
            this.status = $"{this.name} needs help!";
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
        }
        Console.WriteLine(this.status);
    }
}

/// <summary>
/// Delegate that takes a float amount.
/// </summary>
/// <param name="num"></param>
public delegate void CalculateHealth(float num);

/// <summary>
/// Delegate that takes a float and modifier.
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns> Float. </returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Enum.
/// </summary>
public enum Modifier
{
    /// <summary>
    /// Weak.
    /// </summary>
    Weak,
    /// <summary>
    /// Base.
    /// </summary>
    Base,
    /// <summary>
    /// Strong.
    /// </summary>
    Strong
}

/// <summary>
/// Class CurrentHPArgs that inherits from EventArgs.
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// Public float that cannot be modified.
    /// </summary>
    /// <value></value>
    public float currentHp {get; set;}

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
