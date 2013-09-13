using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FTML
{
    static StringBuilder coded;
    static bool IsClosing(string tag, int index)
    {
        StringBuilder check = new StringBuilder();
        for (int j = index; j <= index+2; j++)
        {
            check.Append(coded[index]);
        }
        if (check.ToString() == tag)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        coded = new StringBuilder();
        StringBuilder decoded = new StringBuilder();
        for (int i = 0; i < rows; i++)
        {
            coded.AppendLine(Console.ReadLine());
        }
        bool upper = false; //0
        bool lower = false; //1
        bool toggle = false; //2
        bool rev = false; //3
        bool del = false; //4
        Stack<int> modeStack = new Stack<int>();
        for (int i = 0; i < coded.Length; i++)
        {
            StringBuilder text = new StringBuilder();
            if ((upper&&modeStack.Count==0)||(upper&&modeStack.Peek()==0))
            { StringBuilder operation = new StringBuilder();
                while (coded[i]!='<')
                {
                    operation.Append(coded[i]);
                    i++;
                }
                if (IsClosing("upp", i + 2))
                {
                    string upp = operation.ToString().ToUpper();
                    text.Clear();
                    text.Append(upp);
                    i += 6;
                    if (modeStack.Count > 0)
                    {
                        modeStack.Pop();
                    }
                }
                else
                {
                    string upp = text.ToString().ToUpper();
                    text.Clear();
                    
                }
            }
            if ((lower && modeStack.Count == 0) || (lower && modeStack.Peek() == 1))
            {
                while (coded[i]!='<')
                {
                    text.Append(coded[i]);
                    i++;
                }
                string low = text.ToString().ToLower();
                text.Clear();
                text.Append(low);
                i += 6;
            }
            if ((toggle && modeStack.Count == 0) || (toggle && modeStack.Peek() == 2))
            {
                while (coded[i]!='<')
                {
                    if (coded[i]>='a'&&coded[i]<='z')
                    {
                        text.Append(coded[i].ToString().ToUpper());
                        i++;
                    }
                    else if (coded[i]>='A'&&coded[i]<='Z')
                    {
                        text.Append(coded[i].ToString().ToLower());
                        i++;
                    }
                    else
                    {
                        text.Append(coded[i]);
                        i++;
                    }
                    
                }
                i += 7;
            }
            if ((rev && modeStack.Count == 0) || (rev && modeStack.Peek() == 3))
            {
                while (coded[i]!='<')
                {
                    text.Append(coded[i]);
                    i++;
                }
                StringBuilder reversed = new StringBuilder();
                for (int j = text.Length-1; j >=0 ; j--)
                {
                    reversed.Append(text[j]);
                }
                text.Clear();
                text.Append(reversed.ToString());
                i += 4;
            }
            if ((del && modeStack.Count == 0) || (del && modeStack.Peek() == 4))
            {
                while (coded[i]!='<')
                {
                    i++;
                }
                i += 4;
            }
            if (coded[i] == '<')
            {
                StringBuilder check = new StringBuilder();
                for (int j = 1; j <=3; j++)
                {
                    check.Append(coded[i + j]);
                }
                switch (check.ToString())
                {
                    case "upp":
                        upper = true;
                        break;
                    case "low":
                        lower = true;
                        break;
                    case "tog":
                        toggle = true;
                        break;
                    case "rev":
                        rev = true;
                        break;
                    case "del":
                        del = true;
                        break;
                }
            }
        }
    }
}

