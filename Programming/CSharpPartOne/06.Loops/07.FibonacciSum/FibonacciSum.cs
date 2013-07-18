//Write a program that reads a number N and calculates the sum of the first N 
//members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 
//144, 233, 377, …   Each member of the Fibonacci sequence (except the first two) 
//is a sum of the previous two members.

using System;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {
        Console.WriteLine("Please enter a positive number:");
        int numN = int.Parse(Console.ReadLine());
        BigInteger first = 0;
        BigInteger next = 1;
        BigInteger temp = 0;
        BigInteger sum = 1;

        if (numN == 1)
        {
            sum -= 1;
            Console.WriteLine("The sum of first {0} numberes of Fibonacci sequence is {1}", numN, sum);
            return;
        }
         else if (numN == 2)
        {
            Console.WriteLine("The sum of first {0} numberes of Fibonacci sequence is {1}", numN, sum);
            return;
        }

        for (int i = 2; i < numN; i++)
        {
            temp = next;
            next += first;
            first = temp;
            sum += next;
        }    
        Console.WriteLine("The sum of first {0} numberes of Fibonacci sequence is {1}", numN, sum);
    }
}

