using System;
using System.Collections.Generic;

class Sudoku
{
    static bool IsReady(int[,] sudoku)
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[i,j] == 0)
                {
                    return false;
                }
            }
        }
        return true;
    }
    static void Main()
    {
        List<int> rowSum = new List<int>();
        List<int> colSum = new List<int>();
        List<int> quadSum = new List<int>();
        int[,] sudoku = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            string line = Console.ReadLine();
            for (int j = 0; j < line.Length; j++)
            {
                if (line[j]!='-')
                {
                    sudoku[i, j] = int.Parse(line.Substring(j, 1));
                }
            }
        }
        int iterations = 5;
        while (iterations >0)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (sudoku[row, col] == 0)
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (sudoku[row, i] != 0)
                            {
                                rowSum.Add(sudoku[row, i]);
                            }
                        }
                        for (int i = 0; i < 9; i++)
                        {
                            if (sudoku[i, col] != 0)
                            {
                                colSum.Add(sudoku[i, col]);
                            }
                        }
                        int x = row / 3;
                        int y = col / 3;
                        for (int i = 3 * x; i < 3 * x + 3; i++)
                        {
                            for (int j = 3 * y; j < 3 * y + 3; j++)
                            {
                                if (sudoku[i, j] != 0)
                                {
                                    quadSum.Add(sudoku[i, j]);
                                }
                            }
                        }
                        int count = 0;
                        int number = 0;
                        for (int i = 0; i < 9; i++)
                        {
                            if (!rowSum.Contains(i) && !colSum.Contains(i) && !quadSum.Contains(i))
                            {
                                count++;
                                number = i;
                            }
                        }
                        if (count == 1)
                        {
                            sudoku[row, col] = number;
                        }
                        rowSum.Clear();
                        colSum.Clear();
                        quadSum.Clear();
                    }
                }
            }
            iterations--;
        }
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                Console.Write(sudoku[i,j]);
            }
            Console.WriteLine();
        }

    }

}

