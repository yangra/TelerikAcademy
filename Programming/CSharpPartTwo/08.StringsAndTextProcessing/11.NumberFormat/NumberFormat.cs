//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage 
//and in scientific notation. Format the output aligned right in 15 symbols.

using System;

class NumberFormat
{
    static void Main()
    {
        Console.Write("Please enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15:d}", number);
        Console.WriteLine("{0,15:x}", number);
        Console.WriteLine("{0,15:p}", number);
        Console.WriteLine("{0,15:e}", number);
    }
}

