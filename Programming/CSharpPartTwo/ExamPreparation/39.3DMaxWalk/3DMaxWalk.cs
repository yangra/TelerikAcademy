using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxWalk3D
{
    static void Main()
    {
        int[, ,] cube;
        bool[, ,] visited;
        int[] dirsW = {0,1,0,-1,0,0};
        int[] dirsH = {0,0,1,0,-1,0};
        int[] dirsD = {1,0,0,0,0,-1};
        int sum = 0;
        string[] rawSizes = Console.ReadLine().Split();
        int width = int.Parse(rawSizes[0]);
        int height = int.Parse(rawSizes[1]);
        int depth = int.Parse(rawSizes[2]);
        cube = new int[width, height, depth];
        visited = new bool[width, height, depth];
        for (int i = 0; i < height; i++)
        {
            string[] layer = Console.ReadLine().Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            for (int j = 0; j < depth; j++)
            {
                for (int k = index, p = 0; k < width * (j + 1); k++, p++)
                {
                    cube[p, i, j] = int.Parse(layer[k]);
                }
                index += width;
            }
        }
        bool noMax = false;
        int lastW = width / 2;
        int lastH = height / 2;
        int lastD = depth / 2;
        while (visited[lastW,lastH,lastD]!= true && !noMax)
        {
            bool newMax = false;
            sum += cube[lastW, lastH, lastD];
            visited[lastW, lastH, lastD] = true;
            int max = -2000;
            int curW = lastW;
            int curH = lastH;
            int curD = lastD;
            int count = 0;
            for (int i = 0; i < dirsD.Length; i++)
            {
                int W = lastW;
                int H = lastH;
                int D = lastD;
            
                while (W + dirsW[i] >= 0 && W + dirsW[i] < width &&
                    H + dirsH[i] >= 0 && H + dirsH[i] < height &&
                    D + dirsD[i] >= 0 && D + dirsD[i] < depth)
                {
                    if (cube[W + dirsW[i], H + dirsH[i], D + dirsD[i]] > max)
                    {
                        
                        curW = W + dirsW[i];
                        curH = H + dirsH[i];
                        curD = D + dirsD[i];
                        max = cube[W + dirsW[i], H + dirsH[i], D + dirsD[i]];
                        newMax = true;
                    }
                    if (newMax)
                    {
                        count = 0;
                        noMax = false;
                    }
                    if (cube[W + dirsW[i], H + dirsH[i], D + dirsD[i]] == max)
                    {
                        count++;
                        if (count > 1)
                        {
                            noMax = true;
                        }

                    }
                    W = W + dirsW[i];
                    H = H + dirsH[i];
                    D = D + dirsD[i];
                    newMax = false;
                }
            }
            lastW = curW;
            lastH = curH;
            lastD = curD;
        }
        Console.WriteLine(sum);
    }
}

