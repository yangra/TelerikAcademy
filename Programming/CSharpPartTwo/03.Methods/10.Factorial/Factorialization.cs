//Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that 
//multiplies a number represented as array of digits by given integer number. 

using System;
using System.Collections.Generic;

class Factorialization
{
    static List<int> AddCurrentResults(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int carry = 0;
        int currentNum = 0;
        if (a.Count<b.Count)
        {
           return AddCurrentResults(b, a);
        }
        for (int i = 0; i < b.Count; i++)
        {
            currentNum = a[i] + b[i] + carry;
            result.Add(currentNum % 10);
            carry = currentNum / 10;
        }
        for (int i = b.Count; i < a.Count; i++)
        {
            currentNum = a[i] + carry;
            result.Add(currentNum % 10);
            carry = currentNum / 10;
        }
        if (carry!=0)
        {
            result.Add(carry);
        }
        return result;

    }

    static List<int> MultiplyArrayByNumber(List<int> array, int number)
    {
        List<int> result = new List<int>();
        List<int> currentResult = new List<int>();
        for (int i = number, j = 0; i > 0; i /= 10, j++)
        {
            int digit = i % 10;
            for (int p = 0; p < j; p++)
            {
                currentResult.Add(0);
            }
            result = AddCurrentResults(result,MultiplyByDigit(array,currentResult, digit));
            currentResult.Clear();
        }
        return result;
    }

    static List<int> MultiplyByDigit(List<int> array, List<int> result, int digit)
    {
        int currentDigit = 0;
        int carry = 0;
        for (int i = 0; i < array.Count; i++)
        {
            currentDigit = array[i] * digit + carry;
            result.Add(currentDigit % 10);
            carry = currentDigit / 10;
        }
        if (carry!=0)
        {
            result.Add(carry);
        }
        return result;
    }

    static List<int> Factorial(int number)
    {
        List<int> fact = new List<int>();
        fact.Add(1);
        for (int i = 1; i <= number; i++)
        {
            fact = MultiplyArrayByNumber(fact, i);
        }
        return fact;
    }

    static void Print(List<int> array)
    {
        for (int i = array.Count-1; i >= 0; i--)
        {
            Console.Write("{0}", array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        for (int i = 1; i < 100; i++)
        {
            Print(Factorial(i));
            Console.WriteLine();
        }
    }
}

