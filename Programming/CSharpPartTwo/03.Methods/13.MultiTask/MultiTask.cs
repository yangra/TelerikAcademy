//Write a program that can solve these tasks:
//  Reverses the digits of a number
//  Calculates the average of a sequence of integers
//  Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//  The decimal number should be non-negative
//  The sequence should not be empty
//  'a' should not be equal to 0

using System;
using System.Collections.Generic;

class MultiTask
{
    static int Reverse(int number,int r = 0)
    {
        return number == 0 ? r : Reverse(number / 10, r * 10 + number % 10);
    }

    static double SeqAverage(int[] array)
    {
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average /= array.Length;
        return average;
    }

    static double SolveEquation(double a, double b)
    {
        double result = (-b) / a;
        return result;
    }

    static int InputOption()
    {
        Console.Write("Enter your choice here: ");
        int option = 0;
        while (!int.TryParse(Console.ReadLine(), out option) || option > 4 || option < 1)
        {
            Console.WriteLine("This is an invalid choice. Please enter number 1 through 4!");
            Console.Write("Enter your choice here: ");
        }
        return option;
    }

    static int GetNumber()
    {
        int number = 0;
        Console.Write("Please enter a number: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("You entered an invalid number! Number should be positive. Try again!");
            Console.Write("Please enter a number: ");
        }
        return number;
    }

    static int[] GetSeq()
    {
        Console.Write("Please enter a sequence of numbers separated by commas: ");
        List<string> seq = new List<string>(Console.ReadLine().Split(','));
        int[] sequence = new int[seq.Count];
        for (int i = 0; i < seq.Count; i++)
        {
            while (!int.TryParse(seq[i], out sequence[i]) || seq.Count == 0)
            {
                Console.WriteLine("You entered an invalid sequence! ");
                Console.WriteLine("The sequence cannot be empty and should consist of integers!");
                Console.WriteLine("Please try again!");
                Console.Write("Please enter a sequence of numbers separated by commas: ");
                seq = new List<string>(Console.ReadLine().Split(','));
                sequence = new int[seq.Count];
                i = 0;
            }
        }
        return sequence;
    }

    static double GetA()
    {
        double a = 0;
        Console.Write("Please enter coefficient a: ");
        while (!double.TryParse(Console.ReadLine(), out a) || a == 0)
        {
            Console.WriteLine("You entered invalid number! Please enter integer different than 0!");
            Console.Write("Please enter coefficient a: ");
        }
        return a;
    }
    static double GetB()
    {
        double b = 0;
        Console.Write("Please enter coefficient b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("You entered invalid number! Please try again!");
            Console.Write("Please enter coefficient b: ");
        }
        return b;
    }

    static void Main()
    {
        Console.WriteLine("Please chose your option: ");
        Console.WriteLine("1. Reverse digits of a number ");
        Console.WriteLine("2. Calaculate the average of a sequence of integers");
        Console.WriteLine("3. Solve the eqation a*x + b = 0");
        Console.WriteLine("4. Exit");
        
        int userChoice = InputOption();
        switch (userChoice)
        {
            case 1:
                int userNumber = GetNumber();
                Console.WriteLine("The reversed number is: {0}", Reverse(userNumber));
                break;
            case 2:
                int[] userSeq = GetSeq();
                Console.WriteLine("The average of this sequence is: {0}", SeqAverage(userSeq));
                break;
            case 3:
                Console.WriteLine("Please enter the coefficients ot he eqation a*x + b = 0");
                double coefA = GetA();
                double coefB = GetB();
                Console.WriteLine("The solution of {0}*x" + (coefB>0?" + ":" ") + "{1} = 0 is x = {2}",coefA, coefB, SolveEquation(coefA, coefB));
                break;
            case 4:
                return;
        }
    }
}

