using System;

/// Abstrct Class Base ///
public abstract class Base
{
    /// name ///
    public string name {get;set;}

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
    /// durability ///
    public int durability {get;set;}
    /// collected ///
    public bool isCollected {get;set;}
    /// Interact ///
    public void Interact() {}
    /// Break ///
    public void Break() {}
    /// Collect ///
    public void Collect() {}
}
