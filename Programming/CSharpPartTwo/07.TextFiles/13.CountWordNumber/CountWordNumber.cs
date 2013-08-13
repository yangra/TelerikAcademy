//Write a program that reads a list of words from a file words.txt and finds how many times each of the words 
//is contained in another file test.txt. The result should be written in the file result.txt and the words 
//should be sorted by the number of their occurrences in descending order. Handle all possible exceptions 
//in your methods.

using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

class CountWordNumber
{
    static int SearchText(string pattern)
    {
        int count = 0;
        using (StreamReader reader = new StreamReader(@"../../test.txt"))
        {
            for (string line; (line = reader.ReadLine()) != null; )
            {
                count += Regex.Matches(line, pattern).Count; 
            }
        }
        return count;
    }

    static void Main()
    {
        try
        {
            string[] list = File.ReadAllLines(@"../../words.txt");
            int[] listCount = new int[list.Length];

            for (int i = 0; i < list.Length; i++)
            {
                string pattern = @"\b(" + list[i][0].ToString().ToUpper() + "|" +
                                          list[i][0].ToString().ToLower() + ")" + list[i].Remove(0, 1) + @"\b";
                listCount[i] = SearchText(pattern);
            }
            Array.Sort(listCount, list);
            using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
            {
                for (int i = list.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine("{0}: {1} time(s)", list[i], listCount[i]);
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
        catch (SecurityException se)
        {
            Console.WriteLine(se.Message);
        }
        catch (UnauthorizedAccessException uae)
        {
            Console.WriteLine(uae.Message);
        }
    }
}

