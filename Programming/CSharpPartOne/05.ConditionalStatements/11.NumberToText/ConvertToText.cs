//* Write a program that converts a number in the range [0...999] to a text corresponding 
//to its English pronunciation. Examples:
//    0 -> "Zero"
//    273 -> "Two hundred seventy three"
//    400 -> "Four hundred"
//    501 -> "Five hundred and one"
//    711 -> "Seven hundred and eleven"

using System;

class ConvertToText
{
    static void Main()
    {
        string toText = "";
        string[] digits = { "zero", "one", "two", "three", "four", "five", "six",
                              "seven", "eight", "nine", "ten", "eleven","twelve", 
                          "thirteen", "fourteen", "fifteen", "sixteen", "seventeen",
                          "eighteen", "nineteen" };
        string[] tenths = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy",
                              "eighty", "ninety"};
        Console.WriteLine("Please enter a number between 0 and 999:");
        int number = int.Parse(Console.ReadLine());
        
        if (number / 100 > 0)
        {
            toText = digits[number / 100] + " hundred ";
        }
        if (number > 99 && number % 100 > 0)
        {
            toText += "and ";
        }
        if (number % 100 > 19) 
        {
            toText += tenths[((number%100)/10)-2] + " ";
        }
        if (number % 100 > 9 && number % 100 < 20)
        {
            toText += digits[number % 100];
        }
        else if ((number % 100) % 10 > 0 && (number % 100) % 10 < 10 )
        {
            toText += digits[(number % 100) % 10];
        }
        
        char[] arr = toText.ToCharArray();
        arr[0] = (char)(arr[0] - 32);
        toText = new string (arr);
        Console.WriteLine(toText);
    }
}


