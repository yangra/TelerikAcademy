using System;

class MatrixA
{
    static void Main()
    {
        Console.WriteLine("Please enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[j, i] = counter;
                counter++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}


