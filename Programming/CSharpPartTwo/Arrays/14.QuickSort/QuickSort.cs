//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;

class QuickSort
{
    static bool depth = true;
   
    static bool Greater(string one, string two)
    {
        one.ToCharArray();
        two.ToCharArray();
        int limit = 0;
        bool isOneGreater = false;
        if (one.Length > two.Length)
        {
            limit = two.Length;
        }
        else
        {
            limit = one.Length;
        }
        for (int i = 0; i < limit; i++)
        {
            if (one[i] < two[i])
            {
                return isOneGreater;
            }
            if (one[i] > two[i])
            {
                isOneGreater = true;
                return isOneGreater;
            }
        }
        if (one.Length > two.Length)
        {
            isOneGreater = true;
            return isOneGreater;
        }
        return isOneGreater;
    }

    static bool Smaller(string one, string two)
    {
        one.ToCharArray();
        two.ToCharArray();
        int limit = 0;
        bool isOneSmaller = false;
        if (one.Length>two.Length)
        {
            limit = two.Length;
        }
        else
        {
            limit = one.Length;
        }
        for (int i = 0; i < limit; i++)
        {
            if (one[i] > two[i])
            {
                return isOneSmaller;
            }
            if (one[i] < two[i])
            {
                isOneSmaller = true;
                return isOneSmaller;
            }
        }
        if (one.Length<two.Length)
        {
            isOneSmaller = true;
            return isOneSmaller;
        }
        return isOneSmaller;
    }

    static void Swap(ref string a, ref string b)
    {
        string temp = a;
        a = b;
        b = temp;
    }

    static void Qsort(string[] array, int start, int end)
    {
        if (start >= end)
        {
            depth = false;
            return;
        }
        int i = start;
        int j = end;
        string pivot = array[(start + end) / 2];
        int index = (start + end) / 2;
        while (i != j)
        {
            while (Smaller(array[i], pivot))
            {
                i++;
            }
            while (Greater(array[j], pivot))
            {
                j--;
            }
            if (j == index && i == index)
            {
                break;
            }
            else if (j == index)
            {
                Swap(ref array[index], ref array[index - 1]);
                index--;
                j = index;
                if (index != start&&i!=j)
                {
                    Swap(ref array[i], ref array[index + 1]);
                }
            }
            else if (i == index)
            {
                Swap(ref array[index], ref array[index + 1]);
                index++;
                i = index;
                if (index != end&&i!=j)
                {
                    Swap(ref array[index - 1], ref array[j]);
                }
            }
            else if (i < j)
            {
                Swap(ref array[i], ref array[j]);
            }
        }
        if (depth||start!=0)
        {
            Qsort(array, 0, index - 1);
            Qsort(array, index + 1, end);
        }
        
    }

    static void Main()
    {
        string[] array = { "bcd", "abc", "dab", "mwa", "abc", "cda", "ron", "abcd", 
                         "btw", "con", "Aer", "Abc", "Mate", "LEGO", "Bulgaria" };
        Qsort(array, 0, array.Length - 1);
        foreach (var item in array)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}

