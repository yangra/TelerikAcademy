﻿//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//Example: The target substring is "in". The text is as follows:
//   We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. 
//   So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9.

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. " +
                      "Inside the submarine is very tight. So we are drinking all the day." +
                      " We will move out of it in 5 days.";
        string sub = "in";
        Console.WriteLine("The result is: {0}", Regex.Matches(text, sub, RegexOptions.IgnoreCase).Count);
    }
}

