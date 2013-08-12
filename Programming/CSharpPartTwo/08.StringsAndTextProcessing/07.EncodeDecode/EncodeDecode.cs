//Write a program that encodes and decodes a string using given encryption key (cipher). 
//The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) 
//operation over the first letter of the string with the first of the key, the second – with the second, etc.
//When the last key character is reached, the next is the first.

using System;
using System.Text;

class EncodeDecode
{
    static string Encode(string input, string key)
    {
        StringBuilder encoded = new StringBuilder(input.Length);
        for (int i = 0; i < input.Length; )
        {
            for (int j = 0; i < input.Length && j < key.Length; j++, i++)
            {
                char code = (char)(input[i] ^ key[j]);
                encoded.Append(code);
            }
        }
        return encoded.ToString();
    }

    static string Decode(string input, string key)
    {
        return Encode(input, key);
    }

    static void Main()
    {
        string text = "Write a program that encodes and decodes a string using given encryption key (cipher). " +
            "The key consists of a sequence of characters. The encoding/decoding is done by performing XOR " +
            "(exclusive or) operation over the first letter of the string with the first of the key, " +
            "the second – with the second, etc. When the last key character is reached, the next is the first.";
        string key = "45&#x)(go";
        text = Encode(text, key);
        Console.WriteLine(text);
        text = Decode(text, key);
        Console.WriteLine(text);
    }
}

