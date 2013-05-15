//* Write a program to read your age from the console and print 
//how old you will be after 10 years.

using System;

class TenYearsLater
{
    static void Main()
    {
        Console.WriteLine("Enter your age and press Enter:");
        byte currentAge = byte.Parse(Console.ReadLine());
        if (currentAge < 0 || currentAge > 120)
        {
            Console.WriteLine("You entered invalid age!");
        }
        else
        {
            byte age10YearsLater = (byte)(currentAge + 10);
            Console.WriteLine("Your age after 10 years will be: {0}", age10YearsLater);
        }
    }
}


