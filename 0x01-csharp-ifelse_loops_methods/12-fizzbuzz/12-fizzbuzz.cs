using System;


class Program
{
    static void Main(string[] args)
    {
        for (int num = 1; num <= 100; num++)
        {
            if (num % 15 == 0)
                Console.Write("FizzBuzz");
            else if (num % 5 == 0)
                Console.Write("Buzz");
            else if (num % 3 == 0)
                Console.Write("Fizz");
            else
                Console.Write(num);
            if (num < 100)
                Console.Write(" ");
            else
                Console.WriteLine("");
        }
    }
}
