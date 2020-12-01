using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numb = 0; numb < 99; numb++)
                Console.Write($"{numb} = 0x{numb:x}\n");
        }
    }
}
