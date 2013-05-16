//Write a program that gets a number n and after that gets more n numbers and 
//calculates and prints their sum. 

using System;

class SumNNumbers
{
    static void Main()
    {
        int sum = 0;
        Console.WriteLine("Insert number of numbers:");
        int numbers = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum of all numbers is: {0}", sum);
    }
}
