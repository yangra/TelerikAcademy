//Write a method that adds two positive integer numbers represented as arrays of digits 
//(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
//Each of the numbers that will be added could have up to 10 000 digits.

using System;

class AddArraysMethod
{
    static int[] result;

    static void Print(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void CheckOverflow(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 9)
            {
                array[i + 1] += 1;
                array[i] %= 10;
            }
        }
    }

    static int[] AddArrays(int[] a, int[] b)
    {
        int size = Math.Max(a.Length, b.Length) + 1;
        result = new int[size];
        if (a.Length < b.Length) return AddArrays(b, a);
        Print(a);
        Print(b);
        for (int i = 0; i < a.Length; i++)
        {
            result[i] = a[i];
        }
        for (int i = 0; i < b.Length; i++)
        {
            result[i] += b[i];
        }
        CheckOverflow(result);
        if (result[result.Length - 1] == 0)
        {
            Array.Resize(ref result, result.Length - 1);
        }
        return result;


    }

    static void Main()
    {
        Print(AddArrays(new int[] { 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9, 9 }));
        Console.WriteLine();

        Print(AddArrays(new int[] { 9, 9, 9 }, new int[] { 9, 9, 9, 9, 9 }));
        Console.WriteLine();

        Print(AddArrays(new int[] { 1, 1, 1, 1, 1 }, new int[] { 7, 7, 7, 7, 7 }));
        Console.WriteLine();

        Print(AddArrays(new int[] { 0, 0, 0, 0, 1 }, new int[] { 9, 9 }));
    }
}

