using System;
using System.Collections.Generic;
using System.Text;
 
class KaspichanNumbers
{
    static void Main()
    {
        List<int> digits = new List<int>();
        ulong numberBase10 = ulong.Parse(Console.ReadLine());
        if (numberBase10 == 0)
        {
            digits.Add(0);
        }
        while (numberBase10 > 0)
        {
            digits.Add((int)(numberBase10 % 256));
            numberBase10 /= 256;
        }
        StringBuilder answer = new StringBuilder();
        for (int i = digits.Count - 1; i >= 0; i--)
        {
             
            int firstLetter = digits[i] / 26;
            int secondLetter = digits[i] % 26;
            char firstSymbol = (char)('a' + (firstLetter - 1));
            char secondSymbol = (char)('A' + secondLetter);
            if (firstLetter>0)
            {
                answer.Append(firstSymbol);
                answer.Append(secondSymbol);
            }
            else
            {
                answer.Append(secondSymbol);
            }
        }
        Console.WriteLine(answer);
    }
}

