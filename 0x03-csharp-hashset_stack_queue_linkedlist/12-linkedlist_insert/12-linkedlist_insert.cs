using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current = myLList.First;
        LinkedListNode<int> new_node = new LinkedListNode<int>(n);
        if (myLList == null)
        {
            myLList.AddFirst(new_node);
            return new_node;
        }
        if (current.Value > n)
        {
            myLList.AddBefore(current, new_node);
            return new_node;
        }
        while (current.Next != null)
        {
            if (current.Next.Value >= n)
                break;
            current = current.Next;
        }
        myLList.AddAfter(current, new_node);
        return new_node;
    }
}