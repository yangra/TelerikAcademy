//Write a method that returns the last digit of given integer as an English word. 
//Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".

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

