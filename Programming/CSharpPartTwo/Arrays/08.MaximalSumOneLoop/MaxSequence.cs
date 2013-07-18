//Write a program that finds the sequence of maximal sum in given array. 
//Example: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaxSequence
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        int maxSum = int.MinValue;
        int sum = arr[0];
        int start = 0;
        int startTemp = 0;
        int end = 0;
        for (int i = 1; i < arr.Length; i++)
        {
            sum += arr[i];
            if (arr[i] > sum)
            {
                sum = arr[i];
                startTemp = i;
            }
            if (sum > maxSum)
            {
                maxSum = sum;
                start = startTemp;
                end = i;
            }
        }
        for (int i = 0; i <= end - start; i++)
        {
            Console.Write("{0} ", arr[start + i]);
        }
        Console.WriteLine();
    }
}

