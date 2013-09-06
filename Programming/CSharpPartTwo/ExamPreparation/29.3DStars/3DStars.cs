using System;
using System.Collections.Generic;

class Stars3D
{
    static char[, ,] cube;
    static void Main()
    {
        int counter = 0;
        string[] dimensions = Console.ReadLine().Split();
        int[] sizes = new int[3];
        for (int i = 0; i < sizes.Length; i++)
        {
            sizes[i] = int.Parse(dimensions[i]);
        }
        cube = new char[sizes[0], sizes[1], sizes[2]];
        for (int i = 0; i < cube.GetLength(1); i++)
        {
            string[] row = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < cube.GetLength(2); j++)
            {
                for (int k = 0; k < cube.GetLength(0); k++)
                {
                    cube[k, i, j] = row[j][k];
                }
            }
        }
        //Dictionary<string, int> answer = new Dictionary<string, int>();
        List<char> colors = new List<char>();
        List<int> numberOfStars = new List<int>();

        for (int i = 1; i < cube.GetLength(0)-1; i++)
        {
            for (int j = 1; j < cube.GetLength(1)-1; j++)
            {
                for (int k = 1; k < cube.GetLength(2)-1; k++)
                {
                    if (cube[i, j, k] == cube[i + 1, j, k] && cube[i, j, k] == cube[i - 1, j, k] &&
                        cube[i, j, k] == cube[i, j + 1, k] && cube[i, j, k] == cube[i, j - 1, k] &&
                        cube[i, j, k] == cube[i, j, k + 1] && cube[i, j, k] == cube[i, j, k - 1])
                    {
                        if (colors.Contains(cube[i, j, k]))
                        {
                            int index = colors.IndexOf(cube[i, j, k]);
                            numberOfStars[index]++;
                            counter++;
                        }
                        else
                        {
                            colors.Add(cube[i, j, k]);
                            numberOfStars.Add(1);
                            counter++;
                        }
                        
                    }
                }
            }
        }
        Console.WriteLine(counter);
        char[] outColors = colors.ToArray();
        int[] outCount = numberOfStars.ToArray();
        Array.Sort(outColors, outCount);
        for (int i = 0; i < outColors.Length; i++)
        {
            Console.WriteLine("{0} {1}", outColors[i], outCount[i]);
        }

    }
}


