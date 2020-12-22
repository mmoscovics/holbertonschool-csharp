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

/// Rectangle ingerits from Shape
class Rectangle : Shape
{
    /// Private fields
    private int width;
    private int height;

    /// Public properties with getter and setter
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

    /// Area override
    public override int Area()
    {
        return width * height;
    }

    /// String override
    public override string ToString()
    {
        return ($"[Rectangle] {width} / {height}");
    }
}