using System;
using System.Collections.Generic;
using System.Numerics;

class Brackets
{
    static List<string> allBrackets = new List<string>();
    static BigInteger GetCatalan(int N)
    {
        BigInteger divident = 1;
        BigInteger divisor = 1;

        for (int i = N + 2; i <= 2 * N; i++)
        {
            divident *= i;
        }
        for (int i = 1; i <= N; i++)
        {
            divisor *= i;
        }

        return (divident / divisor);
    }
    static int CountQ(string input)
    {
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '?')
            {
                count++;
            }
        }
        return count;
    }

    static bool IsCatalan(string input)
    {
        bool isCatalan = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] != '?')
            {
                isCatalan = false;
                return isCatalan;
            }

        }
        isCatalan = true;
        return isCatalan;
    }

    public static void DoBrackets(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            DoBrackets("", 0, 0, i);
        }
    }
    public static void DoBrackets(string output, int open, int close, int pairs)
    {
        if ((open == pairs) && (close == pairs))
        {
            allBrackets.Add(output);
            //Console.WriteLine(output);
        }
        else
        {
            if (open < pairs)
                DoBrackets(output + "(", open + 1, close, pairs);
            if (close < open)
                DoBrackets(output + ")", open, close + 1, pairs);
        }
    }
    static void Main()
    {
        checked
        {
            //int count = 0;
            string input = Console.ReadLine();
            if (input.Length % 2 != 0)
            {
                Console.WriteLine("0");
            }
            else if (IsCatalan(input))
            {
                Console.WriteLine(GetCatalan(input.Length / 2));
            }
            else
            {
                int countQ = CountQ(input);
                if (countQ % 2 != 0)
                {
                    countQ += 1;
                }
                Console.WriteLine(GetCatalan(countQ / 2));

                //DoBrackets("", 0, 0, input.Length / 2);
                //for (int i = 0; i < allBrackets.Count; i++)
                //{
                //    if (CompareBrackets(allBrackets[i], input))
                //    {
                //        //Console.WriteLine(allBrackets[i]);
                //        count++;
                //    }
                //}
                //Console.WriteLine(count);
            }
        }
    }

    private static bool CompareBrackets(string original, string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '?')
            {
                continue;
            }
            else
            {
                if (input[i] == original[i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
        }
        return true;
    }
}

