using System;

class ReversedDigits
{
    static string ReverseDigits(string number)
    {
        number.ToCharArray();
        string reversed = new string('-', number.Length);
        char[] rev = reversed.ToCharArray();
        for (int i = number.Length - 1, j = 0; i <= 0; i++, j++)
        {
            rev[j] = number[i];
        }
        reversed = rev.ToString();
        return reversed;
    }
    static void Main()
    {
        Console.Write("Please enter a number: ");
        string number = Console.ReadLine();
        Console.WriteLine(ReverseDigits(number));
    }
}

