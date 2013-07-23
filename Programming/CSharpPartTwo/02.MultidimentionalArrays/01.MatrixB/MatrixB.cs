//Write a program that fills and prints a matrix of size (n, n) as shown below: 
// 1 8  9 16
// 2 7 10 15
// 3 6 11 14
// 4 5 12 13

using System;

class MatrixB
{
    static void Main()
    {
        Console.WriteLine("Please enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            if (i%2==0)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = counter;
                    counter++;
                } 
            }
            else
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    matrix[j, i] = counter;
                    counter++;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write( "{0,4}", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

