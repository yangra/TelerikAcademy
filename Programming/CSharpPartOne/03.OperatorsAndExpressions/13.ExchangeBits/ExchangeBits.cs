//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of 
//given 32-bit unsigned integer.

using System;

class ExchangeBits
{
    static int[] GetBits(uint number,int numberOfBits, int position) 
    {

        uint mask = 1;
        mask <<= position;
        int[] bits = new int[numberOfBits];
        for (int i = 0; i < numberOfBits; i++)
        {
            uint masked = number & mask;
            if (masked > 0) bits[i] = 1;
            else bits[i] = 0;
            mask <<= 1;
        }
        return (bits);
    }

    static uint SetBits(uint number,int[] bits,int numberOfBits, int position) 
    {
        uint mask = 1;
        mask <<= position;
        for (int i = 0; i < numberOfBits; i++)
        {
            if (bits[i] == 1)
            {
                number = mask | number;
            }
            else 
            {
                number = ~mask & number;
            }
            mask <<= 1;
        }
        return(number);
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int[] firstThreeBits = GetBits(number, 3, 3);
        int[] secondThreeBits = GetBits(number, 3, 24);
        number = SetBits(number,firstThreeBits,3,24);
        number = SetBits(number, secondThreeBits, 3, 3);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

