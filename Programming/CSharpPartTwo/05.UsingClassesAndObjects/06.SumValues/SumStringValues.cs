//You are given a sequence of positive integer values written into a string, separated by spaces. 
//Write a function that reads these values from given string and calculates their sum. 
//Example:    string = "43 68 9 23 318" -> result = 461

using System;

    class SumStringValues
    {
        static void Main()
        {
            string input = "43 68 9 23 318";
            string[] array = input.Split(' ');
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += int.Parse(array[i]);
            }
            Console.WriteLine("Result is: {0}", sum);
        }
    }

