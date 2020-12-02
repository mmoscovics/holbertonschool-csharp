﻿using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] new_array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write(i);
            if (i < size - 1)
                Console.Write(" ");
        }
        Console.WriteLine("");
        return new_array;
    }
}