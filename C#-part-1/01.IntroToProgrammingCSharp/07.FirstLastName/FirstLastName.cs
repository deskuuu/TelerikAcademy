/*Problem 7. Print First and Last Name

Create console application that prints your first and last name, each at a separate line.
*/
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your first name:");
    	string firstName = Console.ReadLine();
    	Console.WriteLine("Enter your last name:");
    	string lastName = Console.ReadLine();

    	Console.WriteLine("Your name is: {0} {1}", firstName, lastName);
    }
}

