//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

class PointWithinCircle
{
    static void Main()
    {
        Console.WriteLine("Enter an x coordinate:");
        int pointX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an y coordinate:");
        int pointY = int.Parse(Console.ReadLine());

        int radius = 5;

        if (pointX * pointX + pointY * pointY > radius * radius) 
        {
            Console.WriteLine("The point is outside the circle.");
        }
         else if (pointX * pointX + pointY * pointY < radius * radius)
        {
            Console.WriteLine("The point is inside the circle.");
        }
        else 
        {
            Console.WriteLine("The point lies on the circle.");
        }
    }
}

