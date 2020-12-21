using System;

/// Base Obj class
class Obj
{
    /// Check if obj is int, return true or false
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}