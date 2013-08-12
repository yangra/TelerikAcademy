//Write a program for extracting all email addresses from given text. All substrings that match the format 
//<identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Text.RegularExpressions;

class ExtractEmail
{
    static void Main(string[] args)
    {
        string text = "You can find me at do_you84@be-there.bg but another address is _bemine@monk.gbg " +
                      "The funny thing is tilda@sudo.co.uk is already full to the brim";
        string pattern = @"\b[a-zA-Z_][a-zA-Z0-9_]+@[a-zA-Z0-9]([a-zA-Z0-9-]+\.)+[a-zA-Z]{2,4}\b";
        foreach (Match m in Regex.Matches(text, pattern))
        {
            Console.WriteLine(m);
        }
    }
}

