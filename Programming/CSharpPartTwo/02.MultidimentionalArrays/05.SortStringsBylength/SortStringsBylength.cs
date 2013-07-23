//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).

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

