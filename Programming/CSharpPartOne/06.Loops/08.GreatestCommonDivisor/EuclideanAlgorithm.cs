//Write a program that calculates the greatest common divisor (GCD) of given two 
//numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int numOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number");
        int numTwo = int.Parse(Console.ReadLine());

        if (numOne == numTwo)
        {
            Console.WriteLine("The GCD is: {0}", numOne);
            return;
        }
        if (numOne > numTwo)
        {
            int temp = numTwo;
            numTwo = numOne;
            numOne = temp;  
        }
        
        
        while (numOne != numTwo)
        {
            if (numOne > numTwo)
            {
                int temp = numTwo;
                numTwo = numOne;
                numOne = temp;
            }
           

            numTwo -= numOne;
            
        }
        
        
        Console.WriteLine("The GCD is: {0}", numOne);
    }
}

