using System;

class JoroTheRabbit
{
    static void Main()
    {
        string[] raw = Console.ReadLine().Split(new char[]{ ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] terrain = new int[raw.Length];
        for (int i = 0; i < raw.Length; i++)
        {
            terrain[i] = int.Parse(raw[i]);
        }
        int maxJumps = int.MinValue;
        int jumps = 1;
        for (int step = 1; step <= terrain.Length; step++)
        {
            for (int j = 0; j < terrain.Length; j++)
            {
                bool[] visited = new bool[raw.Length];
                int beginning = j;
                visited[beginning] = true;
                int nextIndex = (beginning + step) % terrain.Length;
                while (terrain[nextIndex] > terrain[beginning]&&!visited[nextIndex])
                {
                    jumps++;
                    visited[nextIndex] = true;
                    beginning = nextIndex;
                    nextIndex = (beginning + step) % terrain.Length;
                }
                if (jumps>maxJumps)
                {
                    maxJumps = jumps;
                }
                jumps = 1;
            }
        }
        Console.WriteLine(maxJumps);
    }
}

