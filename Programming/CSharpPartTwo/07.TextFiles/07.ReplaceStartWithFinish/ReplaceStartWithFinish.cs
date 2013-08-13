//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).

using System;
using System.IO;

class ReplaceOnlyWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../input.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"../../output.txt");
            using (writer)
            {
                for (string text; (text = reader.ReadLine()) != null; )
                {
                    writer.WriteLine(text.Replace("start", "finish"));
                }
            }
        }
    }
}
