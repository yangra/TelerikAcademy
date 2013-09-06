using System;
using System.Collections.Generic;
using System.Text;

class TwoIsBetterThanOne
{
    static long CountLuckyNumbers(ulong lowerBound, ulong upperBound)
    {
        ulong max = (ulong)Math.Pow(10, 18);
        List<ulong> numbers = new List<ulong> { 3, 5 };
        int down = 0;
        long count = 0;
        while (down < numbers.Count)
        {
            int up = numbers.Count;
            for (int i = down; i < up; i++)
            {
                if (numbers[i]<= max)
                {
                    numbers.Add(10 * numbers[i] + 3);
                    numbers.Add(10 * numbers[i] + 5);
                }
            }
            down = up;
        }
        foreach (var number in numbers)
        {
            if (number>=lowerBound&&number<=upperBound&&isPalindrome(number))
            {
                count++;
            }
        }
        return count;
    }

    static bool isPalindrome(ulong number)
    {
        string num = number.ToString();
        for (int i = 0; i < num.Length/2; i++)
        {
            if (num[i] != num[num.Length-i-1])
            {
                return false;
            }
        }
        return true;
    }

    static void Main()
    {
        string[] rawNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        ulong A = ulong.Parse(rawNumbers[0]);
        ulong B = ulong.Parse(rawNumbers[1]);
        Console.WriteLine(CountLuckyNumbers(A, B));

        string[]  rawList = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        int percent = int.Parse(Console.ReadLine());
        int[] list = new int[rawList.Length];
        for (int i = 0; i < list.Length; i++)
        {
            list[i] = int.Parse(rawList[i]);
        }
        
        int least = (int)(Math.Ceiling(list.Length * (double)(percent/100.0)));
        Array.Sort(list);
        Console.WriteLine(least!=0?list[least-1]:list[0]);
    }
}

