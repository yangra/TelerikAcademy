using System;

class ExchangeAnyBits
{
    static int[] GetBits(uint number, int numberOfBits, int position)
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

    static uint SetBits(uint number, int[] bits, int numberOfBits, int position)
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
        return (number);
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer:");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number of bits:");
        int numberOfBits = int.Parse(Console.ReadLine());
        Console.WriteLine("Please first position of bits:");
        int firstPosition = int.Parse(Console.ReadLine());
        Console.WriteLine("Please second position of bits:");
        int secondPosition = int.Parse(Console.ReadLine());

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        int[] firstBits = GetBits(number,numberOfBits,firstPosition);
        int[] secondBits = GetBits(number, numberOfBits, secondPosition);
        number = SetBits(number, firstBits, numberOfBits, secondPosition);
        number = SetBits(number, secondBits, numberOfBits, firstPosition);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

