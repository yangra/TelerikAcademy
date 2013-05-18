//We are given 5 integer numbers. Write a program that checks if the sum of some subset 
//of them is 0. Example: 3, -2, 1, 1, 8 -> 1+1-2=0.

using System;

class ZeroSumSubsets
{
    static void Main()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("Enter integer:");
            while (!int.TryParse(Console.ReadLine(), out numbers[i])) 
            {
                Console.WriteLine("You entered an invalid number! Try again!");
            }
        }
        int length = (int)Math.Pow(2,numbers.Length);
        int zeroSumCount = 0;
        int subsetSum = 0;

        for (int i = 1; i < length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                subsetSum += ((i >> j) & 1) * numbers[j];
            }
            if (subsetSum == 0)
            {
                for (int k = 0; k < numbers.Length; k++)
                {
                    subsetSum += ((i >> k) & 1) * numbers[k];
                    if (((i >> k) & 1) > 0)
                    {
                        if (numbers[k] < 0)
                        {
                            Console.Write("\b" + numbers[k]+ "+");
                        }
                        else
                        {
                            Console.Write(numbers[k] + "+");
                        }  
                        
                    }

                }
                Console.WriteLine("\b=0");
                
                zeroSumCount++;
            }
            subsetSum = 0;
        }
        if (zeroSumCount == 0)
        {
            Console.WriteLine("There are no subsets summing to zero!");
        }

    }
}

