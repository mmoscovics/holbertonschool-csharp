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