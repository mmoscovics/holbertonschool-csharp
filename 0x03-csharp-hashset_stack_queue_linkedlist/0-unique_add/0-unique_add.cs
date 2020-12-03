using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> unique_numb = new HashSet<int>();
        int total = 0;
        foreach (int number in myList)
            unique_numb.Add(number);
        foreach (int i in unique_numb)
            total += i;
        return total;
    }
}