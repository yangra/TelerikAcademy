//Write an expression that calculates rectangle’s area by given width and height.

using System;

class RectengleArea
{
    static void Main()
    {
        Console.WriteLine("Please enter rectangle's width:");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter rectangle's height:");
        int height = int.Parse(Console.ReadLine());

        Console.WriteLine("The rectangle's area is: {0}",width*height);
    }
}

