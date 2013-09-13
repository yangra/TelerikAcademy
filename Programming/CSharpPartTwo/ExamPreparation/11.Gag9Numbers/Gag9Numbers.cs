using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Gag9Numbers
{
    static void Main()
    {
        string[] gagNumbers = new string[9];
        gagNumbers[0] = "-!";
        gagNumbers[1] = "**";
        gagNumbers[2] = "!!!";
        gagNumbers[3] = "&&";
        gagNumbers[4] = "&-";
        gagNumbers[5] = "!-";
        gagNumbers[6] = "*!!!";
        gagNumbers[7] = "&*!";
        gagNumbers[8] = "!!**!-";
        List<int> digits = new List<int>();
        string input = Console.ReadLine();
        for (int i = input.Length - 1; i >= 0; )
        {
            int digit = -1;
            int index;
            List<int> possible = new List<int>();
            StringBuilder check = new StringBuilder();
            for (int j = 0; j < 2; j++)
            {
                check.Append(input[i - j]);
            }
            for (int j = 0; j < 9; j++)
            {
                if (check[0] == gagNumbers[j][gagNumbers[j].Length - 1] 
                 && check[1] == gagNumbers[j][gagNumbers[j].Length - 2])
                {
                    possible.Add(j);
                }
            }
            if (possible.Count == 1)
            {
                digits.Add(possible[0]);
                i -= gagNumbers[digits[digits.Count-1]].Length;
            }
            else
            {
                if (possible.Contains(2))
                {
                    i-=3;
                    if (i == -1)
                    {
                        digits.Add(2);
                        break;
                    }
                    index = i;
                    int count = 0;
                    while(input[index] == '*')
                    {
                        count++;
                        index--;
                        if (index<0)
                        {
                            break;
                        }
                    }
                    if (count%2==0)
                    {
                        digits.Add(2);
                    }
                    else
                    {
                        digits.Add(6);
                        i--;
                    }

                }
                else if (possible.Contains(5))
                {
                    i -= 2;
                    index = i-2;
                    int count = 0;
                    if (input[i]=='*'&&input[i-1]=='*')
                    {
                        while (input[index] == '!')
                        {
                            count++;
                            index--;
                            if (index < 0)
                            {
                                break;
                            }
                        }
                        if (count == 2)
                        {
                            digits.Add(8);
                            i -= 4;
                        }
                        else if (count == 4)
                        {
                            digits.Add(5);
                        }
                        else
                        {
                            digits.Add(5);
                        }
                    }
                    else
                    {
                        digits.Add(5);
                    }
                }
            }
        }
        long answer = 0;
        long stepen9 = 1;
        for (int i = 0; i < digits.Count; i++)
        {
            answer += digits[i] * stepen9;
            stepen9 *= 9;
        }
        Console.WriteLine(answer);
    }
}

