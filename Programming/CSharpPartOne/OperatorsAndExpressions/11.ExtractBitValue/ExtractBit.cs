//Write an expression that extracts from a given integer i the value of a given 
//bit number b. Example: i=5; b=2 -> value=1.

using System;

class ExtractBit
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a position:");
        int bitPosition = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;
        int masked = mask & number;
        int bitValue = masked >> bitPosition;
        Console.WriteLine(bitValue);

    }
}

