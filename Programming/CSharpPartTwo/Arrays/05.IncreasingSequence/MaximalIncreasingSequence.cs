//Write a program that finds the maximal increasing sequence in an array. 
//Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


using System;
using System.Collections.Generic;

class MaximalIncreasingSequence
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
            if (elements[i] == elements[i - 1] + 1 && i != 1)
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
        for (int i = maximal - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.Write(element);
            }
            else
            {
                Console.Write("{0},", element - i);
            }

        }
        Console.WriteLine("}");
    }
}

