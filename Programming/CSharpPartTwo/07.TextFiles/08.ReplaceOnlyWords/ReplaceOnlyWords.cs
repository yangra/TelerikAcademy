using System;
using System.IO;
using System.Text;
//using System.Text.RegularExpressions;

class ReplaceOnlyWords
{
    static string ToBeChanged = "start";
    static string changeTo = "finish";
    static char[] specialChars = { '.', ',', '!', '?', '\\', '/', ';', ':', '\"', '\'','(',')' };
    
    static string ReplaceWords(string[] text)
    {
        StringBuilder line = new StringBuilder();
        string result = "";
        for (int i = 0; i < text.Length; i++)
        {
            string word = text[i];
            for (int j = 0; j < specialChars.Length; j++)
            {
                word = word.Replace(specialChars[j],' ');
                word = word.Trim(); 
            }
            if (word == ToBeChanged)
            {
                text[i] = text[i].Replace(ToBeChanged, changeTo);
            }
            line.AppendFormat("{0} ", text[i]);
            result = line.ToString();
            result.Trim();
        }
        return result;
    }
    
    static void Main()
    {
        StreamReader reader = new StreamReader(@"../../input.txt");
        using (reader)
        {
            StreamWriter writer = new StreamWriter(@"../../output.txt");
            using (writer)
            {
                for (string line; (line = reader.ReadLine()) != null; )
                {
                    //writer.WriteLine(Regex.Replace(text, @"\bstart\b","finish"));
                    string[] words = line.Split(' ');
                    string changed = ReplaceWords(words);
                    writer.WriteLine(changed);
                }
            }
        }
    }
}
