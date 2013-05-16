//Write a program to print the first 100 members of the sequence of 
//Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        int counter = 0;
        BigInteger number = 0;
        BigInteger nextNumber = 1;

        while (counter < 100)
        {
            Console.WriteLine("{0}", number);
            Console.WriteLine("{0}", nextNumber);
            number += nextNumber;
            nextNumber += number;
            counter++;
        }
    }
}

