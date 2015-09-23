/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;

    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Enter a company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter a company address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter a company phone number(10 digits):");
        string companyNumber= Console.ReadLine();
        Console.WriteLine("Enter a company fax number:");
        string companyFax = null;
        Console.WriteLine("Enter a web site:");
        string webSite = Console.ReadLine();

        Console.WriteLine("Enter a manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter a manager last name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter a manager age:");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter a manager number phone:");
        string managerNumber = Console.ReadLine();

        Console.WriteLine(" Company name- {0}\n Company address- {1}\n Company number- {2}\n Company fax- {3}\n Web sait- {4}\n Manager first name- {5}\n Manager last name- {6}\n Manager age- {7}\n Manager number- {8}\n",companyName,companyAddress,companyNumber,companyFax,webSite,managerFirstName,managerLastName,managerAge,managerNumber);


    }
}

