using System;
using System.Collections.Generic;
using System.Text;

class ConsoleJustification
{
    static void Main()
    {
        int numberOflines = int.Parse(Console.ReadLine());
        int symboLimit = int.Parse(Console.ReadLine());
        Queue<string> words = new Queue<string>();
        List<string> lines = new List<string>();
        for (int i = 0; i < numberOflines; i++)
        {
            string[] rawText = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < rawText.Length; j++)
            {
                words.Enqueue(rawText[j]);
            }
        }
        while (words.Count > 0)
        {
            StringBuilder line = new StringBuilder();
            List<int> wordLength = new List<int>();
            int count = 0;
            while (words.Count > 0)
            {
                string word = words.Peek();
                if (count + word.Length + 1 <= symboLimit + 1)
                {
                    count += word.Length + 1;
                    line.Append(words.Dequeue());
                    line.Append(" ");
                    if (words.Count==0)
                    {
                        line.Remove(count - 1, 1);
                        count--;
                    }
                    wordLength.Add(word.Length+1);
                }
                else
                {
                    line.Remove(count - 1, 1);
                    count--;
                    break;
                }
            }
            int iteration = 0;
            while (count != symboLimit)
            {
                if (wordLength.Count == 1)
                {
                    break;
                }
                int index = 0;
                iteration++;
                for (int i = 0; i < wordLength.Count - 1; i++)
                {
                    count++;
                    index += wordLength[i];
                    line.Insert(index, " ");
                    wordLength[i]++;
                    index++;
                    if (count == symboLimit)
                    {
                        break;
                    }
                }
            }
            lines.Add(line.ToString());
        }
        for (int i = 0; i < lines.Count; i++)
        {
            Console.WriteLine(lines[i]); 
        }
    }
}

