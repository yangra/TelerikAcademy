//Write a program that reads a string from the console and lists all different words in the string 
//along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class CountWords
{
    static void Main()
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        string text = "Write a program that reads a string from the console and lists " +
                      "words in the string along with information how many times each word is found.";
        string pattern = @"\b\w+\b";
        foreach (Match word in Regex.Matches(text, pattern))
        {
            if (dict.ContainsKey(word.Value))
            {
                dict[word.Value]++;
            }
            else
            {
                dict.Add(word.Value, 1);
            }
        }
        foreach (var pair in dict)
        {
            Console.WriteLine("{0} {1} time(s)", pair.Key, pair.Value);
        }

    }
}

