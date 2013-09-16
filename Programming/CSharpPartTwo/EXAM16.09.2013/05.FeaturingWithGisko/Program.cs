using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FeaturingWithGrisko
{
    class Program
    {
        static HashSet<string> words = new HashSet<string>();
        static void Swap(ref char a, ref char b)
        {
            if (a == b) return;
            char buffer = a;
            a = b;
            b = buffer;
        }

        static void Permute(char[] array, int begin, int end)
        {
            if (begin == end)
            {
                bool isNotResult = false;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] == array[i-1])
                    {
                        isNotResult = true;
                        break;
                    }
                }
                if (!isNotResult)
                {
                    words.Add(new string(array));
                }
            }
            else
            {
                for (int i = begin; i <= end; i++)
                {
                    Swap(ref array[begin - 1], ref array[i - 1]);
                    Permute(array, begin + 1, end);
                    Swap(ref array[begin - 1], ref array[i - 1]);
                }
            }
        }

        static void Main()
        {
            string input = Console.ReadLine();
            char[] letters = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                letters[i] = input[i];
            }
            bool noRepeat = true;
            
            for (int i = 0; i < letters.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letters[i] == letters[j])
                    {
                        count++;
                    }
                }
                if (count>1)
                {
                    noRepeat = false;
                    break;
                }
            }
            if (noRepeat)
            {
                Console.WriteLine(ReturnCount(letters.Length));
            }
            else
            {
                Permute(letters, 1, letters.Length);
                Console.WriteLine(words.Count);
            }
            
            
        }

        private static int ReturnCount(int numberOfLetters)
        {
            switch (numberOfLetters)
            {
                case 1: return 1;
                case 2: return 2;
                case 3: return 6;
                case 4: return 24;
                case 5: return 120;
                case 6: return 720;
                case 7: return 5040;
                case 8: return 40320;
                case 9: return 362880;
                case 10: return 3628800;
            }
            return -1;
        }

    }
}

    
