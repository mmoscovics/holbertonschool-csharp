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

/// Class TestObject inherits from Base and interfaces ///
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    /// Interact ///
    public void Interact() {}
    /// durability ///
    public int durability {get;set;}
    /// Break ///
    public void Break() {}
    /// collected ///
    public bool isCollected {get;set;}
    /// Collect ///
    public void Collect() {}
}
