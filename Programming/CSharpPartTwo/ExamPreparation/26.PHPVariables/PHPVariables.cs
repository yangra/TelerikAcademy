//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;
//namespace PHPConverter
//{
//    //public class alphabeticalClass : IComparer
//    //{
//    //    int Icomparer.Compare(Object x, Object y)
//    //    {
//    //        return ((new Case
//    //    }
//    //}

//    class PHPVariables
//    {
//        static void Main()
//        {
//            List<string> code = new List<string>();
//            //string varPattern = @"(?<!\\.*?)(?<=\$)\w+";
//            string varPattern = @"(?<=\$)\w+";
//            //string lineComment = @"\#";
//            //string lineComment2 = @"//";
//            //string longComment = @"/\*";
//            //string endLongComment = @"\*/";
//            //string singleQuote = @"'";
//            //string doubleQuote = @"""";
//            //StringBuilder var = new StringBuilder();
//            List<string> variables = new List<string>();
//            while (true)
//            {
//                string line = Console.ReadLine();
//                if (line == "?>")
//                {
//                    break;
//                }
//                code.Add(line);
//            }
//            bool multilineComment = false;
//            bool insideStringDQuote = false;
//            bool insideStringQuote = false;
//            for (int i = 0; i < code.Count; i++)
//            {
//                for (int j = 0; j < code[i].Length; j++)
//                {
//                    string currentRow = code[i];
//                    if (multilineComment)
//                    {
//                        while (currentRow[j] != '*' && j < currentRow.Length - 1)
//                        {
//                            j++;
//                        }
//                        if (j < currentRow.Length - 1 && currentRow[j] == '*')
//                        {
//                            if (currentRow[j + 1] == '/')
//                            {
//                                multilineComment = false;
//                            }
//                            j++;
//                        }
//                        else
//                        {
//                            break;
//                        }

//                    }
//                    else if (currentRow[j] == '/' && j != currentRow.Length - 1 && !insideStringDQuote && !insideStringQuote)
//                    {
//                        if (currentRow[j + 1] == '*')
//                        {
//                            multilineComment = true;
//                            while (currentRow[j] != '*' && j < currentRow.Length - 1)
//                            {
//                                j++;
//                            }
//                            if (j < currentRow.Length - 1 && currentRow[j] == '*')
//                            {
//                                if (currentRow[j + 1] == '/')
//                                {
//                                    multilineComment = false;
//                                }
//                                j++;
//                            }
//                            else
//                            {
//                                break;
//                            }

//                        }
//                        else if (currentRow[j + 1] == '/')
//                        {
//                            break;
//                        }
//                    }
//                    else if (currentRow[j] == '"')
//                    {
//                        if (insideStringDQuote&&currentRow[j-1]!='\\')
//                        {
//                            insideStringDQuote = false;
//                        }
//                        else
//                        {
//                            insideStringDQuote = true;
//                        }
//                    }
//                    else if (currentRow[j] == '\'')
//                    {
//                        if (insideStringQuote && currentRow[j - 1] != '\\')
//                        {
//                            insideStringQuote = false;
//                        }
//                        else
//                        {
//                            insideStringQuote = true;
//                        }
//                    }
//                    else if (currentRow[j] == '#' && !insideStringDQuote && !insideStringQuote)
//                    {
//                        break;
//                    }
//                    else
//                    {
//                        if (currentRow[j] == '$')
//                        {
//                            if (j != 0 && currentRow[j - 1] == '\\')
//                            {
//                                continue;
//                            }
//                            else
//                            {

//                                string toEnd = currentRow.Substring(j);
//                                Match variable = Regex.Match(toEnd, varPattern);
//                                j += variable.ToString().Length;
//                                bool used = false;
//                                string[] vars = variables.ToArray();
//                                if (Array.BinarySearch(vars, variable.ToString()) >= 0)
//                                {
//                                    used = true;
//                                }
//                                if (!used)
//                                {
//                                    variables.Add(variable.ToString());
//                                }
//                                variables.Sort();
//                            }
//                        }
//                    }
//                }
//            }
//            variables.Sort(StringComparer.Ordinal);
//            Console.WriteLine(variables.Count);
//            for (int i = 0; i < variables.Count; i++)
//            {
//                Console.WriteLine(variables[i]);
//            }
//        }
//    }

//}
using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

class PHPVariables
{
    static void Main(string[] args)
    {
        string input;
        string line;
        StringBuilder builder = new StringBuilder();
        do
        {
            line = Console.ReadLine();
            builder.Append(line);
            builder.AppendLine();
        }
        while (line != "?>");
        input = builder.ToString();

        int mode = 0;
        /* 1. comment
         * 2. multiline comment
         * 3. string '
         * 4. string "
         * 5. text in array '
         * 6. text in array "
         */

        StringBuilder currentVarBuilder = new StringBuilder();
        string variable;
        SortedSet<string> allVariables = new SortedSet<string>(StringComparer.Ordinal);
        for (int i = 0; i < input.Length; i++)
        {
            //opening
            if (mode == 0 && input[i] == '/' && input[i + 1] == '/')
            {
                mode = 1;
                i++;
            }
            else if (mode == 0 && input[i] == '#')
            {
                mode = 1;
            }
            else if (mode == 0 && input[i] == '/' && input[i + 1] == '*')
            {
                mode = 2;
                i++;
            }
            else if (mode == 0 && input[i] == '\'')
            {
                mode = 3;
            }
            else if (mode == 0 && input[i] == '"')
            {
                mode = 4;
            }
            //else if (mode == 0 && input[i] == '[')
            //{
            //    if (input[i+1]=='\'')
            //    {
            //        mode = 5;
            //        i++;
            //    }
            //    else if (input[i] == '"')
            //    {
            //        mode = 6;
            //        i++;
            //    }
            //}
            //closing
            else if (mode == 1 && input[i] == '\n')
            {
                mode = 0;
            }
            else if (mode == 2 && input[i] == '*' && input[i + 1] == '/')
            {
                mode = 0;
                i++;
            }
            else if (mode == 3 && input[i] == '\'' && !CheckIfCharIsEscaped(ref input, i))
            {
                mode = 0;
            }
            else if (mode == 4 && input[i] == '"' && !CheckIfCharIsEscaped(ref input, i))
            {
                mode = 0;
            }
            //else if (mode == 5 && input[i] == '\'' && !CheckIfCharIsEscaped(ref input, i))
            //{
            //    mode = 0;
            //}
            //else if (mode == 6 && input[i] == '"' && !CheckIfCharIsEscaped(ref input, i))
            //{
            //    mode = 0;
            //}
            else if ((mode == 0 || mode == 3 || mode == 4) && input[i] == '$' && !CheckIfCharIsEscaped(ref input, i))
            {
                i++;
                currentVarBuilder.Clear();
                do
                {
                    currentVarBuilder.Append(input[i]);
                    i++;
                }
                while (Char.IsLetterOrDigit(input[i]) || input[i] == '_');
                i--;
                variable = currentVarBuilder.ToString();
                allVariables.Add(variable);
            }
        }

        StringBuilder output = new StringBuilder();
        output.AppendLine(allVariables.Count.ToString());
        foreach (string variableToPrint in allVariables)
        {
            output.AppendLine(variableToPrint);
        }
        Console.WriteLine(output.ToString().TrimEnd());

    }

    static bool CheckIfCharIsEscaped(ref string input, int index)
    {
        int numberOfSlashes = 0;
        index--;
        while (input[index] == '\\')
        {
            numberOfSlashes++;
            index--;
        }
        if (numberOfSlashes % 2 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}


