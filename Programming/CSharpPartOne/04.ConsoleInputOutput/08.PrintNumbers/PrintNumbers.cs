//Write a program that reads an integer number n from the console and prints 
//all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbers
{
    static void Main(string[] args)
    {
        int number = 0;
        Console.WriteLine("Please enter a positive integer");
        while (!int.TryParse(Console.ReadLine(), out number)
            || number < 0)
        {
            Console.WriteLine("You entered an invalid number! Please try again!");
            Console.WriteLine("Please enter a positive integer");
        }
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
