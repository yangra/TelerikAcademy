//Write a method that counts how many times given number appears in given array. Write a test program to 
//check if the method is working correctly.

using System;

class NumberFreq
{
    static int NumFreq(int[] array, int num)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (num == array[i])
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int[] array = new int[] {1, 4, 5, 2, 5, 8, 5};
        int num = 5;
        Console.WriteLine("{0} times", NumFreq(array, num)); 
    }
}

