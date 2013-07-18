using System;

class LongestSequence
{
    static int maxCount;
    static int element;

    static void Max(int count, int cell)
    {
        if (count > maxCount)
        {
            maxCount = count;
            element = cell;
        } 
    }

    static void Main()
    {
        int rows = 6;
        int cols = 10;
        int[,] matrix = new int[rows, cols];
        element = 0;
        int count = 1;
        maxCount = 0;
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows-1; j++)
            {
                if (matrix[j,i] == matrix[j+1,i])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                Max(count, matrix[j, i]);

                if (j == rows-2)
                {
                    count = 1;
                }
            }
        }
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols-1; j++)
            {
                if (matrix[i,j] == matrix[i,j+1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                Max(count, matrix[i, j]);
                if (j==cols-2)
                {
                    count = 1;
                }
            }
        }
        for (int i = 0; i < length; i++)
        {
            
        }

    }
}

