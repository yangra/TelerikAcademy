//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

using System;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = 10000000;
        int counter = 0;
        bool[] array = new bool[n];
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            if (!array[i])
            {
                for (int j = i * i; j < n; j += i)
                {
                    array[j] = true;
                }
            }
        }
        for (int i = 2; i < array.Length; i++)
        {
            if (!array[i])
            {
                counter++;
            }
        }
        Console.WriteLine("The number of primes in the interval [1, 10 000 000] is : {0}", counter);
    }
}

