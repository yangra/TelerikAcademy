//Write a program that reads from the console a positive integer number N (N < 20) 
//and outputs a matrix like the following:
//N = 3                     N = 4
// 1 2 3                    1 2 3 4
// 2 3 4                    2 3 4 5
// 3 4 5                    3 4 5 6
//                          4 5 6 7

using System;

class OutputMatrix
{
    static void Main()
    {
        Console.WriteLine("Enter a number N (N < 20):");
        int numN = int.Parse(Console.ReadLine());

        for (int row = 1; row <= numN; row++)
        {
            for (int col = row; col < row + numN; col++)
            {
                Console.Write("{0,3} ",col);
            }
            Console.WriteLine();
        }
    }
}

