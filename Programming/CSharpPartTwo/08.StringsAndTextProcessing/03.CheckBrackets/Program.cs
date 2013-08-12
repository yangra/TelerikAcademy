//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

using System;

class Program
{
    static void BracketCheck(string exp)
    {
        int stack = 0;
        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == '(')
            {
                stack++;
            }
            else if (exp[i] == ')')
            {
                if (stack > 0)
                {
                    stack--;
                }
                else
                {
                    throw new ArgumentException("Incorrect brackets!");
                }
            }
        }
    }

    static void Main(string[] args)
    {
        try
        {
            //string expression = "((a+b)/5-d)";
            //string expression = ")(a+b))";
            string expression = "(a+b))(";
            BracketCheck(expression);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
    }
}

