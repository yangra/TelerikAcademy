//Write a program that reads from the console a string of maximum 20 characters. 
//If the length of the string is less than 20, the rest of the characters should be 
//filled with '*'. Print the result string into the console.

using System;

class PadAsterisk
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a text up to 20 symbols: ");
        string read = Console.ReadLine();
        if (read.Length>20)
        {
            Console.WriteLine("Invalid length!");
            return;
        }
        read = read.PadRight(20, '*');
        Console.WriteLine(read);
    }
}

