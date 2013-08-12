//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.

using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class ExtractDates
{
    static void Main()
    {
        string text = "Today 23.12.2018 is a sunny day. Tomorrow 23.10.20018 will rain. " +
                      "August 7.08.1978 is very important date. Boo watch up on 18.18.2013";
        string pattern = @"\b[0-3][0-9]\.[0-1][0-9]\.[0-9]{4}\b";
        Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
        DateTime date;
        foreach (Match m in Regex.Matches(text, pattern))
        {
            if (DateTime.TryParseExact(m.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                Console.WriteLine(date.ToShortDateString());
            //Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}

