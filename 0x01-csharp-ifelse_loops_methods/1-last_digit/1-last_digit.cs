using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string str = "The last digit of ";
        int ld = number % 10;
        if (ld > 5)
            Console.WriteLine($"{str}{number} is {ld} and is greater than 5");
        else if (ld < 6 && !(ld == 0))
            Console.WriteLine($"{str}{number} is {ld} and is less than 6 and not 0");
        else
            Console.WriteLine($"{str}{number} is {ld} and is 0");
    }
}