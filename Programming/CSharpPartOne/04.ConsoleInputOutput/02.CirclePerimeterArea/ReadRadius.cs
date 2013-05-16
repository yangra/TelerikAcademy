//Write a program that reads the radius r of a circle and prints its perimeter 
//and area.

using System;

class ReadRadius
{
    static void Main()
    {
        int radius;
        Console.WriteLine("Enter the radius of a circle:");
        while (!int.TryParse(Console.ReadLine(), out radius)) 
        {
            Console.WriteLine("You entered an invalid number, please try again!");
            Console.WriteLine("Enter the radius of a circle:");
        }

        double circlePerimeter = 2 * Math.PI * radius;
        double circleArea = Math.PI * radius * radius;
        Console.WriteLine("The area of the circle is: {0}", circleArea);
        Console.WriteLine("The perimeter of the circle is: {0}", circlePerimeter);
    }
}

