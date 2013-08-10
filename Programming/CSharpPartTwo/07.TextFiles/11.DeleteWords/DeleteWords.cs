using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWords
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../test.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"../../output.txt");
            using (writer)
            {
                string line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    line = Regex.Replace(line, @"\btest\w*\b", "");
                    writer.WriteLine(line);
                }
            }
        }
    }
}

