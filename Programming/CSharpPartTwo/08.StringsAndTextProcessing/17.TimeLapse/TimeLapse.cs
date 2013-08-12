﻿//Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

using System;
using System.Globalization;

class TimeLapse
{

    static void Main()
    {
        Console.WriteLine("Please enter a date and time in format (day.month.year hour:minute:second): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        date = date.AddHours(6.5);
        Console.WriteLine("{0} {1}", date.ToString("d.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                                     date.ToString("dddd", CultureInfo.GetCultureInfo("bg-BG")));
    }
}

