//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class Program
{
    static int GetRandomValue(Random rnd)
    {
        int randomNumber = rnd.Next(100, 201);
        return randomNumber;
    }

    static void Main()
    {
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            Console.Write(" {0}", GetRandomValue(rnd));
        }
        Console.WriteLine();
    }
}

