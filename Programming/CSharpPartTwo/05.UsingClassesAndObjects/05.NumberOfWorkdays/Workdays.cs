//Write a method that calculates the number of workdays between today and given date, passed as parameter. 
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays 
//specified preliminary as array.

using System;

class Workdays
{
    static DateTime[] publicHolidays = { 
                                         new DateTime(2013, 1, 1), 
                                         new DateTime(2013, 3, 3), 
                                         new DateTime(2013, 5, 1), 
                                         new DateTime(2013, 5, 3), 
                                         new DateTime(2013, 5, 4), 
                                         new DateTime(2013, 5, 5), 
                                         new DateTime(2013, 5, 6), 
                                         new DateTime(2013, 5, 24), 
                                         new DateTime(2013, 9, 6), 
                                         new DateTime(2013, 9, 22), 
                                         new DateTime(2013, 12, 24), 
                                         new DateTime(2013, 12, 25), 
                                         new DateTime(2013, 12, 26) 
                                       };
    static int RemovePublicHolidays(DateTime date, int numberOfDays)
    {
        for (int j = 0; j < publicHolidays.Length; j++)
        {
            if (date.Day == publicHolidays[j].Day
                && date.Month == publicHolidays[j].Month
                && date.Year == publicHolidays[j].Year
                && publicHolidays[j].DayOfWeek != DayOfWeek.Saturday
                && publicHolidays[j].DayOfWeek != DayOfWeek.Sunday)
            {
                numberOfDays--;
            }
        }
        return numberOfDays;
    }

    static int NumberWorkdays(DateTime end)
    {
        DateTime today = DateTime.Now;
        int result = (int)(end - today).TotalDays;
        int limit = result;
        DateTime day = today;
        for (int i = 0; i < limit; i++)
        {
            day = day.AddDays(1);
            if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
            {
                result--;
            }
            result = RemovePublicHolidays(day, result);
        }
        return result;
    }

    static void Main(string[] args)
    {
        DateTime end = new DateTime(2013, 10, 31);
        Console.WriteLine("Between {0} and {1} there are {2} workdays.", 
            DateTime.Now.Date.ToString("dd/MM/yyyy"), end.Date.ToString("dd/MM/yyyy"), NumberWorkdays(end));
       
    }
}
