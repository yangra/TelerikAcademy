//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:
//   We are living in a yellow submarine. We don't have anything else. 
//   Inside the submarine is very tight. So we are drinking all the day. 
//   We will move out of it in 5 days.
//The expected result is:
//   We are living in a yellow submarine.
//   We will move out of it in 5 days.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

using System;
using System.Text.RegularExpressions;

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else. " +
                      "Inside the submarine is very tight. So we are drinking all the day. " +
                      "We will move out of it in 5 days. How to fit in there? In God's sake! Get in!";
        string word = "in";
        string pattern = @"\s?([^.!?]*\b" + word + @"\b.*?[.?!])";
        foreach (Match sentence in Regex.Matches(text, pattern, RegexOptions.IgnoreCase))
        {
            Console.WriteLine(sentence.Groups[1]);
        }    
    }
}

