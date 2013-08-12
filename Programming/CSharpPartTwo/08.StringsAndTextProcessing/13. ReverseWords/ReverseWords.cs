//Write a program that reverses the words in given sentence.
//Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

using System;
using System.Collections;
using System.Text.RegularExpressions;

class ReverseWords
{
    static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        string blanks = @"[\p{P}\s-[#]][\s]*";
        Stack words = new Stack();
        foreach (var word in Regex.Split(text, blanks))
        {
            if (!String.IsNullOrEmpty(word)) words.Push(word);
        }
        foreach (Match n in Regex.Matches(text, blanks))
        {
            Console.Write("{0}{1}", words.Pop(), n);
        }
        Console.WriteLine();
    }
}

