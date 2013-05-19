//Write a program to print the first 100 members of the sequence of 
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class Fibonacci
{
    static void Main()
    {
        int counter = 0;
        decimal number = 0L;
        decimal nextNumber = 1L;

        while (counter < 50)
        {
            Console.WriteLine("{0}", number);
            Console.WriteLine("{0}", nextNumber);
            number += nextNumber;
            nextNumber += number;
            counter++;
        }
    }
}

