//Extend the program to support also subtraction and multiplication of polynomials.

using System;

class PolinomialsExtended
{
    static int[] Add(int[] a, int[] b)
    {
        int size = Math.Max(a.Length, b.Length);
        int[] result = new int[size];
        Print(a);
        Print(b);
        for (int i = 0; i < size; i++)
        {
            result[i] = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0);
        }
        return result;
    }

    static int[] Substract(int[] a, int[] b)
    {
        int size = Math.Max(a.Length, b.Length);
        int[] result = new int[size];
        Print(a);
        Print(b);
        for (int i = 0; i < size; i++)
        {
            result[i] = (i < a.Length ? a[i] : 0) - (i < b.Length ? b[i] : 0);
        }
        while (size>0)
        {
            if(result[size-1]!=0 ) break; 
            else Array.Resize(ref result,size-1);
            size--;
        }
        return result;
    }

    static int[] Multiply(int[] a, int[] b)
    {
        int size = a.Length + b.Length - 1;
        int[] result = new int[size];
        if(a.Length>b.Length) return Multiply(b,a);
        Print(a);
        Print(b);
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < b.Length; j++)
            {
                result[i + j] += a[i] * b[j];
            }
        }
        return result;
    }

    static void Print(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i]!=0)
            {
                Console.Write("{0}*x^{1}", array[i], i);
            }
            if (i != 0&&array[i]!=0&&array[i-1]>0)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Print(Add(new int[] { 5, 0, 1 }, new int[] { 4, 2, 0, 5, 12 }));
        Console.WriteLine();

        Print(Substract(new int[] { 5, 0, 1, 3, 12 }, new int[] { 4, 2, 0, 5, 12 }));
        Console.WriteLine();

        Print(Multiply(new int[] { 0, 7, 1 }, new int[] { 3, 1, 0, 3, 2 }));
        Console.WriteLine();
    }
}

