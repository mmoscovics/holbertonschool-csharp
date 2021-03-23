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
        public T value = default(T);
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

    /// Returns number of nodes in the Queue ///
    public int Count()
    {
        return count;
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

    /// Removes first node in the queue and returns its value ///
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    /// Returns value of first node of queue ///
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
            return head.value;
    }

    /// Prints the queue from head ///
    public void Print()
    {
        Node temp = head;
        if (head == null)
            Console.WriteLine("Queue is empty");
        while (temp != null)
        {
            Console.WriteLine(temp.value);
            temp = temp.next;
        }
    }
}