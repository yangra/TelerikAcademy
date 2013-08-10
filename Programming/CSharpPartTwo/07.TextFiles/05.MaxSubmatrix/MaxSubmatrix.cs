using System;
using System.IO;

class MaxSubmatrix
{
    const int SizeSubmatrix = 2;

    static int[,] matrix;
    static int size;
    static int maxSum = 0;

    static void ReadMatrix(string file)
    {
        StreamReader reader = new StreamReader(file);
        using (reader)
        {
            size = int.Parse(reader.ReadLine());
            matrix = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                string[] row = reader.ReadLine().Split(' ');
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(row[j]);
                }
            }
        }
    }

    static void FindMaxSubmatrix()
    {
        for (int i = 0; i < size-1; i++)
        {
            for (int j = 0; j < size-1; j++)
            {
                int subSum = SumSubmatrix(i, j);
                if (subSum > maxSum) maxSum = subSum;
            }
        }
    }

    static int SumSubmatrix(int row, int col)
    {
        int result = 0;
        for (int i = row; i < row+SizeSubmatrix; i++)
        {
            for (int j = col; j < col+SizeSubmatrix; j++)
            {
                result += matrix[i, j];
            }
        }
        return result;
    }

    static void WriteToFile(string file)
    {
        StreamWriter writer = new StreamWriter(file);
        using (writer)
        {
            writer.WriteLine(maxSum);
        }
    }

    static void Main()
    {
        ReadMatrix(@"../../matrix.txt");
        FindMaxSubmatrix();
        WriteToFile(@"../../result.txt");
    }
}