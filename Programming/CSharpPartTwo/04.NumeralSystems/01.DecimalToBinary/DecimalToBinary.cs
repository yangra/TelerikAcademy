//Write a program to convert decimal numbers to their binary representation.

using System;

class DecimalToBinary
{
    //Converts decimal to binary integer with two's complement system
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int dec = int.Parse(Console.ReadLine());
        byte index = 0;
        byte[] bin = new byte[32];
        if (dec < 0)
        {
            bin[31] = 1;
            dec = (int.MaxValue + dec) + 1;
        }
        while (dec > 0)
        {
            bin[index] = (byte)(dec % 2);
            dec /= 2;
            index++;
        }
        for (int i = 31; i >= 0; i--)
        {
            Console.Write(bin[i]);
        }
        Console.WriteLine();
    }
}

