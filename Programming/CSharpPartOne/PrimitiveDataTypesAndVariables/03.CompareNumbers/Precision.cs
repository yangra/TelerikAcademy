//Write a program that safely compares floating-point numbers with precision of 
//0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class Precision
{
    static void Main()
    {
        Console.WriteLine("Enter a floating-point number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter a floating-point number: ");
        double secondNum = double.Parse(Console.ReadLine());

        bool comparison = (Math.Abs(firstNum - secondNum) < 0.000001);
        Console.WriteLine(comparison);
    }
}

