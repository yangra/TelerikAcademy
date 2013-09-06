using System;
using System.Collections.Generic;
using System.Text;

class CSharpBrackets
{
    static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        string indent = Console.ReadLine();
        List<string> result = new List<string>();
        for (int i = 0; i < lines; i++)
        {
            string line = Console.ReadLine();
            int index = 0;
            int obrack = 0;
            int cbrack = 0;
            while (line.Contains("{") || line.Contains("}"))
            {
                if (line.Contains("{"))
                {
                   obrack = line.IndexOf('{'); 
                }
                else
                {
                    obrack = int.MaxValue; 
                }
                if (line.Contains("}"))
                {
                    cbrack = line.IndexOf('}');
                }
                else
                {
                    cbrack = int.MaxValue;
                } 
                    index = Math.Min(obrack,cbrack);
                    if (index > 0)
                    {
                        string code = line.Substring(0, index);
                        string[] text = code.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < text.Length; j++)
                        {
                            result.Add(text[j]);
                        }
                    }
                    if (index == obrack)
                    {
                        result.Add("{");
                        line = line.Substring(index + 1);
                        index = 0;
                    }
                    else
                    {
                        result.Add("}");
                        line = line.Substring(index + 1);
                        index = 0;
                    }

            }
            if (line.Length>0)
            {
                string[] coding = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < coding.Length; j++)
                {
                    result.Add(coding[j]);
                }
                result.Add("##true");
            }
        }
        List<string> answer = new List<string>();
        StringBuilder coded = new StringBuilder();
        int step = 0;
        for (int i = 0; i < result.Count; i++)
        {
            if (result[i] != "{" && result[i] != "}" && result[i] != "##true")
            {
                coded.Append(result[i]+" ");
            }
            else if (result[i] =="{")
            {
                if (i != 0 && result[i - 1] != "}" && result[i - 1] != "{" && result[i-1] != "##true")
                {
                    coded.Remove(coded.Length - 1, 1);
                    answer.Add(GetIndent(step,indent) + coded.ToString());
                    coded.Clear();
                }
                answer.Add(GetIndent(step, indent) + "{");
                step++;
            }
            else if (result[i] =="}")
            {
                if (i != 0 && result[i - 1] != "{" && result[i - 1] != "}" && result[i-1] != "##true")
                {
                    coded.Remove(coded.Length - 1, 1);
                    answer.Add(GetIndent(step,indent) + coded.ToString());
                    coded.Clear();
                }
                step--;
                answer.Add(GetIndent(step, indent) + "}");
            }
            else if (result[i] == "##true")
            {
                if (i != 0 && result[i - 1] != "{" && result[i - 1] != "}" && result[i - 1] != "##true")
                {
                    coded.Remove(coded.Length - 1, 1);
                    if (String.IsNullOrWhiteSpace(coded.ToString()))
                    {
                        coded.Clear();
                    }
                    else
                    {
                        answer.Add(GetIndent(step, indent) + coded.ToString());
                        coded.Clear();
                    }
                }
            }
        }
        for (int i = 0; i < answer.Count; i++)
        {
            Console.WriteLine(answer[i]);
        }
    }
    
    static string GetIndent(int step, string indent)
    {
        string space= "";
        for (int i = 0; i < step; i++)
        {
            space += indent;
        }
        return space;
    }
}

