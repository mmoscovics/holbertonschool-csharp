using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int ld = Math.Abs(number) % 10;
        Console.Write($"{ld}");
        return ld;
    }
}