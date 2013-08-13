//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text.txt");
        using (reader)
        {
            int lineNumber = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", lineNumber, line);
                }
                line = reader.ReadLine();
                lineNumber++;
            }
        }
    }
}