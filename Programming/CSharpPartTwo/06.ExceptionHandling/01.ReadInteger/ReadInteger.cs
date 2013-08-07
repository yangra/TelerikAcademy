//Write a program that reads an integer number and calculates and prints its square root. 
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". 
//Use try-catch-finally.

using System;

class ReadInteger
{
    static double CalculateSquareRoot()
    {
        double result = 0;
        Console.WriteLine("Please enter a number:");
        result = int.Parse(Console.ReadLine());
        if (result < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        result = Math.Sqrt(result);
        return result;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine(CalculateSquareRoot());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}

