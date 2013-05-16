//Write a program that reads two positive integer numbers and prints how many 
//numbers p exist between them such that the reminder of the division by 
//5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class CountFactors
{
    static void Main()
    {
        int firstNumber = 0;
        int secondNumber = 0;
        int counter = 0;
        int bigger = 0;

        Console.WriteLine("Insert positive integer:");
        while (!int.TryParse(Console.ReadLine(), out firstNumber)
            || firstNumber < 0)
        {
            Console.WriteLine("You entered invalid number! Please try again!");
            Console.WriteLine("Insert positive integer:");
        }
        Console.WriteLine("Insert another positive integer:");
        while (!int.TryParse(Console.ReadLine(), out secondNumber)
            || secondNumber < 0)
        {
            Console.WriteLine("You entered invalid number! Please try again!");
            Console.WriteLine("Insert another positive integer:");
        }
        bigger = Math.Max(firstNumber, secondNumber);
        if (bigger != secondNumber)
        {
            firstNumber = secondNumber;
            secondNumber = bigger;
        }
        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine("p[{0}, {1}] = {2}", firstNumber, secondNumber, counter);
    }
}
