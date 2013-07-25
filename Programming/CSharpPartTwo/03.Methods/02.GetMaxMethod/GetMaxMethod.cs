//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;

class GetMaxMethod
{
    static int GetMax(int a, int b)
    {
        if (a >= b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter three integers followed by Enter: ");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(third, GetMax(first, second))); 
    }
}

