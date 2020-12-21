using System;

/// Base class
class Shape
{
    /// throw exception
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}