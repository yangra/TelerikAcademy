//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestOfFive
{
    static void Main()
    {
        int first = 30;
        int second = 5;
        int third = 22;
        int fourth = 6;
        int fifth = 18;
        int maxValue = first;

        if (second > maxValue)
        {
            maxValue = second;  
        }
        if (third > maxValue)
        {
            maxValue = third;
        }
        if (fourth > maxValue)
        {
            maxValue = fourth;
        }
        if (fifth > maxValue)
        {
            maxValue = fifth;
        }
        Console.WriteLine("The greatest number is {0}", maxValue);
    }
}

