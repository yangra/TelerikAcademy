using System;

class ThirdDigit7
{
    static void Main()
    {
        Console.WriteLine("Enter a more-than-three-digit integer:");
        int number = int.Parse(Console.ReadLine());


        bool thirdDigit7 = ((number / 100) % 10) == 7;
        Console.WriteLine(thirdDigit7);
    }
}

