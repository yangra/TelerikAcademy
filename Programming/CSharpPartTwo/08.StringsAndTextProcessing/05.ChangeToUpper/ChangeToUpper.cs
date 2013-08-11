//You are given a text. Write a program that changes the text in all regions surrounded 
//by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
//   We are living in a <upcase>yellow submarine</upcase>. 
//   We don't have <upcase>anything</upcase> else.
//The expected result:
//   We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;

class ChangeToUpper
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. " +
                      "We don't have <upcase>anything</upcase> else.";
        while (text.IndexOf('<') != -1)
        {
            int index = text.IndexOf("<upcase>");
            text = text.Remove(index, 8);
            string sub = text.Substring(index, text.IndexOf("</upcase>") - index);
            string upper = sub.ToUpper();
            text = text.Replace(sub, upper);
            text = text.Remove(text.IndexOf('<'), 9);
        }
        Console.WriteLine(text);

    }
}

