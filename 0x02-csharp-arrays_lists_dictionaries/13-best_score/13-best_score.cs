using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count < 1)
            return "None";
        return myList.Aggregate((val1, val2) => val1.Value > val2.Value ? val1 : val2).Key;
    }
}