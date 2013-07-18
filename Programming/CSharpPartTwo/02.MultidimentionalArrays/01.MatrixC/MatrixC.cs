using System;

class MatrixC
{
    static void Main()
    {
        Console.WriteLine("Please enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int[,] matrix = new int[n, n];
        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                matrix[n - i + j, j] = counter;
                counter++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            matrix[i, i] = counter;
            counter++;
        }
        for (int i = n-1, k=1; i >= 1; i--, k++)
        {
            for (int j = 0; j < i; j++)
            {
                matrix[j, j + k] = counter;
                counter++;
            }  
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}

