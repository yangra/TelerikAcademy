//* Write a program that reads an array of integers and removes from it a minimal number
// of elements in such way that the remaining array is sorted in increasing order. 
// Print the remaining sorted array. 
// Example:  {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

using System;
using System.Collections.Generic;

class ArraySort
{
    static List<int> indices = new List<int>();
    static List<int> result = new List<int>();
    static int max = 0;

    static void Max() 
    {
        if (indices.Count > max)
        {
            max = indices.Count;
            result.Clear();
            for (int l = 0; l < indices.Count; l++)
            {
                result.Add(indices[l]);
            }
        }
    }


    static void Traverse(int[] array) 
    {
        for (int i = 0; i < array.Length; i++)
        {
            indices.Add(array[i]);
            Max();
            Search(array, i);
            indices.Remove(indices[indices.Count - 1]);
        }
    }

    static void Search(int[] array, int i)
    {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] <= array[j])
                {
                    indices.Add(array[j]);
                    Max();
                    Search(array,j);
                    indices.Remove(indices[indices.Count-1]);
                }
                
            }
    }

    static void Main()
    {
        Console.Write("Please enter the number of elements of the array: ");
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.Write("Enter element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Traverse(array);
        foreach (var item in result)
        {
            Console.Write("{0} ", item);
        }

    }
}

