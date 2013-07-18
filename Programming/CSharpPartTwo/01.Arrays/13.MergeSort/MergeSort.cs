//* Write a program that sorts an array of integers using the merge sort algorithm 
// (find it in Wikipedia).

using System;
using System.Collections.Generic;

class MergeSort
{
    static List<int> DoMergeSort(List<int> arr)
    {
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        if (arr.Count <= 1)
        {
            return arr;
        }
        int middle = arr.Count / 2;
        for (int i = 0; i < arr.Count; i++)
        {
            if (i < middle)
            {
                left.Add(arr[i]);
            }
            else
            {
                right.Add(arr[i]);
            }
        }
        left = DoMergeSort(left);
        right = DoMergeSort(right);
        return Merge(left, right);
    }

    static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.Remove(left[0]);
                }
                else
                {
                    result.Add(right[0]);
                    right.Remove(right[0]);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.Remove(left[0]);
            }
            else if (right.Count > 0)
            {
                result.Add(right[0]);
                right.Remove(right[0]);
            }
        }
        return result;
    }

    static void Main()
    {
        int[] array = { 821, 16, 34, 7, 23, 45, 34, 16, 18, 3, 56, 321, 25, 17, 456, -12, -91, -16, 0 };
        List<int> arr = new List<int>(array);
        arr = DoMergeSort(arr);
        foreach (var item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

