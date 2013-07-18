//Write a program that reads two numbers N and K and generates all the combinations of K distinct 
//elements from the set [1..N]. 
//Example:  
//N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class Combinations
{
    static int numberOfElements;
    static int numberOfLoops;
    static int[] combination;

    static void Combinate(int iteration, int start)
    {
        if (iteration == numberOfLoops)
        {
            for (int i = 0; i < combination.Length; i++)
            {
                Console.Write("{0} ", combination[i]);
            }
            Console.WriteLine();
            return;
        }
        for (int i = start; i <= numberOfElements; i++)
        {
            combination[iteration] = i;
            Combinate(iteration+1,i+1);
        }
    }

    static void Main()
    {
        Console.Write("Please enter the number of elements: ");
        numberOfElements = int.Parse(Console.ReadLine());
        Console.Write("Please enter length of combination: ");
        numberOfLoops = int.Parse(Console.ReadLine());
        combination = new int[numberOfLoops];
        Combinate(0,1);
    }
}

