using System;

class IsPrime
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer(2 - 100):");
        int number = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 2; i < Math.Sqrt(number); i++)
        {
            if (number % i == 0) 
            {
                count++;
            }

        }
        if (count == 0)
        {
            Console.WriteLine("The number you entered is prime");
        }
        else 
        {
            Console.WriteLine("The number you entered is not prime");
        }
    }
}

