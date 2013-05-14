using System;

class TrapezoidArea
{
    static void Main()
    {
        double sideA = 5;
        double sideB = 12;
        double height = 4;

        double trapezoidArea = ((sideA + sideB) / 2) * height;
        Console.WriteLine(trapezoidArea);
    }
}

