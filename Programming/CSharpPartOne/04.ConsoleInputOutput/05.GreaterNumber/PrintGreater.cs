//Write a program that gets two numbers from the console and prints the greater 
//of them. Don’t use if statements.

using System;

class PrintGreater
{
    static void Main()
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double maxNumber = 0;
        Console.WriteLine("Enter a number:");
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            Console.WriteLine("You entered invalid number! Please try again!");
            Console.WriteLine("Enter a number:");
        }
        Console.WriteLine("Enter another number:");
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            Console.WriteLine("You entered invalid number! Please try again!");
            Console.WriteLine("Enter another number:");
        }
        maxNumber = Math.Max(firstNumber, secondNumber);
        Console.WriteLine("The greater number is : {0}", maxNumber);

    }
}
