using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KukataIsDancing
{
    static void Move(ref int x, ref int y, char dir,ref int curDir)
    {
        switch (dir)
        {
            case 'W':
                switch (curDir)
                {
                    case 0:
                        x--;
                        if (x<0)
                        {
                            x = 2;
                        }
                        break;
                    case 1:
                        y++;
                        if (y>2)
                        {
                            y = 0;
                        }
                        break;
                    case 2:
                        x++;
                        if (x > 2)
                        {
                            x = 0;
                        }
                        break;
                    case 3:
                        y--;
                        if (y<0)
                        {
                            y = 2;
                        }
                        break;
                    default:
                        break;
                }

                break;
            case 'R':
                curDir++;
                if (curDir > 3)
                {
                    curDir = 0;
                }
                break;
            case 'L':
                curDir--;
                if (curDir < 0)
                {
                    curDir = 3;
                }
                break;
            default:
                break;
        }
    }

    static void Main()
    {
        //1-red 2-blue 3-green
        int[,] cube = new int[3,3];
        cube[0, 0] = cube[0, 2] = cube[2, 0] = cube[2, 2] = 1;
        cube[1, 0] = cube[0, 1] = cube[1, 2] = cube[2, 1] = 2;
        cube[1, 1] = 3;
        int seq = int.Parse(Console.ReadLine());
        string[] sequences = new string[seq];
        for (int i = 0; i < seq; i++)
        {
            sequences[i] = Console.ReadLine();
        }
        int[] answers = new int[seq];
        for (int i = 0; i < sequences.Length; i++)
        {
            int x = 1;
            int y = 1;
            int curDir = 0;
            for (int j = 0; j < sequences[i].Length; j++)
            {
                char movement = sequences[i][j];
                Move(ref x, ref y, movement, ref curDir);
            }
            answers[i] = cube[x, y];
        }
        for (int i = 0; i < answers.Length; i++)
        {
            Print(answers[i]);
        }
    }

    static void Print(int color)
    {
        switch (color)
        {   
            case 1:
                Console.WriteLine("RED");
                break;
            case 2:
                Console.WriteLine("BLUE");
                break;
            case 3:
                Console.WriteLine("GREEN");
                break;
            default:
                break;
        }
    }
}

