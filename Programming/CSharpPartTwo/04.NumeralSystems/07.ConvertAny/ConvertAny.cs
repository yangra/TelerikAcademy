//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;

class ConvertAny
{
    static int GetNumber(char digit)
    {
        if (digit > '9')
        {
            return digit - 'A' + 10;
        }
        return digit - '0';
    }

    static char GetChar(int digit)
    {
        if (digit < 10)
        {
            return (char)(digit + '0');
        }
        return (char)(digit + 'A' - 10);
    }

    static long ConvertXTo10(string number, int baseX)
    {
        long result = 0;
        for (int i = number.Length - 1, power = 1; i >= 0; i--, power *= baseX)
        {
            result += GetNumber(number[i]) * power;
        }
        return result;
    }

    static string Convert10ToY(long base10, int baseY)
    {
        string result = "";
        while (base10 > 0)
        {
            int digit = 0;
            digit = (int)(base10 % baseY);
            result = GetChar(digit) + result;
            base10 /= baseY;
        }
        return result;
    }

    static string ConvertBaseXToBaseY(string number, int baseX, int baseY)
    {
        return Convert10ToY(ConvertXTo10(number, baseX), baseY);
    }

    static void Main()
    {
        Console.WriteLine(ConvertBaseXToBaseY("AB123BA", 12, 15));
    }
}

