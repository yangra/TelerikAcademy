//* Write a program that reads a number N and generates and prints all the permutations 
//  of the numbers [1 … N]. 
//  Example:  n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;

class Permutations
{
    static void Swap(ref int a, ref int b) 
    {
        if (a == b) return;
        a ^= b;
        b ^= a;
        a ^= b;
    }

    static void Permute(int[] array, int begin, int end) 
    {
        if (begin == end)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = begin; i <= end; i++)
            {
                Swap(ref array[begin-1], ref array[i-1]);
                Permute(array,begin+1,end);
                Swap(ref array[begin-1], ref array[i-1]);
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive number:");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 1; i <= N; i++)
        {
            array[i - 1] = i;
        }
        Permute(array, 1, N);
    }
}

