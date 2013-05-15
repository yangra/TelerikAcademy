//Declare two string variables and assign them with following value:
//The "use" of quotation causes difficulties.
//Do the above in two different ways: with and without using quoted strings.


using System;

class Quotations
{
    static void Main()
    {
        string quotation1 = "The \"use\" of quotation causes difficulties.";
        string quotation2 = @"The ""use"" of quotation causes difficulties.";
    }
}

