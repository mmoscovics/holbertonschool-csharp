using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");
        if (aStack.Contains(search))
        {
            int target = 0;
            while (target == 0)
            {
                if (aStack.Peek().Equals(search))
                    target += 1;
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}