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

