//Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//Use Windows Character Map to find the Unicode code of the © symbol. 
//Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class CopyRightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copy = '\u00a9';

        Console.WriteLine("Please enter number of rows (3-20):");
        int numberOfRows = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfRows; i++)
        {
            Console.Write(new string(' ',numberOfRows-i));
            Console.Write(new string (copy,i+1));
            Console.WriteLine(new string(copy,i));
        }
        
    }
}

