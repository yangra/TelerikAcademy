//Write a boolean expression that checks for given integer if it can be divided
//(without remainder) by 7 and 5 in the same time.

using System;

class Divisible
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        bool divisible = number % 5 == 0 && number % 7 == 0;
        Console.WriteLine(divisible);
    }
}

