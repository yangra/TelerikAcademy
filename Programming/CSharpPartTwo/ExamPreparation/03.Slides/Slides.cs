using System;
using System.IO;
using System.Text.RegularExpressions;

class Slides
{
    static int ballW;
    static int ballD;
    static string[, ,] cuboid;
    static int width;
    static int height;
    static int depth;

    static void Return(char letter)
    {
        switch (letter)
        {
            case 'L':
                ballW++;
                break;
            case 'R':
                ballW--;
                break;
            case 'F':
                ballD++;
                break;
            case 'B':
                ballD--;
                break;
            default:
                Console.WriteLine("False argument");
                break;
        }
    }

    static bool Move(char letter)
    {
        switch (letter)
        {
            case 'L':
                if (ballW - 1 < 0)
                {
                    return false;
                }
                ballW--;
                return true;
            case 'R':
                if (ballW + 1 >= width)
                {
                    return false;
                }
                ballW++;
                return true;
            case 'F':
                if (ballD - 1 < 0)
                {
                    return false;
                }
                ballD--;
                return true;
            case 'B':
                if (ballD + 1 >= depth)
                {
                    return false;
                }
                ballD++;
                return true;
            default:
                Console.WriteLine("False argument");
                return false;
        }
    }

    static void Main()
    {
        string[] rawSize = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        width = int.Parse(rawSize[0]);
        height = int.Parse(rawSize[1]);
        depth = int.Parse(rawSize[2]);
        cuboid = new string[width, height, depth];
        for (int i = 0; i < height; i++)
        {
            string[] rowSequences = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < depth; j++)
            {
                string pattern = @"(?<=\().*?(?=\))";
                MatchCollection sequence = Regex.Matches(rowSequences[j], pattern);
                for (int k = 0; k < width; k++)
                {
                    cuboid[k, i, j] = sequence[k].ToString();
                }
            }
        }
        string[] rawCoordiantes = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        ballW = int.Parse(rawCoordiantes[0]);
        ballD = int.Parse(rawCoordiantes[1]); 

        int level = 0;
        bool aborted = false;

        while (level != height - 1)
        {
            string currentString = cuboid[ballW, level, ballD]; //!!!
            if (currentString[0] == 'S')
            {
                level++;

                if (!Move(currentString[2]))
                {
                    level--;
                    aborted = true;
                    break;
                }
                if (currentString.Length > 3)
                {
                    if (!Move(currentString[3]))
                    {
                        Return(currentString[2]);
                        level--;
                        aborted = true;
                        break;
                    }
                }
            }
            else if (currentString[0] == 'T')
            {
                string[] parameters = currentString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                ballW = int.Parse(parameters[1]);
                ballD = int.Parse(parameters[2]);
            }
            else if (cuboid[ballW, level, ballD][0] == 'B')
            {
                aborted = true;
                break;
            }
            else if (cuboid[ballW, level, ballD][0] == 'E')
            {
                level++;
            }
        }
        while (cuboid[ballW, level, ballD][0] == 'T')
        {
            string[] parameters = cuboid[ballW, level, ballD].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ballW = int.Parse(parameters[1]);
            ballD = int.Parse(parameters[2]);
        }
        if (cuboid[ballW, level, ballD][0] == 'B')
        {
            aborted = true;
        }
        if (aborted)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
        Console.WriteLine("{0} {1} {2}", ballW, level, ballD);
    }
}

