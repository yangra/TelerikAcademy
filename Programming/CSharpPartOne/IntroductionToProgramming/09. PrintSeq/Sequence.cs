//Write a program that prints the first 10 members of the 
//sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class Sequence
{
    static void Main()
    {
        int num = 2;

        for (int i = 0; i < 10; i++)
        {
            if ((num + i) % 2 == 0)
            {
                Console.WriteLine(num + i);
            }
            else 
            {
                Console.WriteLine((num+i)*(-1));
            }
        }

        //too slow because of Math.Pow
        //for (int i = 0; i < 10; i++) 
        //{
        //    Console.WriteLine((num+i)*Math.Pow(-1,i));   
        //}
    }
}


