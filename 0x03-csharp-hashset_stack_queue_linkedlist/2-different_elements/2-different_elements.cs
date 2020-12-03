using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> common_set = new HashSet<int>(list1);
        common_set.SymmetricExceptWith(list2);
        List<int> common_list = new List<int>(common_set);
        common_list.Sort();
        return common_list;
    }
}