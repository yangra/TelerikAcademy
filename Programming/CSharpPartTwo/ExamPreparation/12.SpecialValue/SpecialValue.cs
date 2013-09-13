using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SpecialValue
{
    static void Main()
    {
        
        int rows = int.Parse(Console.ReadLine());
        int[][] ground = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            string[] rawInput = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            int[] row = new int[rawInput.Length];
            for (int j = 0; j < rawInput.Length; j++)
            {
                row[j] = int.Parse(rawInput[j]);
            }
            ground[i] = row;
        }
        int maxResult = int.MinValue;
        int startCol = -1;
        for (int i = 0; i < ground[0].Length; i++)
        {
            int curVal = i;
            int steps = 0;
            int result = 0;
            int curRow = 0;
            
            bool[,] visited = new bool[rows, 1000];
            bool noResult = false;
            while (curVal>=0)
            {
                if (!visited[curRow,curVal])
                {
                    visited[curRow, curVal] = true;
                    curVal = ground[curRow][curVal];
                    steps++;
                    curRow++;
                    if (curRow==rows)
                    {
                        curRow = 0;
                    }
                }
                else
                {
                    noResult = true;
                    break;
                }
                
            }
            if (!noResult)
            {
                result = steps + Math.Abs(curVal);
                if (result > maxResult)
                {
                    maxResult = result;
                    startCol = i;
                }
            }
            
        }
        if (maxResult<0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine("{0}", maxResult);
        } 
	}
}

