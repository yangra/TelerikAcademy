//Write a program that finds the biggest of three integers using nested if statements.

using System;

class FindBiggest
{
    static void Main()
    {
        int firstInt;
        int secondInt;
        int thirdInt;
        Console.WriteLine("Enter an integer:");
        while(!int.TryParse(Console.ReadLine(),out firstInt))
        {
            Console.WriteLine("You entered an invalid integer, try again!");
        }
        Console.WriteLine("Enter another integer:");
        while(!int.TryParse(Console.ReadLine(), out secondInt))
        {
            Console.WriteLine("You entered an invalid integer, try again!");
        }
        Console.WriteLine("Enter third integer:");
        while(!int.TryParse(Console.ReadLine(), out thirdInt))
        {
            Console.WriteLine("You entered an invalid integer, try again!");
        }

        if (firstInt > secondInt)
        {
            if (firstInt > thirdInt)
            {
                Console.WriteLine("The biggest integer is: {0}", firstInt);
            }
            else
            {
                Console.WriteLine("The biggest integer is: {0}", thirdInt);
            }
        }
        else 
        {
            if (secondInt > thirdInt)
            {
                Console.WriteLine("The biggest integer is: {0}", secondInt);
            }
            else 
            {
                Console.WriteLine("The biggest integer is: {0}", thirdInt);
            }
        }
    }
       
}


