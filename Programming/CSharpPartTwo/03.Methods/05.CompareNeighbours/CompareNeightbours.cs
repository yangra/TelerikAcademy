//Write a method that checks if the element at given position in given array of integers is bigger than its 
//two neighbors (when such exist).

using System;

class CompareNeightbours
{
    static bool isBigger(int[] array, int index)
    {
        return (index > 0 && index < array.Length - 1 && 
                array[index] > array[index - 1] && array[index] > array[index + 1]);
    } 

    static void Main()
    {
        int[] arr = { 2, 5, 7, 3, 2, 8, 16 };
        Console.WriteLine(isBigger(arr,2));
    }
}

