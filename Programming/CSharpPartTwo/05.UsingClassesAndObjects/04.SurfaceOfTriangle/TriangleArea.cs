//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleArea
{
    static double ThreeSides(int a, int b, int c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static double SidesAngle(int a, int b, int angle)
    {
        double angleInRad = Math.PI * angle / 180;
        return (a * b * (Math.Sin(angleInRad))) / 2;
    }

    static double SideHeight(int side, int height)
    {
        return (side * height) / 2;
    }

    static void Main()
    {
        Console.WriteLine(ThreeSides(3, 4, 5));
        Console.WriteLine(SidesAngle(3, 4, 90));
        Console.WriteLine(SideHeight(3, 4));
    }
}

