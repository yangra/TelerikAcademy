//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, 
//if there’s no such element. Use the method from the previous exercise.

using System;

class FirstElement
{
    static bool isBiggerThanNeightbours(int[] array, int index)
    {
        return index > 0 && index < array.Length - 1 && 
                array[index] > array[index + 1] && array[index] > array[index - 1];
    }

    static int ReturnFirstIndex(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (isBiggerThanNeightbours(array, i))
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 0, 2, 3, 8, 12, 6, 5 };
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int result = ReturnFirstIndex(arr);
        Console.WriteLine(result==-1?"There is no such element!":"The first element bigger than its neighbours is on position: {0} ", result);
    }
}

