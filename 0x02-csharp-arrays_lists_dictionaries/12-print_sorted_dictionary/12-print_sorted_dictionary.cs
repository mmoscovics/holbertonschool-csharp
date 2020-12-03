using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> key_list = myDict.Keys.ToList();
        key_list.Sort();
        foreach(string key in key_list)
            Console.WriteLine($"{key}: {myDict[key]}");
    }
}