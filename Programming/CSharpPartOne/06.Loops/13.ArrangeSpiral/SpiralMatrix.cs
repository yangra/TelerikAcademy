//* Write a program that reads a positive integer number N (N < 20) from console and outputs 
//in the console the numbers 1 ... N numbers arranged as a spiral.
//	Example for N = 4
//    1  2  3  4
//   12 13 14  5
//   11 16 15  6
//   10  9  8  7

using System;

class SpiralMatrix
{
    static int origCol;
    static int origRow;
    static int direction = 0;

    static void MoveCursur()
    {
        
       switch (direction % 4)
        {
            case 0:
                break;
            case 1:
                origRow = Console.CursorTop;
                origCol = Console.CursorLeft;
                Console.SetCursorPosition(origCol - 4, origRow + 1);
                break;
            case 2:
                origRow = Console.CursorTop;
                origCol = Console.CursorLeft;
                Console.SetCursorPosition(origCol - 8, origRow);
                break;
            case 3:
                origRow = Console.CursorTop;
                origCol = Console.CursorLeft;
                Console.SetCursorPosition(origCol - 4, origRow - 1);
                break;
        }
        
    }

    static void Main()
    {
        Console.WindowWidth = 120;
        Console.WriteLine("Please enter a number N (N < 20):");
        int numN = int.Parse(Console.ReadLine());
        int number = 1;

        for (int i = 0; i < numN; i++)
        {
            MoveCursur();
            Console.Write("{0,3} ", number);
            //Console.Write(Convert.ToString(number).PadLeft(5, ' '));
            number++;
            
        }
        direction++;
        for (int i = 0; i < numN - 1; i++)
        {
            for (int k = 0; k < numN - i - 1; k++)
            {
                MoveCursur();
                Console.Write("{0,3} ", number);
                //Console.Write(Convert.ToString(number).PadLeft(5, ' '));
                number++;
                
            }
            direction++;
            for (int j = 0; j < numN - i - 1; j++)
            {
                MoveCursur();
                Console.Write("{0,3} ", number);
                //Console.Write(Convert.ToString(number).PadLeft(5, ' '));
                number++;
                
            }
            direction++;
        }
        Console.WriteLine("{0}{0}{0}{0}{0}{0}{0}{0}{0}", Environment.NewLine); 
    }
}

