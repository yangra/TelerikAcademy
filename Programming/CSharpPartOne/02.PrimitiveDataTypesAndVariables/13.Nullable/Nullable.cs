//Create a program that assigns null values to an integer and to double variables. 
//Try to print them on the console, try to add some values or the null literal to 
//them and see the result.

using System;

class Nullable
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("a = _{0}_, b = _{1}_,", a, b);
        Console.WriteLine("a + 10 = _{0}_", a+10);
        b += null;
        Console.WriteLine("b + null = _{0}_", b);

    }
}

