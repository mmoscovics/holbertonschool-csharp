using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] td_array = new int[5, 5];
            td_array[2, 2] = 1;
            for (int i = 0; i < td_array.GetLength(0); i++)
            {
                for (int j = 0; j < td_array.GetLength(1); j++)
                {
                    Console.Write(td_array[i, j]);
                    if (j < td_array.GetLength(1) - 1)
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
