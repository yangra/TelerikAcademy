using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MagicWords
{
    class Program
    {
        static void Main()
        {
            List<string> words = new List<string>();
            int maxLength = int.MinValue;
            int numberOfWords = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfWords; i++)
            {
                words.Add(Console.ReadLine());
                if (maxLength < words[i].Length)
                {
                    maxLength = words[i].Length;
                }
            }
            for (int i = 0; i < words.Count; i++)
            {
                int newIndex = words[i].Length % (words.Count + 1);
                words.Insert(newIndex, words[i]);
                if (newIndex > i)
                {
                    words.RemoveAt(i);
                }
                else
                {
                    words.RemoveAt(i + 1);
                }
            }
            StringBuilder answer = new StringBuilder();
            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (i < words[j].Length)
                    {
                        answer.Append(words[j][i]);
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
