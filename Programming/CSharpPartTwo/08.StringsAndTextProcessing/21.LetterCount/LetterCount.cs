//Write a program that reads a string from the console and prints all different letters in the string 
//along with information how many times each letter is found. 

using System;
using System.Collections.Generic;

class LetterCount
{
    static void Main()
    {
        int[] count = new int[65536];
        Console.WriteLine("Please enter text here: ");
        string text = Console.ReadLine();
        for (int i = 0; i < text.Length; i++)
        {
            count[(int)(text[i])]++;
        }
        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] > 0)
            {
                Console.WriteLine("Letter \"{0}\" {1} time(s)", (char)(i), count[i]);
            }
        }
    }
}

