//Write a program to calculate the sum (with accuracy of 0.001): 
//1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class CalculateSum
{
    static void Main()
    {
        decimal sum = 1.0m;
        for (decimal i = 2.0m; i < 20001; i++)
        {
            decimal number = Math.Round(1 / i, 4);
            sum += number;
        }
        Console.WriteLine(sum);
    }
}
