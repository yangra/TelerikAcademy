//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;

class HexToBin
{
    static int ConvertToNumber(char digit)
    {
        if (digit >= 'A')
        {
            return digit - 'A' + 10;
        }
        return digit - '0';
    }

    static string ToBinary(string number)
    {
        string binary = "";
        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = ConvertToNumber(number[i]);
            for (int j = 0; j < 4; j++)
            {
                binary = digit % 2 + binary;
                digit /= 2;
            }
        }
        return binary;
    }

    static void Main()
    {

        string hex = "0123456789ABCDEF";
        Console.WriteLine(ToBinary(hex));

    }
}

