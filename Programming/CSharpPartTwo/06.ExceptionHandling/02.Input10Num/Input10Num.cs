//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:	a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;

class Input10Num
{
    static int ReadNumber(int start, int end)
    {
        if (end < start) 
        {
            throw new ArgumentException("Beginning of the interval was bigger than the end!");
        }
        Console.Write("Please enter a number in the interval [{0}, {1}]:", start, end);
        int number = int.Parse(Console.ReadLine());
        if (number>end||number<start)
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

    static void Main()
    {
        int start = 2;
        int end = 99;
        int index = 0;
        int[] result = new int[10];

        try
        {
            result[0] = ReadNumber(start, end);
            for (index = 1; index < 10; )
            {
                result[index] = ReadNumber(result[index - 1] + 1, end);
                index++;
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(" {0}", result[i]);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number on row {0}!", index + 1);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number on row {0} was out of range!", index + 1);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Number cannot be null!");
        }
        catch (ArgumentException ae)
        {
            throw new ArgumentException("Second boundary of the interval was used as number before the 10th number was reached", ae);
        }
    }
}

