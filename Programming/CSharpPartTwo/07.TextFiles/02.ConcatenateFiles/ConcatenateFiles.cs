using System;
using System.IO;

class ConcatenateFiles
{
    static void WriteToFile(StreamWriter writer, string file)
    {
        StreamReader reader = new StreamReader(file);
        using (reader)
        {
            string line  = reader.ReadLine();
            while ( line != null )
            {
                writer.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }

    static void Main()
    {
        string[] files = { @"../../ConcatenateFiles.cs", @"../../ConcatenateFiles.cs" };

        StreamWriter writer = new StreamWriter(@"../../result.txt");
        using (writer)
        {
            foreach (var file in files)
            {
                WriteToFile(writer, file);
            }
        }
    }
}