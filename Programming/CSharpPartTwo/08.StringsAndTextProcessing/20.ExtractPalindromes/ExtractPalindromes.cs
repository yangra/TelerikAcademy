//Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

using System;
using System.Text.RegularExpressions;
using System.Text;

class ExtractPalindromes
{
    static string[] words;

    static void GetList(string text)
    {
        string pattern = @"\w+";
        text = text.ToLower();
        var matches = Regex.Matches(text, pattern);
        words = new string[matches.Count];
        for (int i = 0; i < matches.Count; i++)
        {
            words[i] = matches[i].ToString();
        }
    }

    static string GetStaright(int index, int length)
    {
        StringBuilder straight = new StringBuilder();
        for (int i = index; i < index + length; i++)
        {
            straight.Append(words[i]);
        }
        return straight.ToString();
    }

    static string GetReverersed(string straight)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = straight.Length - 1; i >= 0; i--)
        {
            reversed.Append(straight[i]);
        }
        return reversed.ToString();
    }

    static void Print(int index, int length)
    {
        for (int i = index; i < index + length; i++)
        {
            Console.Write("{0} ", words[i]);
        }
        Console.WriteLine();
    }

    static void Search(string text)
    {
        GetList(text);
        int size = words.Length;
        for (int i = 0; i < size; i++)
        {
            for (int j = 1; j < size - i; j++)
            {
                string straight = GetStaright(i, j);
                string reversed = GetReverersed(straight);
                if (straight == reversed)
                {
                    Print(i, j);
                }
            }
        }
    }

    static void Main()
    {
        string text = "Seven eves. solos stats Stunt nuts. Halala bala";
        Search(text);
    }
}

