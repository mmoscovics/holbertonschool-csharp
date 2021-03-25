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