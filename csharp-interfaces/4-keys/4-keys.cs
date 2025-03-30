using System;

/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    public string name
    {
        get;
        set;
    }

    /// <summary>
    /// Override tostring() method
    /// </summary>
    /// <returns>string</returns>
    public override string ToString()
    {
        return ($"{this.name} is a {this.GetType()}");
    }
}

/// <summary>
/// Ineterface Interactive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Intercat method
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface Breakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability integer
    /// </summary>
    int durability
    {
        get;
        set;
    }
    /// <summary>
    /// break method
    /// </summary>
    void Break();   
}

/// <summary>
/// Interface Collectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// isCOllected property
    /// </summary>
    bool isCollected
    {
        get;
        set;
    }
    /// <summary>
    /// Collect method
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// COnstructor of Door
    /// </summary>
    public Door(string name="Door")
    {
        this.name = name;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }

}

/// <summary>
/// Class Decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Bool value
    /// </summary>
    public bool isQuestItem
    {
        get;
        set;
    }

    /// <summary>
    /// Durability property
    /// </summary>
    /// <value>Integer</value>
    public int durability
    {
        get;
        set;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        else
        {
            this.durability = durability;
            this.name = name;
            this.isQuestItem = isQuestItem;
        }
    }

    /// <summary>
    /// Implementation of interact
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
            Console.WriteLine($"The {this.name} has been broken.");
        else
        {
            if (isQuestItem == true)
                Console.WriteLine($"You look at the {this.name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {this.name}. Not much to see here.");
        }
    }

    /// <summary>
    /// Break implementation
    /// </summary>
    public void Break()
    {
        this.durability -= 1;
        if (this.durability > 0)
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        else
            Console.WriteLine($"The {this.name} is already broken.");
    }
}

/// <summary>
/// Class key
/// </summary>
public class Key : Base, ICollectable
{
    /// <summary>
    /// isCollected property
    /// </summary>
    public bool isCollected
    {
        get;
        set;
    }

    /// <summary>
    /// Constructor of Key
    /// </summary>
    public Key(string name="Key", bool isCollected=false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// <summary>
    /// Collect implementation
    /// </summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {this.name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {this.name}.");
        }
    }
}