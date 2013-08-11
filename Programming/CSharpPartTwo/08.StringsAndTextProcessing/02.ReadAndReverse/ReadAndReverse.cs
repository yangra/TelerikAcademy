//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

using System;

class ReadAndReverse
{
    static void Main()
    {
        Console.Write("Please enter a text for reversal: ");
        string text = Console.ReadLine();
        for (int i = text.Length - 1; i >= 0; i--)
        {
            Console.Write(text[i]);
        }
        Console.WriteLine();
    }
}

