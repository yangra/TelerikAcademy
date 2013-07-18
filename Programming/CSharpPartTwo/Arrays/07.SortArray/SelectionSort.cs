//Sorting an array means to arrange its elements in increasing order. Write a program 
//to sort an array. Use the "selection sort" algorithm: Find the smallest element, 
//move it at the first position, find the smallest from the rest, move it at the second 
//position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        int[] array = { 56, 12, 8, 42, 9, 79, 789, 1, 252, 38, 14, 15, 61, 8, 96, 18, 54, 1, 7, 2 };
        int min = 0;
        int swap = 0;
        int index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            min = array[i];
            index = i;
            for (int j = i; j < array.Length; j++)
            {
                if (min > array[j])
                {
                    min = array[j];
                    index = j;
                }
            }
            swap = array[i];
            array[i] = min;
            array[index] = swap;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();


    }
}

