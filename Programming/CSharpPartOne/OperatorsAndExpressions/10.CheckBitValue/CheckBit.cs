//Write a boolean expression that returns if the bit at position p (counting from 0)
//in a given integer number v has value of 1. 
//Example: v=5; p=1 -> false.

using System;

class CheckBit
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        bool checkBit = (number & mask) != 0;
        Console.WriteLine(checkBit);
    }
}

