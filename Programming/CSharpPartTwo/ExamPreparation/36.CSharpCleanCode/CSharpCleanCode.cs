﻿using System;
using System.Collections.Generic;
using System.Text;

class CSharpCleanCode
{
    static void Main()
    {
        StringBuilder line = new StringBuilder();
        List<string> result = new List<string>();
        int numberOfLines = int.Parse(Console.ReadLine());
        int mode = 0;
        /*0 - normal
         *1 - multiline comment
         *2 - string
         *3 - multiline string
         *4 - char
         */

        for (int i = 0; i < numberOfLines; i++)
        {
            string input = Console.ReadLine();
            for (int j = 0; j < input.Length; j++)
            {
                if (mode == 0 && input[j] == '/' && j < input.Length - 1 && input[j + 1] == '/')
                {
                    if (j + 2 < input.Length && input[j + 2] == '/')
                    {
                        line.Append("///");
                        j += 2;
                        continue;
                    }
                    if (!String.IsNullOrWhiteSpace(line.ToString()))
                    {
                        result.Add(line.ToString());
                    }
                    line.Clear();
                    break;
                }
                else if (mode == 0 && input[j] == '/' && j < input.Length - 1 && input[j + 1] == '*')
                {
                    mode = 1;
                    j++;
                }
                else if (mode == 0 && input[j] == '"')
                {
                    line.Append(input[j]);
                    mode = 2;
                }
                else if (mode == 0 && input[j] == '\'')
                {
                    line.Append(input[j]);
                    mode = 4;
                }
                else if (mode == 0 && input[j] == '@')
                {
                    line.Append(input[j]);
                    j++;
                    line.Append(input[j]);   //append the following "
                    if (j == input.Length - 1)
                    {
                        if (!String.IsNullOrWhiteSpace(line.ToString()))
                        {
                            result.Add(line.ToString());
                        }
                        line.Clear();
                    }
                    mode = 3;
                }
                else if (mode == 1)
                {
                    while (j < input.Length && input[j] != '*')
                    {
                        j++;
                    }
                    if (j >= input.Length - 1)
                    {
                        break;
                    }
                    else if (input[j + 1] == '/')
                    {
                        j++;
                        mode = 0;
                        if (j == input.Length - 1)
                        {
                            if (!String.IsNullOrWhiteSpace(line.ToString()))
                            {
                                result.Add(line.ToString());
                            }
                            line.Clear();
                            break;
                        }
                    }
                }
                else if (mode == 2 && input[j] == '"' && !IsEscaped(input, j))
                {
                    line.Append(input[j]);
                    mode = 0;
                }
                else if (mode == 3 && input[j] == '"' && !IsQuoteEscaped(input, ref j, ref line))
                {
                    line.Append(input[j]);
                    mode = 0;
                    if (j == input.Length - 1)
                    {
                        if (!String.IsNullOrWhiteSpace(line.ToString()))
                        {
                            result.Add(line.ToString());
                        }
                        line.Clear();
                    }
                }
                else if (mode == 4 && input[j] == '\'' && !IsEscaped(input, j))
                {
                    line.Append(input[j]);
                    mode = 0;
                }
                else if (mode == 0 || mode == 2 || mode == 3 || mode == 4)
                {
                    line.Append(input[j]);
                    if (j == input.Length - 1)
                    {
                        if (!String.IsNullOrWhiteSpace(line.ToString()))
                        {
                            result.Add(line.ToString());
                        }
                        line.Clear();
                    }
                }
            }
        }
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }

    }

    static bool IsEscaped(string input, int j)
    {
        int count = 0;
        if (j > 0)
        {
            while (input[j - 1] == '\\')
            {
                count++;
                j--;
                if (j == 0)
                {
                    break;
                }
            }
        }
        if (count % 2 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    static bool IsQuoteEscaped(string input, ref int j, ref StringBuilder line)
    {
        int count = 1;
        if (j < input.Length - 1)
        {
            while (input[j + 1] == '"')
            {
                count++;
                j++;
                line.Append(input[j]);
                if (j == input.Length - 1)
                {
                    break;
                }
            }
        }
        if (count % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}


