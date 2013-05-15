//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("This number is even!");
        }
        else 
        {
            Console.WriteLine("This number is odd!");
        }
    }
}

