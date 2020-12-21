using System;
using System.Reflection;

/// Base Obj class
class Obj
{
    /// Prints name of available properties and methods
    public static void Print(object myObj)
    {
        Console.WriteLine($"{myObj.GetType().Name} Properties:");
        foreach (var prop in myObj.GetType().GetProperties())
            Console.WriteLine(prop.Name);

        Console.WriteLine($"{myObj.GetType().Name} methods:");
        foreach (var meth in myObj.GetType().GetMethods())
            Console.WriteLine(meth.Name);
    }
}