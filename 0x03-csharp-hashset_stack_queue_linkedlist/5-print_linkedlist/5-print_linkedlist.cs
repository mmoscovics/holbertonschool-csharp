using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> new_llist = new LinkedList<int>();
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(i);
            new_llist.AddLast(i);
        }
        return new_llist;
    }
}