//Write a program that reads two integer numbers N and K and an array of N elements 
//from the console. Find in the array those K elements that have maximal sum.

using System;

class MaximalSubSum
{
    static void Main()
    {
        Console.Write("Please enter number of elements: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter size of subset: ");
        int K = int.Parse(Console.ReadLine());
        
        int[] array = new int[N];
        int[] result = new int[K];
        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            Console.Write("Element{0}:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < K ; i++)
        {
            int max = int.MinValue;
            int index = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                    index = j;
                }
            }
            result[i] = max;
            array[index] = int.MinValue;
        }
        for (int i = 0; i < result.Length; i++)
        {
            sum += result[i];
            if (i == result.Length - 1)
            {
                Console.WriteLine("{0} = {1}", result[i], sum);
            }
            else
            {
                Console.Write("{0} + ", result[i]);
            }
        }
    }
}

