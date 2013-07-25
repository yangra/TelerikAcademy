//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class ReversedDigits
{
    static string ReverseDigits(string number)
    {
        number.ToCharArray();
        char[] rev = new char[number.Length];
        for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
        {
            rev[j] = number[i];
        }
        string reversed = new string(rev);
        return reversed;
    }

    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = Console.ReadLine();
        Console.WriteLine(ReverseDigits(number));
    }
}

