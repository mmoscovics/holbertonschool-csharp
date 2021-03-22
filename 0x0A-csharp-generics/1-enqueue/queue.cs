using System;

/// Queue class ///
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count = 0;
    
    /// Node class ///
    public class Node
    {
        T value = default(T);
        public Node next = null;

        public Node(T val)
        {
            value = val;
        }
    }

    /// Check Queue's type ///
    public Type CheckType()
    {
        return typeof(T);
    }

    /// Creates new node and adds it to end of queue and update count ///
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
            head = newNode;
        if (tail != null)
            tail.next = newNode;
        tail = newNode;

        count++;
    }

    /// Returns number of nodes in the Queue ///
    public int Count()
    {
        return count;
    }
}