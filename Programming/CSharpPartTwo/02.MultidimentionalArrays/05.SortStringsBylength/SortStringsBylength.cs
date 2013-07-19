using System;

class SortStringsBylength
{
    static void Main()
    {
        string[] strArray = {"abd" , "mc","tralala","console","freesbee", "face","cadet", "mojo", "a", "alabalanica"};
        int[] length = new int[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            length[i] = strArray[i].Length;
        }
        Array.Sort(length,strArray);
        Console.WriteLine(String.Join(" ", strArray));
    }
}

