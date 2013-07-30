//Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;

class BinToHex
{
    static string binary = "1011111";
    static int index = binary.Length-1;

    static int ToNum()
    {
        int digit = 0;
        for (int i = 1; i < 9; i*=2)
        {
            if (index == -1)
            {
                return digit;
            }

            digit += (binary[index] - '0') * i;
            index--;
        }
        return digit;
    }

    static char ToHexNum(int digit)
    {
        if (digit<10)
        {
            return (char)(digit + '0');
        }
        return (char)('A'+ digit - 10);
    }

    static void Main()
    {
        
        string hex = "";
        for (int i = 0; i <= binary.Length/4; i++)
        {
            hex = ToHexNum(ToNum()) + hex;
        }
        Console.WriteLine(hex);
        
        
    }
}

