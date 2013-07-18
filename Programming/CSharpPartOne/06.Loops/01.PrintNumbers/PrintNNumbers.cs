//Write a program that prints all the numbers from 1 to N.

using System;

class PrintNNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0,3}", i);
        }
        Console.WriteLine();
    }
}

