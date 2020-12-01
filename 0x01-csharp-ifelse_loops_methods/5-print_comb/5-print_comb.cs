using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numb = 0; numb < 100; numb++)
                if (numb < 99)
                    Console.Write($"{numb:00}, ");
                else
                    Console.Write($"{numb}\n");
        }
    }
}
