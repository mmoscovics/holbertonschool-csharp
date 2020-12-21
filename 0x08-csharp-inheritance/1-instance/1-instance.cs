using System;

/// Base Obj class
class Obj
{
    /// Check if obj is an instance of or inherited from Array
    /// Returns true or false
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj.GetType().IsArray)
            return true;
        return false;
    }
}
