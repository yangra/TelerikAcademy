//* Write a program that calculates for given N how many trailing zeros present at the 
//end of the number N!. Examples:
//    N = 10 -> N! = 3628800 -> 2
//    N = 20 -> N! = 2432902008176640000 -> 4
//Does your program work for N = 50 000?
//Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. 
//Think why!

using System;

class CountTrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Please enter a number N (N > 0):");
        int numN = int.Parse(Console.ReadLine());

        int NumberOfTrailingZeroes = 0;
        int powerOfFive = 1;

        
        for (int i = 1; i < numN; i++)
        {               
            powerOfFive *= 5;
            NumberOfTrailingZeroes += numN / powerOfFive;
            if (numN / powerOfFive == 0)
            {
                break;
            }
        }
        Console.WriteLine("Number of trailing zeroes is: {0}", NumberOfTrailingZeroes);
            
        
    }
}

