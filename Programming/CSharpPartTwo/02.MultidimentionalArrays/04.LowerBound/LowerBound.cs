//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the 
//method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class LowerBound
{
    static void Main()
    {
        int k = 999999;
        int[] array = { 4, 5, 1, 18, 2, 4, 12, 9, 8, 7, 13, 45, 34, 1000000 };
        int index=0;
        int element = 0;
        Array.Sort(array);
        Console.Write("Sorted array: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        for (int i = k; i >= 0; i--)
        {
           index = Array.BinarySearch(array, i);
           if (index <0)
           {
               continue;
           }
           element = array[index];
            break;
        }
        Console.WriteLine("The largest number of the array less than {0} is {1} with index {2}",k,element,index);
    }
}

