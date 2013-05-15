using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Please enter length of side A:");
        double sideA = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter length of side B:");
        double sideB = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter height of trapezoid:");
        double height = double.Parse(Console.ReadLine());

        double trapezoidArea = ((sideA + sideB) / 2) * height;
        Console.WriteLine("Area of trapezoid is: {0}",trapezoidArea);
    }
}

