//Write a program that extracts from given XML file all the text without the tags. 

using System;
using System.Collections;
using System.IO;
using System.Text;

class XMLFile
{
    static void Main()
    {
        StreamReader input = new StreamReader(@"../../input.xml");
        using (input)
        {
            StringBuilder word = new StringBuilder();
            StreamWriter output = new StreamWriter(@"../../output.txt");
            using (output)
            {
                char letter = (char)(input.Read());
                string line = String.Empty;
                while (letter != 65535)
                {
                    word.Clear();
                    line = "";
                    if (letter == '>')
                    {
                        while ((letter = (char)(input.Read())) != 65535 && letter != '<')
                        {
                            word.Append(letter);
                        }
                        line = word.ToString();
                        line = line.Trim();
                        if (!String.IsNullOrEmpty(line))
                        {
                            output.WriteLine(line);   
                        }
                    }
                    letter = (char)(input.Read());
                }
            } 
        }
    }
}