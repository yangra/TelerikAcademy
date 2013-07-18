//Write a program that reads two arrays from the console and compares them element by element.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter the size of array1: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the size of array2: ");
        int m = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[m];
        bool identical = true;

        

        if (n!=m)
        {
            identical = false;
        }
        else
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array1 element[{0}]: ", i);
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array2 element[{0}]: ", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] != array2[i])
                {
                    identical = false;
                    break;
                }
            }
        }
        if (identical)
        {
            Console.WriteLine("The arrays are identical!"); 
        }
        else
        {
            Console.WriteLine("Those arrays are different!");
        }
    }
}

