//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;

class DivideFactorials
{
    static void Main()
    {
        Console.WriteLine("Please enter number K (K > 1):");
        int numK = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number N (N > K):");
        int numN = int.Parse(Console.ReadLine());
        int calculated = 1;

        for (int i = numK+1; i <= numN; i++)
        {
            calculated *= i;
        }

        Console.WriteLine("The calculated N!/K! = {0}", calculated);
    }
}

