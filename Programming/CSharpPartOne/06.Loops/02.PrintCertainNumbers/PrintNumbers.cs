//Write a program that prints all the numbers from 1 to N, that are not divisible 
//by 3 and 7 at the same time.

using System;

class PrintNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                continue;
            }
            Console.Write("{0,3}", i);
        }
        Console.WriteLine();
    }
}

