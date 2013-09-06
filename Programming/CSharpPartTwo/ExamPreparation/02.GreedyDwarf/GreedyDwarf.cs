using System;
using System.Collections.Generic;
using System.Numerics;

class GreedyDwarf
{
    public static int[] ReadArray()
    {
        string[] raw = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] processed = new int[raw.Length];

        for (int i = 0; i < processed.Length; i++)
        {
            processed[i] = int.Parse(raw[i]);
        }
        return processed;
    }
    static void Main()
    {
        checked
        {
            BigInteger sum = 0;
            BigInteger maxSum = long.MinValue;

            int[] valley = ReadArray();

            int numberOfPatterns = int.Parse(Console.ReadLine());
            List<int[]> patterns = new List<int[]>();
            for (int i = 0; i < numberOfPatterns; i++)
            {
                int[] pattern = ReadArray();
                patterns.Add(pattern);
            }

            for (int i = 0; i < patterns.Count; i++)
            {
                bool[] usedIndex = new bool[valley.Length];
                int index = 0;
                bool isTerminated = false;
                while (!isTerminated)
                {
                    for (int j = 0; j < patterns[i].Length; j++)
                    {
                        if (index >= valley.Length|| index < 0 || usedIndex[index] == true)
                        {
                            isTerminated = true;
                            break;
                        }
                        sum += valley[index];
                        usedIndex[index] = true;
                        index += patterns[i][j];
                    }
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine(maxSum);
        } 
    }
}

