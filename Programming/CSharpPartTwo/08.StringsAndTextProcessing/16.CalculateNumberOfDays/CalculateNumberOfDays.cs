//Write a program that reads two dates in the format: day.month.year and calculates the number of days 
//between them. Example:
//   Enter the first date: 27.02.2006
//   Enter the second date: 3.03.2004
//   Distance: 4 days

using System;
using System.Globalization;

class CalculateNumberOfDays
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
        var difference = secondDate.Date - firstDate.Date;
        Console.WriteLine("Distance: {0} days", difference.Days);
    }
}

