//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
//Sample input: Hi!
//Expected output: \u0048\u0069\u0021

using System;

class ConvertToUnicodeChar
{
    static void Main(string[] args)
    {
        string text = "Hi!";
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(String.Format(@"\u{0:X4}", (int)text[i]));
        }
        Console.WriteLine();
    }
}

