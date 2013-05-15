//Write an expression that checks for given point (x, y) if it is within the 
//circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, 
//height=2).

using System;

class WithinCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter an x coordinate:");
        int pointX = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter an y coordinate:");
        int pointY = int.Parse(Console.ReadLine());

        
        int radius = 3;
        // formula for checking if point is within a circle 
        //(x-center_x)^2 + (y - center_y)^2 < radius^2
        int diffX = pointX-1;
        int diffY = pointY-1;

        //Let's assume theat points from the lines of the figures are inside them
        bool isWithinCircle = (diffX * diffX) + (diffY * diffY) <= (radius * radius);
        bool isWithinRectangle = (pointY <= 1 && pointY >= -1) 
                                && (pointX >= -1 && pointX <= 5);

        if (isWithinCircle && isWithinRectangle)
        {
            Console.WriteLine("The point is within both figures.");
        }
        else if (!isWithinCircle && !isWithinRectangle)
        {
            Console.WriteLine("The point is  outside both figures.");
        }
        else if (isWithinCircle && !isWithinRectangle)
        {
            Console.WriteLine("The point is within the circle and out of the rectangle.");
        }
        else if (!isWithinCircle && isWithinRectangle)
        {
            Console.WriteLine("The point is within rectangle and out of the circle.");
        }
    }
}

