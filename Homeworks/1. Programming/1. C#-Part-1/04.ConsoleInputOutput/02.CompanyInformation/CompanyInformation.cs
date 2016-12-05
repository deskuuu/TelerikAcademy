/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;
class CompanyInfo
    {
        static void Main()
        {
          string companyName = Console.ReadLine();
          string companyAddress = Console.ReadLine();
          string companyPhone= Console.ReadLine();
          string companyFax = Console.ReadLine();
          string webSite = Console.ReadLine();
          string managerFirstName = Console.ReadLine();
          string managerLastName = Console.ReadLine();
          int managerAge = int.Parse(Console.ReadLine());
          string managerPhone = Console.ReadLine();
          if (companyFax == string.Empty)
          {
            companyFax = "(no fax)";
          }

          Console.WriteLine("{0}\nAddress: {1}\nTel. {2:+359 ### ## ## ###}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8:+359 # ### ###})",companyName,companyAddress,companyPhone,companyFax,webSite,managerFirstName,managerLastName,managerAge,managerPhone);
    }
}

