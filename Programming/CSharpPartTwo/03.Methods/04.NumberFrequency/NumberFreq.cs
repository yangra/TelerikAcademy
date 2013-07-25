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
        int[] array = new int[20];
        int num = 5;
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = num;
        }
        Console.WriteLine(NumFreq(array, num)); 
    }
}

