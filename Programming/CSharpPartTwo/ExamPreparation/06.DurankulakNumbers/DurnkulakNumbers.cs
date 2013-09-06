using System;
using System.Collections.Generic;
using System.Numerics;

class DurnkulakNumbers
{
    static void Main()
    {
        checked
        {
            string input = Console.ReadLine();
            int index = 0;
            List<int> digits = new List<int>();
            BigInteger result = 0;
            while (index < input.Length)
            {
                if ((int)(input[index]) > 96)
                {
                    int coef = (int)(input[index]) - (int)('a') + 1;
                    int number = coef * 26 + ((int)(input[index + 1]) - (int)('A'));
                    digits.Add(number);
                    index += 2;
                }
                else
                {
                    int number = (int)(input[index]) - (int)('A');
                    digits.Add(number);
                    index++;
                }
            }
            BigInteger order = 1;
            for (int i = digits.Count - 1; i >= 0; i--)
            {
                result += digits[i] * order;
                order *= 168;
            }
            Console.WriteLine(result);
        }
    }
}

