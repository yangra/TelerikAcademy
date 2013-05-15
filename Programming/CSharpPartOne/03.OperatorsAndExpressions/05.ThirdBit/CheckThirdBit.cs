//Write a boolean expression for finding if the bit 3 (counting from 0) of
//a given integer is 1 or 0.

using System;

class CheckThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int num = int.Parse(Console.ReadLine());

        int mask = 1 << 3;
        bool afterMask = (num & mask) > 0;
        Console.WriteLine(afterMask);
    }
}

