﻿using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        int dec = 16;
        string[] numbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", };
        string hex = "";
        while (dec > 0)
        {
            int index = dec % 16;
            hex = numbers[index] + hex;
            dec /= 16;
        }
        Console.WriteLine(hex);
    }
}

