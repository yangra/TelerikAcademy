//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
//Use variable number of arguments.

using System;

class MinMaxSumProduct
{
    static int GetMax( params int[] array) 
    { 
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }
        return array[maxIndex];
    }

    static int GetMin( params int[] array)
    {
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<array[minIndex])
            {
                minIndex = i;
            }
        }
        return array[minIndex];
    }

    static double GetAverage(params int[] array)
    {
        return Convert.ToDouble(GetSum(array)) / array.Length;
    }

    static int GetSum(params int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int GetProduct(params int[] array)  
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static void Main()
    {
        Console.WriteLine(GetMin(1, 2, 3));
        Console.WriteLine(GetMax(1, 2, 3));
        Console.WriteLine(GetAverage(4, 5, 4, 5, 4, 5));
        Console.WriteLine(GetSum(5, 6, 12, 8));
        Console.WriteLine(GetProduct(1, 2, 3, 4, 5, 6));
    }
}

