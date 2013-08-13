//Write a program that deletes from given text file all odd lines. The result should be in the same file.

using System;
using System.IO;
using System.Text;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../text.txt");
        string result;
        using (reader)
        {
            StringBuilder text = new StringBuilder();
            string line = reader.ReadLine();
            int lineNumber = 0;
            while (line != null)
            {
                lineNumber++;
                if (lineNumber%2==0)
                {
                    text.AppendLine(line);
                }
                line = reader.ReadLine();
            }
            result = text.ToString();  
        }
        StreamWriter writer = new StreamWriter(@"../../text.txt");
        using (writer)
        {
            writer.Write(result);
        }
    }
}


