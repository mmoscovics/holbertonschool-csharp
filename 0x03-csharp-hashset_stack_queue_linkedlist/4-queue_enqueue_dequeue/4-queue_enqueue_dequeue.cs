using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        aQueue.Enqueue(newItem);
        Console.WriteLine($"Queue contains \"{search}\": {aQueue.Contains(search)}");
        if (aQueue.Contains(search))
        {
            int target = 0;
            while (target == 0)
            {
                if (aQueue.Peek().Equals(search))
                    target += 1;
                aQueue.Dequeue();
            }
        }
        return aQueue;
    }
}