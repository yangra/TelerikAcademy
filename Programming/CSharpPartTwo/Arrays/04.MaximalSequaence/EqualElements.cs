//Write a program that finds the maximal sequence of equal elements in an array.
//	Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;
using System.Collections.Generic;

class EqualElements
{
    static void Main()
    {
        List<string> array = new List<string>();
        Console.WriteLine("Please enter the elements of the array separated by comas:");
        array = new List<string>(Console.ReadLine().Split(','));

        int[] elements = new int[array.Count + 1];
        int length = 1;
        int maximal = 1;
        int element = 0;

        for (int i = 1; i < elements.Length; i++)
        {
            elements[i] = int.Parse(array[i - 1]);
            if (elements[i] == elements[i - 1] && i != 1)
            {
                length++;
                if (length > maximal)
                {
                    maximal = length;
                    element = elements[i];
                }
            }
            else
            {
                length = 1;
            }
        }
        Console.Write("{");
        for (int i = 0; i < maximal; i++)
        {
            if (i == maximal - 1)
            {
                Console.Write(element);
            }
            else
            {
                Console.Write("{0},", element);
            }

        }
        Console.WriteLine("}");


    }
}

