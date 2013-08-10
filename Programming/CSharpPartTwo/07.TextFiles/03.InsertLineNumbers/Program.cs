using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../Program.cs");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"../../Output.txt");
            using (writer)
            {
                string line = reader.ReadLine();
                int lineNumber = 0;
                while (line != null)
                {
                    lineNumber++;
                    writer.WriteLine("Line {0}: {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}