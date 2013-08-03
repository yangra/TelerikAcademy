//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("The year {1} is {0}", DateTime.IsLeapYear(year)?"leap":"not leap", year);
    }
}

