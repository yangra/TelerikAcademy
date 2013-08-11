//A dictionary is stored as a sequence of text lines containing words and their explanations. 
//Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//   .NET – platform for applications from Microsoft
//   CLR – managed execution environment for .NET
//   namespace – hierarchical organization of classes

using System;
using System.Text.RegularExpressions;

class Dictionary
{
    static void Main()
    {
        string dictionary =  ".NET – platform for applications from Microsoft" +
                             "/nCLR – managed execution environment for .NET" +
                             "/nnamespace – hierarchical organization of classes";
        string word = "CLR";
        string term = @"(.*) - (.*)";
        var match = Regex.Match(dictionary,term).Groups;

    }
}

