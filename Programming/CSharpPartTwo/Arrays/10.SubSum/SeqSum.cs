//Write a program that finds in given array of integers a sequence of given sum S (if present). 
//Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;
using System.Collections.Generic;

class SeqSum
{
    static void Main(string[] args)
    {
        int[] array = { 4, 3, 1, 4, 2, 5, -5, 8, 3, 11, 0, 10, 1, 10, -10 };
        
        List<List<int>> combinations = new List<List<int>>();
        for (int i = 0; i < array.Length; i++)
        {
            int sum = 0;
            for (int j = i; j < array.Length; j++)
            {
                sum += array[j];
                if (sum == 11)
                {
                    List<int> combination = new List<int>();
                    for (int m = i; m <= j; m++)
                    {
                        combination.Add(array[m]);
                    }
                    combinations.Add(combination);
                }
            }
        }
        foreach (var sublist in combinations)
        {
            foreach (var item in sublist)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }
    }
}

