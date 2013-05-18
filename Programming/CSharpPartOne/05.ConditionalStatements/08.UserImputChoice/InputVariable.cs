//Write a program that, depending on the user's choice inputs int, double or string 
//variable. If the variable is integer or double, increases it with 1. If the variable 
//is string, appends "*" at its end. The program must show the value of that variable 
//as a console output. Use switch statement.

using System;

class InputVariable
{
    static void Main()
    {
        byte choice = 0;
        int userInt = 0;
        double userDouble = 0;
        string userStr = "";
        Console.WriteLine("Please enter a number for type of variable");
        Console.WriteLine("1 - (integer) 2 - (real number) 3 - (text)");
        
        while(!byte.TryParse(Console.ReadLine(), out choice) || choice > 3 || choice < 1)
        {
            Console.WriteLine("This is invalid input! Please try again!");
        }

        switch (choice)
	    {
            case 1:
                Console.WriteLine("Please enter an integer:");
                int.TryParse(Console.ReadLine(), out userInt);
                userInt += 1;
                Console.WriteLine(userInt);
                break;
            case 2:
                Console.WriteLine("Please enter a real number:");
                double.TryParse(Console.ReadLine(), out userDouble);
                userDouble += 1;
                Console.WriteLine(userDouble);
                break;
            case 3:
                Console.WriteLine("Please enter text here:");
                userStr = Console.ReadLine();
                userStr = userStr + "*";
                Console.WriteLine(userStr);
                break;
 
	    }
    }
}

