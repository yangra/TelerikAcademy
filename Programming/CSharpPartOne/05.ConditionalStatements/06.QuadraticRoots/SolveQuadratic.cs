//Write a program that enters the coefficients a, b and c of a quadratic equation 
//a*x2 + b*x + c = 0 and calculates and prints its real roots. 
//Note that quadratic equations may have 0, 1 or 2 real roots.

using System;
 
class SolveQuadratic
{
    static void Main()
    {
        Console.WriteLine("Please enter coefficient A:");
        int coefA = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient B:");
        int coefB = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient C:");
        int coefC = int.Parse(Console.ReadLine());

        double discriminant = Math.Sqrt((coefB * coefB) - (4 * coefA * coefC));
        double rootOne = (-coefB - discriminant) / (2 * coefA);
        double rootTwo = (-coefB + discriminant) / (2 * coefA);
        double root = -coefC/(double)coefB;
        if (discriminant > 0 && coefA != 0)
        {
            Console.WriteLine("Two real roots x1 = {0}, x2 = {1}", rootOne, rootTwo);
        }
        else if (discriminant == 0 && coefA != 0)
        {
            Console.WriteLine("One real root x = {0}", rootOne);
        }
        else if (coefA == 0)
        {
            Console.WriteLine("One real root x = {0}", root );
        }
        else 
        {
            Console.WriteLine("The equation has no real roots!");
        }
    }
}

