//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program 
//that reads the information about a company and its manager and prints them on 
//the console.

using System;

class ReadCompanyData
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address:");
        string companyAddress = Console.ReadLine();
        int companyPhone;
        Console.WriteLine("Company phone (9 digits):");
        while (!int.TryParse(Console.ReadLine(), out companyPhone)
            ||companyPhone < 100000000 || companyPhone > 999999999)
        {
            Console.WriteLine("You entered an invalid number. Please try again");
            Console.WriteLine("Company phone (9 digits):");
        }
        int companyFax;
        Console.WriteLine("Company fax (9 digits):");
        while (!int.TryParse(Console.ReadLine(), out companyFax)
            || companyFax < 100000000 || companyFax > 999999999)
        {
            Console.WriteLine("You entered an invalid number. Please try again");
            Console.WriteLine("Company fax (9 digits):");
        }
        Console.WriteLine("Company website:");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine("Company manager:");
        string companyManager = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string managerLastName = Console.ReadLine();
        byte managerAge;
        Console.WriteLine("Manager age:");
        while (!byte.TryParse(Console.ReadLine(), out managerAge)
         || managerAge < 18 || managerAge > 100)
        {
            Console.WriteLine("You entered an invalid number. Please try again");
            Console.WriteLine("Manager age (9 digits):");
        }
        int managerPhone;
        Console.WriteLine("Manager phone (9 digits):");
        while (!int.TryParse(Console.ReadLine(), out managerPhone)
         || managerPhone < 100000000 || managerPhone > 999999999)
        {
            Console.WriteLine("You entered an invalid number. Please try again");
            Console.WriteLine("Manager phone (9 digits):");
        }

        Console.WriteLine("Company: {0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Phome number: {0:###-##-##-##}", companyPhone);
        Console.WriteLine("Fax number: {0:###-##-##-##}", companyFax);
        Console.WriteLine("Website: {0}", companyWebSite);
        Console.WriteLine("Manager: {0}", companyManager);
        Console.WriteLine("First name: {0}", managerFirstName);
        Console.WriteLine("Last name: {0}", managerLastName);
        Console.WriteLine("Age: {0} years old", managerAge);
        Console.WriteLine("Phone number: {0:###-##-##-##}", managerPhone);


    }
}