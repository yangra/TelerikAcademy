//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.

using System;

class MaximalElement
{
    static int ReturnMaxmalElement(int[] array, int startIndex)
    {
        int indexMax = 0;
        int max = int.MinValue;
        for (int i = startIndex; i >= 0; i--)
        {
            if (array[i] > max)
            {
                indexMax = i;
                max = array[i];
            }
        }
        return indexMax;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void Sort(int[] array, bool asc)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Swap(array, i, ReturnMaxmalElement(array, i));
        }
        if (!asc)
        {
            Array.Reverse(array);
        }      
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = { 56, 23, 13, 7, 3, 45, 12, 1, 67, 0, 5, 3, 7, 12 };
        Print(array);
        Console.WriteLine();

        Sort(array, true);
        Print(array);
        Console.WriteLine();

        Sort(array, false);
        Print(array);
        Console.WriteLine();
    }
}
