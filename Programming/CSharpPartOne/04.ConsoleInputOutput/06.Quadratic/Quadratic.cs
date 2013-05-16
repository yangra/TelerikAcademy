//Write a program that reads the coefficients a, b and c of a quadratic equation 
//ax2+bx+c=0 and solves it (prints its real roots).

using System;

class Quadratic
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coeficient a:");
        int coefA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient b:");
        int coefB = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter coefficient c:");
        int coefC = int.Parse(Console.ReadLine());
        double discriminant = Math.Sqrt(coefB * coefB - 4 * coefA * coefC);
        double x1 = (-1 * coefB + discriminant) / (2 * coefA);
        double x2 = (-1 * coefB - discriminant) / (2 * coefA);
        Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
    }
}

