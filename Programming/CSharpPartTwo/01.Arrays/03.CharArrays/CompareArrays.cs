//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Please enter number of elemnts for the first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number of elemnts for the second array: ");
        int m = int.Parse(Console.ReadLine());
        char[] array1 = new char[n];
        char[] array2 = new char[m];
        int commonLength = 0;
        bool identical = true;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Array1 - element{0}: ", i);
            array1[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < m; i++)
        {
            Console.Write("Array2 - element{0}: ", i);
            array2[i] = char.Parse(Console.ReadLine());
        }
        if (n > m)
        {
            commonLength = m;
        }
        else
        {
            commonLength = n;
        }
        for (int i = 0; i < commonLength; i++)
        {
            if (array1[i] != array2[i])
            {
                if (array1[i] > array2[i])
                {
                    identical = false;
                    Console.WriteLine("Array2 is lexicogrphically first.");
                    break;
                }
                else
                {
                    identical = false;
                    Console.WriteLine("Array1 is lexicogrphically first.");
                    break;
                }
            }
        }
        if (identical && m != n)
        {
            if (m > n)
            {
                identical = false;
                Console.WriteLine("Array1 is lexicogrphically first.");
            }
            else
            {
                identical = false;
                Console.WriteLine("Array2 is lexicogrphically first.");
            }
        }

        if (identical)
        {
            Console.WriteLine("The arrays are equal.");
        }
    }
}

