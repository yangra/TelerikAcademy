using System;
using System.Collections.Generic;

class CalculateExpression
{
    static string expression;
    static int size;
    static List<string> RPN;
    static List<double> result;
    static double arg1;
    static double arg2;

    static void ExtractArguments()
    {
        arg2 = result[result.Count - 1];
        arg1 = result[result.Count - 2];
        result.RemoveAt(result.Count - 1);
        result.RemoveAt(result.Count - 1);
    }

    static string ExtractNum(ref string num, ref int index)
    {
        if ((expression[index] >= '0' && expression[index] <= '9')||expression[index]=='.')
        {
            num += expression[index];
            if (index != size - 1 && ((expression[index+1] >= '0' && expression[index+1] <= '9') || expression[index+1] == '.'))
            {
                index++;
                ExtractNum(ref num, ref index);
            }
        }
        return num;
    }

    static void ExtractOperator(ref string op, ref int index, ref List<string> opStack)
    {
        if (expression[index] == '(')
        {
            op += expression[index];
        }
        else if ((expression[index] == '-' && index == 0) || (expression[index] == '-'&&(expression[index+1]>='0'&&expression[index+1]<='9')))
        {
            op = "minus";
        }
        else if (expression[index] == 'p')
        {
            if (opStack.Count!=0&&(opStack[opStack.Count-1]=="log10"||opStack[opStack.Count-1]=="sqrt"||opStack.Count!=0&&opStack[opStack.Count-1]=="minus"))
            {
                RPN.Add(opStack[opStack.Count - 1]);
                opStack.RemoveAt(opStack.Count - 1);
            }
            index += 3;
            op = "pow";
        }
        else if (expression[index] == 'l')
        {
            if (opStack.Count != 0 && (opStack[opStack.Count - 1] == "pow" || opStack[opStack.Count - 1] == "sqrt" || opStack.Count != 0 && opStack[opStack.Count - 1] == "minus"))
            {
                RPN.Add(opStack[opStack.Count - 1]);
                opStack.RemoveAt(opStack.Count - 1);
            }
            index += 2;
            op = "log10";
        }
        else if (expression[index] == 's')
        {
            if (opStack.Count != 0 && (opStack[opStack.Count - 1] == "pow" || opStack[opStack.Count - 1] == "log10" || opStack.Count != 0 && opStack[opStack.Count - 1] == "minus"))
            {
                RPN.Add(opStack[opStack.Count - 1]);
                opStack.RemoveAt(opStack.Count - 1);
            }
            index += 4;
            op = "sqrt";
        }
        else if (expression[index] == ')')
        {
            if (opStack.Count>0&&opStack[opStack.Count-1]=="minus")
            {
                RPN.Add(opStack[opStack.Count - 1]);
                opStack.RemoveAt(opStack.Count - 1);
            }
            if (opStack.Count>0&&!(opStack[opStack.Count-1]=="pow"||opStack[opStack.Count-1]=="log10"||opStack[opStack.Count-1]=="sqrt"))
            {
                while (opStack.Count>0&&opStack[opStack.Count - 1]!="(")
                {
                    RPN.Add(opStack[opStack.Count - 1]);
                    opStack.RemoveAt(opStack.Count - 1);
                }
            }
            else
            {
                RPN.Add(opStack[opStack.Count - 1]);
            }
            opStack.RemoveAt(opStack.Count - 1);
        }
        else if (expression[index] == '/')
        {
            if (opStack.Count!=0&&(opStack[opStack.Count - 1] == "+" || opStack[opStack.Count - 1] == "-"))
            {
                op = "/";
            }
            else if (opStack.Count != 0 && (opStack[opStack.Count - 1] != "("))
            {
                while (opStack.Count != 0 && (opStack[opStack.Count - 1] != "("))
                {
                    RPN.Add(opStack[opStack.Count - 1]);
                    opStack.RemoveAt(opStack.Count - 1);
                }
            }
            op = "/";
        }
        else if (expression[index] == '*')
        {
            if (opStack.Count!=0&&(opStack[opStack.Count - 1] == "+" || opStack[opStack.Count - 1] == "-"))
            {
                op = "*";
            }
            else if (opStack.Count != 0 && (opStack[opStack.Count - 1] != "("))
            {
                while (opStack.Count != 0 && (opStack[opStack.Count - 1] != "("))
                {
                    RPN.Add(opStack[opStack.Count - 1]);
                    opStack.RemoveAt(opStack.Count - 1);
                }
            }
            op = "*";
        }
        else if (expression[index] == '+')
        {
            while (opStack.Count != 0 && (opStack[opStack.Count - 1] != "("))
            {
                RPN.Add(opStack[opStack.Count - 1]);
                opStack.RemoveAt(opStack.Count - 1);  
            }
            op = "+";
        }
        else if (expression[index] == '-')
        {
            while (opStack.Count != 0 && (opStack[opStack.Count - 1] != "("))
            {
                RPN.Add(opStack[opStack.Count - 1]);
                opStack.RemoveAt(opStack.Count - 1);
            }
                op = "-"; 
        }

    }

    static void Main()
    {
        expression = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";
        //expression = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";
        size = expression.Length;
        RPN = new List<string>();
        result = new List<double>();
        List<string> opStack = new List<string>();
        for (int i = 0; i < size; i++)
        {
            string item = "";
            ExtractNum(ref item, ref i);
            if (item.Length>0)
            {
                RPN.Add(item);
            }
            else
            {
                ExtractOperator(ref item, ref i, ref opStack);
                if (item.Length>0)
                {
                    opStack.Add(item);
                }  
            }   
        }
        for (int i = opStack.Count - 1; i >= 0; i--)
        {
            RPN.Add(opStack[i]);
        }

        //for (int i = 0; i < RPN.Count; i++)
        //{
        //    Console.WriteLine(" {0}", RPN[i]);
        //}

        for (int i = 0; i < RPN.Count; i++)
        {
            if (RPN[i]!="log10"&&RPN[i]!="pow"&&RPN[i]!="sqrt"&&RPN[i]!="/"&&RPN[i]!="*"&&RPN[i]!="minus"&&RPN[i]!="+"&&RPN[i]!="-")
            {
                result.Add(double.Parse(RPN[i]));
            }
            else if (RPN[i]=="minus")
            {
                result[result.Count - 1] *= -1;
            }
            else if (RPN[i]=="log10")
            {
                result[result.Count - 1] = Math.Log(result[result.Count - 1], Math.E);
            }
            else if (RPN[i] == "sqrt")
            {
                result[result.Count - 1] = Math.Sqrt(result[result.Count - 1]);
            }
            else if (RPN[i] == "pow")
            {
                ExtractArguments();
                result.Add(Math.Pow(arg1,arg2));
            }
            else if (RPN[i] == "/")
            {
                ExtractArguments();
                result.Add(arg1/ arg2);
            }
            else if (RPN[i] == "*")
            {
                ExtractArguments();
                result.Add(arg1* arg2);
            }
            else if (RPN[i] == "+")
            {
                ExtractArguments();
                result.Add(arg1 + arg2);
            }
            else if (RPN[i] == "-")
            {
                ExtractArguments();
                result.Add(arg1 - arg2);
            }
        }
        Console.WriteLine(result[0]);
        

    }
}
