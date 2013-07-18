//Write a program that, for a given two integer numbers N and X, calculates 
//the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

using System;

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine("Please enter number N (N > 0):");
        double numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number X (X != 0):");
        double numX = int.Parse(Console.ReadLine());
        double result = 1;
        int factorial = 1;
        double power = 1;

        for (int i = 1; i <= numN; i++)
        {
            factorial *= i;
            power *= numX;
            result += factorial / power;
            
        }
        Console.WriteLine("The result is: {0}", result);

    }
}

