using System;

/// Base Obj class
class Obj
{
    /// Check if obj is instances or inherits from subclass
    /// Returns true or false
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}