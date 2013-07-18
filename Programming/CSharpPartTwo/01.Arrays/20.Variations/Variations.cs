//Write a program that reads two numbers N and K and generates all the variations of K elements 
//from the set [1..N]. 
//Example:  N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;
using System.Collections.Generic;


class Variations
{
    static uint N;
    static uint K;
    static int[] variation;

    static void Variate(uint iteration)
    {
        if (iteration == K)
        {
            for (int i = 0; i < variation.Length; i++)
            {
                Console.Write("{0} ", variation[i]);
            }
            Console.WriteLine();
            return;
        }
        for (int i = 1; i <= N; i++)
        {
            variation[iteration] = i;
            Variate(iteration+1);
        }
    }

    static void Main()
    {
        Console.Write("Please enter a positive number: ");
        N = uint.Parse(Console.ReadLine());
        Console.Write("Please enter the size of variation: ");
        K = uint.Parse(Console.ReadLine());
        variation = new int[K];

        Variate(0);
    }
}

