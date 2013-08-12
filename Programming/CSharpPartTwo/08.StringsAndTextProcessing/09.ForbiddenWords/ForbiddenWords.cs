//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:
//   Microsoft announced its next generation PHP compiler today. 
//   It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//   Words: "PHP, CLR, Microsoft"
//The expected result:
//   ********* announced its next generation *** compiler today. 
//   It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

using System;
//using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        string list = "PHP, CLR, Microsoft";
        char[] separator = { ' ', ',' };
        string[] forbidden = list.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        string text = "Microsoft announced its next generation PHP compiler today. It is based on " +
                      ".NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        for (int i = 0; i < forbidden.Length; i++)
        {
            string code = new string('*', forbidden[i].Length);
            text = text.Replace(forbidden[i], code);
        }
        //text = Regex.Replace(text, list.Replace(", ", "|"), m => new string('*', m.Length));
        Console.WriteLine(text);
    }
}

