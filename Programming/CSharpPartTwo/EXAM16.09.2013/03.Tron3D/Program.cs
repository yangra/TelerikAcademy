using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Tron3D
{
    class Program
    {
        static int[,] matrix;
        static int blueX;
        static int blueY;
        static int redX;
        static int redY;
        static string redDir;
        static string blueDir;
        static bool redWins;
        static bool blueWins;

        static void Main()
        {
            string[] sizes = Console.ReadLine().Split();
            string pathRed = Console.ReadLine();
            string pathBlue = Console.ReadLine();
            int pathLength = pathRed.Length;
            int X = int.Parse(sizes[0]);
            int Y = int.Parse(sizes[1]);
            int Z = int.Parse(sizes[2]);
            matrix = new int[X + 1, (2 * Y + 2 * Z)];
            blueX = Y / 2 + Y + Z;
            blueY = X / 2;
            redX = Y / 2;
            redY = X / 2;
            matrix[redY, redX] = 1;
            matrix[blueY, blueX] = 2;
            blueDir = "left";
            redDir = "right";
            int indexR = 0;
            int indexB = 0;
            blueWins = false;
            redWins = false;
            int distance = 0;
            while (indexR < pathRed.Length || indexB < pathBlue.Length)
            {

                while (indexR < pathRed.Length && (pathRed[indexR] == 'L' || pathRed[indexR] == 'R'))
                {
                    ChangeDirection(ref redDir, pathRed[indexR]);
                    indexR++;
                }
                while (indexB < pathBlue.Length && (pathBlue[indexB] == 'L' || pathBlue[indexB] == 'R'))
                {
                    ChangeDirection(ref blueDir, pathBlue[indexB]);
                    indexB++;
                }

                MoveRed();
                indexR++;
                MoveBlue();
                indexB++;
                if ((redX == blueX && redY == blueY)||(blueWins && redWins))
                {
                    if (redX > Y / 2 + Y + Z)
                    {
                        distance = Math.Abs(X / 2 - redY) + Math.Abs(Y / 2 - (Y / 2 + Y + Z)) - Math.Abs((Y / 2 + Y + Z) - redX);
                    }
                    else
                    {
                        distance = Math.Abs(X / 2 - redY) + Math.Abs(Y / 2 - redX);
                    }
                    Console.WriteLine("DRAW");
                    Console.WriteLine(distance);
                    return;

                }
                if (blueWins)
                {
                    if (redX > Y / 2 + Y + Z)
                    {
                        distance = Math.Abs(X / 2 - redY) + Math.Abs(Y / 2 - (Y / 2 + Y + Z)) - Math.Abs((Y / 2 + Y + Z) - redX);
                    }
                    else
                    {
                        distance = Math.Abs(X / 2 - redY) + Math.Abs(Y / 2 - redX);
                    }
                    Console.WriteLine("BLUE");
                    Console.WriteLine(distance);
                    return;
                }
                if (redWins)
                {
                    if (redX > Y / 2 + Y + Z)
                    {
                        distance = Math.Abs(X / 2 - redY) + Math.Abs(Y / 2 - (Y / 2 + Y + Z)) - Math.Abs((Y / 2 + Y + Z) - redX);
                    }
                    else
                    {
                        distance = Math.Abs(X / 2 - redY) + Math.Abs(Y / 2 - redX);
                    }
                    Console.WriteLine("RED");
                    Console.WriteLine(distance);
                    return;
                }
            }

        }

        private static void MoveRed()
        {
            if (redDir == "left")
            {
                redX--;
                if (redX < 0)
                {
                    redX = matrix.GetLength(1) - 1;
                }

                if (matrix[redY, redX] == 2)
                {
                    blueWins = true;
                    return;
                }
                matrix[redY, redX] = 1;

            }
            else if (redDir == "right")
            {
                redX++;
                if (redX >= matrix.GetLength(1))
                {
                    redX = 0;
                }
                if (matrix[redY, redX] == 2)
                {
                    blueWins = true;
                    return;
                }
                matrix[redY, redX] = 1;
            }
            else if (redDir == "down")
            {
                redY++;
                if (redY >= matrix.GetLength(0))
                {
                    blueWins = true;
                    redY = matrix.GetLength(0) - 1;
                    return;
                }
                if (matrix[redY, redX] == 2)
                {
                    blueWins = true;
                    return;
                }
                matrix[redY, redX] = 1;
            }
            else
            {
                redY--;
                if (redY < 0)
                {
                    blueWins = true;
                    redY = 0;
                    return;
                }
                if (matrix[redY, redX] == 2)
                {
                    blueWins = true;
                    return;
                }
                matrix[redY, redX] = 1;
            }
        }

        private static void MoveBlue()
        {
            if (blueDir == "left")
            {
                blueX--;
                if (blueX < 0)
                {
                    blueX = matrix.GetLength(1) - 1;
                }
                if (matrix[blueY, blueX] == 1)
                {
                    redWins = true;
                    return;
                }
                matrix[blueY, blueX] = 2;
            }
            else if (blueDir == "right")
            {
                blueX++;
                if (blueX > matrix.GetLength(1) - 1)
                {
                    blueX = 0;
                }
                if (matrix[blueY, blueX] == 1)
                {
                    redWins = true;
                    return;
                }
                matrix[blueY, blueX] = 2;
            }
            else if (blueDir == "down")
            {
                blueY++;
                if (blueY > matrix.GetLength(0) - 1)
                {
                    redWins = true;
                    return;
                }
                if (matrix[blueY, blueX] == 1)
                {
                    redWins = true;
                    return;
                }
                matrix[blueY, blueX] = 2;
            }
            else
            {
                blueY--;
                if (blueY < 0)
                {
                    redWins = true;
                    return;
                }
                if (matrix[blueY, blueX] == 1)
                {
                    redWins = true;
                    return;
                }
                matrix[blueY, blueX] = 2;
            }
        }

        private static void ChangeDirection(ref string dir, char change)
        {

            if (change == 'L')
            {
                if (dir == "right")
                {
                    dir = "up";
                }
                else if (dir == "up")
                {
                    dir = "left";
                }
                else if (dir == "left")
                {
                    dir = "down";
                }
                else
                {
                    dir = "right";
                }
            }
            else
            {
                if (dir == "right")
                {
                    dir = "down";
                }
                else if (dir == "up")
                {
                    dir = "right";
                }
                else if (dir == "left")
                {
                    dir = "up";
                }
                else
                {
                    dir = "left";
                }
            }

        }

    }
}

