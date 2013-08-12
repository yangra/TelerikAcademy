//Write a program that reads a string from the console and replaces all series of consecutive 
//identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

using System;

class RemoveRepeats
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a string with repeating characters: ");
        string text = Console.ReadLine();
        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == text[i - 1])
            {
                text = text.Remove(i, 1);
                i--;
            }
        }
        Console.WriteLine(text);
    }
}

