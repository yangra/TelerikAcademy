using System;

class MatrixD
{
    static void Main()
    {
        Console.WriteLine("Please enter matrix's size: ");
        int n = int.Parse(Console.ReadLine());
        int counter = 1;
        int[,] matrix = new int[n, n];
        int i = 0;
        int j = 0;
        string direction = "down";
        while (counter<=n*n)
        {
            matrix[i, j] = counter;
            counter++;
            if (direction == "down")
            {
                i++;
                if (i==n||matrix[i,j]!=0)
                {
                    direction = "right";
                    i--;
                    j++;
                }
            }
            else if (direction == "right")
            {
                j++;
                if (j==n||matrix[i,j]!=0)
                {
                    direction = "up";
                    j--;
                    i--;
                }
            }
            else if (direction == "up")
            {
                i--;
                if (i < 0 || matrix[i, j] != 0)
                {
                    direction = "left";
                    i++;
                    j--;
                }
            }
            else if (direction == "left")
            {
                j--;
                if (matrix[i, j] != 0)
                {
                    direction = "down";
                    j++;
                    i++;
                }
            }
        }
        for (int p = 0; p < n; p++)
        {
            for (int q = 0; q < n; q++)
            {
                Console.Write("{0,4}", matrix[p, q]);
            }
            Console.WriteLine();
        }
    }
}

