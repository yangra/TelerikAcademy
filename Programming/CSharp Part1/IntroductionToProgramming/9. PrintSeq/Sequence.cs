using System;

class Sequence
{
    static void Main()
    {
        int num = 2;
        for (int i = 0; i < 10; i++) 
        {
            Console.WriteLine((num+i)*Math.Pow(-1,i));   
        }
    }
}


