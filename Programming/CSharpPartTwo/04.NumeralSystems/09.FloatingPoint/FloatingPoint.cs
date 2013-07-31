//* Write a program that shows the internal binary representation of given 32-bit signed floating-point 
//number in IEEE 754 format (the C# type float). 
//Example: -27,25 -> sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.

using System;

class FloatingPoint
{
    static float mantissa = 0f;
    static byte GetSign(float num)
    {
        if (num < 0) return 1;
        return 0;
    }

    static string ExpToBinary(int num)
    {
        string result = "";
        for (int i = 0; i < 8; i++)
        {
            result = (char)(num % 2 + '0') + result;
            num /= 2;
        }
        return result;
    }

    static string GetExponent(float num)
    {
        int exp = 0;
        if (num < 0)
        {
            num *= -1;
        }
        while (num >= 2)
        {
            exp++;
            num /= 2;
        }
        while (num < 1 && num != 0)
        {
            exp--;
            num *= 2;
        }
        exp += 127;
        mantissa = num;
        return ExpToBinary(exp);
    }

    static string GetMantissa(float mantissa)
    {
        string result = "";
        mantissa -= 1;
        float power = 0.5f;
        for (int i = 0; i < 23; i++)
        {
            if (mantissa >= power)
            {
                result += '1';
                mantissa -= power;
            }
            else
            {
                result += '0';
            }
            power /= 2;
        }
        return result;
    }

    static void Main()
    {
        float number = -27.25f;
        if (number > float.MaxValue || number < float.MinValue)
        {
            Console.WriteLine("Illegal number!");
            return;
        }
        Console.WriteLine("sign = {0}", GetSign(number));
        Console.WriteLine("exponent = {0}", GetExponent(number));
        Console.WriteLine("mantissa = {0}", GetMantissa(mantissa));
    }
}

