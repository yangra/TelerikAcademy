//Write a program that finds the most frequent number in an array. 
//Example:	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)


using System;

class Frequency
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int finalElement = 0;
        int finalNumber = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int number = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    number++;
                }
                if (number > finalNumber)
                {
                    finalNumber = number;
                    finalElement = arr[i];
                }
            }
        }

        Console.WriteLine("{0} ({1} times)", finalElement, finalNumber);
    }
}

