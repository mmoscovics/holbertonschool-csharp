using System;

/// Abstrct Class Base ///
public abstract class Base
{
    /// name ///
    public string name;

    /// ToString override ///
    public override string ToString()
    {
        return ($"{name} is a {this.GetType()}");
    }
}

/// Interactive interface ///
public interface IInteractive
{
    /// Interact ///
    void Interact();
}

/// Breakable interface ///
public interface IBreakable
{
    /// durability ///
    int durability {get; set;}

    /// Break ///
    void Break();
}

/// Collectable interface ///
public interface ICollectable
{
    /// collected ///
    bool isCollected {get; set;}

    /// Collect ///
    void Collect();
}

/// Class Door ///
public class Door : Base, IInteractive
{
    /// door constructor, names door ///
    public Door(string name = "Door")
    {
        this.name = name;
    }

    /// Interact ///
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}

/// Class Decoration ///
public class Decoration : Base, IInteractive, IBreakable
{
    /// decoration durability ///
    public int durability {get;set;}
    /// decoration is quest item ///
    public bool isQuestItem;

    /// decoration constructor, names decoration, counts durability, checks is quest item ///
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");

        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// decoration interation ///
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine($"The {name} has been broken.");
        else if (isQuestItem == true)
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        else
            Console.WriteLine($"You look at the {name}. Not much to see here.");
    }

    /// decoration break ///
    public void Break()
    {
        durability--;

        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        else if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        else
            Console.WriteLine($"The {name} is already broken.");
    }
}

/// Class Key ///
public class Key : Base, ICollectable
{
    /// key is collectable ///
    public bool isCollected {get;set;}

    /// key constructor, names key, checks is collected ///
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    /// key collect ///
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
            Console.WriteLine($"You have already picked up the {name}.");
    }
}