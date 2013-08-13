//Write a program that removes from a text file all words listed in given another text file. 
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class RemoveAllWords
{
    static string[] ReadList()
    {
        List<string> list = new List<string>();
        int n = 0;
        string[] result;
        using (StreamReader readWord = new StreamReader(@"../../wordlist.txt"))
        {
            for (string word; (word = readWord.ReadLine()) != null; n++)
            {
                word = word.Trim();
                list.Add(word);
            }
        }
        result = new string[list.Count];
        for (int i = 0; i < list.Count; i++)
        {
            result[i] = list[i];
        }
        return result;
    }

    static void Main()
    {
        try
        {
            string[] wordList = ReadList();
            string pattern = @"\b(" + String.Join("|", wordList) + @")\b";

            using (StreamReader readText = new StreamReader(@"../../text.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"../../output.txt"))
                {
                    for (string line; (line = readText.ReadLine()) != null; )
                    {
                        writer.WriteLine(Regex.Replace(line, pattern, String.Empty));
                    }
                }
            }
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (PathTooLongException ptle)
        {
            Console.WriteLine(ptle.Message);
        }
        catch (IOException ioe)
        {
            Console.WriteLine(ioe.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
    }
}

