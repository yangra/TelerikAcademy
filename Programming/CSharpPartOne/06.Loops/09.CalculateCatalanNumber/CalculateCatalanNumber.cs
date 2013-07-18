//In the combinatorial mathematics, the Catalan numbers are calculated by the following 
//formula:
//Cn = 2n!/(n+1)!n!
//Write a program to calculate the Nth Catalan number by given N.

using System;
using System.Numerics;

class CalculateCatalanNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter a number (N > 0)");
        int numN = int.Parse(Console.ReadLine());

        BigInteger divident = 1;
        BigInteger divisor = 1;

        numN -= 1;

        for (int i = numN + 2; i <= 2*numN; i++)
        {
            divident *= i;
        }
        for (int i = 1; i <= numN; i++)
        {
            divisor *= i;
        }
       
        Console.WriteLine("The #{0} Catalan number is: {1}", numN+1, divident/divisor);
    }
}

