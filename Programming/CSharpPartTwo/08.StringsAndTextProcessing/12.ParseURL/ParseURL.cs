//Write a program that parses an URL address given in the format:  [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. 
// For example from the URL http://www.devbg.org/forum/index.php the following 
// information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"

using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        string input = "http://www.devbg.org/forum/index.php";
        string pattern = @"(?<protocol>.*?)://(?<server>.*?)(?<resource>/.*)";
        Console.WriteLine("[protocol] = {0}", Regex.Match(input, pattern).Groups["protocol"]);
        Console.WriteLine("[server] = {0}", Regex.Match(input, pattern).Groups["server"]);
        Console.WriteLine("[resource] = {0}", Regex.Match(input, pattern).Groups["resource"]);

        //string pattern = @"(.*?)://(.*?)(/.*)";
        //var match = Regex.Match(input, pattern);
        //Console.WriteLine("[protocol] = {0}", match.Groups[1]);
        //Console.WriteLine("[server] = {0}", match.Groups[2]);
        //Console.WriteLine("[resource] = {0}", match.Groups[3]);
    }
}

