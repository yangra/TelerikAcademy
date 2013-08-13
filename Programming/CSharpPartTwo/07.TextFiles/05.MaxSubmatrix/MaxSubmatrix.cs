//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
//an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains 
//the size of matrix N. Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. 

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

    static void WriteAnswerToFile(string file)
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
        WriteAnswerToFile(@"../../result.txt");
    }
}