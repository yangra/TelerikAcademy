using System;

class MaximumSumSquare
{
    static int[,] matrix;

    static int SquareSum(int index1, int index2)
    {
        int sum = 0;
        for (int i = index1 - 1; i <= index1 + 1; i++)
        {
            for (int j = index2 - 1; j <= index2 + 1; j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Please enter number of rows of the matrix (m > 3): ");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter number of columns of the matrix (n > 3): ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int tempSum = 0;
        int maxSum = int.MinValue;
        int[] indices = new int[2];
        matrix = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = counter;
                counter++;
            }
        }
        for (int i = 1; i < m - 1; i++)
        {
            for (int j = 1; j < n - 1; j++)
            {
                tempSum = SquareSum(i, j);
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                    indices[0] = i;
                    indices[1] = j;
                }
            }
        }
        Console.WriteLine("Searched matrix: \n");
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("{0}", new string('-', 20));
        Console.WriteLine();
        Console.WriteLine("3x3 square with maximal sum: \n");
        for (int i = indices[0] - 1; i <= indices[0] + 1; i++)
        {
            for (int j = indices[1] - 1; j <= indices[1] + 1; j++)
            {
                Console.Write("{0,4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

