//* Modify your last program and try to make it work for any number type, not just integer 
//(e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).

using System;

class GenericMinMaxSumProduct
{
    static T GetMax<T>( params T[] array) where T:IComparable<T>
    { 
        int maxIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[maxIndex]) > 0)
            {
                maxIndex = i;
            }
        }
        return array[maxIndex];
    }

    static T GetMin<T>( params T[] array) where T:IComparable<T>
    {
        int minIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CompareTo(array[minIndex]) < 0)
            {
                minIndex = i;
            }
        }
        return array[minIndex];
    }

    static double GetAverage<T>(params T[] array)
    {
        return Convert.ToDouble(GetSum(array)) / array.Length;
    }

    static T GetSum<T>(params T[] array)
    {
        dynamic sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static T GetProduct<T>(params T[] array)  
    {
        dynamic product = 1;
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

