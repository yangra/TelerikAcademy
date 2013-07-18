//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.

using System;

class WordIndex
{
    static void Main()
    {
        char[] alphabet = new char[52];
        alphabet[0] = 'A';
        for (int i = 1; i < 26; i++)
        {
            alphabet[i] = (char)(alphabet[i - 1] + 1);
        }
        alphabet[26] = 'a';
        for (int i = 27; i < 52; i++)
        {
            alphabet[i] = (char)(alphabet[i - 1] + 1);
        }
        for (int i = 0; i < 52; i++)
        {
            Console.Write(alphabet[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Please enter a word:");
        string word = Console.ReadLine();
        word.ToCharArray();
        int counter = 0;
        while (counter < word.Length)
        {
            int end = alphabet.Length - 1;
            int start = 0;
            while (true)
            {
                int index = (end + start) / 2;
                if (word[counter] == alphabet[index])
                {
                    Console.WriteLine("Letter {0} has index: {1}", word[counter], index);
                    break;
                }
                if (word[counter] > alphabet[index])
                {
                    start = index + 1;
                }
                else if (word[counter] < alphabet[index])
                {
                    end = index - 1;
                }
                if (end < start)
                {
                    Console.WriteLine("There is no such letter: {0}", word[counter]);
                    break;
                }
            }
            counter++;
        }

    }
}

