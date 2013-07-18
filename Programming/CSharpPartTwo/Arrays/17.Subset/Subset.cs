//* Write a program that reads three integer numbers N, K and S and an array of N elements 
//from the console. Find in the array a subset of K elements that have sum S or indicate 
//about its absence.

using System;
using System.Collections.Generic;

class Subset
{
    static void Main()
    {
        Console.Write("Please enter number of elements in the array: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter number of subset elements elements: ");
        int K = int.Parse(Console.ReadLine());
        Console.Write("Please enter sum of subset elements: ");
        int sum = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int powerOf2 = 1;
        int temp = 0;
        int count = 0;
        bool exists = false;
        List<int> subset = new List<int>();
        for (int i = 0; i < array.Length; i++)
        {
            powerOf2 *= 2;
        }
        for (int i = 1; i < powerOf2; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if ((i & (1 << j)) >= 1) 
                {
                    temp += array[j];
                    count++;
                }
            }
            if (temp == sum && count == K)
            {
                exists = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if ((i & (1 << j)) >= 1)
                    {
                        subset.Add(array[j]);
                    }
                }
                break;
            }
            count = 0;
            temp = 0;
        }
        if (exists)
        {
            Console.Write("There is at least one such subset: ");
            for (int i = 0; i < subset.Count; i++)
            {
                Console.Write("{0} ", subset[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("No such subsets exist!");
        }
        
    }
}

