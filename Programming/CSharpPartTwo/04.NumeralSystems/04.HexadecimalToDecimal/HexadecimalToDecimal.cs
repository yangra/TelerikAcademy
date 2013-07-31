//Write a program to convert hexadecimal numbers to their decimal representation.

using System;

class HexadecimalToDecimal
{
    static char[] digits = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F', };
    
    static int FindIndex(char digit)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digit == digits[i])
            {
                return i;
            }
        }
        return -1;
    }

    static int ConvertToDec(string hex)
    {
        int powerOf16 = 1;
        int dec = 0;
        for (int i = 0; i < hex.Length; i++)
        {
            dec += (FindIndex(hex[i])) * powerOf16;
            powerOf16 *= 16;
        }
        return dec;
    }

    static void Main()
    {
        string hex = "FFF";
   
        Console.WriteLine(ConvertToDec(hex));
    }
}

