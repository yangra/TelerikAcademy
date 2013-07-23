//Write a program that finds the largest area of equal neighbor elements in a rectangular matrix and prints its size. 
//Example:
//  1 3 2 2 2 4
//  3 3 3 2 4 4
//  4 3 1 2 3 3  -> 13
//  4 3 1 3 3 1
//  4 3 3 3 1 1


using System;

class FindLargestArea
{
    
    static bool[,] visited;
    static int[,] directions = { { 0, 1 }, { 1, 0 }, { -1, 0 }, { 0, -1 } };
    static int count = 0;

    static bool isTraversable(int[,] matrix, int x, int y)
    {
        return x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1);
    }

    static void DFS(int[,] matrix, int x, int y, bool[,] visited)
    {
        visited[x, y] = true;
        count++;
        for (int direction = 0; direction < directions.GetLength(0); direction++)
        {
           int _x = x + directions[direction, 0];
           int _y = y + directions[direction, 1];

           if (isTraversable(matrix, _x,_y)&&matrix[x,y] == matrix[_x,_y]&&!(visited[_x,_y]))
           {
               DFS(matrix, _x, _y,visited);
           }  
        }

    }

    static void Main()
    {
        int[,] matrix = 
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1},
        };
        visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
        int maxCount = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                count = 0;
                DFS(matrix,row,col, visited);
                if (maxCount<count)
                {
                    maxCount = count;
                }

            }
        }
        Console.WriteLine(maxCount);

    }
}

