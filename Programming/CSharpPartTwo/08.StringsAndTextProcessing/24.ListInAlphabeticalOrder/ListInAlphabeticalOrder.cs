//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class ListInAlphabeticalOrder
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a list of words separated by spaces: ");
        string[] words = Console.ReadLine().Split(' ');
        Array.Sort(words);
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}

