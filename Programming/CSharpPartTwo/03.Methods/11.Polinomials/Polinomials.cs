//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//		x2 + 5 = 1x2 + 0x + 5 -> 5, 0, 1

using System;

class Polinomials
{
    static int[] Add(int[] a, int[] b)
    {
        int size = Math.Max(a.Length,b.Length);
        int[] result = new int[size];
        Print(a);
        Print(b);
        for (int i = 0; i < size; i++)
        {
            result[i] = (i < a.Length ? a[i] : 0) + (i < b.Length ? b[i] : 0);
        }
        return result;
    }

    static void Print(int[] array)
    {
        for (int i = array.Length-1; i >= 0; i--)
        {
            if (array[i] != 0)
            {
                Console.Write("{0}*x^{1}", array[i], i);
            }
            if (i!= 0&&array[i]!=0)
            {
                Console.Write(" + ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Print(Add(new int[] { 5, 0, 1 }, new int[] { 4, 2, 0, 5, 12 }));
    }
}

