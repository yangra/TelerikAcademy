//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
//Example:
//  ha fifi ho hi                    s qq s
//  fo   ha hi xx - > ha, ha, ha    pp pp s -> s,s,s
// xxx   ho ha xx                   pp qq s

using System;

class LongestSequence
{
    static int maxSum = 0;
    static string element;
    static bool[, ,] used;
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { 1, 1 }, { -1, -1 }, };

    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void PrintResult()
    {
        Console.WriteLine("Result is:");
        for (int i = 0; i < maxSum; i++)
        {
            if (i == maxSum - 1)
            {
                Console.Write("{0}", element);
            }
            else
            {
                Console.Write("{0}, ", element);
            }
        }
        Console.WriteLine();
    }

    static bool IsTraversable(string[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) & col >= 0 && col < matrix.GetLength(1);
    }

    static void DFS(string[,] matrix, int row, int col)
    {

        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
            if (used[row, col, direction]) continue;

            int currentSum = 0;
            int currentRow = row;
            int currentCol = col;

            while (IsTraversable(matrix, currentRow, currentCol) && matrix[row, col] == matrix[currentRow, currentCol])
            {
                currentSum++;
                used[currentRow, currentCol, direction] = true;
                currentRow += directions[direction, 0];
                currentCol += directions[direction, 1];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                element = matrix[row, col];
            }

        }

    }

    static void Main()
    {
        string[,] matrix = { { "ha", "fifi", "ho", "hi" }, { "fo", "ha", "hi", "xx" }, { "xxx", "ho", "ha", "xx" } };
        //string[,] matrix = { { "s", "qq", "s" }, { "pp", "pp", "s" }, { "pp", "qq", "s" } };

        used = new bool[matrix.GetLength(0), matrix.GetLength(1), directions.GetLength(0)];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                DFS(matrix, row, col);
            }
        }
        PrintMatrix(matrix);
        PrintResult();
    }


}
