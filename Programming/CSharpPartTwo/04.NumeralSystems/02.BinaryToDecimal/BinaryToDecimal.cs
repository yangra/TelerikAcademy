//Write a program to convert binary numbers to their decimal representation.

using System;

class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Please enter a positive binary integer: ");
        long binary = long.Parse(Console.ReadLine());
        uint powerOf2 = 1;
        int dec = 0;
        while (binary!=0)
        {
            dec += (int)((binary % 10) * powerOf2);
            binary /= 10;
            powerOf2 *= 2;
        }
        Console.WriteLine(dec);
    }
}

