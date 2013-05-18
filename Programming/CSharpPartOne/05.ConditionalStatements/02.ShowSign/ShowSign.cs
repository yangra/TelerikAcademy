//Write a program that shows the sign (+ or -) of the product of three real 
//numbers without calculating it. Use a sequence of if statements.

using System;

class ShowSign
{
    static void Main()
    {
        Console.WriteLine("Enter real number:");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter real number:");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter real number:");
        double thirdNumber = double.Parse(Console.ReadLine());
        int negative = 0;


        if (firstNumber == 0 || secondNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("The product is zero.");
        }
        else
        {
            if (firstNumber < 0)
            {
                negative++;
            }
            if (secondNumber < 0)
            {
                negative++;
            }
            if (thirdNumber < 0)
            {
                negative++;
            }
            if (negative == 3 || negative == 1)
            {
                Console.WriteLine("The product is negative.");
            }
            else
            {
                Console.WriteLine("The product is positiive.");
            }
        }
    }
}

