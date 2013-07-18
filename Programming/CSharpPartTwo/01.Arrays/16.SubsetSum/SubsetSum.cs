//* We are given an array of integers and a number S. Write a program to find if there 
//exists a subset of the elements of the array that has a sum S. 
//Example:   arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 1, 2, 4, 3, 5, 2, 6 };
        bool exists = false;
        List<int> sums = new List<int>();
        List<List<int>> allIndices = new List<List<int>>();
        int sum = 14;
        for (int i = 0; i < arr.Length; i++)
        {
            int limit = sums.Count;
            List<int> iteration = new List<int>();
            iteration.Add(i);
            for (int j = 0; j < limit; j++)
            {
                List<int> indices = new List<int>();
                sums.Add(sums[j] + arr[i]);
                foreach (var item in allIndices[j])
                {
                    indices.Add(item);
                }
                indices.Add(i);
                allIndices.Add(indices);
            }
            sums.Add(arr[i]);
            allIndices.Add(iteration);

        }
        for (int i = 0; i < allIndices.Count; i++)
        {
            if (sums[i] == sum)
            {
                exists = true;
                Console.Write(exists ? "Yes " : "No ");
                Console.Write("{");
                foreach (var item in allIndices[i])
                {
                    Console.Write("{0} ", arr[item]);
                }
                Console.Write("}");
                Console.WriteLine();
                break;
            }
        }
        
        
    }
}

