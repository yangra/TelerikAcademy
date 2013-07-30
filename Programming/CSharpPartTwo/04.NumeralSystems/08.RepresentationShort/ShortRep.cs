//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;

class ShortRep
{
    static void Main()
    {
        Console.Write("Please enter a short decimal number [-32 768 - 32 767]: ");
        short dec = short.Parse(Console.ReadLine());
        byte[] binRep = new byte[16];
        byte index = 0;
        if (dec<0)
        {
            binRep[15] = 1;
            dec = (short)((short.MaxValue + dec) + 1);
        }
        while (dec > 0)
        {
            binRep[index] = (byte)(dec % 2);
            dec /= 2;
            index++;
        }
        for (int i = 15; i >= 0; i--)
        {
            Console.Write(binRep[i]);
        }
        Console.WriteLine();
    }
}

