using System;
using System.Collections.Generic;
using System.IO;

class SortList
{
    static List<string> ReadList(string file)
    {
        StreamReader reader = new StreamReader(file);
        using (reader)
        {
            List<string> list = new List<string>();
            string item = reader.ReadLine();
            while (item != null)
            {
                list.Add(item);
                item = reader.ReadLine();
            }
            return list;
        }
    }

    static void WriteList(List<string> list, string file)
    {
        StreamWriter writer = new StreamWriter(file);
        using (writer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
            }
        }
    }

    static void Main()
    {
       List<string> list = ReadList(@"../../unsorted.txt");
       list.Sort();
       WriteList(list, @"../../sorted.txt");
    }
}

