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

        Console.WriteLine(ReturnFirstIndex(arr));
    }
}

