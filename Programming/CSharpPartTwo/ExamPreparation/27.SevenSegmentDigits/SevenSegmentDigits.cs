using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class SevenSegmentDigits
{
    static List<List<int>> possible;
    static int[] variation;
    static string[] answer;
    static long counter = 0;
    static void Main()
    {
        possible = new List<List<int>>();
        long combinations = 1;
        string[] cases = new string[10];
        cases[0] = "1111110";
        cases[1] = "0110000";
        cases[2] = "1101101";
        cases[3] = "1111001";
        cases[4] = "0110011";
        cases[5] = "1011011";
        cases[6] = "1011111";
        cases[7] = "1110000";
        cases[8] = "1111111";
        cases[9] = "1111011";
        int numCount = int.Parse(Console.ReadLine());
        string[] digits = new string[numCount];
        for (int i = 0; i < numCount; i++)
        {
            string number = Console.ReadLine();
            digits[i] = number;
        }
        for (int i = 0; i < digits.Length; i++)
        {
            List<int> pos = new List<int>();
            string currDigit = digits[i];
            for (int j = 0; j < cases.Length; j++)
            {
                bool notACase = false;
                for (int k = 0; k < currDigit.Length; k++)
                {
                    if (currDigit[k] == '1'&&currDigit[k] != cases[j][k])
                    {
                        notACase = true;
                        break;
                    }
                }
                if (!notACase)
                {
                    pos.Add(j); 
                }
            }
            possible.Add(pos);

        }
        for (int i = 0; i < possible.Count; i++)
        {
            combinations *= possible[i].Count; 
        }
        Console.WriteLine(combinations);
        answer = new string[combinations];
        variation = new int[possible.Count];

		Variate(0, possible[0].Count);
        StreamWriter writer = new StreamWriter(@"../../answer.txt");
        using (writer)
        {
            for (int i = 0; i < answer.Length; i++)
            {
                writer.WriteLine(answer[i]);
            }
        }
    }

    static void Variate(int iteration, int firstBoundary)
    {
       
        if (iteration == possible.Count)
        {
            StringBuilder number = new StringBuilder();
            for (int j = 0; j < variation.Length; j++)
            {
                number.Append(variation[j]);
            }
            answer[counter] = number.ToString();
            counter++;
            return;
        }
        for (int j = 0; j < firstBoundary; j++)
        {
            int index = iteration + 1;
            if (index >= possible.Count)
            {
                index = 0;
            }
            variation[iteration] = possible[iteration][j];
            Variate(iteration + 1, possible[index].Count);
        }
    }
}

