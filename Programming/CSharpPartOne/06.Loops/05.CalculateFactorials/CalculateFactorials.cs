//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class CalculateFactorials
{
    static void Main()
    {
        Console.WriteLine("Please enter number N (N > 1):");
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number K (K > N):");
        int numK = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = numK - numN + 1;

        for (int i = 1; i <= numN; i++)
        {
            factorialN *= i;
        }
        for (int j = numK - numN + 2; j <= numK; j++)
        {
            factorialK *= j;
        }
        Console.WriteLine("The answer is {0}", factorialN*factorialK);
    }
}

