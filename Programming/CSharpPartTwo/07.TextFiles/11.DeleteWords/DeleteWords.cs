//Write a program that deletes from a text file all words that start with the prefix "test". 
//Words contain only the symbols 0...9, a...z, A…Z, _.

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

