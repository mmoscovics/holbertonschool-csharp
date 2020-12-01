using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = 0;
            for (numb = 1; numb < 89; numb++)
            {
                if (numb < 89 && numb / 10 < numb % 10)
                    Console.Write($"{numb:00}, ");
            }
            Console.Write($"{numb:00}\n");
        }
    }
}
