//Sort 3 real values in descending order using nested if statements.

using System;

    class SortValues
{
    static void Main()
    {
        double firstNum;
        double secondNum;
        double thirdNum;
        Console.WriteLine("Enter a real number:");
        while (!double.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.WriteLine("You entered an invalid number, try again!");
        }
        Console.WriteLine("Enter another real number:");
        while (!double.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.WriteLine("You entered an invalid number, try again!");
        }
        Console.WriteLine("Enter third real number:");
        while (!double.TryParse(Console.ReadLine(), out thirdNum))
        {
            Console.WriteLine("You entered an invalid number, try again!");
        }

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("Sorted numbers {0}, {1}, {2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("Sorted numbers {0}, {1}, {2}", firstNum, thirdNum, secondNum);
                }
            }
            else
            {
                Console.WriteLine("Sorted numbers {0}, {1}, {2}", thirdNum, firstNum, secondNum);
            }
        }
        else 
        {
            if (secondNum > thirdNum)
            {
                if (firstNum > thirdNum)
                {
                    Console.WriteLine("Sorted numbers {0}, {1}, {2}", secondNum, firstNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("Sorted numbers {0}, {1}, {2}", secondNum, thirdNum, firstNum);
                }
            }
            else 
            {
                Console.WriteLine("Sorted numbers {0}, {1}, {2}", thirdNum, secondNum, firstNum);
            }
        }
    }
}

