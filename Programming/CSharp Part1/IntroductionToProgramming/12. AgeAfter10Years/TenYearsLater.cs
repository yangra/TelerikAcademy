using System;

class TenYearsLater
{
    static void Main()
    {
        Console.WriteLine("Enter your age and press Enter:");
        int currentAge = int.Parse(Console.ReadLine());
        if (currentAge < 0 || currentAge > 120)
        {
            Console.WriteLine("You entered invalid age!");
        }
        else
        {
            int age10YearsLater = currentAge + 10;
            Console.WriteLine("Your age after 10 years will be: {0}", age10YearsLater);
        }
    }
}


