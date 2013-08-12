//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//   .NET – platform for applications from Microsoft
//   CLR – managed execution environment for .NET
//   namespace – hierarchical organization of classes

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Dictionary
{
    static Dictionary<string, string> dict = new Dictionary<string, string>();

    static void FillDictionary()
    {
        string raw = ".NET – platform for applications from Microsoft" +
                     "\r\nCLR – managed execution environment for .NET" +
                     "\r\nnamespace – hierarchical organization of classes";
        string term = @"(.*?)\s–\s(.*)";
        MatchCollection matches = Regex.Matches(raw, term);
        foreach (Match m in matches)
        {
            dict.Add(m.Groups[1].Value, m.Groups[2].Value);
        }
    }

    static void Search(string word)
    {
        if (dict.ContainsKey(word))
        {
            Console.WriteLine(dict[word]);
        }
        else
        {
            throw new ArgumentException("No such term in dictionary!");
        }
    }

    static void Main()
    {
        try
        {
            FillDictionary();
            Search(".NET");
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }

    }
}

