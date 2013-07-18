//Write a program that reads from the console a sequence of N integer numbers 
//and returns the minimal and maximal of them.

using System;

class ReturnMinMax
{
    static void Main()
    {
        Console.Write("Please enter the length of the sequence:");
        int seqLength = int.Parse(Console.ReadLine());
        int minimum = int.MaxValue;
        int maximum = int.MinValue;

        for (int i = 1; i <= seqLength; i++)
        {
            Console.WriteLine("Please enter the #{0} number", i);
            int number = int.Parse(Console.ReadLine());
            if (number < minimum)
            {
                minimum = number;
            }
            if (number > maximum )
            {
                maximum = number;
            }
        }
        Console.WriteLine("The maximum number entered is: {0}", maximum);
        Console.WriteLine("The minimum number entered is: {0}", minimum);
    }
}

