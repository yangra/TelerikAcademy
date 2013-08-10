using System;
using System.IO;

class CompareFiles
{
    static void Main()
    {
        int lines = 0;
        int sameLines = 0;
        StreamReader reader1 = new StreamReader(@"..\..\..\03.InsertLinenumbers\Program.cs");
        using (reader1)
        {
            StreamReader reader2 = new StreamReader(@"..\..\..\01.OddLines\OddLines.cs");
            using (reader2)
            {
                string lineFirstFile = reader1.ReadLine();
                string lineSecondFile = reader2.ReadLine();

                while (lineFirstFile != null && lineSecondFile != null)
                {
                    lines++;
                    if (lineFirstFile.CompareTo(lineSecondFile) == 0)
                    {
                        sameLines++;
                    }
                    lineFirstFile = reader1.ReadLine();
                    lineSecondFile = reader2.ReadLine();
                }
            }
        }
        Console.WriteLine("Number of same lines: {0}", sameLines);
        Console.WriteLine("Number of different lines: {0}",lines-sameLines);
    }
}

