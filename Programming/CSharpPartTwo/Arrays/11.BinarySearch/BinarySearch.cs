//Write a program that finds the index of given element in a sorted array of integers 
//by using the binary search algorithm (find it in Wikipedia).

using System;

class BinarySearch
{
    static void Main()
    {
        int[] array = { -23, -12, -6, -1, 1, 2, 3, 4, 5, 6, 7, 8, 10, 12, 16, 18, 19, 25, 64, 231 };
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            if (i == array.Length - 1)
            {
                Console.Write(array[i]);
            }
            else
            {
                Console.Write("{0},", array[i]);
            }
        }
        Console.WriteLine("}");
        Console.WriteLine("Please enter a number to find its index in the above array:");
        int key = int.Parse(Console.ReadLine());
        int start = 0;
        int end = array.Length - 1;
        while (true)
        {
            int index = (start + end) / 2;
            if (key == array[index])
            {
                Console.WriteLine("The index of {0} is : {1}", key, index);
                break;
            }
            if (key > array[index])
            {
                start = index + 1;
            }
            else if (key < array[index])
            {
                end = index - 1;
            }
            if (end < start)
            {
                Console.WriteLine("No such element!");
                break;
            }
        }

    }
}

