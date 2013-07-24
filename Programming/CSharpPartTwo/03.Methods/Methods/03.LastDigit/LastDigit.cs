using System;

class LastDigit
{
    static string ReturnLastDigit(int number)
    {
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int digit = number % 10;
        return digits[digit];
    }

    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit in your number is: {0}", ReturnLastDigit(number));
    }
}

