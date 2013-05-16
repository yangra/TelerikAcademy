//Write a program that reads 3 integer numbers from the console and 
//prints their sum.

using System;

class ReadPrintConsole
{
    static void Main()
    {
        int firstInteger = 0;
        int secondInteger = 0;
        int thirdInteger = 0;


        Console.WriteLine("Please enter integer 1:");
        while (!int.TryParse(Console.ReadLine(), out firstInteger))
        {
            Console.WriteLine("You entered invalid number! Try again! {0}Please enter integer 1:",
                Environment.NewLine);
        }
        Console.WriteLine("Please enter integer 2:");
        while (!int.TryParse(Console.ReadLine(), out secondInteger))
        {
            Console.WriteLine("You entered invalid number! Try again! {0}Please enter integer 2:",
                Environment.NewLine);
        }
        Console.WriteLine("Please enter integer 3:");
        while (!int.TryParse(Console.ReadLine(), out thirdInteger))
        {
            Console.WriteLine("You entered invalid number! Try again! {0}Please enter integer 3:",
                Environment.NewLine);
        }

        Console.WriteLine("{0} + {1} + {2} = {3}",firstInteger,
            secondInteger,thirdInteger,firstInteger+secondInteger+thirdInteger);
        
    }
}

