using System;
using System.Collections.Generic;
using System.Numerics;

class Tubes
{
    static int GetUpperBound(List<int> tubes, int friends)
    {
        checked
        {
            BigInteger sumLength = 0;
            for (int i = 0; i < tubes.Count; i++)
            {
                sumLength += tubes[i];
            }
            return (int)(sumLength / friends);
        }
    }
    static int GetOptimalLength(int upBound, int friends, List<int> tubes)
    {
        checked
        {
            int result = 0;
            int left = 1;
            int right = upBound;
            int search = (left + right) / 2;
            while (left <= right)
            {
                result = 0;
                for (int i = 0; i < tubes.Count; i++)
                {
                    result += tubes[i] / search;
                }
                if (result >= friends)
                {
                    left = search + 1;
                    result = search;
                }
                else if (result < friends)
                {
                    right = search - 1;
                    result = search - 1;
                }
                search = left + (right - left) / 2;
            }
            return result;
        }
    }

    //static int GetOptimalLength(int upBound, int friends, List<int> tubes)
    //{
    //    int count = 0;
    //    upBound++;
    //    while (count<friends)
    //    {
    //        upBound--;
    //        count = 0;
    //        for (int i = 0; i < tubes.Count; i++)
    //        {
    //            int tube = tubes[i];
    //            count += tube / upBound;
    //        }
    //    }
    //    return upBound;
    //}

    static void Main()
    {
        checked
        {
            int N = int.Parse(Console.ReadLine());
            int friends = int.Parse(Console.ReadLine());
            List<int> tubes = new List<int>();

            for (int i = 0; i < N; i++)
            {
                tubes.Add(int.Parse(Console.ReadLine()));
            }
            tubes.Sort();
            if (friends < tubes.Count)
            {
                tubes.RemoveRange(0, tubes.Count - friends);
                int upBound = GetUpperBound(tubes, friends);
                if (upBound <= 0)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(GetOptimalLength(upBound, friends, tubes));
                }

            }
            else
            {
                int upBound = GetUpperBound(tubes, friends);
                if (upBound <= 0)
                {
                    Console.WriteLine("-1");
                }
                else
                {
                    Console.WriteLine(GetOptimalLength(upBound, friends, tubes));
                }
            }
        }
    }
}




