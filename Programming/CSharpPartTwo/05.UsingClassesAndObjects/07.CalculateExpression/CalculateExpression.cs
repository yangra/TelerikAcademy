//* Write a program that calculates the value of given arithmetical expression. The expression can contain the 
//following elements only:
//Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//Arithmetic operators: +, -, *, / (standard priorities)
//Mathematical functions: ln(x), sqrt(x), pow(x,y)
//Brackets (for changing the default priorities)
//    Examples:
//    (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)  ~ 10.6
//    pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)  ~ 21.22

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

class CalculateExpression
{
    static List<string> operators = new List<string> { "*", "/", "+", "-" };
    static List<string> functions = new List<string> { "pow", "ln", "sqrt" };
    static List<string> brackets = new List<string> { "(", ")" };

    static string GetNumber(string exp, ref int index, ref bool negative)
    {
        StringBuilder num = new StringBuilder();
        if (negative)
        {
            num.Append("-");
            negative = false;
        }
        num.Append(exp[index]);
        for (int i = index + 1; i < exp.Length && ((exp[i] <= '9' && exp[i] >= '0') || exp[i] == '.'); i++)
        {
            num.Append(exp[i]);
            index++;
        }
        return num.ToString();
    }

    static List<string> ParseExpression(string exp)
    {
        List<string> parsed = new List<string>();
        bool negate = false;
        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '-' && i != exp.Length - 1 && char.IsDigit(exp[i + 1]) && (i == 0 || exp[i - 1] == ',' || exp[i - 1] == '(' || operators.Contains(exp[i - 1].ToString())))
            {
                negate = true;
            }
            else if (char.IsDigit(exp[i]))
            {
                parsed.Add(GetNumber(exp, ref i, ref negate));
            }
            else if (operators.Contains(exp[i].ToString()))
            {
                parsed.Add(exp[i].ToString());
            }
            else if (brackets.Contains(exp[i].ToString()))
            {
                parsed.Add(exp[i].ToString());
            }
            else if (exp[i] == ',')
            {
                parsed.Add(exp[i].ToString());
            }
            else if (i + 1 < exp.Length && exp.Substring(i, 2) == "ln")
            {
                parsed.Add("ln");
                i++;
            }
            else if (i + 2 < exp.Length && exp.Substring(i, 3) == "pow")
            {
                parsed.Add("pow");
                i += 2;
            }
            else if (i + 3 < exp.Length && exp.Substring(i, 4) == "sqrt")
            {
                parsed.Add("sqrt");
                i += 3;
            }
            else
            {
                throw new ArgumentException("Invalid expression!");
            }
        }
        //for (int i = 0; i < parsed.Count; i++)
        //{
        //    Console.WriteLine(parsed[i]);
        //}
        //Console.WriteLine();
        return parsed;
    }

    static int Precedence(string op)
    {
        if (op == "+" || op == "-")
        {
            return 1;
        }
        else if (op == "*" || op == "/")
        {
            return 2;
        }
        else
        {
            throw new ArgumentException("Invalid operator!");
        }
    }

    static Queue<string> ConvertToRPN(List<string> tokens)
    {
        Stack<string> stack = new Stack<string>();
        Queue<string> result = new Queue<string>();

        for (int i = 0; i < tokens.Count; i++)
        {
            double number;
            if (double.TryParse(tokens[i], out number))
            {
                result.Enqueue(tokens[i]);
            }
            else if (functions.Contains(tokens[i]))
            {
                stack.Push(tokens[i]);
            }
            else if (tokens[i] == ",")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Wrong parentheses or misplaced separator!");
                }
                while (stack.Peek() != "(")
                {
                    result.Enqueue(stack.Pop());
                }
            }
            else if (operators.Contains(tokens[i]))
            {
                while (stack.Count != 0 && operators.Contains(stack.Peek()) && Precedence(tokens[i]) <= Precedence(stack.Peek()))
                {
                    result.Enqueue(stack.Pop());
                }
                stack.Push(tokens[i]);
            }
            else if (tokens[i] == "(")
            {
                stack.Push(tokens[i]);
            }
            else if (tokens[i] == ")")
            {
                if (!stack.Contains("(") || stack.Count == 0)
                {
                    throw new ArgumentException("Mismatched parentheses!");
                }
                while (stack.Peek() != "(")
                {
                    result.Enqueue(stack.Pop());
                }
                stack.Pop();
                if (stack.Count != 0 && functions.Contains(stack.Peek()))
                {
                    result.Enqueue(stack.Pop());
                }
            }
        }
        while (stack.Count != 0)
        {
            if (brackets.Contains(stack.Peek()))
            {
                throw new ArgumentException("Mismatched brackets!");
            }
            result.Enqueue(stack.Pop());
        }
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //Console.WriteLine();
        return result;
    }

    static double Evaluate(Queue<string> RPN)
    {
        Stack<double> stack = new Stack<double>();

        while (RPN.Count != 0)
        {
            double number = 0;
            double evaluation = 0;
            string token = RPN.Dequeue();

            if (double.TryParse(token, out number))
            {
                stack.Push(number);
            }
            else
            {
                if (token == "+")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to sum.");
                    }

                    evaluation = stack.Pop() + stack.Pop();
                    stack.Push(evaluation);
                }
                else if (token == "-")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to extract.");
                    }

                    evaluation = -stack.Pop() + stack.Pop();
                    stack.Push(evaluation);
                }
                else if (token == "/")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to divide.");
                    }

                    evaluation = (1 / stack.Pop()) * stack.Pop();
                    stack.Push(evaluation);
                }
                else if (token == "*")
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to multiply.");
                    }

                    evaluation = stack.Pop() * stack.Pop();
                    stack.Push(evaluation);
                }
                else if (token == "pow")
                {

                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to raise to power.");
                    }

                    double secondValue = stack.Pop();
                    double firstValue = stack.Pop();

                    evaluation = Math.Pow(firstValue, secondValue);
                    stack.Push(evaluation);
                }
                else if (token == "sqrt")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to extract square root.");
                    }

                    evaluation = Math.Sqrt(stack.Pop());
                    stack.Push(evaluation);
                }
                else if (token == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Invalid expression! Insufficient number of arguments while trying to extract natural logarithm.");
                    }

                    evaluation = Math.Log(stack.Pop());
                    stack.Push(evaluation);
                }

            }
        }

        if (stack.Count == 1)
        {
            return stack.Pop();
        }
        else
        {
            throw new ArgumentException("Too many values");
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            string expression = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";
            //string expression = "pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3)";

            expression = expression.Replace(" ", String.Empty);

            double result = Evaluate(ConvertToRPN(ParseExpression(expression)));
            Console.WriteLine(result);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}