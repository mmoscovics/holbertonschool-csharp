using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine("");
        for (int line = 0; line < length; line++)
        {
            for (int space = 0; space < line; space++)
                Console.Write(" ");
            Console.WriteLine("\\");
        }
    }
}