//Write an if statement that examines two integer variables and exchanges their 
//values if the first one is greater than the second one.

using System;

class CompareVariables
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another integer:");
        int second = int.Parse(Console.ReadLine());

        if (first > second)
        {
            first += second;
            second = first - second;
            first -= second;
        }
    }
}

